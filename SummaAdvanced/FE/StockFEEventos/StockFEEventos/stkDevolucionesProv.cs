using StockCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StockFEEventos
{
    public class stkDevolucionesProv
    {
        [Generalidades.QFuncion_Condicion]
        public string ManejaCantidadAlterna(StockCommon.stkDevolucionesProvDS exch, Framework.Core.Command cmd)
        {
            return StockFEEventos.ComunesStock.ManejaCantidadAlterna(cmd);
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductos(StockCommon.stkDevolucionesProvDS exch,
        StockCommon.stkDevolucionesProvDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            return ComunesStock.VariablesProductos(exchNoPost.Cuerpo[0].Producto_Id,
                exchNoPost.Cuerpo[0].Deposito_Id, cmd);

        }
        public enum stkDevolucionesProvVar
        {
            ManejaSerieoLote, ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, ManejoDeposito, ManejoCantEntregada, LetraCondFiscal, UsaDespacho, CantidadSoloLectura
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public static string ValirSerieLote(stkDevolucionesProvDS exch, stkDevolucionesProvDS exchNoPost, int pIndice, 
            Framework.Core.Command cmd)
        {

            // No se puede llamar a este método (stkMoviSerieSalidasSolapa.ValirSerieLote) con Merge porque las ds no son iguales //
            // Por eso se escribe todo el código otra vez acá //

            //stkMoviCabeDS dsExch = new stkMoviCabeDS();
            //dsExch.Merge(exch, false, System.Data.MissingSchemaAction.Ignore);

            //stkMoviCabeDS dsExchNoPost = new stkMoviCabeDS();
            //dsExchNoPost.Merge(exchNoPost, false, System.Data.MissingSchemaAction.Ignore);

            //return stkMoviSerieSalidasSolapa.ValirSerieLote(dsExch, dsExchNoPost, pIndice, cmd);

            StockExchange.stkExistenciaSerieActionExchange exchSerie = new StockExchange.stkExistenciaSerieActionExchange
    (StockExchange.stkExistenciaSerieActionEnum.EnumstkExistenciaSerieAction.Datos);
            exchSerie.Producto_Id = exchNoPost.Cuerpo[0].Producto_Id;
            exchSerie.Serie = exchNoPost.grdMoviSerie[0].Serie;
            exchSerie.Deposito_Id = exchNoPost.Cuerpo[0].Deposito_Id;

            exchSerie = new StockExchange.stkExistenciaSerieActionExchange
                (Generalidades.QBIInternal.WrapperExecuteActionInternal(new Framework.Core.Exchange(exchSerie), cmd));

            if (!exchSerie.Existe)
                return "Serie_Lote_<0>_en_deposito_<1>_no_existe";
            return "";

        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkDevolucionesProvDS SumarCant(stkDevolucionesProvDS exch, stkDevolucionesProvDS exchNoPost, int pIndice, 
            Framework.Core.Command cmd)
        {
            // No se puede llamar a este método (stkMoviSerieSalidasdasSolapa.SumarCant) con Merge porque las ds no son iguales //
            // Por eso se escribe todo el código otra vez acá //

            //stkMoviCabeDS dsExch = new stkMoviCabeDS();
            //dsExch.Merge(exch, false, System.Data.MissingSchemaAction.Ignore);

            //stkMoviCabeDS dsExchNoPost = new stkMoviCabeDS();
            //string lNombreTablaOld = dsExchNoPost.grdCuerpo.TableName;
            //dsExchNoPost.grdCuerpo.TableName = exchNoPost.Cuerpo.TableName;
            //dsExchNoPost.Merge(exchNoPost, false, System.Data.MissingSchemaAction.Ignore);
            //dsExchNoPost.grdCuerpo.TableName = lNombreTablaOld;

            //stkMoviCabeDS ds = stkMoviSerieSalidasdasSolapa.SumarCant(dsExch, dsExchNoPost, pIndice, cmd);

            //stkEntradasOcDS dsEOC = new stkEntradasOcDS();
            //dsEOC.Merge(ds, false, System.Data.MissingSchemaAction.Ignore);
            //return dsEOC;



            exchNoPost.Cuerpo[0].CantidadForm = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_Condicion]
        public string EnMonedaBase(stkDevolucionesProvDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Moneda_Id == cmd.MonedaBase)
                return "";
            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string Anulado(stkDevolucionesProvDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Anulado)
                return "S";
            return "N";
        }


       


        public static stkDevolucionesProvDS SumarCantU(stkDevolucionesProvDS exch, stkDevolucionesProvDS exchNoPost, int pIndice,
   Framework.Core.Command cmd)
        {
            exchNoPost.Cuerpo[0].CantidadForm = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static stkDevolucionesProvDS AsignarCantidad(stkDevolucionesProvDS exch, stkDevolucionesProvDS exchNoPost, int pIndice,
    Framework.Core.Command cmd)
        {
            if (exchNoPost.Cuerpo[0].CantidadForm == 0)
                return exchNoPost;

            exchNoPost.Ubicaciones[0].Cantidad = 0;
            StockExchange.stkExistenciaUbiActionExchange eExistU = new StockExchange.stkExistenciaUbiActionExchange(StockExchange.stkExistenciaUbiActionEnum.EnumstkExistenciaUbiAction.Datos)
            {
                Deposito_Id = exchNoPost.Cuerpo[0].Deposito_Id,
                Producto_Id = exchNoPost.Cuerpo[0].Producto_Id,
                Ubicacion_Id = exchNoPost.Ubicaciones[0].Ubicacion_Id
            };
            eExistU = new StockExchange.stkExistenciaUbiActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eExistU, cmd));
            if (eExistU.Existe && eExistU.Cantidad > 0)
            {
                decimal lCant = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
                exchNoPost.Ubicaciones[0].Cantidad = Math.Min(exchNoPost.Cuerpo[0].CantidadForm - lCant, eExistU.Cantidad);
            }

            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkDevolucionesProvDS PopularSerie(stkDevolucionesProvDS pCommonDS, stkDevolucionesProvDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            // Se llaman distintos los dt y por eso los tengo que renombrar //
            // En el estándar se llaman grdCuerpo y acá en remitos grdMoviCuerpo //
            pCommonDS.Cuerpo.TableName = "grdCuerpo";
            pCommonDSNoPost.Cuerpo.TableName = "grdCuerpo";
            stkDevolucionesProvDS ds = new stkDevolucionesProvDS();
            ds.Merge(stkMoviSerieSalidasSolapa.PopularSerie(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Add);
            ds.Tables.Remove("Cuerpo");
            ds.Tables["grdCuerpo"].TableName = "Cuerpo";
            return ds;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkDevolucionesProvDS PopularLote(stkDevolucionesProvDS pCommonDS, stkDevolucionesProvDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            // Se llaman distintos los dt y por eso los tengo que renombrar //
            // En el estándar se llaman grdCuerpo y acá en remitos grdMoviCuerpo //
            pCommonDS.Cuerpo.TableName = "grdCuerpo";
            pCommonDSNoPost.Cuerpo.TableName = "grdCuerpo";
            stkDevolucionesProvDS ds = new stkDevolucionesProvDS();
            ds.Merge(stkMoviSerieSalidasSolapa.PopularLote(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Add);
            ds.Tables.Remove("Cuerpo");
            ds.Tables["grdCuerpo"].TableName = "Cuerpo";
            return ds;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkDevolucionesProvDS PopularUbi(stkDevolucionesProvDS pCommonDS, stkDevolucionesProvDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {

            // Se llaman distintos los dt y por eso los tengo que renombrar //
            // En el estándar se llaman grdCuerpo y acá en remitos grdMoviCuerpo //
            pCommonDS.Cuerpo.TableName = "grdCuerpo";
            pCommonDSNoPost.Cuerpo.TableName = "grdCuerpo";
            stkDevolucionesProvDS ds = new stkDevolucionesProvDS();
            ds.Merge(stkEntradasUbicacion.PopularUbi(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Add);
            ds.Tables.Remove("Cuerpo");
            ds.Tables["grdCuerpo"].TableName = "Cuerpo";
            return ds;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkDevolucionesProvDS SumarCantLote(stkDevolucionesProvDS exch, stkDevolucionesProvDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            exchNoPost.Cuerpo[0].CantidadForm = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkDevolucionesProvDS SumarCantSerie(stkDevolucionesProvDS exch, stkDevolucionesProvDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            exchNoPost.Cuerpo[0].CantidadForm = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Marcado ? 1 : 0);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }
    }
}
