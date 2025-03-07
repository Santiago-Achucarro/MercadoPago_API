using System;
using Framework.Core;
using KSKExchange;
using System.ServiceModel;
using KSKBE.MP;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase espvenMovimientosConStockKSKMPBorrarOrdenAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "espvenMovimientosConStockKSKMPBorrarOrdenAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase espvenMovimientosConStockKSKMPBorrarOrdenAction. No olvide de dar de
    /// alta la acción "espvenMovimientosConStockKSKMPBorrarOrdenAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espvenMovimientosConStockKSKMPBorrarOrdenAction : Framework.Core.IAction
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
            KSKExchange.espvenMovimientosConStockKSKActionExchange req = new KSKExchange.espvenMovimientosConStockKSKActionExchange(exch);
            //KSKExchange.espvenMovimientosConStockKSKActionExchange res = new KSKExchange.espvenMovimientosConStockKSKActionExchange();
            try
            {

                KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
                ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);
                ds.MercadoPago[0].IdMercadoPago = "1";

                ds.Principal[0].Existe = true;
                Generalidades.Especializacion.UnirDatatSets(req.Param, ds);

                string external_reference = req.Segmento1C + req.Segmento2C + req.Segmento3C + "-" + req.Segmento1N.ToString();
                //GenerarOrden MpOrden = new GenerarOrden(external_reference, "SUC001", "POS001");
                GenerarOrden MpOrden = new GenerarOrden(external_reference, req.SucursalEmpr);
                MpOrden.Borrar();
             

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
