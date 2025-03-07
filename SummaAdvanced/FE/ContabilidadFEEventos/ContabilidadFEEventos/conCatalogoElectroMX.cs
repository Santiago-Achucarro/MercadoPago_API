using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;

namespace ContabilidadFEEventos
{
    public class conCatalogoElectroMX
    {
        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarCatalogo(ContabilidadCommon.conCatalogoElectroMXDS Exch, Command cmd)
        {
            ContabilidadExchange.conCatalogoElectroMXActionExchange ExCat = new ContabilidadExchange.conCatalogoElectroMXActionExchange(ContabilidadExchange.conCatalogoElectroMXActionEnum.EnumconCatalogoElectroMXAction.Guardar)
            {
                Anio = Exch.Principal[0].Anio,
                Mes = Exch.Principal[0].Mes,
                Genera_Catalogo = true,
                Genera_Balanza = false,
                TipoEnvio = Exch.Principal[0].TipoEnvio,
                FechaModBal=Exch.Principal[0].FechaModBal
            };

            ExCat = new ContabilidadExchange.conCatalogoElectroMXActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExCat, cmd));

            string lRfc = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd).Cuit.Trim();

            return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo",  lRfc+Exch.Principal[0].Anio.ToString("0000")+
                    Exch.Principal[0].Mes.ToString("00")+"CT.xml", false, "xml", ExCat.BytesCatalgo);
        }

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarBalnza(ContabilidadCommon.conCatalogoElectroMXDS Exch, Command cmd)
        {
            ContabilidadExchange.conCatalogoElectroMXActionExchange ExCat = new ContabilidadExchange.conCatalogoElectroMXActionExchange(ContabilidadExchange.conCatalogoElectroMXActionEnum.EnumconCatalogoElectroMXAction.Guardar)
            {
                Anio = Exch.Principal[0].Anio,
                Mes = Exch.Principal[0].Mes,
                Genera_Catalogo = false,
                Genera_Balanza = true,
                TipoEnvio = Exch.Principal[0].TipoEnvio,
                FechaModBal = Exch.Principal[0].FechaModBal
            };

            ExCat = new ContabilidadExchange.conCatalogoElectroMXActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExCat, cmd));

            string lRfc = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd).Cuit.Trim();

            return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", lRfc + Exch.Principal[0].Anio.ToString("0000") +
                    Exch.Principal[0].Mes.ToString("00")+ "BN.xml", false, "xml", ExCat.BytesBalanza);
        }
    }
}
