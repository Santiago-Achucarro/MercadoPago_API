using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockCommon;
namespace StockFEEventos
{
    public class stkRemisionFactura
    {
        

        [Generalidades.QFuncion_Condicion]
        public string ManejaCantidadAlterna(StockCommon.stkRemisionFacturaDS exch, Framework.Core.Command cmd)
        {
            return StockFEEventos.ComunesStock.ManejaCantidadAlterna(cmd);
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarRenglon(stkRemisionFacturaDS exch, stkRemisionFacturaDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {

            stkRemisionFacturaDS.grdCuerpoDataTable dt = exchNoPost.grdCuerpo;
            if (dt[0].CantidadAEntregar > 0)
            {

                if (dt[0].Deposito_Id == "")
                    return "Debe_informar_el_deposito";
                if (dt[0].CantidadAEntregar > dt[0].CantidadPendienteOrig)
                    Generalidades.qFunctionalException.GenerarExcepcion(
                        "La_Cantidad_A_Entregar_No_Puede_Ser_Mayor_A_<0>", new object[] { dt[0].CantidadPendienteOrig });
            }            
            return "";
        }

        [Generalidades.QFuncion_Condicion]
        public string EnMonedaBase(stkRemisionFacturaDS exch, Framework.Core.Command cmd)
        {
            return "S";
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductos(stkRemisionFacturaDS exch,
           stkRemisionFacturaDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            return ComunesStock.VariablesProductos(exchNoPost.grdCuerpo[0].Producto_Id,
                    exchNoPost.grdCuerpo[0].Deposito_Id, cmd);

        }

        public enum stkRemisionFacturaVar
        {
            ManejaSerieoLote, ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, ManejoDeposito, ManejoCantEntregada, LetraCondFiscal, UsaDespacho, ManejaUbicacion
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkRemisionFacturaDS SumarCant(stkRemisionFacturaDS exch,
            stkRemisionFacturaDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {

            exchNoPost.grdCuerpo[0].CantidadAEntregar= exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;

        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValirSerieLote(stkRemisionFacturaDS exch, stkRemisionFacturaDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {

            StockExchange.stkExistenciaSerieActionExchange exchSerie = new StockExchange.stkExistenciaSerieActionExchange
                (StockExchange.stkExistenciaSerieActionEnum.EnumstkExistenciaSerieAction.Datos);
            exchSerie.Producto_Id = exchNoPost.grdCuerpo[0].Producto_Id;
            exchSerie.Serie = exchNoPost.grdMoviSerie[0].Serie;
            exchSerie.Deposito_Id = exchNoPost.grdCuerpo[0].Deposito_Id;

            exchSerie = new StockExchange.stkExistenciaSerieActionExchange
                (Generalidades.QBIInternal.WrapperExecuteActionInternal(new Framework.Core.Exchange(exchSerie), cmd));

            if (!exchSerie.Existe)
                return "Serie_Lote_<0>_en_deposito_<1>_no_existe";
            return "";

        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkRemisionFacturaDS LlenarFactor(stkRemisionFacturaDS exch, stkRemisionFacturaDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {

            StockExchange.stkArtiUMActionExchange exchArtiUM = StockValidacion.stkArtiUM.PerteneceUMProd
                (exchNoPost.grdCuerpo[0].Producto_Id, exchNoPost.grdCuerpo[0].Medida_Id, cmd);

            exchNoPost.grdCuerpo[0].Factor = exchArtiUM.Factor;
            exchNoPost.AcceptChanges();

            return exchNoPost;

        }
        /*
        [Generalidades.QFuncion_AccionGrilla]
        public stkRemisionFacturaDS LlenarUM(stkRemisionFacturaDS exch, stkRemisionFacturaDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            StockExchange.stkProductosActionExchange exchProd = StockValidacion.stkProductos.ExistePosteadoyActivo
                (exchNoPost.grdCuerpo[0].Producto_Id, cmd);

            exchNoPost.grdCuerpo[0].Medida_Id = exchProd.Medida_Id;
            exchNoPost.grdCuerpo[0].Factor = 1;
            exchNoPost.grdCuerpo[0].MedidaAlterna = exchProd.MedidaAlterna;
            exchNoPost.AcceptChanges();

            return exchNoPost;

        }
        */
        

        [Generalidades.QFuncion_AccionGrilla]
        public static stkRemisionFacturaDS AsignarCantidad(stkRemisionFacturaDS exch, stkRemisionFacturaDS exchNoPost, int pIndice,
      Framework.Core.Command cmd)
        {
            if (pIndice < 0)
                pIndice = exchNoPost.Ubicaciones.Count-1;

            if (exchNoPost.grdCuerpo[0].CantidadAEntregar== 0)
                return exchNoPost;

            exchNoPost.Ubicaciones[pIndice].Cantidad = 0;
            StockExchange.stkExistenciaUbiActionExchange eExistU = new StockExchange.stkExistenciaUbiActionExchange(StockExchange.stkExistenciaUbiActionEnum.EnumstkExistenciaUbiAction.Datos)
            {
                Deposito_Id = exchNoPost.grdCuerpo[0].Deposito_Id,
                Producto_Id = exchNoPost.grdCuerpo[0].Producto_Id,
                Ubicacion_Id = exchNoPost.Ubicaciones[pIndice].Ubicacion_Id
            };
            eExistU = new StockExchange.stkExistenciaUbiActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eExistU, cmd));
            if (eExistU.Existe && eExistU.Cantidad > 0)
            {
                decimal lCant = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
                exchNoPost.Ubicaciones[pIndice].Cantidad = Math.Min(exchNoPost.grdCuerpo[0].CantidadAEntregar- lCant, eExistU.Cantidad);
            }

            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        public static stkRemisionFacturaDS SumarCantU(stkRemisionFacturaDS exch, stkRemisionFacturaDS exchNoPost, int pIndice,
     Framework.Core.Command cmd)
        {
            exchNoPost.grdCuerpo[0].CantidadAEntregar= exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

    }
}
