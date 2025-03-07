using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebServiceCommon;

namespace WebServiceDAL
{
    public class swsToken
    {
		public static swsTokenDS Datos(string /*0*/pToken, string /*1*/pAccion, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pToken, /*1*/pAccion };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("swsTokenDatos", parametros);

			string[] camposTabla0 = { "ValidThru", "Dominio_Id", "Accion_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			swsTokenDS dsTipado = new swsTokenDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void EliminarVencido(DateTime /*0*/pFecha, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pFecha };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("swsTokenEliminarVencidos", parametros);
		}

		public static swsTokenGenerarDS Generar(string /*0*/pEmpresa_Id, string /*1*/pUsuario_Id, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pUsuario_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("swsTokenGenerar", parametros);

			string[] camposTabla0 = { "Password" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			swsTokenGenerarDS dsTipado = new swsTokenGenerarDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Guardar(string /*0*/pToken, string /*1*/pUsuario_Id, DateTime /*2*/pValidThru, string /*3*/pEmpresa_Id, string /*4*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pToken, /*1*/pUsuario_Id, /*2*/pValidThru, /*3*/pEmpresa_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("swsTokenGuardar", parametros);
		}

	}
}
