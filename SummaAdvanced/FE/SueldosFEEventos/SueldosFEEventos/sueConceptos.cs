using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldosFEEventos
{
    public class sueConceptos
    {
        [Generalidades.QFuncion_Condicion]
        public string TipoConcepto(SueldosCommon.sueConceptosDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].IsSignoNull())
                return "A";
            if (exch.Principal[0].Signo == 1)
                return "D";
            if (exch.Principal[0].Signo == -1)
                return "H";
            if (exch.Principal[0].Signo == 0)
                return "A";
            return "";
        }
        [Generalidades.QFuncion_Condicion]
        public string TipoPercepcion(SueldosCommon.sueConceptosDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].TipoDeduccion == "006" || exch.Principal[0].TipoPercepcion == "014")
                return "I";
            if (exch.Principal[0].TipoDeduccion == "020")
                return "A";
            if (exch.Principal[0].TipoPercepcion == "019")
                return "H";
            return "N";
        }

    }       
}