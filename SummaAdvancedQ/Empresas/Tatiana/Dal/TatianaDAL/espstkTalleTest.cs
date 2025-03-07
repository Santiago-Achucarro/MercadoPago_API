using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TatianaCommon;

namespace TatianaDAL
{
    public class espstkTalleTest
    {
		public static espstkTalleTestDS Datos(string /*0*/pTalle_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTalle_Id };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("espstkTalleTestDatos", parametros);

			string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			espstkTalleTestDS dsTipado = new espstkTalleTestDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}
		public static void Eliminar(string /*0*/pTalle_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pTalle_Id) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("espstkTalleTestEliminar", parametros);
		}
		public static void Guardar(string /*0*/pTalle_Id, string /*1*/pTalle_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, bool /*4*/pInactivo, int /*5*/pUsuario_Id, bool /*6*/pPosteado, string /*7*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTalle_Id, /*1*/pTalle_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, /*4*/pInactivo, /*5*/pUsuario_Id, /*6*/pPosteado };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("espstkTalleTestGuardar", parametros);
		}

	}
}
