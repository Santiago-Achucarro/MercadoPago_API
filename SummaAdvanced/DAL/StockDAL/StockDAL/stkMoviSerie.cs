using interfaceDAAB;
using StockCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StockDAL
{
    public class stkMoviSerie
    {

        public static void Eliminar(long /*0*/pstkMoviCabe, int /*1*/pRenglon, string /*2*/pSerie, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/new Generalidades.NullableInt(pRenglon),
                new Generalidades.NullableString(/*2*/pSerie) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkMoviSerieEliminar", parametros);
        }

        public static void Guardar(long /*0*/pstkMoviCabe, int /*1*/pRenglon, string /*2*/pSerie, decimal /*3*/pCantidad,
            string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pRenglon, /*2*/pSerie, /*3*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkMoviSerieGuardar", parametros);
        }
    }
}
