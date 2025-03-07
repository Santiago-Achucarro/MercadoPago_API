using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockFEEventos
{
    public class stkDepositos
    {
        [Generalidades.QFuncion_Condicion]
        public string Consignacion(StockCommon.stkDepositosDS exch, Framework.Core.Command cmd)
        {
            return (exch.Principal[0].Consignacion ? "S" : "N");

        }

        [Generalidades.QFuncion_Condicion]
        public string ConsCompra(StockCommon.stkDepositosDS exch, Framework.Core.Command cmd)
        {
            if ((exch.Principal[0].Consignacion) && (exch.Principal[0].consCompra_Venta))
                return "S";
            return "N";

        }
    }
}
