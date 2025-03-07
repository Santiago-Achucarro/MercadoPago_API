using System;
using Framework.Core;
using ImpExchange;
using System.ServiceModel;

namespace ImpBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase espstkColorImpEliminarAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "espstkColorImpEliminarAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase espstkColorImpEliminarAction. No olvide de dar de
    /// alta la acción "espstkColorImpEliminarAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espstkColorImpEliminarAction : Framework.Core.IAction
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
            ImpExchange.espstkColorImpActionExchange req = new ImpExchange.espstkColorImpActionExchange(exch);
            ImpExchange.espstkColorImpActionExchange res = new ImpExchange.espstkColorImpActionExchange();
            try
            {
                if (req.Param.Principal[0].Color_Id == "")
                {
                    Generalidades.qFunctionalException.GenerarExcepcion("El codigo no puedo ser vacio");
                }

                if (req.Param.Principal[0].Descripcion == "")
                {
                    Generalidades.qFunctionalException.GenerarExcepcion("L descripcion no puedo ser vacia");
                }

                ImpDAL.espstkColorImp.Guardar(req.Color_Id, req.Color_Id_Nueva, cmd.Empresa_Id, req.Descripcion, req.Inactivo, cmd.Usuario_Id, req.Posteado, cmd.ConnectionString);

                return new Exchange(res);
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
