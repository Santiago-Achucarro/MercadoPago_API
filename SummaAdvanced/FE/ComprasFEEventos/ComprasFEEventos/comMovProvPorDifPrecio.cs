using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
namespace ComprasFEEventos
{
    public class comMovProvPorDifPrecio
    {
        [Generalidades.QFuncion_Condicion]
        public string EsMonedaBase(ComprasCommon.comMovProvDatosPorDifPrecioDS exch, Command cmd)
        {
            if (exch.Principal[0].Moneda_Id == cmd.MonedaBase || exch.Principal[0].Moneda_Id.Trim() == "")
                return "S";

            return "N";

        }

        [Generalidades.QFuncion_Condicion]
        public string PideCuotas(ComprasCommon.comMovProvDatosPorDifPrecioDS exch, Command cmd)
        {

            return exch.Principal[0].CantCuotas > 1 ? "S" : "N";

        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaImp(ComprasCommon.comMovProvDatosPorDifPrecioDS exch, ComprasCommon.comMovProvDatosPorDifPrecioDS exchNoPost,
           int pIndice, Command cmd)
        {
            ComprasCommon.comMovProvDatosPorDifPrecioDS.grdImpuestosDataTable lDF = exchNoPost.grdImpuestos;

            if (lDF[0].Impuesto_Id == "")
                return "El_Impuesto_No_puede_ser_Vacio";

            // TODO DUPLICADO

            return "";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFila(ComprasCommon.comMovProvDatosPorDifPrecioDS exch, ComprasCommon.comMovProvDatosPorDifPrecioDS exchNoPost,
           int pIndice, Command cmd)
        {


            if (exchNoPost.grdCuerpo[0].Producto_Id == "")
                return "El_Producto_No_puede_ser_Vacio";

            if (exchNoPost.grdCuerpo[0].CantidadForm == 0)
                return "La_cantidad_debe_ser_distinta_a_cero";

            // Valido que exsita la Factura y que tenga el producto

            ComprasExchange.comMovprovFactDifPrecRengActionExchange eDCReng =
                    new ComprasExchange.comMovprovFactDifPrecRengActionExchange(ComprasExchange.comMovprovFactDifPrecRengActionEnum.EnumcomMovprovFactDifPrecRengAction.Datos);

            eDCReng.Segmento_Id = exchNoPost.grdCuerpo[0].Segmento_Id;
            eDCReng.Segmento1C = exchNoPost.grdCuerpo[0].Segmento1C;
            eDCReng.Segmento2C = exchNoPost.grdCuerpo[0].Segmento2C;
            eDCReng.Segmento3C = exchNoPost.grdCuerpo[0].Segmento3C;
            eDCReng.Segmento4C = exchNoPost.grdCuerpo[0].Segmento4C;
            eDCReng.Segmento1N = exchNoPost.grdCuerpo[0].Segmento1N;
            eDCReng.Segmento2N = exchNoPost.grdCuerpo[0].Segmento2N;
            eDCReng.Segmento3N = exchNoPost.grdCuerpo[0].Segmento3N;
            eDCReng.Segmento4N = exchNoPost.grdCuerpo[0].Segmento4N;
            eDCReng.Producto_Id = exchNoPost.grdCuerpo[0].Producto_Id;

            eDCReng = new
                    ComprasExchange.comMovprovFactDifPrecRengActionExchange(
                Generalidades.QBIInternal.WrapperExecuteActionInternal(eDCReng, cmd));

            if (!eDCReng.Existe)
                return "El_Producto_No_esta_en_la_Factura";
            if (eDCReng.CantidadOriginal < exchNoPost.grdCuerpo[0].CantidadForm)
                return "La_cantidad_no_puede_ser_mayor_a_la_de_la_Factura_original";

            exchNoPost.grdCuerpo[0].CantidadOriginal = eDCReng.CantidadOriginal;
            exchNoPost.grdCuerpo[0].ComordenComp = eDCReng.ComordenComp;
            exchNoPost.grdCuerpo[0].Factor = eDCReng.Factor;
            exchNoPost.grdCuerpo[0].Medida_Id = eDCReng.Medida_Id;
            exchNoPost.grdCuerpo[0].MovimientoOrig = eDCReng.MovimientoOrig;
            exchNoPost.grdCuerpo[0].PrecioOriginal = eDCReng.PrecioOriginal;
            exchNoPost.grdCuerpo[0].RenglonOrig = eDCReng.RenglonOrig;
            exchNoPost.grdCuerpo[0].SegmentoStr = eDCReng.SegmentoStr;

            return "";
        }


        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comMovProvDatosPorDifPrecioDS AsignarCantidad(ComprasCommon.comMovProvDatosPorDifPrecioDS exch,
                ComprasCommon.comMovProvDatosPorDifPrecioDS exchNoPost, int pIndice,
                Framework.Core.Command cmd)
        {
            exchNoPost.grdCuerpo[0].Factor = 1;
            if (exchNoPost.grdCuerpo[0].Producto_Id == "")
            {
                return exchNoPost;
            }

            ComprasExchange.comMovprovFactDifPrecRengActionExchange eDCReng =
                  new ComprasExchange.comMovprovFactDifPrecRengActionExchange(ComprasExchange.comMovprovFactDifPrecRengActionEnum.EnumcomMovprovFactDifPrecRengAction.Datos);

            eDCReng.Segmento_Id = exchNoPost.grdCuerpo[0].Segmento_Id;
            eDCReng.Segmento1C = exchNoPost.grdCuerpo[0].Segmento1C;
            eDCReng.Segmento2C = exchNoPost.grdCuerpo[0].Segmento2C;
            eDCReng.Segmento3C = exchNoPost.grdCuerpo[0].Segmento3C;
            eDCReng.Segmento4C = exchNoPost.grdCuerpo[0].Segmento4C;
            eDCReng.Segmento1N = exchNoPost.grdCuerpo[0].Segmento1N;
            eDCReng.Segmento2N = exchNoPost.grdCuerpo[0].Segmento2N;
            eDCReng.Segmento3N = exchNoPost.grdCuerpo[0].Segmento3N;
            eDCReng.Segmento4N = exchNoPost.grdCuerpo[0].Segmento4N;
            eDCReng.Producto_Id = exchNoPost.grdCuerpo[0].Producto_Id;

            eDCReng = new
                    ComprasExchange.comMovprovFactDifPrecRengActionExchange(
                Generalidades.QBIInternal.WrapperExecuteActionInternal(eDCReng, cmd));
           
            if (eDCReng.Existe)
            {
                exchNoPost.grdCuerpo[0].CantidadOriginal = eDCReng.CantidadOriginal;
                exchNoPost.grdCuerpo[0].ComordenComp = eDCReng.ComordenComp;
                exchNoPost.grdCuerpo[0].Factor = eDCReng.Factor;
                exchNoPost.grdCuerpo[0].Medida_Id = eDCReng.Medida_Id;
                exchNoPost.grdCuerpo[0].MovimientoOrig = eDCReng.MovimientoOrig;
                exchNoPost.grdCuerpo[0].PrecioOriginal = eDCReng.PrecioOriginal;
                exchNoPost.grdCuerpo[0].RenglonOrig = eDCReng.RenglonOrig;
                exchNoPost.grdCuerpo[0].SegmentoStr = eDCReng.SegmentoStr;
            }
            return exchNoPost;

        }

        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comMovProvDatosPorDifPrecioDS TotalReng(ComprasCommon.comMovProvDatosPorDifPrecioDS exch,
               ComprasCommon.comMovProvDatosPorDifPrecioDS exchNoPost, int pIndice,
               Framework.Core.Command cmd)
        {

            exchNoPost.grdCuerpo[0].Cantidad = exchNoPost.grdCuerpo[0].CantidadForm *
                    exchNoPost.grdCuerpo[0].Factor;
            if (exchNoPost.grdCuerpo[0].Descuento != 0)
                exchNoPost.grdCuerpo[0].Monto = exchNoPost.grdCuerpo[0].PrecioOriginal *
                        exchNoPost.grdCuerpo[0].Descuento / 100;
            exchNoPost.grdCuerpo[0].Total = Math.Round(
                    exchNoPost.grdCuerpo[0].CantidadForm * exchNoPost.grdCuerpo[0].Monto, 2);
            return exchNoPost;
        }
    }
}

