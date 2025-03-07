using Framework.Core;
using KSKBE.MP;
using System;
using System.Data;
using System.ServiceModel;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase esptesMPCobranzaKSKDevolverDatosAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "esptesMPCobranzaKSKDevolverDatosAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase esptesMPCobranzaKSKDevolverDatosAction. No olvide de dar de
    /// alta la acción "esptesMPCobranzaKSKDevolverDatosAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class esptesMPCobranzaKSKDevolverDatosAction : Framework.Core.IAction
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
            KSKExchange.esptesMPCobranzaKSKActionExchange req = new KSKExchange.esptesMPCobranzaKSKActionExchange(exch);
            //KSKExchange.esptesMPCobranzaKSKActionExchange res = new KSKExchange.esptesMPCobranzaKSKActionExchange();
            try
            {
                // busco en el genasisegmentos para traer el id
                // lugo busco si se pago con mercado pago
                // me fijo si el saldo es 0 (tiene que ser 0 porque le puseo mercado pago el summa)

                if (req.Param.Principal[0].external_reference.Length < 8)
                    Generalidades.qFunctionalException.GenerarExcepcion("Por favor revise el comprobante");


                string s1c = req.Param.Principal[0].external_reference.Substring(0, 1);
                string s3c = req.Param.Principal[0].external_reference.Substring(2, 1);
                string s2c = req.Param.Principal[0].external_reference.Substring(4, 4);
                string s1n = req.Param.Principal[0].external_reference.Substring(9).Trim();

                DataRow registro;
                Object dato = 0;
                object aPagar = 0;
                req.Param.Principal[0].status = string.Empty;

                ConectarSQL conectar = new ConectarSQL();
                DataTable tabla = conectar.EjecutarConsulta($@"select * from genAsiSegmentos where Segmento1C = '{s1c}'  
                                AND Segmento2C = '{s2c}'  and Segmento3C = '{s3c}'  
                                and Segmento1N = {s1n}  ORDER BY Asiento_Id DESC");
                if (tabla.Rows.Count > 0)
                {
                    registro = tabla.Rows[0];
                    dato = registro["Asiento_id"];
                }
                else
                    Generalidades.qFunctionalException.GenerarExcepcion("No se encontro este comprobante");


                //ahora me fijo si se pago con Mercado Libre
                tabla = conectar.EjecutarConsulta($@"Select a.Asiento_Id FacturaId, a.Asiento_Id_Ap CobranzaId, b.Saldo, b.Importe, d.Cartera_Id
                            FROM genCancMov a
	                            inner join venMovimientos b on a.Asiento_Id_Ap = b.venMovimientos
	                            inner join tesRengMovi c on a.Asiento_Id_Ap = c.tesMovimientos
	                            inner join tesIdentifica d on c.Cartera_Id = d.tesIdentifica
                             WHERE a.Asiento_Id = {dato} and d.Cartera_Id = 'MPAGO' ");

                if (tabla.Rows.Count > 0)
                {
                    registro = tabla.Rows[0];
                    dato = registro["Saldo"];
                    aPagar = registro["Importe"];
                }
                else
                    Generalidades.qFunctionalException.GenerarExcepcion("Esta Factura no fue pagada con Mercado Pago");


                req.Param.Principal[0].APagar = decimal.Parse(aPagar.ToString());

                GenerarOrden mp = new GenerarOrden(s2c);

                

                //ahora veo que onda con Mercado Pago
                GenerarOrden MpOrden = new GenerarOrden((decimal)aPagar, req.Param.Principal[0].external_reference, mp.mpSucursal, mp.mpCaja);
                MpOrden.Generar();


                try
                {

                    if (MpOrden.Buscar().Result)
                    {
                        

                        req.Param.Principal[0].status = MpOrden.status.ToString();
                        req.Param.Principal[0].pay_transaction_amount = MpOrden.monto;
                        req.Param.Principal[0].pay_status = MpOrden.pay_status.ToString();
                        req.Param.Principal[0].date_created = MpOrden.fecha.ToString();

                    }
                    else
                        req.Param.Principal[0].status = "No se pudo buscar en MP";
                }
                catch (Exception ex)
                {

                    Generalidades.qTechnicalException.GenerarExcepcion(ex.Message);
                    throw new Exception("Error al generar Tecnical Exception");
                }

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
