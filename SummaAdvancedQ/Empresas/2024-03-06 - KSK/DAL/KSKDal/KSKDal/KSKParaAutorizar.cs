using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using KSKCommon;
using System.Data;

namespace KSKDAL
{
    public class KSKParaAutorizar
    {
		public static espParaAutorizarKSKDS Datos(long /*0*/pvenMovimientos, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenMovimientos };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("KSKParaAutorizarDatos", parametros);

			string[] camposTabla0 = { "tesMovimientos", "Usuario_Id", "DescripcionUsuario" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			espParaAutorizarKSKDS dsTipado = new espParaAutorizarKSKDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}



		public static void Eliminar(long /*0*/pvenMovimientos, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenMovimientos };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("KSKParaAutorizarEliminar", parametros);
		}

		public static void Guardar(long /*0*/pvenMovimientos, long /*1*/ptesMovimientos, string /*2*/pCausa, string /*3*/pEstado, int /*4*/pUsuario_Id, string /*5*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/ptesMovimientos, /*2*/pCausa, /*3*/pEstado, new Generalidades.NullableInt(/*4*/pUsuario_Id) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("KSKParaAutorizarGuardar", parametros);
		}

		public static espPVAutorizarPendientesKSKDS Pendientes(int /*0*/pEmpresa_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("KSKPVAutorizarPendientes", parametros);

			string[] camposTabla1 = { "tesMovimientos", "Comprobante" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			espPVAutorizarPendientesKSKDS dsTipado = new espPVAutorizarPendientesKSKDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}








	}
}
