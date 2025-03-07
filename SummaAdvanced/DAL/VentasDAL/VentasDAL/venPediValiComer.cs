using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using interfaceDAAB;
using System.Data;

namespace VentasDAL
{
    public class venPediValiComer
    {
        public static venPediValiComerDS Datos(int /*0*/pvenPedidos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venPediValiComerDatos", parametros);

            venPediValiComerDS dsTipado = new venPediValiComerDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(int /*0*/pvenPedidos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venPediValiComerEliminar", parametros);
        }

        public static void Guardar(int /*0*/pvenPedidos, bool /*1*/pMVendedor, bool /*2*/pMFormaE, bool /*3*/pMListaP, bool /*4*/pMBonifDato, bool /*5*/pMBonifReng, bool /*6*/pMPrecioReng, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos, /*1*/pMVendedor, /*2*/pMFormaE, /*3*/pMListaP, /*4*/pMBonifDato, /*5*/pMBonifReng, /*6*/pMPrecioReng };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venPediValiComerGuardar", parametros);
        }



    }
}
