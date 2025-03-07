using ImpuestosCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImpuestosFEEventos
{
    public class impCABATxt
    {
        [Generalidades.QFuncion_Condicion]
        public static string MT(impCABATxtDS exch, Framework.Core.Command cmd)
        {
            return exch.Principal[0].MesTrimestre;
        }
    }
}
