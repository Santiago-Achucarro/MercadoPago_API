using Framework.Core;
using KSKBE.MP;
using System;
using System.ServiceModel;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase esptesMPCobranzaKSKEscaneoAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "esptesMPCobranzaKSKEscaneoAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase esptesMPCobranzaKSKEscaneoAction. No olvide de dar de
    /// alta la acción "esptesMPCobranzaKSKEscaneoAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class esptesMPCobranzaKSKEscaneoAction : Framework.Core.IAction
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
 
                req.Param.Principal[0].Existe = true;

                GenerarOrden mp = new GenerarOrden(req.Param.Principal[0].external_reference.Substring(1, 4));
                

                //primero creo la orden
                GenerarOrden MpOrden = new GenerarOrden(req.Param.Principal[0].APagar, req.Param.Principal[0].external_reference, mp.mpSucursal, mp.mpCaja);
                if (!MpOrden.Generar().Result)
                {
                    Generalidades.qFunctionalException.GenerarExcepcion($"No se Pudo Gemerar la Orden para Escanear");

                }

                string external_reference = req.Param.Principal[0].external_reference;

                bool escaneado = MpOrden.Escaneo(external_reference).Result;
                if (!escaneado)
                {
                    //IdMercadoPago, tiene que tomar el valor de escaneado y en funcion de ello mostrar carteles apropiados en el formulario
                    Generalidades.qFunctionalException.GenerarExcepcion($"No se detecto escaneo: {MpOrden.Mensaje}");

                }


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
