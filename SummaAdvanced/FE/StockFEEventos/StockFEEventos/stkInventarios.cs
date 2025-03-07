using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockCommon;
namespace StockFEEventos
{
    public class stkInventarios
    {
        [Generalidades.QFuncion_Condicion]
        public string ManejaCantidadAlterna(StockCommon.stkInventarioDS exch, Framework.Core.Command cmd)
        {
            return ComunesStock.ManejaCantidadAlterna(cmd);
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProducto(stkInventarioDS exch, stkInventarioDS exchNoPost,
    int pIndice, Framework.Core.Command cmd)
        {
            return ComunesStock.VariablesProductos(exchNoPost.Cuerpo[0].Producto_Id, exch.Principal[0].Deposito_Id, cmd);
        }

        public enum stkInventariosVar
        {
            ManejaSerieoLote, ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, ManejoDeposito, ManejoCantEntregada, LetraCondFiscal, UsaDespacho
        }

    }
}
