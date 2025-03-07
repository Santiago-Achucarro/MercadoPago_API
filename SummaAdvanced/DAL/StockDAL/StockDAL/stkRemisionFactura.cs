using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkRemisionFactura
    {
		public static stkRemisionFacturaDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("stkRemisionFacturaDatos", parametros);

			string[] camposTabla0 = { "Fecha", "Cliente_Id", "Sucursal", "NombreFantasia", "ListaPrecio_Id", "DescripcionListasPrecios", "Vendedor_Id", "DescripcionVendedores", "Observaciones" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Producto_Id", "DescripcionProductos", "Medida_Id", "DescripcionUniMed", "Deposito_Id", "DescripcionDepositos", "CantidadAEntregar", "CantidadPendienteOrig", "CantidadAFacturarAlterna", "CantidadAEntregarAlterna", "CFVenta_Id", "Observaciones", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

			string[] camposTabla4 = { "Cantidad" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

			stkRemisionFacturaDS dsTipado = new stkRemisionFacturaDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.Ubicaciones.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}



	}
}
