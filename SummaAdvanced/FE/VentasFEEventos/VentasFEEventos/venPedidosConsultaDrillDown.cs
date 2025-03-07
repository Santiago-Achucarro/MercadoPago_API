using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasFEEventos
{
    public class venPedidosConsultaDrillDown
    {

        [Generalidades.QFuncion_Condicion]
        public string Extranjero(VentasCommon.venPedidosConsultaDrillDownDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venClieHabitualActionExchange ExcVen = new VentasExchange.venClieHabitualActionExchange(VentasExchange.venClieHabitualActionEnum.EnumvenClieHabitualAction.Datos);
            ExcVen.Cliente_Id = exch.Principal[0].Cliente_Id;
            ExcVen.Sucursal = exch.Principal[0].Sucursal;
            ExcVen = new VentasExchange.venClieHabitualActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVen, cmd));

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
        public string PideCambio(VentasCommon.venPedidosConsultaDrillDownDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);

            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));

            if (ExcVenSubTipomov.Existe)
            {
                if (ExcVenSubTipomov.PideCambio)
                {
                    // solo es modeda distinta
                    VentasExchange.venListasPreciosActionExchange ExcLP = new VentasExchange.venListasPreciosActionExchange(VentasExchange.venListasPreciosActionEnum.EnumvenListasPreciosAction.Datos);
                    ExcLP.ListaPrecio_Id = exch.Principal[0].ListaPrecio_Id;
                    ExcLP = new VentasExchange.venListasPreciosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcLP, cmd));


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
        public string EnMonedaBase(VentasCommon.venPedidosConsultaDrillDownDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Moneda_Id == "" || exch.Principal[0].Moneda_Id == cmd.MonedaBase)
                return "S";
            else
                return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string FacturaAnticipo(VentasCommon.venPedidosConsultaDrillDownDS exch, Framework.Core.Command cmd)
        {

            if (exch.Principal[0].FacturaAnticipo)
                return "S";
            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string TipoAnticipo(VentasCommon.venPedidosConsultaDrillDownDS exch, Framework.Core.Command cmd)
        {
            if (!exch.Principal[0].FacturaAnticipo)
                return "Z";

            if (exch.Principal[0].PorAnticipo != 0)
                return "P";
            if (exch.Principal[0].Anticipo != 0)
                return "I";
            return "N";
        }


        public enum venPedidosConsultaDrillDownVar
        {
            ModificaPrecio, AdmiteBoniRenglon, ModCondPago, ModVendedor, PideObservaciones, ModListaPrecios, PideFechaEntrega, PideObsReng, PideReferencia, PideOrdenCompra, PideMarcaReserva, DepositoDefecto, PideCentro1, PideCentro2, PermiteSoloEntrega, ModiUniMed, ManejoDeposito, ModiDeposito, TipoPrecioForm, ModiFecha, PorCotizacion
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesSubTipo(VentasCommon.venPedidosConsultaDrillDownDS exch, VentasCommon.venPedidosConsultaDrillDownDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);


            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));

            GeneralesExchange.genEmpresasActionExchange exchEmpr = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);


            Dictionary<string, string> lRetorno = new Dictionary<string, string>();

            /*
            if (exch.Principal[0].SubTipoMov_Id != "")
                lRetorno.Add(venPedidosVar.STMIngresado.ToString(), "S");
            else
                lRetorno.Add(venPedidosVar.STMIngresado.ToString(), "N");
                */

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModCondPago)
                lRetorno.Add(venPedidosConsultaDrillDownVar.ModCondPago.ToString(), "S");
            else
                lRetorno.Add(venPedidosConsultaDrillDownVar.ModCondPago.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModVendedor)
                lRetorno.Add(venPedidosConsultaDrillDownVar.ModVendedor.ToString(), "S");
            else
                lRetorno.Add(venPedidosConsultaDrillDownVar.ModVendedor.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideObervaciones)
                lRetorno.Add(venPedidosConsultaDrillDownVar.PideObservaciones.ToString(), "S");
            else
                lRetorno.Add(venPedidosConsultaDrillDownVar.PideObservaciones.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModificaPrecio)
                lRetorno.Add(venPedidosConsultaDrillDownVar.ModificaPrecio.ToString(), "S");
            else
                lRetorno.Add(venPedidosConsultaDrillDownVar.ModificaPrecio.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.AdmiteBoniRenglon)
                lRetorno.Add(venPedidosConsultaDrillDownVar.AdmiteBoniRenglon.ToString(), "S");
            else
                lRetorno.Add(venPedidosConsultaDrillDownVar.AdmiteBoniRenglon.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModListaPrecios)
                lRetorno.Add(venPedidosConsultaDrillDownVar.ModListaPrecios.ToString(), "S");
            else
                lRetorno.Add(venPedidosConsultaDrillDownVar.ModListaPrecios.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideFechaEntrega)
                lRetorno.Add(venPedidosConsultaDrillDownVar.PideFechaEntrega.ToString(), "S");
            else
                lRetorno.Add(venPedidosConsultaDrillDownVar.PideFechaEntrega.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideObsReng)
                lRetorno.Add(venPedidosConsultaDrillDownVar.PideObsReng.ToString(), "S");
            else
                lRetorno.Add(venPedidosConsultaDrillDownVar.PideObsReng.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideReferencia)
                lRetorno.Add(venPedidosConsultaDrillDownVar.PideReferencia.ToString(), "S");
            else
                lRetorno.Add(venPedidosConsultaDrillDownVar.PideReferencia.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideOrdenCompra)
                lRetorno.Add(venPedidosConsultaDrillDownVar.PideOrdenCompra.ToString(), "S");
            else
                lRetorno.Add(venPedidosConsultaDrillDownVar.PideOrdenCompra.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideMarcaReserva)
                lRetorno.Add(venPedidosConsultaDrillDownVar.PideMarcaReserva.ToString(), "S");
            else
                lRetorno.Add(venPedidosConsultaDrillDownVar.PideMarcaReserva.ToString(), "N");

            if (exchEmpr.Centro1De == "CPR")
                lRetorno.Add(venPedidosConsultaDrillDownVar.PideCentro1.ToString(), "S");
            else
                lRetorno.Add(venPedidosConsultaDrillDownVar.PideCentro1.ToString(), "N");

            if (exchEmpr.Centro2De == "CPR")
                lRetorno.Add(venPedidosConsultaDrillDownVar.PideCentro2.ToString(), "S");
            else
                lRetorno.Add(venPedidosConsultaDrillDownVar.PideCentro2.ToString(), "N");

            if (ExcVenSubTipomov.PermiteSoloEntrega)
                lRetorno.Add(venPedidosConsultaDrillDownVar.PermiteSoloEntrega.ToString(), "S");
            else
                lRetorno.Add(venPedidosConsultaDrillDownVar.PermiteSoloEntrega.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModiUniMed)
                lRetorno.Add(venPedidosConsultaDrillDownVar.ModiUniMed.ToString(), "S");
            else
                lRetorno.Add(venPedidosConsultaDrillDownVar.ModiUniMed.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModDeposito)
                lRetorno.Add(venPedidosConsultaDrillDownVar.ModiDeposito.ToString(), "S");
            else
                lRetorno.Add(venPedidosConsultaDrillDownVar.ModiDeposito.ToString(), "N");

            if (ExcVenSubTipomov.Existe)
                lRetorno.Add(venPedidosConsultaDrillDownVar.TipoPrecioForm.ToString(), ExcVenSubTipomov.TipoPrecioForm);
            else
                lRetorno.Add(venPedidosConsultaDrillDownVar.TipoPrecioForm.ToString(), "");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModFecha)
                lRetorno.Add(venPedidosConsultaDrillDownVar.ModiFecha.ToString(), "S");
            else
                lRetorno.Add(venPedidosConsultaDrillDownVar.ModiFecha.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PorCotizacion)
                lRetorno.Add(venPedidosConsultaDrillDownVar.PorCotizacion.ToString(), "S");
            else
                lRetorno.Add(venPedidosConsultaDrillDownVar.PorCotizacion.ToString(), "N");
            return lRetorno;
        }


        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductos(VentasCommon.venPedidosConsultaDrillDownDS exch, VentasCommon.venPedidosConsultaDrillDownDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            StockExchange.stkProductosActionExchange exchProd = new StockExchange.stkProductosActionExchange (StockExchange.stkProductosActionEnum.EnumstkProductosAction.Datos);
            exchProd.Producto_Id = exchNoPost.grdCuerpo[0].Producto_Id;
            exchProd = new StockExchange.stkProductosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                (new Framework.Core.Exchange(exchProd), cmd));

            GeneralesExchange.genEmpresasActionExchange exchEmpr = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);

            Dictionary<string, string> lRetorno = new Dictionary<string, string>();
            // Si es servicio pero alguno de los centros lo saca del depósito, lo muestro igual //
            if (exchProd.Clase != "D" || exchEmpr.Centro1De == "DEP" || exchEmpr.Centro2De == "DEP")
                // Si no es Servicio muestro el depósito //
                lRetorno.Add(venPedidosConsultaDrillDownVar.ManejoDeposito.ToString(), "S");
            else
                // Si es Servicio se pide el depósito //
                lRetorno.Add(venPedidosConsultaDrillDownVar.ManejoDeposito.ToString(), "N");

            return lRetorno;
        }


        [Generalidades.QFuncion_CondicionGrilla]
        public string ProdManejaUMAlt(VentasCommon.venPedidosConsultaDrillDownDS exch, VentasCommon.venPedidosConsultaDrillDownDS exchNoPost, int pIndice, Framework.Core.Command cmd)
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
        public string ManejaDepo(VentasCommon.venPedidosConsultaDrillDownDS exch, VentasCommon.venPedidosConsultaDrillDownDS exchNoPost, int pIndice, Framework.Core.Command cmd)
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


        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venPedidosConsultaDrillDownDS Stock(VentasCommon.venPedidosConsultaDrillDownDS exch, VentasCommon.venPedidosConsultaDrillDownDS exchNoPost, int pIndice, Framework.Core.Command cmd)
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
        public VentasCommon.venPedidosConsultaDrillDownDS EnTransito(VentasCommon.venPedidosConsultaDrillDownDS exch, VentasCommon.venPedidosConsultaDrillDownDS exchNoPost, int pIndice, Framework.Core.Command cmd)
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
        public VentasCommon.venPedidosConsultaDrillDownDS Pedidos(VentasCommon.venPedidosConsultaDrillDownDS exch, VentasCommon.venPedidosConsultaDrillDownDS exchNoPost, int pIndice, Framework.Core.Command cmd)
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
        public VentasCommon.venPedidosConsultaDrillDownDS Compras(VentasCommon.venPedidosConsultaDrillDownDS exch, VentasCommon.venPedidosConsultaDrillDownDS exchNoPost, int pIndice, Framework.Core.Command cmd)
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
        public VentasCommon.venPedidosConsultaDrillDownDS Embarques(VentasCommon.venPedidosConsultaDrillDownDS exch, VentasCommon.venPedidosConsultaDrillDownDS exchNoPost, int pIndice, Framework.Core.Command cmd)
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
    }
}
