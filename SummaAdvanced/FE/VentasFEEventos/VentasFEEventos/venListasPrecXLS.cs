using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
using VentasExchange;

namespace VentasFEEventos
{
    public class venListasPrecXLS
    {
        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargaXls(VentasCommon.venListaPrecXLSDS Exch, Command cmd)
        {

            VentasExchange.venListasPreciosXLSCatalogoActionExchange eCat = new venListasPreciosXLSCatalogoActionExchange(venListasPreciosXLSCatalogoActionEnum.EnumvenListasPreciosXLSCatalogoAction.Datos)
            {
                ListaDesde = Exch.Principal[0].ListaDesde,
                ListaHasta = Exch.Principal[0].ListaHasta,
                ProductoDesde = Exch.Principal[0].ProductoDesde,
                ProductoHasta = Exch.Principal[0].ProductoHasta,
                Fecha=Exch.Principal[0].Fecha
            };
            eCat = new venListasPreciosXLSCatalogoActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eCat, cmd));
            // genero el Excel con los datos del Resultado
            ClosedXML.Excel.XLWorkbook wbook = new ClosedXML.Excel.XLWorkbook();
            for (int i = 1; i < eCat.Param.Tables.Count; i++)
            {
                wbook.Worksheets.Add(eCat.Param.Tables[i], eCat.Param.Tables[i].TableName);
            }
            string lArchivo = Generalidades.Archivos.ObtenerPathTemporal(cmd.Instalacion, cmd.Empresa_Id, cmd.Usuario_Id) + "\\" + "CatalogoProductos.xlsx";
            wbook.SaveAs(lArchivo);
            string lbase64 = Convert.ToBase64String(System.IO.File.ReadAllBytes(lArchivo));
            return Generalidades.Archivos.ConvertirADatasetDownload("CatalogoProdutos", "CatalogoProdutos.xlsx", false, "xlsx", lbase64);
        }
    }
}
