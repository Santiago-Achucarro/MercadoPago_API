using System;
using Framework.Core;
using KSKExchange;
using System.ServiceModel;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase espvenClieContactoKSKDevolverDatosAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "espvenClieContactoKSKDevolverDatosAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase espvenClieContactoKSKDevolverDatosAction. No olvide de dar de
    /// alta la acción "espvenClieContactoKSKDevolverDatosAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espvenClieContactoKSKDevolverDatosAction : Framework.Core.IAction
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
                /*
                VentasExchange.venClieHabitualActionExchange exchClie = new VentasExchange.venClieHabitualActionExchange(VentasExchange.venClieHabitualActionEnum.EnumvenClieHabitualAction.Datos);
                exchClie.Cliente_Id = "A0001";
                exchClie.Sucursal = 1;
                exchClie = new VentasExchange.venClieHabitualActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchClie, cmd));
                */

                //Ale
                KSKCommon.espvenClieContactoKSKDS ds = new KSKCommon.espvenClieContactoKSKDS();
                //KSKCommon.espvenClieContactoKSKDS ds = KSKDAL.espvenClieContactoKSK.Datos(req.genEntidades, req.Sucursal, 1, cmd.ConnectionString);

                ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);

                VentasBE.venClieHabitualDevolverDatosAction action = new VentasBE.venClieHabitualDevolverDatosAction();

                res = new VentasExchange.venClieHabitualActionExchange(action.Execute(cmd, req));

                Generalidades.Especializacion.UnirDatatSets(res.Param, ds);

                return new Exchange(res);
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
