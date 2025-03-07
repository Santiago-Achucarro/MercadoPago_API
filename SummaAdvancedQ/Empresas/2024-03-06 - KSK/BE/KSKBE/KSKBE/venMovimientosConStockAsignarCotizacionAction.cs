using System;
using Framework.Core;
using VentasExchange;
using System.ServiceModel;

namespace KSKBE
{
    public class venMovimientosConStockAsignarCotizacionAction : Framework.Core.IAction
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
            VentasExchange.venMovimientosConStockActionExchange res = new VentasExchange.venMovimientosConStockActionExchange();
            try
            {
                KSKCommon.venMovimientosConStockDS lResDs = new KSKCommon.venMovimientosConStockDS();
                if (cmd.CommonDSEsp != null)
                    lResDs.Merge(cmd.CommonDSEsp, true);

                VentasBE.venMovimientosConStockAsignarCotizacionAction IAction = new VentasBE.venMovimientosConStockAsignarCotizacionAction();
                res = new venMovimientosConStockActionExchange(IAction.Execute(cmd, req));
                // Si vino la cotizacion busco si es resumida
                VentasExchange.venCotizacionesActionExchange eCoti = new VentasExchange.venCotizacionesActionExchange(VentasExchange.venCotizacionesActionEnum.EnumvenCotizacionesAction.Datos)
                {
                    Segmento_Id = req.Param.Cotizacion[0].Segmento_Id,
                    Segmento1C = req.Param.Cotizacion[0].Segmento1C,
                    Segmento2C = req.Param.Cotizacion[0].Segmento2C,
                    Segmento3C = req.Param.Cotizacion[0].Segmento3C,
                    Segmento4C = req.Param.Cotizacion[0].Segmento4C,
                    Segmento1N = req.Param.Cotizacion[0].Segmento1N,
                    Segmento2N = req.Param.Cotizacion[0].Segmento2N,
                    Segmento3N = req.Param.Cotizacion[0].Segmento3N,
                    Segmento4N = req.Param.Cotizacion[0].Segmento4N
                };
                eCoti = new VentasExchange.venCotizacionesActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eCoti, cmd));
                if (eCoti.Existe)
                {
                    lResDs.Principal.Clear();
                    lResDs.Principal.AcceptChanges();
                    if (eCoti.Existe)
                    {
                        var CotizaResDS =
                        KSKDAL.venCotizacionesResumida.Datos(eCoti.venCotizaciones, cmd.ConnectionString);
                        if (CotizaResDS.Principal.Count > 0)
                        {
                            lResDs.Principal.AddPrincipalRow(0,0,0,"",0,0,0,0,"",false, "", CotizaResDS.Principal[0].Cantidad,
                                    CotizaResDS.Principal[0].Medida_Id, CotizaResDS.Principal[0].Leyenda,
                                    CotizaResDS.Principal[0].ValorUnitario, CotizaResDS.Principal[0].ClaveFiscal, "");
                        }



                    }
                }
                if (lResDs.Principal.Count == 0)
                    lResDs.Principal.AddPrincipalRow(0,0,0,"",0,0,0,0,"",false, "", 0, "", "", 0, "", "");

                Generalidades.Especializacion.UnirDatatSets(res.Param, lResDs);
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

