using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
namespace ComprasFEEventos
{
    public class comFacturasOrdenDeCompra
    {
        [Generalidades.QFuncion_Condicion]
        public string EsMonedaBase(ComprasCommon.comFacturasConOrdenDeCompraDS exch, Command cmd)
        {
            if (exch.Principal[0].Moneda_Id == cmd.MonedaBase || exch.Principal[0].Moneda_Id.Trim() == "")
                return "S";

            return "N";

        }

        [Generalidades.QFuncion_Condicion]
        public string PideCuotas(ComprasCommon.comFacturasConOrdenDeCompraDS exch, Command cmd)
        {

            return exch.Principal[0].CantCuotas > 1 ? "S" : "N";

        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaImp(ComprasCommon.comFacturasConOrdenDeCompraDS exch, ComprasCommon.comFacturasConOrdenDeCompraDS exchNoPost,
           int pIndice, Command cmd)
        {
            ComprasCommon.comFacturasConOrdenDeCompraDS.ImpuestosDataTable lDF = exchNoPost.Impuestos;

            if (lDF[0].Impuesto_Id == "")
                return "El_Impuesto_No_puede_ser_Vacio";

        
            return "";
        }

        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comFacturasConOrdenDeCompraDS ValoresImpuesto(ComprasCommon.comFacturasConOrdenDeCompraDS exch,
            ComprasCommon.comFacturasConOrdenDeCompraDS exchNoPost, int pIndice, Command cmd)
        {
            GeneralesExchange.genMonedasActionExchange exchMon = GeneralesValidacion.genMonedas.Existe(exch.Principal[0].Moneda_Id, cmd);
            int lDigitos = exchMon.CantidadDigitos;

            ComprasCommon.comFacturasConOrdenDeCompraDS.ImpuestosDataTable lDF = exchNoPost.Impuestos;

            ComprasExchange.comImpuestosActionExchange exchImp = new ComprasExchange.comImpuestosActionExchange
                (ComprasExchange.comImpuestosActionEnum.EnumcomImpuestosAction.Datos);
            exchImp.Impuesto_Id = lDF[0].Impuesto_Id;

            exchImp = new ComprasExchange.comImpuestosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                (new Exchange(exchImp), cmd));

            if (exchNoPost.Impuestos[0].Porcentaje == 0)
                // Asigno el porcentaje si está en 0. Si es distinto de cero que no cambie por si el usuario lo editó //
                exchNoPost.Impuestos[0].Porcentaje = exchImp.Porcentaje;
            exchNoPost.Impuestos[0].Cuenta_Id = exchImp.CtaDebe;


            if (exchImp.Formulacalc == "")
            {
                exchNoPost.Impuestos[0].Importe_Impuesto = Generalidades.Auxiliares.Redondear
                    (lDF[0].Base_Imponible * exchImp.Porcentaje, lDigitos);
            }
            else
            {
                //    ComprasExchange.comMovProvDatosSinStockActionExchange exchCMPST = new ComprasExchange.comMovProvDatosSinStockActionExchange
                //        (ComprasExchange.comMovProvDatosSinStockActionEnum.EnumcomMovProvDatosSinStockAction.CalcularImpuesto);

                //    exchCMPST.Param.Merge(exch);
                //    exchCMPST.Param.Principal[0].Delete();


                // Tomo siempre el porcentaje desde la grilla porque si está editando un renglón existente está bien //
                // Y si está editando uno nuevo, ya copió el valor del impuesto a la grilla //

                // Agrego el renglón no posteado al Exchange para que haga el cálculo del impuesto //
                ComprasExchange.comFacturasConOrdenDeCompraActionExchange exchFactuOC = new ComprasExchange.comFacturasConOrdenDeCompraActionExchange
                    (ComprasExchange.comFacturasConOrdenDeCompraActionEnum.EnumcomFacturasConOrdenDeCompraAction.CalcularImpuesto);
                exchFactuOC.Param.Merge(exch, false, System.Data.MissingSchemaAction.Ignore);
                exchFactuOC.Param.Principal[0].Delete();
                exchFactuOC.Param.Impuestos.Clear();
                // Le tengo que sumar el impuesto que todavía no está posteado //
                exchFactuOC.Param.Impuestos.AddImpuestosRow(0, 0, exchImp.Impuesto_Id, "",
                    exchNoPost.Impuestos[0].Porcentaje, lDF[0].Base_Imponible, 0, "", "", "", "", "", "", 0, "", 0);
                exchFactuOC.Param.AcceptChanges();

                ComprasExchange.comMovProvDatosConStockActionExchange ExcMP = 
                    ComprasExchange.comFacturasConOrdenDeCompraActionEnum.ToExcConStock(exchFactuOC);
                ExcMP.Action = ComprasExchange.comMovProvDatosConStockActionEnum.GetAccioncomMovProvDatosConStockAction
                    (ComprasExchange.comMovProvDatosConStockActionEnum.EnumcomMovProvDatosConStockAction.CalcularImpuesto);

                ExcMP = new ComprasExchange.comMovProvDatosConStockActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcMP, cmd));

                exchFactuOC = ComprasExchange.comFacturasConOrdenDeCompraActionEnum.FromExcConStock(ExcMP, exchFactuOC);


                //exchCMPST.Param.grdImpuestos.Clear();
                //exchCMPST.Param.grdImpuestos.AddgrdImpuestosRow(0, 0, exchImp.Impuesto_Id, "",
                //    exchNoPost.Impuestos[0].Porcentaje, lDF[0].Base_Imponible, 0, "", "", "", "", "", "", 0, "", 0);
                //exchCMPST.Param.grdImpuestos.AcceptChanges();

                //exchCMPST = new ComprasExchange.comMovProvDatosSinStockActionExchange
                //    (Generalidades.QBIInternal.WrapperExecuteActionInternal(new Exchange(exchCMPST), cmd));

                // Traigo el valor calculado al Exchange no posteado para que actualice el importe calculado //
                exchNoPost.Impuestos[0].Importe_Impuesto = ExcMP.Param.grdImpuestos[0].Importe_Impuesto;

            }
            //}

            return exchNoPost;
        }

        public enum comFacturasOrdenDeCompraVar
        {
            UsaDescuento, CtaDtoPositivo, CtaDtoNegativo
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesDescuento(ComprasCommon.comFacturasConOrdenDeCompraDS exch,
        ComprasCommon.comFacturasConOrdenDeCompraDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            Dictionary<string, string> lRetorno = new Dictionary<string, string>();
            var eEmpresa = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);

            lRetorno.Add(comFacturasOrdenDeCompraVar.UsaDescuento.ToString(), eEmpresa.MontoDtoFinanciero == 0? "N":"S");
            lRetorno.Add(comFacturasOrdenDeCompraVar.CtaDtoNegativo.ToString(), eEmpresa.CtaDtoFinNeg);
            lRetorno.Add(comFacturasOrdenDeCompraVar.CtaDtoPositivo.ToString(), eEmpresa.CtaDtoFinPos);

            return lRetorno;


        }

        [Generalidades.QFuncion_Condicion]
        public string DtoNegativo(ComprasCommon.comFacturasConOrdenDeCompraDS exch, Command cmd)
        {
            if (exch.DescuentoFin[0].ImporteMonedaOriginal<0)
                return "S";

            return "N";

        }


        [Generalidades.QFuncion_Condicion]
        public string PideCambioOriginal(ComprasCommon.comFacturasConOrdenDeCompraDS exch, Command cmd)
        {
            if (exch.Principal[0].Moneda_Id == cmd.MonedaBase && exch.OrdenCompra[0].Moneda_Id != cmd.MonedaBase)
                return "S";

            return "N";

        }
    }
}
