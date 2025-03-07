using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldosFEEventos
{
    public class sueDatoXLS
    {
        [Generalidades.QFuncion_Condicion]
        public string EditaFechas(SueldosCommon.sueDatoXLSDS pCommonDS, Framework.Core.Command cmd)
        {
            if (cmd.Dominio_Id == "MX")
                return "S";
            return "N";
        }
    }
}
