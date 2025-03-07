using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasCommon;

namespace ComprasFEEventos
{
    public class comEmbarques
    {
        [Generalidades.QFuncion_ObtenerParametrosReporte]
        public String ObtenerParametrosRepo(comEmbarquesDS exch, Framework.Core.Command cmd)
        {
            string a = "Empresa_Id|" + cmd.Empresa_Id.ToString() + "@Segmento_Id|EMB" +
                  "@Segmento1N|" + exch.Principal[0].Segmento1N.ToString() +
                  "@Segmento2N|" + exch.Principal[0].Segmento2N.ToString() +
                  "@Segmento3N|" + exch.Principal[0].Segmento3N.ToString() +
                  "@Segmento4N|" + exch.Principal[0].Segmento4N.ToString() +
                  "@Segmento1C|" + exch.Principal[0].Segmento1C +
                  "@Segmento2C|" + exch.Principal[0].Segmento2C +
                  "@Segmento3C|" + exch.Principal[0].Segmento3C +
                  "@Segmento4C|" + exch.Principal[0].Segmento4C;

            return a;
        }
    }
}
