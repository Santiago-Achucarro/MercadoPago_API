using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesoreriaCommon;
namespace TesoreriaDAL
{
    public class tesFlujoFondos
    {
		public static tesFlujoFondoDS Datos(int /*0*/Empresa_Id, string /*1*/Segmento_Id, string /*2*/Segmento1C, string /*3*/Segmento2C, string /*4*/Segmento3C, string /*5*/Segmento4C, int /*6*/Segmento1N, int /*7*/Segmento2N, int /*8*/Segmento3N, int /*9*/Segmento4N, string /*10*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/Segmento_Id, /*2*/Segmento1C, /*3*/Segmento2C, /*4*/Segmento3C, /*5*/Segmento4C, /*6*/Segmento1N, /*7*/Segmento2N, /*8*/Segmento3N, /*9*/Segmento4N };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("tesFlujoFondoDatos", parametros);

			string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			tesFlujoFondoDS dsTipado = new tesFlujoFondoDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Eliminar(long /*0*/tesFlujoFondo, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/tesFlujoFondo };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("tesFlujoFondoEliminar", parametros);
		}

		public static Int64 Guardar(long /*0*/tesFlujoFondo, DateTime /*1*/pFechaDesde, DateTime /*2*/pFechaHasta, bool /*3*/pDetallaClientes, bool /*4*/pDetallaProveedores, int /*5*/pUsuario_Id, DateTime /*6*/pFechaRegistro, string /*7*/pPeriodo, string /*8*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/tesFlujoFondo, /*1*/pFechaDesde, /*2*/pFechaHasta, /*3*/pDetallaClientes, /*4*/pDetallaProveedores, /*5*/pUsuario_Id, /*6*/pFechaRegistro, /*7*/pPeriodo };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			return (Int64) oiDAAB.guardar("tesFlujoFondoGuardar", parametros);
		}




	}
}
