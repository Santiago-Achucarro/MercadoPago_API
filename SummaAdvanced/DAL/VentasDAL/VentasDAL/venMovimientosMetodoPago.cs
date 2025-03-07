using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venMovimientosMetodoPago
    {

        public static venMovimientosMetodoPagoDS Datos(long /*0*/pvenMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venMovimientosMetodoPagoDatos", parametros);

            string[] camposTabla0 = { "MetodoPago", "CuentaPago", "NMetodoPago", "UsoCfdi" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venMovimientosMetodoPagoDS dsTipado = new venMovimientosMetodoPagoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(long /*0*/pvenMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venMovimientosMetodoPagoEliminar", parametros);
        }

        public static void Guardar(long /*0*/pvenMovimientos, string /*1*/pMetodoPago, string /*2*/pCuentaPago, string /*3*/pNMetodoPago, string /*4*/pUsoCfdi, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, new Generalidades.NullableString(/*1*/pMetodoPago), new Generalidades.NullableString(/*2*/pCuentaPago), new Generalidades.NullableString(/*3*/pNMetodoPago), new Generalidades.NullableString(/*4*/pUsoCfdi) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venMovimientosMetodoPagoGuardar", parametros);
        }




    }
}
