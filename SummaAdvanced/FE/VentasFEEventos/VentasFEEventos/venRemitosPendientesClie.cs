using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasFEEventos
{
    public class venRemitosPendientesClie
    {
        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarPdfFactura(VentasCommon.venRemitosPendienteClieDS exch, Framework.Core.Command cmd)
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
        public Generalidades.DescargaArchivoDS DescargarXmlFactura(VentasCommon.venRemitosPendienteClieDS exch, Framework.Core.Command cmd)
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

        [Generalidades.QFuncion_EnviarMail]
        public Generalidades.CorreoDS Enviar(VentasCommon.venRemitosPendienteClieDS pCommonDS, Framework.Core.Command cmd)
        {
            Generalidades.CorreoDS lRetorno = new Generalidades.CorreoDS();
            VentasExchange.venMovimientosEnviarActionExchange eMov = new VentasExchange.venMovimientosEnviarActionExchange(VentasExchange.venMovimientosEnviarActionEnum.EnumvenMovimientosEnviarAction.Datos)
            {
                Segmento_Id = pCommonDS.Principal[0].Segmento_IdFact,
                Segmento1N = pCommonDS.Principal[0].Segmento1NFact,
                Segmento2N = pCommonDS.Principal[0].Segmento2NFact,
                Segmento3N = pCommonDS.Principal[0].Segmento3NFact,
                Segmento4N = pCommonDS.Principal[0].Segmento4NFact,
                Segmento1C = pCommonDS.Principal[0].Segmento1CFact,
                Segmento2C = pCommonDS.Principal[0].Segmento2CFact,
                Segmento3C = pCommonDS.Principal[0].Segmento3CFact,
                Segmento4C = pCommonDS.Principal[0].Segmento4CFact
            };
            eMov = new VentasExchange.venMovimientosEnviarActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

            lRetorno.Principal.AddPrincipalRow(eMov.Param.Cabecera[0].Asunto, eMov.Param.Cabecera[0].Cuerpo,
                    eMov.Param.Cabecera[0].Destinatarios, eMov.Param.Cabecera[0].DestinatariosCopia, eMov.Param.Cabecera[0].DestinatariosCopiaOculta, false);
            foreach (var ren in eMov.Param.Adjuntos)
            {
                lRetorno.Adjuntos.AddAdjuntosRow(ren.Renglon, ren.Guid, ren.NombreArchivo, ren.Extension,
                      ren.ArchivoBase64, ren.Estado);
            }
            //...... 
            //...... 
            // Los destinatarios van separados por ';'
            // El datatable de adjuntos tiene la misma estructura y forma de utilizarse que el datatable adjuntos de cualquier entidad o movimiwento
            // Se puede usar el método Generalidades.Auxiliares.AdjuntosCompletarDatos(NombreTabla, Identity, Path, cmd) para completar el datatable de ajuntos del mail, con los adjuntos asociados a la entidad o movimiento
            return lRetorno;

        }

        [Generalidades.QFuncion_Condicion]
        public string EnviaFactura(VentasCommon.venRemitosPendienteClieDS exch, Framework.Core.Command cmd)
        {

            return (GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd).EnviaFacturas ? "S" : "N");
        }
    }
}
