
using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SueldosFEEventos
{
    class sueGenerarArchivosTxt
    {
        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarArchivosTxt(SueldosCommon.sueGenerarArchivosTxtDS ds, Framework.Core.Command cmd)
        {
          
            SueldosExchange.sueGenerarArchivosTxtActionExchange eTxt = new SueldosExchange.sueGenerarArchivosTxtActionExchange(SueldosExchange.sueGenerarArchivosTxtActionEnum.EnumsueGenerarArchivosTxtAction.Generar);
            eTxt.Param.Merge(ds, false, System.Data.MissingSchemaAction.Ignore);
            eTxt.Param.Principal[0].Delete();
            eTxt.Param.AcceptChanges();
            eTxt = new SueldosExchange.sueGenerarArchivosTxtActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eTxt, cmd));

            DateTime lDateTime = GeneralesValidacion.FechaBaseDatos.GetFechaServer(cmd);

            return Generalidades.Archivos.ConvertirADatasetDownload("txt", eTxt.Descripcion + lDateTime.Year.ToString() + lDateTime.Month.ToString("00") + ".txt", false, "txt", eTxt.Txt);


        }
    }
}
