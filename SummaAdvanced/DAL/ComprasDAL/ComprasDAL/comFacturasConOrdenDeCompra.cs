using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ComprasCommon;
using interfaceDAAB;

namespace ComprasDAL
{
    public class comFacturasConOrdenDeCompra
    {
		public static comFacturasConOrdenDeCompraDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/pSegmento_Id_OC, int /*11*/pSegmento1N_OC, int /*12*/pSegmento2N_OC, int /*13*/pSegmento3N_OC, int /*14*/pSegmento4N_OC, string /*15*/pSegmento1C_OC, string /*16*/pSegmento2C_OC, string /*17*/pSegmento3C_OC, string /*18*/pSegmento4C_OC, string /*19*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pSegmento_Id_OC, /*11*/pSegmento1N_OC, /*12*/pSegmento2N_OC, /*13*/pSegmento3N_OC, /*14*/pSegmento4N_OC, /*15*/pSegmento1C_OC, /*16*/pSegmento2C_OC, /*17*/pSegmento3C_OC, /*18*/pSegmento4C_OC };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("comFacturasConOrdenDeCompraDatos", parametros);

			string[] camposTabla0 = { "Tipomov", "Observaciones", "TipoCtaProv", "DescripcionProveedoresTipoPasivo", "Origen_Id", "DescripcionOrCredFisc", "CondPago_Id", "DescripcionConPago", "CondFiscal_Id", "DescripcionCondFiscal", "FechaFiscal", "ClaveFiscal", "VieneDeFiscal", "TipoCompFE", "DescripcionTipoCompFE", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "FechaVencimiento", "Cierre", "RenglonDtoFin" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla2 = { "comMovProv", "Cantidad", "CantidadForm", "CantidadPendiente" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

			string[] camposTabla3 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

			string[] camposTabla4 = { "ValorN", "ValorC", "ValorF" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

			string[] camposTabla6 = { "comMovProv" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

			string[] camposTabla8 = { "comMovProv" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

			string[] camposTabla10 = { "RenglonDtoFin", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[10], camposTabla10);

			comFacturasConOrdenDeCompraDS dsTipado = new comFacturasConOrdenDeCompraDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.OrdenCompra.TableName, dsTipado.Cuerpo.TableName, dsTipado.Impuestos.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.Cuotas.TableName, dsTipado.comFactuReceOc.TableName, dsTipado.ReceOcCambio.TableName, dsTipado.comFactuReceStk.TableName, dsTipado.ReceStkCambio.TableName, dsTipado.DescuentoFin.TableName, dsTipado.Adjuntos.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}
	}
}


