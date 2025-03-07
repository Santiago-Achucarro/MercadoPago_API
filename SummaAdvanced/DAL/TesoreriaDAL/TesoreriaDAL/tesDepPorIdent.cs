using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesDepPorIdent
    {
		public static tesDepoPorIdentDS Datos(long /*0*/ptesMovimientos, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/ptesMovimientos };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("tesDepoPorIdentDatos", parametros);

			string[] camposTabla0 = { "venMovimientos" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			tesDepoPorIdentDS dsTipado = new tesDepoPorIdentDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Impuestos.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Eliminar(long /*0*/ptesMovimientos, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/ptesMovimientos };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("tesDepoPorIdentEliminar", parametros);
		}

		public static void Guardar(long /*0*/ptesMovimientos, long /*1*/pvenMovimientos, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/ptesMovimientos, new Generalidades.NullableInt64(/*1*/pvenMovimientos) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);
			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("tesDepoPorIdentGuardar", parametros);
		}


		public static tesDepIdentificacionDS DatoPendientes(int /*0*/Empresa_Id, string /*1*/Cartera_id, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/Cartera_id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("tesDepIdentificacionDatos", parametros);

			string[] camposTabla0 = { "Fecha" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Comprobante" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			string[] camposTabla2 = { "tesMovimientos", "venMovimientos", "Fecha", "NroCuota", "FechaVencimiento" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

			tesDepIdentificacionDS dsTipado = new tesDepIdentificacionDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Depositos.TableName, dsTipado.Aplicaciones.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static tesDepoPorIdentVenDS DatosVen(long /*0*/pVenMovimientos, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pVenMovimientos };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("tesDepoPorIdentVenDatos", parametros);

			string[] camposTabla0 = { "venMovimientos" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			tesDepoPorIdentVenDS dsTipado = new tesDepoPorIdentVenDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}





	}
}
