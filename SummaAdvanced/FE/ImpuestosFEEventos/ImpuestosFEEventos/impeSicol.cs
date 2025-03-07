using Framework.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpuestosFEEventos
{
    public class impeSicol
    {
        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarPercepciones(ImpuestosCommon.impeSicolDS Exch, Command cmd)

        {
            byte[] lbytes;
            string lbase64;

            lbytes = File.ReadAllBytes(@"C:\Temp\eSicol.txt");
            lbase64 = Convert.ToBase64String(lbytes);
            return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", "eSicol.txt", false, "txt", lbase64);
        }
    }
}
