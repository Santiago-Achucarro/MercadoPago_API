using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
namespace ComprasFEEventos
{
    public class comOCRecepcion
    {
        [Generalidades.QFuncion_Condicion]
        public string EsMonedaBase(ComprasCommon.comOcRecepcionDS exch, Command cmd)
        {
            if (exch.Principal[0].Moneda_Id == cmd.MonedaBase || exch.Principal[0].Moneda_Id.Trim() == "")
                return "S";

            return "N";

        }

        ///Si no es invocado desde eventos de grilla
        [Generalidades.QFuncion_ObtenerParametrosReporte]
        public string Parametros(ComprasCommon.comOcRecepcionDS pCommonDS, Command cmd)
        {
            string lRetorno = "Empresa_Id|" + cmd.Empresa_Id.ToString() + "@" +
             "Segmento_Id|" + pCommonDS.Principal[0].Segmento_Id + "@" +
             "Segmento1N|" + pCommonDS.Principal[0].Segmento1N.ToString() + "@" +
             "Segmento2N|" + pCommonDS.Principal[0].Segmento2N.ToString() + "@" +
             "Segmento3N|" + pCommonDS.Principal[0].Segmento3N.ToString() + "@" +
             "Segmento4N|" + pCommonDS.Principal[0].Segmento4N.ToString() + "@" +
             "Segmento1C|" + pCommonDS.Principal[0].Segmento1C + "@" +
             "Segmento2C|" + pCommonDS.Principal[0].Segmento2C + "@" +
             "Segmento3C|" + pCommonDS.Principal[0].Segmento3C + "@" +
             "Segmento4C|" + pCommonDS.Principal[0].Segmento4C;

            return lRetorno;
        }
    }
}
