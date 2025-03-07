using Framework.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ImpuestosFEEventos
{
    public class impSifere
    {
        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarRetenciones(ImpuestosCommon.impSifereDS Exch, Command cmd)
        {
            var lbytes = File.ReadAllBytes(@"C:\Temp\Retenciones.TXT");
            string lbase64 = Convert.ToBase64String(lbytes);
            return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", "Retenciones.TXT", false, "txt", lbase64);
        }

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarPercepciones(ImpuestosCommon.impSifereDS Exch, Command cmd)
        {
            var lbytes = File.ReadAllBytes(@"C:\Temp\Percepciones.TXT");
            string lbase64 = Convert.ToBase64String(lbytes);
            return Generalidades.Archivos.ConvertirADatasetDownload("DescargarArchivo", "Percepciones.TXT", false, "txt", lbase64);
        }

        [Generalidades.QFuncion_ObtenerParametrosReporte]
        public String ObtenerParametrosRepo(ImpuestosCommon.impSifereDS exch, Framework.Core.Command cmd)
        {
            string a = "pEmpresa_id|" + cmd.Empresa_Id.ToString() + "@pMes|" + exch.Principal[0].Mes.ToString() +
                "@pAnio|" + exch.Principal[0].Anio.ToString();

            return a;
        }

        public enum impSifereVar
        {
            MesActual, AnioActual
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesMesAnio(ImpuestosCommon.impSifereDS Exch, ImpuestosCommon.impSifereDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            Dictionary<string, string> lRetorno = new Dictionary<string, string>();

            lRetorno.Add(impSifereVar.MesActual.ToString(), GeneralesValidacion.FechaBaseDatos.GetFechaServer(cmd).Month.ToString());
            lRetorno.Add(impSifereVar.AnioActual.ToString(), GeneralesValidacion.FechaBaseDatos.GetFechaServer(cmd).ToString());

            return lRetorno;
        }
    }
}
