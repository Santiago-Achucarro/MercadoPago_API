using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using TesoreriaCommon;
using interfaceDAAB;
namespace TesoreriaDAL
{
    public class tesFFPagosOtros
    {

		public static tesFFPagosOtrosDS Datos(long /*0*/ptesFlujoFondo, DateTime /*1*/pFecha, int /*2*/pRenglon, string /*3*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/ptesFlujoFondo, /*1*/pFecha, /*2*/pRenglon };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("tesFFPagosOtrosDatos", parametros);

			string[] camposTabla0 = { "Impuesto_Id", "DescripcionImpuesto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			tesFFPagosOtrosDS dsTipado = new tesFFPagosOtrosDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Eliminar(long /*0*/ptesFlujoFondo, DateTime /*1*/pFechaDesde, DateTime /*2*/pFechaHasta, string /*3*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/ptesFlujoFondo, /*1*/pFechaDesde, /*2*/pFechaHasta };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("tesFFPagosOtrosEliminar", parametros);
		}

		public static void Guardar(long /*0*/ptesFlujoFondo, DateTime /*1*/pFecha, int /*2*/pRenglon, string /*3*/pDescripcion, string /*4*/pTipo, string /*5*/pImpuesto_Id, string /*6*/pMoneda_Id, decimal /*7*/pMonto, string /*8*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/ptesFlujoFondo, /*1*/pFecha, /*2*/pRenglon, /*3*/pDescripcion, /*4*/pTipo, new Generalidades.NullableString(/*5*/pImpuesto_Id), /*6*/pMoneda_Id, /*7*/pMonto };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("tesFFPagosOtrosGuardar", parametros);
		}






	}
}
