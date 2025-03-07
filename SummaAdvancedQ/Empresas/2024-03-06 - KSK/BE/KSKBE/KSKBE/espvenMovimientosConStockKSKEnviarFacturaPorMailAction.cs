using System;
using Framework.Core;
using KSKExchange;
using System.ServiceModel;
using KSKBE.Mail;

namespace KSKBE
{
   
    public class espvenMovimientosConStockKSKEnviarFacturaPorMailAction : Framework.Core.IAction
    {
       

        public Exchange Execute(Command cmd, Exchange exch)
        {
            VentasExchange.venMovimientosConStockActionExchange req = new VentasExchange.venMovimientosConStockActionExchange(exch);
            //VentasExchange.venMovimientosConStockActionExchange res = new VentasExchange.venMovimientosConStockActionExchange();
            
            try
            {
                KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
                ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);
                
                
                if (ds.Principal[0].Email == string.Empty)
                    return new Exchange(req);

                string email = ds.Principal[0].Email;
                string archivo = req.Segmento1C + req.Segmento2C + req.Segmento3C + req.Segmento1N.ToString("D8") + ".pdf";
                string asunto = "Factura KOSIUKO N.: " + archivo;

                string ruta = @"C:\PDFS\" + DateTime.Now.Year.ToString() + @"\" + DateTime.Now.Month.ToString("D2") + @"\";
                
                                

                //string texto = "<H4>Estimado: " + ds.Principal[0].RazonSocial + "</H4>" ;
                //texto = texto + "<p>adjunt se encuentra la factura de su compra realizada en nuestra sucursal " + req.Sucursal + " el dia " + req.Fecha.ToShortDateString() + "</p>";
                //texto = texto + "<p>Queremos aprovechar para agradecerle que haya confiado en nuestra marca y esperamos volver a verlo pronto</p><br>";
                //texto = texto + "Kowzef SA <br> Dardo Rocha xxxx <br>TEL: +54 11 98888888888 <br> Atte al cliente: cliente@kosiuko.com.ar <br> Tel: 0800 555 5555";

                //--------------------------------------------------------------------------------------------

                var lSegmentoStr =
            GeneralesValidacion.genSegmentos.SegmentoStr(req.Param
                                .Principal[0].Segmento_Id,
                                "",
                                req.Param.Principal[0].Segmento2C,
                                "", req.Param.Principal[0].Segmento4C,
                                req.Param.Principal[0].Segmento1N,
                                req.Param.Principal[0].Segmento2N,
                                req.Param.Principal[0].Segmento3N,
                                req.Param.Principal[0].Segmento4N, cmd);

                var eUsuario = GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd);
                var eSucursal = GeneralesValidacion.genSucursalesEmpr.Existe(eUsuario.Sucursal, cmd);


                string lRetorno = "";
                lRetorno += "<img alt='Imagen' height='100px' width='100px' src='data:image/png;base64," + "KOWZEF SA" + "' /><br>";
                lRetorno += "<p>";
                lRetorno += "<strong>TICKET DE CAMBIO</strong>";
                lRetorno += "<p>";
                lRetorno += "Kowzef SA" + "<br>";
                lRetorno += "Dardo Rocha 1835 San Isidro - Provincia de Buenos Aires " + "<br>";
                lRetorno += "Argentina" + "<br>";
                lRetorno += "CUIT: 30677399879" + "<br>";
                lRetorno += "RESPONSABLE INSCRIPTO"  + "<br>";
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

                EnviarMail enMail = new EnviarMail(email, asunto, lRetorno, true, ruta, archivo);

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
