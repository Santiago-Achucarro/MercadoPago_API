using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using StockCommon;
namespace StockFEEventos
{
    public class stkEntradasUbicacion
    {

        // esta clase se usa para entrada y Salida

        [Generalidades.QFuncion_AccionGrilla]
        public static stkMoviCabeDS SumarCantU(stkMoviCabeDS exch, stkMoviCabeDS exchNoPost, int pIndice,
          Framework.Core.Command cmd)
        {
            exchNoPost.grdCuerpo[0].CantidadForm = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static stkMoviCabeDS AsignarCantidad(stkMoviCabeDS exch, stkMoviCabeDS exchNoPost, int pIndice,
         Framework.Core.Command cmd)
        {
            exchNoPost.Ubicaciones[0].Cantidad = 0;
            StockExchange.stkExistenciaUbiActionExchange eExistU = new StockExchange.stkExistenciaUbiActionExchange(StockExchange.stkExistenciaUbiActionEnum.EnumstkExistenciaUbiAction.Datos)
            {
                Deposito_Id = exchNoPost.grdCuerpo[0].Deposito_Id,
                Producto_Id = exchNoPost.grdCuerpo[0].Producto_Id,
                Ubicacion_Id = exchNoPost.Ubicaciones[0].Ubicacion_Id
            };
            eExistU = new StockExchange.stkExistenciaUbiActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eExistU, cmd));
            if (eExistU.Existe && eExistU.Cantidad > 0)
            {
                decimal lCant = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
                exchNoPost.Ubicaciones[0].Cantidad = Math.Min(exchNoPost.grdCuerpo[0].CantidadForm - lCant, eExistU.Cantidad);
            }
            
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_Condicion]
        public static string ManejaCantidadAlterna(Framework.Core.Command cmd)
        {
            return StockFEEventos.ComunesStock.ManejaCantidadAlterna(cmd);
        }

        /*
        public enum stkEntradasUbicacionVar
        {
            ManejaSerieoLote, ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, ManejoDeposito, ManejoCantEntregada, LetraCondFiscal, UsaDespacho
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductos(stkMoviCabeDS exch,
             stkMoviCabeDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            return StockFEEventos.ComunesStock.VariablesProductos(exchNoPost.grdCuerpo[0].Producto_Id, cmd);

        }
        */

        [Generalidades.QFuncion_AccionGrilla]
        public static stkMoviCabeDS PopularUbi(DataSet pCommonDS1, DataSet pCommonDSNoPost1, int pIndice, Framework.Core.Command cmd)
        {

                // Para poder usarlo desde cualquier formulario de stock, recibo un DataSet genérico y lo convierto //
                stkMoviCabeDS pCommonDS = new stkMoviCabeDS();
                stkMoviCabeDS pCommonDSNoPost = new stkMoviCabeDS();

                pCommonDS.Merge(pCommonDS1, false, MissingSchemaAction.Ignore);
                pCommonDSNoPost.Merge(pCommonDSNoPost1, false, MissingSchemaAction.Ignore);

            if (pCommonDS.Principal[0].Segmento1N == 0)
            {
                // Solo actualizo todo esto si es un movimiento nuevo. No lo tiene que hacer //
                // si estoy consultando uno existente //

                StockExchange.stkExistenciaXSerieXUbiActionExchange exchUbi = new StockExchange.stkExistenciaXSerieXUbiActionExchange(StockExchange.stkExistenciaXSerieXUbiActionEnum.EnumstkExistenciaXSerieXUbiAction.DatosUbi)
                {
                    Producto_Id = pCommonDSNoPost.grdCuerpo[0].Producto_Id,
                    Medida_Id = pCommonDSNoPost.grdCuerpo[0].Medida_Id,
                    Deposito_Id = pCommonDSNoPost.grdCuerpo[0].Deposito_Id
                };
                exchUbi = new StockExchange.stkExistenciaXSerieXUbiActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchUbi, cmd));

                if (pIndice < 0 || pCommonDSNoPost.grdCuerpo[0].Producto_Id != pCommonDS.grdCuerpo[pIndice].Producto_Id || pCommonDSNoPost.grdCuerpo[0].Deposito_Id != pCommonDS.grdCuerpo[pIndice].Deposito_Id || pCommonDSNoPost.grdCuerpo[0].Medida_Id != pCommonDS.grdCuerpo[pIndice].Medida_Id)
                {
                    // Si estoy agregando un nuevo renglón o cambié alguno de los datos de un renglón existente entonces //
                    // populo las ubicaciones //


                    pCommonDSNoPost.grdCuerpo[0].CantidadForm = 0;
                    pCommonDSNoPost.Ubicaciones.Clear();
                    pCommonDSNoPost.Ubicaciones.Merge(exchUbi.Param.ExistenciaUbi);
                    pCommonDSNoPost.Ubicaciones.AcceptChanges();
                    // Le paso el renglón de la grilla principal //
                    pCommonDSNoPost.Ubicaciones.ToList().ForEach(s => s.Renglon = pCommonDSNoPost.grdCuerpo[0].Renglon);
                }

                // Recorro los renglones de las existencias porque pueden haber usado alguna serie/lote en otro renglón //
                // y ya fue borrado entonces lo tengo que agregar porque lo pueden haber borrado del renglón original //
                // y ahora me tiene que volver a aparecer acá //
                exchUbi.Param.ExistenciaUbi.ToList().ForEach(e =>
                {
                    if (pCommonDSNoPost.Ubicaciones.Where(u => u.Ubicacion_Id == e.Ubicacion_Id).Count() == 0)
                    {
                        // Lo tengo que agregar //
                        pCommonDSNoPost.Ubicaciones.AddUbicacionesRow(0, pCommonDSNoPost.grdCuerpo[0].Renglon, pCommonDSNoPost.grdCuerpo[0].Producto_Id, pCommonDSNoPost.grdCuerpo[0].Deposito_Id, e.Ubicacion_Id, 0, 0, e.Existencia, e.ExistenciaAlterna);
                    }

                    else
                    {
                        pCommonDSNoPost.Ubicaciones.Where(u => u.Ubicacion_Id == e.Ubicacion_Id).First().Existencia = e.Existencia;
                        pCommonDSNoPost.Ubicaciones.Where(u => u.Ubicacion_Id == e.Ubicacion_Id).First().ExistenciaAlterna = e.ExistenciaAlterna;
                    }
                });

                // Borro los que no tienen existencia //
                pCommonDSNoPost.Ubicaciones.ToList().ForEach(s =>
                {
                    // Resto las ubicaciones que ya se pudieron haber usado de este producto en otro renglón //
                    s.Existencia -= (from ubi in pCommonDS.Ubicaciones
                                     join pro in pCommonDS.grdCuerpo on ubi.Renglon equals pro.Renglon
                                     where pro.Producto_Id == pCommonDSNoPost.grdCuerpo[0].Producto_Id && pro.Deposito_Id == pCommonDSNoPost.grdCuerpo[0].Deposito_Id && pro.Renglon != pCommonDSNoPost.grdCuerpo[0].Renglon && ubi.Ubicacion_Id == s.Ubicacion_Id
                                     select ubi).Sum(r => r.Cantidad);

                    s.ExistenciaAlterna -= (from ubi in pCommonDS.Ubicaciones
                                     join pro in pCommonDS.grdCuerpo on ubi.Renglon equals pro.Renglon
                                     where pro.Producto_Id == pCommonDSNoPost.grdCuerpo[0].Producto_Id && pro.Deposito_Id == pCommonDSNoPost.grdCuerpo[0].Deposito_Id && pro.Renglon != pCommonDSNoPost.grdCuerpo[0].Renglon && ubi.Ubicacion_Id == s.Ubicacion_Id
                                     select ubi).Sum(r => r.CantidadAlterna);

                    if (s.Existencia <= 0)
                        s.Delete();
                }
                );

                pCommonDSNoPost.Ubicaciones.AcceptChanges();
                // Le paso el renglón de la grilla principal //
                pCommonDSNoPost.Ubicaciones.ToList().ForEach(u => u.Renglon = pCommonDSNoPost.grdCuerpo[0].Renglon);

            }
            return pCommonDSNoPost;
        }
    }
}
