using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockCommon;
namespace StockFEEventos
{
    public class stkconsKardex
    {
        [Generalidades.QFuncion_CondicionGrilla]
        public string TieneDetalle(stkConsKardexDS exch, stkConsKardexDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            if (exch.Cuerpo[pIndice].Formulario_Id != "")
                return "S";
            return "N";
        }
    }
}
