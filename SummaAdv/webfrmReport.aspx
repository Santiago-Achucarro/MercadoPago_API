<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webfrmReport.aspx.cs" Inherits="SummaWeb.webfrmReport" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link id="favicon" rel="shortcut icon" type="image/png" href="imagenes/qiconnav.png" />
    <script src="Script/modernizr-2.6.2.js"></script>
    <script src="Script/jquery-1.10.2.min.js"></script>
    <script src="Script/jquery-ui-1.12.0.min.js"></script>
    <script src="Script/bootstrap.min.js"></script>
    <link href="css/bootstrap.min.css?v=2.10.16" rel="stylesheet" />
</head>
<body style="width:auto">
    <form id="form1" runat="server" style="height:100%; width:100%">
        <div style="height:100%; width:100%">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <div class="container-fluid" style="height:100%; width:100%" >
                <div id="divLabelGenerar" class="row">
                    <h6>Generando Reporte.....</h6>
                </div>
                <div class="row">
                    <div id="divreportviewer" class="form-group col-sm-12" style="display:none">
                                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Style="height:100%; width:100%" SizeToReportContent="true"  CssClass="ms-report-viewer-control" ShowToolBar="true" AsyncRendering="true">
                                </rsweb:ReportViewer>        
<%--                        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Style="height:100%; width:100%" SizeToReportContent="true" AsyncRendering="false">
                        </rsweb:ReportViewer>--%>
                    </div>
                </div>
            </div>
        </div>
       <script type="text/javascript">

        function setInputEnableState(reportViewer) {
            var lTipoRpt = sessionStorage.getItem("tiporpt");
            if (lTipoRpt != 'V') {
                // It is ok to export if the viewer is not loading and is displaying a report.
                var disableInputs = reportViewer.get_isLoading() ||
                    reportViewer.get_reportAreaContentType() !== Microsoft.Reporting.WebFormsClient.ReportAreaContent.ReportPage;
            }
        }

        function onReportViewerLoadingChanged(sender, e) {
            var lTipoRpt = sessionStorage.getItem("tiporpt");
            if (lTipoRpt != 'V') {       
                var propertyName = e.get_propertyName();
                if (propertyName === "isLoading" || propertyName === "reportAreaContentType") {
                    setInputEnableState(sender);
                }
            }
        }

        var hookedPropertyChangedEvent = false;

           function pageLoad() {
               var lTipoRpt = sessionStorage.getItem("tiporpt");
               // Si se usa la manera anterior de imprimir, viene este parámetro en null //
               if (lTipoRpt == null)
                   lTipoRpt = 'V';

               if (lTipoRpt != 'V') {
                   $("#divreportviewer").hide();
                   $("#divLabelGenerar").show();
                   if (!hookedPropertyChangedEvent) {
                       var reportViewer = $find("ReportViewer1");
                       reportViewer.add_propertyChanged(onReportViewerLoadingChanged);
                       setInputEnableState(reportViewer);
                       hookedPropertyChangedEvent = true;
                   }
                   else {
                       var reportViewer = $find("ReportViewer1");
                       var myVar = setInterval(function () {
                           var stillonLoadState = reportViewer.get_isLoading();
                           if (!stillonLoadState) {
                               clearInterval(myVar);
                               var internalViewer = reportViewer._getInternalViewer();
                               if (lTipoRpt == 'I') {
                                   window.close();
                                   window.open(internalViewer.PdfPreviewUrl, '');
                               }
                               else if (lTipoRpt == 'X') {
                                   var exportFormat = "EXCELOPENXML";
                                   reportViewer.exportReport(exportFormat);
                                   window.close();
                               }
                               else if (lTipoRpt == 'P') {
                                   var exportFormat = "PDF";
                                   reportViewer.exportReport(exportFormat);
                                   window.close();
                               }
                               else {

                               }

                           }
                       }, 500);

                   }
               }
               else {
                   $("#divLabelGenerar").hide();
                   $("#divreportviewer").show();

                   //Estas sentencias que siguen, es para dejar fija la toolbar del report viewer
                   //y bajar un poquito el area del informe
                    $("#ReportViewer1 .MenuBarBkGnd").each(function(i, item) {
                        $(item).css('position', 'fixed');
                        $(item).css('z-index', '10000');
                   });

                   $('[role="main"]').each(function (i, elem){
                        $(elem).css('margin-top', '50px');
                   });
               }
        }
        //});  
    </script>
    </form>
    
</body>



</html>
