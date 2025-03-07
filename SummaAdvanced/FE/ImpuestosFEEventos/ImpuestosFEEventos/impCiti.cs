using Framework.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Text;

namespace ImpuestosFEEventos
{
    public class impCiti
    {


        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarComprasCbte(ImpuestosCommon.impCitiDS Exch, Command cmd)

        {


            byte[] lbytes;
            string lbase64;

            if (Exch.Principal[0].Destino == "C")
            {
                lbytes = File.ReadAllBytes(@"C:\Temp\REGINFO_CV_COMPRAS_CBTE.TXT");
                lbase64 = Convert.ToBase64String(lbytes);
                return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", "REGINFO_CV_COMPRAS_CBTE.TXT", false, "txt", lbase64);
            }

            lbytes = File.ReadAllBytes(@"C:\Temp\LIBRO_IVA_DIGITAL_COMPRAS_CBTE.TXT");
            lbase64 = Convert.ToBase64String(lbytes);
            return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", "LIBRO_IVA_DIGITAL_COMPRAS_CBTE.TXT", false, "txt", lbase64);

        }
        // Emp Mantis 12504 que bajes importación separado según opción.
        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarComprasImportacion(ImpuestosCommon.impCitiDS Exch, Command cmd)

        {
            byte[] lbytes;
            string lbase64;

            if (Exch.Principal[0].Destino == "C")
            {
                lbytes = File.ReadAllBytes(@"C:\Temp\REGINFO_CV_COMPRAS_IMPORTACION.TXT");
                lbase64 = Convert.ToBase64String(lbytes);
                return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", "REGINFO_CV_COMPRAS_IMPORTACION.TXT", false, "txt", lbase64);
            }

            lbytes = File.ReadAllBytes(@"C:\Temp\LIBRO_IVA_DIGITAL_COMPRAS_IMPORTACION.TXT");
            lbase64 = Convert.ToBase64String(lbytes);
            return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", "LIBRO_IVA_DIGITAL_COMPRAS_IMPORTACION.TXT", false, "txt", lbase64);

        }
        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarComprasCbte_BS(ImpuestosCommon.impCitiDS Exch, Command cmd)
                      
        {
            
            
            byte[] lbytes;
            string lbase64;
            if (Exch.Principal[0].Destino == "C")
                {
                    lbytes = File.ReadAllBytes(@"C:\Temp\REGINFO_CV_COMPRAS_CBTE_BS.TXT");
                    lbase64 = Convert.ToBase64String(lbytes);
                    return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", "REGINFO_CV_COMPRAS_CBTE_BS.TXT", false, "txt", lbase64);
                }

                lbytes = File.ReadAllBytes(@"C:\Temp\LIBRO_IVA_DIGITAL_COMPRAS_CBTE_BS.TXT");
                lbase64 = Convert.ToBase64String(lbytes);

                return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", "LIBRO_IVA_DIGITAL_COMPRAS_CBTE_BS.TXT", false, "txt", lbase64);
            
            
        }
        // Fin Emp Mantis 12504
        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarComprasAlicuota(ImpuestosCommon.impCitiDS Exch, Command cmd)
        {

            byte[] lbytes;
            string lbase64;

            if (Exch.Principal[0].Destino == "C")
            {
                lbytes = File.ReadAllBytes(@"C:\Temp\REGINFO_CV_COMPRAS_ALICUOTAS.TXT");
                lbase64 = Convert.ToBase64String(lbytes);
                return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", "REGINFO_CV_COMPRAS_ALICUOTAS.TXT", false, "txt", lbase64);
            }

            lbytes = File.ReadAllBytes(@"C:\Temp\LIBRO_IVA_DIGITAL_COMPRAS_ALICUOTAS.TXT");
            lbase64 = Convert.ToBase64String(lbytes);
            return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", "LIBRO_IVA_DIGITAL_COMPRAS_ALICUOTAS.TXT", false, "txt", lbase64);


        }

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarVentasCbte(ImpuestosCommon.impCitiDS Exch, Command cmd)
        {


            byte[] lbytes;
            string lbase64;

            if (Exch.Principal[0].Destino == "C")
            {
                lbytes = File.ReadAllBytes(@"C:\Temp\REGINFO_CV_VENTAS_CBTE.TXT");
                lbase64 = Convert.ToBase64String(lbytes);
                return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", "REGINFO_CV_VENTAS_CBTE.TXT", false, "txt", lbase64);
            }

            lbytes = File.ReadAllBytes(@"C:\Temp\LIBRO_IVA_DIGITAL_VENTAS_CBTE.TXT");
            lbase64 = Convert.ToBase64String(lbytes);
            return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", "LIBRO_IVA_DIGITAL_VENTAS_CBTE.TXT", false, "txt", lbase64);

        }

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarVentasAlicuota(ImpuestosCommon.impCitiDS Exch, Command cmd)
        {

            byte[] lbytes;
            string lbase64;

            if (Exch.Principal[0].Destino == "C")
            {
                lbytes = File.ReadAllBytes(@"C:\Temp\REGINFO_CV_VENTAS_ALICUOTAS.TXT");
                lbase64 = Convert.ToBase64String(lbytes);
                return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", "REGINFO_CV_VENTAS_ALICUOTAS.TXT", false, "txt", lbase64);
            }
            lbytes = File.ReadAllBytes(@"C:\Temp\LIBRO_IVA_DIGITAL_VENTAS_ALICUOTAS.TXT");
            lbase64 = Convert.ToBase64String(lbytes);
            return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", "LIBRO_IVA_DIGITAL_VENTAS_ALICUOTAS.TXT", false, "txt", lbase64);

        }
    }


}
