using System;   
using Framework.Core;
using KSKExchange;
using System.ServiceModel;
using System.Linq;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase venMovimientosConStockGuardarAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "venMovimientosConStockGuardarAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase venMovimientosConStockGuardarAction. No olvide de dar de
    /// alta la acción "venMovimientosConStockGuardarAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class venMovimientosConStockGuardarAction : Framework.Core.IAction
    {
        /// <summary>
        /// Ejecuta la acción, utilizando el Command y el <c>Exchange</c> 
        /// (especializado para la acción que se está desarrollando)
        /// como parámetros, y opcionalmente devolviendo el resultado en
        /// <c>Response</c>.
        ///
        /// </summary>
        /// <param name="cmd">El comando con la información de contexto y
        /// parámetros necesarios para llevar a cabo la acción</param>
        /// <param name="exch">El request especializado para la acción actual
        /// según se describió en el "Asistente de Acciones".</param>

        public Exchange Execute(Command cmd, Exchange exch)
        {
            string lCausa = "";
            VentasExchange.venMovimientosConStockActionExchange req = new VentasExchange.venMovimientosConStockActionExchange(exch);
            VentasExchange.venMovimientosConStockActionExchange res = new VentasExchange.venMovimientosConStockActionExchange();
            try
            {
                KSKCommon.venMovimientosConStockDS lCobDs = new KSKCommon.venMovimientosConStockDS();
                KSKExchange.espConfPtoVtaKSKActionExchange eConfig = new espConfPtoVtaKSKActionExchange(espConfPtoVtaKSKActionEnum.EnumespConfPtoVtaKSKAction.Datos)
                {
                    Empresa_Id = cmd.Empresa_Id
                };
                eConfig = new espConfPtoVtaKSKActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eConfig, cmd));
                if (cmd.CommonDSEsp != null)
                {
                    if (!eConfig.Existe)
                        Generalidades.qFunctionalException.GenerarExcepcion("Debe_Configurar_Los_Medios_de_Pago");


                    lCobDs.Merge(cmd.CommonDSEsp, true);
                    if (lCobDs.Principal[0].ACredito)
                    {
                        // VALIDO QUE SI PUEDA
                        var eCond =
                        VentasValidacion.venCondPago.ExistePosteadoyActivo(req.CondPagoCli_Id, cmd);
                        if (eCond.Dias == 0)
                            Generalidades.qFunctionalException.GenerarExcepcion("Este_Cliente_No_Permite_Venta_a_Credito");

                        // VALIDAR LIMITE DE CREDITO

                        VentasExchange.venVeriCreditoActionExchange exchVeriC =
                        new VentasExchange.venVeriCreditoActionExchange(VentasExchange.venVeriCreditoActionEnum.EnumvenVeriCreditoAction.Calcular);


                        exchVeriC.Cliente_Id = req.Cliente_Id;
                        exchVeriC.ImporteASumar = req.Importe;
                        exchVeriC = new VentasExchange.venVeriCreditoActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchVeriC, cmd));
                        foreach (var ren in exchVeriC.Param.Motivos)
                        {
                            lCausa += "Problemas Credito" + ren.Motivo + "\n";
                        }


                    }
                    else
                    {
                        decimal lTotal = lCobDs.Principal[0].Efectivo + lCobDs.Principal[0].Cheque +
                            lCobDs.Principal[0].Transferencia + lCobDs.Principal[0].Credito + lCobDs.Principal[0].Debito;

                        if (Generalidades.Auxiliares.Redondear(req.Importe * req.Cambio, 2) != lTotal)
                        {
                            Generalidades.qFunctionalException.GenerarExcepcion("El_Monto_a_Cobrar_debe_ser_<0>_y_No_<1>",
                                    new object[] { Generalidades.Auxiliares.Redondear(req.Importe * req.Cambio, 2), lTotal });
                        }
                    }
                    // VALIDAR DESCUENTOS 



                    if (req.Dato1 != 0 || req.Dato2 != 0 || req.Dato3 != 0)
                    {
                        lCausa = "Descuento Extra " + req.Dato1.ToString() + "%+" + req.Dato2.ToString() + "%+ " + req.Dato3.ToString() + "%\n";
                    }
                    foreach (var ren in req.Param.grdCuerpo)
                    {

                        if (ren.Bonificacion != 0)
                        {
                            lCausa += "Descuento En Renglon Producto " + ren.Producto_Id + " " + ren.DescripcionProductos + " " +
                                    ren.Bonificacion.ToString() + "%\n";
                        }
                        if (ren.PrecioForm != ren.PrecioLista)
                        {
                            lCausa += "Cambio de Precio " + ren.Producto_Id + " " + ren.DescripcionProductos + " de " +
                                        ren.PrecioLista.ToString() + " a " + ren.PrecioForm.ToString() + "\n";
                        }

                    }

                    if (lCausa != "")
                    {

                        req.Posteado = false;
                    }
                }

                /*
                // AVERIGUO SI HAY DE OTRA EMPRESA
                var eUsu = GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd);
                var eSucursal =
                GeneralesValidacion.genSucursalesEmpr.ExistePosteadoyActiva(eUsu.Sucursal, cmd);

                KSKExchange.KSKTraspasoICActionExchange eTraspaso = new KSKTraspasoICActionExchange(KSKTraspasoICActionEnum.EnumKSKTraspasoICAction.Guardar)
                {
                    Fecha = req.Fecha,
                    DepoDestino = eSucursal.DepositoVentas

                };

                var Depos = req.Param.grdCuerpo.GroupBy(c => c.Deposito_Id, (key, g) => new { Deposito_Id = key });

                foreach (var ren in Depos)
                {

                    StockExchange.stkDepositosActionExchange eDepo = new StockExchange.stkDepositosActionExchange(StockExchange.stkDepositosActionEnum.EnumstkDepositosAction.Datos)
                    {

                        Deposito_Id = ren.Deposito_Id
                    };
                    eDepo = new StockExchange.stkDepositosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eDepo, cmd));
                    if (!eDepo.Existe)
                        Generalidades.qFunctionalException.GenerarExcepcion("El_Deposito_<0>_No_Existe", new object[] { ren.Deposito_Id });
                    if (!eDepo.PTodasEmpresas && !(eDepo.Empresa_Id == cmd.Empresa_Id))
                    {
                        foreach (var ren1 in req.Param.grdCuerpo.Where(c => c.Deposito_Id == ren.Deposito_Id))
                        {
                            // debo traspasar
                            eTraspaso.Param.Cuerpo.AddCuerpoRow(ren.Deposito_Id, eDepo.Empresa_Id, ren1.Producto_Id, ren1.CantEntregada, ren1.Medida_Id);
                            ren1.Observaciones = ren1.Observaciones + " Sale de " + ren1.Deposito_Id;
                            ren1.Deposito_Id = eSucursal.DepositoVentas;

                        }
                    }

                }
                // LAMO AL QUE GENERA LOS TRASPASOS
                if (eTraspaso.Param.Cuerpo.Count > 0)
                {
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(eTraspaso, cmd);
                }
                */

                // LAMO AL PADRE

                bool lTieneEspecial = cmd.CommonDSEsp != null;
                VentasBE.venMovimientosConStockGuardarAction IAction = new VentasBE.venMovimientosConStockGuardarAction();
                req.LlamarAlWSFE = false;
                
                res = new VentasExchange.venMovimientosConStockActionExchange(IAction.Execute(cmd, req));
                Int64 lTesMovimientos = 0;
                if (lTieneEspecial)
                {
                    if (lCobDs.Principal[0].Cantidad > 0)
                    {

                        if (res.SubTotalBonif !=
                                Generalidades.Auxiliares.Redondear(lCobDs.Principal[0].Cantidad * lCobDs.Principal[0].ValorUnitario, 2))
                            Generalidades.qFunctionalException.GenerarExcepcion("El_Monto_Resumido_Debe_Ser_<0>_y_No_<1>",
                                    new object[] { res.SubTotalBonif, Generalidades.Auxiliares.Redondear(lCobDs.Principal[0].Cantidad * lCobDs.Principal[0].ValorUnitario, 2) });

                        StockValidacion.stkUniMed.ExistePosteadoyActivo(lCobDs.Principal[0].Medida_Id, cmd);
                        GeneralesValidacion.genEntidadesBasicasValor.Existe(3, cmd.Dominio_Id,
                                lCobDs.Principal[0].ClaveFiscal, cmd);

                        KSKDAL.venMovimientosResu.Guardar(res.venMovimientos,
                            lCobDs.Principal[0].Cantidad, lCobDs.Principal[0].Medida_Id,
                            lCobDs.Principal[0].Leyenda, lCobDs.Principal[0].ValorUnitario,
                            lCobDs.Principal[0].ClaveFiscal, cmd.ConnectionString);
                    }
                    if (!lCobDs.Principal[0].ACredito)
                    {
                        // Guardo la Cobranza
                        TesoreriaExchange.tesCobranzasActionExchange eCobra = new TesoreriaExchange.tesCobranzasActionExchange(TesoreriaExchange.tesCobranzasActionEnum.EnumtesCobranzasAction.Guardar);

                        eCobra.Param.Principal.AddPrincipalRow(cmd.Empresa_Id, "TES", 0, 0, 0, 0, "", "", "", "", 0, "I", req.Fecha,
                            DateTime.Now, req.Moneda_Id, "", req.Cambio, 1, false, "", req.Posteado, cmd.Formulario, "", "COB", "",
                                req.Fecha, req.Cliente_Id, "", "", "", Generalidades.Auxiliares.Redondear(req.Importe * req.Cambio, 2),
                                Generalidades.Auxiliares.Redondear(req.Importe * req.Cambio, 2), Generalidades.Auxiliares.Redondear(req.Importe * req.Cambio, 2),
                                false, req.Importe, req.Importe, "", false);
                        eCobra.Param.Principal[0].Delete();


                        int nReng = 1;
                        if (lCobDs.Principal[0].Efectivo != 0)
                        {
                            if (String.IsNullOrWhiteSpace(eConfig.Efectivo))
                                Generalidades.qFunctionalException.GenerarExcepcion("Debe_Configurar_Efectivo");

                            decimal lImporte = lCobDs.Principal[0].Efectivo;
                            var eCartera = TesoreriaValidacion.tesIdentifica.ExistePosteadoyActivo(eConfig.Efectivo, cmd);

                            eCobra.Param.Debe.AddDebeRow(0, nReng++, eCartera.Cartera_Id, "", lImporte, lImporte, 1, cmd.MonedaBase, "",
                                                    eCartera.Cuenta_Id, "", eCartera.Centro1_Id, "", eCartera.Centro2_Id, "", 1, "TRM", eCartera.TipoCartera,
                                                    0, 0, 0, "", "", 0, 0, 0, Generalidades.Nulls.NullDate, "", "", "", "", "", "", 0, "", "", "", "", 0,
                                                    Generalidades.Nulls.NullDate, "", "", 0, "", "", "", "", 0,
                                                    Generalidades.Nulls.NullDate, Generalidades.Nulls.NullDate,
                                                    "", "", "", "", "", "", "", "", "", "", "", "", 0, "", false, "", 0, "", 0, "", "", 0, 0, 0, 0, "", "", "", "",
                                                    0, 0, 0, 0, 0, 0, "", 0, "", 0, "", "", "", "", "", "", "", "", "", 0);
                        }


                        if (lCobDs.Principal[0].Cheque != 0)
                        {
                            if (String.IsNullOrWhiteSpace(eConfig.Cheques))
                                Generalidades.qFunctionalException.GenerarExcepcion("Debe_Configurar_Cheques");

                            decimal lImporte = lCobDs.Principal[0].Cheque;
                            var eCartera = TesoreriaValidacion.tesIdentifica.ExistePosteadoyActivo(eConfig.Cheques, cmd);

                            eCobra.Param.Debe.AddDebeRow(0, nReng++, eCartera.Cartera_Id, "", lImporte, lImporte, 1, cmd.MonedaBase, "", eCartera.Cuenta_Id, "", eCartera.Centro1_Id, "", eCartera.Centro2_Id, "", 1, "TRM", eCartera.TipoCartera, 0, 0, 0, "", "", 0, 0, 0, Generalidades.Nulls.NullDate, "", "", "", "", "", "", 0, lCobDs.Principal[0].Banco_Id, "", "48", "", 0, req.Fecha, "", "", lCobDs.Principal[0].NroCheque, "C", req.Cliente_Id, "", "", 0, Generalidades.Nulls.NullDate, Generalidades.Nulls.NullDate, "", "", "", "", "", "", "", "", "", "", "", "", 0, "", false, "", 0, "", 0, "", "", 0, 0, 0, 0, "", "", "", "", 0, 0, 0, 0, 0, 0, "", 0, "", 0, "", "", "", "", "", "", "", "", "", 0);
                        }


                        if (lCobDs.Principal[0].Debito != 0)
                        {
                            if (String.IsNullOrWhiteSpace(eConfig.TDebito))
                                Generalidades.qFunctionalException.GenerarExcepcion("Debe_Configurar_Tarjeta_Debito");

                            decimal lImporte = lCobDs.Principal[0].Debito;
                            var eCartera = TesoreriaValidacion.tesIdentifica.ExistePosteadoyActivo(eConfig.TDebito, cmd);

                            eCobra.Param.Debe.AddDebeRow(0, nReng++, eCartera.Cartera_Id, "", lImporte, lImporte, 1, cmd.MonedaBase, "",
                                                    eCartera.Cuenta_Id, "", eCartera.Centro1_Id, "", eCartera.Centro2_Id, "", 1, "TRM", eCartera.TipoCartera,
                                                    0, 0, 0, "", "", 0, 0, 0, Generalidades.Nulls.NullDate, "", "", "", "", "", "", 0, "", "", "0", "", 0,
                                                    req.Fecha, "", "", 0, "", "", "", "", 0,
                                                    Generalidades.Nulls.NullDate, Generalidades.Nulls.NullDate,
                                                    "", "", "", "", "", "", "", "", "", "", "", "", 0, "", false, "", 0, "", 0, "", "", 0, 0, 0, 0, "", "", "", "",
                                                    0, 0, 0, 0, 0, 0, "", 0, "", 0, "", "", "", "", "", "", "", "", "", 0);
                        }

                        if (lCobDs.Principal[0].Credito != 0)
                        {
                            if (String.IsNullOrWhiteSpace(eConfig.TCredito))
                                Generalidades.qFunctionalException.GenerarExcepcion("Debe_Configurar_Tarjeta_Credito");

                            decimal lImporte = lCobDs.Principal[0].Credito;
                            var eCartera = TesoreriaValidacion.tesIdentifica.ExistePosteadoyActivo(eConfig.TCredito, cmd);

                            eCobra.Param.Debe.AddDebeRow(0, nReng++, eCartera.Cartera_Id, "", lImporte, lImporte, 1, cmd.MonedaBase, "",
                                                    eCartera.Cuenta_Id, "", eCartera.Centro1_Id, "", eCartera.Centro2_Id, "", 1, "TRM", eCartera.TipoCartera,
                                                    0, 0, 0, "", "", 0, 0, 0, Generalidades.Nulls.NullDate, "", "", "", "", "", "", 0, "", "", "0", "", 0,
                                                    req.Fecha, "", "", 0, "", "", "", "", 0,
                                                    Generalidades.Nulls.NullDate, Generalidades.Nulls.NullDate,
                                                    "", "", "", "", "", "", "", "", "", "", "", "", 0, "", false, "", 0, "", 0, "", "", 0, 0, 0, 0, "", "", "", "",
                                                    0, 0, 0, 0, 0, 0, "", 0, "", 0, "", "", "", "", "", "", "", "", "", 0);
                        }


                        if (lCobDs.Principal[0].Transferencia != 0)
                        {

                            decimal lImporte = lCobDs.Principal[0].Transferencia;
                            var eCartera = TesoreriaValidacion.tesIdentifica.ExistePosteadoyActivo(lCobDs.Principal[0].Cartera_Id, cmd);

                            eCobra.Param.Debe.AddDebeRow(0, nReng++, eCartera.Cartera_Id, "", lImporte, lImporte, 1, cmd.MonedaBase, "",
                                                    eCartera.Cuenta_Id, "", eCartera.Centro1_Id, "", eCartera.Centro2_Id, "", 1, "TRM", eCartera.TipoCartera,
                                                    0, 0, 0, "", "", 0, 0, 0, Generalidades.Nulls.NullDate, "", "", "", "", "", "", 0, "", "", "0", "", 0,
                                                    req.Fecha, "", "", 0, "", "", "", "", 0,
                                                    Generalidades.Nulls.NullDate, Generalidades.Nulls.NullDate,
                                                    "", "", "", "", "", "", "", "", "", "", "", "", 0, "", false, "", 0, "", 0, "", "", 0, 0, 0, 0, "", "", "", "",
                                                    0, 0, 0, 0, 0, 0, "", 0, "", 0,
                                                    req.Param.venMovMetodoPago[0].MetodoPago, "", "", "", "", "", "", "", "", 0);
                        }

                        eCobra.Param.FactClientes.AddFactClientesRow("", req.Fecha, req.Moneda_Id, "",
                                req.Cambio, req.Importe, req.Importe, req.Importe, res.venMovimientos, res.CtaClientes,
                                    req.Importe, req.Cambio, 1, true, "");

                        eCobra.Param.AcceptChanges();
                        eCobra = new TesoreriaExchange.tesCobranzasActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eCobra, cmd));
                        lTesMovimientos = eCobra.tesMovimientos;
                    }

                    if (lCausa == "")
                    {
                        lCobDs.Principal[0].Autorizada = "S";
                        // Y TIMBRO
                        res.Action = VentasExchange.venMovimientosConStockActionEnum.GetAccionvenMovimientosConStockAction(VentasExchange.venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.LlamarAlWebServiceFE);

                        res = new VentasExchange.venMovimientosConStockActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(res, cmd));

                    }
                    else
                    {
                        lCobDs.Principal[0].Autorizada = "N";
                        // mado a autorizar 
                        KSKExchange.espParaAutorizarKSKActionExchange eAuto =
                                new espParaAutorizarKSKActionExchange(espParaAutorizarKSKActionEnum.EnumespParaAutorizarKSKAction.Guardar)
                                {

                                    venMovimientos = res.venMovimientos,
                                    tesMovimientos = lTesMovimientos,
                                    Causa = lCausa,
                                    Estado = "P"
                                };
                        Generalidades.QBIInternal.WrapperExecuteActionInternal(eAuto, cmd);
                    }
                    Generalidades.Especializacion.UnirDatatSets(res.Param, lCobDs);
                }
                return new Exchange(res);
            }
            catch (FaultException<QuestionFault> ex)
            {
                throw ex;
            }
            catch (FaultException<FunctionalFault> ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                Generalidades.qTechnicalException.GenerarExcepcion(ex.Message);
                throw new Exception("Error al generar Tecnical Exception");
            }
        }

    }
}
