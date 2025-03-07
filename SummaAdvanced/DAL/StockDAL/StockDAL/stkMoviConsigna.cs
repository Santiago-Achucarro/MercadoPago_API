using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using StockCommon;


namespace StockDAL
{
    public class stkMoviConsigna
    {
        public static stkMoviConsignaDS Datos(long /*0*/pstkMoviCabe, int /*1*/pRenglon, int /*2*/pcomOrdenComp, int /*3*/pRenglon_OC, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, new Generalidades.NullableInt(/*1*/pRenglon), new Generalidades.NullableInt(/*2*/pcomOrdenComp), new Generalidades.NullableInt(/*3*/pRenglon_OC) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkMoviConsignaDatos", parametros);

            stkMoviConsignaDS dsTipado = new stkMoviConsignaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(long /*0*/pstkMoviCabe, int /*1*/pRenglon, int /*2*/pcomOrdenComp, int /*3*/pRenglon_OC, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, new Generalidades.NullableInt(/*1*/pRenglon), new Generalidades.NullableInt(/*2*/pcomOrdenComp), new Generalidades.NullableInt(/*3*/pRenglon_OC) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkMoviConsignaEliminar", parametros);
        }

        public static void Insertar(long /*0*/pstkMoviCabe, int /*1*/pRenglon, int /*2*/pcomOrdenComp, int /*3*/pRenglon_OC, decimal /*4*/pCantidad, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pRenglon, /*2*/pcomOrdenComp, /*3*/pRenglon_OC, /*4*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkMoviConsignaInsertar", parametros);
        }







    }
}
