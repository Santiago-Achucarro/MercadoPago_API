using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockCommon;
using System.Data;

namespace StockFEEventos
{
    public class stkMoviCabeEntradasCausa
    {
        [Generalidades.QFuncion_Condicion]
        public string ManejaCantidadAlterna(stkMoviCabeDatosCausaDS exch, Framework.Core.Command cmd)
        {
            return StockFEEventos.ComunesStock.ManejaCantidadAlterna(cmd);
        }

        [Generalidades.QFuncion_Condicion]
        public string ManejaSerieLote(stkMoviCabeDatosCausaDS exch, Framework.Core.Command cmd)
        {
            //if (exch.grdCuerpo)
            return "N";
        }


        [Generalidades.QFuncion_AccionGrilla]
        public stkMoviCabeDatosCausaDS LlenarUM(stkMoviCabeDatosCausaDS exch, stkMoviCabeDatosCausaDS exchNoPost, 
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

        [Generalidades.QFuncion_AccionGrilla]
        public stkMoviCabeDatosCausaDS LlenarUMySerieDespa(stkMoviCabeDatosCausaDS exch, stkMoviCabeDatosCausaDS exchNoPost, 
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

        [Generalidades.QFuncion_AccionGrilla]
        public stkMoviCabeDatosCausaDS LlenarFactor(stkMoviCabeDatosCausaDS exch, stkMoviCabeDatosCausaDS exchNoPost, 
            int pIndice, Framework.Core.Command cmd)
        {
            StockExchange.stkArtiUMActionExchange exchArtiUM = StockValidacion.stkArtiUM.PerteneceUMProd
                 (exchNoPost.grdCuerpo[0].Producto_Id, exchNoPost.grdCuerpo[0].Medida_Id, cmd);

            exchNoPost.grdCuerpo[0].Factor = exchArtiUM.Factor;
            exchNoPost.AcceptChanges();

            return exchNoPost;

        }

        
        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductos(stkMoviCabeDatosCausaDS exch, stkMoviCabeDatosCausaDS exchNoPost,
    int pIndice, Framework.Core.Command cmd)
        {
            return ComunesStock.VariablesProductos(exchNoPost.grdCuerpo[0].Producto_Id,
                    exchNoPost.grdCuerpo[0].Deposito_Id, cmd);
        }


        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarRenglonCuerpo(stkMoviCabeDatosCausaDS exch, stkMoviCabeDatosCausaDS exchNoPost, 
            int pIndice, Framework.Core.Command cmd)
        {

            if (exchNoPost.grdCuerpo[0].Producto_Id == "")
                return "Debe_informar_un_producto";

            if (exchNoPost.grdCuerpo[0].Medida_Id == "")
                return "Debe_informar_una_Unidad_de_medida";

            if (exchNoPost.grdCuerpo[0].Deposito_Id == "")
                return "Debe_informar_un_deposito";

            if (!(exchNoPost.grdCuerpo[0].CantidadForm > 0))
                return "La_cantidad_debe_ser_mayor_que_cero";

            if (exchNoPost.grdCuerpo[0].CantidadAlternaForm < 0)
                return "La_cantidad_alternativa_debe_ser_mayor_o_igual_que_cero";

            //TODO FM falta validar el despacho. Ver cómo evitar buscar el producto otra vez

            return "";

        }

        public enum stkMoviCabeEntradasCausaVar
        {
            ManejaSerieoLote, ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, ManejoDeposito, ManejoCantEntregada, LetraCondFiscal, UsaDespacho, ManejaUbicacion, DepositoDefecto
        }


        [Generalidades.QFuncion_AccionGrilla]
        public stkMoviCabeDatosCausaDS SumarCant(stkMoviCabeDatosCausaDS exch, stkMoviCabeDatosCausaDS exchNoPost,
    int pIndice, Framework.Core.Command cmd)
        {

            exchNoPost.grdCuerpo[0].CantidadForm = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;

        }

        public static stkMoviCabeDatosCausaDS SumarCantU(stkMoviCabeDatosCausaDS exch, stkMoviCabeDatosCausaDS exchNoPost, int pIndice,
     Framework.Core.Command cmd)
        {
            exchNoPost.grdCuerpo[0].CantidadForm = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_Condicion]
        public string Anulado(stkMoviCabeDatosCausaDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Anulado)
                return "S";
            return "N";
        }
    }
}
