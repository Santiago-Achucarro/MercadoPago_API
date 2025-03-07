using System;
using Framework.Core;
using VentasExchange;
using System.ServiceModel;
using System.Linq;
using Generalidades;
using VentasCommon;

namespace KSKBE
{
    public class venMovimientosConStockCalcularTotalesAction : Framework.Core.IAction
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

                KSKCommon.venMovimientosConStockDS lResEsp = new KSKCommon.venMovimientosConStockDS();
                if (cmd.CommonDSEsp != null)
                    lResEsp.Merge(cmd.CommonDSEsp, true);

                VentasBE.venMovimientosConStockCalcularTotalesAction IAction =
                        new VentasBE.venMovimientosConStockCalcularTotalesAction();

                VentasExchange.venMovimientosConStockActionExchange res =
                    new venMovimientosConStockActionExchange(IAction.Execute(cmd, req));

                if (lResEsp.Principal.Count > 0)
                {
                    decimal lSubTotal = 0;
                    foreach (var ren in res.Param.grdCuerpo)
                    {
                        ren.SubTotalFormImpuesto += ren.SubTotal;
                        lSubTotal += ren.SubTotal;
                    }

                    if (lResEsp.Principal[0].Cantidad > 1)
                        lResEsp.Principal[0].ValorUnitario = lSubTotal / lResEsp.Principal[0].Cantidad;
                    else
                        lResEsp.Principal[0].ValorUnitario = lSubTotal;

                    Generalidades.Especializacion.UnirDatatSets(res.Param, lResEsp);
                }
                

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
