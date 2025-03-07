using System;
using Framework.Core;
using KSKExchange;
using System.ServiceModel;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase espvenClieContactoKSKGuardarAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "espvenClieContactoKSKGuardarAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase espvenClieContactoKSKGuardarAction. No olvide de dar de
    /// alta la acción "espvenClieContactoKSKGuardarAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espvenClieContactoKSKGuardarAction : Framework.Core.IAction
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
            VentasExchange.venClieHabitualActionExchange req = new VentasExchange.venClieHabitualActionExchange(exch);
            VentasExchange.venClieHabitualActionExchange res = new VentasExchange.venClieHabitualActionExchange();
            try
            {
                KSKCommon.espvenClieContactoKSKDS ds = new KSKCommon.espvenClieContactoKSKDS();
                ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);

                VentasBE.venClieHabitualGuardarAction action = new VentasBE.venClieHabitualGuardarAction();

                res = new VentasExchange.venClieHabitualActionExchange(action.Execute(cmd, req));
                int nroContacto = 1;

                for (int i = 0; i < ds.grdContactos.Count; i++)
                {
                    KSKDAL.espvenClieContactoKSK.Guardar(res.genEntidades, res.Sucursal, nroContacto++,
                        ds.grdContactos[i].Instragram,ds.grdContactos[i].Facebook, ds.grdContactos[i].Linkedin, ds.grdContactos[i].Youtube, cmd.ConnectionString);
                }

                return new Exchange(res);
            }
            catch (FaultException<QuestionFault> ex)
            {
                throw ex;
            }
            catch (FaultException<FunctionalFault> ex)           {
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