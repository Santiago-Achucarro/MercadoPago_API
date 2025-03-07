using interfaceDAAB;
using StockCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StockDAL
{
    public class stkMoviEmbarque
    {

        public static void Eliminar(long /*0*/pstkMoviCabe, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkMoviEmbarqueEliminar", parametros);
        }

        public static void Guardar(long /*0*/pstkMoviCabe, long /*1*/pcomEmbarques, string /*2*/pProveed_Id, 
            string /*3*/pRemitoProv, string /*4*/pDespacho_Id, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pcomEmbarques, /*2*/pProveed_Id, 
                /*3*/pRemitoProv, new Generalidades.NullableString(/*4*/pDespacho_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkMoviEmbarqueGuardar", parametros);
        }
    }
}
