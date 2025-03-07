using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;

namespace ComprasFEEventos
{
    public class comDespachos
    {
        [Generalidades.QFuncion_Condicion]
        public string EsMonedaBase(ComprasCommon.comDespachosDS exch, Command cmd)
        {

            // TODO DEBEN VENIR COMO PARAMETRO LAS VARIABLES GLOBALES
            if (exch.Principal[0].Moneda_Id == cmd.MonedaBase)
                return "S";

            return "N";

        }
    }
}
