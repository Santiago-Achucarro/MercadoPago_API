using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasFEEventos
{
    public class venMovimientosConsultaDrillDown
    {
        [Generalidades.QFuncion_Condicion]
        public string Anulada(VentasCommon.venMovimientosConsultaDrillDownDS exch, Framework.Core.Command cmd)
        {
            return (exch.Principal[0].Anulado ? "S" : "N");
        }


        [Generalidades.QFuncion_Condicion]
        public string PideCambio(VentasCommon.venMovimientosConsultaDrillDownDS exch, Framework.Core.Command cmd)
        {
            // Si la moneda de facturación es diferente de la moneda base, entonces tiene que pedir el cambio //
            bool lCambio1 = true;
            if (exch.Principal[0].Moneda_Id != cmd.MonedaBase)
                lCambio1 = false;


            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);

            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange ( Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideCambio && !lCambio1)
                return "S";
            else
                return "N";
        }


        public enum venMovimientosConsultaDrillDownVar
        {
            ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, ManejoDeposito, ManejoCantEntregada, LetraCondFiscal, PideCambio, ModificaPrecio, AdmiteBoniRenglon, ModCondPago, ModVendedor, PideObservaciones, ModListaPrecios, PideFechaEntrega, PideObsReng, AdmiteFactsinEntr, ManejaLoteoSerie, DepositoDefecto, STMIngresado, PideCentro1, PideCentro2, MuestraDespacho, ManejaUbicacion, ModiDeposito, TipoPrecioForm, ModiFecha, PorCotizacion
        }


        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesSubTipo(VentasCommon.venMovimientosConsultaDrillDownDS exch, VentasCommon.venMovimientosConsultaDrillDownDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);


            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange( Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));

            GeneralesExchange.genEmpresasActionExchange exchEmpr = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);


            Dictionary<string, string> lRetorno = new Dictionary<string, string>();

            if (exch.Principal[0].SubTipoMov_Id != "" && exch.Principal[0].Cliente_Id != "")
                lRetorno.Add(venMovimientosConsultaDrillDownVar.STMIngresado.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.STMIngresado.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideCambio)
                lRetorno.Add(venMovimientosConsultaDrillDownVar.PideCambio.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.PideCambio.ToString(), "N");


            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModCondPago)
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ModCondPago.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ModCondPago.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModVendedor)
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ModVendedor.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ModVendedor.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.AdmiteBoniRenglon)
                lRetorno.Add(venMovimientosConsultaDrillDownVar.AdmiteBoniRenglon.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.AdmiteBoniRenglon.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideObervaciones)
                lRetorno.Add(venMovimientosConsultaDrillDownVar.PideObservaciones.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.PideObservaciones.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.AdmiteFactsinEntr)
                lRetorno.Add(venMovimientosConsultaDrillDownVar.AdmiteFactsinEntr.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.AdmiteFactsinEntr.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModificaPrecio)
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ModificaPrecio.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ModificaPrecio.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModListaPrecios)
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ModListaPrecios.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ModListaPrecios.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideFechaEntrega)
                lRetorno.Add(venMovimientosConsultaDrillDownVar.PideFechaEntrega.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.PideFechaEntrega.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideObsReng)
                lRetorno.Add(venMovimientosConsultaDrillDownVar.PideObsReng.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.PideObsReng.ToString(), "N");

            string lDepo = GeneralesValidacion.genSucursalesEmpr.Existe(GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd).Sucursal, cmd).DepositoVentas;

            lRetorno.Add(venMovimientosConsultaDrillDownVar.DepositoDefecto.ToString(), lDepo);

            if (exchEmpr.Centro1De == "CPR")
                lRetorno.Add(venMovimientosConsultaDrillDownVar.PideCentro1.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.PideCentro1.ToString(), "N");

            if (exchEmpr.Centro2De == "CPR")
                lRetorno.Add(venMovimientosConsultaDrillDownVar.PideCentro2.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.PideCentro2.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModDeposito)
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ModiDeposito.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ModiDeposito.ToString(), "N");

            if (ExcVenSubTipomov.Existe)
                lRetorno.Add(venMovimientosConsultaDrillDownVar.TipoPrecioForm.ToString(), ExcVenSubTipomov.TipoPrecioForm);
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.TipoPrecioForm.ToString(), "");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModFecha)
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ModiFecha.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ModiFecha.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PorCotizacion)
                lRetorno.Add(venMovimientosConsultaDrillDownVar.PorCotizacion.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.PorCotizacion.ToString(), "N");
            return lRetorno;
        }



        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductos(VentasCommon.venMovimientosConsultaDrillDownDS exch,
    VentasCommon.venMovimientosConsultaDrillDownDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            StockExchange.stkProductosActionExchange exchProd = new StockExchange.stkProductosActionExchange
                 (StockExchange.stkProductosActionEnum.EnumstkProductosAction.Datos);
            exchProd.Producto_Id = exchNoPost.Cuerpo[0].Producto_Id;
            exchProd = new StockExchange.stkProductosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                (new Framework.Core.Exchange(exchProd), cmd));

            GeneralesExchange.genEmpresasActionExchange exchEmpr = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);

            Dictionary<string, string> lRetorno = new Dictionary<string, string>();

            if (exchProd.Serializable)
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ManejaSerie.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ManejaSerie.ToString(), "N");

            if (exchProd.TrabajaPorLotes)
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ManejaLote.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ManejaLote.ToString(), "N");

            if (exchProd.TrabajaPorLotes || exchProd.Serializable)
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ManejaLoteoSerie.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ManejaLoteoSerie.ToString(), "N");

            if (exchProd.conVencimiento)
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ManejaVencimiento.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ManejaVencimiento.ToString(), "N");

            if (exchProd.MedidaAlterna != "")
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ManejaUMAlterna.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ManejaUMAlterna.ToString(), "N");

            lRetorno.Add(venMovimientosConsultaDrillDownVar.Clase.ToString(), exchProd.Clase);

            // FM 20/03/2019 Si es servicio pero alguno de los centros lo saca del depósito, lo muestro igual //
            if (exchProd.Clase != "D" || exchEmpr.Centro1De == "DEP" || exchEmpr.Centro2De == "DEP")
                // Si no es Servicio muestro el depósito //
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ManejoDeposito.ToString(), "S");
            else
                // Si es Servicio se pide el depósito //
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ManejoDeposito.ToString(), "N");

            // FM 18/07/2019 Si en NC y maneja Despacho que muestre la lupa de despacho //
            if (exchProd.UsaDespachoImportacion && exch.Principal[0].venTipoMov == "R")
                lRetorno.Add(venMovimientosConsultaDrillDownVar.MuestraDespacho.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.MuestraDespacho.ToString(), "N");

            // PARA 
            StockExchange.stkDepositosActionExchange eDepo = new StockExchange.stkDepositosActionExchange(StockExchange.stkDepositosActionEnum.EnumstkDepositosAction.Datos)
            {
                Deposito_Id = exchNoPost.Cuerpo[0].Deposito_Id
            };

            eDepo = new StockExchange.stkDepositosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eDepo, cmd));
            if (eDepo.Existe && eDepo.UsaUbicacion)
            {
                var eTm = VentasValidacion.venTipomov.Existe(exch.Principal[0].venTipoMov, cmd);
                if (eTm.Signo == 1)
                    lRetorno.Add(venMovimientosConsultaDrillDownVar.ManejaUbicacion.ToString(), "S");
                else
                {

                    lRetorno.Add(venMovimientosConsultaDrillDownVar.ManejaUbicacion.ToString(), "E");
                }
            }
            else
                lRetorno.Add(venMovimientosConsultaDrillDownVar.ManejaUbicacion.ToString(), "N");

            return lRetorno;
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesCliente(VentasCommon.venMovimientosConsultaDrillDownDS exch,
    VentasCommon.venMovimientosConsultaDrillDownDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            VentasExchange.venClientesActionExchange exchClie = new VentasExchange.venClientesActionExchange
                 (VentasExchange.venClientesActionEnum.EnumvenClientesAction.Datos);
            exchClie.Cliente_Id = exch.Principal[0].Cliente_Id;
            exchClie = new VentasExchange.venClientesActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                (new Framework.Core.Exchange(exchClie), cmd));

            Dictionary<string, string> lRetorno = new Dictionary<string, string>();

            if (exchClie.Existe)
            {
                VentasExchange.venCondFiscalActionExchange exchVCF = new VentasExchange.venCondFiscalActionExchange
                    (VentasExchange.venCondFiscalActionEnum.EnumvenCondFiscalAction.Datos);
                exchVCF.CondFisc_Id = exchClie.CondFisc_Id;
                exchVCF = new VentasExchange.venCondFiscalActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                    (new Framework.Core.Exchange(exchVCF), cmd));


                lRetorno.Add(venMovimientosConsultaDrillDownVar.LetraCondFiscal.ToString(), exchVCF.Letra);
            }
            return lRetorno;
        }


        [Generalidades.QFuncion_Condicion]
        public string ManejaCantidadAlterna(VentasCommon.venMovimientosConsultaDrillDownDS exch, Framework.Core.Command cmd)
        {
            GeneralesExchange.genEmpresasActionExchange ExcEmp = new GeneralesExchange.genEmpresasActionExchange(GeneralesExchange.genEmpresasActionEnum.EnumgenEmpresasAction.Datos);

            ExcEmp.Empresa_Id = "";
            ExcEmp.genEmpresas = cmd.Empresa_Id;
            ExcEmp = new GeneralesExchange.genEmpresasActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcEmp, cmd));

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


        [Generalidades.QFuncion_Condicion]
        public string MostrarBotonIne(VentasCommon.venMovimientosConsultaDrillDownDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venClieHabitualActionExchange eClie = new VentasExchange.venClieHabitualActionExchange(VentasExchange.venClieHabitualActionEnum.EnumvenClieHabitualAction.Datos);
            eClie.Cliente_Id = exch.Principal[0].Cliente_Id;
            eClie.Sucursal = exch.Principal[0].Sucursal;
            eClie = new VentasExchange.venClieHabitualActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eClie, cmd));
            if (eClie.UsaComplementoINE)
                return "S";
            return "N";
        }


        [Generalidades.QFuncion_Condicion]
        public string Extranjero(VentasCommon.venMovimientosConsultaDrillDownDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venClieHabitualActionExchange ExcVen = new VentasExchange.venClieHabitualActionExchange(VentasExchange.venClieHabitualActionEnum.EnumvenClieHabitualAction.Datos);
            ExcVen.Cliente_Id = exch.Principal[0].Cliente_Id;
            ExcVen.Sucursal = exch.Principal[0].Sucursal;
            ExcVen = new VentasExchange.venClieHabitualActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVen, cmd));

            if (ExcVen.Existe)
            {
                if (ExcVen.Dominio_Id == cmd.Dominio_Id)
                {
                    if (cmd.Dominio_Id == "AR")
                    {
                        // Si es Argentina también se toma como extranjero si es Tierra del Fuego que tiene letra E //
                        VentasExchange.venCondFiscalActionExchange exchCF = new VentasExchange.venCondFiscalActionExchange(VentasExchange.venCondFiscalActionEnum.EnumvenCondFiscalAction.Datos)
                        {
                            CondFisc_Id = ExcVen.CondFisc_Id
                        };
                        exchCF = new VentasExchange.venCondFiscalActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchCF, cmd));
                        if (exchCF.Letra == "E")
                            return "S";
                        else
                            return "N";
                    }
                    else
                    {
                        return "N";
                    }
                }
                else
                    return "S";

            }

            return "N";
        }

    }
}
