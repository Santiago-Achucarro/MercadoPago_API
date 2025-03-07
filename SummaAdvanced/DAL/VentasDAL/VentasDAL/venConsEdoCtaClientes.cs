using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venConsEdoCtaClientes
    {
		public static venConsEdoCtaClientesDS Datos(string /*0*/Cliente_Id, int /*1*/PendHist, DateTime /*2*/FechaDesde, DateTime /*3*/FechaHasta, string /*4*/Moneda_Id, int /*5*/Empresa, bool /*6*/pConsolidados, string /*7*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/Cliente_Id, /*1*/PendHist, /*2*/FechaDesde, /*3*/FechaHasta, new Generalidades.NullableString(/*4*/Moneda_Id), /*5*/Empresa, /*6*/pConsolidados };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("venConsEdoCtaClientes", parametros);

			string[] camposTabla0 = { "Cliente_Id", "PendHist", "FechaDesde", "FechaHasta", "Moneda_Id", "Empresa", "FechaAplicacion", "Consolidados", "DireccionEntrega", "DireccionFacturacion", "Telefonos", "EMail", "Fax", "CobradorAsignado", "VendedorAsignado", "Zona_Id", "TipoClie_Id", "ListaPrecio_Id", "DescripcionListaPrecios", "FechaAlta", "Contactos", "CondPagoCli_Id", "DescrioncionCondPago", "Bonificacion1", "Bonificacion2", "Bonificacion3", "Observaciones" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Sucursal", "Segmento", "Fecha", "Debe", "Haber", "Saldo", "SaldoAcum", "FechaVencimiento", "FechaRegistro", "FechaConforma", "Observaciones" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			string[] camposTabla4 = { "Fecha", "Seleccionar", "ven_Movimientos", "NroCuota" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

			string[] camposTabla6 = { "Fecha" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

			string[] camposTabla7 = { "FechaDoc" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

			string[] camposTabla8 = { "venMovimientos", "Fecha", "NroCuota" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

			string[] camposTabla9 = { "Asiento_Id", "Cuota_Nro" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[9], camposTabla9);

			string[] camposTabla10 = { "Segmento", "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[10], camposTabla10);

			venConsEdoCtaClientesDS dsTipado = new venConsEdoCtaClientesDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.Inventario.TableName, dsTipado.AsientoContable.TableName, dsTipado.Aplicaciones.TableName, dsTipado.Impuestos.TableName, dsTipado.OrdenCompra.TableName, dsTipado.Valores.TableName, dsTipado.Comprobantes.TableName, dsTipado.CompAAplic.TableName, dsTipado.Remitos.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}




	}
}
