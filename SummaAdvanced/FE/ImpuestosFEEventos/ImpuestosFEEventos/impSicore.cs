using Framework.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ImpuestosFEEventos
{
    public class impSicore
    {
        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarTxt(ImpuestosCommon.impSicoreDS Exch, Command cmd)
        {
            var lbytes = File.ReadAllBytes(@"C:\Temp\Sicore.TXT");
            string lbase64 = Convert.ToBase64String(lbytes);
            return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", "Retenciones.TXT", false, "txt", lbase64);
        }
    }
}
