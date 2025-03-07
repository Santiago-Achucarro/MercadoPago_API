using System;
using Framework.Core;
using KSKExchange;
using System.ServiceModel;

namespace KSKBE
{
/// <summary>
/// QBI:Utilizar esta sección para describir brevemente la clase esptesT3PromocionesKSKDevolverDatosAction
/// </summary>
/// <remarks>
/// Esta clase implementa la acción "esptesT3PromocionesKSKDevolverDatosAction"
///
/// Utilizar esta sección para documentar el funcionamiento 
/// de la clase esptesT3PromocionesKSKDevolverDatosAction. No olvide de dar de
/// alta la acción "esptesT3PromocionesKSKDevolverDatosAction" para que el Dispatcher
/// sepa como ejecutarla.
/// </remarks>
	 public class esptesT3PromocionesKSKDevolverDatosAction:Framework.Core.IAction  
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

public Exchange Execute( Command cmd, Exchange exch) 
{
   TesoreriaExchange.tesT3PromocionesActionExchange req = new TesoreriaExchange.tesT3PromocionesActionExchange(exch); 
   //TesoreriaExchange.tesT3PromocionesActionExchange res = new TesoreriaExchange.tesT3PromocionesActionExchange();
   try
   {

                req.Action = TesoreriaExchange.tesT3PromocionesActionEnum
                        .GetAcciontesT3PromocionesAction(TesoreriaExchange.tesT3PromocionesActionEnum.EnumtesT3PromocionesAction.Datos);

                req = new TesoreriaExchange.tesT3PromocionesActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(req, cmd));

                KSKCommon.esptesT3PromocionesKSKDS ds = KSKDAL.esptesT3PromocionesKSK.Datos(req.tesT3Promociones, cmd.ConnectionString);

                Generalidades.Especializacion.UnirDatatSets(req.Param, ds);

                req.Param.AcceptChanges();

                return new Exchange(req);
   }
   catch (FaultException<QuestionFault> ex)
   {
     throw ex;
;   }
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
