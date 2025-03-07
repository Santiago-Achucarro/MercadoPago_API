using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venPedidosAnul
    {
        public static venPedidosAnulDS Datos(int /*0*/pvenPedidos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venPedidosAnulDatos", parametros);

            venPedidosAnulDS dsTipado = new venPedidosAnulDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Guardar(int /*0*/pvenPedidos, DateTime /*1*/pFecha, string /*2*/pOperacion, int /*3*/pUsuario_Id, 
            string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos, /*1*/pFecha, /*2*/pOperacion, /*3*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venPedidosAnulGuardar", parametros);
        }

        public static void Eliminar(int /*0*/pvenPedidos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venPedidosAnulEliminar", parametros);
        }
    }
}
