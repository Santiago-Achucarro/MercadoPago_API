using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;

namespace ActivoFijoFeEventos
{
    public class ActivoFijoXLS
    {
        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargaXls(ActivoFijoCommon.ActivoFijoXlsDS Exch, Command cmd)
        {

            ActivoFijoExchange.AfiActivoFijoXLSCatalogoActionExchange eCat = new ActivoFijoExchange.AfiActivoFijoXLSCatalogoActionExchange(ActivoFijoExchange.AfiActivoFijoXLSCatalogoActionEnum.EnumAfiActivoFijoXLSCatalogoAction.Datos)
            {
                ActivoFijoDesde = Exch.Principal[0].ActivoDesde,
                ActivoFijoHasta = Exch.Principal[0].ActivoHasta
            };
            eCat = new ActivoFijoExchange.AfiActivoFijoXLSCatalogoActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eCat, cmd));
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
