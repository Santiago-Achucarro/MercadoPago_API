using System;
using Framework.Core;
using KSKExchange;
using System.ServiceModel;

namespace KSKBE
{
/// <summary>
/// QBI:Utilizar esta sección para describir brevemente la clase espvenClieHabitualKSKEliminarAction
/// </summary>
/// <remarks>
/// Esta clase implementa la acción "espvenClieHabitualKSKEliminarAction"
///
/// Utilizar esta sección para documentar el funcionamiento 
/// de la clase espvenClieHabitualKSKEliminarAction. No olvide de dar de
/// alta la acción "espvenClieHabitualKSKEliminarAction" para que el Dispatcher
/// sepa como ejecutarla.
/// </remarks>
	 public class espvenClieHabitualKSKEliminarAction:Framework.Core.IAction  
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
   VentasExchange.venClieHabitualActionExchange req = new VentasExchange.venClieHabitualActionExchange(exch); 
   //VentasExchange.venClieHabitualActionExchange res = new VentasExchange.venClieHabitualActionExchange();
   try
   {
                //ahora llamo al DAL y ejecuto el eliminar para eliminar desde la tabla especial
                KSKDAL.espvenClieHabitualKSK.Eliminar(req.genEntidades, req.Sucursal, cmd.ConnectionString);

                //ahora la tabla padre
                req.Action = VentasExchange.venClieHabitualActionEnum.GetAccionvenClieHabitualAction(VentasExchange.venClieHabitualActionEnum.EnumvenClieHabitualAction.Eliminar);

                //ahora ejecutamos la accion eliminar eliminando los datos de la tabla estandar
                Generalidades.QBIInternal.WrapperExecuteActionInternal(req, cmd);

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
