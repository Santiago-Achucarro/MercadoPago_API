using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkMoviSerieUbicacion
    {
        public static stkMoviSerieUbicacionDS Datos(long /*0*/pstkMoviCabe, int /*1*/pRenglon, string /*2*/pSerie, string /*3*/pUbicacion_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pRenglon, /*2*/pSerie, /*3*/pUbicacion_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkMoviSerieUbicacionDatos", parametros);

            stkMoviSerieUbicacionDS dsTipado = new stkMoviSerieUbicacionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pstkMoviCabe, int /*1*/pRenglon, string /*2*/pSerie, string /*3*/pUbicacion_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, new Generalidades.NullableInt(/*1*/pRenglon), new Generalidades.NullableString(/*2*/pSerie), new Generalidades.NullableString(/*3*/pUbicacion_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkMoviSerieUbicacionEliminar", parametros);
        }

        public static void Insertar(long /*0*/pstkMoviCabe, int /*1*/pRenglon, string /*2*/pSerie, string /*3*/pUbicacion_Id, decimal /*4*/pCantidad, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pRenglon, /*2*/pSerie, /*3*/pUbicacion_Id, /*4*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkMoviSerieUbicacionInsertar", parametros);
        }



    }
}
