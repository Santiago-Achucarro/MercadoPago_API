using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockFEEventos
{
    public class stkProductos
    {
        [Generalidades.QFuncion_Condicion]
        public string Acepta_Ventas(StockCommon.stkProductosDS exch, Framework.Core.Command cmd)
        {
            return (exch.Principal[0].Acepta_Ventas ? "S" : "N");

        }

        [Generalidades.QFuncion_Condicion]
        public string Acepta_Compras(StockCommon.stkProductosDS exch, Framework.Core.Command cmd)
        {
            return (exch.Principal[0].Acepta_Compras ? "S" : "N");

        }


        [Generalidades.QFuncion_Condicion]
        public string Clase(StockCommon.stkProductosDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Clase == "-")
                return "M";

            return exch.Principal[0].Clase;

        }

        [Generalidades.QFuncion_Condicion]
        public string ClaseAlterna(StockCommon.stkProductosDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].ClaseAlterna == "-")
                return "M";
            return exch.Principal[0].ClaseAlterna;
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public String ValidarFila(StockCommon.stkProductosDS exch,
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
        public string ManejaCantidadAlterna(StockCommon.stkProductosDS exch, Framework.Core.Command cmd)
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
        public string ManejaSerieLotes(StockCommon.stkProductosDS exch, Framework.Core.Command cmd)
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
        public string ManejaDespachoImpor(StockCommon.stkProductosDS exch, Framework.Core.Command cmd)
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
        // este no estaba en V2
        [Generalidades.QFuncion_CondicionGrilla]
        public StockCommon.stkMoviCabeDatosCausaDS ValidarProducto(StockCommon.stkMoviCabeDatosCausaDS dsCommiteado, StockCommon.stkMoviCabeDatosCausaDS dsSinCommitear, int lRenglon)
        {

            return dsSinCommitear;
        }

        [Generalidades.QFuncion_Condicion]
        public string EsSerializable(StockCommon.stkProductosDS exch, Framework.Core.Command cmd)
        {
            return (exch.Principal[0].Serializable ? "S" : "N");
        }

        [Generalidades.QFuncion_Condicion]
        public string EsLoteable(StockCommon.stkProductosDS exch, Framework.Core.Command cmd)
        {
            return (exch.Principal[0].TrabajaPorLotes ? "S" : "N");
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarReceta(StockCommon.stkProductosDS dsCommiteado, StockCommon.stkProductosDS dsSinCommitear,
                int pIndice, Command cmd)
        {
            if (dsSinCommitear.Recetas[0].Receta_Id == "")
                return "Debe_Ingresar_Una_Receta";

            var eReceta =
                ProduccionValidacion.proRecetas.ExistePosteadoyActiva(dsSinCommitear.Recetas[0].Receta_Id, cmd);

            if (eReceta.Param.Productos.ToList().Where(c => c.EntradaSalida == "P" && c.Producto_Id == dsCommiteado.Principal[0].Producto_Id).Count() == 0)
            {
                return "La_Receta_No_Produce_Este_Producto";
            }

            for (int i = 0; i < dsCommiteado.Recetas.Count; i++)
            {
                if (dsSinCommitear.Recetas[0].Principal && i != pIndice && dsCommiteado.Recetas[i].Principal)
                    return "Solo_Puede_Haber_Una_Receta_Principal";
                if (i != pIndice && dsCommiteado.Recetas[i].Receta_Id == dsSinCommitear.Recetas[0].Receta_Id)
                    return "La_Receta_Ya_Esta_En_La_Lista";
            }


            return "";
        }
    }
}
