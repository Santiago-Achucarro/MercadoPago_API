using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venPedidosConsultaDrillDown
    {
		public static venPedidosConsultaDrillDownDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venPedidosConsultaDrillDown", parametros);

			string[] camposTabla0 = { "Segmento", "Cliente_Id", "Sucursal", "NombreFantasia", "Moneda_Id", "DescripcionMonedas", "MonedaFacturacion", "DescripcionMonFacturacion", "CondPagoCli_Id", "DescripcionCondPago", "ListaPrecio_Id", "DescripcionListasPrecios", "Vendedor_Id", "DescripcionVendedores", "FormaEntrega_Id", "DescripcionFormaEntrega", "UsuarioAutoriz_Id", "DescripcionUsuarioAutoriz", "FechaAutorizo", "Observaciones", "ObservEstado", "Motivo_Id", "ObsAnticipo", "Incoterm_Id", "DescripcionIncoterm", "MetodoPago", "UsoCfdi", "DescripcionUsoCfdi", "DescripcionMetodoPago", "SucursalUsu" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Producto_Id", "DescripcionProductos", "Medida_Id", "DescripcionUniMed", "Deposito_Id", "DescripcionDepositos", "CFVenta_Id", "Observaciones", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "SubTotalNeto", "Anular" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

			string[] camposTabla5 = { "Fecha" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

			string[] camposTabla6 = { "EsquemaAuto_Id", "DescripcionEsquema" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

			string[] camposTabla7 = { "Relacionado" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

			venPedidosConsultaDrillDownDS dsTipado = new venPedidosConsultaDrillDownDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.ConsStock.TableName, dsTipado.ConsDetalle.TableName, dsTipado.venNPAutorizando.TableName, dsTipado.Esquema.TableName, dsTipado.Relacionados.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}
	}
}
