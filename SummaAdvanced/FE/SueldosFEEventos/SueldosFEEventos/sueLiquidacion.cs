using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldosFEEventos
{
    public class sueLiquidacion
    {
        [Generalidades.QFuncion_Condicion]
        public string EditaPeriodicidad(SueldosCommon.sueLiquidacionGenerarDS pCommonDS, Command cmd)
        {
            if (cmd.Dominio_Id != "MX")
                return "S";
            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string Clase(SueldosCommon.sueLiquidacionGenerarDS exch, Framework.Core.Command cmd)
        {
            return exch.Principal[0].TipoLiq;
        }
    }
}
