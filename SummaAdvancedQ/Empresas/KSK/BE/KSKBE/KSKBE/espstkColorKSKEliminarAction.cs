using System;
using Framework.Core;
using KSKExchange;
using System.ServiceModel;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase espstkColorTestEliminarAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "espstkColorTestEliminarAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase espstkColorTestEliminarAction. No olvide de dar de
    /// alta la acción "espstkColorTestEliminarAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espstkColorKSKEliminarAction : Framework.Core.IAction
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
            KSKExchange.espstkColorKSKActionExchange req = new KSKExchange.espstkColorKSKActionExchange(exch);
            KSKExchange.espstkColorKSKActionExchange res = new KSKExchange.espstkColorKSKActionExchange();
            try
            {
                KSKExchange.espstkColorKSKActionExchange exchColor = new espstkColorKSKActionExchange(espstkColorKSKActionEnum.EnumespstkColorKSKAction.Datos);
                exchColor.Color_Id = req.Color_Id;
                exchColor = new espstkColorKSKActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchColor, cmd));
                if(exchColor.Existe)
                {
                    KSKDal.espstkColorKSK.Eliminar(req.Color_Id, cmd.ConnectionString);
                }
                else
                {
                    Generalidades.qFunctionalException.GenerarExcepcion("No existe el codigo a eliminar");
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
