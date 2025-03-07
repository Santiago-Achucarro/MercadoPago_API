using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockCommon;

namespace StockFEEventos
{
    public class stkEntradasOC
    {
        [Generalidades.QFuncion_Condicion]
        public string ManejaCantidadAlterna(StockCommon.stkEntradasOcDS exch, Framework.Core.Command cmd)
        {
            return StockFEEventos.ComunesStock.ManejaCantidadAlterna(cmd);
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductos(stkEntradasOcDS exch,
        stkEntradasOcDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            return ComunesStock.VariablesProductos(exchNoPost.Cuerpo[0].Producto_Id, exchNoPost.Cuerpo[0].Deposito_Id, cmd);

        }
        public enum stkEntradasOCVar
        {
            ManejaSerieoLote, ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, ManejoDeposito, ManejoCantEntregada, LetraCondFiscal, UsaDespacho, ManejaUbicacion, CantidadSoloLectura
        }


        [Generalidades.QFuncion_AccionGrilla]
        public stkEntradasOcDS SumarCant(stkEntradasOcDS exch, stkEntradasOcDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            // No se puede llamar a este método (stkMoviSerieEntradasSolapa.SumarCant) con Merge porque las ds no son iguales //
            // Por eso se escribe todo el código otra vez acá //

            //stkMoviCabeDS dsExch = new stkMoviCabeDS();
            //dsExch.Merge(exch, false, System.Data.MissingSchemaAction.Ignore);

            //stkMoviCabeDS dsExchNoPost = new stkMoviCabeDS();
            //string lNombreTablaOld = dsExchNoPost.grdCuerpo.TableName;
            //dsExchNoPost.grdCuerpo.TableName = exchNoPost.Cuerpo.TableName;
            //dsExchNoPost.Merge(exchNoPost, false, System.Data.MissingSchemaAction.Ignore);
            //dsExchNoPost.grdCuerpo.TableName = lNombreTablaOld;

            //stkMoviCabeDS ds = stkMoviSerieEntradasSolapa.SumarCant(dsExch, dsExchNoPost, pIndice, cmd);

            //stkEntradasOcDS dsEOC = new stkEntradasOcDS();
            //dsEOC.Merge(ds, false, System.Data.MissingSchemaAction.Ignore);
            //return dsEOC;



            exchNoPost.Cuerpo[0].CantidadForm = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        public static stkEntradasOcDS SumarCantU(stkEntradasOcDS exch, stkEntradasOcDS exchNoPost, int pIndice,
          Framework.Core.Command cmd)
        {
            exchNoPost.Cuerpo[0].CantidadForm = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_Condicion]
        public string EnMonedaBase(StockCommon.stkEntradasOcDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Moneda_Id == cmd.MonedaBase)
                return "";
            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string Anulado(StockCommon.stkEntradasOcDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Anulado)
                return "S";
            return "N";
        }

        [Generalidades.QFuncion_AccionGrilla]
        public StockCommon.stkEntradasOcDS PegarSerie(StockCommon.stkEntradasOcDS pCommonDS, StockCommon.stkEntradasOcDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {

            if (!string.IsNullOrWhiteSpace(pCommonDSNoPost.Cuerpo[0].PegarSeries))
            {

                if (!string.IsNullOrWhiteSpace(pCommonDSNoPost.Cuerpo[0].PegarSeries))
                {
                    StockExchange.stkProductosActionExchange eProd = StockValidacion.stkProductos.ExistePosteadoyActivo(pCommonDSNoPost.Cuerpo[0].Producto_Id, cmd);
                    StockExchange.stkDepositosActionExchange eDepo = StockValidacion.stkDepositos.ExistePosteadoyActivo(pCommonDSNoPost.Cuerpo[0].Deposito_Id, cmd);


                    if (eProd.Serializable || eProd.TrabajaPorLotes)
                    {
                        foreach (string reng in pCommonDSNoPost.Cuerpo[0].PegarSeries.Split('\n'))
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
                                pCommonDSNoPost.grdMoviSerie.AddgrdMoviSerieRow(pCommonDSNoPost.Cuerpo[0].stkMoviCabe, pCommonDSNoPost.Cuerpo[0].Renglon, lSerie, lCantidad, lCaducidad, lUbicacion);
                            }
                        }
                        pCommonDSNoPost.Cuerpo[0].CantidadForm = pCommonDSNoPost.grdMoviSerie.Sum(c => c.Cantidad);
                    }
                }
            }

            return pCommonDSNoPost;
        }
     
    }
}
