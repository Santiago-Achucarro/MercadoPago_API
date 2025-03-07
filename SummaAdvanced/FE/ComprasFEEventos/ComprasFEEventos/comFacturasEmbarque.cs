using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
namespace ComprasFEEventos
{
    public class comFacturasEmbarque
    {
        [Generalidades.QFuncion_Condicion]
        public string EsMonedaBase(ComprasCommon.comFacturasConOrdenDeEmbarqueDS exch, Command cmd)
        {
            if (exch.Principal[0].Moneda_Id == cmd.MonedaBase || exch.Principal[0].Moneda_Id.Trim() == "")
                return "S";

            return "N";

        }

        [Generalidades.QFuncion_Condicion]
        public string PideCuotas(ComprasCommon.comFacturasConOrdenDeEmbarqueDS exch, Command cmd)
        {

            return exch.Principal[0].CantCuotas > 1 ? "S" : "N";

        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaImp(ComprasCommon.comFacturasConOrdenDeEmbarqueDS exch, ComprasCommon.comFacturasConOrdenDeEmbarqueDS exchNoPost,
           int pIndice, Command cmd)
        {
            ComprasCommon.comFacturasConOrdenDeEmbarqueDS.ImpuestosDataTable lDF = exchNoPost.Impuestos;

            if (lDF[0].Impuesto_Id == "")
                return "El_Impuesto_No_puede_ser_Vacio";


            return "";
        }
        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comFacturasConOrdenDeEmbarqueDS CalcularImpuestos(ComprasCommon.comFacturasConOrdenDeEmbarqueDS exch, ComprasCommon.comFacturasConOrdenDeEmbarqueDS exchNoPost,
           int pIndice, Command cmd)
        {

            // TODO FM Ver de dónde sacamos la cantidad de dígitos
            int lDigitos = 2;
            
            ComprasCommon.comFacturasConOrdenDeEmbarqueDS.ImpuestosDataTable lDF = exchNoPost.Impuestos;

            ComprasExchange.comImpuestosActionExchange exchImp = new ComprasExchange.comImpuestosActionExchange
                (ComprasExchange.comImpuestosActionEnum.EnumcomImpuestosAction.Datos);
            exchImp.Impuesto_Id = lDF[0].Impuesto_Id;

            exchImp = new ComprasExchange.comImpuestosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                (new Exchange(exchImp), cmd));

            if (exchNoPost.Impuestos[0].Porcentaje == 0)
                // Asigno el porcentaje si está en 0. Si es distinto de cero que no cambie por si el usuario lo editó //
                exchNoPost.Impuestos[0].Porcentaje = exchImp.Porcentaje;
            exchNoPost.Impuestos[0].Cuenta_Id = exchImp.CtaDebe;

            // FM Si cambio el porcentaje que calculo siempre el impuesto y no solo si estoy dando //
            // de alta un nuevo impuesto. Comento el if de abajo //

            // Calculo el importe del impuesto solo si estoy insertando un nuevo renglón //
            //if (pIndice == -1)
            //{
            if (exchImp.Formulacalc == "")
            {
                exchNoPost.Impuestos[0].Importe_Impuesto = Generalidades.Auxiliares.Redondear
                    (lDF[0].Base_Imponible * exchImp.Porcentaje, lDigitos);
            }
            else
            {
                ComprasExchange.comMovProvDatosSinStockActionExchange exchCMPST =
                    new ComprasExchange.comMovProvDatosSinStockActionExchange
                    (ComprasExchange.comMovProvDatosSinStockActionEnum.EnumcomMovProvDatosSinStockAction.CalcularImpuesto);

                exchCMPST.Param.Merge(exch);
                exchCMPST.Param.Principal[0].Delete();

                // Tomo siempre el porcentaje desde la grilla porque si está editando un renglón existente está bien //
                // Y si está editando uno nuevo, ya copió el valor del impuesto a la grilla //

                // Agrego el renglón no posteado al Exchange para que haga el cálculo del impuesto //
                exchCMPST.Param.grdImpuestos.Clear();
                exchCMPST.Param.grdImpuestos.AddgrdImpuestosRow(0, 0, exchImp.Impuesto_Id, "",
                    exchNoPost.Impuestos[0].Porcentaje, lDF[0].Base_Imponible, 0, "", "", "", "", "", "", 0, "", 0);
                exchCMPST.Param.grdImpuestos.AcceptChanges();

                exchCMPST = new ComprasExchange.comMovProvDatosSinStockActionExchange
                    (Generalidades.QBIInternal.WrapperExecuteActionInternal(new Exchange(exchCMPST), cmd));

                // Traigo el valor calculado al Exchange no posteado para que actualice el importe calculado //
                exchNoPost.Impuestos[0].Importe_Impuesto = exchCMPST.Param.grdImpuestos[0].Importe_Impuesto;

            }
            //}

            return exchNoPost;

        }
        
    }
}
