using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockCommon;

namespace StockFEEventos
{
    public class stkEntradasRemito
    {
        [Generalidades.QFuncion_Condicion]
        public string ManejaCantidadAlterna(StockCommon.stkEntradasCancRemiPendDS exch, Framework.Core.Command cmd)
        {
            return StockFEEventos.ComunesStock.ManejaCantidadAlterna(cmd);
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductos(stkEntradasCancRemiPendDS exch,
        stkEntradasCancRemiPendDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            return ComunesStock.VariablesProductos(exchNoPost.Cuerpo[0].Producto_Id, exchNoPost.Cuerpo[0].Deposito_Id, cmd);

        }
        public enum stkEntradasCancRemiPendVar
        {
            ManejaSerieoLote, ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, ManejoDeposito, ManejoCantEntregada, LetraCondFiscal, UsaDespacho, ManejaUbicacion
        }


        [Generalidades.QFuncion_AccionGrilla]
        public stkEntradasCancRemiPendDS SumarCant(stkEntradasCancRemiPendDS exch, stkEntradasCancRemiPendDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {

            exchNoPost.Cuerpo[0].CantidadForm = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        public static stkEntradasCancRemiPendDS SumarCantU(stkEntradasCancRemiPendDS exch, stkEntradasCancRemiPendDS exchNoPost, int pIndice,
          Framework.Core.Command cmd)
        {
            exchNoPost.Cuerpo[0].CantidadForm = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_Condicion]
        public string EnMonedaBase(StockCommon.stkEntradasCancRemiPendDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Moneda_Id == cmd.MonedaBase)
                return "";
            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string Anulado(StockCommon.stkEntradasCancRemiPendDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Anulado)
                return "S";
            return "N";
        }

    }
}
