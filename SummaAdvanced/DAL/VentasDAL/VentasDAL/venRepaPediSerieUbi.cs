using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using interfaceDAAB;
using System.Data;

namespace VentasDAL
{
    public class venRepaPediSerieUbi
    {

        public static venRepaPediSerieUbiDS Datos(int /*0*/pvenReparto, int /*1*/pRenglon_Rep, int /*2*/pvenPedidos, int /*3*/pRenglon_Pe, string /*4*/pSerie, string /*5*/pUbicacion_Id, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenReparto, new Generalidades.NullableInt(/*1*/pRenglon_Rep), new Generalidades.NullableInt(/*2*/pvenPedidos), new Generalidades.NullableInt(/*3*/pRenglon_Pe), new Generalidades.NullableString(/*4*/pSerie), new Generalidades.NullableString(/*5*/pUbicacion_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venRepaPediSerieUbiDatos", parametros);

            venRepaPediSerieUbiDS dsTipado = new venRepaPediSerieUbiDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pvenReparto, int /*1*/pRenglon_Rep, int /*2*/pvenPedidos, int /*3*/pRenglon_Pe, string /*4*/pSerie, string /*5*/pUbicacion_Id, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenReparto, new Generalidades.NullableInt(/*1*/pRenglon_Rep), new Generalidades.NullableInt(/*2*/pvenPedidos), new Generalidades.NullableInt(/*3*/pRenglon_Pe), new Generalidades.NullableString(/*4*/pSerie), new Generalidades.NullableString(/*5*/pUbicacion_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venRepaPediSerieUbiEliminar", parametros);
        }


        public static void Insertar(int /*0*/pvenReparto, int /*1*/pRenglon_Rep, int /*2*/pvenPedidos, int /*3*/pRenglon_Pe, string /*4*/pSerie, string /*5*/pUbicacion_Id, decimal /*6*/pCantidad, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenReparto, /*1*/pRenglon_Rep, /*2*/pvenPedidos, /*3*/pRenglon_Pe, /*4*/pSerie, /*5*/pUbicacion_Id, /*6*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venRepaPediSerieUbiInsertar", parametros);
        }


    }
}
