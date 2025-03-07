using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesoreriaFEEventos
{
    public class tesChequeras
    {
        [Generalidades.QFuncion_Condicion]
        public string DeBaja(TesoreriaCommon.tesChequerasDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Estado_id=="B")
            {
                return "S";
            }

            return "N";
        }
    }
}
