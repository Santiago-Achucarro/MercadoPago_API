using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using VentasExchange;

namespace VentasFEEventos
{
    public class venGeneraRemitoFactura
    {

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarPDFRemitos(venGeneraRemitoFacturaDS exch, Framework.Core.Command cmd)
        {
            venRepartoImprimirActionExchange eMov = new venRepartoImprimirActionExchange(venRepartoImprimirActionEnum.EnumvenRepartoImprimirAction.Datos)
            {
                Segmento_Id = exch.Principal[0].Segmento_Id,
                Segmento1N = exch.Principal[0].Segmento1N,
                Segmento2N = exch.Principal[0].Segmento2N,
                Segmento3N = exch.Principal[0].Segmento3N,
                Segmento4N = exch.Principal[0].Segmento4N,
                Segmento1C = exch.Principal[0].Segmento1C,
                Segmento2C = exch.Principal[0].Segmento2C,
                Segmento3C = exch.Principal[0].Segmento3C,
                Segmento4C = exch.Principal[0].Segmento4C,
                FacturaRemito = "R"
            };
            eMov = new venRepartoImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

            if (!eMov.Existe)
            {

                Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_el_Movimiento");

            }

            if (eMov.PDF == "")
                return new Generalidades.DescargaArchivoDS();

            //Generalidades.qFunctionalException.GenerarExcepcion("Solo_Se_Generaron_Facturas");


            return Generalidades.Archivos.ConvertirADatasetDownload("PDF",
                eMov.NombreArchivo.Split('\\')[eMov.NombreArchivo.Split('\\').Length - 1], false, "pdf", eMov.PDF);
        }

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarPDFFacturas(venGeneraRemitoFacturaDS exch, Framework.Core.Command cmd)
        {

            venRepartoImprimirActionExchange eMov = new venRepartoImprimirActionExchange(venRepartoImprimirActionEnum.EnumvenRepartoImprimirAction.Datos)
            {
                Segmento_Id = exch.Principal[0].Segmento_Id,
                Segmento1N = exch.Principal[0].Segmento1N,
                Segmento2N = exch.Principal[0].Segmento2N,
                Segmento3N = exch.Principal[0].Segmento3N,
                Segmento4N = exch.Principal[0].Segmento4N,
                Segmento1C = exch.Principal[0].Segmento1C,
                Segmento2C = exch.Principal[0].Segmento2C,
                Segmento3C = exch.Principal[0].Segmento3C,
                Segmento4C = exch.Principal[0].Segmento4C,
                FacturaRemito = "F"
            };
            eMov = new venRepartoImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

            if (!eMov.Existe)
            {

                Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_el_Movimiento");

            }
            if (eMov.PDF == "")
                //Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");
                Generalidades.qFunctionalException.GenerarExcepcion("Problema_con_archivo_<0>", new object[] { eMov.NombreArchivo });

            return Generalidades.Archivos.ConvertirADatasetDownload("PDF",
                eMov.NombreArchivo.Split('\\')[eMov.NombreArchivo.Split('\\').Length - 1], false, "pdf", eMov.PDF);
        }
    }
}
