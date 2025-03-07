using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using Framework.Core;

namespace StockFEEventos
{
    public class stkConsStock
    {
        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargaXls(StockCommon.stkExistenciasXDepositoDS Exch, Command cmd)
        {

            // genero el Excel con los datos del Resultado
            ClosedXML.Excel.XLWorkbook wbook = new ClosedXML.Excel.XLWorkbook();
            wbook.Worksheets.Add(Exch.Resultado);
            string lArchivo = Generalidades.Archivos.ObtenerPathTemporal(cmd.Instalacion, cmd.Empresa_Id, cmd.Usuario_Id) +"\\" + "ConsultaStock.xlsx";
            wbook.SaveAs(lArchivo);
            string lbase64 = Convert.ToBase64String(System.IO.File.ReadAllBytes(lArchivo));
            return Generalidades.Archivos.ConvertirADatasetDownload("ConsultaStock", "ConsultaStock.xlsx", false, "xlsx", lbase64);
        }

        [Generalidades.QFuncion_Condicion]
        public string PuedeDescargar(StockCommon.stkExistenciasXDepositoDS Exch, Command cmd)
        {
            GeneralesExchange.genPermisosActionExchange ePermi = new GeneralesExchange.genPermisosActionExchange(GeneralesExchange.genPermisosActionEnum.EnumgenPermisosAction.Datos)
            {
                Usuario_id = cmd.Usuario_Id, 
                Formulario_Id = cmd.Formulario
            };
            ePermi = new GeneralesExchange.genPermisosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ePermi, cmd));
            if (ePermi.Existe && ePermi.Borrar)
                return "S";
            return "N";
        
        }
    }
}
