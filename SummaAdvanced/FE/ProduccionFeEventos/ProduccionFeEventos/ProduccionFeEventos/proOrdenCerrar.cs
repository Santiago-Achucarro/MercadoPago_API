using ProduccionCommon;
using StockFEEventos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduccionFeEventos
{
    public class proOrdenCerrar
    {
        [Generalidades.QFuncion_Condicion]
        public string PideCausa(ProduccionCommon.proOrdenCerrarrDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].CantIngPendiente != exch.Orden[0].CantPendiente && exch.Principal[0].TipoCierre == "1")
                return "S";
            return "N";
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductosConsumo(proOrdenCerrarrDS exch,
            proOrdenCerrarrDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            return ComunesStock.VariablesProductos(exchNoPost.Productos[0].Producto_Id, exchNoPost.Productos[0].Deposito_Id, cmd);

        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductosProduccion(proOrdenCerrarrDS exch,
          proOrdenCerrarrDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            return ComunesStock.VariablesProductos(exchNoPost.Producciones[0].Producto_Id, exchNoPost.Producciones[0].Deposito_Id, cmd);

        }
        public enum proOrdenCerrarVar
        {
            ManejaSerieoLote, ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, ManejoDeposito, ManejoCantEntregada, LetraCondFiscal, UsaDespacho, ManejaUbicacion, CantidadSoloLectura
        }



        [Generalidades.QFuncion_AccionGrilla]
        public proOrdenCerrarrDS SumarCantConsumo(proOrdenCerrarrDS exch, proOrdenCerrarrDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {

            exchNoPost.Productos[0].Cantidad = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }



        [Generalidades.QFuncion_AccionGrilla]
        public proOrdenCerrarrDS SumarCantProduccion(proOrdenCerrarrDS exch, proOrdenCerrarrDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {

            exchNoPost.Producciones[0].Cantidad = exchNoPost.SerieProduccion.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_Condicion]
        public string ManejaCantidadAlterna(proOrdenCerrarrDS exch, Framework.Core.Command cmd)
        {
            return StockFEEventos.ComunesStock.ManejaCantidadAlterna(cmd);
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValirSerieLoteConsumo(proOrdenCerrarrDS exch, proOrdenCerrarrDS exchNoPost,
          int pIndice, Framework.Core.Command cmd)
        {

            StockExchange.stkExistenciaSerieActionExchange exchSerie = new StockExchange.stkExistenciaSerieActionExchange
                (StockExchange.stkExistenciaSerieActionEnum.EnumstkExistenciaSerieAction.Datos);
            exchSerie.Producto_Id = exchNoPost.Productos[0].Producto_Id;
            exchSerie.Serie = exchNoPost.grdMoviSerie[0].Serie;
            exchSerie.Deposito_Id = exchNoPost.Productos[0].Deposito_Id;

            exchSerie = new StockExchange.stkExistenciaSerieActionExchange
                (Generalidades.QBIInternal.WrapperExecuteActionInternal(new Framework.Core.Exchange(exchSerie), cmd));

            if (!exchSerie.Existe)
                return "Serie_Lote_<0>_en_deposito_<1>_no_existe";
            return "";

        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValirSerieLoteProduccion(proOrdenCerrarrDS exch, proOrdenCerrarrDS exchNoPost,
      int pIndice, Framework.Core.Command cmd)
        {

            /*
            StockExchange.stkExistenciaSerieActionExchange exchSerie = new StockExchange.stkExistenciaSerieActionExchange
                (StockExchange.stkExistenciaSerieActionEnum.EnumstkExistenciaSerieAction.Datos);
            exchSerie.Producto_Id = exchNoPost.Producciones[0].Producto_Id;
            exchSerie.Serie = exchNoPost.SerieProduccion[0].Serie;
            exchSerie.Deposito_Id = exchNoPost.Producciones[0].Deposito_Id;

            exchSerie = new StockExchange.stkExistenciaSerieActionExchange
                (Generalidades.QBIInternal.WrapperExecuteActionInternal(new Framework.Core.Exchange(exchSerie), cmd));

            if (!exchSerie.Existe)
                return "Serie_Lote_<0>_en_deposito_<1>_no_existe";
                */

            return "";

        }


        [Generalidades.QFuncion_AccionGrilla]
        public static proOrdenCerrarrDS AsignarCantidad(proOrdenCerrarrDS exch, proOrdenCerrarrDS exchNoPost, int pIndice,
            Framework.Core.Command cmd)
        {

            if (exchNoPost.Producciones.Count > 0)
            {

                if (exchNoPost.Producciones[0].Cantidad == 0)
                    return exchNoPost;

                decimal lCant = exchNoPost.UbicacionesE.ToList().Sum(r => r.Cantidad);
                exchNoPost.UbicacionesE[0].Cantidad = Math.Max(exchNoPost.Producciones[0].Cantidad - lCant, 0);
            }
            else
            {
                exchNoPost.Ubicaciones[0].Cantidad = 0;
                StockExchange.stkExistenciaUbiActionExchange eExistU = new StockExchange.stkExistenciaUbiActionExchange(StockExchange.stkExistenciaUbiActionEnum.EnumstkExistenciaUbiAction.Datos)
                {
                    Deposito_Id = exchNoPost.Productos[0].Deposito_Id,
                    Producto_Id = exchNoPost.Productos[0].Producto_Id,
                    Ubicacion_Id = exchNoPost.Ubicaciones[0].Ubicacion_Id
                };
                eExistU = new StockExchange.stkExistenciaUbiActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eExistU, cmd));
                if (eExistU.Existe && eExistU.Cantidad > 0)
                {
                    decimal lCant = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
                    exchNoPost.Ubicaciones[0].Cantidad = Math.Min(exchNoPost.Productos[0].Cantidad - lCant, eExistU.Cantidad);
                }


            }

            exchNoPost.AcceptChanges();

            return exchNoPost;
        }


        public static proOrdenCerrarrDS SumarCantU(proOrdenCerrarrDS exch, proOrdenCerrarrDS exchNoPost, int pIndice,
            Framework.Core.Command cmd)
        {

            if (exchNoPost.Producciones.Count > 0)
                exchNoPost.Producciones[0].Cantidad = exchNoPost.UbicacionesE.ToList().Sum(r => r.Cantidad);
            else
                exchNoPost.Productos[0].Cantidad = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);

            exchNoPost.AcceptChanges();
            return exchNoPost;
        }


        [Generalidades.QFuncion_AccionGrilla]
        public static proOrdenCerrarrDS PegarSerie(proOrdenCerrarrDS exch, proOrdenCerrarrDS exchNoPost, int pIndice,
          Framework.Core.Command cmd)
        {
            if (String.IsNullOrEmpty(exchNoPost.Producciones[0].ParaPegar))
                Generalidades.qFunctionalException.GenerarExcepcion("Debe_Pegar_Las_Series_Primero");

            StockExchange.stkProductosActionExchange eProd = StockValidacion.stkProductos.ExistePosteadoyActivo(exchNoPost.Producciones[0].Producto_Id, cmd);
            StockExchange.stkDepositosActionExchange eDepo = StockValidacion.stkDepositos.ExistePosteadoyActivo(exchNoPost.Producciones[0].Deposito_Id, cmd);


            if (eProd.Serializable || eProd.TrabajaPorLotes)
            {
                foreach (string reng in exchNoPost.Producciones[0].ParaPegar.Split('\n'))
                {

                    if (!String.IsNullOrEmpty(reng))
                    {
                        string lSerie = "";
                        decimal lCantidad = 1;
                        DateTime lCaducidad = Generalidades.Nulls.NullDate;
                        string lUbicacion = "";
                        int i = 0;
                        lSerie = reng.Split('\t')[i++];
                        if (eProd.TrabajaPorLotes)
                        {
                            lCantidad = ComunesStock.toDecimal(reng.Split('\t')[i++]);
                            if (eProd.conVencimiento)
                                lCaducidad = ComunesStock.toDate(reng.Split('\t')[i++]);
                        }
                        if (eDepo.UsaUbicacion)
                            lUbicacion = reng.Split('\t')[i++];
                        exchNoPost.SerieProduccion.AddSerieProduccionRow(0, exchNoPost.Producciones[0].Renglon, lSerie, lCantidad, lCaducidad, lUbicacion);
                    }
                }
                exchNoPost.Producciones[0].Cantidad = exchNoPost.SerieProduccion.Sum(c => c.Cantidad);

               
            }
            return exchNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public proOrdenCerrarrDS PopularSerie(proOrdenCerrarrDS pCommonDS, proOrdenCerrarrDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            // Se llaman distintos los dt y por eso los tengo que renombrar //
            // En el estándar se llaman grdCuerpo y acá en Producción se llama Productos //
            pCommonDS.Productos.TableName = "grdCuerpo";
            pCommonDSNoPost.Productos.TableName = "grdCuerpo";
            proOrdenCerrarrDS ds = new proOrdenCerrarrDS();
            ds.Merge(stkMoviSerieSalidasSolapa.PopularSerie(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Add);
            ds.Tables.Remove("Productos");
            ds.Tables["grdCuerpo"].TableName = "Productos";
            return ds;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public proOrdenCerrarrDS PopularLote(proOrdenCerrarrDS pCommonDS, proOrdenCerrarrDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            // Se llaman distintos los dt y por eso los tengo que renombrar //
            // En el estándar se llaman grdCuerpo y acá en Producción se llama Productos //
            pCommonDS.Productos.TableName = "grdCuerpo";
            pCommonDSNoPost.Productos.TableName = "grdCuerpo";
            proOrdenCerrarrDS ds = new proOrdenCerrarrDS();
            ds.Merge(stkMoviSerieSalidasSolapa.PopularLote(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Add);
            ds.Tables.Remove("Productos");
            ds.Tables["grdCuerpo"].TableName = "Productos";
            return ds;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public proOrdenCerrarrDS PopularUbi(proOrdenCerrarrDS pCommonDS, proOrdenCerrarrDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            // Se llaman distintos los dt y por eso los tengo que renombrar //
            // En el estándar se llaman grdCuerpo y acá en Producción se llama Productos //
            pCommonDS.Productos.TableName = "grdCuerpo";
            pCommonDSNoPost.Productos.TableName = "grdCuerpo";
            proOrdenCerrarrDS ds = new proOrdenCerrarrDS();
            ds.Merge(stkEntradasUbicacion.PopularUbi(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Add);
            ds.Tables.Remove("Productos");
            ds.Tables["grdCuerpo"].TableName = "Productos";
            return ds;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public proOrdenCerrarrDS SumarCantLote(proOrdenCerrarrDS pCommonDS, proOrdenCerrarrDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            pCommonDSNoPost.Productos[0].Cantidad = pCommonDSNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            pCommonDSNoPost.AcceptChanges();

            return pCommonDSNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public proOrdenCerrarrDS SumarCantSerie(proOrdenCerrarrDS pCommonDS, proOrdenCerrarrDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            pCommonDSNoPost.Productos[0].Cantidad = pCommonDSNoPost.grdMoviSerie.ToList().Sum(r => r.Marcado ? 1 : 0);
            pCommonDSNoPost.AcceptChanges();

            return pCommonDSNoPost;
        }

    }
}
