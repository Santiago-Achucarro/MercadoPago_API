using System;
using Framework.Core;
using KSKExchange;
using System.ServiceModel;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase venMovimientosConStockDevolverDatosAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "venMovimientosConStockDevolverDatosAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase venMovimientosConStockDevolverDatosAction. No olvide de dar de
    /// alta la acción "venMovimientosConStockDevolverDatosAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class venMovimientosConStockDevolverDatosAction : Framework.Core.IAction
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
            VentasExchange.venMovimientosConStockActionExchange req = new VentasExchange.venMovimientosConStockActionExchange(exch);
            VentasExchange.venMovimientosConStockActionExchange res = new VentasExchange.venMovimientosConStockActionExchange();
            try
            {
                VentasBE.venMovimientosConStockDevolverDatosAction IAction =
                       new VentasBE.venMovimientosConStockDevolverDatosAction();
                res = new VentasExchange.venMovimientosConStockActionExchange(IAction.Execute(cmd, req));
                // ahora busco como se pago
                KSKCommon.venMovimientosConStockDS lCobDs = new KSKCommon.venMovimientosConStockDS();
                if (cmd.CommonDSEsp != null)
                {
                    lCobDs.Merge(cmd.CommonDSEsp, true);
                    GeneralesExchange.genCancMovActionExchange eCanc = new GeneralesExchange.genCancMovActionExchange(GeneralesExchange.genCancMovActionEnum.EnumgenCancMovAction.Datos)
                    {
                        Asiento_Id = res.venMovimientos,
                        CuotaNro = 0,
                        Asiento_Id_Ap = 0,
                        CuotaNro_Ap = 0
                    };
                    eCanc = new GeneralesExchange.genCancMovActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eCanc, cmd));
                    foreach (var ren in eCanc.Param.Cuerpo)
                    {
                        if (ren.Segmento_ap == "TES")
                        {
                            TesoreriaExchange.tesCobranzasActionExchange eCobra =
                                    new TesoreriaExchange.tesCobranzasActionExchange(TesoreriaExchange.tesCobranzasActionEnum.EnumtesCobranzasAction.Datos)
                                    {
                                        Segmento_Id = ren.Segmento_ap,
                                        Segmento1N = ren.Segmento1N_ap,
                                        Segmento2N = ren.Segmento2N_ap,
                                        Segmento3N = ren.Segmento3N_ap,
                                        Segmento4N = ren.Segmento4N_ap,
                                        Segmento1C = ren.Segmento1C_ap,
                                        Segmento2C = ren.Segmento2C_ap,
                                        Segmento3C = ren.Segmento3C_ap,
                                        Segmento4C = ren.Segmento4C_ap,
                                        Empresa_Id = cmd.Empresa_Id
                                    };
                            eCobra = new TesoreriaExchange.tesCobranzasActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eCobra, cmd));



                        }
                    }

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
