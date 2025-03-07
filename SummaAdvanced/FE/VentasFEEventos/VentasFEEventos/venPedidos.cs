using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasFEEventos
{
    public class venPedidos
    {



        [Generalidades.QFuncion_Condicion]
        public string Extranjero(VentasCommon.venPedidosDS exch, Framework.Core.Command cmd)
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
                    // Si es AR, si la letra es E también se lo toma como extranjero //
                    if (cmd.Dominio_Id == "AR")
                    {
                        VentasExchange.venCondFiscalActionExchange exchCF = new VentasExchange.venCondFiscalActionExchange(VentasExchange.venCondFiscalActionEnum.EnumvenCondFiscalAction.Datos)
                        {
                            CondFisc_Id = ExcVen.CondFisc_Id
                        };
                        exchCF = new VentasExchange.venCondFiscalActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchCF, cmd));
                        if (exchCF.Letra == "E")
                            return "S";
                        return "N";
                    }
                    else
                        return "N";
                else
                    return "S";

            }

            return "N";
        }


        [Generalidades.QFuncion_Condicion]
        public string PideCambio(VentasCommon.venPedidosDS exch, Framework.Core.Command cmd)
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
        public string EnMonedaBase(VentasCommon.venPedidosDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Moneda_Id == "" || exch.Principal[0].Moneda_Id == cmd.MonedaBase)
                return "S";
            else
                return "N";
        }


        [Generalidades.QFuncion_Condicion]
        public string FacturaAnticipo(VentasCommon.venPedidosDS exch, Framework.Core.Command cmd)
        {

            if (exch.Principal[0].FacturaAnticipo)
                return "S";
            return "N";

        }

        [Generalidades.QFuncion_Condicion]
        public string TipoAnticipo(VentasCommon.venPedidosDS exch, Framework.Core.Command cmd)
        {
            if (!exch.Principal[0].FacturaAnticipo)
                return "Z";

            if (exch.Principal[0].PorAnticipo != 0)
                return "P";
            if (exch.Principal[0].Anticipo != 0)
                return "I";
            return "N";
        }


        public enum venPedidosVar
        {
            ModificaPrecio, AdmiteBoniRenglon, ModCondPago, ModVendedor, PideObservaciones, ModListaPrecios,
            PideFechaEntrega, PideObsReng, PideReferencia, PideOrdenCompra, PideMarcaReserva, DepositoDefecto,
            PideCentro1, PideCentro2, PermiteSoloEntrega, ModiUniMed, ManejoDeposito, ModiDeposito, TipoPrecioForm, ModiFecha, 
            PorCotizacion,Sucursal
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> DepositoDefecto(VentasCommon.venPedidosDS exch,
VentasCommon.venPedidosDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            Dictionary<string, string> lRetorno = new Dictionary<string, string>();
            string lDepo = GeneralesValidacion.genSucursalesEmpr.Existe(GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd).Sucursal, cmd).DepositoPedidos;

            lRetorno.Add(venPedidosVar.DepositoDefecto.ToString(), lDepo);
            return lRetorno;
        }

    [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesSubTipo(VentasCommon.venPedidosDS exch,
VentasCommon.venPedidosDS exchNoPost, int pIndice, Framework.Core.Command cmd)
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
                lRetorno.Add(venPedidosVar.STMIngresado.ToString(), "S");
            else
                lRetorno.Add(venPedidosVar.STMIngresado.ToString(), "N");
                */

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModCondPago)
                lRetorno.Add(venPedidosVar.ModCondPago.ToString(), "S");
            else
                lRetorno.Add(venPedidosVar.ModCondPago.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModVendedor)
                lRetorno.Add(venPedidosVar.ModVendedor.ToString(), "S");
            else
                lRetorno.Add(venPedidosVar.ModVendedor.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideObervaciones)
                lRetorno.Add(venPedidosVar.PideObservaciones.ToString(), "S");
            else
                lRetorno.Add(venPedidosVar.PideObservaciones.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModificaPrecio)
                lRetorno.Add(venPedidosVar.ModificaPrecio.ToString(), "S");
            else
                lRetorno.Add(venPedidosVar.ModificaPrecio.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.AdmiteBoniRenglon)
                lRetorno.Add(venPedidosVar.AdmiteBoniRenglon.ToString(), "S");
            else
                lRetorno.Add(venPedidosVar.AdmiteBoniRenglon.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModListaPrecios)
                lRetorno.Add(venPedidosVar.ModListaPrecios.ToString(), "S");
            else
                lRetorno.Add(venPedidosVar.ModListaPrecios.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideFechaEntrega)
                lRetorno.Add(venPedidosVar.PideFechaEntrega.ToString(), "S");
            else
                lRetorno.Add(venPedidosVar.PideFechaEntrega.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideObsReng)
                lRetorno.Add(venPedidosVar.PideObsReng.ToString(), "S");
            else
                lRetorno.Add(venPedidosVar.PideObsReng.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideReferencia)
                lRetorno.Add(venPedidosVar.PideReferencia.ToString(), "S");
            else
                lRetorno.Add(venPedidosVar.PideReferencia.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideOrdenCompra)
                lRetorno.Add(venPedidosVar.PideOrdenCompra.ToString(), "S");
            else
                lRetorno.Add(venPedidosVar.PideOrdenCompra.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideMarcaReserva)
                lRetorno.Add(venPedidosVar.PideMarcaReserva.ToString(), "S");
            else
                lRetorno.Add(venPedidosVar.PideMarcaReserva.ToString(), "N");

            if (exchEmpr.Centro1De == "CPR")
                lRetorno.Add(venPedidosVar.PideCentro1.ToString(), "S");
            else
                lRetorno.Add(venPedidosVar.PideCentro1.ToString(), "N");

            if (exchEmpr.Centro2De == "CPR")
                lRetorno.Add(venPedidosVar.PideCentro2.ToString(), "S");
            else
                lRetorno.Add(venPedidosVar.PideCentro2.ToString(), "N");

            if (ExcVenSubTipomov.PermiteSoloEntrega)
                lRetorno.Add(venPedidosVar.PermiteSoloEntrega.ToString(), "S");
            else
                lRetorno.Add(venPedidosVar.PermiteSoloEntrega.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModiUniMed)
                lRetorno.Add(venPedidosVar.ModiUniMed.ToString(), "S");
            else
                lRetorno.Add(venPedidosVar.ModiUniMed.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModDeposito)
                lRetorno.Add(venPedidosVar.ModiDeposito.ToString(), "S");
            else
                lRetorno.Add(venPedidosVar.ModiDeposito.ToString(), "N");

            if (ExcVenSubTipomov.Existe)
                lRetorno.Add(venPedidosVar.TipoPrecioForm.ToString(), ExcVenSubTipomov.TipoPrecioForm);
            else
                lRetorno.Add(venPedidosVar.TipoPrecioForm.ToString(), "");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModFecha)
                lRetorno.Add(venPedidosVar.ModiFecha.ToString(), "S");
            else
                lRetorno.Add(venPedidosVar.ModiFecha.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PorCotizacion)
                lRetorno.Add(venPedidosVar.PorCotizacion.ToString(), "S");
            else
                lRetorno.Add(venPedidosVar.PorCotizacion.ToString(), "N");
            lRetorno.Add(venPedidosVar.Sucursal.ToString(), GeneralesValidacion.genUsuarios.Sucursal(cmd.Usuario_Id, cmd.Empresa_Id, cmd));
            return lRetorno;
        }


        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductos(VentasCommon.venPedidosDS exch,
    VentasCommon.venPedidosDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            StockExchange.stkProductosActionExchange exchProd = new StockExchange.stkProductosActionExchange
    (StockExchange.stkProductosActionEnum.EnumstkProductosAction.Datos);
            exchProd.Producto_Id = exchNoPost.grdCuerpo[0].Producto_Id;
            exchProd = new StockExchange.stkProductosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                (new Framework.Core.Exchange(exchProd), cmd));

            GeneralesExchange.genEmpresasActionExchange exchEmpr = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);

            Dictionary<string, string> lRetorno = new Dictionary<string, string>();
            // Si es servicio pero alguno de los centros lo saca del depósito, lo muestro igual //
            if (exchProd.Clase != "D" || exchEmpr.Centro1De == "DEP" || exchEmpr.Centro2De == "DEP")
                // Si no es Servicio muestro el depósito //
                lRetorno.Add(venPedidosVar.ManejoDeposito.ToString(), "S");
            else
                // Si es Servicio se pide el depósito //
                lRetorno.Add(venPedidosVar.ManejoDeposito.ToString(), "N");

            return lRetorno;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venPedidosDS AsignarDatosProd(VentasCommon.venPedidosDS exch,
    VentasCommon.venPedidosDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            // FM 24/09/2019 Cambie el !=0 por == 0 //
            //if (exchNoPost.grdCuerpo[0].PrecioForm == 0)
             // Si ya había sido asignado no lo vuelvo a asignar //

                exchNoPost = CambiarPUxUM(exch, exchNoPost, pIndice, cmd);
            

            return exchNoPost;

        }

        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venPedidosDS CambiarPUxUM(VentasCommon.venPedidosDS exch,
VentasCommon.venPedidosDS exchNoPost, int pIndice, Framework.Core.Command cmd)
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

                //exchNoPost.grdCuerpo[0].PrecioListaForm = exchNoPost.grdCuerpo[0].PrecioForm;
            }
            return exchNoPost;
        }
            


        [Generalidades.QFuncion_CondicionGrilla]
        public string ProdManejaUMAlt(VentasCommon.venPedidosDS exch, 
            VentasCommon.venPedidosDS exchNoPost, int pIndice, Framework.Core.Command cmd)
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
        public string ManejaDepo(VentasCommon.venPedidosDS exch, VentasCommon.venPedidosDS exchNoPost, int pIndice, Framework.Core.Command cmd)
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
        public string Parametros(VentasCommon.venPedidosDS exch, Framework.Core.Command cmd)
        {

            return
                     "Empresa_Id|" + cmd.Empresa_Id.ToString() + "@Segmento_Id|NP" +
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
        public VentasCommon.venPedidosDS Stock(VentasCommon.venPedidosDS exch, VentasCommon.venPedidosDS exchNoPost,
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
        public VentasCommon.venPedidosDS EnTransito(VentasCommon.venPedidosDS exch, VentasCommon.venPedidosDS exchNoPost,
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
        public VentasCommon.venPedidosDS Pedidos(VentasCommon.venPedidosDS exch, VentasCommon.venPedidosDS exchNoPost,
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
        public VentasCommon.venPedidosDS Compras(VentasCommon.venPedidosDS exch, VentasCommon.venPedidosDS exchNoPost,
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
        public VentasCommon.venPedidosDS Embarques(VentasCommon.venPedidosDS exch, VentasCommon.venPedidosDS exchNoPost,
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
        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venPedidosDS LimiteCredito(VentasCommon.venPedidosDS exch, VentasCommon.venPedidosDS exchNoPost,
           int pIndice, Framework.Core.Command cmd)
        {
            exch.LimiteCredito.Clear();
            VentasExchange.venVeriCreditoActionExchange eCred = new VentasExchange.venVeriCreditoActionExchange(VentasExchange.venVeriCreditoActionEnum.EnumvenVeriCreditoAction.Calcular)
            {
                Cliente_Id = exch.Principal[0].Cliente_Id
            };
            eCred = new VentasExchange.venVeriCreditoActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eCred, cmd));
            if (eCred.Param.Motivos.Count == 0)
            {
                string Motivos = "";
                foreach (var ren in eCred.Param.Motivos)
                    Motivos += ren.Motivo + "; ";
                Generalidades.qFunctionalException.GenerarExcepcion(Motivos);
            }
            exch.LimiteCredito.AddLimiteCreditoRow(eCred.Disponible, eCred.LimiteCredito);
            return exch;
        }


        [Generalidades.QFuncion_CondicionGrilla]
        public string VaridarFilaProd(VentasCommon.venPedidosDS Exch, VentasCommon.venPedidosDS exchNoPost,
                int pIndice, Command cmd)
        {
            string lRetorno = "";
            VentasValidacion.venSubTipoMov.ExistePosteadoyActivo(Exch.Principal[0].SubTipoMov_Id, cmd);
            if (exchNoPost.grdCuerpo[0].CantidadOriginal <= 0)
                Generalidades.qFunctionalException.GenerarExcepcion("La_Cantidad_Debe_Ser_Mayor_Que_Cero");
            StockValidacion.stkProductos.ExistePosteadoActivoyVentas(exchNoPost.grdCuerpo[0].Producto_Id, cmd);


            return lRetorno;
        }

        [Generalidades.QFuncion_EnviarMail]
        public Generalidades.CorreoDS Enviar(VentasCommon.venPedidosDS pCommonDS, Framework.Core.Command cmd)
        {
            Generalidades.CorreoDS lRetorno = new Generalidades.CorreoDS();
            VentasExchange.venPedidosEnviarActionExchange eMov = new VentasExchange.venPedidosEnviarActionExchange(VentasExchange.venPedidosEnviarActionEnum.EnumvenPedidosEnviarAction.Datos)
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
            eMov = new VentasExchange.venPedidosEnviarActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

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

        [Generalidades.QFuncion_Condicion]
        public string EnviaPedido(VentasCommon.venPedidosDS exch, Framework.Core.Command cmd)
        {

            return (GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd).EnviaPedido ? "S" : "N");
        }
        [Generalidades.QFuncion_Condicion]
        public string ConfirmaEnvioPedido(VentasCommon.venPedidosDS exch, Framework.Core.Command cmd)
        {

            return (GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd).ConfirmarEnviarPedidos ? "S" : "N");
        }
    }
}
