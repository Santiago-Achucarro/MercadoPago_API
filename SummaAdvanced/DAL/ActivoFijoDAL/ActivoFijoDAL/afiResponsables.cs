using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ActivoFijoCommon;

namespace ActivoFijoDAL
{
    public class afiResponsables
    {
		public static afiResponsablesDS Datos(string /*0*/pResponsable_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pResponsable_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("afiResponsablesDatos", parametros);

			string[] camposTabla0 = { "Responsable_Id", "Descripcion", "Empresa_Id", "PTodasEmpresas" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			afiResponsablesDS dsTipado = new afiResponsablesDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Eliminar(string /*0*/pResponsable_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pResponsable_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("afiResponsablesEliminar", parametros);
		}

		public static void Guardar(string /*0*/pResponsable_Id, string /*1*/pResponsable_Id_Nuevo, string /*2*/pDescripcion, int /*3*/pEmpresa_Id, bool /*4*/pPosteado, bool /*5*/pInactivo, string /*6*/ pAuxiliar)
		{
			Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pResponsable_Id), /*1*/pResponsable_Id_Nuevo, new Generalidades.NullableString(/*2*/pDescripcion), new Generalidades.NullableInt(/*3*/pEmpresa_Id), /*4*/pPosteado, /*5*/pInactivo };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("afiResponsablesGuardar", parametros);
		}

	}
}
