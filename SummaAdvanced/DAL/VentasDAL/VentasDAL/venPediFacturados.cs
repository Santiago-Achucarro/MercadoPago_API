using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using System.Data;
using interfaceDAAB;

namespace VentasDAL
{
    public class venPediFacturados
    {
        public static venPediFacturadosDS Datos(long /*0*/pvenMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venPediFacturadosDatos", parametros);

            string[] camposTabla0 = { "PedidoStr", "Reparto_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venPediFacturadosDS dsTipado = new venPediFacturadosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(long /*0*/pvenMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venPediFacturadosEliminar", parametros);
        }

        public static void Guardar(long /*0*/pvenMovimientos, int /*1*/pvenPedidos, decimal /*2*/pImporte, int /*3*/pReparto_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pvenPedidos, /*2*/pImporte, new Generalidades.NullableInt(/*3*/pReparto_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venPediFacturadosGuardar", parametros);
        }





    }
}
