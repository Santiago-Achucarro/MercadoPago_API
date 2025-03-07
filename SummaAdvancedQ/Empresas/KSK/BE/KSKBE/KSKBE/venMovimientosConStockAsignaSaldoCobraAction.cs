using System;
using Framework.Core;
using KSKExchange;
using System.ServiceModel;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase venMovimientosConStockAsignaSaldoCobraAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "venMovimientosConStockAsignaSaldoCobraAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase venMovimientosConStockAsignaSaldoCobraAction. No olvide de dar de
    /// alta la acción "venMovimientosConStockAsignaSaldoCobraAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class venMovimientosConStockAsignaSaldoCobraAction : Framework.Core.IAction
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

            try
            {
                if (cmd.CommonDSEsp != null)
                {
                    KSKCommon.venMovimientosConStockDS lCobDs = new KSKCommon.venMovimientosConStockDS();
                    lCobDs.Merge(cmd.CommonDSEsp, true);

                    if (lCobDs.Principal[0].ACredito)
                    {
                        lCobDs.Principal[0].Efectivo = 0;
                        lCobDs.Principal[0].Credito = 0;
                        lCobDs.Principal[0].Debito = 0;
                        lCobDs.Principal[0].Transferencia = 0;
                        lCobDs.Principal[0].Cheque = 0;
                        req.Param.venMovMetodoPago[0].MetodoPago = "99";
                        req.Param.venMovMetodoPago[0].NMetodoPago = "PPD";


                    }
                    else
                    {
                        lCobDs.Principal[0].Efectivo = Math.Max(req.Importe -
                             lCobDs.Principal[0].Credito - lCobDs.Principal[0].Debito - lCobDs.Principal[0].Transferencia -
                             lCobDs.Principal[0].Cheque, 0M);
                        if (lCobDs.Principal[0].Efectivo > 0)
                            req.Param.venMovMetodoPago[0].MetodoPago = "01";
                        else
                        {
                            if (lCobDs.Principal[0].Cheque > 0)
                                req.Param.venMovMetodoPago[0].MetodoPago = "02";
                            else
                            {
                                if (lCobDs.Principal[0].Transferencia > 0)
                                    req.Param.venMovMetodoPago[0].MetodoPago = "03";
                                else
                                {
                                    if (lCobDs.Principal[0].Debito > 0)
                                        req.Param.venMovMetodoPago[0].MetodoPago = "28";
                                    else
                                    {
                                        if (lCobDs.Principal[0].Credito > 0)
                                            req.Param.venMovMetodoPago[0].MetodoPago = "04";
                                    }
                                }
                            }
                        }
                        req.Param.venMovMetodoPago[0].NMetodoPago = "PUE";
                    }



                    Generalidades.Especializacion.UnirDatatSets(req.Param, lCobDs);
                }
                req.Existe = true;
                return new Exchange(req);
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
