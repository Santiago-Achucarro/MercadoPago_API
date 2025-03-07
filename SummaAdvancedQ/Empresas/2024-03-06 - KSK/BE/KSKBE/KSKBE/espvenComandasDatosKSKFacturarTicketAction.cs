using Framework.Core;
using System;
using System.Linq;
using System.ServiceModel;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase espvenComandasDatosKSKFacturarTicketAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "espvenComandasDatosKSKFacturarTicketAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase espvenComandasDatosKSKFacturarTicketAction. No olvide de dar de
    /// alta la acción "espvenComandasDatosKSKFacturarTicketAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espvenComandasDatosKSKFacturarTicketAction : Framework.Core.IAction
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
            KSKExchange.espvenComandasDatosKSKActionExchange req = new KSKExchange.espvenComandasDatosKSKActionExchange(exch);
            //KSKExchange.espvenComandasDatosKSKActionExchange res = new KSKExchange.espvenComandasDatosKSKActionExchange();
            try
            {
                // Obtengo el valor de los parciales del segmento //

                GeneralesExchange.genAsiSegmentosActionExchange exchSeg = new GeneralesExchange.genAsiSegmentosActionExchange(GeneralesExchange.genAsiSegmentosActionEnum.EnumgenAsiSegmentosAction.DatosInt)
                {
                    Asiento_Id = req.Param.Comandas[0].Comanda
                };
                exchSeg = new GeneralesExchange.genAsiSegmentosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchSeg, cmd));
                if (exchSeg.Segmento1C != "Z")
                    Generalidades.qFunctionalException.GenerarExcepcion("El_ticket_no_esta_pendiente_de_facturar");


                VentasExchange.venMovimientosConStockActionExchange exchVMCT = new VentasExchange.venMovimientosConStockActionExchange(VentasExchange.venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.Datos)
                {
                    Segmento_Id = exchSeg.Segmento_Id,
                    Segmento1C = exchSeg.Segmento1C,
                    Segmento2C = exchSeg.Segmento2C,
                    Segmento3C = exchSeg.Segmento3C,
                    Segmento4C = exchSeg.Segmento4C,
                    Segmento1N = exchSeg.Segmento1N,
                    Segmento2N = exchSeg.Segmento2N,
                    Segmento3N = exchSeg.Segmento3N,
                    Segmento4N = exchSeg.Segmento4N,
                    Empresa_Id = cmd.Empresa_Id
                };

                exchVMCT = new VentasExchange.venMovimientosConStockActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchVMCT, cmd));

                // Primero borro el genAsiSegmentos con la Z //
                exchSeg.Action = GeneralesExchange.genAsiSegmentosActionEnum.GetAcciongenAsiSegmentosAction(GeneralesExchange.genAsiSegmentosActionEnum.EnumgenAsiSegmentosAction.Eliminar);
                Generalidades.QBIInternal.WrapperExecuteActionInternal(exchSeg, cmd);

                // Ahora tengo que cambiar el tipoMov y llamar para generar el próximo número de factura //
                GeneralesExchange.genSegmentosValoresActionExchange ExcSegVal = new GeneralesExchange.genSegmentosValoresActionExchange
        (GeneralesExchange.genSegmentosValoresActionEnum.EnumgenSegmentosValoresAction.Datos)
                {
                    Segmento_Id = exchSeg.Segmento_Id,
                    Segmento1N = 0,
                    Segmento2N = exchSeg.Segmento2N,
                    Segmento3N = exchSeg.Segmento3N,
                    Segmento4N = exchSeg.Segmento4N,
                    Segmento1C = "F",
                    Segmento2C = exchSeg.Segmento2C,
                    Segmento3C = exchSeg.Segmento3C,
                    Segmento4C = exchSeg.Segmento4C,
                    Fecha = GeneralesValidacion.FechaBaseDatos.GetFechaServer(cmd).Date,
                    Posteado = exchSeg.Posteado,
                    Cliente_Id = req.Param.Comandas[0].Cliente_Id,
                    TipoMov = "F",
                    Sucursal = GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd).Sucursal
                };
                ExcSegVal = new GeneralesExchange.genSegmentosValoresActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
        (ExcSegVal, cmd));


                // Y ahora le asigno un nuevo comprobante con F //
                exchSeg.Action = GeneralesExchange.genAsiSegmentosActionEnum.GetAcciongenAsiSegmentosAction(GeneralesExchange.genAsiSegmentosActionEnum.EnumgenAsiSegmentosAction.Guardar);
                exchSeg.Segmento1C = "F";
                exchSeg.Segmento1N = 0;

                exchSeg = new GeneralesExchange.genAsiSegmentosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchSeg, cmd));

                // Cambio la fecha del ticket (tal vez se facture el ticket después de las 12) y también cambio el cliente //
                // del venMovimientos porque tal vez lo editaron cuando facturaron //
                KSKDAL.espvenComandasDatosKSK.Modificar(req.Param.Comandas[0].Comanda, ExcSegVal.Fecha, ExcSegVal.Cliente_Id, cmd.ConnectionString);

                // Llama al ws de la Afip //
                exchVMCT.Segmento1N = exchSeg.Segmento1N;
                exchVMCT.Segmento1C = exchSeg.Segmento1C;
                exchVMCT.venTipoMov = "F";
                exchVMCT.Cliente_Id = req.Param.Comandas[0].Cliente_Id;
                exchVMCT.Fecha = ExcSegVal.Fecha;
                exchVMCT.Param.grdCuotas.ToList().ForEach(c => c.FechaVencimiento = ExcSegVal.Fecha);
                exchVMCT.SubTipoMov_Id = "FCSTK";
                exchVMCT.LlamarAlWSFE = true;
                exchVMCT.Action = VentasExchange.venMovimientosConStockActionEnum.GetAccionvenMovimientosConStockAction(VentasExchange.venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.LlamarAlWebServiceFE);
                exchVMCT = new VentasExchange.venMovimientosConStockActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchVMCT, cmd));

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
