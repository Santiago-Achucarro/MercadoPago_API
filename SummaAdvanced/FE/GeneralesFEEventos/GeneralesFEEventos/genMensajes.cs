using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;


namespace GeneralesFEEventos
{
    public class genMensajes
    {
        public Generalidades.DescargaArchivoDS DescargarArchDesdeMensaje(string pSubTipo, string pParametros, Command cmd)
        {
            Generalidades.DescargaArchivoDS lRetorno = null;
            switch (pSubTipo.ToUpper())
            {
                case "PRUEBA":
                    lRetorno = DescargarArchivoPrueba(pParametros);
                    break;
                case "PDFV":
                    // PDF DE FACTURA DE VENTAS
                    string[] lPar = pParametros.Split('|');
                    VentasExchange.venMovimientosImprimirActionExchange eMOV = new VentasExchange.venMovimientosImprimirActionExchange(VentasExchange.venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction.Datos)
                    {
                        Segmento_Id = lPar[0],
                        Segmento1N = Convert.ToInt32(lPar[1]),
                        Segmento2N = Convert.ToInt32(lPar[2]),
                        Segmento3N = Convert.ToInt32(lPar[3]),
                        Segmento4N = Convert.ToInt32(lPar[4]),
                        Segmento1C = lPar[5],
                        Segmento2C = lPar[6],
                        Segmento3C = lPar[7],
                        Segmento4C = lPar[8]
                    };
                    eMOV = new VentasExchange.venMovimientosImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMOV, cmd));
                    if (eMOV.Existe)
                        lRetorno = Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", eMOV.NombreArchivo + ".PDF", false, "pdf", eMOV.PDF);
                    else
                        Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_No_Existe");
                    break;
                case "XMLV":
                    // XML DE FACTURA DE VENTAS
                    string[] lParX = pParametros.Split('|');
                    VentasExchange.venMovimientosImprimirActionExchange eMOVX = new VentasExchange.venMovimientosImprimirActionExchange(VentasExchange.venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction.Datos)
                    {
                        Segmento_Id = lParX[0],
                        Segmento1N = Convert.ToInt32(lParX[1]),
                        Segmento2N = Convert.ToInt32(lParX[2]),
                        Segmento3N = Convert.ToInt32(lParX[3]),
                        Segmento4N = Convert.ToInt32(lParX[4]),
                        Segmento1C = lParX[5],
                        Segmento2C = lParX[6],
                        Segmento3C = lParX[7],
                        Segmento4C = lParX[8]
                    };
                    eMOVX = new VentasExchange.venMovimientosImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMOVX, cmd));
                    if (eMOVX.Existe)
                        lRetorno = Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", eMOVX.NombreArchivo + ".xml", false, "xml", eMOVX.XML);
                    else
                        Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_No_Existe");
                    break;

            }
            return lRetorno;
        }




        private Generalidades.DescargaArchivoDS DescargarArchivoPrueba(string pParametros)
        {
            StringBuilder lpepe = new StringBuilder();
            lpepe.Append(pParametros + Environment.NewLine);
            lpepe.Append("Segundo renglon" + Environment.NewLine);
            byte[] buffer = Encoding.ASCII.GetBytes(lpepe.ToString());
            string lbase64 = Convert.ToBase64String(buffer);
            return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", "Prueba.txt", false, "txt", lbase64);
        }


    }
}
