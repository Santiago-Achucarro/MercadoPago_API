using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasExchange
{
    public class venPediCuerpoWrapper
    {
        public static venPediCuerpoActionExchange Guardar(int pvenPedidos, int pRenglon_Pe, string pProducto_Id, string pMedida_Id,
            string pDeposito_Id, decimal pFactor, decimal pCantidadOriginal)
        {
            venPediCuerpoActionExchange exch = new venPediCuerpoActionExchange(venPediCuerpoActionEnum.EnumvenPediCuerpoAction.Guardar);
            return exch;
        }
    }
}
