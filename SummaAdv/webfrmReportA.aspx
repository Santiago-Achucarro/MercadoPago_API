<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webfrmReport.aspx.cs" Inherits="SummaWeb.webfrmReport" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Print Local Report RDLC without Previewing nor Print Dialog!</title>

    <style>
        body{font: 13px 'Segoe UI', Tahoma, Arial, Helvetica, sans-serif;background:#ddd;color:#333;margin:0;}
        h1{background:#333;color:#fff;padding:10px;font: 29px 'Segoe UI Light', 'Tahoma Light', 'Arial Light', 'Helvetica Light', sans-serif;}
        .myRow{width:auto;padding:0 20px 0 20px;height:auto;}
    </style>

</head>
<body>
    <%-- Store User's SessionId --%>
    <input type="hidden" id="sid" name="sid" value="<%=Session.SessionID%>" />

    <form id="form1" runat="server">

    <h1>ReportViewer with Cross-Browser Client Print</h1>
        
    <div class="myRow" style="clear:both" id="pnlReport">    
        <br /><br />        
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Height="450px" Width="960px">
        </rsweb:ReportViewer>    
    </div>
    
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>

    </form>

    <%-- Add Reference to jQuery at Google CDN --%>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js"></script>

    
    <%-- Register the WebClientPrint script code --%>
    <%-- Neodynamic.SDK.Web.WebClientPrint.CreateScript()--%>

    <script type="text/javascript">
        $(document).ready(function () {
            
            <%-- hide built-in print button from ReportViewer toolbar --%>
            $('table[title="Print"]').hide();

            
            <%-- embed custom DropDownList for listing installed client printers and print image button --%>
            $('#ReportViewer1.ClientID_ctl05:last-child').children().append('<div class=" " style="display:inline-block;font-family:Verdana;font-size:8pt;vertical-align:top;"><table cellpadding="0" cellspacing="0" style="display:inline;"><tbody><tr><td height="28px"><select name="ddlClientPrinters" id="ddlClientPrinters" style="font-family:Verdana;font-size:8pt;" title="Select Printer"><option>Loading printers...</option></select></td><td width="4px"></td><td height="28px"><div><div id="<%=ReportViewer1.ClientID%>_Custom_Print_Button" style="border: 1px solid transparent; background-color: transparent; cursor: default;"><table title="Print"><tbody><tr><td><input type="image" title="Print" src="Reserved.ReportViewerWebControl.axd?OpType=Resource&Name=Microsoft.Reporting.WebForms.Icons.Print.gif" alt="Refresh" style="border-style:None;height:16px;width:16px;border-width:0px;"></td></tr></tbody></table></div></div></td></tr></tbody></table></div>');
            <%-- mouse hover effect for our new print image button --%>
            $('#ReportViewer1.ClientID_Custom_Print_Button').hover(function() { //hover style
                    $(this).css({'border': '1px solid #336699', 'background-color': '#DDEEF7', 'cursor': 'pointer'});               
            }, function() { //normal style
                $(this).css({'border': '1px solid transparent', 'background-color': 'transparent', 'cursor': 'default'})
            });


            <%-- load client printers through WebClientPrint --%>
            jsWebClientPrint.getPrinters();

            <%-- add click handler for print button --%>
            $('#<%=ReportViewer1.ClientID%>_Custom_Print_Button').click(function() {
                jsWebClientPrint.print('printerName=' + $('#ddlClientPrinters').val()); 
            });
        });

        <%-- Time delay we'll wait for getting client printer names --%>
        var wcppGetPrintersDelay_ms = 5000; //5 sec

        function wcpGetPrintersOnSuccess(){
            <%-- Display client installed printers --%>
            if(arguments[0].length > 0){
                var p=arguments[0].split("|");
                var options = '<option>Default Printer</option>';
                for (var i = 0; i < p.length; i++) {
                    options += '<option>' + p[i] + '</option>';
                }
                $('#ddlClientPrinters').html(options);                                            
            }else{
                alert("No printers are installed in your system.");
            }
        }

        function wcpGetPrintersOnFailure() {
            <%-- Do something if printers cannot be got from the client --%>
            alert("No printers are installed in your system.");
        }

    </script>

</body>
</html>
