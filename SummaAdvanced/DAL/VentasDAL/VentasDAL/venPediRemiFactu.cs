using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venPediRemiFactu
    {
        public static venPediRemiFactuDS Datos(int /*0*/pvenPedidos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venPediRemiFactuDatos", parametros);

            string[] camposTabla0 = { "venPedidos" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Remitos" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Facturas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Repartos" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            venPediRemiFactuDS dsTipado = new venPediRemiFactuDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Remitos.TableName, dsTipado.Facturas.TableName,
                dsTipado.Repartos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
