using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace VentasFEEventos
{
    public class venImpuestos
    {

        [Generalidades.QFuncion_Condicion]
        public string PorVencimiento(VentasCommon.venImpuestosDS exch, Framework.Core.Command cmd)
        {
            return exch.Principal[0].PorVencimiento ? "S" : "N";
            
        }

        [Generalidades.QFuncion_Condicion]
        public string UsaFormula(VentasCommon.venImpuestosDS exch, Framework.Core.Command cmd)
        {
            return exch.Principal[0].UsaFormula ? "S" : "N";

        }
    }
}
