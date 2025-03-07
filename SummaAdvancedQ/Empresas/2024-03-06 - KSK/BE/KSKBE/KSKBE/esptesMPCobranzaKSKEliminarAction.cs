using Framework.Core;
using KSKBE.MP;
using System;
using System.ServiceModel;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase esptesMPCobranzaKSKEliminarAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "esptesMPCobranzaKSKEliminarAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase esptesMPCobranzaKSKEliminarAction. No olvide de dar de
    /// alta la acción "esptesMPCobranzaKSKEliminarAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class esptesMPCobranzaKSKEliminarAction : Framework.Core.IAction
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
            KSKExchange.esptesMPCobranzaKSKActionExchange req = new KSKExchange.esptesMPCobranzaKSKActionExchange(exch);

     
            try
            {
                
                GenerarOrden MpOrden = new GenerarOrden(req.Param.Principal[0].external_reference, "SUC001", "POS001");
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
