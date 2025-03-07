using System;
using Framework.Core;
using KSKExchange;
using System.ServiceModel;
using System.Collections.Generic;
using VentasExchange;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase espvenMovimientosConStockKSKEnviaKSKAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "espvenMovimientosConStockKSKEnviaKSKAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase espvenMovimientosConStockKSKEnviaKSKAction. No olvide de dar de
    /// alta la acción "espvenMovimientosConStockKSKEnviaKSKAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espvenMovimientosConStockKSKEnviaKSKAction : Framework.Core.IAction
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
            KSKExchange.espvenMovimientosConStockKSKActionExchange res = new KSKExchange.espvenMovimientosConStockKSKActionExchange();
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
                        List<string> pAdjuntos = new List<string> { eImprimir.NombreArchivo.EndsWith(".pdf") ? eImprimir.NombreArchivo : eImprimir.NombreArchivo + ".pdf" };
                        if (cmd.Dominio_Id == "MX")
                        {
                            if (System.IO.File.Exists(eImprimir.NombreArchivo + ".xml"))
                                pAdjuntos.Add(eImprimir.NombreArchivo + ".xml");
                            else
                            {
                                VentasExchange.venMovimientosFiscalActionExchange eMovFiscal =
                                   new venMovimientosFiscalActionExchange(venMovimientosFiscalActionEnum.EnumvenMovimientosFiscalAction.Datos)
                                   {
                                       venMovimientos = eMov.venMovimientos

                                   };

                                eMovFiscal = new venMovimientosFiscalActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMovFiscal, cmd));

                                if (eMovFiscal.Existe && !String.IsNullOrWhiteSpace(eMovFiscal.XMLFiscal))
                                {
                                    System.IO.File.WriteAllText(eImprimir.NombreArchivo + ".xml",
                                            eMovFiscal.XMLFiscal, System.Text.Encoding.UTF8);
                                    pAdjuntos.Add(eImprimir.NombreArchivo + ".xml");
                                }

                            }

                        }


                        ///-----------------------------------------------------------------------
                        var eUsuario = GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd);
                        var eSucursal = GeneralesValidacion.genSucursalesEmpr.Existe(eUsuario.Sucursal, cmd);

                        var lSegmentoStr = GeneralesValidacion.genSegmentos.SegmentoStr(req.Param
                                .Principal[0].Segmento_Id,
                                "",
                                req.Param.Principal[0].Segmento2C,
                                "", req.Param.Principal[0].Segmento4C,
                                req.Param.Principal[0].Segmento1N,
                                req.Param.Principal[0].Segmento2N,
                                req.Param.Principal[0].Segmento3N,
                                req.Param.Principal[0].Segmento4N, cmd);

                        string lRetorno = "";
                        lRetorno += "<img alt='Imagen' height='100px' width='100px' src='data:image/png;base64," + "KOWZEF SA" + "' /><br>";
                        lRetorno += "<p>";
                        lRetorno += "<strong>TICKET DE CAMBIO</strong>";
                        lRetorno += "<p>";
                        lRetorno += "Kowzef SA" + "<br>";
                        lRetorno += "Dardo Rocha 1835 San Isidro - Provincia de Buenos Aires " + "<br>";
                        lRetorno += "Argentina" + "<br>";
                        lRetorno += "CUIT: 30677399879" + "<br>";
                        lRetorno += "RESPONSABLE INSCRIPTO" + "<br>";
                        lRetorno += "----------------------------------------------------------<br>";
                        lRetorno += req.Param.Principal[0].Fecha.Day.ToString("00") + "/" + req.Param.Principal[0].Fecha.Month.ToString("00") + "/" + req.Param.Principal[0].Fecha.Year.ToString("0000") + "  ";
                        lRetorno += req.Param.Principal[0].Fecha.Hour.ToString("00") + ":" + req.Param.Principal[0].Fecha.Minute.ToString("00") + ":" + req.Param.Principal[0].Fecha.Second.ToString("00") + "  ";
                        lRetorno += "Nro.T.:" + lSegmentoStr.SegmentoSTR + "<br>";
                        lRetorno += "----------------------------------------------------------<br>";
                        //lRetorno += "RFC:" + eEmpresa.Cuit + "</p>";
                        //lRetorno += "<p> </p>";
                        lRetorno += eSucursal.Descripcion + "<br> ";
                        lRetorno += eSucursal.Direccion + "<br>";
                        lRetorno += eSucursal.Localidad + " " + eSucursal.DescripcionProvincias + " " + eSucursal.CodigoPostal + "<br>";
                        lRetorno += "Te:" + eSucursal.Telefono + "<br>";
                        lRetorno += "</p>";
                        //lRetorno += "<p> </p>";
                        //lRetorno += "<p>Vendedor:" + pCommonDS.Principal[0].Vendedor_Id + "<br>";
                        //lRetorno += pCommonDS.Principal[0].NombreFantasia + "</p>";
                        //lRetorno += "<p> </p>";

                        //int nEspBlancos = 18;


                        lRetorno += "<p style=\"margin-bottom: 1px; margin-top: 1px\">----------------------------------------------------------</p>";
                        lRetorno += "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" style=\"font-size: 16px; font-family: 'Times New Roman'; \">";
                        lRetorno += "<tbody>";
                        lRetorno += "<tr>";
                        lRetorno += "<td style=\"width: 38px; text-align: right; padding-right:3px; \">Cant.</td>";
                        lRetorno += "<td style=\"width: 100px; text-align: left; padding-right:2px; \">SKU</td>";
                        lRetorno += "<td style=\"width: 177px; text-align: left; padding-right:2px; \">Descripción</td>";

                        lRetorno += "</tr>";
                        lRetorno += "</tbody>";
                        lRetorno += "</table>";
                        lRetorno += "<p style=\"margin-bottom: 1px; margin-top: 1px\">----------------------------------------------------------</p>";
                        lRetorno += "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" style=\"font-size: 16px; font-family: 'Times New Roman'; \">";
                        lRetorno += "<tbody>";

                        //--- Cuerpo -----------------
                        foreach (var ren in req.Param.grdCuerpo)
                        {
                            lRetorno += "<tr>";
                            lRetorno += "<td style=\"width: 38px; text-align: right; padding-right:3px; font-size: 10px; \">" + ren.CantOriginal.ToString() + "</td>";
                            lRetorno += "<td style=\"width: 100px; text-align: left; padding-right:2px; font-size: 10px; \">" + ren.Producto_Id + "</td>";
                            lRetorno += "<td style=\"width: 177px; text-align: left; padding-right:2px; font-size: 10px; \">" + ren.DescripcionProductos + "</td>";

                            lRetorno += "</tr>";
                        }

                        lRetorno += "</tbody>";
                        lRetorno += "</table>";

                        lRetorno += "<p style=\"margin-bottom: 1px; margin-top: 1px\">==================================<br>";
                        lRetorno += "<p> Los cambios se realizan dentro de los 30 días de la fecha de compra.</P><br>";
                        //-----------------------------------------------------------------




                        object[] lParam = { eEmpresa.RazonSocial };
                        // todo definir esto

                        string lCuerpo = "<HTML>";
                        lCuerpo += "<div><p>Sres " + eCliente.RazonSocial + "</p></div>";
                        lCuerpo += "<div><p>Adjunto a este correo encontrará su factura</p></div>";
                        lCuerpo += "<div><p>Agradecemos su Atención.</p></div>";
                        lCuerpo += "<div><p>Sector de Facturación de " + eEmpresa.RazonSocial.Trim() + "</p></div>";

                        lCuerpo += "<br> <br> <br> " + lRetorno;

                        lCuerpo += "</HTML>";

                        
                        string lError = "";

                        string sPara = "";
                        foreach (var Para in lPara)
                            sPara += Para.Trim() + ";";
                        try
                        {
                            bool lResultado = GeneralesValidacion.Correo.Enviar(lPara, Recursos.Recurso.GetString("Factura_de_<0>", lParam), lCuerpo, pAdjuntos, out lError, cmd);
                            if (!lResultado)
                            {
                                VentasDAL.venLogCorreo.Guardar(DateTime.Now, sPara, eMov.venMovimientos, lError, cmd.ConnectionString);
                                Generalidades.qFunctionalException.GenerarExcepcion("Error_Al_Enviar_eMail_<0>", new object[] { lError });
                            }
                            else
                                VentasDAL.venLogCorreo.Guardar(DateTime.Now, sPara, eMov.venMovimientos, "", cmd.ConnectionString);
                        }
                        catch (Exception ex)
                        {
                            VentasDAL.venLogCorreo.Guardar(DateTime.Now, sPara, eMov.venMovimientos, ex.Message, cmd.ConnectionString);
                            throw ex;
                        }
                    }

                }

                req.Existe = false;
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
