using System;
using Framework.Core;
using KSKExchange;
using System.ServiceModel;
using System.Data;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase espConfPtoVtaGuardarAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "espConfPtoVtaGuardarAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase espConfPtoVtaGuardarAction. No olvide de dar de
    /// alta la acción "espConfPtoVtaGuardarAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espConfPtoVtaKSKGuardarAction : Framework.Core.IAction
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
            KSKExchange.espConfPtoVtaKSKActionExchange req = new KSKExchange.espConfPtoVtaKSKActionExchange(exch);
            try
            {
                if (!String.IsNullOrWhiteSpace(req.SubTipoMov_Id))
                    VentasValidacion.venSubTipoMov.ExistePosteadoyActivo(req.SubTipoMov_Id, cmd);
                if (!String.IsNullOrWhiteSpace(req.Efectivo))
                    TesoreriaValidacion.tesIdentifica.ExistePosteadoyActivo(req.Efectivo, cmd);
                if (!String.IsNullOrWhiteSpace(req.Cheques))
                    TesoreriaValidacion.tesIdentifica.ExistePosteadoyActivo(req.Cheques, cmd);
                if (!String.IsNullOrWhiteSpace(req.TCredito))
                    TesoreriaValidacion.tesIdentifica.ExistePosteadoyActivo(req.TCredito, cmd);
                if (!String.IsNullOrWhiteSpace(req.TDebito))
                    TesoreriaValidacion.tesIdentifica.ExistePosteadoyActivo(req.TDebito, cmd);
                if (!String.IsNullOrWhiteSpace(req.Transferencia))
                    TesoreriaValidacion.tesIdentifica.ExistePosteadoyActivo(req.Transferencia, cmd);

                KSKDAL.espConfPtoVtaKSK.Guardar(cmd.Empresa_Id, req.SubTipoMov_Id, req.Efectivo,
                    req.Cheques, req.TDebito, req.TCredito, req.Transferencia, cmd.ConnectionString);

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
