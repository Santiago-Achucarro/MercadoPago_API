using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
namespace ContabilidadFEEventos
{
    public class conCatalogoElectoMx
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
                Genera_Poliza = false,
                Numorden = "",
                NumTramite = "",
                TipoSolicitud = "",
                TipoEnvio = Exch.Principal[0].TipoEnvio,
                Nivel = Exch.Principal[0].Nivel
            };

            ExCat = new ContabilidadExchange.conCatalogoElectroMXActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExCat, cmd));

            string lRfc = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd).Cuit.Trim();

            return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", lRfc + Exch.Principal[0].Anio.ToString("0000") +
                    Exch.Principal[0].Mes.ToString("00") + "CT.xml", false, "xml", ExCat.BytesCatalgo);
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
                Genera_Poliza = false,
                Numorden = "",
                NumTramite = "",
                TipoSolicitud ="",
                TipoEnvio = Exch.Principal[0].TipoEnvio,
                FechaModBal=Exch.Principal[0].FechaModBal,
                Nivel = Exch.Principal[0].Nivel
            };

            ExCat = new ContabilidadExchange.conCatalogoElectroMXActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExCat, cmd));

            string lRfc = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd).Cuit.Trim();

            return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", lRfc + Exch.Principal[0].Anio.ToString("0000") +
                    Exch.Principal[0].Mes.ToString("00") + "BN.xml", false, "xml", ExCat.BytesBalanza);
        }

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarPolizas(ContabilidadCommon.conCatalogoElectroMXDS Exch, Command cmd)
        {
            ContabilidadExchange.conCatalogoElectroMXActionExchange ExCat = new ContabilidadExchange.conCatalogoElectroMXActionExchange(ContabilidadExchange.conCatalogoElectroMXActionEnum.EnumconCatalogoElectroMXAction.Guardar)
            {
                Anio = Exch.Principal[0].Anio,
                Mes = Exch.Principal[0].Mes,
                Genera_Catalogo = false,
                Genera_Balanza = false,
                Genera_Poliza = true,
                Numorden = (Exch.Principal[0].TipoSolicitud == "DE" || Exch.Principal[0].TipoSolicitud == "CO")?"":Exch.Principal[0].Numorden,
                NumTramite = (Exch.Principal[0].TipoSolicitud =="DE" || Exch.Principal[0].TipoSolicitud=="CO")?Exch.Principal[0].NumTramite:"",
                TipoSolicitud = Exch.Principal[0].TipoSolicitud,
                TipoEnvio = Exch.Principal[0].TipoEnvio,
                FechaModBal=Exch.Principal[0].FechaModBal,
                Nivel = Exch.Principal[0].Nivel
            };

            ExCat = new ContabilidadExchange.conCatalogoElectroMXActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExCat, cmd));

            string lRfc = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd).Cuit.Trim();

            return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", lRfc + Exch.Principal[0].Anio.ToString("0000") +
                    Exch.Principal[0].Mes.ToString("00") + "PL.xml", false, "xml", ExCat.BytesPoliza);
        }
    }
}
