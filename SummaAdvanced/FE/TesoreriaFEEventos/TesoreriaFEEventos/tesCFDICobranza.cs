using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace TesoreriaFEEventos
{
    public class tesCFDICobranza
    {

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarXmlFactura(TesoreriaCommon.tesTimbradoCobraDS exch, Framework.Core.Command cmd)
        {
            TesoreriaExchange.tesCFDICobranzaImprimirActionExchange eMov =
                    new TesoreriaExchange.tesCFDICobranzaImprimirActionExchange(TesoreriaExchange.tesCFDICobranzaImprimirActionEnum.EnumtesCFDICobranzaImprimirAction.Datos)
                    {
                        
                        Segmento_Id = exch.Generados[0].Segmento_Id,
                        Segmento1N = exch.Generados[0].Segmento1N,
                        Segmento2N = exch.Generados[0].Segmento2N,
                        Segmento3N = exch.Generados[0].Segmento3N,
                        Segmento4N = exch.Generados[0].Segmento4N,
                        Segmento1C = exch.Generados[0].Segmento1C,
                        Segmento2C = exch.Generados[0].Segmento2C,
                        Segmento3C = exch.Generados[0].Segmento3C,
                        Segmento4C = exch.Generados[0].Segmento4C
                    };
            eMov = new TesoreriaExchange.tesCFDICobranzaImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

            if (!eMov.Existe)
            {

                Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_el_Movimiento");

            }
            if (eMov.XML == "")
                Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");

            return Generalidades.Archivos.ConvertirADatasetDownload("XML", eMov.NombreArchivo + ".xml", false, "xml",
                        eMov.XML);


        }

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarPDFFactura(TesoreriaCommon.tesTimbradoCobraDS exch, Framework.Core.Command cmd)
        {


            TesoreriaExchange.tesCFDICobranzaImprimirActionExchange eMov =
                    new TesoreriaExchange.tesCFDICobranzaImprimirActionExchange(TesoreriaExchange.tesCFDICobranzaImprimirActionEnum.EnumtesCFDICobranzaImprimirAction.Datos)
                    {
                        Segmento_Id = exch.Generados[0].Segmento_Id,
                        Segmento1N = exch.Generados[0].Segmento1N,
                        Segmento2N = exch.Generados[0].Segmento2N,
                        Segmento3N = exch.Generados[0].Segmento3N,
                        Segmento4N = exch.Generados[0].Segmento4N,
                        Segmento1C = exch.Generados[0].Segmento1C,
                        Segmento2C = exch.Generados[0].Segmento2C,
                        Segmento3C = exch.Generados[0].Segmento3C,
                        Segmento4C = exch.Generados[0].Segmento4C
                    };
            eMov = new TesoreriaExchange.tesCFDICobranzaImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));
            if (!eMov.Existe)
            {

                Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_el_Movimiento");

            }
            if (eMov.PDF == "")
                eMov.PDF = GenerarPDF(eMov, cmd);

            return Generalidades.Archivos.ConvertirADatasetDownload("PDF", eMov.NombreArchivo + ".pdf", false, "pdf",
                        eMov.PDF);


        }

        [Generalidades.QFuncion_AccionDescargarFila]
        public Generalidades.DescargaArchivoDS DescargarXmlFacturas(TesoreriaCommon.tesTimbradoCobraDS Exch, TesoreriaCommon.tesTimbradoCobraDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            TesoreriaExchange.tesCFDICobranzaImprimirActionExchange eMov =
                    new TesoreriaExchange.tesCFDICobranzaImprimirActionExchange(TesoreriaExchange.tesCFDICobranzaImprimirActionEnum.EnumtesCFDICobranzaImprimirAction.Datos)
                    {

                        Segmento_Id = exchNoPost.grdGenerados[pIndice].Segmento_Id,
                        Segmento1N = exchNoPost.grdGenerados[pIndice].Segmento1N,
                        Segmento2N = exchNoPost.grdGenerados[pIndice].Segmento2N,
                        Segmento3N = exchNoPost.grdGenerados[pIndice].Segmento3N,
                        Segmento4N = exchNoPost.grdGenerados[pIndice].Segmento4N,
                        Segmento1C = exchNoPost.grdGenerados[pIndice].Segmento1C,
                        Segmento2C = exchNoPost.grdGenerados[pIndice].Segmento2C,
                        Segmento3C = exchNoPost.grdGenerados[pIndice].Segmento3C,
                        Segmento4C = exchNoPost.grdGenerados[pIndice].Segmento4C
                    };
            eMov = new TesoreriaExchange.tesCFDICobranzaImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

            if (!eMov.Existe)
            {

                Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_el_Movimiento");

            }
            if (eMov.XML == "")
                Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");

            return Generalidades.Archivos.ConvertirADatasetDownload("XML", eMov.NombreArchivo + ".xml", false, "xml",
                        eMov.XML);

        }

        [Generalidades.QFuncion_AccionDescargarFila]
        public Generalidades.DescargaArchivoDS DescargarPDFFacturas(TesoreriaCommon.tesTimbradoCobraDS Exch, TesoreriaCommon.tesTimbradoCobraDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            TesoreriaExchange.tesCFDICobranzaImprimirActionExchange eMov =
                    new TesoreriaExchange.tesCFDICobranzaImprimirActionExchange(TesoreriaExchange.tesCFDICobranzaImprimirActionEnum.EnumtesCFDICobranzaImprimirAction.Datos)
                    {

                        Segmento_Id = exchNoPost.grdGenerados[pIndice].Segmento_Id,
                        Segmento1N = exchNoPost.grdGenerados[pIndice].Segmento1N,
                        Segmento2N = exchNoPost.grdGenerados[pIndice].Segmento2N,
                        Segmento3N = exchNoPost.grdGenerados[pIndice].Segmento3N,
                        Segmento4N = exchNoPost.grdGenerados[pIndice].Segmento4N,
                        Segmento1C = exchNoPost.grdGenerados[pIndice].Segmento1C,
                        Segmento2C = exchNoPost.grdGenerados[pIndice].Segmento2C,
                        Segmento3C = exchNoPost.grdGenerados[pIndice].Segmento3C,
                        Segmento4C = exchNoPost.grdGenerados[pIndice].Segmento4C
                    };
            eMov = new TesoreriaExchange.tesCFDICobranzaImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

            if (!eMov.Existe)
            {

                Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_el_Movimiento");

            }
            if (eMov.PDF == "")
                eMov.PDF = GenerarPDF(eMov, cmd);

            return Generalidades.Archivos.ConvertirADatasetDownload("PDF", eMov.NombreArchivo + ".pdf", false, "pdf",
                        eMov.PDF);


        }

        public static string GenerarPDF(TesoreriaExchange.tesCFDICobranzaImprimirActionExchange req, Framework.Core.Command cmd)
        {
            GeneralesExchange.genReportesActionExchange ExcR =
                                      new GeneralesExchange.genReportesActionExchange(GeneralesExchange.genReportesActionEnum.EnumgenReportesAction.Datos);
            ExcR.Reporte_Id = "TesCfdiCobranza";

            ExcR = new GeneralesExchange.genReportesActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcR, cmd));



            SqlServerTypes.Utilities.LoadNativeAssemblies(System.IO.Directory.GetCurrentDirectory());
            Microsoft.Reporting.WebForms.ReportViewer ReportViewer1 = new Microsoft.Reporting.WebForms.ReportViewer();

            ReportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportViewer1.LocalReport.EnableExternalImages = true;
            // AJ AGO 2017
            ReportViewer1.LocalReport.EnableHyperlinks = true;
            ReportViewer1.ShowPrintButton = true;
            string lCultura = GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd).Cultura;

            if (lCultura == "")
                lCultura = "es-MX";

            // FIN AJ
            XmlDocument lReport = new XmlDocument();
            //lReport.AppendChild()
            string lCarpeta = System.IO.Directory.GetCurrentDirectory() + "\\Reportes\\" + ExcR.Rpt + ".rdlc";

            if (!System.IO.File.Exists(lCarpeta))
            {
                object[] lParam = { lCarpeta };
                Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_El_Archivo_<0>",lParam);
            }

            lReport.Load(lCarpeta);

            // Modifico
            XmlNodeList lReportN = (XmlNodeList)lReport.GetElementsByTagName("Report");

            ((XmlElement)lReportN[0]).SetAttribute("Language", lCultura);


            MemoryStream lStmReport = new MemoryStream(System.Text.UTF8Encoding.UTF8.GetBytes(lReport.InnerXml));

            ReportViewer1.LocalReport.LoadReportDefinition(lStmReport);


            ReportParameter lPA = new ReportParameter("Empresa_Id", cmd.Empresa_Id.ToString());
            ReportViewer1.LocalReport.SetParameters(lPA);

            
            lPA = new ReportParameter("Segmento_Id", req.Segmento_Id);
            ReportViewer1.LocalReport.SetParameters(lPA);

            lPA = new ReportParameter("Segmento1C", req.Segmento1C);
            ReportViewer1.LocalReport.SetParameters(lPA);
            lPA = new ReportParameter("Segmento2C", req.Segmento2C);
            ReportViewer1.LocalReport.SetParameters(lPA);
            lPA = new ReportParameter("Segmento3C", req.Segmento3C);
            ReportViewer1.LocalReport.SetParameters(lPA);
            lPA = new ReportParameter("Segmento4C", req.Segmento4C);
            ReportViewer1.LocalReport.SetParameters(lPA);
            lPA = new ReportParameter("Segmento1N", req.Segmento1N.ToString());
            ReportViewer1.LocalReport.SetParameters(lPA);
            lPA = new ReportParameter("Segmento2N", req.Segmento2N.ToString());
            ReportViewer1.LocalReport.SetParameters(lPA);
            lPA = new ReportParameter("Segmento3N", req.Segmento3N.ToString());
            ReportViewer1.LocalReport.SetParameters(lPA);
            lPA = new ReportParameter("Segmento4N", req.Segmento4N.ToString());
            ReportViewer1.LocalReport.SetParameters(lPA);


            GeneralesExchange.genReporteEjecutarActionExchange ExcEr =
                               new GeneralesExchange.genReporteEjecutarActionExchange(GeneralesExchange.genReporteEjecutarActionEnum.EnumgenReporteEjecutarAction.Ejecutar);
            ExcEr.StoreProcedure = ExcR.StoreProcedure;

            string lParametrosR =
                cmd.Empresa_Id.ToString() + "|" +
                    req.Segmento_Id + "|" + req.Segmento1N.ToString() + "|" +
                    req.Segmento2N.ToString() + "|" + req.Segmento3N.ToString() + "|" +
                    req.Segmento4N.ToString() + "|" + req.Segmento1C + "|" +
                    req.Segmento2C + "|" + req.Segmento3C + "|" + req.Segmento4C;

            ExcEr.Parametros = lParametrosR;

            ExcEr = new GeneralesExchange.genReporteEjecutarActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcEr, cmd));


            ReportDataSource lRDS = new ReportDataSource("Principal", (System.Data.DataTable)ExcEr.Param.Resultado);
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(lRDS);
            ExcEr =
                               new GeneralesExchange.genReporteEjecutarActionExchange(GeneralesExchange.genReporteEjecutarActionEnum.EnumgenReporteEjecutarAction.Ejecutar);
            ExcEr.StoreProcedure = "INF_DATOSEMPRESA";
            ExcEr.Parametros = cmd.Empresa_Id.ToString();

            ExcEr = new GeneralesExchange.genReporteEjecutarActionExchange(
                 Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcEr, cmd));


            lRDS = new ReportDataSource("Empresas", (System.Data.DataTable)ExcEr.Param.Resultado);
            ReportViewer1.LocalReport.DataSources.Add(lRDS);


            for (int i = 0; i < ExcR.Param.Procedimientos.Count; i++)
            {

                ExcEr =
                   new GeneralesExchange.genReporteEjecutarActionExchange(GeneralesExchange.genReporteEjecutarActionEnum.EnumgenReporteEjecutarAction.Ejecutar);
                ExcEr.StoreProcedure = ExcR.Param.Procedimientos[i].StoreProcedure;
                ExcEr.Parametros = lParametrosR;

                ExcEr = new GeneralesExchange.genReporteEjecutarActionExchange(
                           Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcEr, cmd));

                lRDS = new ReportDataSource(ExcR.Param.Procedimientos[i].DataTable, (System.Data.DataTable)ExcEr.Param.Resultado);
                ReportViewer1.LocalReport.DataSources.Add(lRDS);

            }


            ReportViewer1.LocalReport.GetDefaultPageSettings();
            ReportViewer1.ShowZoomControl = true;
            //ReportViewer1.AsyncRendering = false;


            // LAS ASIGNO PARA EL WINDOWS
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lCultura);
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(lCultura);


            byte[] lRes = ReportViewer1.LocalReport.Render("PDF");


            ReportViewer1.LocalReport.ReleaseSandboxAppDomain();
            ReportViewer1.LocalReport.Dispose();
            //ReportViewer1.Dispose();

            System.IO.File.WriteAllBytes(req.NombreArchivo + ".pdf", lRes);

            return Generalidades.Archivos.ConvertirACampoDownload("Pdf", req.NombreArchivo + ".pdf", false, "pdf",
                   Convert.ToBase64String(System.IO.File.ReadAllBytes(req.NombreArchivo + ".pdf")));

        }
    }
}
