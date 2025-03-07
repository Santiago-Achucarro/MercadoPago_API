using Framework.Core;
using System;
using System.Data;
using System.ServiceModel;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase espvenClieHabitualKSKGuardarAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "espvenClieHabitualKSKGuardarAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase espvenClieHabitualKSKGuardarAction. No olvide de dar de
    /// alta la acción "espvenClieHabitualKSKGuardarAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espvenClieHabitualKSKGuardarAction : Framework.Core.IAction
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

            //Gustavo 13/05/2023
            VentasExchange.venClieHabitualActionExchange req = new VentasExchange.venClieHabitualActionExchange(exch);
            VentasExchange.venClieHabitualActionExchange res = new VentasExchange.venClieHabitualActionExchange();
            try
            {

                //instancio el dataset especial
                KSKCommon.espvenClieHabitualKSKDS ds = new KSKCommon.espvenClieHabitualKSKDS();
                //lleno el dataSet especial con los datos de la pantalla (ver diferencia con el de DatosAction que los datos se llenan desde el DAL
                ds.Merge(cmd.CommonDSEsp, false, MissingSchemaAction.Ignore);

                /////// Lo que sigue no trae el identity del vencliehabitual, es decir el genEntidades y da error al guardar
                ///
                /// 
                ////ahora le asigno la accion, en este caso el Guardar del VenClieHabitual
                //req.Action = VentasExchange.venClieHabitualActionEnum.GetAccionvenClieHabitualAction(VentasExchange.venClieHabitualActionEnum.EnumvenClieHabitualAction.Guardar);


                ////ahora corre la accion (esto es siempre lo mismo), corro la accion del guardar estandar
                //Generalidades.QBIInternal.WrapperExecuteActionInternal(req, cmd);

                ////una vez que guardamos el estandar ahora nos ocupamos de la tabla hija
                ////llamo al DAL para que guarde la tabla especial
                ////los datos de la tabla hija se encuentran en el dataset ds que se creo mas arriba y los datos padrE (PK) en req.

                //KSKDAL.espvenClieHabitualKSK.Guardar(req.genEntidades, req.Sucursal, ds.Principal[0].Celular
                //    , ds.Principal[0].Mes, ds.Principal[0].Anio, ds.Principal[0].Instagram, ds.Principal[0].Youtube, ds.Principal[0].Linkedin
                //    , ds.Principal[0].Facebook, cmd.ConnectionString);
                //
                //return new Exchange(req);


                VentasBE.venClieHabitualGuardarAction action = new VentasBE.venClieHabitualGuardarAction();
                res = new VentasExchange.venClieHabitualActionExchange(action.Execute(cmd, req));

                KSKDAL.espvenClieHabitualKSK.Guardar(res.genEntidades, res.Sucursal, ds.Principal[0].Celular
                    , ds.Principal[0].Mes, ds.Principal[0].Dia, ds.Principal[0].Instagram, ds.Principal[0].Youtube, ds.Principal[0].Linkedin
                    , ds.Principal[0].Facebook, cmd.ConnectionString);


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
