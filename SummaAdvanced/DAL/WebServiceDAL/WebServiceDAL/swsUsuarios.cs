using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebServiceCommon;

namespace WebServiceDAL
{
    public class swsUsuarios
    {
		public static swsUsuariosDS Datos(bool /*0*/pTodos, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTodos };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("swsUsuariosDatos", parametros);

			string[] camposTabla0 = { "Todos" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Marca" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			swsUsuariosDS dsTipado = new swsUsuariosDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Usuarios.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Guardar(string /*0*/pUsuario_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pUsuario_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("swsUsuariosGuardar", parametros);
		}

		public static void Eliminar(string /*0*/pUsuario_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pUsuario_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("swsUsuariosEliminar", parametros);
		}

		public static void ActuPass(string /*0*/pUsuario_Id, string /*1*/pPassword, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pUsuario_Id, /*1*/pPassword };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("swsUsuariosActuPassword", parametros);
		}

	}
}
