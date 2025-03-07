using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneralesCommon;
using interfaceDAAB;
using System.Data;

namespace GeneralesDAL
{
    public class genUsuariosSucursal
    {
        public static genUsuariosSucursalDS Datos(string /*0*/pSucursal_Id, string /*1*/pEmpresa_Id, string /*2*/pUsuario_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pSucursal_Id), new Generalidades.NullableString(/*1*/pEmpresa_Id), new Generalidades.NullableString(/*2*/pUsuario_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genUsuariosSucursalDatos", parametros);

            genUsuariosSucursalDS dsTipado = new genUsuariosSucursalDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pSucursal_Id, string /*1*/pEmpresa_Id, string /*2*/pUsuario_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pSucursal_Id), new Generalidades.NullableString(/*1*/pEmpresa_Id), new Generalidades.NullableString(/*2*/pUsuario_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genUsuariosSucursalEliminar", parametros);
        }

        public static void Insertar(string /*0*/pSucursal_Id, string /*1*/pEmpresa_Id, string /*2*/pUsuario_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSucursal_Id, /*1*/pEmpresa_Id, /*2*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genUsuariosSucursalInsertar", parametros);
        }

    }
}
