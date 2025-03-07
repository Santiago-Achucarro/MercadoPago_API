using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ionic.Zip;
using System.IO;

namespace VentasFEEventos
{
    public class venImprimirComprobantes
    {
        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarXmlFactura(VentasCommon.venMovimientosImprimirDS exch, Framework.Core.Command cmd)
        {
            if(exch.Principal[0].ComprobanteHasta>exch.Principal[0].Segmento1N)
            {
                ZipFile lZip = new ZipFile();
                for (int i = exch.Principal[0].Segmento1N; i <= exch.Principal[0].ComprobanteHasta; i++)
                {
                    VentasExchange.venMovimientosImprimirActionExchange eMov =
                            new VentasExchange.venMovimientosImprimirActionExchange(VentasExchange.venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction.Datos)
                            {
                                Segmento_Id = exch.Principal[0].Segmento_Id,
                                Segmento1N = i,
                                Segmento2N = exch.Principal[0].Segmento2N,
                                Segmento3N = exch.Principal[0].Segmento3N,
                                Segmento4N = exch.Principal[0].Segmento4N,
                                Segmento1C = exch.Principal[0].Segmento1C,
                                Segmento2C = exch.Principal[0].Segmento2C,
                                Segmento3C = exch.Principal[0].Segmento3C,
                                Segmento4C = exch.Principal[0].Segmento4C
                            };
                    eMov = new VentasExchange.venMovimientosImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

                  
                    if (eMov.Existe && eMov.XML!="" && !eMov.Anulado)
                    {
                        Directory.CreateDirectory("XMLS_Temporal");
                        string lRuta = @"XMLS_Temporal\" + eMov.NombreArchivo + ".xml";
                        File.WriteAllText(lRuta, System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(eMov.XML)));
                        lZip.AddFile(lRuta);

                    }
                }
                lZip.Save(@"XMLS_Temporal\XMLs.zip");
                byte[] buffer = File.ReadAllBytes(@"XMLS_Temporal\XMLs.zip");
                return Generalidades.Archivos.ConvertirADatasetDownload("XMLs", "XMLs.zip", false, "zip",
                            Convert.ToBase64String(buffer));
            }
            else
            {
                VentasExchange.venMovimientosImprimirActionExchange eMov =
                        new VentasExchange.venMovimientosImprimirActionExchange(VentasExchange.venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction.Datos)
                        {
                            Segmento_Id = exch.Principal[0].Segmento_Id,
                            Segmento1N = exch.Principal[0].Segmento1N,
                            Segmento2N = exch.Principal[0].Segmento2N,
                            Segmento3N = exch.Principal[0].Segmento3N,
                            Segmento4N = exch.Principal[0].Segmento4N,
                            Segmento1C = exch.Principal[0].Segmento1C,
                            Segmento2C = exch.Principal[0].Segmento2C,
                            Segmento3C = exch.Principal[0].Segmento3C,
                            Segmento4C = exch.Principal[0].Segmento4C
                        };
                eMov = new VentasExchange.venMovimientosImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

                if (!eMov.Existe)
                {

                    Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_el_Movimiento");

                }
                /*
                if (cmd.CodigoConsulta == "")
                {
                    if (eMov.Anulado)
                        Generalidades.qQuestionException.GenerarExcepcion("Este_Movimiento_Esta_Anulado_Descarga_Igual_el_Xml", "SI");
                }
                */
                if (eMov.XML == "")
                    Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");

                return Generalidades.Archivos.ConvertirADatasetDownload("XML", eMov.NombreArchivo + ".xml", false, "xml",
                            eMov.XML);
            }

        }

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarPDFFactura(VentasCommon.venMovimientosImprimirDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Segmento1N < exch.Principal[0].ComprobanteHasta)
            {
                ZipFile lZip = new ZipFile();
                Directory.CreateDirectory("PDFs_Temporal");
                byte[] Buffer;
                for (int i=exch.Principal[0].Segmento1N;i<=exch.Principal[0].ComprobanteHasta;i++)
                {
                    VentasExchange.venMovimientosImprimirActionExchange eMov =
                        new VentasExchange.venMovimientosImprimirActionExchange(VentasExchange.venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction.Datos)
                        {
                            Segmento_Id = exch.Principal[0].Segmento_Id,
                            Segmento1N = i,
                            Segmento2N = exch.Principal[0].Segmento2N,
                            Segmento3N = exch.Principal[0].Segmento3N,
                            Segmento4N = exch.Principal[0].Segmento4N,
                            Segmento1C = exch.Principal[0].Segmento1C,
                            Segmento2C = exch.Principal[0].Segmento2C,
                            Segmento3C = exch.Principal[0].Segmento3C,
                            Segmento4C = exch.Principal[0].Segmento4C
                        };

                    eMov = new VentasExchange.venMovimientosImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

                    if (eMov.Existe && eMov.PDF!="" && !eMov.Anulado)
                    {
                        string lRuta = @"PDFs_Temporal\" + eMov.NombreArchivo + ".pdf";
                        Buffer = Convert.FromBase64String(eMov.PDF);
                        File.WriteAllBytes(lRuta, Buffer);
                        lZip.AddFile(lRuta);
                    }


                }
                lZip.Save(@"PDFs_Temporal\PDFs.zip");
                Buffer = File.ReadAllBytes(@"PDFs_Temporal\PDFs.zip");
                return Generalidades.Archivos.ConvertirADatasetDownload("ZIP", @"PDFs_Temporal\PDFs.zip", false, "zip",
                            Convert.ToBase64String(Buffer));
            }
            else
            {
                VentasExchange.venMovimientosImprimirActionExchange eMov =
                        new VentasExchange.venMovimientosImprimirActionExchange(VentasExchange.venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction.Datos)
                        {
                            Segmento_Id = exch.Principal[0].Segmento_Id,
                            Segmento1N = exch.Principal[0].Segmento1N,
                            Segmento2N = exch.Principal[0].Segmento2N,
                            Segmento3N = exch.Principal[0].Segmento3N,
                            Segmento4N = exch.Principal[0].Segmento4N,
                            Segmento1C = exch.Principal[0].Segmento1C,
                            Segmento2C = exch.Principal[0].Segmento2C,
                            Segmento3C = exch.Principal[0].Segmento3C,
                            Segmento4C = exch.Principal[0].Segmento4C
                        };
                eMov = new VentasExchange.venMovimientosImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

                if (!eMov.Existe)
                {

                    Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_el_Movimiento");

                }
                /*
                if (cmd.CodigoConsulta == "")
                {
                    if (eMov.Anulado)
                        Generalidades.qQuestionException.GenerarExcepcion("Este_Movimiento_Esta_Anulado_Lo_Imprime_Igual", "SI");
                }
                */
                if (eMov.PDF == "")
                    Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");

                return Generalidades.Archivos.ConvertirADatasetDownload("PDF", eMov.NombreArchivo + ".pdf", false, "pdf",
                            eMov.PDF);

            }
        }

        [Generalidades.QFuncion_Condicion]
        public string Continuar(VentasCommon.venMovimientosImprimirDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].ComprobanteHasta >= exch.Principal[0].Segmento1N || 
            (exch.Principal[0].ComprobanteHasta<0 && 
                -exch.Principal[0].ComprobanteHasta>=exch.Principal[0].Segmento1N))
                return "S";
            else
                return "N";

        }


        [Generalidades.QFuncion_EnviarMail]
        public Generalidades.CorreoDS Enviar(VentasCommon.venMovimientosImprimirDS pCommonDS /*, VentasCommon.venMovimientosImprimirDS pCommonDSNoPost, int pIndice*/, Framework.Core.Command cmd)
        {
            Generalidades.CorreoDS lRetorno = new Generalidades.CorreoDS();
            VentasExchange.venMovimientosEnviarActionExchange eMov = new VentasExchange.venMovimientosEnviarActionExchange(VentasExchange.venMovimientosEnviarActionEnum.EnumvenMovimientosEnviarAction.Datos)
            {
                Segmento_Id = pCommonDS.Principal[0].Segmento_Id,
                Segmento1N = pCommonDS.Principal[0].Segmento1N,
                Segmento2N = pCommonDS.Principal[0].Segmento2N,
                Segmento3N = pCommonDS.Principal[0].Segmento3N,
                Segmento4N = pCommonDS.Principal[0].Segmento4N,
                Segmento1C = pCommonDS.Principal[0].Segmento1C,
                Segmento2C = pCommonDS.Principal[0].Segmento2C,
                Segmento3C = pCommonDS.Principal[0].Segmento3C,
                Segmento4C = pCommonDS.Principal[0].Segmento4C
            };
            eMov = new VentasExchange.venMovimientosEnviarActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

            lRetorno.Principal.AddPrincipalRow(eMov.Param.Cabecera[0].Asunto, eMov.Param.Cabecera[0].Cuerpo,
                    eMov.Param.Cabecera[0].Destinatarios, eMov.Param.Cabecera[0].DestinatariosCopia, eMov.Param.Cabecera[0].DestinatariosCopiaOculta, false);
            foreach (var ren in eMov.Param.Adjuntos)
            {
                lRetorno.Adjuntos.AddAdjuntosRow(ren.Renglon, ren.Guid, ren.NombreArchivo, ren.Extension,
                      ren.ArchivoBase64, ren.Estado);
            }
            //...... 
            //...... 
            // Los destinatarios van separados por ';'
            // El datatable de adjuntos tiene la misma estructura y forma de utilizarse que el datatable adjuntos de cualquier entidad o movimiwento
            // Se puede usar el método Generalidades.Auxiliares.AdjuntosCompletarDatos(NombreTabla, Identity, Path, cmd) para completar el datatable de ajuntos del mail, con los adjuntos asociados a la entidad o movimiento
            return lRetorno;

        }

        [Generalidades.QFuncion_Condicion]
        public string Anulada(VentasCommon.venMovimientosImprimirDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venMovimientosActionExchange eMov = new VentasExchange.venMovimientosActionExchange(VentasExchange.venMovimientosActionEnum.EnumvenMovimientosAction.DatosSeg)
            {
                Segmento_Id = exch.Principal[0].Segmento_Id,
                Segmento1N = exch.Principal[0].Segmento1N,
                Segmento2N = exch.Principal[0].Segmento2N,
                Segmento3N = exch.Principal[0].Segmento3N,
                Segmento4N = exch.Principal[0].Segmento4N,
                Segmento1C = exch.Principal[0].Segmento1C,
                Segmento2C = exch.Principal[0].Segmento2C,
                Segmento3C = exch.Principal[0].Segmento3C,
                Segmento4C = exch.Principal[0].Segmento4C
            };
            eMov = new VentasExchange.venMovimientosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

            return (eMov.Anulado ? "S" : "N");
        }

    }
}
