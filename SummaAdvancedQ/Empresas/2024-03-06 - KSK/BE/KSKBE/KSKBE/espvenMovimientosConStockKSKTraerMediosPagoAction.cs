using Framework.Core;
using System;
using System.Linq;
using System.ServiceModel;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase espvenMovimientosConStockKSKTraerMediosPagoAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "espvenMovimientosConStockKSKTraerMediosPagoAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase espvenMovimientosConStockKSKTraerMediosPagoAction. No olvide de dar de
    /// alta la acción "espvenMovimientosConStockKSKTraerMediosPagoAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espvenMovimientosConStockKSKTraerMediosPagoAction : Framework.Core.IAction
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
            //KSKExchange.espvenMovimientosConStockKSKActionExchange res = new KSKExchange.espvenMovimientosConStockKSKActionExchange();
            try
            {

                KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
                ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);

                if (ds.Identificadores.Count() == 0)
                {
                    // La primera vez paso el total de la factura al primer identificador de efectivo //
                    TesoreriaExchange.tesIdentificaPVActionExchange exchMediosPago = new TesoreriaExchange.tesIdentificaPVActionExchange(TesoreriaExchange.tesIdentificaPVActionEnum.EnumtesIdentificaPVAction.TraerMediosPago)
                    {
                        Existe = false
                    };

                    exchMediosPago = new TesoreriaExchange.tesIdentificaPVActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchMediosPago, cmd));
                    ds.Identificadores.Merge(exchMediosPago.Param.Principal, false, System.Data.MissingSchemaAction.Ignore);

                    //bool lYaAsigne = false;
                    //ds.Identificadores.ToList().ForEach(i =>
                    //{
                    //    if (i.TipoCartera == "EF" && !lYaAsigne)
                    //    {
                    //        i.Importe = req.Importe;
                    //        lYaAsigne = true;
                    //    }
                    //});
                    ds.Principal[0].ImporteAAsignar = req.Importe;
                    ds.Principal[0].ImporteAsignado = 0;
                    ds.Principal[0].Total = req.Importe;
                    ds.Principal[0].Resto = req.Importe;
                }

                Generalidades.Especializacion.UnirDatatSets(req.Param, ds);


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
