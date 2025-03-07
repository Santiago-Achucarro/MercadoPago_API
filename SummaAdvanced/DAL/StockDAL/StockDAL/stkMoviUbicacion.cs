using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using StockCommon;
using interfaceDAAB;
using System.Data;

namespace StockDAL
{
    public class stkMoviUbicacion
    {
        public static stkMoviUbicacionDS Datos(long /*0*/pstkMoviCabe, int /*1*/pRenglon, string /*2*/pUbicacion_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, new Generalidades.NullableInt(/*1*/pRenglon), new Generalidades.NullableString(/*2*/pUbicacion_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkMoviUbicacionDatos", parametros);

            stkMoviUbicacionDS dsTipado = new stkMoviUbicacionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pstkMoviCabe, int /*1*/pRenglon, string /*2*/pUbicacion_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, new Generalidades.NullableInt(/*1*/pRenglon), new Generalidades.NullableString(/*2*/pUbicacion_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkMoviUbicacionEliminar", parametros);
        }

        public static void Insertar(long /*0*/pstkMoviCabe, int /*1*/pRenglon, string /*2*/pUbicacion_Id, decimal /*3*/pCantidad, decimal /*4*/pCantidadAlterna, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pRenglon, /*2*/pUbicacion_Id, /*3*/pCantidad, /*4*/pCantidadAlterna };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkMoviUbicacionInsertar", parametros);
        }





    }
}
