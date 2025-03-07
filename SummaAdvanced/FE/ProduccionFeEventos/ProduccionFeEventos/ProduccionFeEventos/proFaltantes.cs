using Framework.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduccionFeEventos
{
    public class proFaltantes
    {
        [Generalidades.QFuncion_ObtenerParametrosReporte]
        public string AsignarParametros(ProduccionCommon.proExploProgramaFaltantesDS Exch, Command cmd)
        {
            string lRetorno = "";
            lRetorno = "Segmento_Id|" + Exch.Principal[0].Segmento_Id + "@" +
                "Segmento1N|" + Exch.Principal[0].Segmento1N.ToString() + "@" +
                "Segmento2N|" + Exch.Principal[0].Segmento2N.ToString() + "@" +
                "Segmento3N|" + Exch.Principal[0].Segmento3N.ToString() + "@" +
                "Segmento4N|" + Exch.Principal[0].Segmento4N.ToString() + "@" +
                "Segmento1C|" + Exch.Principal[0].Segmento1C + "@" +
                "Segmento2C|" + Exch.Principal[0].Segmento2C + "@" +
                "Segmento3C|" + Exch.Principal[0].Segmento3C + "@" +
                "Segmento4C|" + Exch.Principal[0].Segmento4C + "@" +
                "FechaDesde|" + Exch.Principal[0].FechaDesde.ToString() + "@" +
                "FechaHasta|" + Exch.Principal[0].FechaHasta.ToString() + "@"+
                "SoloFalantes|"+Exch.Principal[0].SoloFaltantes.ToString()+"@"+
                "IncluPendiente|"+Exch.Principal[0].IncluPendiente.ToString();


            return lRetorno;
        }

        [Generalidades.QFuncion_ObtenerDatosReporte]
        public DataSet LlenarDataSet(string pParametros, Framework.Core.Command cmd)
        {
            string[] lPar = pParametros.Split('@');

            ProduccionExchange.proExploProgramaFaltantesActionExchange  eExplo = new ProduccionExchange.proExploProgramaFaltantesActionExchange(ProduccionExchange.proExploProgramaFaltantesActionEnum.EnumproExploProgramaFaltantesAction.Faltantes)
            {
                Segmento_Id = lPar[0].Split('|')[1],
                Segmento1N = Convert.ToInt32(lPar[1].Split('|')[1]),
                Segmento2N = Convert.ToInt32(lPar[2].Split('|')[1]),
                Segmento3N = Convert.ToInt32(lPar[3].Split('|')[1]),
                Segmento4N = Convert.ToInt32(lPar[4].Split('|')[1]),
                Segmento1C = lPar[5].Split('|')[1],
                Segmento2C = lPar[6].Split('|')[1],
                Segmento3C = lPar[7].Split('|')[1],
                Segmento4C = lPar[8].Split('|')[1],
                FechaDesde = Convert.ToDateTime(lPar[9].Split('|')[1]),
                FechaHasta = Convert.ToDateTime(lPar[10].Split('|')[1]),
                SoloFaltantes = Convert.ToBoolean(lPar[11].Split('|')[1]),
                IncluPendiente = Convert.ToBoolean(lPar[12].Split('|')[1]),
            };

            eExplo = new ProduccionExchange.proExploProgramaFaltantesActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eExplo, cmd));

            eExplo.ProgramaStr =
            GeneralesValidacion.genSegmentos.SegmentoStr(eExplo.Segmento_Id, eExplo.Segmento1C, eExplo.Segmento2C, eExplo.Segmento3C,
                    eExplo.Segmento4C, eExplo.Segmento1N, eExplo.Segmento2N, eExplo.Segmento3N, eExplo.Segmento4N, cmd).SegmentoSTR;

            return eExplo.Param;
        }
    }
}
