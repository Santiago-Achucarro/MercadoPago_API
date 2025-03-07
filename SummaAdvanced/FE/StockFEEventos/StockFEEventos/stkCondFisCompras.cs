using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockCommon;
using Framework.Core;

namespace StockFEEventos
{
    class stkCondFisCompras
    {


        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaImp(stkCondFisCompraDS exch, stkCondFisCompraDS exchNoPost,
            int pIndice, Command cmd)
        {

            // imp exsite, columna 0,tipo renglon existe


            if (exchNoPost.grdImpuestos[0].Impuesto_Id == "")
                return "Debe_Ingresar_Un_Codigo_de_impuesto";

            ComprasValidacion.comImpuestos.Existe(exchNoPost.grdImpuestos[0].Impuesto_Id, cmd);


            return "";
        }

    }
}


