using ComprasCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ComprasDAL
{
    public class comOrdenCompCons
    {
		public static comOrdenCompDatosConsDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("comOrdenCompDatosCons", parametros);

			string[] camposTabla0 = { "Proveed_Id", "DescripcionProveedores", "TipoPermi_Id", "DescripcionTipoPermi", "Moneda_Id", "DescripcionMonedas", "NroUsuAuto", "Autorizo", "DescripcionUsuarioAutorizo", "CondPago_Id", "DescripcionConPago", "Observaciones", "TipoCuerpo", "Total", "FechaNueva" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Producto_Id", "DescripcionProductos", "Deposito_Id", "DescripcionDepositos", "Medida_Id", "DescripcionUniMed", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Marca", "Observaciones" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			string[] camposTabla2 = { "Cuenta_Id", "DescripcionCuentas", "Medida_Id", "DescripcionUniMed", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Marca", "Observaciones" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

			string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

			string[] camposTabla4 = { "Usuario_Id", "DescripcionUsuario", "Fecha", "ResultadoFormula" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

			string[] camposTabla6 = { "CantidadPedida", "CantidadRecibida", "CantidadPendRec", "CantidadFacturada", "CantidadPendFac", "CantidadConsignada" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

			string[] camposTabla7 = { "Cantidad" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

			string[] camposTabla8 = { "Cantidad" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

			string[] camposTabla9 = { "Recepcion" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[9], camposTabla9);

			string[] camposTabla10 = { "Comprobante" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[10], camposTabla10);

			string[] camposTabla11 = { "SegmentoSTR" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[11], camposTabla11);

			comOrdenCompDatosConsDS dsTipado = new comOrdenCompDatosConsDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.CuerpoArti.TableName, dsTipado.CuerpoMemo.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.Autorizando.TableName, dsTipado.Adjuntos.TableName, dsTipado.DetalleProducto.TableName, dsTipado.RecepcionRenglon.TableName, dsTipado.ComprobanteRenglon.TableName, dsTipado.Recepciones.TableName, dsTipado.Comprobantes.TableName, dsTipado.RequisicionesInt.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}
	}
}
