using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComprasFEEventos
{
    public class comImpuestos
    {
        [Generalidades.QFuncion_Condicion]
        public string PorAcreditacion(ComprasCommon.comImpuestosDS Exch)
        {
            return Exch.Principal[0].PorAcreditacion.ToString();

        }
        [Generalidades.QFuncion_Condicion]
        public string VaAlCosto(ComprasCommon.comImpuestosDS Exch)
        {
            return Exch.Principal[0].VaAlCosto.ToString();

        }


    }
}
