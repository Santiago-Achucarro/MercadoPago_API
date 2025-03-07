using System;
using Framework.Core;
using KSKExchange;
using System.ServiceModel;
using KSKBE.MP;
using System.Data;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase espvenMovimientosConStockKSKMPCrearOrdenAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "espvenMovimientosConStockKSKMPCrearOrdenAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase espvenMovimientosConStockKSKMPCrearOrdenAction. No olvide de dar de
    /// alta la acción "espvenMovimientosConStockKSKMPCrearOrdenAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espvenMovimientosConStockKSKMPEscanearOrdenAction : Framework.Core.IAction
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
            KSKExchange.espvenMovimientosConStockKSKActionExchange req = new KSKExchange.espvenMovimientosConStockKSKActionExchange(exch);
            //KSKExchange.espvenMovimientosConStockKSKActionExchange res = new KSKExchange.espvenMovimientosConStockKSKActionExchange();
            try
            {

                KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
                ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);
                ds.MercadoPago[0].IdMercadoPago = "1";

                req.Param.Principal[0].Existe = true;
                Generalidades.Especializacion.UnirDatatSets(req.Param, ds);

                string mensajeMP = string.Empty;
                //string external_reference = ds.Principal[0].Comprobante;
                string external_reference = DateTime.Now.ToString("yyyyMMddHHmmss");

                if (req.Param.Cobranza[0].Cartera_Id == "MPAGO")
                {
                    GenerarOrden mp = new GenerarOrden(req.Param.Principal[0].Segmento2C);
                    // ya tengo la sucursal y caja de mercado pago llenas en mp.mpSucursal y mp.mpCaja

                   GenerarOrden MpOrden = new KSKBE.MP.GenerarOrden(req.Param.Cobranza[0].Importe, external_reference, mp.mpSucursal, mp.mpCaja);

                    if (MpOrden.Generar().Result)
                        ds.MercadoPago[0].IdMercadoPago = "1";
                    else
                        Generalidades.qFunctionalException.GenerarExcepcion($"No se pudo generar la orden: {MpOrden.Mensaje}");
                }




                // Ahora llamo al escaneo
                ConectarSQL conectar = new ConectarSQL();
                Console.WriteLine("Buscando Sucursal de Ksk");
                DataTable tabla = conectar.EjecutarConsulta($@"select Serie as Sucursal, 
                                RegPatronal as Caja from genSucursalesEmpr (nolock) where Sucursal = '{req.Param.Principal[0].Segmento2C}'");

                string mpsucursal = string.Empty;
                string mpcaja = string.Empty;

                if (tabla.Rows.Count > 0)
                {
                    mpsucursal = tabla.Rows[0][0].ToString();
                    mpcaja = tabla.Rows[0][1].ToString();
                }
                else
                    Generalidades.qFunctionalException.GenerarExcepcion("Esta Sucursal no tiene Caja de MP asociada");


                Console.WriteLine($"Antes de Detectar Escaneo del comprobante {external_reference} de la sucursal {mpsucursal} y de la caja {mpcaja}");
                GenerarOrden MpOrdenEsc = new GenerarOrden(external_reference, mpsucursal, mpcaja);
                bool escaneado = MpOrdenEsc.Escaneo(external_reference).Result;

                if (escaneado)
                {
                    Console.WriteLine("Escaneo Detectado ");
                    ds.Principal[0].MPEstado = "F";
                
                }
                else
                {
                    // por ahora viene aca si no escaneo en los 20 segundos que le di
                    ds.Principal[0].MPEstado = "N";
                    Console.WriteLine("No se detecto escaneo");
                }


                Console.WriteLine("req.Existe = true ");
                req.Existe = true;

                Console.WriteLine("Generalidades.Especializacion.UnirDatatSets(req.Param, ds);");
                Generalidades.Especializacion.UnirDatatSets(req.Param, ds);

                Console.WriteLine("Devuelvo new Exchange ");
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
