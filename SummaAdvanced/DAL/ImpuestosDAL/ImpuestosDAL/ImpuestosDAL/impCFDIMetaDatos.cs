using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using ImpuestosCommon;
using System.Data;

namespace ImpuestosDAL
{
    public class impCFDIMetaDatos
    {
		public static impCfdiMetaDatosDS Datos(string /*0*/pUuid, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pUuid };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("impCfdiMetaDatosDatos", parametros);

			string[] camposTabla0 = { "NombreReceptor", "FechaCancelacion" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			impCfdiMetaDatosDS dsTipado = new impCfdiMetaDatosDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Eliminar(string /*0*/pUuid, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pUuid) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("impCfdiMetaDatosEliminar", parametros);
		}

		public static void EliminarxFecha(DateTime /*0*/pFechaDesde, DateTime /*1*/pFechaHasta, int /*2*/pEmpresa_Id, string /*3*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pFechaDesde, /*1*/pFechaHasta, /*2*/pEmpresa_Id };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("impCfdiMetaDatosEliminarxFecha", parametros);
		}

		public static void Guardar(string /*0*/pUuid, string /*1*/pRfcEmisor, string /*2*/pNombreEmisor, string /*3*/pRfcReceptor, string /*4*/pNombreReceptor, string /*5*/pRfcPac, DateTime /*6*/pFechaEmision, DateTime /*7*/pFechaCertificacionSat, decimal /*8*/pMonto, string /*9*/pEfectoComprobante, bool /*10*/pEstatus, DateTime /*11*/pFechaCancelacion, DateTime /*12*/pFechaDescarga, int /*13*/pUsuario_Id, int /*14*/pEmpresa_Id, string /*15*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pUuid, /*1*/pRfcEmisor, /*2*/pNombreEmisor, /*3*/pRfcReceptor, new Generalidades.NullableString(/*4*/pNombreReceptor), /*5*/pRfcPac, /*6*/pFechaEmision, /*7*/pFechaCertificacionSat, /*8*/pMonto, /*9*/pEfectoComprobante, /*10*/pEstatus, new Generalidades.NullableDate(/*11*/pFechaCancelacion), /*12*/pFechaDescarga, /*13*/pUsuario_Id, /*14*/pEmpresa_Id };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("impCfdiMetaDatosGuardar", parametros);
		}




	}
}
