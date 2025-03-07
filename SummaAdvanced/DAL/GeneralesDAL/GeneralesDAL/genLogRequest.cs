using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genLogRequest
    {
		public static genLogRequestDS Datos(int /*0*/pgenLogRequest, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pgenLogRequest };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("genLogRequestDatos", parametros);

			string[] camposTabla0 = { "RequestEsp", "Accion", "Segmento_Id", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			genLogRequestDS dsTipado = new genLogRequestDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static int Guardar(string /*0*/pNombreClase, int /*1*/pEmpresa_Id, string /*2*/pTipo, string /*3*/pRequest, string /*4*/pRequestEsp, string /*5*/pAccion, string /*6*/pFormulario_Id, int /*7*/pUsuario_Id, string /*8*/pSegmento_Id, string /*9*/pSegmento1C, string /*10*/pSegmento2C, string /*11*/pSegmento3C, string /*12*/pSegmento4C, int /*13*/pSegmento1N, int /*14*/pSegmento2N, int /*15*/pSegmento3N, int /*16*/pSegmento4N, string /*17*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pNombreClase, /*1*/pEmpresa_Id, /*2*/pTipo, /*3*/pRequest, new Generalidades.NullableString(/*4*/pRequestEsp), new Generalidades.NullableString(/*5*/pAccion), /*6*/pFormulario_Id, /*7*/pUsuario_Id, new Generalidades.NullableString(/*8*/pSegmento_Id), new Generalidades.NullableString(/*9*/pSegmento1C), new Generalidades.NullableString(/*10*/pSegmento2C), new Generalidades.NullableString(/*11*/pSegmento3C), new Generalidades.NullableString(/*12*/pSegmento4C), new Generalidades.NullableInt(/*13*/pSegmento1N), new Generalidades.NullableInt(/*14*/pSegmento2N), new Generalidades.NullableInt(/*15*/pSegmento3N), new Generalidades.NullableInt(/*16*/pSegmento4N) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			return ((int)oiDAAB.guardar("genLogRequestGuardar", parametros));
		}


		public static void Eliminar(int /*0*/pgenLogRequest, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pgenLogRequest };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("genLogRequestEliminar", parametros);
		}

		public static genLogRequestDatosTodosDS DatosTodos(int /*0*/pEmpresa_Id, string /*1*/pTipo, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, new Generalidades.NullableString(/*1*/pTipo) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("genLogRequestDatosTodos", parametros);

			string[] camposTabla0 = { "Tipo" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "RequestEsp", "Accion", "Segmento_Id", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Comprobante" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			genLogRequestDatosTodosDS dsTipado = new genLogRequestDatosTodosDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Request.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}


		public static void Eliminar(string /*0*/pSegmento_Id, string /*1*/pSegmento1C, string /*2*/pSegmento2C, string /*3*/pSegmento3C, string /*4*/pSegmento4C, int /*5*/pSegmento1N, int /*6*/pSegmento2N, int /*7*/pSegmento3N, int /*8*/pSegmento4N, string /*9*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pSegmento_Id, /*1*/pSegmento1C, /*2*/pSegmento2C, /*3*/pSegmento3C, /*4*/pSegmento4C, /*5*/pSegmento1N, /*6*/pSegmento2N, /*7*/pSegmento3N, /*8*/pSegmento4N };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("genLogRequestXSegEliminar", parametros);
		}

		public static void EliminarXSeg(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, string /*2*/pSegmento1C, string /*3*/pSegmento2C, string /*4*/pSegmento3C, string /*5*/pSegmento4C, int /*6*/pSegmento1N, int /*7*/pSegmento2N, int /*8*/pSegmento3N, int /*9*/pSegmento4N, string /*10*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1C, /*3*/pSegmento2C, /*4*/pSegmento3C, /*5*/pSegmento4C, /*6*/pSegmento1N, /*7*/pSegmento2N, /*8*/pSegmento3N, /*9*/pSegmento4N };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("genLogRequestEliminarXSeg", parametros);
		}
	}
}
