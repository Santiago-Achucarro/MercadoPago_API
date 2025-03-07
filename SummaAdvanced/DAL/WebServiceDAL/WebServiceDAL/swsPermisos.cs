using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebServiceCommon;

namespace WebServiceDAL
{
    public class swsPermisos
    {
        public static swsPermisosDS Datos(string /*0*/pUsuario_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("swsPermisosDatos", parametros);

            string[] camposTabla1 = { "Marca" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            swsPermisosDS dsTipado = new swsPermisosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Permisos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pUsuario_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("swsPermisosEliminar", parametros);
        }

        public static void Guardar(string /*0*/pUsuario_Id, string /*1*/pAccion_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_Id, /*1*/pAccion_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("swsPermisosGuardar", parametros);
        }

    }
}
