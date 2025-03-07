using System;
using Framework.Core;
using KSKExchange;
using System.ServiceModel;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase espstkTalleKSKDevolverDatosAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "espstkTalleKSKDevolverDatosAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase espstkTalleKSKDevolverDatosAction. No olvide de dar de
    /// alta la acción "espstkTalleKSKDevolverDatosAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espstkTalleKSKDevolverDatosAction : Framework.Core.IAction
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
            KSKExchange.espstkTalleKSKActionExchange req = new KSKExchange.espstkTalleKSKActionExchange(exch);
            KSKExchange.espstkTalleKSKActionExchange res = new KSKExchange.espstkTalleKSKActionExchange();
            try
            {
                KSKCommon.espstkTalleKSKDS ds = KSKDal.espstkTalleKSK.Datos(req.Talle_Id, cmd.ConnectionString);

                //res.Param = ds;
                res.Param.Merge(ds, false, System.Data.MissingSchemaAction.Ignore);
                res.Param.Principal[0].Delete();
                res.Param.AcceptChanges();
                res.Existe = ds.Principal.Count > 0;

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
