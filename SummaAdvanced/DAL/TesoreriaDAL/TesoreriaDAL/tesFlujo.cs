using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesoreriaCommon;
namespace TesoreriaDAL
{
    public class tesFlujo
    {
		public static tesFlujoDS Datos(int /*0*/Empresa_Id, string /*1*/Segmento_Id, string /*2*/Segmento1C, string /*3*/Segmento2C, string /*4*/Segmento3C, string /*5*/Segmento4C, int /*6*/Segmento1N, int /*7*/Segmento2N, int /*8*/Segmento3N, int /*9*/Segmento4N, DateTime /*10*/FechaDesde, DateTime /*11*/FechaHasta, string /*12*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/Segmento_Id, /*2*/Segmento1C, /*3*/Segmento2C, /*4*/Segmento3C, /*5*/Segmento4C, /*6*/Segmento1N, /*7*/Segmento2N, /*8*/Segmento3N, /*9*/Segmento4N, new Generalidades.NullableDate(/*10*/FechaDesde), new Generalidades.NullableDate(/*11*/FechaHasta) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("tesFlujoDatos", parametros);

			string[] camposTabla1 = { "Fecha", "Dia" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			string[] camposTabla2 = { "Fecha", "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

			string[] camposTabla3 = { "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

			string[] camposTabla4 = { "Fecha", "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

			string[] camposTabla5 = { "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

			string[] camposTabla6 = { "Fecha", "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

			string[] camposTabla7 = { "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

			string[] camposTabla8 = { "Fecha", "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

			string[] camposTabla9 = { "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[9], camposTabla9);

			string[] camposTabla10 = { "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[10], camposTabla10);

			string[] camposTabla11 = { "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[11], camposTabla11);

			string[] camposTabla13 = { "Impuesto_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[13], camposTabla13);

			string[] camposTabla14 = { "MontoSI" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[14], camposTabla14);

			string[] camposTabla15 = { "Fecha", "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[15], camposTabla15);

			string[] camposTabla16 = { "Cliente_Id", "RazonSocial" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[16], camposTabla16);

			string[] camposTabla17 = { "Cliente_Id", "RazonSocial", "Fecha", "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[17], camposTabla17);

			tesFlujoDS dsTipado = new tesFlujoDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Fechas.TableName, dsTipado.CarteraSI.TableName, dsTipado.CarteraMovimientos.TableName, dsTipado.ClienteSI.TableName, dsTipado.ClienteVencimientos.TableName, dsTipado.ClienteAjustesSI.TableName, dsTipado.ClienteAjustes.TableName, dsTipado.ProveedoresSI.TableName, dsTipado.ProveedoresVencimientos.TableName, dsTipado.ProveedoresAjustesSI.TableName, dsTipado.ProveedoresAjustes.TableName, dsTipado.OtrosIngresos.TableName, dsTipado.OtrosEgresos.TableName, dsTipado.ChequesSI.TableName, dsTipado.ChequesVencimientos.TableName, dsTipado.ChequesAjustes.TableName, dsTipado.ChequesCartera.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}





		public static tesFlujoDS DatosInt(long /*0*/tesFlujoFondo, DateTime /*2*/FechaDesde, DateTime /*3*/FechaHasta,  int /*4*/ Empresa_id, string /*5*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/tesFlujoFondo, /*2*/FechaDesde, /*3*/ FechaHasta, /*4*/ Empresa_id };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("tesFlujoDatosINT", parametros);

			string[] camposTabla1 = { "Fecha", "Dia" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			string[] camposTabla2 = { "Fecha", "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

			string[] camposTabla3 = { "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

			string[] camposTabla4 = { "Fecha", "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

			string[] camposTabla5 = { "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

			string[] camposTabla6 = { "Fecha", "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

			string[] camposTabla7 = { "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

			string[] camposTabla8 = { "Fecha", "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

			string[] camposTabla9 = { "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[9], camposTabla9);

			string[] camposTabla10 = { "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[10], camposTabla10);

			string[] camposTabla11 = { "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[11], camposTabla11);

			string[] camposTabla13 = { "Impuesto_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[13], camposTabla13);

			string[] camposTabla14 = { "MontoSI" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[14], camposTabla14);

			string[] camposTabla15 = { "Fecha", "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[15], camposTabla15);

			string[] camposTabla16 = { "Cliente_Id", "RazonSocial" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[16], camposTabla16);

			string[] camposTabla17 = { "Cliente_Id", "RazonSocial", "Fecha", "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[17], camposTabla17);

			tesFlujoDS dsTipado = new tesFlujoDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Fechas.TableName, dsTipado.CarteraSI.TableName, dsTipado.CarteraMovimientos.TableName, dsTipado.ClienteSI.TableName, dsTipado.ClienteVencimientos.TableName, dsTipado.ClienteAjustesSI.TableName, dsTipado.ClienteAjustes.TableName, dsTipado.ProveedoresSI.TableName, dsTipado.ProveedoresVencimientos.TableName, dsTipado.ProveedoresAjustesSI.TableName, dsTipado.ProveedoresAjustes.TableName, dsTipado.OtrosIngresos.TableName, dsTipado.OtrosEgresos.TableName, dsTipado.ChequesSI.TableName, dsTipado.ChequesVencimientos.TableName, dsTipado.ChequesAjustes.TableName, dsTipado.ChequesCartera.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}


	}
}
