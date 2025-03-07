using StockCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockFEEventos
{
    public class stkSalidasRemitoConsultaDrillDown
    {
        [Generalidades.QFuncion_Condicion]
        public string PendienteFacturacion(StockCommon.stkSalidasRemitoConsultaDrillDownDS exch, Framework.Core.Command cmd)
        {
            return (exch.stkMoviCausa[0].PendienteFacturacion ? "S" : "N");
        }

        [Generalidades.QFuncion_Condicion]
        public string ManejaCantidadAlterna(StockCommon.stkSalidasRemitoConsultaDrillDownDS exch, Framework.Core.Command cmd)
        {
            return StockFEEventos.ComunesStock.ManejaCantidadAlterna(cmd);
        }

        [Generalidades.QFuncion_Condicion]
        public string EnMonedaBase(stkSalidasRemitoConsultaDrillDownDS exch, Framework.Core.Command cmd)
        {
            if (exch.stkRemitos[0].Moneda_Id != cmd.MonedaBase)
                return "N";

            return "S";
        }


        public enum stkSalidasRemitoConsultaDrillDownVar
        {
            ManejaSerieoLote, ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, ManejoDeposito, ManejoCantEntregada, LetraCondFiscal, UsaDespacho, ManejaUbicacion
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductos(stkSalidasRemitoConsultaDrillDownDS exch, stkSalidasRemitoConsultaDrillDownDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            return ComunesStock.VariablesProductos(exchNoPost.grdMoviCuerpo[0].Producto_Id,
                   exchNoPost.grdMoviCuerpo[0].Deposito_Id, cmd);
        }

        [Generalidades.QFuncion_Condicion]
        public string Anulado(stkSalidasRemitoConsultaDrillDownDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Anulado)
                return "S";
            return "N";
        }
    }
}
