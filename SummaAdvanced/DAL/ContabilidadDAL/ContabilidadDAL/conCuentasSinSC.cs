using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using ContabilidadCommon;
using System.Data;
namespace ContabilidadDAL
{
    public class conCuentasSinSC
    {
        public static void Guardar(string /*0*/pCuenta_Id, string /*1*/pDescripcion, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCuenta_Id, /*1*/pDescripcion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conCuentasSinSCGuardar", parametros);
        }
        public static conCuentasSinSCDS Datos(string /*0*/pCuenta_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCuenta_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conCuentasSinSCDatos", parametros);

            conCuentasSinSCDS dsTipado = new conCuentasSinSCDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pCuenta_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCuenta_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conCuentasSinSCEliminar", parametros);
        }



    }

}
