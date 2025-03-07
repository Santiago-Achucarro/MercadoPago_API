using Framework.Core;
using System;
using System.ServiceModel;
using System.Xml;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase espvenMovimientosConStockKSKLeerPadronAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "espvenMovimientosConStockKSKLeerPadronAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase espvenMovimientosConStockKSKLeerPadronAction. No olvide de dar de
    /// alta la acción "espvenMovimientosConStockKSKLeerPadronAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espvenMovimientosConStockKSKLeerPadronAction : Framework.Core.IAction
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
            VentasExchange.venMovimientosConStockActionExchange req = new VentasExchange.venMovimientosConStockActionExchange(exch);
            //VentasExchange.venMovimientosConStockActionExchange res = new VentasExchange.venMovimientosConStockActionExchange();
            try
            {

                KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
                ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);

                VentasExchange.venClieHabitualActionExchange exchClie = new VentasExchange.venClieHabitualActionExchange(VentasExchange.venClieHabitualActionEnum.EnumvenClieHabitualAction.Datos)
                {
                    Cliente_Id = ds.Principal[0].ClienteNuevo_Id,
                    Sucursal = 1
                };

                exchClie = new VentasExchange.venClieHabitualActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchClie, cmd));
                if (!exchClie.Existe)
                {
                    Int64 lNroDoc = 11111111;


                    //string[] lCuits = { ds.Principal[0].ClienteNuevo_Id.Trim()};
                    bool lAgregarGuiones = false;
                    string lCuit = ds.Principal[0].ClienteNuevo_Id.Trim();
                    Int64[] lCuitNumerico = { 0 };

                    if (lCuit.Length == 13 && lCuit.Split('-').Length == 3 && Int64.TryParse(lCuit.Replace("-", ""), out lNroDoc) || lCuit.Length == 11 && Int64.TryParse(lCuit.Replace("-", ""), out lNroDoc))
                    {
                        // Son solo números y tiene los 2 guiones y se los quito o no tiene los guiones //
                        lCuitNumerico = new Int64[] { lNroDoc };

                        if (lCuit.Length == 11)
                            lAgregarGuiones = true;
                    }
                    else if (lCuit.Length <= 8 && Int64.TryParse(lCuit, out lNroDoc))
                    {
                        // Es un DNI. Lo convierto a Cuit para buscar los datos agregando 20, 23, 24, 27 y calculando el último dígito //
                        lCuitNumerico = new Int64[] { 0, 0, 0, 0 };

                        string lCuitCalculado;
                        lCuitCalculado = Generalidades.Auxiliares.CalculaDigitoCuit("20-" + lCuit.PadLeft(8, '0'), "AR");
                        Int64.TryParse(lCuitCalculado.Replace("-", ""), out lNroDoc);
                        lCuitNumerico[0] = lNroDoc;

                        lCuitCalculado = Generalidades.Auxiliares.CalculaDigitoCuit("27-" + lCuit.PadLeft(8, '0'), "AR");
                        Int64.TryParse(lCuitCalculado.Replace("-", ""), out lNroDoc);
                        lCuitNumerico[1] = lNroDoc;

                        lCuitCalculado = Generalidades.Auxiliares.CalculaDigitoCuit("24-" + lCuit.PadLeft(8, '0'), "AR");
                        Int64.TryParse(lCuitCalculado.Replace("-", ""), out lNroDoc);
                        lCuitNumerico[2] = lNroDoc;

                        lCuitCalculado = Generalidades.Auxiliares.CalculaDigitoCuit("23-" + lCuit.PadLeft(8, '0'), "AR");
                        Int64.TryParse(lCuitCalculado.Replace("-", ""), out lNroDoc);
                        lCuitNumerico[3] = lNroDoc;
                    }

                    bool lContinuo = true;
                    for (int i = 0; i < lCuitNumerico.Length && lContinuo; i++)
                    {

                        try
                        {
                            //lNroDoc = Convert.ToInt64(ds.Principal[0].ClienteNuevo_Id);
                            VentasBEFactElect.venMovimientosConStockFELlamarWS.Resultado lResultado = VentasBEFactElect.venAccesosFEAR.XMLDatosCuitDNI(lCuitNumerico[i], cmd);

                            ds.Principal[0].DescripcionClienteNuevo = "";

                            if (!lResultado.Error)
                            {
                                XmlDocument xmlResultado = new XmlDocument();
                                xmlResultado.LoadXml(lResultado.Devolucion);
                                ds.Principal[0].DescripcionClienteNuevo = xmlResultado.GetElementsByTagName("apellido")[0].InnerText;

                                lContinuo = false;

                                if (lAgregarGuiones)
                                    // Devuelvo el cuit con los guiones agregados para que se almacene así //
                                    ds.Principal[0].ClienteNuevo_Id = ds.Principal[0].ClienteNuevo_Id.Trim().Substring(0, 2) + "-" + ds.Principal[0].ClienteNuevo_Id.Trim().Substring(2, 8) + "-" + ds.Principal[0].ClienteNuevo_Id.Trim().Substring(10, 1);

                            }

                        }
                        catch(Exception ex)
                        {
                            // Si el ws dio error no traigo nada //
                            lContinuo = false;
                            throw ex;
                        }

                        //if (ds.Principal[0].ClienteNuevo_Id.Trim().Length == 11 && Int64.TryParse(ds.Principal[0].ClienteNuevo_Id.Trim().Replace("-", ""), out lNroDoc))
                        //{
                        //    // No tiene guiones => se los agrego //

                        //}


                    }
                }
                Generalidades.Especializacion.UnirDatatSets(req.Param, ds);

                req.Existe = true;

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
