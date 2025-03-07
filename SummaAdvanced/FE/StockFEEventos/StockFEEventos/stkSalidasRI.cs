using StockCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFEEventos
{
    public class stkSalidasRI
    {
        [Generalidades.QFuncion_Condicion]
        public string ManejaCantidadAlterna(stkSalidasRIDS pCommonDS, Framework.Core.Command cmd)
        {
            return ComunesStock.ManejaCantidadAlterna(cmd);
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductos(stkSalidasRIDS pCommonDS, stkSalidasRIDS pCommonNoPost, int pIndice, Framework.Core.Command cmd)
        {
            return ComunesStock.VariablesProductos(pCommonNoPost.Cuerpo[0].Producto_Id, pCommonNoPost.Cuerpo[0].Deposito_Id, cmd);
        }

        public enum stkSalidasRIVar
        {
            ManejaSerieoLote, ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, ManejoDeposito, ManejoCantEntregada, LetraCondFiscal, UsaDespacho, ManejaUbicacion, CantidadSoloLectura
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarRenglon(stkSalidasRIDS pCommonDS, stkSalidasRIDS pCommonNoPost, int pIndice, Framework.Core.Command cmd)
        {

            stkSalidasRIDS.CuerpoDataTable dt = pCommonNoPost.Cuerpo;
            if (dt[0].CantidadForm > 0)
            {
                if (dt[0].Producto_Id == "")
                    return "Debe_Ingresar_Un_codigo_de_producto";

                if (dt[0].Deposito_Id == "")
                    return "Debe_informar_el_deposito";
            }
            else
            {
                return "La_Cantidad_Debe_Ser_Mayor_que_Cero";
            }
            return "";
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkSalidasRIDS PopularSerie(stkSalidasRIDS pCommonDS, stkSalidasRIDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            // Se llaman distintos los dt y por eso los tengo que renombrar //
            // En el estándar se llaman grdCuerpo y acá en RI Cuerpo //
            pCommonDS.Cuerpo.TableName = "grdCuerpo";
            pCommonDSNoPost.Cuerpo.TableName = "grdCuerpo";
            stkSalidasRIDS ds = new stkSalidasRIDS();
            ds.Merge(stkMoviSerieSalidasSolapa.PopularSerie(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Add);
            ds.Tables.Remove("Cuerpo");
            ds.Tables["grdCuerpo"].TableName = "Cuerpo";
            return ds;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkSalidasRIDS PopularLote(stkSalidasRIDS pCommonDS, stkSalidasRIDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            // Se llaman distintos los dt y por eso los tengo que renombrar //
            // En el estándar se llaman grdCuerpo y acá en RI Cuerpo //
            pCommonDS.Cuerpo.TableName = "grdCuerpo";
            pCommonDSNoPost.Cuerpo.TableName = "grdCuerpo";
            stkSalidasRIDS ds = new stkSalidasRIDS();
            ds.Merge(stkMoviSerieSalidasSolapa.PopularLote(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Add);
            ds.Tables.Remove("Cuerpo");
            ds.Tables["grdCuerpo"].TableName = "Cuerpo";
            return ds;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkSalidasRIDS PopularUbi(stkSalidasRIDS pCommonDS, stkSalidasRIDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            // Se llaman distintos los dt y por eso los tengo que renombrar //
            // En el estándar se llaman grdCuerpo y acá en RI Cuerpo //
            pCommonDS.Cuerpo.TableName = "grdCuerpo";
            pCommonDSNoPost.Cuerpo.TableName = "grdCuerpo";
            stkSalidasRIDS ds = new stkSalidasRIDS();
            ds.Merge(stkEntradasUbicacion.PopularUbi(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Add);
            ds.Tables.Remove("Cuerpo");
            ds.Tables["grdCuerpo"].TableName = "Cuerpo";
            return ds;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkSalidasRIDS SumarCantLote(stkSalidasRIDS pCommonDS, stkSalidasRIDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            pCommonDSNoPost.Cuerpo[0].CantidadForm = pCommonDSNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            pCommonDSNoPost.AcceptChanges();

            return pCommonDSNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkSalidasRIDS SumarCantSerie(stkSalidasRIDS pCommonDS, stkSalidasRIDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            pCommonDSNoPost.Cuerpo[0].CantidadForm = pCommonDSNoPost.grdMoviSerie.ToList().Sum(r => r.Marcado ? 1 : 0);
            pCommonDSNoPost.AcceptChanges();

            return pCommonDSNoPost;
        }

        public static stkSalidasRIDS SumarCantU(stkSalidasRIDS pCommonDS, stkSalidasRIDS pCommonDSNoPost, int pIndice,
Framework.Core.Command cmd)
        {
            pCommonDSNoPost.Cuerpo[0].CantidadForm = pCommonDSNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
            pCommonDSNoPost.AcceptChanges();

            return pCommonDSNoPost;
        }
    }
}
