using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public static class venMovClieSuc
    {
        public static venMovClieSucDS Datos(long /*0*/pvenMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venMovClieSucDatos", parametros);

            venMovClieSucDS dsTipado = new venMovClieSucDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pvenMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venMovClieSucEliminar", parametros);
        }

        public static void Guardar(long /*0*/pvenMovimientos, long /*1*/pgenEntidades, int /*2*/pSucursal, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pgenEntidades, /*2*/pSucursal };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venMovClieSucGuardar", parametros);
        }
    }
}
