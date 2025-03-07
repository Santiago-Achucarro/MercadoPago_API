using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venMovConStockCrPed
    {
        public static venMovConStockCrPedDS Datos(int /*0*/pvenPedidos, int /*1*/pRenglon_Pe, long /*2*/pvenMovimientos,
            int /*3*/pRenglonCuerpo, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pvenPedidos),
                new Generalidades.NullableInt(/*1*/pRenglon_Pe), /*2*/pvenMovimientos, new Generalidades.NullableInt(/*3*/pRenglonCuerpo) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venMovConStockCrPedDatos", parametros);

            string[] camposTabla0 = { "venReparto", "Pedido", "Reparto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venMovConStockCrPedDS dsTipado = new venMovConStockCrPedDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pvenMovimientos, int /*1*/pRenglonCuerpo, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pRenglonCuerpo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venMovConStockCrPedEliminar", parametros);
        }


        public static void Guardar(int /*0*/pvenPedidos, int /*1*/pRenglon_Pe, long /*2*/pvenMovimientos,
            int /*3*/pRenglonCuerpo, int /*4*/pvenReparto, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos, /*1*/pRenglon_Pe, /*2*/pvenMovimientos, 
                /*3*/pRenglonCuerpo, new Generalidades.NullableInt(/*4*/pvenReparto) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venMovConStockCrPedGuardar", parametros);
        }

        public static venMovConStockCrPedDatosCancDS DatosCanc(long /*0*/pvenPedidos, int /*1*/pRenglon_Pe, long /*2*/pvenMovimientos, int /*3*/pRenglon_Ventas, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {new Generalidades.NullableInt64(/*0*/pvenPedidos), new Generalidades.NullableInt(/*1*/pRenglon_Pe), new Generalidades.NullableInt64(/*2*/pvenMovimientos), new Generalidades.NullableInt(/*3*/pRenglon_Ventas) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venMovConStockCrPedDatosCanc", parametros);

            string[] camposTabla0 = { "venReparto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venMovConStockCrPedDatosCancDS dsTipado = new venMovConStockCrPedDatosCancDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
