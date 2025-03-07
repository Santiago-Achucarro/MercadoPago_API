using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venPediRemitidos
    {
        public static venPediRemitidosDS Datos(int /*0*/pvenPedidos, int /*1*/pRenglon_Pe, int /*2*/pRenglon, 
            long /*3*/pstkMoviCabe, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos, /*1*/pRenglon_Pe, /*2*/pRenglon, /*3*/pstkMoviCabe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venPediRemitidosDatos", parametros);

            string[] camposTabla0 = { "venReparto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venPediRemitidosDS dsTipado = new venPediRemitidosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(int /*0*/pvenPedidos, int /*1*/pRenglon_Pe, int /*2*/pRenglon, 
            long /*3*/pstkMoviCabe, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos, /*1*/pRenglon_Pe, /*2*/pRenglon, /*3*/pstkMoviCabe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venPediRemitidosEliminar", parametros);
        }

        public static void Guardar(int /*0*/pvenPedidos, int /*1*/pRenglon_Pe, int /*2*/pRenglon, 
            long /*3*/pstkMoviCabe, int /*4*/pvenReparto, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos, /*1*/pRenglon_Pe, /*2*/pRenglon, /*3*/pstkMoviCabe,
                new Generalidades.NullableInt(/*4*/pvenReparto) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venPediRemitidosGuardar", parametros);
        }

        public static venPediRemitidosDatosCancDS DatosCanc(long /*0*/pvenPedidos, int /*1*/pRenglon_Pedido, long /*2*/pstkMoviCabe, int /*3*/pRenglon_Stock, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {new Generalidades.NullableInt64(/*0*/pvenPedidos), new Generalidades.NullableInt(/*1*/pRenglon_Pedido), /*2*/pstkMoviCabe, new Generalidades.NullableInt(/*3*/pRenglon_Stock) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venPediRemitidosDatosCanc", parametros);

            venPediRemitidosDatosCancDS dsTipado = new venPediRemitidosDatosCancDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
