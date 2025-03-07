using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockCommon;

namespace StockFEEventos
{
    public class stkMoviCabe
    {
        [Generalidades.QFuncion_Condicion]
        public string ManejaCantidadAlterna(stkMoviCabeDS exch, Framework.Core.Command cmd)
        {
            return StockFEEventos.ComunesStock.ManejaCantidadAlterna(cmd);
        }


        [Generalidades.QFuncion_AccionGrilla]
        public stkMoviCabeDS LlenarUM(stkMoviCabeDS exch, stkMoviCabeDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            StockExchange.stkProductosActionExchange exchProd = StockValidacion.stkProductos.ExistePosteadoyActivo
                 (exchNoPost.grdCuerpo[0].Producto_Id, cmd);

            exchNoPost.grdCuerpo[0].Medida_Id = exchProd.Medida_Id;
            exchNoPost.grdCuerpo[0].DescripcionUniMed = exchProd.DescripcionUniMed;
            exchNoPost.grdCuerpo[0].Factor = 1;
            exchNoPost.grdCuerpo[0].MedidaAlterna = exchProd.MedidaAlterna;
            exchNoPost.grdCuerpo[0].DescripcionMedidaAlterna = exchProd.DescripcionMedidaAlterna;
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkMoviCabeDS LlenarFactor(stkMoviCabeDS exch, stkMoviCabeDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            StockExchange.stkArtiUMActionExchange exchArtiUM = StockValidacion.stkArtiUM.PerteneceUMProd
                 (exchNoPost.grdCuerpo[0].Producto_Id, exchNoPost.grdCuerpo[0].Medida_Id, cmd);

            exchNoPost.grdCuerpo[0].Factor = exchArtiUM.Factor;
            exchNoPost.AcceptChanges();

            return exchNoPost;

        }


        [Generalidades.QFuncion_AccionGrilla]
        public stkMoviCabeDS AsignarPrecio(stkMoviCabeDS exch, stkMoviCabeDS exchNoPost,
           int pIndice, Framework.Core.Command cmd)
        {

            if (exchNoPost.grdCuerpo[0].Factor > 0 && exchNoPost.grdCuerpo[0].PrecioOriginal == 0)
            {
                StockExchange.stkProductosCostosActionExchange eCosto =
                        new StockExchange.stkProductosCostosActionExchange(StockExchange.stkProductosCostosActionEnum.EnumstkProductosCostosAction.Datos);
                eCosto.Producto_Id = exchNoPost.grdCuerpo[0].Producto_Id;
                eCosto.Empresa_Id = cmd.Empresa_Id;
                eCosto = new StockExchange.stkProductosCostosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eCosto, cmd));
                if (eCosto.Existe)
                {
                    exchNoPost.grdCuerpo[0].PrecioOriginal = eCosto.PrecioUltCompra * exchNoPost.grdCuerpo[0].Factor;
                }
                else
                {
                    StockExchange.stkProductosActionExchange exchProd = StockValidacion.stkProductos.Existe
                        (exchNoPost.grdCuerpo[0].Producto_Id, cmd);

                    exchNoPost.grdCuerpo[0].PrecioOriginal = exchProd.PrecioUltCompra * exchNoPost.grdCuerpo[0].Factor;


                }


                exchNoPost.AcceptChanges();
            }

            return exchNoPost;

        }



        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarRenglonCuerpo(stkMoviCabeDS exch, stkMoviCabeDS exchNoPost,
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

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductos(stkMoviCabeDS exch,
          stkMoviCabeDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            return ComunesStock.VariablesProductos(exchNoPost.grdCuerpo[0].Producto_Id,
                    exchNoPost.grdCuerpo[0].Deposito_Id, cmd);

        }

        public enum stkMoviCabeVar
        {
            ManejaSerieoLote, ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, ManejoDeposito, ManejoCantEntregada, LetraCondFiscal, UsaDespacho, ManejaUbicacion, DepositoDefecto, CantidadSoloLectura
        }

    }
}
