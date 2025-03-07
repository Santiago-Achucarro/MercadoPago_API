using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using Framework.Core;
using Microsoft.Reporting.WinForms;

namespace ComprasFEEventos
{
    public class rptComEdoCta
    {

        [Generalidades.QFuncion_Condicion]
        public string Pendiente(ComprasReportesCommon.ComEdoctaDS exch, Command cmd)
        {
            if (exch.Principal[0].Pendiente)
                return "S";

            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string Enviar(ComprasReportesCommon.ComEdoctaDS exch, Command cmd)
        {

            if (exch.Principal[0].ProveedDesde != exch.Principal[0].ProveedHasta)
            {
                Generalidades.qFunctionalException.GenerarExcepcion("Solo_Se_pude_Enviar_a_Un_Proveedor");
            }

            var eProv =
            ComprasValidacion.comProveedores.Existe(exch.Principal[0].ProveedDesde, cmd);
            if (String.IsNullOrWhiteSpace(eProv.EMail))
                Generalidades.qFunctionalException.GenerarExcepcion("El_Proveedor_No_Tiene_Configurado_El_Correo");

            // Llamo a la accion de BE que Envia
            GeneralesExchange.genReportesActionExchange ExcR =
                                     new GeneralesExchange.genReportesActionExchange(GeneralesExchange.genReportesActionEnum.EnumgenReportesAction.Datos);

            var eEmp = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);
            ExcR.Reporte_Id = "COMEDOCTA";
            ExcR = new GeneralesExchange.genReportesActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcR, cmd));

            SqlServerTypes.Utilities.LoadNativeAssemblies(System.IO.Directory.GetCurrentDirectory());
            ReportViewer ReportViewer1 = new ReportViewer();

            ReportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportViewer1.LocalReport.EnableExternalImages = true;
            // AJ AGO 2017
            ReportViewer1.LocalReport.EnableHyperlinks = true;
            ReportViewer1.ShowPrintButton = true;
            string lCultura = GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd).Cultura;

            if (lCultura == "")
                lCultura = "es-AR";

            // FIN AJ
            XmlDocument lReport = new XmlDocument();
            //lReport.AppendChild()
            string lCarpeta = System.IO.Directory.GetCurrentDirectory() + "\\Reportes\\" + ExcR.Rpt + ".rdlc";

            if (!System.IO.File.Exists(lCarpeta))
            {
                object[] lParam = { lCarpeta };
                Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_El_Archivo_<0>", lParam);
            }

            lReport.Load(lCarpeta);

            // Modifico
            XmlNodeList lReportN = (XmlNodeList)lReport.GetElementsByTagName("Report");

            ((XmlElement)lReportN[0]).SetAttribute("Language", lCultura);


            XmlNodeList lLanguaje = lReport.GetElementsByTagName("Language");

            if (lLanguaje.Count == 0)
            {
                XmlNode node = lReport.CreateNode(XmlNodeType.Element, "Language", lReportN[0].NamespaceURI);
                node.InnerText = lCultura;
                ((XmlElement)lReportN[0]).AppendChild(node);
            }
            else
            {
                lLanguaje[0].InnerText = lCultura;
            }



            MemoryStream lStmReport = new MemoryStream(System.Text.UTF8Encoding.UTF8.GetBytes(lReport.InnerXml));

            ReportViewer1.LocalReport.LoadReportDefinition(lStmReport);

            CultureInfo dft = new CultureInfo(lCultura);



            ReportParameter lPA = new ReportParameter("ProveedDesde", exch.Principal[0].ProveedDesde);
            ReportViewer1.LocalReport.SetParameters(lPA);

            lPA = new ReportParameter("ProveedHasta", exch.Principal[0].ProveedHasta);
            ReportViewer1.LocalReport.SetParameters(lPA);
            lPA = new ReportParameter("Pendiente", exch.Principal[0].Pendiente.ToString());
            ReportViewer1.LocalReport.SetParameters(lPA);
            lPA = new ReportParameter("FechaDesde", exch.Principal[0].FechaDesde.ToString(dft.DateTimeFormat.ShortDatePattern, dft));
            ReportViewer1.LocalReport.SetParameters(lPA);
            lPA = new ReportParameter("FechaHasta", exch.Principal[0].FechaHasta.ToString(dft.DateTimeFormat.ShortDatePattern, dft));
            ReportViewer1.LocalReport.SetParameters(lPA);
            lPA = new ReportParameter("Empresa", cmd.Empresa_Id.ToString());
            ReportViewer1.LocalReport.SetParameters(lPA);
            GeneralesExchange.genReporteEjecutarActionExchange ExcEr =
                                   new GeneralesExchange.genReporteEjecutarActionExchange(GeneralesExchange.genReporteEjecutarActionEnum.EnumgenReporteEjecutarAction.Ejecutar);
            ExcEr.StoreProcedure = ExcR.StoreProcedure;

            string lParametrosR =
                    exch.Principal[0].ProveedDesde + "|" +
                    exch.Principal[0].ProveedHasta + "|" +
                    exch.Principal[0].Pendiente.ToString() + "|" +
                    exch.Principal[0].FechaDesde.ToString() + "|" +
                    exch.Principal[0].FechaHasta.ToString() + "|" +
                    cmd.Empresa_Id.ToString();

            ExcEr.Parametros = lParametrosR;

            ExcEr = new GeneralesExchange.genReporteEjecutarActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcEr, cmd));


            ReportDataSource lRDS = new ReportDataSource("Principal", (System.Data.DataTable)ExcEr.Param.Resultado);
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(lRDS);
            ExcEr = new GeneralesExchange.genReporteEjecutarActionExchange(GeneralesExchange.genReporteEjecutarActionEnum.EnumgenReporteEjecutarAction.Ejecutar);
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
            string lArchivo = "Estado_de_Cuenta_" + eProv.Proveed_Id + ".pdf";


            

            byte[] lRes = ReportViewer1.LocalReport.Render("PDF");

            ReportViewer1.LocalReport.ReleaseSandboxAppDomain();
            ReportViewer1.LocalReport.Dispose();
            //ReportViewer1.Dispose();

            System.IO.File.WriteAllBytes(lArchivo, lRes);
            // y envio el correo
            List<string> lPara = new List<string> { eProv.EMail };
            string lCuerpo = "Sres " + eProv.RazonSocial + ":<br><br>" +
                "&ensp;Adjunto a este correo encontrará su Estado de Cuenta<br><br>" +
                "&ensp;Saludos Cordiales<br><br>";

            List<string> pAdjuntos = new List<string> { lArchivo };


            string lError = "";
            bool lResultado = GeneralesValidacion.Correo.Enviar(lPara, Recursos.Recurso.GetString("Estado_de_Cuenta_de_<0>", new object[] { eEmp.RazonSocial }), lCuerpo, pAdjuntos, out lError, cmd);
            System.IO.File.Delete(lArchivo);

            if (!lResultado)
                Generalidades.qFunctionalException.GenerarExcepcion("Error_Al_Enviar_eMail_<0>", new object[] { lError });

            return "S";
        }
    }
}
