using System;
using Framework.Core;
using KSKExchange;
using System.ServiceModel;
using KSKDal;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase espstkProductosGuardarAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "espstkProductosGuardarAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase espstkProductosGuardarAction. No olvide de dar de
    /// alta la acción "espstkProductosGuardarAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espstkProductosKSKGuardarAction : Framework.Core.IAction
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
                KSKCommon.espProductosColorTalleKSKDS ds = new KSKCommon.espProductosColorTalleKSKDS();
                ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);
                KSKExchange.espstkColorKSKActionExchange exchColor = new espstkColorKSKActionExchange(KSKExchange.espstkColorKSKActionEnum.EnumespstkColorKSKAction.Datos);
                exchColor.Color_Id = ds.TalleColor[0].Color_Id;
                exchColor = new espstkColorKSKActionExchange (Generalidades.QBIInternal.WrapperExecuteActionInternal(exchColor, cmd));
                if (!exchColor.Existe)
                {
                    Generalidades.qFunctionalException.GenerarExcepcion("El color no existe");
                }
                if (!exchColor.Posteado)
                {
                    Generalidades.qFunctionalException.GenerarExcepcion("No esta posteado");
                }
                if (!exchColor.PTodasEmpresas && exchColor.Empresa_Id != cmd.Empresa_Id)
                {
                    Generalidades.qFunctionalException.GenerarExcepcion("No esta habilitado para usar esta empresa");
                }

                KSKExchange.espstkTalleKSKActionExchange exchTalle = new espstkTalleKSKActionExchange(KSKExchange.espstkTalleKSKActionEnum.EnumespstkTalleKSKAction.Datos);
                exchTalle.Talle_Id = ds.TalleColor[0].Talle_Id;
                exchTalle = new espstkTalleKSKActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchTalle, cmd));
                if (!exchTalle.Existe)
                {
                    Generalidades.qFunctionalException.GenerarExcepcion("El talle no existe");
                }
                if (!exchTalle.Posteado)
                {
                    Generalidades.qFunctionalException.GenerarExcepcion("No esta posteado");
                }
                if (!exchTalle.PTodasEmpresas && exchTalle.Empresa_Id != cmd.Empresa_Id)
                {
                    Generalidades.qFunctionalException.GenerarExcepcion("No esta habilitado para usar esta empresa");
                }
                req.Action = StockExchange.stkProductosActionEnum.GetAccionstkProductosAction(StockExchange.stkProductosActionEnum.EnumstkProductosAction.Guardar);
                req = new StockExchange.stkProductosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(req, cmd));
                

                KSKDal.espProductosColorTalleKSK.Guardar(req.Producto_Id, ds.TalleColor[0].Color_Id, ds.TalleColor[0].Talle_Id, cmd.ConnectionString);
                
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
