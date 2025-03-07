using Framework.Core;
using System;
using System.ServiceModel;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase espvenClieHabitualKSKDevolverDatosAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "espvenClieHabitualKSKDevolverDatosAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase espvenClieHabitualKSKDevolverDatosAction. No olvide de dar de
    /// alta la acción "espvenClieHabitualKSKDevolverDatosAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espvenClieHabitualKSKDevolverDatosAction : Framework.Core.IAction
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
            //VentasExchange.venClieHabitualActionExchange res = new VentasExchange.venClieHabitualActionExchange();
            try
            {
                //le digo cual es el Action que tiene que ejecutar, en este caso el Datos Standard (es decir, de la tabla original en este caso vencliahabitual)
                req.Action = VentasExchange.venClieHabitualActionEnum.GetAccionvenClieHabitualAction(VentasExchange.venClieHabitualActionEnum.EnumvenClieHabitualAction.Datos);
                // aca se corre la accion, en este caso Datos
                req = new VentasExchange.venClieHabitualActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(req, cmd));


                //una vez que tengo los datos de la tabla estandar ahora voy a buscar los datos especiales creo una isntancia del DS que se creo desde el Helper
                //y llamo al DAL que tambien se creo desde el Helper para que traiga los datos de la base de datos de la tabla Auxiliar
                //le tenemos que pasar las pk que requiere el SP en este caso Clinte_Id y Sucursal
                KSKCommon.espvenClieHabitualKSKDS ds = KSKDAL.espvenClieHabitualKSK.Datos(req.genEntidades, req.Sucursal, cmd.ConnectionString);
                ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);

                //uno el dataset estandar y el especial, compara tabla por tabla y agrega los campis distintos
                //el DataSet Estandar se encuentra en req.Param y el DataSet auxiliar lo creamos arriba y se llama DS
                Generalidades.Especializacion.UnirDatatSets(req.Param, ds);



                //Este que se supone que es un refresh, se puede llamar como no, no estaba, lo agregue porque Alegandro lo agrego en la clase que nos dio
                req.Param.AcceptChanges();

                //finalmente se devuelve el dato
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
