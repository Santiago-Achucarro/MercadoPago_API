using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasFEEventos
{
    public class venCondFiscal
    {
        [Generalidades.QFuncion_CondicionGrilla]
        public String ValidarFila(VentasCommon.venCondFiscalDS exch, VentasCommon.venCondFiscalDS exchNoPost, 
            int pIndice, Framework.Core.Command cmd)
        {
            VentasCommon.venCondFiscalDS.grdImpuestosDataTable lRenglon = exchNoPost.grdImpuestos;

            if (lRenglon[0].Impuesto_Id == "")
                return "Debe_Ingresar_un_codigo_de_impuesto";
            return "";

        }
    }
}
