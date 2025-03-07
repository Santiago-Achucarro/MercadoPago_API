using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesoreriaExchange;
using Framework.Core;

namespace TesoreriaFEEventos
{
    public class tesCheqBusquedaDS
    {
        [Generalidades.QFuncion_Condicion]
        public int Tipo(TesoreriaReportesCommon.tesCheqBusquedaDS pCommonDS, Command cmd)
        {
            int lRetorno = pCommonDS.Principal[0].Tipo;
        
            return lRetorno;
        }
    }
}
