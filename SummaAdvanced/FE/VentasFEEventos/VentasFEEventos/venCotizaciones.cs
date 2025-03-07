using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasFEEventos
{
    public class venCotizaciones
    {
        [Generalidades.QFuncion_Condicion]
        public string Extranjero(VentasCommon.venCotizacionesDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venClieHabitualActionExchange ExcVen =
                    new VentasExchange.venClieHabitualActionExchange(VentasExchange.venClieHabitualActionEnum.EnumvenClieHabitualAction.Datos);
            ExcVen.Cliente_Id = exch.Principal[0].Cliente_Id;
            ExcVen.Sucursal = exch.Principal[0].Sucursal;
            ExcVen = new VentasExchange.venClieHabitualActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVen, cmd));

            if (ExcVen.Existe)
            {
                if (ExcVen.Dominio_Id == cmd.Dominio_Id)
                    return "N";
                else
                    return "S";

            }

            return "N";
        }


        [Generalidades.QFuncion_Condicion]
        public string PideCambio(VentasCommon.venCotizacionesDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
                new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);

            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));

            if (ExcVenSubTipomov.Existe)
            {
                if (ExcVenSubTipomov.PideCambio)
                {
                    // solo es modeda distinta
                    VentasExchange.venListasPreciosActionExchange ExcLP =
                    new VentasExchange.venListasPreciosActionExchange(VentasExchange.venListasPreciosActionEnum.EnumvenListasPreciosAction.Datos);
                    ExcLP.ListaPrecio_Id = exch.Principal[0].ListaPrecio_Id;
                    ExcLP = new VentasExchange.venListasPreciosActionExchange(
                            Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcLP, cmd));


                    if (!ExcLP.Existe)
                        return "N";

                    if (exch.Principal[0].Moneda_Id == ExcLP.Moneda_Id)
                        return "N";

                    return "S";
                }
                else
                {

                    return "N";
                }
            }

            return "N";
        }



        [Generalidades.QFuncion_Condicion]
        public string EnMonedaBase(VentasCommon.venCotizacionesDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Moneda_Id == "" || exch.Principal[0].Moneda_Id == cmd.MonedaBase)
                return "S";
            else
                return "N";
        }


        [Generalidades.QFuncion_Condicion]
        public string FacturaAnticipo(VentasCommon.venCotizacionesDS exch, Framework.Core.Command cmd)
        {

            if (exch.Principal[0].FacturaAnticipo)
                return "S";
            return "N";

        }

        [Generalidades.QFuncion_Condicion]
        public string TipoAnticipo(VentasCommon.venCotizacionesDS exch, Framework.Core.Command cmd)
        {
            if (!exch.Principal[0].FacturaAnticipo)
                return "Z";

            if (exch.Principal[0].PorAnticipo != 0)
                return "P";
            if (exch.Principal[0].Anticipo != 0)
                return "I";
            return "N";
        }


        public enum venCotizacionesVar
        {
            ModificaPrecio, AdmiteBoniRenglon, ModCondPago, ModVendedor, PideObservaciones, ModListaPrecios, Pais_Id,
            PideFechaEntrega, PideObsReng, PideReferencia, PideOrdenCompra, PideMarcaReserva, DepositoDefecto, PideCentro1, PideCentro2, 
            PideDeposito,Sucursal
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> DepositoDefecto(VentasCommon.venCotizacionesDS exch,
VentasCommon.venCotizacionesDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            Dictionary<string, string> lRetorno = new Dictionary<string, string>();
            string lDepo = GeneralesValidacion.genSucursalesEmpr.Existe(GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd).Sucursal, cmd).DepositoVentas;

            lRetorno.Add(venCotizacionesVar.DepositoDefecto.ToString(), lDepo);
            lRetorno.Add(venCotizacionesVar.Sucursal.ToString(), GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd).Sucursal);
            
            return lRetorno;
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesSubTipo(VentasCommon.venCotizacionesDS exch,
    VentasCommon.venCotizacionesDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
   new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);


            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));

            GeneralesExchange.genEmpresasActionExchange exchEmpr = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);


            Dictionary<string, string> lRetorno = new Dictionary<string, string>();

            /*
            if (exch.Principal[0].SubTipoMov_Id != "")
                lRetorno.Add(venCotizacionesVar.STMIngresado.ToString(), "S");
            else
                lRetorno.Add(venCotizacionesVar.STMIngresado.ToString(), "N");
                */

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModCondPago)
                lRetorno.Add(venCotizacionesVar.ModCondPago.ToString(), "S");
            else
                lRetorno.Add(venCotizacionesVar.ModCondPago.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModVendedor)
                lRetorno.Add(venCotizacionesVar.ModVendedor.ToString(), "S");
            else
                lRetorno.Add(venCotizacionesVar.ModVendedor.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideObervaciones)
                lRetorno.Add(venCotizacionesVar.PideObservaciones.ToString(), "S");
            else
                lRetorno.Add(venCotizacionesVar.PideObservaciones.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModificaPrecio)
                lRetorno.Add(venCotizacionesVar.ModificaPrecio.ToString(), "S");
            else
                lRetorno.Add(venCotizacionesVar.ModificaPrecio.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.AdmiteBoniRenglon)
                lRetorno.Add(venCotizacionesVar.AdmiteBoniRenglon.ToString(), "S");
            else
                lRetorno.Add(venCotizacionesVar.AdmiteBoniRenglon.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModListaPrecios)
                lRetorno.Add(venCotizacionesVar.ModListaPrecios.ToString(), "S");
            else
                lRetorno.Add(venCotizacionesVar.ModListaPrecios.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideFechaEntrega)
                lRetorno.Add(venCotizacionesVar.PideFechaEntrega.ToString(), "S");
            else
                lRetorno.Add(venCotizacionesVar.PideFechaEntrega.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideObsReng)
                lRetorno.Add(venCotizacionesVar.PideObsReng.ToString(), "S");
            else
                lRetorno.Add(venCotizacionesVar.PideObsReng.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideReferencia)
                lRetorno.Add(venCotizacionesVar.PideReferencia.ToString(), "S");
            else
                lRetorno.Add(venCotizacionesVar.PideReferencia.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideOrdenCompra)
                lRetorno.Add(venCotizacionesVar.PideOrdenCompra.ToString(), "S");
            else
                lRetorno.Add(venCotizacionesVar.PideOrdenCompra.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideMarcaReserva)
                lRetorno.Add(venCotizacionesVar.PideMarcaReserva.ToString(), "S");
            else
                lRetorno.Add(venCotizacionesVar.PideMarcaReserva.ToString(), "N");

            if (exchEmpr.Centro1De == "CPR")
                lRetorno.Add(venCotizacionesVar.PideCentro1.ToString(), "S");
            else
                lRetorno.Add(venCotizacionesVar.PideCentro1.ToString(), "N");

            if (exchEmpr.Centro2De == "CPR")
                lRetorno.Add(venCotizacionesVar.PideCentro2.ToString(), "S");
            else
                lRetorno.Add(venCotizacionesVar.PideCentro2.ToString(), "N");

            if (ExcVenSubTipomov.ModDeposito)
                lRetorno.Add(venCotizacionesVar.PideDeposito.ToString(), "S");
            else
                lRetorno.Add(venCotizacionesVar.PideDeposito.ToString(), "N");

            return lRetorno;
        }


        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venCotizacionesDS AsignarDatosProd(VentasCommon.venCotizacionesDS exch,
    VentasCommon.venCotizacionesDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {

            exchNoPost = CambiarPUxUM(exch, exchNoPost, pIndice, cmd);

            /*
            if (exchNoPost.grdCuerpo[0].PrecioForm != 0)
            { // Si ya había sido asignado no lo vuelvo a asignar //


                VentasExchange.venListasPrecProdActionExchange exchVLPP = new VentasExchange.venListasPrecProdActionExchange
        (VentasExchange.venListasPrecProdActionEnum.EnumvenListasPrecProdAction.DatosFecha);
                exchVLPP.Producto_Id = exchNoPost.grdCuerpo[0].Producto_Id;
                exchVLPP.ListaPrecio_Id = exch.Principal[0].ListaPrecio_Id;
                exchVLPP.Fecha = exch.Principal[0].Fecha;

                exchVLPP = new VentasExchange.venListasPrecProdActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                    (new Framework.Core.Exchange(exchVLPP), cmd));

                // TODO FM Usar la cantidad de decimales de la UM 
                exchNoPost.grdCuerpo[0].PrecioLista = Generalidades.Auxiliares.Redondear(exchVLPP.PrecioLista * exch.Principal[0].Cambio, 8); ;
                exchNoPost.grdCuerpo[0].PrecioForm = Generalidades.Auxiliares.Redondear(exchVLPP.PrecioLista * exch.Principal[0].Cambio, 8);
                exchNoPost.grdCuerpo[0].PrecioListaForm = exchNoPost.grdCuerpo[0].PrecioForm;
            }
            */


            return exchNoPost;

        }


        [Generalidades.QFuncion_CondicionGrilla]
        public string ProdManejaUMAlt(VentasCommon.venCotizacionesDS exch,
            VentasCommon.venCotizacionesDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {

            StockExchange.stkProductosActionExchange exchProd = new StockExchange.stkProductosActionExchange
    (StockExchange.stkProductosActionEnum.EnumstkProductosAction.Datos);
            exchProd.Producto_Id = exchNoPost.grdCuerpo[0].Producto_Id;
            exchProd = new StockExchange.stkProductosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                (new Framework.Core.Exchange(exchProd), cmd));

            if (exchProd.MedidaAlterna != "")
                return "S";
            else
                return "N";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ManejaDepo(VentasCommon.venCotizacionesDS exch, VentasCommon.venCotizacionesDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {

            GeneralesExchange.genEmpresasActionExchange exchEmpr = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);

            StockExchange.stkProductosActionExchange exchProd = new StockExchange.stkProductosActionExchange
(StockExchange.stkProductosActionEnum.EnumstkProductosAction.Datos);
            exchProd.Producto_Id = exchNoPost.grdCuerpo[0].Producto_Id;
            exchProd = new StockExchange.stkProductosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                (new Framework.Core.Exchange(exchProd), cmd));

            if (exchProd.Clase != "D" || exchEmpr.Centro1De == "DEP" || exchEmpr.Centro2De == "DEP") 
                    
                return "S";
            return "N";
        }

        [Generalidades.QFuncion_ObtenerParametrosReporte]
        public string Parametros(VentasCommon.venCotizacionesDS exch, Framework.Core.Command cmd)
        {
            return
                    "Empresa_Id|" + cmd.Empresa_Id.ToString() +
                    "@Segmento_Id|" + exch.Principal[0].Segmento_Id +
                    "@Segmento1N|" + exch.Principal[0].Segmento1N.ToString() +
                    "@Segmento2N|" + exch.Principal[0].Segmento2N.ToString() +
                    "@Segmento3N|" + exch.Principal[0].Segmento3N.ToString() +
                    "@Segmento4N|" + exch.Principal[0].Segmento4N.ToString() +
                    "@Segmento1C|" + exch.Principal[0].Segmento1C +
                    "@Segmento2C|" + exch.Principal[0].Segmento2C +
                    "@Segmento3C|" + exch.Principal[0].Segmento3C +
                    "@Segmento4C|" + exch.Principal[0].Segmento4C;

        }


        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venCotizacionesDS Stock(VentasCommon.venCotizacionesDS exch, VentasCommon.venCotizacionesDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            exch.ConsStock.Clear();

            StockExchange.stkConsStockActionExchange eCons = new StockExchange.stkConsStockActionExchange(StockExchange.stkConsStockActionEnum.EnumstkConsStockAction.Datos)
            {
                Producto_Id = exch.grdCuerpo[pIndice].Producto_Id,
                Deposito_Id = exch.grdCuerpo[pIndice].Deposito_Id
            };
            eCons = new StockExchange.stkConsStockActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eCons, cmd));
            decimal lAcum = 0;
            foreach (var ren in eCons.Param.Cuerpo)
            {
                lAcum += ren.Final;
                ren.Final = lAcum;
            }
            exch.ConsStock.Merge(eCons.Param.Cuerpo);
            exch.ConsStock.AcceptChanges();
            return exch;
        }
        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venCotizacionesDS EnTransito(VentasCommon.venCotizacionesDS exch, VentasCommon.venCotizacionesDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            exch.ConsDetalle.Clear();
            var reng = exch.ConsStock[pIndice];
            StockExchange.stkConsStockDetalleActionExchange eDetalle = new StockExchange.stkConsStockDetalleActionExchange(StockExchange.stkConsStockDetalleActionEnum.EnumstkConsStockDetalleAction.Datos);
            eDetalle.Param.Parametros.AddParametrosRow("ET", reng.Producto_Id, reng.Deposito_Id, reng.Fecha, cmd.UsuarioVendedor_id);
            eDetalle = new StockExchange.stkConsStockDetalleActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eDetalle, cmd));
            if (eDetalle.Existe)
                exch.ConsDetalle.Merge(eDetalle.Param.Principal);
            exch.ConsDetalle.AcceptChanges();
            return exch;
        }
        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venCotizacionesDS Pedidos(VentasCommon.venCotizacionesDS exch, VentasCommon.venCotizacionesDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            exch.ConsDetalle.Clear();
            var reng = exch.ConsStock[pIndice];
            StockExchange.stkConsStockDetalleActionExchange eDetalle = new StockExchange.stkConsStockDetalleActionExchange(StockExchange.stkConsStockDetalleActionEnum.EnumstkConsStockDetalleAction.Datos);
            eDetalle.Param.Parametros.AddParametrosRow("P", reng.Producto_Id, reng.Deposito_Id, reng.Fecha, cmd.UsuarioVendedor_id);
            eDetalle = new StockExchange.stkConsStockDetalleActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eDetalle, cmd));
            
            if (eDetalle.Existe)
                exch.ConsDetalle.Merge(eDetalle.Param.Principal);
            exch.ConsDetalle.AcceptChanges();
            return exch;
        }
        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venCotizacionesDS Compras(VentasCommon.venCotizacionesDS exch, VentasCommon.venCotizacionesDS exchNoPost,
           int pIndice, Framework.Core.Command cmd)
        {
            exch.ConsDetalle.Clear();
            var reng = exch.ConsStock[pIndice];
            StockExchange.stkConsStockDetalleActionExchange eDetalle = new StockExchange.stkConsStockDetalleActionExchange(StockExchange.stkConsStockDetalleActionEnum.EnumstkConsStockDetalleAction.Datos);
            eDetalle.Param.Parametros.AddParametrosRow("C", reng.Producto_Id, reng.Deposito_Id, reng.Fecha, cmd.UsuarioVendedor_id);
            eDetalle = new StockExchange.stkConsStockDetalleActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eDetalle, cmd));
            if (eDetalle.Existe)
                exch.ConsDetalle.Merge(eDetalle.Param.Principal);
            exch.ConsDetalle.AcceptChanges();
            return exch;
        }
        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venCotizacionesDS Embarques(VentasCommon.venCotizacionesDS exch, VentasCommon.venCotizacionesDS exchNoPost,
           int pIndice, Framework.Core.Command cmd)
        {
            exch.ConsDetalle.Clear();
            var reng = exch.ConsStock[pIndice];
            StockExchange.stkConsStockDetalleActionExchange eDetalle = new StockExchange.stkConsStockDetalleActionExchange(StockExchange.stkConsStockDetalleActionEnum.EnumstkConsStockDetalleAction.Datos);
            eDetalle.Param.Parametros.AddParametrosRow("E", reng.Producto_Id, reng.Deposito_Id, reng.Fecha, cmd.UsuarioVendedor_id);
            eDetalle = new StockExchange.stkConsStockDetalleActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eDetalle, cmd));
            if (eDetalle.Existe)
                exch.ConsDetalle.Merge(eDetalle.Param.Principal);
            exch.ConsDetalle.AcceptChanges();
            return exch;
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string VaridarFilaProd(VentasCommon.venCotizacionesDS Exch, VentasCommon.venCotizacionesDS exchNoPost, 
                int pIndice, Command cmd)
        {
            string lRetorno = "";
            VentasValidacion.venSubTipoMov.ExistePosteadoyActivo(Exch.Principal[0].SubTipoMov_Id, cmd);
            if (exchNoPost.grdCuerpo[0].CantidadOriginal <= 0)
                Generalidades.qFunctionalException.GenerarExcepcion("La_Cantidad_Debe_Ser_Mayor_Que_Cero");
            StockValidacion.stkProductos.ExistePosteadoActivoyVentas(exchNoPost.grdCuerpo[0].Producto_Id, cmd);

            
            return lRetorno;
        }


        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venCotizacionesDS CambiarPUxUM(VentasCommon.venCotizacionesDS exch,
            VentasCommon.venCotizacionesDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            VentasExchange.venListasPrecProdActionExchange exchVLPP = new VentasExchange.venListasPrecProdActionExchange
                (VentasExchange.venListasPrecProdActionEnum.EnumvenListasPrecProdAction.DatosFecha);

            exchVLPP.Producto_Id = exchNoPost.grdCuerpo[0].Producto_Id;
            exchVLPP.ListaPrecio_Id = exch.Principal[0].ListaPrecio_Id;
            exchVLPP.Fecha = exch.Principal[0].Fecha;

            exchVLPP = new VentasExchange.venListasPrecProdActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                (new Framework.Core.Exchange(exchVLPP), cmd));

            StockExchange.stkArtiUMActionExchange exchProdUM = StockValidacion.stkArtiUM.PerteneceUMProd(exchNoPost.grdCuerpo[0].Producto_Id,
                exchNoPost.grdCuerpo[0].Medida_Id, cmd);

            VentasExchange.venSubTipoMovActionExchange exchSubTipo = new VentasExchange.venSubTipoMovActionExchange
                (VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos)
            {
                SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id
            };
            exchSubTipo = new VentasExchange.venSubTipoMovActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchSubTipo, cmd));

            if (!String.IsNullOrEmpty(exchVLPP.Producto_Id) && !String.IsNullOrEmpty(exchVLPP.ListaPrecio_Id))
            {

                var eLista = VentasValidacion.venListaPrecios.Existe(exch.Principal[0].ListaPrecio_Id, cmd);
                // AJ Usar la cantidad de decimales de la LP
                exchNoPost.grdCuerpo[0].PrecioLista = Generalidades.Auxiliares.Redondear(exchVLPP.PrecioLista * exch.Principal[0].Cambio, eLista.DecimalesPu);

                if (exchSubTipo.TipoPrecioForm != "S")
                {
                    // AJ LE QUITE CAMBIO PORQUE YA MULTIPLICABA ARRIBA
                    exchNoPost.grdCuerpo[0].PrecioListaForm = Generalidades.Auxiliares.Redondear(exchNoPost.grdCuerpo[0].PrecioLista * exchProdUM.Factor, eLista.DecimalesPu);
                }
                else
                {
                    exchNoPost.grdCuerpo[0].PrecioListaForm = exchNoPost.grdCuerpo[0].PrecioLista;
                }
                exchNoPost.grdCuerpo[0].PrecioForm = exchNoPost.grdCuerpo[0].PrecioListaForm;
                exchNoPost.grdCuerpo[0].Factor = exchProdUM.Factor;
                //exchNoPost.grdCuerpo[0].PrecioListaForm = exchNoPost.grdCuerpo[0].PrecioForm;
            }
            return exchNoPost;
        }

        [Generalidades.QFuncion_EnviarMail]
        public Generalidades.CorreoDS Enviar(VentasCommon.venCotizacionesDS pCommonDS, Framework.Core.Command cmd)
        {
            Generalidades.CorreoDS lRetorno = new Generalidades.CorreoDS();
            VentasExchange.venCotizacionesEnviarActionExchange eMov = new VentasExchange.venCotizacionesEnviarActionExchange(VentasExchange.venCotizacionesEnviarActionEnum.EnumvenCotizacionesEnviarAction.Datos)
            {
                Segmento_Id = pCommonDS.Principal[0].Segmento_Id,
                Segmento1N = pCommonDS.Principal[0].Segmento1N,
                Segmento2N = pCommonDS.Principal[0].Segmento2N,
                Segmento3N = pCommonDS.Principal[0].Segmento3N,
                Segmento4N = pCommonDS.Principal[0].Segmento4N,
                Segmento1C = pCommonDS.Principal[0].Segmento1C,
                Segmento2C = pCommonDS.Principal[0].Segmento2C,
                Segmento3C = pCommonDS.Principal[0].Segmento3C,
                Segmento4C = pCommonDS.Principal[0].Segmento4C
            };
            eMov = new VentasExchange.venCotizacionesEnviarActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

            lRetorno.Principal.AddPrincipalRow(eMov.Param.Cabecera[0].Asunto, eMov.Param.Cabecera[0].Cuerpo,
                    eMov.Param.Cabecera[0].Destinatarios, eMov.Param.Cabecera[0].DestinatariosCopia, eMov.Param.Cabecera[0].DestinatariosCopiaOculta, false);
            foreach (var ren in eMov.Param.Adjuntos)
            {
                lRetorno.Adjuntos.AddAdjuntosRow(ren.Renglon, ren.Guid, ren.NombreArchivo, ren.Extension,
                      ren.ArchivoBase64, ren.Estado);
            }
            //...... 
            //...... 
            // Los destinatarios van separados por ';'
            // El datatable de adjuntos tiene la misma estructura y forma de utilizarse que el datatable adjuntos de cualquier entidad o movimiwento
            // Se puede usar el método Generalidades.Auxiliares.AdjuntosCompletarDatos(NombreTabla, Identity, Path, cmd) para completar el datatable de ajuntos del mail, con los adjuntos asociados a la entidad o movimiento
            return lRetorno;

        }

    }
}

