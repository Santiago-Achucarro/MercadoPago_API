using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
namespace ComprasFEEventos
{
    public class comMovProvSinStock
    {
        [Generalidades.QFuncion_Condicion]
        public string EsMonedaBase(ComprasCommon.comMovProvDatosSinStockDS exch, Command cmd)
        {   
            if (exch.Principal[0].Moneda_Id == cmd.MonedaBase || exch.Principal[0].Moneda_Id.Trim()=="")
                return "S";

            return "N";

        }

        [Generalidades.QFuncion_Condicion]
        public string PideCuotas(ComprasCommon.comMovProvDatosSinStockDS exch, Command cmd)
        {

            return exch.Principal[0].CantCuotas > 1 ? "S" : "N";

        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaDeta(ComprasCommon.comMovProvDatosSinStockDS exch, ComprasCommon.comMovProvDatosSinStockDS exchNoPost,
            int pIndice, Command cmd)
        {
            ComprasCommon.comMovProvDatosSinStockDS.grdCuerpoDataTable lDF = exchNoPost.grdCuerpo;

            if (lDF[0].Cuenta_Id == "")
                return "La_Cuenta_No_puede_ser_Vacia";

            ContabilidadValidacion.conCuentas.ExistePosteadoActivaImputableNoReservada(lDF[0].Cuenta_Id, cmd);

            return "";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaImp(ComprasCommon.comMovProvDatosSinStockDS exch, ComprasCommon.comMovProvDatosSinStockDS exchNoPost,
            int pIndice, Command cmd)
        {

            ComprasCommon.comMovProvDatosSinStockDS.grdImpuestosDataTable lDF = exchNoPost.grdImpuestos;

            if (lDF[0].Impuesto_Id == "")
                return "El_Impuesto_No_puede_ser_Vacio";

            return "";
        }


        [Generalidades.QFuncion_AccionGrilla]
        public static ComprasCommon.comMovProvDatosSinStockDS ValoresImpuesto(ComprasCommon.comMovProvDatosSinStockDS exch, 
            ComprasCommon.comMovProvDatosSinStockDS exchNoPost, int pIndice, Command cmd)
        {
            // TODO FM Ver de dónde sacamos la cantidad de dígitos
            int lDigitos = 2;

            ComprasCommon.comMovProvDatosSinStockDS.grdImpuestosDataTable lDF = exchNoPost.grdImpuestos;

            ComprasExchange.comImpuestosActionExchange exchImp = new ComprasExchange.comImpuestosActionExchange
                (ComprasExchange.comImpuestosActionEnum.EnumcomImpuestosAction.Datos);
            exchImp.Impuesto_Id = lDF[0].Impuesto_Id;

            exchImp = new ComprasExchange.comImpuestosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                (new Exchange(exchImp), cmd));

            if(exchNoPost.grdImpuestos[0].Porcentaje == 0)
                // Asigno el porcentaje si está en 0. Si es distinto de cero que no cambie por si el usuario lo editó //
                exchNoPost.grdImpuestos[0].Porcentaje = exchImp.Porcentaje;
            exchNoPost.grdImpuestos[0].Cuenta_Id = exchImp.CtaDebe;

            // FM Si cambio el porcentaje que calculo siempre el impuesto y no solo si estoy dando //
            // de alta un nuevo impuesto. Comento el if de abajo //

            // Calculo el importe del impuesto solo si estoy insertando un nuevo renglón //
            //if (pIndice == -1)
            //{

            if (!exchImp.VaAlCosto)
            {
                // FM 04/03/2022 Calculo el importe del impuesto solo si no va al costo //

                if (exchImp.Formulacalc == "")
                {
                    exchNoPost.grdImpuestos[0].Importe_Impuesto = Generalidades.Auxiliares.Redondear
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
                        exchNoPost.grdImpuestos[0].Porcentaje, lDF[0].Base_Imponible, 0, "", "", "", "", "", "", 0, "", 0);
                    exchCMPST.Param.grdImpuestos.AcceptChanges();

                    exchCMPST = new ComprasExchange.comMovProvDatosSinStockActionExchange
                        (Generalidades.QBIInternal.WrapperExecuteActionInternal(new Exchange(exchCMPST), cmd));

                    // Traigo el valor calculado al Exchange no posteado para que actualice el importe calculado //
                    exchNoPost.grdImpuestos[0].Importe_Impuesto = exchCMPST.Param.grdImpuestos[0].Importe_Impuesto;

                }
                //}
            }

            return exchNoPost;
        }


        [Generalidades.QFuncion_Condicion]
        public string ValidarFechaContable(ComprasCommon.comMovProvDatosSinStockDS exch, Command cmd)
        {
            GeneralesExchange.genEmpresasActionExchange exchEmpr = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);

            if (exch.Principal[0].Fecha > exchEmpr.FechaCierreCompras)
                return "La_fecha_contable_no_puede_ser_menor_a_la_fecha_de_cierre_de_compras";
            return "";

        }
        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> RFCProveedor(ComprasCommon.comMovProvDatosSinStockDS exch,
          ComprasCommon.comMovProvDatosSinStockDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            // Tomo la sucursal del Usuario

            string lRfcProveedor = ComprasValidacion.comProveedores.Existe(exch.Principal[0].Segmento3C, cmd).CUIT;
            

            Dictionary<string, string> lRetorno = new Dictionary<string, string>();
            lRetorno.Add("RFCProveedor", lRfcProveedor);

            return lRetorno;
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ImpuestoVaAlCosto(ComprasCommon.comMovProvDatosSinStockDS pCommonDS, ComprasCommon.comMovProvDatosSinStockDS pCommonDSNoPost, int pIndice, Command cmd)
        {

            ComprasExchange.comImpuestosActionExchange exchImpu = new ComprasExchange.comImpuestosActionExchange(ComprasExchange.comImpuestosActionEnum.EnumcomImpuestosAction.Datos)
            {
                Impuesto_Id = pCommonDSNoPost.grdImpuestos[0].Impuesto_Id
            };
            exchImpu = new ComprasExchange.comImpuestosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchImpu, cmd));
            if (exchImpu.VaAlCosto)
                return "S";

            return "N";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaVaAlCosto(ComprasCommon.comMovProvDatosSinStockDS exch, ComprasCommon.comMovProvDatosSinStockDS exchNoPost,
    int pIndice, Command cmd)
        {

            if (pIndice < 0)
                pIndice = exchNoPost.ImpuestosVaAlCosto.Count - 1;

            if (exchNoPost.ImpuestosVaAlCosto[pIndice].Cuenta_Id == "")
                return "La_Cuenta_No_puede_ser_Vacia";

            ContabilidadValidacion.conCuentas.ExistePosteadoActivaImputableNoReservada(exchNoPost.ImpuestosVaAlCosto[pIndice].Cuenta_Id, cmd);
            ContabilidadValidacion.conCentro1.ExistePosteadoyActivo(exchNoPost.ImpuestosVaAlCosto[pIndice].Centro1_Id, cmd);
            ContabilidadValidacion.conCentro2.ExistePosteadoyActivo(exchNoPost.ImpuestosVaAlCosto[pIndice].Centro2_Id, cmd);

            if (exchNoPost.ImpuestosVaAlCosto[pIndice].Importe <= 0)
                Generalidades.qFunctionalException.GenerarExcepcion("El_Importe_debe_ser_mayor_que_cero");

            return "";
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static ComprasCommon.comMovProvDatosSinStockDS SumarImporte (ComprasCommon.comMovProvDatosSinStockDS exch, ComprasCommon.comMovProvDatosSinStockDS exchNoPost, int pIndice, Command cmd)
        {
            exchNoPost.grdImpuestos[0].Importe_Impuesto = exchNoPost.ImpuestosVaAlCosto.ToList().Sum(r => r.Importe);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }
    }
}
