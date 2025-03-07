using System;
using Framework.Core;
using System.Linq;

namespace StockFEEventos
{
    public class stkPlantillasProductos
    {
        [Generalidades.QFuncion_Condicion]
        public string Acepta_Ventas(StockCommon.stkProductosPlantillaDS exch, Framework.Core.Command cmd)
        {
            return (exch.Principal[0].Acepta_Ventas ? "S" : "N");

        }

        [Generalidades.QFuncion_Condicion]
        public string Acepta_Compras(StockCommon.stkProductosPlantillaDS exch, Framework.Core.Command cmd)
        {
            return (exch.Principal[0].Acepta_Compras ? "S" : "N");

        }


        [Generalidades.QFuncion_Condicion]
        public string Clase(StockCommon.stkProductosPlantillaDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Clase == "-")
                return "M";

            return exch.Principal[0].Clase;

        }

        [Generalidades.QFuncion_Condicion]
        public string ClaseAlterna(StockCommon.stkProductosPlantillaDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].ClaseAlterna == "-")
                return "M";
            return exch.Principal[0].ClaseAlterna;

        }

        [Generalidades.QFuncion_CondicionGrilla]
        public String ValidarFila(StockCommon.stkProductosPlantillaDS exch,
StockCommon.stkProductosDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            StockCommon.stkProductosDS.MedidasDataTable lRenglon = exchNoPost.Medidas;

            if (lRenglon[0].Medida_Id == "")
                return "Debe_Ingresar_una_unidad_de_medida";

            if (lRenglon[0].Factor <= 0)
                return "Debe_informar_factor_de_conversion_mayor_a_cero";

            return "";
        }

        [Generalidades.QFuncion_Condicion]
        public string ManejaCantidadAlterna(StockCommon.stkProductosPlantillaDS exch, Framework.Core.Command cmd)
        {
            GeneralesExchange.genEmpresasActionExchange ExchEmp =
                new GeneralesExchange.genEmpresasActionExchange(GeneralesExchange.genEmpresasActionEnum.EnumgenEmpresasAction.Datos);

            ExchEmp.Empresa_Id = "";
            ExchEmp.genEmpresas = cmd.Empresa_Id;
            ExchEmp = new GeneralesExchange.genEmpresasActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExchEmp, cmd));

            if (ExchEmp.UsaCantidadAlterna)
                return "S";

            return "N";

        }

        [Generalidades.QFuncion_Condicion]
        public string ManejaSerieLotes(StockCommon.stkProductosPlantillaDS exch, Framework.Core.Command cmd)
        {
            GeneralesExchange.genEmpresasActionExchange ExchEmp =
                new GeneralesExchange.genEmpresasActionExchange(GeneralesExchange.genEmpresasActionEnum.EnumgenEmpresasAction.Datos);

            ExchEmp.Empresa_Id = "";
            ExchEmp.genEmpresas = cmd.Empresa_Id;
            ExchEmp = new GeneralesExchange.genEmpresasActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExchEmp, cmd));

            if (ExchEmp.UsaSerie)
                return "S";

            return "N";

        }

        [Generalidades.QFuncion_Condicion]
        public string ManejaDespachoImpor(StockCommon.stkProductosPlantillaDS exch, Framework.Core.Command cmd)
        {
            GeneralesExchange.genEmpresasActionExchange ExchEmp =
                new GeneralesExchange.genEmpresasActionExchange(GeneralesExchange.genEmpresasActionEnum.EnumgenEmpresasAction.Datos);

            ExchEmp.Empresa_Id = "";
            ExchEmp.genEmpresas = cmd.Empresa_Id;
            ExchEmp = new GeneralesExchange.genEmpresasActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExchEmp, cmd));

            if (ExchEmp.UsaDespachoImportacion)
                return "S";

            return "N";

        }

        //[Generalidades.QFuncion_CondicionGrilla]
        
        [Generalidades.QFuncion_Condicion]
        public string EsSerializable(StockCommon.stkProductosPlantillaDS exch, Framework.Core.Command cmd)
        {
            return (exch.Principal[0].Serializable ? "S" : "N");
        }

        [Generalidades.QFuncion_Condicion]
        public string EsLoteable(StockCommon.stkProductosPlantillaDS exch, Framework.Core.Command cmd)
        {
            return (exch.Principal[0].TrabajaPorLotes ? "S" : "N");
        }


    }
}
