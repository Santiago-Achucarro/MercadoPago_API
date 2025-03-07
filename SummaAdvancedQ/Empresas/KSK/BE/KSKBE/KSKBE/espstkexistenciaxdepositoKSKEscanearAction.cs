using System;
using Framework.Core;
using KSKExchange;
using System.ServiceModel;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase espstkexistenciaxdepositoKSKEscanearAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "espstkexistenciaxdepositoKSKEscanearAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase espstkexistenciaxdepositoKSKEscanearAction. No olvide de dar de
    /// alta la acción "espstkexistenciaxdepositoKSKEscanearAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espstkexistenciaxdepositoKSKEscanearAction : Framework.Core.IAction
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
            //KSKExchange.espstkexistenciaxdepositoKSKActionExchange res = new KSKExchange.espstkexistenciaxdepositoKSKActionExchange();
            try
            {
                

                StockExchange.stkProductosActionExchange exchProd = new StockExchange.stkProductosActionExchange(StockExchange.stkProductosActionEnum.EnumstkProductosAction.Datos);

                exchProd.Producto_Id = req.stkProductoEscaneo; 
                exchProd = new StockExchange.stkProductosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchProd, cmd));

                if (!exchProd.Existe)
                {
                    Generalidades.qFunctionalException.GenerarExcepcion("El producto no existe");
                }
                if (!exchProd.Posteado)
                {
                    Generalidades.qFunctionalException.GenerarExcepcion("El producto no está posteado");
                }
                if (exchProd.Inactivo)
                {
                    Generalidades.qFunctionalException.GenerarExcepcion("El producto está inactivo");
                }
                req.Producto = req.stkProductoEscaneo;
                //Generalidades.Especializacion.UnirDatatSets(req.Param, ds);
                req.stkProductoEscaneo = "";
                req.Existe = true;

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