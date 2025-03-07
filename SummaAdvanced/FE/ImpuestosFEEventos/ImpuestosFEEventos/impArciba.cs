using Framework.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ImpuestosFEEventos
{
    public class impArciba
    {
        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarArchivo(ImpuestosCommon.impArcibaDS Exch, Command cmd)
        {
            var lbytes = File.ReadAllBytes(@"C:\Temp\Arciba.TXT");
            string lbase64 = Convert.ToBase64String(lbytes);
            return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", "Arciba.TXT", false, "txt", lbase64);
        }

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarArchivoNC(ImpuestosCommon.impArcibaDS Exch, Command cmd)
        {
            var lbytes = File.ReadAllBytes(@"C:\Temp\ArcibaNC.TXT");
            string lbase64 = Convert.ToBase64String(lbytes);
            return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", "ArcibaNC.TXT", false, "txt", lbase64);
        }
    }
}
