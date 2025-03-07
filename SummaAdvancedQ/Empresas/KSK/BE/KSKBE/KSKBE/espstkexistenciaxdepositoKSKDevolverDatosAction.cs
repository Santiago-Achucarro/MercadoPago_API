using System;
using Framework.Core;
using KSKExchange;
using System.ServiceModel;
using GeneralesExchange;
using System.Data;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase espstkexistenciaxdepositoKSKDevolverDatosAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "espstkexistenciaxdepositoKSKDevolverDatosAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase espstkexistenciaxdepositoKSKDevolverDatosAction. No olvide de dar de
    /// alta la acción "espstkexistenciaxdepositoKSKDevolverDatosAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espstkexistenciaxdepositoKSKDevolverDatosAction : Framework.Core.IAction
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
            KSKExchange.espstkexistenciaxdepositoKSKActionExchange req = new KSKExchange.espstkexistenciaxdepositoKSKActionExchange(exch);
            KSKExchange.espstkexistenciaxdepositoKSKActionExchange res = new KSKExchange.espstkexistenciaxdepositoKSKActionExchange();
            try
            {

                req.Param.grdcuerpo.Clear();
                
                if (req.Producto == string.Empty)
                    return new Exchange(req);

               // int todo = Convert.ToInt16(req.Param.Principal[0].Todo);
         


                genUsuariosActionExchange usu = new genUsuariosActionExchange(genUsuariosActionEnum.EnumgenUsuariosAction.DatosIdentity);
                usu.genUsuarios= cmd.Usuario_Id;
                usu = new GeneralesExchange.genUsuariosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(usu, cmd));

                


                //TODO: Del usuario saltar a la sucursal 
                //TODO: Traer de una variable global la lista de precios para los locales ahora esta hardcodeada
                KSKCommon.espstkexistenciaxdepositoKSKDS ds = KSKDAL.espstkexistenciaxdepositoKSK.Datos(req.Producto,
                    usu.Sucursal, cmd.Empresa_Id, "LOC", cmd.ConnectionString);


                //le pega los datos de la consulta para volver a enviarlo a la pantalla
                //ds.Merge(req.Param, false, System.Data.MissingSchemaAction.Ignore);
                req.Param.Merge(ds, false, MissingSchemaAction.Add);

                req.Existe = true;
                req.Param.AcceptChanges();

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
