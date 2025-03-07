using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
   public class comConsEdoCtaProveedoresTesoreria
    {
		public static comConsEdoCtaProveedoresTesoreriaDS Datos(string /*0*/Proveed_Id_Desde, string /*1*/Proveed_Id_Hasta, int /*2*/PendHist, DateTime /*3*/FechaDesde, DateTime /*4*/FechaHasta, string /*5*/Moneda_Id, int /*6*/Empresa, string /*7*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/Proveed_Id_Desde, /*1*/Proveed_Id_Hasta, /*2*/PendHist, /*3*/FechaDesde, /*4*/FechaHasta, new Generalidades.NullableString(/*5*/Moneda_Id), /*6*/Empresa };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("comConsEdoCtaProveedoresTesoreria", parametros);

			string[] camposTabla0 = { "Proveed_Id_Desde", "Proveed_Id_Hasta", "PendHist", "FechaDesde", "FechaHasta", "Moneda_Id", "Empresa", "FechaAplicacion", "FechaApli", "OrigenXml" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Segmento", "Fecha", "Debe", "Haber", "Saldo", "SaldoAcum", "FechaVencimiento", "FechaRegistro", "EditaEmbarques", "Observaciones", "TipoCtaProv", "TipoCtaProvDescripcion" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			string[] camposTabla4 = { "Fecha", "Seleccionar", "Asiento_Id", "NroCuota", "AsientoApli_Id", "AsiDifCambio_Id", "Importacion" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

			string[] camposTabla6 = { "Fecha" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

			string[] camposTabla7 = { "FechaDoc" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

			string[] camposTabla8 = { "Asiento_Id", "Fecha", "NroCuota" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

			string[] camposTabla9 = { "Asiento_Id", "Cuota_Nro" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[9], camposTabla9);

			string[] camposTabla10 = { "comEmbarque", "comMovProv" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[10], camposTabla10);

			string[] camposTabla11 = { "SegmentoSTR" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[11], camposTabla11);

			string[] camposTabla12 = { "SegmentoSTR" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[12], camposTabla12);

			comConsEdoCtaProveedoresTesoreriaDS dsTipado = new comConsEdoCtaProveedoresTesoreriaDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.Inventario.TableName, dsTipado.AsientoContable.TableName, dsTipado.Aplicaciones.TableName, dsTipado.Impuestos.TableName, dsTipado.OrdenCompra.TableName, dsTipado.Valores.TableName, dsTipado.Comprobantes.TableName, dsTipado.CompAAplic.TableName, dsTipado.Embarques.TableName, dsTipado.EmbCons.TableName, dsTipado.Oc.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}








	}
}
