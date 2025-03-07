using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venCFDISat
    {
		public static venCFDISatDS Datos(string /*0*/pUUID, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pUUID };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("venCFDISatDatos", parametros);

			string[] camposTabla0 = { "Empresa_Id", "RFCReceptor", "Fecha", "Monto", "Impuestos", "Folio", "Serie", "XML", "Usuario_Id", "DescripcionUsuario", "FechaCarga", "TipoComprobante" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			venCFDISatDS dsTipado = new venCFDISatDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}


		public static void Eliminar(string /*0*/pUUID, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pUUID) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("venCFDISatEliminar", parametros);
		}

		public static void Guardar(string /*0*/pUUID, int /*1*/pEmpresa_Id, string /*2*/pRFCReceptor, DateTime /*3*/pFecha, decimal /*4*/pMonto, decimal /*5*/pImpuestos, long /*6*/pFolio, string /*7*/pSerie, 
				string /*8*/pXML, int /*9*/pUsuario, DateTime /*10*/pFechaCarga, string pTipoComprobante, string /*11*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pUUID, new Generalidades.NullableInt(/*1*/pEmpresa_Id), new Generalidades.NullableString(/*2*/pRFCReceptor), new Generalidades.NullableDate(/*3*/pFecha), /*4*/pMonto, /*5*/pImpuestos, /*6*/pFolio, new Generalidades.NullableString(/*7*/pSerie), new Generalidades.NullableString(/*8*/pXML), new Generalidades.NullableInt(/*9*/pUsuario), new Generalidades.NullableDate(/*10*/pFechaCarga), pTipoComprobante };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("venCFDISatGuardar", parametros);
		}

	}
}
