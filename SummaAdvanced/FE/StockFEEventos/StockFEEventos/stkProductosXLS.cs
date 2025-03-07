using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core;
namespace StockFEEventos
{
    public class stkProductosXLS
    {
        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargaXls(StockCommon.stkProductosXLSDS Exch, Command cmd)
        {

            StockExchange.stkCataProductosActionExchange eCat = new StockExchange.stkCataProductosActionExchange(StockExchange.stkCataProductosActionEnum.EnumstkCataProductosAction.Datos)
            {
                ProductoDesde = Exch.Principal[0].ProductoDesde,
                ProductoHasta = Exch.Principal[0].ProductoHasta,
                FamiliaDesde = Exch.Principal[0].FamiliaDesde,
                FamiliaHasta = Exch.Principal[0].FamiliaHasta,
                GrupoDesde = Exch.Principal[0].GrupoDesde,
                GrupoHasta = Exch.Principal[0].GrupoHasta
            };
            eCat = new StockExchange.stkCataProductosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eCat, cmd));
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
