using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ActivoFijoCommon;

namespace ActivoFijoDAL
{
    public class afiResponsablesActivo
    {
		public static afiResponsableActivoDS Datos(string /*0*/pResponsable_Id, string /*1*/pActivoFijo_Id, DateTime /*2*/pFechaAsignacion, string /*3*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pResponsable_Id, /*1*/pActivoFijo_Id, /*2*/pFechaAsignacion };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("afiResponsableActivoDatos", parametros);

			string[] camposTabla0 = { "Responsable_Id", "DescripcionResponsables" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			afiResponsableActivoDS dsTipado = new afiResponsableActivoDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Eliminar(string /*0*/pResponsable_Id, int /*1*/pEmpresa_Id, string /*2*/pActivoFijo_Id, string /*3*/ pAuxiliar)
		{
			Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pResponsable_Id), /*1*/pEmpresa_Id, /*2*/pActivoFijo_Id };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("afiResponsableActivoEliminar", parametros);
		}


		public static void Guardar(string /*0*/pResponsable_Id, string /*1*/pActivoFijo_Id, DateTime /*2*/pFechaAsignacion, int /*3*/pEmpresa_Id, decimal /*4*/pCantidad, string /*5*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pResponsable_Id, /*1*/pActivoFijo_Id, /*2*/pFechaAsignacion, /*3*/pEmpresa_Id, /*4*/pCantidad };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("afiResponsableActivoGuardar", parametros);
		}

	}
}
