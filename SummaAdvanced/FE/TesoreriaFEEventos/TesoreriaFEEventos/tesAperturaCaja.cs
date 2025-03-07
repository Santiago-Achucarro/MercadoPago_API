using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesoreriaFEEventos
{
    public class tesAperturaCaja
    {
        [Generalidades.QFuncion_Condicion]
        public string DosTiposCambio(TesoreriaCommon.tesAperturaCajaMonedasDS exch, Framework.Core.Command cmd)
        {
            // FM 02/08/2021 Que no pida más 2 TC //
            //if (cmd.Dominio_Id=="MX")
            //{
            //    return "N";
            //}

            //return "S";
            return "N";
        }
    }
}
