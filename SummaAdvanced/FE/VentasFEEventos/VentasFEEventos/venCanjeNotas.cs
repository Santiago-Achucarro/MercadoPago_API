using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;

namespace VentasFEEventos
{
    public class venCanjeNotas
    {
        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.ventasCanjeNotasDS AgregarNota(VentasCommon.ventasCanjeNotasDS exch,
                VentasCommon.ventasCanjeNotasDS exchNoPost, int pIndice, Command cmd)
        {
            var ren = exchNoPost.Cuerpo[0];
            VentasExchange.ventasCanjeNotaAgregarActionExchange eNota =
                    new VentasExchange.ventasCanjeNotaAgregarActionExchange(VentasExchange.ventasCanjeNotaAgregarActionEnum.EnumventasCanjeNotaAgregarAction.Datos)
                    {
                        Segmento_Id = ren.Segmento_Id,
                        Segmento1C = ren.Segmento1C,
                        Segmento2C = ren.Segmento2C,
                        Segmento3C = ren.Segmento3C,
                        Segmento4C = ren.Segmento4C,
                        Segmento1N = ren.Segmento1N,
                        Segmento2N = ren.Segmento2N,
                        Segmento3N = ren.Segmento3N,
                        Segmento4N = ren.Segmento4N

                    };
            eNota = new VentasExchange.ventasCanjeNotaAgregarActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eNota, cmd));
            if (!eNota.Existe)
                Generalidades.qFunctionalException.GenerarExcepcion("La_Nota_No_Existe");

            ren.venMovimientos = eNota.venMovimientos;
            ren.SegmentoStr = eNota.SegmentoStr;
            ren.SubTotal = eNota.SubTotal;
            ren.Impuestos = eNota.Impuestos;
            ren.Fecha = eNota.Fecha;
            ren.Importe = eNota.Importe;
            ren.Saldo = eNota.Saldo;

            return exchNoPost;
        }


        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarXmlFactura(VentasCommon.ventasCanjeNotasDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venMovimientosImprimirActionExchange eMov =
                    new VentasExchange.venMovimientosImprimirActionExchange(VentasExchange.venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction.Datos)
                    {
                        Segmento_Id = exch.Principal[0].Segmento_Id,
                        Segmento1N = exch.Principal[0].Segmento1N,
                        Segmento2N = exch.Principal[0].Segmento2N,
                        Segmento3N = exch.Principal[0].Segmento3N,
                        Segmento4N = exch.Principal[0].Segmento4N,
                        Segmento1C = exch.Principal[0].Segmento1C,
                        Segmento2C = exch.Principal[0].Segmento2C,
                        Segmento3C = exch.Principal[0].Segmento3C,
                        Segmento4C = exch.Principal[0].Segmento4C
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

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarPDFFactura(VentasCommon.ventasCanjeNotasDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venMovimientosImprimirActionExchange eMov =
                    new VentasExchange.venMovimientosImprimirActionExchange(VentasExchange.venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction.Datos)
                    {
                        Segmento_Id = exch.Principal[0].Segmento_Id,
                        Segmento1N = exch.Principal[0].Segmento1N,
                        Segmento2N = exch.Principal[0].Segmento2N,
                        Segmento3N = exch.Principal[0].Segmento3N,
                        Segmento4N = exch.Principal[0].Segmento4N,
                        Segmento1C = exch.Principal[0].Segmento1C,
                        Segmento2C = exch.Principal[0].Segmento2C,
                        Segmento3C = exch.Principal[0].Segmento3C,
                        Segmento4C = exch.Principal[0].Segmento4C
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

        [Generalidades.QFuncion_CondicionGrilla]
        public String ValidarCFDIR(VentasCommon.ventasCanjeNotasDS exch, VentasCommon.ventasCanjeNotasDS exchNoPost,
          int pIndice, Framework.Core.Command cmd)
        {

            VentasExchange.venMovimientosConsultaActionExchange exchVMC = new VentasExchange.venMovimientosConsultaActionExchange
                 (VentasExchange.venMovimientosConsultaActionEnum.EnumvenMovimientosConsultaAction.Datos);
            exchVMC.Segmento_Id = exchNoPost.venMovimientosCFDIR[0].Segmento_Id;
            exchVMC.Segmento1N = exchNoPost.venMovimientosCFDIR[0].Segmento1N;
            exchVMC.Segmento2N = exchNoPost.venMovimientosCFDIR[0].Segmento2N;
            exchVMC.Segmento3N = exchNoPost.venMovimientosCFDIR[0].Segmento3N;
            exchVMC.Segmento4N = exchNoPost.venMovimientosCFDIR[0].Segmento4N;
            exchVMC.Segmento1C = exchNoPost.venMovimientosCFDIR[0].Segmento1C;
            exchVMC.Segmento2C = exchNoPost.venMovimientosCFDIR[0].Segmento2C;
            exchVMC.Segmento3C = exchNoPost.venMovimientosCFDIR[0].Segmento3C;
            exchVMC.Segmento4C = exchNoPost.venMovimientosCFDIR[0].Segmento4C;

            exchVMC = new VentasExchange.venMovimientosConsultaActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                (new Framework.Core.Exchange(exchVMC), cmd));
            if (!exchVMC.Existe)
                return "No_existe_el_comprobante";

            // TODO FM Falta validar la lupa de relaciones desde entidades básicas

            return "";

        }

    }
}
