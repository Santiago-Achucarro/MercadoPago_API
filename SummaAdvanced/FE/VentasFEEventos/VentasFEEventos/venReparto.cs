using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasFEEventos
{
    public class venReparto
    {
        [Generalidades.QFuncion_Condicion]
        public string ManejaCantidadAlterna(VentasCommon.venRepartoDS exch, Framework.Core.Command cmd)
        {
            GeneralesExchange.genEmpresasActionExchange ExcEmp =
            new GeneralesExchange.genEmpresasActionExchange(GeneralesExchange.genEmpresasActionEnum.EnumgenEmpresasAction.Datos);

            ExcEmp.Empresa_Id = "";
            ExcEmp.genEmpresas = cmd.Empresa_Id;
            ExcEmp = new GeneralesExchange.genEmpresasActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcEmp, cmd));

            if (ExcEmp.Existe)
            {
                if (ExcEmp.UsaCantidadAlterna)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }
        public enum venRepartoVar
        {
            ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, DepositoDefecto, ManejaLoteoSerie, ManejoDeposito, ManejaUbicacion, CantidadSoloLectura
        }


        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductos(VentasCommon.venRepartoDS exch,
            VentasCommon.venRepartoDS exchNoPost, int pIndice, Framework.Core.Command cmd)

        {
            bool lLotes = false, lSerie = false;

            Dictionary<string, string> lRetorno = new Dictionary<string, string>();
            if (exchNoPost.venRepaPedi.Count > 0)
            {
                StockExchange.stkProductosActionExchange exchProd = new StockExchange.stkProductosActionExchange
                (StockExchange.stkProductosActionEnum.EnumstkProductosAction.Datos);


                exchProd.Producto_Id = exchNoPost.venRepaPedi[0].Producto_Id;
                exchProd = new StockExchange.stkProductosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                    (new Framework.Core.Exchange(exchProd), cmd));



                if (exchProd.Serializable)
                {
                    lRetorno.Add(venRepartoVar.ManejaSerie.ToString(), "S");
                    lSerie = true;
                }
                else
                    lRetorno.Add(venRepartoVar.ManejaSerie.ToString(), "N");

                if (exchProd.TrabajaPorLotes)
                {
                    lRetorno.Add(venRepartoVar.ManejaLote.ToString(), "S");
                    lLotes = true;
                }
                else
                    lRetorno.Add(venRepartoVar.ManejaLote.ToString(), "N");

                if (exchProd.TrabajaPorLotes || exchProd.Serializable)
                    lRetorno.Add(venRepartoVar.ManejaLoteoSerie.ToString(), "S");
                else
                    lRetorno.Add(venRepartoVar.ManejaLoteoSerie.ToString(), "N");

                if (exchProd.conVencimiento)
                    lRetorno.Add(venRepartoVar.ManejaVencimiento.ToString(), "S");
                else
                    lRetorno.Add(venRepartoVar.ManejaVencimiento.ToString(), "N");

                if (exchProd.MedidaAlterna != "")
                    lRetorno.Add(venRepartoVar.ManejaUMAlterna.ToString(), "S");
                else
                    lRetorno.Add(venRepartoVar.ManejaUMAlterna.ToString(), "N");

                lRetorno.Add(venRepartoVar.Clase.ToString(), exchProd.Clase);

                if (exchProd.Clase != "D")
                    // Si no es Servicio muestro el depósito //
                    lRetorno.Add(venRepartoVar.ManejoDeposito.ToString(), "S");
                else
                    // Si es Servicio se pide el depósito //
                    lRetorno.Add(venRepartoVar.ManejoDeposito.ToString(), "N");

            }
            // PARA 
            StockExchange.stkDepositosActionExchange eDepo = new StockExchange.stkDepositosActionExchange(StockExchange.stkDepositosActionEnum.EnumstkDepositosAction.Datos)
            {
                Deposito_Id = exch.Principal[0].Deposito_Id
            };

            eDepo = new StockExchange.stkDepositosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eDepo, cmd));
            if (eDepo.Existe && eDepo.UsaUbicacion)
            {
                lRetorno.Add(venRepartoVar.ManejaUbicacion.ToString(), "S");

            }
            else
                lRetorno.Add(venRepartoVar.ManejaUbicacion.ToString(), "N");


            var eUsu = GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd);
            var eSuc = GeneralesValidacion.genSucursalesEmpr.Existe(eUsu.Sucursal, cmd);
            lRetorno.Add(venRepartoVar.DepositoDefecto.ToString(), eSuc.DepositoVentas);

            if (lSerie || lLotes || eDepo.UsaUbicacion)
                lRetorno.Add(venRepartoVar.CantidadSoloLectura.ToString(), "S");
            else
                lRetorno.Add(venRepartoVar.CantidadSoloLectura.ToString(), "N");

            return lRetorno;
        }


        [Generalidades.QFuncion_CondicionGrilla]
        public string ValirSerieLote(venRepartoDS exch, venRepartoDS exchNoPost,
         int pIndice, Framework.Core.Command cmd)
        {

            StockExchange.stkExistenciaSerieActionExchange exchSerie = new StockExchange.stkExistenciaSerieActionExchange
             (StockExchange.stkExistenciaSerieActionEnum.EnumstkExistenciaSerieAction.Datos);
            exchSerie.Producto_Id = exchNoPost.venRepaPedi[0].Producto_Id;
            exchSerie.Serie = exchNoPost.grdMoviSerie[0].Serie;
            exchSerie.Deposito_Id = exch.Principal[0].Deposito_Id;

            exchSerie = new StockExchange.stkExistenciaSerieActionExchange
                (Generalidades.QBIInternal.WrapperExecuteActionInternal(new Framework.Core.Exchange(exchSerie), cmd));

            if (!exchSerie.Existe)
                return "Serie_Lote_<0>_en_deposito_<1>_no_existe";
            return "";

        }

        [Generalidades.QFuncion_AccionGrilla]
        public venRepartoDS SumarCantSerie(venRepartoDS exch, venRepartoDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            exchNoPost.venRepaPedi[0].CantidadForm = exchNoPost.grdMoviSerie.ToList().Sum(r => !r.Marcado ? 0 : 1);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public venRepartoDS SumarCantLote(venRepartoDS exch, venRepartoDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            exchNoPost.venRepaPedi[0].CantidadForm = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_ObtenerParametrosReporte]
        public String ObtenerParametrosRepo(venRepartoDS exch, Framework.Core.Command cmd)
        {
            string a = "Empresa_Id|" + cmd.Empresa_Id.ToString() + "@Segmento_Id|REPARTO" +
              "@Segmento1N|" + exch.Principal[0].Segmento1N.ToString() +
              "@Segmento2N|" + exch.Principal[0].Segmento2N.ToString() +
              "@Segmento3N|" + exch.Principal[0].Segmento3N.ToString() +
              "@Segmento4N|" + exch.Principal[0].Segmento4N.ToString() +
              "@Segmento1C|" + exch.Principal[0].Segmento1C +
              "@Segmento2C|" + exch.Principal[0].Segmento2C +
              "@Segmento3C|" + exch.Principal[0].Segmento3C +
              "@Segmento4C|" + exch.Principal[0].Segmento4C;

            return a;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public venRepartoDS RenglonA0(venRepartoDS exch, venRepartoDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {

            exch.grdMoviSerie.Where(s => s.Renglon_Rep == exch.venRepaPedi[pIndice].Renglon_Rep).ToList().ForEach(s => s.Delete());
            exch.venRepaPedi[pIndice].CantidadForm = 0;
            exch.AcceptChanges();

            return exch;

        }

        [Generalidades.QFuncion_AccionGrilla]
        public static venRepartoDS AsignarCantidad(venRepartoDS exch, venRepartoDS exchNoPost, int pIndice,
      Framework.Core.Command cmd)
        {


            if (exchNoPost.venRepaPedi[0].CantidadForm == 0)
                return exchNoPost;


            exchNoPost.Ubicaciones[0].Cantidad = 0;
            StockExchange.stkExistenciaUbiActionExchange eExistU = new StockExchange.stkExistenciaUbiActionExchange(StockExchange.stkExistenciaUbiActionEnum.EnumstkExistenciaUbiAction.Datos)
            {
                Deposito_Id = exch.Principal[0].Deposito_Id,
                Producto_Id = exchNoPost.venRepaPedi[0].Producto_Id,
                Ubicacion_Id = exchNoPost.Ubicaciones[0].Ubicacion_Id
            };
            eExistU = new StockExchange.stkExistenciaUbiActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eExistU, cmd));
            if (eExistU.Existe && eExistU.Cantidad > 0)
            {
                decimal lCant = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
                exchNoPost.Ubicaciones[0].Cantidad = Math.Min(exchNoPost.venRepaPedi[0].CantidadForm - lCant, eExistU.Cantidad / exchNoPost.venRepaPedi[0].Factor);
            }

            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        public static venRepartoDS SumarCantU(venRepartoDS exch, venRepartoDS exchNoPost, int pIndice,
     Framework.Core.Command cmd)
        {

            exchNoPost.venRepaPedi[0].CantidadForm = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
            exchNoPost.venRepaPedi[0].CantidadAlternaForm = exchNoPost.Ubicaciones.ToList().Sum(r => r.CantidadAlterna);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venRepartoDS EliminarPedido(VentasCommon.venRepartoDS exch,
         VentasCommon.venRepartoDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            int lPedido = exch.venRepaPedi[pIndice].venPedidos;
            VentasExchange.venRepartoActionExchange eRepa = new VentasExchange.venRepartoActionExchange(VentasExchange.venRepartoActionEnum.EnumvenRepartoAction.Datos)
            {
                Segmento_Id = exch.Principal[0].Segmento_Id,
                Segmento1N = exch.Principal[0].Segmento1N,
                Segmento2N = exch.Principal[0].Segmento2N,
                Segmento3N = exch.Principal[0].Segmento3N,
                Segmento4N = exch.Principal[0].Segmento4N,
                Segmento1C = exch.Principal[0].Segmento1C,
                Segmento2C = exch.Principal[0].Segmento2C,
                Segmento3C = exch.Principal[0].Segmento3C,
                Segmento4C = exch.Principal[0].Segmento4C
            };
            eRepa = new VentasExchange.venRepartoActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eRepa, cmd));
            if (eRepa.Param.venRepaPedi.Where(c => c.venPedidos == lPedido && c.Remitido).Count() > 0)
                Generalidades.qFunctionalException.GenerarExcepcion("No_Se_Pueden_Quitar_Pedidos_Remitidos");
            else
            {
                VentasExchange.venRepaPediActionExchange eRepaPedi = new VentasExchange.venRepaPediActionExchange(VentasExchange.venRepaPediActionEnum.EnumvenRepaPediAction.Eliminar)
                {
                    venPedidos = lPedido,
                    Renglon_Pe = 0,
                    venReparto = eRepa.venReparto,
                    Renglon_Rep = 0
                };
                Generalidades.QBIInternal.WrapperExecuteActionInternal(eRepaPedi, cmd);
                for (int i = 0; i < exch.venRepaPedi.Count; i++)
                {
                    if (exch.venRepaPedi[i].venPedidos == lPedido)
                        exch.venRepaPedi[i].Delete();
                }
                exch.venRepaPedi.AcceptChanges();
            }
            return exch;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public venRepartoDS PopularSerie(venRepartoDS pCommonDS, venRepartoDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            if (pCommonDS.Principal[0].Segmento1N == 0)
            {
                // Solo actualizo todo esto si es un movimiento nuevo. No lo tiene que hacer //
                // si estoy consultando uno existente //

                StockExchange.stkExistenciaXSerieXUbiActionExchange exchSerie = new StockExchange.stkExistenciaXSerieXUbiActionExchange(StockExchange.stkExistenciaXSerieXUbiActionEnum.EnumstkExistenciaXSerieXUbiAction.DatosSerie)
                {
                    Producto_Id = pCommonDSNoPost.venRepaPedi[0].Producto_Id,
                    Medida_Id = pCommonDSNoPost.venRepaPedi[0].MedidaPed,
                    Deposito_Id = pCommonDS.Principal[0].Deposito_Id
                };
                exchSerie = new StockExchange.stkExistenciaXSerieXUbiActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchSerie, cmd));

                if (pCommonDS.grdMoviSerie.Where(s => s.Renglon_Rep == pCommonDSNoPost.venRepaPedi[0].Renglon_Rep).Count() == 0)
                {
                    // Estoy entrando por primera vez en este renglón así que traigo los datos //

                    pCommonDSNoPost.venRepaPedi[0].CantidadForm = 0;
                    pCommonDSNoPost.grdMoviSerie.Clear();
                    pCommonDSNoPost.grdMoviSerie.Merge(exchSerie.Param.ExistenciasSerie);
                    pCommonDSNoPost.grdMoviSerie.AcceptChanges();
                    pCommonDSNoPost.grdMoviSerie.ToList().ForEach(s => s.Marcado = false);
                }

                // Recorro los renglones de las existencias porque pueden haber usado alguna serie en otro renglón //
                // y ya fue borrado entonces lo tengo que agregar porque lo pueden haber borrado del renglón original //
                // y ahora me tiene que volver a aparecer acá //
                exchSerie.Param.ExistenciasSerie.ToList().ForEach(e =>
                {
                    if (pCommonDSNoPost.grdMoviSerie.Where(s => s.Serie == e.Serie).Count() == 0)
                    {
                        // Lo tengo que agregar //
                        pCommonDSNoPost.grdMoviSerie.AddgrdMoviSerieRow(0, pCommonDSNoPost.venRepaPedi[0].Renglon_Rep, pCommonDSNoPost.venRepaPedi[0].venPedidos, pCommonDSNoPost.venRepaPedi[0].Renglon_Pe, e.Serie, 0, e.Vencimiento, e.Ubicacion_Id, e.Existencia, false);
                    }

                    else
                        pCommonDSNoPost.grdMoviSerie.Where(s => s.Serie == e.Serie).First().Existencia = e.Existencia;
                });

                // Borro los que no tienen existencia //
                pCommonDSNoPost.grdMoviSerie.ToList().ForEach(s =>
                {
                    // Resto las series que ya se pudieron haber usado de este producto en otro renglón //
                    s.Renglon_Rep = pCommonDSNoPost.venRepaPedi[0].Renglon_Rep;

                    s.Existencia -= (from ser in pCommonDS.grdMoviSerie
                                     join pro in pCommonDS.venRepaPedi on ser.Renglon_Rep equals pro.Renglon_Rep
                                     where pro.Producto_Id == pCommonDSNoPost.venRepaPedi[0].Producto_Id && ser.Ubicacion_Id == s.Ubicacion_Id && ser.Renglon_Rep != pCommonDSNoPost.venRepaPedi[0].Renglon_Rep && ser.Serie == s.Serie select ser).Sum(y => y.Marcado ? 1: 0);

                    s.Cantidad = !s.Marcado ? 0 : 1;

                    if (s.Existencia <= 0)
                        s.Delete();
                }
                );

                pCommonDSNoPost.grdMoviSerie.AcceptChanges();
                // Le paso el renglón de la grilla principal //
                pCommonDSNoPost.grdMoviSerie.ToList().ForEach(s => s.Renglon_Rep = pCommonDSNoPost.venRepaPedi[0].Renglon_Rep);


            }

            return pCommonDSNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public venRepartoDS PopularLote(venRepartoDS pCommonDS, venRepartoDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            if (pCommonDS.Principal[0].Segmento1N == 0)
            {
                // Solo actualizo todo esto si es un movimiento nuevo. No lo tiene que hacer //
                // si estoy consultando uno existente //

                StockExchange.stkExistenciaXSerieXUbiActionExchange exchSerie = new StockExchange.stkExistenciaXSerieXUbiActionExchange(StockExchange.stkExistenciaXSerieXUbiActionEnum.EnumstkExistenciaXSerieXUbiAction.DatosSerie)
                {
                    Producto_Id = pCommonDSNoPost.venRepaPedi[0].Producto_Id,
                    Medida_Id = pCommonDSNoPost.venRepaPedi[0].MedidaPed,
                    Deposito_Id = pCommonDS.Principal[0].Deposito_Id
                };
                exchSerie = new StockExchange.stkExistenciaXSerieXUbiActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchSerie, cmd));

                if (pCommonDS.grdMoviSerie.Where(s => s.Renglon_Rep == pCommonDSNoPost.venRepaPedi[0].Renglon_Rep).Count() == 0)
                {
                    // Estoy entrando por primera vez en este renglón así que traigo los datos //


                    pCommonDSNoPost.venRepaPedi[0].CantidadForm = 0;
                    pCommonDSNoPost.grdMoviSerie.Clear();
                    pCommonDSNoPost.grdMoviSerie.Merge(exchSerie.Param.ExistenciasSerie);
                    pCommonDSNoPost.grdMoviSerie.AcceptChanges();
                    // Le paso el renglón de la grilla principal //
                }
                else
                {
                    // Si entro por segunda vez tengo que actualizar la existencia original así después resto //
                    // que ya está usada en otros renglones //
                    pCommonDSNoPost.grdMoviSerie.ToList().ForEach(s =>
                    {
                        s.Existencia =
                           (from exi in exchSerie.Param.ExistenciasSerie
                            where exi.Serie == s.Serie && exi.Ubicacion_Id == s.Ubicacion_Id
                            select new { exi.Existencia }).Sum(u => u.Existencia);
                    }
    );
                }

                // Le paso el renglón de la grilla principal //
                // También resto las cantidades de esos mismos lotes y ubicaciones que ese mismo producto pueda haber usado //
                // en otros renglones de esta misma grilla //
                pCommonDSNoPost.grdMoviSerie.ToList().ForEach(s =>
                {
                    s.Renglon_Rep = pCommonDSNoPost.venRepaPedi[0].Renglon_Rep;
                    s.Existencia -= (from ser in pCommonDS.grdMoviSerie
                                     join pro in pCommonDS.venRepaPedi on ser.Renglon_Rep equals pro.Renglon_Rep
                                     where pro.Producto_Id == pCommonDSNoPost.venRepaPedi[0].Producto_Id &&
                                     ser.Ubicacion_Id == s.Ubicacion_Id && ser.Renglon_Rep != pCommonDSNoPost.venRepaPedi[0].Renglon_Rep && ser.Ubicacion_Id == s.Ubicacion_Id
                                     select new { ser.Cantidad, pro.Factor }).Sum(y => y.Cantidad / y.Factor);
                }
                );
            }

            return pCommonDSNoPost;
        }


        [Generalidades.QFuncion_AccionGrilla]
        public venRepartoDS PopularUbi(venRepartoDS pCommonDS, venRepartoDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            if (pCommonDS.Principal[0].Segmento1N == 0)
            {
                // Solo actualizo todo esto si es un movimiento nuevo. No lo tiene que hacer //
                // si estoy consultando uno existente //

                StockExchange.stkExistenciaXSerieXUbiActionExchange exchUbi = new StockExchange.stkExistenciaXSerieXUbiActionExchange(StockExchange.stkExistenciaXSerieXUbiActionEnum.EnumstkExistenciaXSerieXUbiAction.DatosUbi)
                {
                    Producto_Id = pCommonDSNoPost.venRepaPedi[0].Producto_Id,
                    Medida_Id = pCommonDSNoPost.venRepaPedi[0].MedidaPed,
                    Deposito_Id = pCommonDS.Principal[0].Deposito_Id
                };
                exchUbi = new StockExchange.stkExistenciaXSerieXUbiActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchUbi, cmd));

                if (pCommonDS.Ubicaciones.Where(s => s.Renglon_Rep == pCommonDSNoPost.venRepaPedi[0].Renglon_Rep).Count() == 0)
                {
                    // Estoy entrando por primera vez en este renglón así que traigo los datos //


                    pCommonDSNoPost.venRepaPedi[0].CantidadForm = 0;
                    pCommonDSNoPost.Ubicaciones.Clear();
                    pCommonDSNoPost.Ubicaciones.Merge(exchUbi.Param.ExistenciaUbi);
                    pCommonDSNoPost.Ubicaciones.AcceptChanges();
                }
                else
                {
                    // Si entro por segunda vez tengo que actualizar la existencia original así después resto //
                    // que ya está usada en otros renglones //
                    pCommonDSNoPost.Ubicaciones.ToList().ForEach(s =>
                    {
                        s.Existencia =
                           (from exi in exchUbi.Param.ExistenciaUbi
                            where exi.Ubicacion_Id == s.Ubicacion_Id
                            select new { exi.Existencia, exi.ExistenciaAlterna }).Sum(u => u.Existencia);
                        s.ExistenciaAlterna =
                        (from exi in exchUbi.Param.ExistenciaUbi
                         where exi.Ubicacion_Id == s.Ubicacion_Id
                         select new { exi.Existencia, exi.ExistenciaAlterna }).Sum(u => u.ExistenciaAlterna);
                    }
                    );
                }

                // Le paso el renglón de la grilla principal //
                // También resto las cantidades de esas mismas ubicaciones que ese mismo producto pueda haber usado //
                // en otros renglones de esta misma grilla //
                pCommonDSNoPost.Ubicaciones.ToList().ForEach(s =>
                {
                    s.Renglon_Rep = pCommonDSNoPost.venRepaPedi[0].Renglon_Rep;
                    s.Existencia = s.Existencia - (from ubi in pCommonDS.Ubicaciones
                                                   join pro in pCommonDS.venRepaPedi on ubi.Renglon_Rep equals pro.Renglon_Rep
                                                   where pro.Producto_Id == pCommonDSNoPost.venRepaPedi[0].Producto_Id &&
                                                   ubi.Ubicacion_Id == s.Ubicacion_Id && ubi.Renglon_Rep != pCommonDSNoPost.venRepaPedi[0].Renglon_Rep
                                                   select new { ubi.Cantidad, pro.Factor }).Sum(y => y.Cantidad / y.Factor);

                    s.ExistenciaAlterna -= (from ubi in pCommonDS.Ubicaciones
                                            join pro in pCommonDS.venRepaPedi on ubi.Renglon_Rep equals pro.Renglon_Rep
                                            where pro.Producto_Id == pCommonDSNoPost.venRepaPedi[0].Producto_Id &&
                                        ubi.Ubicacion_Id == s.Ubicacion_Id && ubi.Renglon_Rep != pCommonDSNoPost.venRepaPedi[0].Renglon_Rep
                                            select new { ubi.CantidadAlterna }).Sum(y => y.CantidadAlterna);

                }
                );
            }
            
            return pCommonDSNoPost;
        }

    }
}
