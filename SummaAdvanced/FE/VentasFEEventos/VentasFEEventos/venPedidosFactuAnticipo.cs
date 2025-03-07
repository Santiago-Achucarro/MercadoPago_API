using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasFEEventos
{
    public class venPedidosFactuAnticipo
    {

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarPdfFactura(VentasCommon.venPedidosAnticipoDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venMovimientosImprimirActionExchange eMov =
                    new VentasExchange.venMovimientosImprimirActionExchange(VentasExchange.venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction.Datos)
                    {
                        Segmento_Id = exch.Principal[0].Segmento_IdFact,
                        Segmento1N = exch.Principal[0].Segmento1NFact,
                        Segmento2N = exch.Principal[0].Segmento2NFact,
                        Segmento3N = exch.Principal[0].Segmento3NFact,
                        Segmento4N = exch.Principal[0].Segmento4NFact,
                        Segmento1C = exch.Principal[0].Segmento1CFact,
                        Segmento2C = exch.Principal[0].Segmento2CFact,
                        Segmento3C = exch.Principal[0].Segmento3CFact,
                        Segmento4C = exch.Principal[0].Segmento4CFact
                    };
            eMov = new VentasExchange.venMovimientosImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

            if (!eMov.Existe)
            {

                Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_el_Movimiento");

            }
            if (eMov.PDF == "")
                Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");

            return Generalidades.Archivos.ConvertirADatasetDownload("PDF", eMov.NombreArchivo + ".pdf", false, "pdf",
                        eMov.PDF);


        }

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarXmlFactura(VentasCommon.venPedidosAnticipoDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venMovimientosImprimirActionExchange eMov =
                    new VentasExchange.venMovimientosImprimirActionExchange(VentasExchange.venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction.Datos)
                    {
                        Segmento_Id = exch.Principal[0].Segmento_IdFact,
                        Segmento1N = exch.Principal[0].Segmento1NFact,
                        Segmento2N = exch.Principal[0].Segmento2NFact,
                        Segmento3N = exch.Principal[0].Segmento3NFact,
                        Segmento4N = exch.Principal[0].Segmento4NFact,
                        Segmento1C = exch.Principal[0].Segmento1CFact,
                        Segmento2C = exch.Principal[0].Segmento2CFact,
                        Segmento3C = exch.Principal[0].Segmento3CFact,
                        Segmento4C = exch.Principal[0].Segmento4CFact
                    };
            eMov = new VentasExchange.venMovimientosImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

            if (!eMov.Existe)
            {

                Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_el_Movimiento");

            }
            if (eMov.XML == "")
                Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");

            return Generalidades.Archivos.ConvertirADatasetDownload("XML", eMov.NombreArchivo + ".xml", false, "xml",
                        eMov.XML);


        }
    }
}
