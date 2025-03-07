using System;
using Framework.Core;
using TtExchange;
using System.ServiceModel;

namespace TtBE
{
/// <summary>
/// QBI:Utilizar esta sección para describir brevemente la clase tesMercadoPagoGuardarAction
/// </summary>
/// <remarks>
/// Esta clase implementa la acción "tesMercadoPagoGuardarAction"
///
/// Utilizar esta sección para documentar el funcionamiento 
/// de la clase tesMercadoPagoGuardarAction. No olvide de dar de
/// alta la acción "tesMercadoPagoGuardarAction" para que el Dispatcher
/// sepa como ejecutarla.
/// </remarks>
	 public class tesMercadoPagoGuardarAction:Framework.Core.IAction  
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
   TtExchange.tesMercadoPagoActionExchange req = new TtExchange.tesMercadoPagoActionExchange(exch); 
   TtExchange.tesMercadoPagoActionExchange res = new TtExchange.tesMercadoPagoActionExchange();
   try
   {
                if (req.Param.Principal[0].MercadoPago_Id == "")
                {
                    Generalidades.qFunctionalException.GenerarExcepcion("El codigo no puedo ser vacio");
                }

                if (req.Param.Principal[0].Descripcion == "")
                {
                    Generalidades.qFunctionalException.GenerarExcepcion("L descripcion no puedo ser vacia");
                }

                TtDAL.tesMercadoPago.Guardar(req.MercadoPago_Id, req.MercadoPago_Id_Nueva, cmd.Empresa_Id, req.Descripcion, req.Inactivo, cmd.Usuario_Id, req.Posteado, cmd.ConnectionString);

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
