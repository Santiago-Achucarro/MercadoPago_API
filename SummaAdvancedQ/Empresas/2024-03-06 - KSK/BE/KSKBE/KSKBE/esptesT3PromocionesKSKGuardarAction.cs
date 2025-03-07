using Framework.Core;
using System;
using System.Data;
using System.ServiceModel;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase esptesT3PromocionesKSKGuardarAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "esptesT3PromocionesKSKGuardarAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase esptesT3PromocionesKSKGuardarAction. No olvide de dar de
    /// alta la acción "esptesT3PromocionesKSKGuardarAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class esptesT3PromocionesKSKGuardarAction : Framework.Core.IAction
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
            TesoreriaExchange.tesT3PromocionesActionExchange req = new TesoreriaExchange.tesT3PromocionesActionExchange(exch);
            TesoreriaExchange.tesT3PromocionesActionExchange res = new TesoreriaExchange.tesT3PromocionesActionExchange();
            try
            {

                KSKCommon.esptesT3PromocionesKSKDS ds = new KSKCommon.esptesT3PromocionesKSKDS();
                ds.Merge(cmd.CommonDSEsp, false, MissingSchemaAction.Ignore);

                TesoreriaBE.tesT3PromocionesGuardarAction action = new TesoreriaBE.tesT3PromocionesGuardarAction();
                req = new TesoreriaExchange.tesT3PromocionesActionExchange(action.Execute(cmd, req));

                KSKDAL.esptesT3PromocionesKSK.Guardar(req.tesT3Promociones, ds.Principal[0].PorcentajeEntidad, ds.Principal[0].PorcentajeBanco, cmd.ConnectionString);


                return new Exchange(req);
            }
            catch (FaultException<QuestionFault> ex)
            {
                throw ex;
                ;
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
