using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldosFEEventos
{
    public class sueTimbradoRecibos
    {
        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarPDFFactura(SueldosCommon.sueTimbradoRecibosDS exch, Framework.Core.Command cmd)
        {
            SueldosExchange.sueTimbradoRecibosActionExchange eTimbrado = new SueldosExchange.sueTimbradoRecibosActionExchange(SueldosExchange.sueTimbradoRecibosActionEnum.EnumsueTimbradoRecibosAction.Imprimir)
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
                LegajoDesde = exch.Principal[0].LegajoDesde,
                LegajoHasta = exch.Principal[0].LegajoHasta,
                TipoNomina = exch.Principal[0].TipoNomina,
                Grupo_Id = exch.Principal[0].Grupo_Id
            };
            eTimbrado = new SueldosExchange.sueTimbradoRecibosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eTimbrado, cmd));
            if (eTimbrado.Zip == "")
                Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");

            return Generalidades.Archivos.ConvertirADatasetDownload("ZIP", eTimbrado.NombreZip + ".zip", false, "zip",
                        eTimbrado.Zip);

        }
    }
}
