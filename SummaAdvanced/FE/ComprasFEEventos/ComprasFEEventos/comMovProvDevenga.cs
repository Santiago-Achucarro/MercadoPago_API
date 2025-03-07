using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprasFEEventos
{
    public class comMovProvDevenga
    {
        [Generalidades.QFuncion_Condicion]
        public string EsMonedaBase(ComprasCommon.comMovProvDevengaDS exch, Command cmd)
        {
            if (exch.Principal[0].Moneda_Id == cmd.MonedaBase || exch.Principal[0].Moneda_Id.Trim() == "")
                return "S";

            return "N";

        }

        [Generalidades.QFuncion_Condicion]
        public string PideCuotas(ComprasCommon.comMovProvDevengaDS exch, Command cmd)
        {

            return exch.Principal[0].CantCuotas > 1 ? "S" : "N";

        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaDeta(ComprasCommon.comMovProvDevengaDS exch, ComprasCommon.comMovProvDevengaDS exchNoPost, int pIndice, Command cmd)
        {
            ComprasCommon.comMovProvDevengaDS.grdCuerpoDataTable lDF = exchNoPost.grdCuerpo;

            if (lDF[0].Cuenta_Id == "")
                return "La_Cuenta_No_puede_ser_Vacia";

            ContabilidadValidacion.conCuentas.ExistePosteadoActivaImputableNoReservada(lDF[0].Cuenta_Id, cmd);

            return "";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaImp(ComprasCommon.comMovProvDevengaDS exch, ComprasCommon.comMovProvDevengaDS exchNoPost, int pIndice, Command cmd)
        {

            ComprasCommon.comMovProvDevengaDS.grdImpuestosDataTable lDF = exchNoPost.grdImpuestos;

            if (lDF[0].Impuesto_Id == "")
                return "El_Impuesto_No_puede_ser_Vacio";

            return "";
        }


        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comMovProvDevengaDS ValoresImpuesto(ComprasCommon.comMovProvDevengaDS pCommonDS, ComprasCommon.comMovProvDevengaDS pCommonNoPostDS, int pIndice, Command cmd)
        {
            // Llamo al padre //
            ComprasCommon.comMovProvDatosSinStockDS lCommonDS = new ComprasCommon.comMovProvDatosSinStockDS();
            ComprasCommon.comMovProvDatosSinStockDS lCommonNoPostDS = new ComprasCommon.comMovProvDatosSinStockDS();

            lCommonDS.Merge(pCommonDS, false, System.Data.MissingSchemaAction.Ignore);
            lCommonNoPostDS.Merge(pCommonNoPostDS, false, System.Data.MissingSchemaAction.Ignore);

            ComprasCommon.comMovProvDatosSinStockDS lReturnPadre = ComprasFEEventos.comMovProvSinStock.ValoresImpuesto(lCommonDS, lCommonNoPostDS, pIndice, cmd);
            ComprasCommon.comMovProvDevengaDS lReturn = new ComprasCommon.comMovProvDevengaDS();
            lReturn.Merge(lReturnPadre, false, System.Data.MissingSchemaAction.Add);

            return lReturn;
        }


        [Generalidades.QFuncion_Condicion]
        public string ValidarFechaContable(ComprasCommon.comMovProvDevengaDS pCommonDS, Command cmd)
        {
            GeneralesExchange.genEmpresasActionExchange exchEmpr = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);

            if (pCommonDS.Principal[0].Fecha > exchEmpr.FechaCierreCompras)
                return "La_fecha_contable_no_puede_ser_menor_a_la_fecha_de_cierre_de_compras";
            return "";

        }
        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> RFCProveedor(ComprasCommon.comMovProvDevengaDS exch, ComprasCommon.comMovProvDevengaDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            // Tomo la sucursal del Usuario

            string lRfcProveedor = ComprasValidacion.comProveedores.Existe(exch.Principal[0].Segmento3C, cmd).CUIT;

            Dictionary<string, string> lRetorno = new Dictionary<string, string>();
            lRetorno.Add("RFCProveedor", lRfcProveedor);

            return lRetorno;
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ImpuestoVaAlCosto(ComprasCommon.comMovProvDevengaDS pCommonDS, ComprasCommon.comMovProvDevengaDS pCommonDSNoPost, int pIndice, Command cmd)
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
        public string ValidarFilaVaAlCosto(ComprasCommon.comMovProvDevengaDS exch, ComprasCommon.comMovProvDevengaDS exchNoPost,
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
        public static ComprasCommon.comMovProvDevengaDS SumarImporte(ComprasCommon.comMovProvDevengaDS exch, ComprasCommon.comMovProvDevengaDS exchNoPost, int pIndice, Command cmd)
        {
            exchNoPost.grdImpuestos[0].Importe_Impuesto = exchNoPost.ImpuestosVaAlCosto.ToList().Sum(r => r.Importe);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }
    }
}
