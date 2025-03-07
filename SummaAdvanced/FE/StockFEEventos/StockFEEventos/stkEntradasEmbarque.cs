using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockCommon;

namespace StockFEEventos
{
    public class stkEntradasEmbarque
    {
        [Generalidades.QFuncion_Condicion]
        public string ManejaCantidadAlterna(StockCommon.stkEntradasEmbarqueDS exch, Framework.Core.Command cmd)
        {
            return StockFEEventos.ComunesStock.ManejaCantidadAlterna(cmd);
        }

        [Generalidades.QFuncion_Condicion]
        public string EnMonedaBase(StockCommon.stkEntradasEmbarqueDS exch, Framework.Core.Command cmd)
        {
            return exch.Principal[0].Moneda_Id == cmd.MonedaBase ? "S" : "N";
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductos(stkEntradasEmbarqueDS exch,
        stkEntradasEmbarqueDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            return StockFEEventos.ComunesStock.VariablesProductos(exchNoPost.grdCuerpo[0].Producto_Id,
                    exchNoPost.grdCuerpo[0].Deposito_Id, cmd);

        }
        public enum stkEntradasEmbarqueVar
        {
            ManejaSerieoLote, ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, ManejoDeposito, ManejoCantEntregada, LetraCondFiscal, UsaDespacho, ManejaUbicacion
        }


        [Generalidades.QFuncion_AccionGrilla]
        public stkEntradasEmbarqueDS SumarCant(stkEntradasEmbarqueDS exch, stkEntradasEmbarqueDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {

            exchNoPost.grdCuerpo[0].CantidadForm = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;

        }

        [Generalidades.QFuncion_Condicion]
        public string Anulado(stkEntradasEmbarqueDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Anulado)
                return "S";
            return "N";
        }

        public static stkEntradasEmbarqueDS SumarCantU(stkEntradasEmbarqueDS exch, stkEntradasEmbarqueDS exchNoPost, int pIndice,
         Framework.Core.Command cmd)
        {
            exchNoPost.grdCuerpo[0].CantidadForm = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public StockCommon.stkEntradasEmbarqueDS PegarSerie(StockCommon.stkEntradasEmbarqueDS pCommonDS, StockCommon.stkEntradasEmbarqueDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {



            if (!string.IsNullOrWhiteSpace(pCommonDSNoPost.grdCuerpo[0].PegarSeries))
            {
                StockExchange.stkProductosActionExchange eProd = StockValidacion.stkProductos.ExistePosteadoyActivo(pCommonDSNoPost.grdCuerpo[0].Producto_Id, cmd);
                StockExchange.stkDepositosActionExchange eDepo = StockValidacion.stkDepositos.ExistePosteadoyActivo(pCommonDSNoPost.grdCuerpo[0].Deposito_Id, cmd);


                if (eProd.Serializable || eProd.TrabajaPorLotes)
                {
                    foreach (string reng in pCommonDSNoPost.grdCuerpo[0].PegarSeries.Split('\n'))
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
                        pCommonDSNoPost.grdMoviSerie.AddgrdMoviSerieRow(pCommonDSNoPost.grdCuerpo[0].stkMoviCabe, pCommonDSNoPost.grdCuerpo[0].Renglon, lSerie, lCantidad, lCaducidad, lUbicacion);

                    }
                    pCommonDSNoPost.grdCuerpo[0].CantidadForm = pCommonDSNoPost.grdMoviSerie.Sum(c => c.Cantidad);
                }
            }


            return pCommonDSNoPost;
        }
    }
}
