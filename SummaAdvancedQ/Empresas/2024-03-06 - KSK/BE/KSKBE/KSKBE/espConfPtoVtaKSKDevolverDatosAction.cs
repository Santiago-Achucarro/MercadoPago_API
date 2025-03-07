using System;
using Framework.Core;
using KSKExchange;
using System.ServiceModel;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase KSKConfPtoVtaDevolverDatosAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "KSKConfPtoVtaDevolverDatosAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase KSKConfPtoVtaDevolverDatosAction. No olvide de dar de
    /// alta la acción "KSKConfPtoVtaDevolverDatosAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espConfPtoVtaKSKDevolverDatosAction : Framework.Core.IAction
    {
        /// <summary>
        /// Ejecuta la acción, utilizando el Command y el <c>Exchange</c> 
        /// (KSKecializado para la acción que se está desarrollando)
        /// como parámetros, y opcionalmente devolviendo el resultado en
        /// <c>RKSKonse</c>.
        ///
        /// </summary>
        /// <param name="cmd">El comando con la información de contexto y
        /// parámetros necesarios para llevar a cabo la acción</param>
        /// <param name="exch">El request KSKecializado para la acción actual
        /// según se describió en el "Asistente de Acciones".</param>

        public Exchange Execute(Command cmd, Exchange exch)
        {
            KSKExchange.espConfPtoVtaKSKActionExchange req = new KSKExchange.espConfPtoVtaKSKActionExchange(exch);
            KSKExchange.espConfPtoVtaKSKActionExchange res = new KSKExchange.espConfPtoVtaKSKActionExchange();
            try
            {
                KSKCommon.espConfPtoVtaKSKDS ds = KSKDAL.espConfPtoVtaKSK.Datos(cmd.Empresa_Id, cmd.ConnectionString);
                res.Param.Merge(ds, false, System.Data.MissingSchemaAction.Ignore);
                //borro la primera fila que agrega de m�s al generar res
                res.Param.Principal[0].Delete();
                res.Existe = (ds.Principal.Count > 0);
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
