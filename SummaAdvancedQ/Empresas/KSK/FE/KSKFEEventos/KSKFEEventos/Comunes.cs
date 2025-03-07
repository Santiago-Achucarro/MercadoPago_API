using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSKFEEventos
{
    internal class Comunes
    {
        internal static string HTMLTicket(VentasCommon.venMovimientosConStockDS pCommonDS, VentasCommon.venMovimientosConStockDS pCommonDSNoPost, int pIndice, Command cmd)

        {
            string lRetorno = "";
            //decimal lTotal = 0;
            //decimal lSubtotal = 0;


            var lSegmentoStr =
            GeneralesValidacion.genSegmentos.SegmentoStr(pCommonDS
                                .Principal[0].Segmento_Id, 
                                "", 
                                pCommonDS.Principal[0].Segmento2C, 
                                "", pCommonDS.Principal[0].Segmento4C, 
                                pCommonDS.Principal[0].Segmento1N, 
                                pCommonDS.Principal[0].Segmento2N, 
                                pCommonDS.Principal[0].Segmento3N, 
                                pCommonDS.Principal[0].Segmento4N, cmd);

            var eEmpresa = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);
            var eUsuario = GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd);
            var eSucursal = GeneralesValidacion.genSucursalesEmpr.Existe(eUsuario.Sucursal, cmd);

            lRetorno += "<html><body style=\"font - size: 16px; font - family: 'Times New Roman'; \">";
            //lRetorno += "<FONT SIZE =\"2p\">";

            if (pCommonDS.Principal[0].Segmento1C == "F")
            {
                lRetorno += "<img alt='Imagen' height='100px' width='100px' src='data:image/png;base64," + eEmpresa.Logo + "' /><br>";
                lRetorno += "<p>";
                lRetorno += "<strong>TICKET DE CAMBIO</strong>";
                lRetorno += "<p>";
                lRetorno += eEmpresa.RazonSocial + "<br>";
                lRetorno += eEmpresa.Calle + " " + eEmpresa.NoExterior + " " + eEmpresa.Localidad + " " + "<br>";
                lRetorno += eEmpresa.DescripcionProvincias + " " + "<br>";
                lRetorno += "CUIT:" + eEmpresa.Cuit + " IIBB:" + eEmpresa.NumeroIIBB + "<br>";
                lRetorno += eEmpresa.CondFiscal + "<br>";
                lRetorno += "----------------------------------------------------------<br>";
                lRetorno += pCommonDS.Principal[0].Fecha.Day.ToString("00") + "/" + pCommonDS.Principal[0].Fecha.Month.ToString("00") + "/" + pCommonDS.Principal[0].Fecha.Year.ToString("0000") + "  ";
                lRetorno += pCommonDS.Principal[0].Fecha.Hour.ToString("00") + ":" + pCommonDS.Principal[0].Fecha.Minute.ToString("00") + ":" + pCommonDS.Principal[0].Fecha.Second.ToString("00") + "  ";
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
//                lRetorno += "<td style=\"width: 33px; text-align: right; padding-right:2px; \">Unit</td>";
//                lRetorno += "<td style=\"width: 55px; text-align: right; padding-right:0px; \">Total</td>";
                lRetorno += "</tr>";
                lRetorno += "</tbody>";
                lRetorno += "</table>";
                lRetorno += "<p style=\"margin-bottom: 1px; margin-top: 1px\">----------------------------------------------------------</p>";
                lRetorno += "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" style=\"font-size: 16px; font-family: 'Times New Roman'; \">";
                lRetorno += "<tbody>";

                

                //nEspBlancos = 8;
                foreach (var ren in pCommonDS.grdCuerpo)
                {
                    /*
                    string EBCant = "";
                    nEspBlancos -= ren.CantOriginal.ToString().Length;
                    for (int i = 0; i < nEspBlancos; i++)
                        EBCant += "&nbsp";


                    //string EBP_ID = "&nbsp";
                    //nEspBlancos = 28;
                    //nEspBlancos -= ren.Producto_Id.ToString().Length;
                    //for (int i = 0; i < nEspBlancos; i++)
                    //    EBP_ID += "&nbsp";

                    string EBPF = "&nbsp";
                    nEspBlancos = 12;
                    nEspBlancos -= ren.PrecioForm.ToString().Length;
                    for (int i = 0; i < nEspBlancos; i++)
                        EBPF += "&nbsp";

                    //string EBBonif = "&nbsp";
                    //nEspBlancos = 6;
                    //nEspBlancos -= ren.Bonificacion.ToString().Length;
                    //for (int i = 0; i < nEspBlancos; i++)
                    //    EBBonif += "&nbsp";

                    string EBDescrip = "&nbsp";
                    nEspBlancos = 35;
                    nEspBlancos -= ren.DescripcionProductos.Length;
                    for (int i = 0; i < nEspBlancos; i++)
                        EBDescrip += "&nbsp";

                    //string EBBonif = "&nbsp";
                    //nEspBlancos = 6;
                    //nEspBlancos -= ren.SubTotal.ToString().Length;
                    //for (int i = 0; i < nEspBlancos; i++)
                    //    EBBonif += "&nbsp";

                    string EBSTFI = "&nbsp";
                    nEspBlancos = 12;
                    nEspBlancos -= ren.SubTotal.ToString().Length;
                    for (int i = 0; i < nEspBlancos; i++)
                        EBSTFI += "&nbsp";


                    //if (ren.Producto_Id.Length > 13)
                    //{
                    //    lRetorno += ren.Producto_Id.Substring(0, 13) + EBP_ID + ren.PrecioForm.ToString() + EBPF + ren.Bonificacion.ToString() + EBBonif + lSubtotal.ToString() + "<br>";
                    //    lRetorno += ren.Producto_Id.Substring(13, ren.Producto_Id.Length - 13) + "</p>";

                    //}
                    //else

                    lRetorno += "<p>" + EBCant + ren.CantOriginal.ToString() + EBDescrip + ren.DescripcionProductos + EBPF + ren.PrecioForm.ToString() + EBSTFI + ren.SubTotalFormImpuesto.ToString() + "</p>";

                    nEspBlancos = 8;
                    */
                    

                    lRetorno += "<tr>";
                    lRetorno += "<td style=\"width: 38px; text-align: right; padding-right:3px; font-size: 10px; \">" + ren.CantOriginal.ToString() + "</td>";
                    lRetorno += "<td style=\"width: 100px; text-align: left; padding-right:2px; font-size: 10px; \">" + ren.Producto_Id + "</td>";
                    lRetorno += "<td style=\"width: 177px; text-align: left; padding-right:2px; font-size: 10px; \">" + ren.DescripcionProductos + "</td>";
                    //lRetorno += "<td style=\"width: 33px; text-align: right; padding-right:2px; \">" + ren.PrecioForm.ToString() + "</td>";
                    //lRetorno += "<td style=\"width: 55px; text-align: right; padding-right:0px; \">" + ren.SubTotalFormImpuesto.ToString() + "</td>";
                    lRetorno += "</tr>";

                }
                lRetorno += "</tbody>";
                lRetorno += "</table>";

                if (pCommonDS.Principal[0].Segmento3C == "A")
                {
                    string EBSTFI = "&nbsp";
                    //nEspBlancos = 50;
                    //nEspBlancos -= pCommonDS.Principal[0].SubTotal.ToString().Length;
                    //for (int i = 0; i < nEspBlancos; i++)
                    //    EBSTFI += "&nbsp";

                    //lRetorno += "----------------------------------------------------------<br>";
                    //lRetorno += "SubTotal:" + EBSTFI + pCommonDS.Principal[0].SubTotal.ToString() + "<br>";

                    //pCommonDS.grdImpuestos.ToList().ForEach(i =>
                    //{
                    //    lRetorno += i.DescripcionImpuestos + " " + i.Importe.ToString() + "<br>";
                    //});
                }

                lRetorno += "<p style=\"margin-bottom: 1px; margin-top: 1px\">==================================<br>";
                // lRetorno += "<strong>Total: " + pCommonDS.Principal[0].Importe.ToString("###,###,###.00") + "</strong><br>";
                lRetorno += "<p> Los cambios se realizan dentro de los 30 días de la fecha de compra.</P><br>";
                //lRetorno += "</p>";
                //lRetorno += "<p style=\"margin-top: 1px\">" + GeneralidadesFEAdv.Varios.NroALetra(pCommonDS.Principal[0].Importe, false, pCommonDS.Principal[0].Moneda_Id, pCommonDS.Principal[0].DescripcionMonedas, eEmpresa.DescripcionPaises, eEmpresa.Moneda_Id) + "</p>";

                VentasExchange.venClieHabitualActionExchange exchClieH = VentasValidacion.venClieHabitual.ExistePosteadoyActivo(pCommonDS.Principal[0].Cliente_Id, pCommonDS.Principal[0].Sucursal, cmd);


                GeneralesExchange.genMonedasActionExchange exchMon = GeneralesValidacion.genMonedas.ExistePosteadoyActiva(pCommonDS.Principal[0].Moneda_Id, cmd);


                //lRetorno += "<img alt='Imagen' height='100px' width='100px' src='data:image/png;base64," + Convert.FromBase64String(GeneralidadesFEAdv.Varios.QrCode("https://www.afip.gob.ar/fe/qr/?p=" + GeneralidadesFEAdv.Varios.ToBase64(GeneralidadesFEAdv.Varios.ArmarJSONFEAR(1, pCommonDS.Principal[0].Fecha.Date, eEmpresa.Cuit, pCommonDS.Principal[0].Segmento2C, pCommonDS.venMovFiscal[0].Comprobante_Id, pCommonDS.Principal[0].Segmento1N, pCommonDS.Principal[0].Importe, exchMon.CodigoFiscal, pCommonDS.Principal[0].Cambio, exchClieH.TipoDoc, exchClieH.CUIT.Replace("-", ""), "E", pCommonDS.venMovFiscal[0].ClaveFiscal)))) + "' /><br>";


                //lRetorno += "<img alt='Imagen' src='data:image/jpeg;base64," + GeneralidadesFEAdv.Varios.QrCode("https://www.afip.gob.ar/fe/qr/?p=" + GeneralidadesFEAdv.Varios.ToBase64(GeneralidadesFEAdv.Varios.ArmarJSONFEAR(1, pCommonDS.Principal[0].Fecha.Date, eEmpresa.Cuit, pCommonDS.Principal[0].Segmento2C, 81, pCommonDS.Principal[0].Segmento1N, pCommonDS.Principal[0].Importe, exchMon.CodigoFiscal, pCommonDS.Principal[0].Cambio, exchClieH.TipoDoc, exchClieH.CUIT.Replace("-", ""), "E", "12345678901234")), 10) + "' /><br>";

                //lRetorno += "<p>----------------------------------------------------------</ p>";

            }
            else
            {
                lRetorno += "<p>" + eEmpresa.RazonSocial + "<br>";
                lRetorno += eEmpresa.Calle + " " + eEmpresa.NoExterior + " " + eEmpresa.Localidad + " " + "<br>";
                lRetorno += eEmpresa.DescripcionProvincias + " " + "<br>";
                lRetorno += "<p>************** T I C K E T **************</p>";
                lRetorno += "<p>----------------------------------------------------------</ p>";
                lRetorno += "<p>Ticket:" + lSegmentoStr.SegmentoSTR + "<br>";
                lRetorno += "<Fecha:" + pCommonDS.Principal[0].Fecha.Day.ToString("00") + "/" + pCommonDS.Principal[0].Fecha.Month.ToString("00") + "/" + pCommonDS.Principal[0].Fecha.Year.ToString("0000") + "<br>";
                lRetorno += "Hora:" + pCommonDS.Principal[0].Fecha.Hour.ToString("00") + ":" + pCommonDS.Principal[0].Fecha.Minute.ToString("00") + ":" + pCommonDS.Principal[0].Fecha.Second.ToString("00") + "</p>";
                lRetorno += "<p>----------------------------------------------------------</ p>";
                //lRetorno += "RFC:" + eEmpresa.Cuit + "</p>";
                lRetorno += "<p> </p>";
                lRetorno += "<p>" + eSucursal.Descripcion + "<br> ";
                lRetorno += eSucursal.Direccion + "<br>";
                lRetorno += eSucursal.Localidad + " " + eSucursal.DescripcionProvincias + "" + eSucursal.CodigoPostal + "<br>";
                lRetorno += "Te:" + eSucursal.Telefono + "</p>";
                lRetorno += "<p> </p>";
                //lRetorno += "<p>Vendedor:" + pCommonDS.Principal[0].Vendedor_Id + "<br>";
                //lRetorno += pCommonDS.Principal[0].NombreFantasia + "</p>";
                lRetorno += "<p> </p>";

                //int nEspBlancos = 22;
                string EB = "";
                //for (int i = 0; i < nEspBlancos; i++)
                //    EB += "&nbsp";

                lRetorno += "<p style=\"margin-bottom: 1px; margin-top: 1px\">----------------------------------------------------------</p>";
                lRetorno += "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" style=\"font-size: 16px; font-family: 'Times New Roman'; \">";
                lRetorno += "<tbody>";
                lRetorno += "<tr>";
                lRetorno += "<td style=\"width: 38px; text-align: right; padding-right:3px; \">Cant.</td>";
                lRetorno += "<td style=\"width: 177px; text-align: left; padding-right:2px; \">Descripción</td>";
                lRetorno += "<td style=\"width: 33px; text-align: right; padding-right:2px; \">Unit</td>";
                lRetorno += "<td style=\"width: 55px; text-align: right; padding-right:0px; \">Total</td>";
                lRetorno += "</tr>";
                lRetorno += "</tbody>";
                lRetorno += "</table>";
                lRetorno += "<p style=\"margin-bottom: 1px; margin-top: 1px\">----------------------------------------------------------</p>";
                lRetorno += "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" style=\"font-size: 16px; font-family: 'Times New Roman'; \">";
                lRetorno += "<tbody>";

                //nEspBlancos = 8;
                //EB = "";
                foreach (var ren in pCommonDS.grdCuerpo)
                {
                    /*
                    nEspBlancos -= ren.CantOriginal.ToString().Length;
                    for (int i = 0; i < nEspBlancos; i++)
                        EB += "&nbsp";

                    //lSubtotal = ren.CantOriginal * Generalidades.Auxiliares.Redondear((ren.PrecioForm * (1 - ren.Bonificacion / 100)), 2);
                    //lTotal += lSubtotal;

                    //if (ren.DescripcionProductos.Length > 29)
                    //{
                    //    lRetorno += "<p>" + EB + ren.CantOriginal.ToString() + " " + ren.DescripcionProductos.Substring(0, 29) + "<br>";
                    //    //10 espacios para los numeros
                    //    lRetorno += "&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp" + ren.DescripcionProductos.Substring(29, ren.DescripcionProductos.Length - 29) + "<br>";

                    //}
                    //else
                    //{
                    //    lRetorno += "<p>" + EB + ren.CantOriginal.ToString() + " " + ren.DescripcionProductos + " " + "<br>";
                    //}

                    string EBP_ID = "&nbsp";
                    nEspBlancos = 28;
                    nEspBlancos -= ren.Producto_Id.ToString().Length;
                    for (int i = 0; i < nEspBlancos; i++)
                        EBP_ID += "&nbsp";

                    string EBPF = "&nbsp";
                    nEspBlancos = 10;
                    nEspBlancos -= ren.PrecioForm.ToString().Length;
                    for (int i = 0; i < nEspBlancos; i++)
                        EBPF += "&nbsp";

                    //string EBBonif = "&nbsp";
                    //nEspBlancos = 6;
                    //nEspBlancos -= ren.Bonificacion.ToString().Length;
                    //for (int i = 0; i < nEspBlancos; i++)
                    //    EBBonif += "&nbsp";

                    string EBBonif = "&nbsp";
                    nEspBlancos = 6;
                    nEspBlancos -= ren.SubTotal.ToString().Length;
                    for (int i = 0; i < nEspBlancos; i++)
                        EBBonif += "&nbsp";


                    nEspBlancos = 10;
                    nEspBlancos -= ren.SubTotal.ToString().Length;
                    for (int i = 0; i <= nEspBlancos; i++)
                        EB += "&nbsp";

                    //if (ren.Producto_Id.Length > 13)
                    //{
                    //    lRetorno += ren.Producto_Id.Substring(0, 13) + EBP_ID + ren.PrecioForm.ToString() + EBPF + ren.Bonificacion.ToString() + EBBonif + lSubtotal.ToString() + "<br>";
                    //    lRetorno += ren.Producto_Id.Substring(13, ren.Producto_Id.Length - 13) + "</p>";

                    //}
                    //else

                    lRetorno += "<p>" + ren.CantOriginal.ToString() + EBBonif + ren.DescripcionProductos + EBP_ID + ren.PrecioForm.ToString() + EBPF + ren.SubTotalFormImpuesto.ToString() + "</p>";





                    EB = "";
                    nEspBlancos = 8;
                    */

                    lRetorno += "<tr>";
                    lRetorno += "<td style=\"width: 38px; text-align: right; padding-right:3px; \">" + ren.CantOriginal.ToString() + "</td>";
                    lRetorno += "<td style=\"width: 177px; text-align: left; padding-right:2px; \">" + ren.DescripcionProductos + "</td>";
                    lRetorno += "<td style=\"width: 33px; text-align: right; padding-right:2px; \">" + ren.PrecioForm.ToString() + "</td>";
                    lRetorno += "<td style=\"width: 55px; text-align: right; padding-right:0px; \">" + ren.SubTotalFormImpuesto.ToString() + "</td>";
                    lRetorno += "</tr>";

                }
                lRetorno += "</tbody>";
                lRetorno += "</table>";

                //nEspBlancos = 10;

                //nEspBlancos -= pCommonDS.Principal[0].Importe.ToString().Length;
                //for (int i = 0; i < nEspBlancos; i++)
                //    EB += "&nbsp";

                lRetorno += "<p>----------------------------------------------------------</ p>";
                lRetorno += "<p><strong>Total:" + EB + pCommonDS.Principal[0].Importe.ToString() + "</strong></p>";
                lRetorno += "<p> </p>";
                lRetorno += "<p>" + GeneralidadesFEAdv.Varios.NroALetra(pCommonDS.Principal[0].Importe, false, pCommonDS.Principal[0].Moneda_Id, pCommonDS.Principal[0].DescripcionMonedas, eEmpresa.DescripcionPaises, eEmpresa.Moneda_Id) + "</p>";
                lRetorno += "<p> </p>";
                lRetorno += "<p>DOCUMENTO NO VÁLIDO COMO FACTURA</ p>";
                lRetorno += "<p>";
                lRetorno += "</p>";

                lRetorno += "<p>----------------------------------------------------------</ p>";
            }
            lRetorno += "</FONT></body></html>";

            ///El string debe representar la estructura de una página HTML
            return lRetorno;

        }
    }
}
