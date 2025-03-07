using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasFEEventos
{
    public class venCondPago
    {
        [Generalidades.QFuncion_CondicionGrilla]
        public String ValidarFila(VentasCommon.venCondPagoDS exch, VentasCommon.venCondPagoDS exchNoPost, 
            int pRenglon, Framework.Core.Command cmd)
        {
            VentasCommon.venCondPagoDS.CuotasDataTable lRenglon = exchNoPost.Cuotas;

            if (lRenglon[0].Porcentaje <= 0)
                return "Debe_Ingresar_un_porcentaje_mayor_a_cero";

            if (lRenglon[0].Dias <= 0)
                return "Debe_informar_cantidad_de_dias_mayor_a_cero";

            return "";
        }
    }
}
