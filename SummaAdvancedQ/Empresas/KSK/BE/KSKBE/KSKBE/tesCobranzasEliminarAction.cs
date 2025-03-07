using Framework.Core;
using System;
using System.ServiceModel;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase tesCobranzasEliminarAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "tesCobranzasEliminarAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase tesCobranzasEliminarAction. No olvide de dar de
    /// alta la acción "tesCobranzasEliminarAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class tesCobranzasEliminarAction : Framework.Core.IAction
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
            TesoreriaExchange.tesCobranzasActionExchange req = new TesoreriaExchange.tesCobranzasActionExchange(exch);
            //TesoreriaExchange.tesCobranzasActionExchange res = new TesoreriaExchange.tesCobranzasActionExchange();
            try
            {
                ContabilidadExchange.conAsientosActionExchange eAsi = new ContabilidadExchange.conAsientosActionExchange(ContabilidadExchange.conAsientosActionEnum.EnumconAsientosAction.DatosInt)
                {
                    conAsientos = req.tesMovimientos
                };
                eAsi = new ContabilidadExchange.conAsientosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eAsi, cmd));

                cmd.Formulario = eAsi.Formulario_Id;

                TesoreriaBE.tesCobranzasEliminarAction action = new TesoreriaBE.tesCobranzasEliminarAction();
                req = new TesoreriaExchange.tesCobranzasActionExchange(action.Execute(cmd, req));

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