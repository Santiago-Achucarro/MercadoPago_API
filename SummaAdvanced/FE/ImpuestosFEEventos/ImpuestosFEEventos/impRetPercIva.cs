using Framework.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpuestosFEEventos
{
    public class impRetPercIva
    {
        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarRetenciones(ImpuestosCommon.impRetPercIvaDS Exch, Command cmd)

        {
            byte[] lbytes;
            string lbase64;

            lbytes = File.ReadAllBytes(@"C:\Temp\RetIva.txt");
            lbase64 = Convert.ToBase64String(lbytes);
            return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", "RetIva.txt", false, "txt", lbase64);
        }

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarPercepciones(ImpuestosCommon.impRetPercIvaDS Exch, Command cmd)

        {
            byte[] lbytes;
            string lbase64;

            lbytes = File.ReadAllBytes(@"C:\Temp\PercIva.txt");
            lbase64 = Convert.ToBase64String(lbytes);
            return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", "PercIva.txt", false, "txt", lbase64);
        }
    }
}
