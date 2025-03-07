using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;

namespace ComprasFEEventos
{
    public class comMovProvRemiPend
    {
        [Generalidades.QFuncion_Condicion]
        public string EsMonedaBase(ComprasCommon.comMovProvRemiPendDS exch, Command cmd)
        {
            if (exch.Principal[0].Moneda_Id == cmd.MonedaBase || exch.Principal[0].Moneda_Id.Trim() == "")
                return "S";

            return "N";

        }

        [Generalidades.QFuncion_Condicion]
        public string PideCuotas(ComprasCommon.comMovProvRemiPendDS exch, Command cmd)
        {

            return exch.Principal[0].CantCuotas > 1 ? "S" : "N";

        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaImp(ComprasCommon.comMovProvRemiPendDS exch, ComprasCommon.comMovProvRemiPendDS exchNoPost,
           int pIndice, Command cmd)
        {
            ComprasCommon.comMovProvRemiPendDS.grdImpuestosDataTable lDF = exchNoPost.grdImpuestos;

            if (lDF[0].Impuesto_Id == "")
                return "El_Impuesto_No_puede_ser_Vacio";

            // TODO DUPLICADO

            return "";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFila(ComprasCommon.comMovProvRemiPendDS exch, ComprasCommon.comMovProvRemiPendDS exchNoPost,
        int pIndice, Command cmd)
        {

            exchNoPost.grdCuerpo[0].CantidadFacturado = exchNoPost.grdCuerpo[0].CantidadOriginalFact *
                    exchNoPost.grdCuerpo[0].Factor;

            if (exchNoPost.grdCuerpo[0].CantidadOriginalFact > exchNoPost.grdCuerpo[0].CantidadOriginal)
                return "La_cantidad_facturada_debe_ser_menor_o_igual_a_la_recibida";
            
            return "";
        }


        

    }
}
