using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockCommon;

namespace StockDAL
{
    public class stkSolicitudCD
    {
		public static stkSolicitudCDDS Datos(string /*0*/pSegmento_Id, int /*1*/pSegmento1N, int /*2*/pSegmento2N, int /*3*/pSegmento3N, int /*4*/pSegmento4N, string /*5*/pSegmento1C, string /*6*/pSegmento2C, string /*7*/pSegmento3C, string /*8*/pSegmento4C, int /*9*/pEmpresa_Id, string /*10*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pSegmento_Id, /*1*/pSegmento1N, /*2*/pSegmento2N, /*3*/pSegmento3N, /*4*/pSegmento4N, /*5*/pSegmento1C, /*6*/pSegmento2C, /*7*/pSegmento3C, /*8*/pSegmento4C, /*9*/pEmpresa_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("stkSolicitudCDDatos", parametros);

			string[] camposTabla0 = { "Deposito_Id", "DescripcionDepositos" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Renglon", "Observaciones" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			stkSolicitudCDDS dsTipado = new stkSolicitudCDDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Eliminar(long /*0*/pstkSolicitudCD, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pstkSolicitudCD };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("stkSolicitudCDEliminar", parametros);
		}

		public static Int64 Guardar(long /*0*/pstkSolicitudCD, string /*1*/pDepositoDestino, DateTime /*2*/pFecha, string /*3*/pEstado, bool /*4*/pPosteado, int /*5*/pUsuario_Id, string /*6*/pObservaciones, string /*7*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pstkSolicitudCD, new Generalidades.NullableString(/*1*/pDepositoDestino), new Generalidades.NullableDate(/*2*/pFecha), /*3*/pEstado, /*4*/pPosteado, /*5*/pUsuario_Id, /*6*/pObservaciones };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			return ((Int64)oiDAAB.guardar("stkSolicitudCDGuardar", parametros));
		}

	}
}
