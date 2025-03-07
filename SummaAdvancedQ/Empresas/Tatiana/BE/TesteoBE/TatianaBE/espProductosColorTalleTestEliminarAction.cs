using System;
using Framework.Core;
using TatianaExchange;
using System.ServiceModel;

namespace TatianaBE
{
/// <summary>
/// QBI:Utilizar esta sección para describir brevemente la clase espProductosColorTalleTestEliminarAction
/// </summary>
/// <remarks>
/// Esta clase implementa la acción "espProductosColorTalleTestEliminarAction"
///
/// Utilizar esta sección para documentar el funcionamiento 
/// de la clase espProductosColorTalleTestEliminarAction. No olvide de dar de
/// alta la acción "espProductosColorTalleTestEliminarAction" para que el Dispatcher
/// sepa como ejecutarla.
/// </remarks>
	 public class espProductosColorTalleTestEliminarAction:Framework.Core.IAction  
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
   StockExchange.stkProductosActionExchange req = new StockExchange.stkProductosActionExchange(exch); 
   StockExchange.stkProductosActionExchange res = new StockExchange.stkProductosActionExchange();
   try
   {
       
   return new Exchange(res);
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
