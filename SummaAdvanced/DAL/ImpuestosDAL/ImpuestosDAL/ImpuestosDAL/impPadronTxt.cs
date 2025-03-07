using ImpuestosCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpuestosDAL
{
    public class impPadronTxt
    {
		public static impPadronTxtDS Datos(string /*0*/pPadron_Id, string /*1*/pCuit, int /*2*/pAnio, int /*3*/pMes, int /*4*/pTrimestre, string /*5*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pPadron_Id, /*1*/pCuit, /*2*/pAnio, /*3*/pMes, /*4*/pTrimestre };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("impPadronTxtDatos", parametros);

			string[] camposTabla0 = { "Anio", "Mes", "Alicuota", "StoreProcedure" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			impPadronTxtDS dsTipado = new impPadronTxtDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}







		//public static void Importar(long /*0*/pimpPadronTxt, string /*1*/pCodigoArchivo_Id, string /*2*/pCuit, int /*3*/pAnio, int /*4*/pMes, int /*5*/pTrimestre, string /*6*/pRegimen, DateTime /*7*/pFechaVigDesde, DateTime /*8*/pFechaVigHasta, decimal /*9*/pAlicuota, short /*10*/pNumber, string /*11*/pExcluido, string /*12*/pTipo, decimal /*13*/pCoeficiente, string /*14*/ pAuxiliar)
		//{
		//	Object[] parametros = new Object[] {/*0*/pimpPadronTxt, new Generalidades.NullableString(/*1*/pCodigoArchivo_Id), new Generalidades.NullableString(/*2*/pCuit), new Generalidades.NullableInt(/*3*/pAnio), new Generalidades.NullableInt(/*4*/pMes), new Generalidades.NullableInt(/*5*/pTrimestre), new Generalidades.NullableString(/*6*/pRegimen), new Generalidades.NullableDate(/*7*/pFechaVigDesde), new Generalidades.NullableDate(/*8*/pFechaVigHasta), /*9*/pAlicuota, new Generalidades.NullableShort(/*10*/pNumber), new Generalidades.NullableString(/*11*/pExcluido), new Generalidades.NullableString(/*12*/pTipo), /*13*/pCoeficiente };

		//	Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

		//	interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

		//	oiDAAB.guardar("impPadronTxtGuardar", parametros);
		//}

		public static long Importar(string pArchivo, string pPadron_Id, Int16 pAnio, Int16 pMes, Int16 pTrimestre,  string pSP, string pAuxiliar)
		{
			object[] parametros = { pArchivo, pPadron_Id, pAnio, pMes, pTrimestre };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			return (long)oiDAAB.guardar(pSP, parametros);
		}

		public static void BorrarAnteriores(string pPadron_Id, string pAuxiliar)
		{
			object[] parametros = { pPadron_Id };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("impPadronTxtEliminarUlt", parametros);
		}
	}
}
