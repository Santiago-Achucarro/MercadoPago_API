using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasFEEventos
{
    public class venMovimientosConStock
    {
        [Generalidades.QFuncion_Condicion]
        public string Extranjero(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
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


        [Generalidades.QFuncion_Condicion]
        public string CPORIGENEXTRA(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {

            if (exch.CartaPorte.Count > 0 && exch.CartaPorte[0].PaisOrigen != 0)
            {

                var Pais = new GeneralesExchange.genPaisesActionExchange(GeneralesExchange.genPaisesActionEnum.EnumgenPaisesAction.Datos)
                {
                    Pais_Id = exch.CartaPorte[0].PaisOrigen
                };
                Pais = new GeneralesExchange.genPaisesActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(Pais, cmd));
                if (Pais.Existe && Pais.CodFiscal != "MEX")
                    return "S";
            }

            return "N";

        }


        [Generalidades.QFuncion_Condicion]
        public string CPDESTINOEXTRA(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {

            if (exch.CartaPorte.Count > 0 && exch.CartaPorte[0].PaisDestino != 0)
            {

                var Pais = new GeneralesExchange.genPaisesActionExchange(GeneralesExchange.genPaisesActionEnum.EnumgenPaisesAction.Datos)
                {
                    Pais_Id = exch.CartaPorte[0].PaisDestino
                };
                Pais = new GeneralesExchange.genPaisesActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(Pais, cmd));
                if (Pais.Existe && Pais.CodFiscal != "MEX")
                    return "S";
            }

            return "N";

        }

        [Generalidades.QFuncion_Condicion]
        public string PideCambioMonOrig(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {
            // Si la moneda de la LP es diferente de la moneda de facturación tengo que pedir el cambio //
            // para pasar de la LP a la moneda de facturación //
            if (exch.venMovConStock[0].ListaPrecio_Id != "")
            {
                bool lCambio1 = true;

                VentasExchange.venListasPreciosActionExchange ExcLP = new VentasExchange.venListasPreciosActionExchange
                    (VentasExchange.venListasPreciosActionEnum.EnumvenListasPreciosAction.Datos);
                ExcLP.ListaPrecio_Id = exch.venMovConStock[0].ListaPrecio_Id;
                ExcLP = new VentasExchange.venListasPreciosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcLP, cmd));

                if (!ExcLP.Existe)
                    return "N";

                if (ExcLP.Moneda_Id != exch.Principal[0].Moneda_Id)
                {
                    GeneralesExchange.genTipoCambioActionExchange exchTC =
                        GeneralesValidacion.genTipoCambio.Existe(ExcLP.Moneda_Id, exch.Principal[0].Fecha, cmd);
                    exch.Principal[0].CambioMonedaOriginal = exchTC.CambioCompra;
                    lCambio1 = false;
                }
                else
                    exch.Principal[0].CambioMonedaOriginal = 1;


                VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
                    new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);

                ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
                ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                        Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));

                if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideCambio && !lCambio1)
                    return "S";
                else
                    return "N";


            }
            return "N";
        }


        [Generalidades.QFuncion_Condicion]
        public string PideCambio(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {
            // Si la moneda de facturación es diferente de la moneda base, entonces tiene que pedir el cambio //
            bool lCambio1 = true;
            if (exch.Principal[0].Moneda_Id != cmd.MonedaBase)
                lCambio1 = false;


            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
                new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);

            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideCambio && !lCambio1)
                return "S";
            else
                return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string EnMonedaBase(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Moneda_Id == "" || exch.Principal[0].Moneda_Id == cmd.MonedaBase)
                return "S";
            else
                return "N";
        }

        /*
        [Generalidades.QFuncion_Condicion]
        public string ModificaPrecio(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
                   new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);

            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));

            if (ExcVenSubTipomov.Existe)
            {
                if (ExcVenSubTipomov.ModificaPrecio)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string AdmiteBoniRenglon(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
                new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);

            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));

            if (ExcVenSubTipomov.Existe)
            {
                if (ExcVenSubTipomov.AdmiteBoniRenglon)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }


        [Generalidades.QFuncion_Condicion]
        public string ModCondPago(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {

            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
                new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);

            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));

            if (ExcVenSubTipomov.Existe)
            {
                if (ExcVenSubTipomov.ModCondPago)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string ModVendedor(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
                new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);

            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                        Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));

            if (ExcVenSubTipomov.Existe)
            {
                if (ExcVenSubTipomov.ModVendedor)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }


        [Generalidades.QFuncion_Condicion]
        public string PideObervaciones(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
                new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);

            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));
            if (ExcVenSubTipomov.Existe)
            {
                if (ExcVenSubTipomov.PideObervaciones)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string ModListaPrecios(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
                new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);

            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));
            if (ExcVenSubTipomov.Existe)
            {
                if (ExcVenSubTipomov.ModListaPrecios)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }


        [Generalidades.QFuncion_Condicion]
        public string PideFechaEntrega(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
                new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);

            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));
            if (ExcVenSubTipomov.Existe)
            {
                if (ExcVenSubTipomov.PideFechaEntrega)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string PideObsReng(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {

            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
                new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);

            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));
            if (ExcVenSubTipomov.Existe)
            {
                if (ExcVenSubTipomov.PideObsReng)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }
        */


        [Generalidades.QFuncion_Condicion]
        public string ManejaCantidadAlterna(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
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

        [Generalidades.QFuncion_Condicion]
        public string FacturaSinEnt(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {

            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
                new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);

            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));
            if (ExcVenSubTipomov.Existe)
            {
                if (ExcVenSubTipomov.AdmiteFactsinEntr)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }


        [Generalidades.QFuncion_Condicion]
        public string Anulada(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {
            return (exch.Principal[0].Anulado ? "S" : "N");
        }


        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFila(VentasCommon.venMovimientosConStockDS exch, VentasCommon.venMovimientosConStockDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            VentasValidacion.venSubTipoMov.ExistePosteadoyActivo(exch.Principal[0].SubTipoMov_Id, cmd);
            VentasCommon.venMovimientosConStockDS.grdCuerpoDataTable lDF = exchNoPost.grdCuerpo;

            if (lDF[0].Producto_Id == "")
                return "Debe_Ingresar_Un_codigo_de_producto";

            if (exchNoPost.grdCuerpo[0].CantOriginal == 0)
                return "Debe_Ingresar_la_Cantidad";
            return "";
        }

        [Generalidades.QFuncion_Condicion]
        public string PideCompleExpo(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {
            if (cmd.Dominio_Id != "MX")
                return "N";

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

        // PARA INE
        [Generalidades.QFuncion_Condicion]
        public string EsOrdinario(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {
            VentasFEEventos.venMovimientosFiscales lm = new VentasFEEventos.venMovimientosFiscales();
            return lm.EsOrdinario(exch.venMovFiscal[0].TipoProceso);
        }


        [Generalidades.QFuncion_Condicion]
        public string EsEstatal(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {
            VentasFEEventos.venMovimientosFiscales lm = new VentasFEEventos.venMovimientosFiscales();
            return lm.EsEstatal(exch.venMovFiscal[0].TipoComite);

        }


        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductos(VentasCommon.venMovimientosConStockDS exch,
            VentasCommon.venMovimientosConStockDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            StockExchange.stkProductosActionExchange exchProd = new StockExchange.stkProductosActionExchange
                 (StockExchange.stkProductosActionEnum.EnumstkProductosAction.Datos);
            exchProd.Producto_Id = exchNoPost.grdCuerpo[0].Producto_Id;
            exchProd = new StockExchange.stkProductosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                (new Framework.Core.Exchange(exchProd), cmd));

            GeneralesExchange.genEmpresasActionExchange exchEmpr = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);

            Dictionary<string, string> lRetorno = new Dictionary<string, string>();

            if (exchProd.Serializable)
                lRetorno.Add(venMovimientosConStockVar.ManejaSerie.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.ManejaSerie.ToString(), "N");

            if (exchProd.TrabajaPorLotes)
                lRetorno.Add(venMovimientosConStockVar.ManejaLote.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.ManejaLote.ToString(), "N");

            if (exchProd.TrabajaPorLotes || exchProd.Serializable)
                lRetorno.Add(venMovimientosConStockVar.ManejaLoteoSerie.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.ManejaLoteoSerie.ToString(), "N");

            if (exchProd.conVencimiento)
                lRetorno.Add(venMovimientosConStockVar.ManejaVencimiento.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.ManejaVencimiento.ToString(), "N");

            if (exchProd.MedidaAlterna != "")
                lRetorno.Add(venMovimientosConStockVar.ManejaUMAlterna.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.ManejaUMAlterna.ToString(), "N");

            lRetorno.Add(venMovimientosConStockVar.Clase.ToString(), exchProd.Clase);

            // FM 20/03/2019 Si es servicio pero alguno de los centros lo saca del depósito, lo muestro igual //
            if (exchProd.Clase != "D" || exchEmpr.Centro1De == "DEP" || exchEmpr.Centro2De == "DEP")
                // Si no es Servicio muestro el depósito //
                lRetorno.Add(venMovimientosConStockVar.ManejoDeposito.ToString(), "S");
            else
                // Si es Servicio se pide el depósito //
                lRetorno.Add(venMovimientosConStockVar.ManejoDeposito.ToString(), "N");

            // FM 18/07/2019 Si en NC y maneja Despacho que muestre la lupa de despacho //
            if (exchProd.UsaDespachoImportacion && "RX".Contains(exch.Principal[0].venTipoMov))
                lRetorno.Add(venMovimientosConStockVar.MuestraDespacho.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.MuestraDespacho.ToString(), "N");

            // PARA 
            StockExchange.stkDepositosActionExchange eDepo = new StockExchange.stkDepositosActionExchange(StockExchange.stkDepositosActionEnum.EnumstkDepositosAction.Datos)
            {
                Deposito_Id = exchNoPost.grdCuerpo[0].Deposito_Id
            };

            eDepo = new StockExchange.stkDepositosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eDepo, cmd));
            if (eDepo.Existe && eDepo.UsaUbicacion)
            {
                var eTm = VentasValidacion.venTipomov.Existe(exch.Principal[0].venTipoMov, cmd);
                if (eTm.Signo == 1)
                    lRetorno.Add(venMovimientosConStockVar.ManejaUbicacion.ToString(), "S");
                else
                {

                    lRetorno.Add(venMovimientosConStockVar.ManejaUbicacion.ToString(), "E");
                }
            }
            else
                lRetorno.Add(venMovimientosConStockVar.ManejaUbicacion.ToString(), "N");

            return lRetorno;
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesCliente(VentasCommon.venMovimientosConStockDS exch,
    VentasCommon.venMovimientosConStockDS exchNoPost, int pIndice, Framework.Core.Command cmd)
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


                lRetorno.Add(venMovimientosConStockVar.LetraCondFiscal.ToString(), exchVCF.Letra);
            }
            return lRetorno;
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesLP(VentasCommon.venMovimientosConStockDS exch,
    VentasCommon.venMovimientosConStockDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            Dictionary<string, string> lRetorno = new Dictionary<string, string>();

            // Devuelvo los dígitos de la LP para asignar en el control Precio //
            VentasExchange.venListasPreciosActionExchange exchLP = new VentasExchange.venListasPreciosActionExchange(VentasExchange.venListasPreciosActionEnum.EnumvenListasPreciosAction.DatosCabe)
            {
                ListaPrecio_Id = exch.venMovConStock[0].ListaPrecio_Id
            };
            exchLP = new VentasExchange.venListasPreciosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchLP, cmd));
            if (exchLP.Existe)
                lRetorno.Add(venMovimientosConStockVar.DigitosLP.ToString(), exchLP.DecimalesPu.ToString());
            else
                lRetorno.Add(venMovimientosConStockVar.DigitosLP.ToString(), 4.ToString());

            return lRetorno;
        }


        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venMovimientosConStockDS AsignarDatosProd(VentasCommon.venMovimientosConStockDS exch,
            VentasCommon.venMovimientosConStockDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            //AO: Cambie el !=0 por == 0 
            //if (exchNoPost.grdCuerpo[0].PrecioForm == 0 && exchNoPost.grdCuerpo[0].Producto_Id != "")
            { // Si ya había sido asignado no lo vuelvo a asignar //

                exchNoPost = CambiarPUxUM(exch, exchNoPost, pIndice, cmd);
            }

            return exchNoPost;

        }

        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venMovimientosConStockDS CambiarPUxUM(VentasCommon.venMovimientosConStockDS exch,
    VentasCommon.venMovimientosConStockDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            VentasExchange.venListasPrecProdActionExchange exchVLPP = new VentasExchange.venListasPrecProdActionExchange
(VentasExchange.venListasPrecProdActionEnum.EnumvenListasPrecProdAction.DatosFecha);
            exchVLPP.Producto_Id = exchNoPost.grdCuerpo[0].Producto_Id;
            exchVLPP.ListaPrecio_Id = exch.venMovConStock[0].ListaPrecio_Id;
            exchVLPP.Fecha = exch.Principal[0].Fecha;

            if (!String.IsNullOrEmpty(exchVLPP.Producto_Id) && !String.IsNullOrEmpty(exchVLPP.ListaPrecio_Id))
            {
                exchVLPP = new VentasExchange.venListasPrecProdActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                    (new Framework.Core.Exchange(exchVLPP), cmd));

                // FM 24/09/2019 //
                StockExchange.stkArtiUMActionExchange exchProdUM = StockValidacion.stkArtiUM.PerteneceUMProd(exchNoPost.grdCuerpo[0].Producto_Id,
    exchNoPost.grdCuerpo[0].Medida_Id, cmd);

                // AJ MAY 21
                exchNoPost.grdCuerpo[0].Factor = exchProdUM.Factor;

                VentasExchange.venSubTipoMovActionExchange exchSubTipo = new VentasExchange.venSubTipoMovActionExchange
                    (VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos)
                {
                    SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id
                };
                exchSubTipo = new VentasExchange.venSubTipoMovActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchSubTipo, cmd));


                //exchNoPost.grdCuerpo[0].PrecioLista = exchVLPP.PrecioLista;
                //// TODO FM Usar la cantidad de decimales de la UM 
                //exchNoPost.grdCuerpo[0].PrecioForm = 
                //    Generalidades.Auxiliares.Redondear(exchVLPP.PrecioLista * exch.Principal[0].CambioMonedaOriginal, 8);

                // Usar la cantidad de decimales de la LP
                var eLista = VentasValidacion.venListaPrecios.Existe(exch.venMovConStock[0].ListaPrecio_Id, cmd);
                if (exchSubTipo.TipoPrecioForm != "S")
                {
                    //EMP para que guarde bien el precio de lista en su moneda original 06/08/2021
                    exchNoPost.grdCuerpo[0].PrecioLista = Generalidades.Auxiliares.Redondear(exchVLPP.PrecioLista * exchProdUM.Factor, eLista.DecimalesPu);
                    exchNoPost.grdCuerpo[0].PrecioForm = Generalidades.Auxiliares.Redondear(exchVLPP.PrecioLista * exch.Principal[0].CambioMonedaOriginal * exchProdUM.Factor, eLista.DecimalesPu);

                    //exchNoPost.grdCuerpo[0].PrecioLista = Generalidades.Auxiliares.Redondear(exchVLPP.PrecioLista * exch.Principal[0].CambioMonedaOriginal * exchProdUM.Factor, eLista.DecimalesPu);
                }
                else
                {
                    //EMP para que guarde bien el precio de lista en su moneda original 06/08/2021
                    exchNoPost.grdCuerpo[0].PrecioLista = Generalidades.Auxiliares.Redondear(exchVLPP.PrecioLista, eLista.DecimalesPu);
                    exchNoPost.grdCuerpo[0].PrecioForm = Generalidades.Auxiliares.Redondear(exchVLPP.PrecioLista * exch.Principal[0].CambioMonedaOriginal, eLista.DecimalesPu);

                    //exchNoPost.grdCuerpo[0].PrecioLista = Generalidades.Auxiliares.Redondear(exchVLPP.PrecioLista * exch.Principal[0].CambioMonedaOriginal, eLista.DecimalesPu);

                }
                // Emp exchNoPost.grdCuerpo[0].PrecioForm = exchNoPost.grdCuerpo[0].PrecioLista;

                //exchNoPost.grdCuerpo[0].PrecioListaForm = exchNoPost.grdCuerpo[0].PrecioForm;
                // Fin FM //
            }
            return exchNoPost;
        }


        public enum venMovimientosConStockVar
        {
            ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, ManejoDeposito, ManejoCantEntregada, LetraCondFiscal,
            PideCambio, ModificaPrecio, AdmiteBoniRenglon, ModCondPago, ModVendedor, PideObservaciones, ModListaPrecios, PideFechaEntrega,
            PideObsReng, AdmiteFactsinEntr, ManejaLoteoSerie, DepositoDefecto, STMIngresado, PideCentro1, PideCentro2, MuestraDespacho,
            ManejaUbicacion, ModiDeposito, TipoPrecioForm, ModiFecha, PorCotizacion, DigitosLP, UsaCartaPorte, ModiUniMed
        }



        [Generalidades.QFuncion_Condicion]
        public string HabilitaCompAsoc(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {
            if ("DRX".Contains(exch.Principal[0].venTipoMov))
                return "S";
            return "N";

        }


        [Generalidades.QFuncion_Condicion]
        public string Pais(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {
            return cmd.Dominio_Id;
        }



        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesSubTipo(VentasCommon.venMovimientosConStockDS exch,
VentasCommon.venMovimientosConStockDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
  new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);


            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));

            GeneralesExchange.genEmpresasActionExchange exchEmpr = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);


            Dictionary<string, string> lRetorno = new Dictionary<string, string>();

            if (exch.Principal[0].SubTipoMov_Id != "" && exch.Principal[0].Cliente_Id != "")
                lRetorno.Add(venMovimientosConStockVar.STMIngresado.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.STMIngresado.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideCambio)
                lRetorno.Add(venMovimientosConStockVar.PideCambio.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.PideCambio.ToString(), "N");


            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModCondPago)
                lRetorno.Add(venMovimientosConStockVar.ModCondPago.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.ModCondPago.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModVendedor)
                lRetorno.Add(venMovimientosConStockVar.ModVendedor.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.ModVendedor.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.AdmiteBoniRenglon)
                lRetorno.Add(venMovimientosConStockVar.AdmiteBoniRenglon.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.AdmiteBoniRenglon.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideObervaciones)
                lRetorno.Add(venMovimientosConStockVar.PideObservaciones.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.PideObservaciones.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.AdmiteFactsinEntr)
                lRetorno.Add(venMovimientosConStockVar.AdmiteFactsinEntr.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.AdmiteFactsinEntr.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModificaPrecio)
                lRetorno.Add(venMovimientosConStockVar.ModificaPrecio.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.ModificaPrecio.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModListaPrecios)
                lRetorno.Add(venMovimientosConStockVar.ModListaPrecios.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.ModListaPrecios.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideFechaEntrega)
                lRetorno.Add(venMovimientosConStockVar.PideFechaEntrega.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.PideFechaEntrega.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideObsReng)
                lRetorno.Add(venMovimientosConStockVar.PideObsReng.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.PideObsReng.ToString(), "N");

            string lDepo = GeneralesValidacion.genSucursalesEmpr.Existe(GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd).Sucursal, cmd).DepositoVentas;

            lRetorno.Add(venMovimientosConStockVar.DepositoDefecto.ToString(), lDepo);

            if (exchEmpr.Centro1De == "CPR")
                lRetorno.Add(venMovimientosConStockVar.PideCentro1.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.PideCentro1.ToString(), "N");

            if (exchEmpr.Centro2De == "CPR")
                lRetorno.Add(venMovimientosConStockVar.PideCentro2.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.PideCentro2.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModDeposito)
                lRetorno.Add(venMovimientosConStockVar.ModiDeposito.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.ModiDeposito.ToString(), "N");

            if (ExcVenSubTipomov.Existe)
                lRetorno.Add(venMovimientosConStockVar.TipoPrecioForm.ToString(), ExcVenSubTipomov.TipoPrecioForm);
            else
                lRetorno.Add(venMovimientosConStockVar.TipoPrecioForm.ToString(), "");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModFecha)
                lRetorno.Add(venMovimientosConStockVar.ModiFecha.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.ModiFecha.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PorCotizacion)
                lRetorno.Add(venMovimientosConStockVar.PorCotizacion.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.PorCotizacion.ToString(), "N");


            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.UsaCartaPorte)
                lRetorno.Add(venMovimientosConStockVar.UsaCartaPorte.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.UsaCartaPorte.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModiUniMed)
                lRetorno.Add(venMovimientosConStockVar.ModiUniMed.ToString(), "S");
            else
                lRetorno.Add(venMovimientosConStockVar.ModiUniMed.ToString(), "N");

            return lRetorno;
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public String ValidarCFDIR(VentasCommon.venMovimientosConStockDS exch, VentasCommon.venMovimientosConStockDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {

            VentasExchange.venMovimientosConsultaActionExchange exchVMC = new VentasExchange.venMovimientosConsultaActionExchange
                 (VentasExchange.venMovimientosConsultaActionEnum.EnumvenMovimientosConsultaAction.Datos);
            exchVMC.Segmento_Id = exchNoPost.venMovimientosCFDIR[0].Segmento_Id;
            exchVMC.Segmento1N = exchNoPost.venMovimientosCFDIR[0].Segmento1N;
            exchVMC.Segmento2N = exchNoPost.venMovimientosCFDIR[0].Segmento2N;
            exchVMC.Segmento3N = exchNoPost.venMovimientosCFDIR[0].Segmento3N;
            exchVMC.Segmento4N = exchNoPost.venMovimientosCFDIR[0].Segmento4N;
            exchVMC.Segmento1C = exchNoPost.venMovimientosCFDIR[0].Segmento1C;
            exchVMC.Segmento2C = exchNoPost.venMovimientosCFDIR[0].Segmento2C;
            exchVMC.Segmento3C = exchNoPost.venMovimientosCFDIR[0].Segmento3C;
            exchVMC.Segmento4C = exchNoPost.venMovimientosCFDIR[0].Segmento4C;

            exchVMC = new VentasExchange.venMovimientosConsultaActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                (new Framework.Core.Exchange(exchVMC), cmd));
            if (!exchVMC.Existe)
                return "No_existe_el_comprobante";

            // TODO FM Falta validar la lupa de relaciones desde entidades básicas

            return "";

        }

        [Generalidades.QFuncion_AccionGrilla]
        public venMovimientosConStockDS SumarCant(venMovimientosConStockDS exch, venMovimientosConStockDS exchNoPost,
int pIndice, Framework.Core.Command cmd)
        {

            exchNoPost.grdCuerpo[0].CantOriginal = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            exchNoPost.grdCuerpo[0].CantEntregadaForm = exchNoPost.grdCuerpo[0].CantOriginal;
            exchNoPost.AcceptChanges();

            return exchNoPost;

        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValirSerieLote(venMovimientosConStockDS exch, venMovimientosConStockDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {

            StockExchange.stkExistenciaSerieActionExchange exchSerie = new StockExchange.stkExistenciaSerieActionExchange
                (StockExchange.stkExistenciaSerieActionEnum.EnumstkExistenciaSerieAction.Datos);
            exchSerie.Producto_Id = exchNoPost.grdCuerpo[0].Producto_Id;
            exchSerie.Serie = exchNoPost.grdMoviSerie[0].Serie;
            exchSerie.Deposito_Id = exchNoPost.grdCuerpo[0].Deposito_Id;

            exchSerie = new StockExchange.stkExistenciaSerieActionExchange
                (Generalidades.QBIInternal.WrapperExecuteActionInternal(new Framework.Core.Exchange(exchSerie), cmd));

            if (!exchSerie.Existe)
            {
                Recursos.RecursoFE lRec = new Recursos.RecursoFE(GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd).Cultura);
                return lRec.GetString("Serie_Lote_<0>_en_deposito_<1>_no_existe", new object[] { exchNoPost.grdMoviSerie[0].Serie,
                    exchNoPost.grdCuerpo[0].Deposito_Id});
            }
            return "";

        }
        [Generalidades.QFuncion_Condicion]
        public string MostrarBotonIne(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venClieHabitualActionExchange eClie = new VentasExchange.venClieHabitualActionExchange(VentasExchange.venClieHabitualActionEnum.EnumvenClieHabitualAction.Datos);
            eClie.Cliente_Id = exch.Principal[0].Cliente_Id;
            eClie.Sucursal = exch.Principal[0].Sucursal;
            eClie = new VentasExchange.venClieHabitualActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eClie, cmd));
            if (eClie.UsaComplementoINE)
                return ("S");
            return ("N");
        }
        [Generalidades.QFuncion_AccionGrilla]
        public static venMovimientosConStockDS AsignarCantidad(venMovimientosConStockDS exch, venMovimientosConStockDS exchNoPost, int pIndice,
     Framework.Core.Command cmd)
        {


            if (exchNoPost.grdCuerpo[0].CantEntregadaForm == 0)
                return exchNoPost;

            int lSigno = VentasValidacion.venTipomov.Existe(exch.Principal[0].venTipoMov, cmd).Signo;
            if (lSigno == 1)
            {
                exchNoPost.Ubicaciones[0].Cantidad = 0;
                StockExchange.stkExistenciaUbiActionExchange eExistU = new StockExchange.stkExistenciaUbiActionExchange(StockExchange.stkExistenciaUbiActionEnum.EnumstkExistenciaUbiAction.Datos)
                {
                    Deposito_Id = exchNoPost.grdCuerpo[0].Deposito_Id,
                    Producto_Id = exchNoPost.grdCuerpo[0].Producto_Id,
                    Ubicacion_Id = (lSigno == 1 ? exchNoPost.Ubicaciones[0].Ubicacion_Id : exchNoPost.UbicacionesE[0].Ubicacion_Id)
                };
                eExistU = new StockExchange.stkExistenciaUbiActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eExistU, cmd));
                if (eExistU.Existe && eExistU.Cantidad > 0)
                {
                    decimal lCant = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
                    exchNoPost.Ubicaciones[0].Cantidad = Math.Min(exchNoPost.grdCuerpo[0].CantEntregadaForm - lCant, eExistU.Cantidad / exchNoPost.grdCuerpo[0].Factor);
                }
            }
            else
            {
                decimal lCant = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
                exchNoPost.UbicacionesE[0].Cantidad = Math.Max(exchNoPost.grdCuerpo[0].CantEntregadaForm - lCant, 0);
            }

            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        public static venMovimientosConStockDS SumarCantU(venMovimientosConStockDS exch, venMovimientosConStockDS exchNoPost, int pIndice,
     Framework.Core.Command cmd)
        {

            if (VentasValidacion.venTipomov.Existe(exch.Principal[0].venTipoMov, cmd).Signo == 1)
                exchNoPost.grdCuerpo[0].CantEntregadaForm = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
            else
                exchNoPost.grdCuerpo[0].CantEntregadaForm = exchNoPost.UbicacionesE.ToList().Sum(r => r.Cantidad);

            exchNoPost.grdCuerpo[0].CantFacturada = exchNoPost.grdCuerpo[0].CantEntregadaForm;
            exchNoPost.grdCuerpo[0].CantOriginal = exchNoPost.grdCuerpo[0].CantEntregadaForm;
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venMovimientosConStockDS Stock(VentasCommon.venMovimientosConStockDS exch, VentasCommon.venMovimientosConStockDS exchNoPost,
           int pIndice, Framework.Core.Command cmd)
        {
            exch.ConsStock.Clear();



            StockExchange.stkConsStockActionExchange eCons = new StockExchange.stkConsStockActionExchange(StockExchange.stkConsStockActionEnum.EnumstkConsStockAction.Datos)
            {
                Producto_Id = pIndice == -1 ? exchNoPost.grdCuerpo[0].Producto_Id : exch.grdCuerpo[pIndice].Producto_Id,
                Deposito_Id = pIndice == -1 ? exchNoPost.grdCuerpo[0].Deposito_Id : exch.grdCuerpo[pIndice].Deposito_Id
            };
            eCons = new StockExchange.stkConsStockActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eCons, cmd));
            decimal lAcum = 0;
            foreach (var ren in eCons.Param.Cuerpo)
            {
                lAcum += ren.Final;
                ren.Final = lAcum;
            }
            if (pIndice == -1)
            {
                exchNoPost.ConsStock.Merge(eCons.Param.Cuerpo);
                exchNoPost.ConsStock.AcceptChanges();
                return exchNoPost;

            }
            exch.ConsStock.Merge(eCons.Param.Cuerpo);
            exch.ConsStock.AcceptChanges();
            return exch;
        }
        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venMovimientosConStockDS EnTransito(VentasCommon.venMovimientosConStockDS exch, VentasCommon.venMovimientosConStockDS exchNoPost,
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
        public VentasCommon.venMovimientosConStockDS Pedidos(VentasCommon.venMovimientosConStockDS exch, VentasCommon.venMovimientosConStockDS exchNoPost,
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
        public VentasCommon.venMovimientosConStockDS Compras(VentasCommon.venMovimientosConStockDS exch, VentasCommon.venMovimientosConStockDS exchNoPost,
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
        public VentasCommon.venMovimientosConStockDS Embarques(VentasCommon.venMovimientosConStockDS exch, VentasCommon.venMovimientosConStockDS exchNoPost,
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


        [Generalidades.QFuncion_EnviarMail]
        public Generalidades.CorreoDS Enviar(VentasCommon.venMovimientosConStockDS pCommonDS, Framework.Core.Command cmd)
        {
            Generalidades.CorreoDS lRetorno = new Generalidades.CorreoDS();
            VentasExchange.venMovimientosEnviarActionExchange eMov = new VentasExchange.venMovimientosEnviarActionExchange(VentasExchange.venMovimientosEnviarActionEnum.EnumvenMovimientosEnviarAction.Datos)
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
            eMov = new VentasExchange.venMovimientosEnviarActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

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
        public string EnviaFactura(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {

            return (GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd).EnviaFacturas ? "S" : "N");
        }
        [Generalidades.QFuncion_Condicion]
        public string ConfirmarEnviaFactura(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {

            return (GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd).ConfirmarEnviarFacturas ? "S" : "N");
        }

        [Generalidades.QFuncion_Condicion]
        public String NCdeFacDeCred(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venMovimientosConsultaActionExchange exchVMC = new VentasExchange.venMovimientosConsultaActionExchange
     (VentasExchange.venMovimientosConsultaActionEnum.EnumvenMovimientosConsultaAction.Datos);
            exchVMC.Segmento_Id = exch.venComprobAsoc[0].Segmento_Id;
            exchVMC.Segmento1N = exch.venComprobAsoc[0].Segmento1N;
            exchVMC.Segmento2N = exch.venComprobAsoc[0].Segmento2N;
            exchVMC.Segmento3N = exch.venComprobAsoc[0].Segmento3N;
            exchVMC.Segmento4N = exch.venComprobAsoc[0].Segmento4N;
            exchVMC.Segmento1C = exch.venComprobAsoc[0].Segmento1C;
            exchVMC.Segmento2C = exch.venComprobAsoc[0].Segmento2C;
            exchVMC.Segmento3C = exch.venComprobAsoc[0].Segmento3C;
            exchVMC.Segmento4C = exch.venComprobAsoc[0].Segmento4C;

            exchVMC = new VentasExchange.venMovimientosConsultaActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                (new Framework.Core.Exchange(exchVMC), cmd));
            if (!exchVMC.Existe)
                Generalidades.qFunctionalException.GenerarExcepcion("No_existe_el_comprobante");

            // Si estoy haciendo una NC o ND y la factura, ND o NC relacionada es de crédito que pregunte si es por anulación //
            if ((exch.Principal[0].venTipoMov == "R" || exch.Principal[0].venTipoMov == "D") && (exchVMC.venTipoMov == "I" || exchVMC.venTipoMov == "B" || exchVMC.venTipoMov == "E"))
                return "S";


            return "N";

        }

        [Generalidades.QFuncion_AccionGrilla]
        public venMovimientosConStockDS PopularUbi(venMovimientosConStockDS pCommonDS, venMovimientosConStockDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
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

                if (pCommonDS.Ubicaciones.Where(s => s.Renglon == pCommonDSNoPost.grdCuerpo[0].RenglonCuerpo).Count() == 0)
                {
                    // Estoy entrando por primera vez en este renglón así que traigo los datos //


                    pCommonDSNoPost.grdCuerpo[0].CantOriginal = 0;
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
                    s.Renglon = pCommonDSNoPost.grdCuerpo[0].RenglonCuerpo;
                    s.Existencia = s.Existencia - (from ubi in pCommonDS.Ubicaciones
                                                   join pro in pCommonDS.grdCuerpo on ubi.Renglon equals pro.RenglonCuerpo
                                                   where pro.Producto_Id == pCommonDSNoPost.grdCuerpo[0].Producto_Id &&
                                                   ubi.Ubicacion_Id == s.Ubicacion_Id && ubi.Renglon != pCommonDSNoPost.grdCuerpo[0].RenglonCuerpo
                                                   select new { ubi.Cantidad, pro.Factor }).Sum(y => y.Cantidad / y.Factor);

                    s.ExistenciaAlterna -= (from ubi in pCommonDS.Ubicaciones
                                            join pro in pCommonDS.grdCuerpo on ubi.Renglon equals pro.RenglonCuerpo
                                            where pro.Producto_Id == pCommonDSNoPost.grdCuerpo[0].Producto_Id &&
                                            ubi.Ubicacion_Id == s.Ubicacion_Id && ubi.Renglon != pCommonDSNoPost.grdCuerpo[0].RenglonCuerpo
                                            select new { ubi.CantidadAlterna }).Sum(y => y.CantidadAlterna);

                }
                );
            }

            return pCommonDSNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public venMovimientosConStockDS PopularSerie(venMovimientosConStockDS pCommonDS, venMovimientosConStockDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            if (pCommonDS.Principal[0].Segmento1N == 0)
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

                if (pCommonDS.grdMoviSerie.Where(s => s.Renglon == pCommonDSNoPost.grdCuerpo[0].RenglonCuerpo).Count() == 0)
                {
                    // Estoy entrando por primera vez en este renglón así que traigo los datos //

                    pCommonDSNoPost.grdCuerpo[0].CantOriginal = 0;
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
                        pCommonDSNoPost.grdMoviSerie.AddgrdMoviSerieRow(0, pCommonDSNoPost.grdCuerpo[0].RenglonCuerpo, e.Serie, 0, e.Vencimiento, e.Ubicacion_Id, e.Existencia, false);
                    }

                    else
                        pCommonDSNoPost.grdMoviSerie.Where(s => s.Serie == e.Serie).First().Existencia = e.Existencia;
                });

                // Borro los que no tienen existencia //
                pCommonDSNoPost.grdMoviSerie.ToList().ForEach(s =>
                {
                    // Resto las series que ya se pudieron haber usado de este producto en otro renglón //
                    s.Renglon = pCommonDSNoPost.grdCuerpo[0].RenglonCuerpo;

                    s.Existencia -= (from ser in pCommonDS.grdMoviSerie
                                     join pro in pCommonDS.grdCuerpo on ser.Renglon equals pro.RenglonCuerpo
                                     where pro.Producto_Id == pCommonDSNoPost.grdCuerpo[0].Producto_Id && ser.Ubicacion_Id == s.Ubicacion_Id && ser.Renglon != pCommonDSNoPost.grdCuerpo[0].RenglonCuerpo && ser.Serie == s.Serie
                                     select ser).Sum(y => y.Marcado ? 1 : 0);

                    s.Cantidad = !s.Marcado ? 0 : 1;

                    if (s.Existencia <= 0)
                        s.Delete();
                }
                );

                pCommonDSNoPost.grdMoviSerie.AcceptChanges();
                // Le paso el renglón de la grilla principal //
                pCommonDSNoPost.grdMoviSerie.ToList().ForEach(s => s.Renglon = pCommonDSNoPost.grdCuerpo[0].RenglonCuerpo);
            }

            return pCommonDSNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public venMovimientosConStockDS PopularLote(venMovimientosConStockDS pCommonDS, venMovimientosConStockDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            if (pCommonDS.Principal[0].Segmento1N == 0)
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

                if (pCommonDS.grdMoviSerie.Where(s => s.Renglon == pCommonDSNoPost.grdCuerpo[0].RenglonCuerpo).Count() == 0)
                {
                    // Estoy entrando por primera vez en este renglón así que traigo los datos //


                    pCommonDSNoPost.grdCuerpo[0].CantOriginal = 0;
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
                    s.Renglon = pCommonDSNoPost.grdCuerpo[0].RenglonCuerpo;
                    s.Existencia -= (from ser in pCommonDS.grdMoviSerie
                                     join pro in pCommonDS.grdCuerpo on ser.Renglon equals pro.RenglonCuerpo
                                     where pro.Producto_Id == pCommonDSNoPost.grdCuerpo[0].Producto_Id &&
                                     ser.Ubicacion_Id == s.Ubicacion_Id && ser.Renglon != pCommonDSNoPost.grdCuerpo[0].RenglonCuerpo && ser.Ubicacion_Id == s.Ubicacion_Id
                                     select new { ser.Cantidad, pro.Factor }).Sum(y => y.Cantidad / y.Factor);
                }
                );
            }

            return pCommonDSNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public venMovimientosConStockDS SumarCantSerie(venMovimientosConStockDS exch, venMovimientosConStockDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            exchNoPost.grdCuerpo[0].CantOriginal = exchNoPost.grdMoviSerie.ToList().Sum(r => !r.Marcado ? 0 : 1);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public venMovimientosConStockDS SumarCantLote(venMovimientosConStockDS exch, venMovimientosConStockDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            exchNoPost.grdCuerpo[0].CantOriginal = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }
    }
}