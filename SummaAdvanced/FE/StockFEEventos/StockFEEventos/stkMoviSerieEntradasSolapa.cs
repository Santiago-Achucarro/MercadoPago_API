using StockCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockFEEventos
{
    public class stkMoviSerieEntradasSolapa
    {
        [Generalidades.QFuncion_AccionGrilla]
        public static stkMoviCabeDS SumarCant(stkMoviCabeDS exch, stkMoviCabeDS exchNoPost, int pIndice, 
            Framework.Core.Command cmd)
        {
            exchNoPost.grdCuerpo[0].CantidadForm = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }
    }
}
