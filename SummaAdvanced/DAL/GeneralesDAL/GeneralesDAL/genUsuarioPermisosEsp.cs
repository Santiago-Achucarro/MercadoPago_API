using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genUsuarioPermisosEsp
    {
		public static genUsuarioPermisosEspDS Datos(string /*0*/pUsuario_Id, int /*1*/pPermiso_Id, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pUsuario_Id, new Generalidades.NullableInt(/*1*/pPermiso_Id) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("genUsuarioPermisosEspDatos", parametros);

			string[] camposTabla0 = { "Permiso_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Marcado" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			genUsuarioPermisosEspDS dsTipado = new genUsuarioPermisosEspDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Permisos.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Eliminar(string /*0*/pUsuario_Id, int /*1*/pPermiso_Id, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pUsuario_Id, new Generalidades.NullableInt(/*1*/pPermiso_Id) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("genUsuarioPermisosEspEliminar", parametros);
		}



		public static void Guardar(string /*0*/pUsuario_Id, int /*1*/pPermiso_Id, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pUsuario_Id, /*1*/pPermiso_Id };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("genUsuarioPermisosEspGuardar", parametros);
		}




	}
}
