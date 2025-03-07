using interfaceDAAB;
using StockDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StockDAL
{
    public class stkMoviCausa
    {
        public static void Eliminar(long /*0*/pstkMoviCabe, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkMoviCausaEliminar", parametros);
        }

        public static void Guardar(long /*0*/pstkMoviCabe, string /*1*/pCausa_Id, string /*2*/pCentro1_Id, 
            string /*3*/pCentro2_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pCausa_Id, /*2*/pCentro1_Id, /*3*/pCentro2_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkMoviCausaGuardar", parametros);
        }
    }
}
