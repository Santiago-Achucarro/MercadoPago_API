using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
using VentasExchange;

namespace VentasFEEventos
{
    public class venClientesXLS
    {
        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargaXls(VentasCommon.venClientesImportarXlsDS Exch, Command cmd)
        {

            venClientesXLSCatalogoActionExchange eCat = new venClientesXLSCatalogoActionExchange(venClientesXLSCatalogoActionEnum.EnumvenClientesXLSCatalogoAction.Datos)
            {
                ClienteDesde = Exch.Principal[0].ClienteDesde,
                ClienteHasta = Exch.Principal[0].ClienteHasta
            };
            eCat = new venClientesXLSCatalogoActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eCat, cmd));
            // genero el Excel con los datos del Resultado
            ClosedXML.Excel.XLWorkbook wbook = new ClosedXML.Excel.XLWorkbook();
            for (int i = 1; i < eCat.Param.Tables.Count; i++)
            {
                wbook.Worksheets.Add(eCat.Param.Tables[i], eCat.Param.Tables[i].TableName);
            }
            string lArchivo = Generalidades.Archivos.ObtenerPathTemporal(cmd.Instalacion, cmd.Empresa_Id, cmd.Usuario_Id) + "\\" + "CatalogoProductos.xlsx";
            wbook.SaveAs(lArchivo);
            string lbase64 = Convert.ToBase64String(System.IO.File.ReadAllBytes(lArchivo));
            return Generalidades.Archivos.ConvertirADatasetDownload("CatalogoClientes", "CatalogoClientes.xlsx", false, "xlsx", lbase64);
        }
    }
}
