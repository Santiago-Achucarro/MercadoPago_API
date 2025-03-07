using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasCommon;
namespace VentasDAL
{
    public class venCompCartaPorteFact
    {
		public static venCartaPorteFactDS Datos(long /*0*/pvenMovimientosFactCP, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenMovimientosFactCP };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venCartaPorteFactDatos", parametros);

			string[] camposTabla0 = { "venMovimientosFact" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			venCartaPorteFactDS dsTipado = new venCartaPorteFactDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}




		public static void Eliminar(long /*0*/pvenMovimientosFactCP, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenMovimientosFactCP };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("venCartaPorteFactEliminar", parametros);
		}

		public static void Guardar(long /*0*/pvenMovimientosFactCP, long /*1*/pvenMovimientosFact, int /*2*/pParada, decimal /*3*/pDistanciaRecorrida, DateTime /*4*/pFechaHoraLLegada, string /*5*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenMovimientosFactCP, /*1*/pvenMovimientosFact, /*2*/pParada, /*3*/pDistanciaRecorrida, /*4*/pFechaHoraLLegada };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("venCartaPorteFactGuardar", parametros);
		}



		public static venCartaPorteFactDatosFactDS DatosFact(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venCartaPorteFactDatosFact", parametros);

			string[] camposTabla0 = { "venMovimientosFact" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			venCartaPorteFactDatosFactDS dsTipado = new venCartaPorteFactDatosFactDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.CartasPorte.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}




	}
}
