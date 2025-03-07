using System;
using Framework.Core;
using KSKExchange;
using System.ServiceModel;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase venMovimientosConStockValoresDefectoAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "venMovimientosConStockValoresDefectoAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase venMovimientosConStockValoresDefectoAction. No olvide de dar de
    /// alta la acción "venMovimientosConStockValoresDefectoAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class venMovimientosConStockValoresDefectoAction : Framework.Core.IAction
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
            VentasExchange.venMovimientosConStockActionExchange req = new VentasExchange.venMovimientosConStockActionExchange(exch);
            
            try
            {

                KSKExchange.espConfPtoVtaKSKActionExchange eValores = new espConfPtoVtaKSKActionExchange(espConfPtoVtaKSKActionEnum.EnumespConfPtoVtaKSKAction.Datos)
                {

                    Empresa_Id = cmd.Empresa_Id
                };
                eValores = new espConfPtoVtaKSKActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eValores, cmd));
                if (eValores.Existe)
                {

                    KSKCommon.venMovimientosConStockDS lCobDs = new KSKCommon.venMovimientosConStockDS();
                    lCobDs.Merge(cmd.CommonDSEsp, true);

                    lCobDs.Principal[0].Efectivo = 0;
                    lCobDs.Principal[0].Credito = 0;
                    lCobDs.Principal[0].Debito = 0;
                    lCobDs.Principal[0].Transferencia = 0;
                    lCobDs.Principal[0].Cheque = 0;
                    
                    req.SubTipoMov_Id = eValores.SubTipoMov_Id;
                    req.DescripcionSubTipoMov = eValores.DescripcionSubTipoMov;
                    req.venMovimientos = 0;
                    req.Moneda_Id = cmd.MonedaBase;

                    if (lCobDs.CodigoBarra.Rows.Count == 0)
                        lCobDs.CodigoBarra.AddCodigoBarraRow("");

                    Generalidades.Especializacion.UnirDatatSets(req.Param, lCobDs);
                    req.Existe = true;
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
