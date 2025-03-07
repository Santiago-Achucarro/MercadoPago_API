using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venRepaPediSerie
    {

        public static venRepaPediSerieDS Datos(int /*0*/pvenReparto, int /*1*/pRenglon_Rep, int /*2*/pvenPedidos, int /*3*/pRenglon_Pe, string /*4*/pSerie, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenReparto, new Generalidades.NullableInt(/*1*/pRenglon_Rep), new Generalidades.NullableInt(/*2*/pvenPedidos), new Generalidades.NullableInt(/*3*/pRenglon_Pe), new Generalidades.NullableString(/*4*/pSerie) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venRepaPediSerieDatos", parametros);

            string[] camposTabla0 = { "Vencimiento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venRepaPediSerieDS dsTipado = new venRepaPediSerieDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(int /*0*/pvenReparto, int /*1*/pRenglon_Rep, int /*2*/pvenPedidos, int /*3*/pRenglon_Pe, 
            string /*4*/pSerie, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenReparto, new Generalidades.NullableInt(/*1*/pRenglon_Rep),
                new Generalidades.NullableInt(/*2*/pvenPedidos), new Generalidades.NullableInt(/*3*/pRenglon_Pe),
                new Generalidades.NullableString(/*4*/pSerie) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venRepaPediSerieEliminar", parametros);
        }

        public static void Guardar(int /*0*/pvenReparto, int /*1*/pRenglon_Rep, int /*2*/pvenPedidos, int /*3*/pRenglon_Pe, 
            string /*4*/pSerie, decimal /*5*/pCantidad, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenReparto, /*1*/pRenglon_Rep, /*2*/pvenPedidos, /*3*/pRenglon_Pe, /*4*/pSerie,
                /*5*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venRepaPediSerieGuardar", parametros);
        }



    }
}
