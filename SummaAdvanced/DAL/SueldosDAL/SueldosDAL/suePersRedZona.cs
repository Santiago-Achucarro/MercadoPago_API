using SueldosCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SueldosDAL
{
    public class suePersRedZona
    {
		public static suePersRedZonalDS Datos(long /*0*/pLegajo, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pLegajo };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("suePersRedZonalDatos", parametros);

			string[] camposTabla0 = { "Usuario_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			suePersRedZonalDS dsTipado = new suePersRedZonalDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Eliminar(long /*0*/pLegajo, DateTime /*1*/pFechaDesde, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pLegajo, new Generalidades.NullableDate(/*1*/pFechaDesde) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("suePersRedZonalEliminar", parametros);
		}

		public static void Guardar(long /*0*/pLegajo, DateTime /*1*/pFechaDesde, DateTime /*2*/pFechaHasta, decimal /*3*/pReduccion, int /*4*/pUsuario_Id, string /*5*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pFechaDesde, /*2*/pFechaHasta, /*3*/pReduccion, new Generalidades.NullableInt(/*4*/pUsuario_Id) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("suePersRedZonalGuardar", parametros);
		}
	}
}
