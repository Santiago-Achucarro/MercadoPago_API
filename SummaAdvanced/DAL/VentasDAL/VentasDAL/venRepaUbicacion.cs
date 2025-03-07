using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using interfaceDAAB;
using System.Data;

namespace VentasDAL
{
    public class venRepaUbicacion
    {
        public static venRepaUbicacionDS Datos(int /*0*/pvenReparto, int /*1*/pRenglon_Rep, int /*2*/pvenPedidos, int /*3*/pRenglon_Pe, string /*4*/pUbicacion_Id, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenReparto, new Generalidades.NullableInt(/*1*/pRenglon_Rep),
                new Generalidades.NullableInt(/*2*/pvenPedidos), new Generalidades.NullableInt(/*3*/pRenglon_Pe),
                new Generalidades.NullableString(/*4*/pUbicacion_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venRepaUbicacionDatos", parametros);

            venRepaUbicacionDS dsTipado = new venRepaUbicacionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pvenReparto, int /*1*/pRenglon_Rep, int /*2*/pvenPedidos, int /*3*/pRenglon_Pe, string /*4*/pUbicacion_Id, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenReparto, new Generalidades.NullableInt(/*1*/pRenglon_Rep), new Generalidades.NullableInt(/*2*/pvenPedidos), new Generalidades.NullableInt(/*3*/pRenglon_Pe), new Generalidades.NullableString(/*4*/pUbicacion_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venRepaUbicacionEliminar", parametros);
        }

        public static void Insertar(int /*0*/pvenReparto, int /*1*/pRenglon_Rep, int /*2*/pvenPedidos, int /*3*/pRenglon_Pe, string /*4*/pUbicacion_Id, decimal /*5*/pCantidadForm, decimal /*6*/pCantidadAlternaForm, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenReparto, /*1*/pRenglon_Rep, /*2*/pvenPedidos, /*3*/pRenglon_Pe, /*4*/pUbicacion_Id, /*5*/pCantidadForm, /*6*/pCantidadAlternaForm };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venRepaUbicacionInsertar", parametros);
        }






    }
}
