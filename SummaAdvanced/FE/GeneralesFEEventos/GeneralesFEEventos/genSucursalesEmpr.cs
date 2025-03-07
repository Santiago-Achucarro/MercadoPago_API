using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralesFEEventos
{
    public class genSucursalesEmpr
    {
        [Generalidades.QFuncion_Condicion]
        public string EsFacturaElectronica(GeneralesCommon.genSucursalesEmprDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].FacturaElectronica)
                return "S";
            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string UsaWS(GeneralesCommon.genSucursalesEmprDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].UsaWS)
                return "S";
            return "N";
        }
    }
}
