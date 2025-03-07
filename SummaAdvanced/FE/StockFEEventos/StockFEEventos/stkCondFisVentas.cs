using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockCommon;
using Framework.Core;

namespace StockFEEventos
{
    public class stkCondFisVentas
    {
        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaImp(stkCondFisVentaDS exch, stkCondFisVentaDS exchNoPost,
           int pIndice, Command cmd)
        {

            // imp exsite, columna 0,tipo renglon existe


            if (exchNoPost.grdImpuestos[0].Impuesto_Id == "")
                return "Debe_Ingresar_Un_Codigo_de_impuesto";

            VentasValidacion.venImpuestos.Existe(exchNoPost.grdImpuestos[0].Impuesto_Id, cmd);


            return "";
        }
    }
}
