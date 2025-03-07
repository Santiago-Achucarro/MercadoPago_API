using System;
using Framework.Core;
using TesteoExchange;
using System.ServiceModel;
using System.Net.Configuration;

namespace TesteoBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase espstkProductosDevolverDatosAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "espstkProductosDevolverDatosAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase espstkProductosDevolverDatosAction. No olvide de dar de
    /// alta la acción "espstkProductosDevolverDatosAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espstkProductosDevolverDatosAction : Framework.Core.IAction
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
            StockExchange.stkProductosActionExchange req = new StockExchange.stkProductosActionExchange(exch);
            StockExchange.stkProductosActionExchange res = new StockExchange.stkProductosActionExchange();
            try
            {
                req.Action = StockExchange.stkProductosActionEnum.GetAccionstkProductosAction(StockExchange.stkProductosActionEnum.EnumstkProductosAction.Datos);
                req = new StockExchange.stkProductosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(req, cmd));
                TestCommon.espProductosColorTalleTestDS ds = TestDal.espProductosColorTalleTest.Datos(req.Producto_Id, cmd.ConnectionString);
                if(ds.TalleColor.Count == 0)
                {
                    ds.TalleColor.AddTalleColorRow(req.Producto_Id, req.Descripcion, "", "", "", "", false);
                }
                Generalidades.Especializacion.UnirDatatSets(req.Param, ds);
                req.Param.AcceptChanges();
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
