using System;
using Framework.Core;
using KSKExchange;
using System.ServiceModel;
using System.Collections.Generic;
using System.IO;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase venMovimientosEnviarAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "venMovimientosEnviarAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase venMovimientosEnviarAction. No olvide de dar de
    /// alta la acción "venMovimientosEnviarAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class venMovimientosEnviarAction : Framework.Core.IAction
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
            KSKExchange.venMovimientosActionExchange req = new KSKExchange.venMovimientosActionExchange(exch);
            KSKExchange.venMovimientosActionExchange res = new KSKExchange.venMovimientosActionExchange();
            try
            {
                GeneralesExchange.genEmpresasActionExchange eEmpresa = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);
                if (eEmpresa.EnviaFacturas)
                {
                    if (eEmpresa.ConfirmarEnviarFacturas && cmd.CodigoConsulta != "YES")
                        Generalidades.qQuestionException.GenerarExcepcion("Desea_Enviar_La_Factura", "YES");

                    VentasExchange.venMovimientosActionExchange eMov = new VentasExchange.venMovimientosActionExchange(VentasExchange.venMovimientosActionEnum.EnumvenMovimientosAction.DatosSeg)
                    {
                        Segmento_Id = req.Segmento_Id,
                        Segmento1C = req.Segmento1C,
                        Segmento2C = req.Segmento2C,
                        Segmento3C = req.Segmento3C,
                        Segmento4C = req.Segmento4C,
                        Segmento1N = req.Segmento1N,
                        Segmento2N = req.Segmento2N,
                        Segmento3N = req.Segmento3N,
                        Segmento4N = req.Segmento4N

                    };
                    eMov = new VentasExchange.venMovimientosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

                    if (!eMov.Existe)
                        Generalidades.qFunctionalException.GenerarExcepcion("El_movimiento_No_existe");


                    List<string> lPara = new List<string> { };

                    VentasExchange.venClieHabitualActionExchange eCliente =
                        VentasValidacion.venClieHabitual.Existe(eMov.Cliente_Id, eMov.Sucursal, cmd);
                    foreach (var Contacto in eCliente.Param.grdContactos)
                    {
                        if (Contacto.EnviaFacturas)
                            lPara.Add(Contacto.Email);
                    }
                    if ((lPara.Count == 0) && eCliente.SucursalPredeter != eCliente.Sucursal)
                    {
                        eCliente =
                        VentasValidacion.venClieHabitual.Existe(req.Cliente_Id, eCliente.SucursalPredeter, cmd);
                        foreach (var Contacto in eCliente.Param.grdContactos)
                        {
                            if (Contacto.EnviaFacturas)
                                lPara.Add(Contacto.Email);
                        }

                    }
                    if (lPara.Count == 0)
                    {
                        if (eEmpresa.MailClientesSinMail != "")
                            lPara.Add(eEmpresa.MailClientesSinMail);
                    }

                    if (lPara.Count > 0)
                    {
                        // Averigo la Ruta al Pdf

                        VentasExchange.venMovimientosImprimirActionExchange eImprimir = new VentasExchange.venMovimientosImprimirActionExchange(VentasExchange.venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction.AsignarNombre)
                        {
                            Segmento_Id = req.Segmento_Id,
                            Segmento1C = req.Segmento1C,
                            Segmento2C = req.Segmento2C,
                            Segmento3C = req.Segmento3C,
                            Segmento4C = req.Segmento4C,
                            Segmento1N = req.Segmento1N,
                            Segmento2N = req.Segmento2N,
                            Segmento3N = req.Segmento3N,
                            Segmento4N = req.Segmento4N
                        };


                        eImprimir = new VentasExchange.venMovimientosImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eImprimir, cmd));
                        if (!System.IO.File.Exists(eImprimir.NombreArchivo + ".pdf"))
                        {
                            // Si no existe la genero
                            eImprimir.Action = VentasExchange.venMovimientosImprimirActionEnum.GetAccionvenMovimientosImprimirAction
                                (VentasExchange.venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction.Guardar);

                            eImprimir = new VentasExchange.venMovimientosImprimirActionExchange
                                (Generalidades.QBIInternal.WrapperExecuteActionInternal(eImprimir, cmd));

                            /*
                            object[] param = { eImprimir.NombreArchivo + ".pdf" };
                            Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_el_Archivo_<0>", param);
                            */
                        }
                        List<string> pAdjuntos;
                        object EnviarForma = null;
                        if (!String.IsNullOrWhiteSpace(eMov.FormaEntrega_Id))
                        {
                            VentasExchange.venFormaEntregaActionExchange eFormaEntrega = VentasValidacion.venFormaEntrega.ExistePosteadoyActivo(eMov.FormaEntrega_Id, cmd);
                            EnviarForma = GeneralesValidacion.genAtributosValores.Obtener(1, eFormaEntrega.venFormaEntrega, "venFormaEntrega", cmd);
                        }

                        if (EnviarForma != null && (int)EnviarForma == 1)
                            pAdjuntos = new List<string> { eImprimir.NombreArchivo.EndsWith(".pdf") ? eImprimir.NombreArchivo : eImprimir.NombreArchivo + ".pdf", "FormasEmbarque\\Forma Embarque " + eEmpresa.Empresa_Id + ".pdf" };
                        else
                            pAdjuntos = new List<string> { eImprimir.NombreArchivo.EndsWith(".pdf") ? eImprimir.NombreArchivo : eImprimir.NombreArchivo + ".pdf" };
                        if (cmd.Dominio_Id == "MX")
                        {
                            if (System.IO.File.Exists(eImprimir.NombreArchivo + ".xml"))
                                pAdjuntos.Add(eImprimir.NombreArchivo + ".xml");

                        }


                        object[] lParam = { eEmpresa.RazonSocial };
                        // todo definir esto

                        string lCuerpo = "<HTML>";
                        lCuerpo += "<div><p>Sres " + eCliente.RazonSocial + "</p></div>";
                        lCuerpo += "<div><p>Adjunto a este correo encontrará su factura</p></div>";
                        lCuerpo += "<div><p>Agradecemos su Atención.</p></div>";
                        lCuerpo += "<div><p>Área de Facturación de " + eEmpresa.RazonSocial.Trim() + "</p></div>";
                        lCuerpo += "</HTMP>";
                        GeneralesExchange.genUsuariosActionExchange eUsuario = GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd);

                        Stream ImagenFirma = new MemoryStream(Convert.FromBase64String(eUsuario.ImagenFirmaB64));

                        bool lResultado = GeneralesValidacion.Correo.Enviar(lPara, Recursos.Recurso.GetString("Factura_de_<0>", lParam), lCuerpo, pAdjuntos, cmd);
                        if (!lResultado)
                            Generalidades.qFunctionalException.GenerarExcepcion("Error_Al_Enviar_eMail");

                    }

                }
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
