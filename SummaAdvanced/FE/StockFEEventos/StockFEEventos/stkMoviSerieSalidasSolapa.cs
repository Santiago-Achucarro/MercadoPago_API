using StockCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StockFEEventos
{
    public class stkMoviSerieSalidasSolapa
    {
        [Generalidades.QFuncion_AccionGrilla]
        public static stkMoviCabeDS SumarCantSerie(stkMoviCabeDS exch, stkMoviCabeDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {

            // Si es lote tiene las cantidades y si es serie tiene las marcas //
            // No puede tener las 2 cosas //
            exchNoPost.grdCuerpo[0].CantidadForm = exchNoPost.grdMoviSerie.ToList().Sum(r => !r.Marcado ? 0 : 1);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static stkMoviCabeDS SumarCantLote(stkMoviCabeDS exch, stkMoviCabeDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {

            // Si es lote tiene las cantidades y si es serie tiene las marcas //
            // No puede tener las 2 cosas //
            exchNoPost.grdCuerpo[0].CantidadForm = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public static string ValirSerieLote(stkMoviCabeDS exch, stkMoviCabeDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {

            if (String.IsNullOrEmpty(exchNoPost.grdMoviSerie[0].Serie))
                return "Debe_ingresar_El_Numero_de_Serie_o_Lote";

            StockExchange.stkExistenciaSerieActionExchange exchSerie = new StockExchange.stkExistenciaSerieActionExchange
                (StockExchange.stkExistenciaSerieActionEnum.EnumstkExistenciaSerieAction.Datos);
            exchSerie.Producto_Id = exchNoPost.grdCuerpo[0].Producto_Id;
            exchSerie.Serie = exchNoPost.grdMoviSerie[0].Serie;
            exchSerie.Deposito_Id = exchNoPost.grdCuerpo[0].Deposito_Id;

            exchSerie = new StockExchange.stkExistenciaSerieActionExchange
                (Generalidades.QBIInternal.WrapperExecuteActionInternal(new Framework.Core.Exchange(exchSerie), cmd));

            if (!exchSerie.Existe)
                return "Serie_Lote_<0>_en_deposito_<1>_no_existe";

            // FM 21/05/2019 //
            if (exchNoPost.grdMoviSerie[0].Cantidad <= 0)
                return "Cantidad_invalida";
            // Fin FM //

            return "";
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static stkMoviCabeDS PopularSerie(DataSet pCommonDS1, DataSet pCommonDSNoPost1, int pIndice, Framework.Core.Command cmd)
        {
            // Para poder usarlo desde cualquier formulario de stock, recibo un DataSet genérico y lo convierto //
            stkMoviCabeDS pCommonDS = new stkMoviCabeDS();
            stkMoviCabeDS pCommonDSNoPost = new stkMoviCabeDS();

            pCommonDS.Merge(pCommonDS1, false, MissingSchemaAction.Ignore);
            pCommonDSNoPost.Merge(pCommonDSNoPost1, false, MissingSchemaAction.Ignore);

            // Armo los dt con los lotes/series a elegir si el movimiento es nuevo y no es entrada por CD //
            // Si estoy consultando uno ya existente o es entrada por CD tengo que conservar lo que ya estaba //
            if (pCommonDS.Principal[0].Segmento1N == 0 && !(!pCommonDS.Principal[0].IsTipomovNull() && pCommonDS.Principal[0].Tipomov == "E" && !pCommonDS.Principal[0].IsSubTipoMov_IdNull() && pCommonDS.Principal[0].SubTipoMov_Id == "CDE"))
            {
                // Solo actualizo todo esto si es un movimiento nuevo. No lo tiene que hacer //
                // si estoy consultando uno existente //

                StockExchange.stkExistenciaXSerieXUbiActionExchange exchSerie = new StockExchange.stkExistenciaXSerieXUbiActionExchange(StockExchange.stkExistenciaXSerieXUbiActionEnum.EnumstkExistenciaXSerieXUbiAction.DatosSerie)
                {
                    Producto_Id = pCommonDSNoPost.grdCuerpo[0].Producto_Id,
                    Medida_Id = pCommonDSNoPost.grdCuerpo[0].Medida_Id,
                    Deposito_Id = pCommonDSNoPost.grdCuerpo[0].Deposito_Id
                };
                exchSerie = new StockExchange.stkExistenciaXSerieXUbiActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchSerie, cmd));

                if (pIndice < 0 || pCommonDSNoPost.grdCuerpo[0].Producto_Id != pCommonDS.grdCuerpo[pIndice].Producto_Id || pCommonDSNoPost.grdCuerpo[0].Deposito_Id != pCommonDS.grdCuerpo[pIndice].Deposito_Id || pCommonDSNoPost.grdCuerpo[0].Medida_Id != pCommonDS.grdCuerpo[pIndice].Medida_Id)
                {
                    // Si estoy agregando un nuevo renglón o cambié alguno de los datos de un renglón existente entonces //
                    // populo los serie/lote //

                    pCommonDSNoPost.grdCuerpo[0].CantidadForm = 0;
                    pCommonDSNoPost.grdMoviSerie.Clear();
                    pCommonDSNoPost.grdMoviSerie.Merge(exchSerie.Param.ExistenciasSerie);
                    pCommonDSNoPost.grdMoviSerie.ToList().ForEach(s => s.Marcado = false);

                }

                // Recorro los renglones de las existencias porque pueden haber usado alguna serie/lote en otro renglón //
                // y ya fue borrado entonces lo tengo que agregar porque lo pueden haber borrado del renglón original //
                // y ahora me tiene que volver a aparecer acá //
                exchSerie.Param.ExistenciasSerie.ToList().ForEach(e =>
               {
                   if (pCommonDSNoPost.grdMoviSerie.Where(s => s.Serie == e.Serie && s.Ubicacion_Id == e.Ubicacion_Id).Count() == 0)
                   {
                   // Lo tengo que agregar //
                   pCommonDSNoPost.grdMoviSerie.AddgrdMoviSerieRow(0, pCommonDSNoPost.grdCuerpo[0].Renglon, e.Serie, 0, e.Vencimiento, e.Ubicacion_Id, e.Existencia, false);
                   }

                   else
                       pCommonDSNoPost.grdMoviSerie.Where(s => s.Serie == e.Serie && s.Ubicacion_Id == e.Ubicacion_Id).First().Existencia = e.Existencia;
               });

                // Borro los que no tienen existencia //
                pCommonDSNoPost.grdMoviSerie.ToList().ForEach(s =>
                {
                // Resto las series que ya se pudieron haber usado de este producto en otro renglón //
                s.Existencia -= (from ser in pCommonDS.grdMoviSerie
                                     join pro in pCommonDS.grdCuerpo on ser.Renglon equals pro.Renglon
                                     where pro.Producto_Id == pCommonDSNoPost.grdCuerpo[0].Producto_Id && pro.Deposito_Id == pCommonDSNoPost.grdCuerpo[0].Deposito_Id && pro.Renglon != pCommonDSNoPost.grdCuerpo[0].Renglon && ser.Serie == s.Serie && ser.Ubicacion_Id == s.Ubicacion_Id
                                 select ser).Sum(r => !r.Marcado ? 0 : 1);

                    s.Cantidad = !s.Marcado ? 0 : 1;

                    if (s.Existencia <= 0)
                        s.Delete();
                }
                );


                pCommonDSNoPost.grdMoviSerie.AcceptChanges();
                // Le paso el renglón de la grilla principal //
                pCommonDSNoPost.grdMoviSerie.ToList().ForEach(s => s.Renglon = pCommonDSNoPost.grdCuerpo[0].Renglon);

            }

            return pCommonDSNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static stkMoviCabeDS PopularLote(DataSet pCommonDS1, DataSet pCommonDSNoPost1, int pIndice, Framework.Core.Command cmd)
        {
            // Para poder usarlo desde cualquier formulario de stock, resivo un DataSet genérico y lo convierto //
            stkMoviCabeDS pCommonDS = new stkMoviCabeDS();
            stkMoviCabeDS pCommonDSNoPost = new stkMoviCabeDS();

            pCommonDS.Merge(pCommonDS1, false, MissingSchemaAction.Ignore);
            pCommonDSNoPost.Merge(pCommonDSNoPost1, false, MissingSchemaAction.Ignore);

            if (pCommonDS.Principal[0].Segmento1N == 0 && !(!pCommonDS.Principal[0].IsTipomovNull() && pCommonDS.Principal[0].Tipomov == "E" && !pCommonDS.Principal[0].IsSubTipoMov_IdNull() && pCommonDS.Principal[0].SubTipoMov_Id == "CDE"))
            {
                // Solo actualizo todo esto si es un movimiento nuevo. No lo tiene que hacer //
                // si estoy consultando uno existente //

                StockExchange.stkExistenciaXSerieXUbiActionExchange exchSerie = new StockExchange.stkExistenciaXSerieXUbiActionExchange(StockExchange.stkExistenciaXSerieXUbiActionEnum.EnumstkExistenciaXSerieXUbiAction.DatosSerie)
                {
                    Producto_Id = pCommonDSNoPost.grdCuerpo[0].Producto_Id,
                    Medida_Id = pCommonDSNoPost.grdCuerpo[0].Medida_Id,
                    Deposito_Id = pCommonDSNoPost.grdCuerpo[0].Deposito_Id
                };
                exchSerie = new StockExchange.stkExistenciaXSerieXUbiActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchSerie, cmd));

                if (pIndice < 0 || pCommonDSNoPost.grdCuerpo[0].Producto_Id != pCommonDS.grdCuerpo[pIndice].Producto_Id || pCommonDSNoPost.grdCuerpo[0].Deposito_Id != pCommonDS.grdCuerpo[pIndice].Deposito_Id || pCommonDSNoPost.grdCuerpo[0].Medida_Id != pCommonDS.grdCuerpo[pIndice].Medida_Id)
                {
                    // Si estoy agregando un nuevo renglón o cambié alguno de los datos de un renglón existente entonces //
                    // populo los serie/lote //

                    pCommonDSNoPost.grdCuerpo[0].CantidadForm = 0;
                    pCommonDSNoPost.grdMoviSerie.Clear();
                    pCommonDSNoPost.grdMoviSerie.Merge(exchSerie.Param.ExistenciasSerie);

                }

                // Recorro los renglones de las existencias porque pueden haber usado alguna serie/lote en otro renglón //
                exchSerie.Param.ExistenciasSerie.ToList().ForEach(e =>
                {
                    if (pCommonDSNoPost.grdMoviSerie.Where(s => s.Serie == e.Serie && s.Ubicacion_Id == e.Ubicacion_Id).Count() == 0)
                    {
                        // Lo tengo que agregar //
                        pCommonDSNoPost.grdMoviSerie.AddgrdMoviSerieRow(0, pCommonDSNoPost.grdCuerpo[0].Renglon, e.Serie, 0, e.Vencimiento, e.Ubicacion_Id, e.Existencia, false);
                    }

                    else
                        pCommonDSNoPost.grdMoviSerie.Where(s => s.Serie == e.Serie && s.Ubicacion_Id == e.Ubicacion_Id).First().Existencia = e.Existencia;
                });

                // Borro los que no tienen existencia //
                pCommonDSNoPost.grdMoviSerie.ToList().ForEach(s =>
                {
                    // Resto las series que ya se pudieron haber usado de este producto en otro renglón //
                    // Si Marcado está en Null es Lote (no serie) o nunca entró a esa serie entonces no suma //
                    // Si no está en Null entonces es serie y suma si está marcado //
                    s.Existencia -= (from ser in pCommonDS.grdMoviSerie
                                     join pro in pCommonDS.grdCuerpo on ser.Renglon equals pro.Renglon
                                     where pro.Producto_Id == pCommonDSNoPost.grdCuerpo[0].Producto_Id && pro.Deposito_Id == pCommonDSNoPost.grdCuerpo[0].Deposito_Id && pro.Renglon != pCommonDSNoPost.grdCuerpo[0].Renglon && ser.Serie == s.Serie && ser.Ubicacion_Id == s.Ubicacion_Id select ser).Sum(r => r.Cantidad);

                    if (s.Existencia <= 0)
                        s.Delete();
                }
                );


                pCommonDSNoPost.grdMoviSerie.AcceptChanges();
                // Le paso el renglón de la grilla principal //
                pCommonDSNoPost.grdMoviSerie.ToList().ForEach(s => s.Renglon = pCommonDSNoPost.grdCuerpo[0].Renglon);

            }

            return pCommonDSNoPost;
        }
    }
}
