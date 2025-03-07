using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProduccionCommon;
using StockFEEventos;

namespace ProduccionFeEventos
{


    public class proOrden
    {
        public enum proOrdenVar
        {
            Receta_Id, ManejaSerieoLote, ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, UsaDespacho, ManejaUbicacion, CantidadSoloLectura
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesReceta(proOrdenDS pCommon, proOrdenDS pCommonNoPost, int pIndice, Framework.Core.Command cmd)
        {
            ProduccionExchange.proProductosRecetaActionExchange eRelacion = new ProduccionExchange.proProductosRecetaActionExchange( Generalidades.QBIInternal.WrapperExecuteActionInternal(new ProduccionExchange.proProductosRecetaActionExchange(ProduccionExchange.proProductosRecetaActionEnum.EnumproProductosRecetaAction.Datos)
            {
                Producto_Id = pCommon.Principal[0].Producto_Id
            }, cmd));
            Dictionary<string, string> lRetorno = new Dictionary<string, string>();

            lRetorno = ComunesStock.VariablesProductos(pCommon.Principal[0].Producto_Id, "", cmd);

            if (eRelacion.Existe)
                lRetorno.Add(proOrdenVar.Receta_Id.ToString(), eRelacion.Receta_Id);
            else
                lRetorno.Add(proOrdenVar.Receta_Id.ToString(), "");
            return lRetorno;

        }


        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarTrabajos3(ProduccionCommon.proOrdenDS exch, ProduccionCommon.proOrdenDS excNoPos, int Indice, Framework.Core.Command cmd)
        {

            ProduccionValidacion.proTrabajo3.ExistePosteadoyActiva(excNoPos.Trabajo3[0].Trabajo3_Id, cmd);
            ComprasValidacion.comProveedores.AnexoExistePosteadoyActiva(excNoPos.Trabajo3[0].Proveed_Id, cmd);

            return "";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarRecursos(ProduccionCommon.proOrdenDS exch, ProduccionCommon.proOrdenDS excNoPos, int Indice, Framework.Core.Command cmd)
        {

            ProduccionValidacion.proRecursos.ExistePosteadoyActiva(excNoPos.Recursos[0].Recurso_Id, cmd);

            return "";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarProductos(ProduccionCommon.proOrdenDS exch, ProduccionCommon.proOrdenDS excNoPos, int Indice, Framework.Core.Command cmd)
        {

            StockExchange.stkProductosActionExchange eProducto =
            StockValidacion.stkProductos.ExistePosteadoyActivo(excNoPos.Productos[0].Producto_Id, cmd);
            StockValidacion.stkProductos.Factor(eProducto, excNoPos.Productos[0].Medida_Id);
            if (excNoPos.Productos[0].EntradaSalida != "C" && excNoPos.Productos[0].EntradaSalida != "P")
                Generalidades.qFunctionalException.GenerarExcepcion("El_Tipo_de_Uso_C_o_P");
            return "";
        }

        [Generalidades.QFuncion_ObtenerParametrosReporte]
        public string Parametros(ProduccionCommon.proOrdenDS exch, Framework.Core.Command cmd)
        {

            return
                     "Empresa_Id|" + cmd.Empresa_Id.ToString() + "@Segmento_Id|PORD" +
                     "@Segmento1N|" + exch.Principal[0].Segmento1N.ToString() +
                     "@Segmento2N|" + exch.Principal[0].Segmento2N.ToString() +
                     "@Segmento3N|" + exch.Principal[0].Segmento3N.ToString() +
                     "@Segmento4N|" + exch.Principal[0].Segmento4N.ToString() +
                     "@Segmento1C|" + exch.Principal[0].Segmento1C +
                     "@Segmento2C|" + exch.Principal[0].Segmento2C +
                     "@Segmento3C|" + exch.Principal[0].Segmento3C +
                     "@Segmento4C|" + exch.Principal[0].Segmento4C;

        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductosConsumo(proOrdenDS exch, proOrdenDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            return ComunesStock.VariablesProductos(exchNoPost.Productos[0].Producto_Id, exchNoPost.Productos[0].Deposito_Id, cmd);

        }
        public static string ValirSerieLote(proOrdenDS exch, proOrdenDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {

            if (String.IsNullOrEmpty(exchNoPost.grdMoviSerie[0].Serie))
                return "Debe_ingresar_El_Numero_de_Serie_o_Lote";

            StockExchange.stkExistenciaSerieActionExchange exchSerie = new StockExchange.stkExistenciaSerieActionExchange
                (StockExchange.stkExistenciaSerieActionEnum.EnumstkExistenciaSerieAction.Datos);
            exchSerie.Producto_Id = exchNoPost.Productos[0].Producto_Id;
            exchSerie.Serie = exchNoPost.grdMoviSerie[0].Serie;
            exchSerie.Deposito_Id = exchNoPost.Productos[0].Deposito_Id;

            exchSerie = new StockExchange.stkExistenciaSerieActionExchange
                (Generalidades.QBIInternal.WrapperExecuteActionInternal(new Framework.Core.Exchange(exchSerie), cmd));

            if (!exchSerie.Existe)
                return "Serie_Lote_<0>_en_deposito_<1>_no_existe";

            // FM 21/05/2019 //
            if (exchNoPost.grdMoviSerie[0].Cantidad <= 0)
                return "Cantidad_invalida";
            // Fin FM //

            return "";
        }

        public static proOrdenDS SumarCant(proOrdenDS exch, proOrdenDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {

            exchNoPost.Productos[0].Cantidad = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;

        }

        [Generalidades.QFuncion_AccionGrilla]
        public proOrdenDS PopularSerie(proOrdenDS pCommonDS, proOrdenDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            // Se llaman distintos los dt y por eso los tengo que renombrar //
            // En el estándar se llaman grdCuerpo y acá en RI Cuerpo //
            pCommonDS.Productos.TableName = "grdCuerpo";
            pCommonDSNoPost.Productos.TableName = "grdCuerpo";
            proOrdenDS ds = new proOrdenDS();
            ds.Merge(stkMoviSerieSalidasSolapa.PopularSerie(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Add);
            ds.Tables.Remove("Productos");
            ds.Tables["grdCuerpo"].TableName = "Productos";
            return ds;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public proOrdenDS PopularLote(proOrdenDS pCommonDS, proOrdenDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            // Se llaman distintos los dt y por eso los tengo que renombrar //
            // En el estándar se llaman grdCuerpo y acá en RI Cuerpo //
            pCommonDS.Productos.TableName = "grdCuerpo";
            pCommonDSNoPost.Productos.TableName = "grdCuerpo";
            proOrdenDS ds = new proOrdenDS();
            ds.Merge(stkMoviSerieSalidasSolapa.PopularLote(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Add);
            ds.Tables.Remove("Productos");
            ds.Tables["grdCuerpo"].TableName = "Productos";
            return ds;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public proOrdenDS SumarCantLote(proOrdenDS pCommonDS, proOrdenDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            pCommonDSNoPost.Productos[0].Cantidad = pCommonDSNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            pCommonDSNoPost.AcceptChanges();

            return pCommonDSNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public proOrdenDS SumarCantSerie(proOrdenDS pCommonDS, proOrdenDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            pCommonDSNoPost.Productos[0].Cantidad = pCommonDSNoPost.grdMoviSerie.ToList().Sum(r => r.Marcado ? 1 : 0);
            pCommonDSNoPost.AcceptChanges();

            return pCommonDSNoPost;
        }
    }
}
