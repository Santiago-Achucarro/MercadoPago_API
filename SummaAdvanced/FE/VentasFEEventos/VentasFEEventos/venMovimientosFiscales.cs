using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasFEEventos
{
    public class venMovimientosFiscales
    {
        [Generalidades.QFuncion_Condicion]
        public string EsOrdinario(string pTipoProceso)
        {
            if (pTipoProceso == "Ordinario")
                return "S";
            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string EsEstatal(string pTipoComite)
        {
            if (pTipoComite.Contains("Estatal"))
                return "S";
            return "N";
        }


    }
}
