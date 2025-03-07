using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkEntradasCD
    {
		public static stkEntradasCDDS Datos(int /*0*/pEmpresa_id, string /*1*/pSegmento_id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_id, /*1*/pSegmento_id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("stkEntradasCDDatos", parametros);

			string[] camposTabla0 = { "DistribuyeContrapartida", "Observaciones" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Deposito_Id", "DescripcionDepositos", "Producto_Id", "DescripcionProductos", "Medida_Id", "DescripcionUniMed", "MedidaAlterna", "DescripcionMedidaAlterna", "Observaciones", "Centro1Debe", "DescripcionCentro1Debe", "Centro2Debe", "DescripcionCentro2Debe", "Centro1Haber", "DescripcionCentro1Haber", "Centro2Haber", "DescripcionCentro2Haber", "Despacho_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

			string[] camposTabla3 = { "Cantidad", "Vencimiento", "Existencia", "Marcado" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

			string[] camposTabla5 = { "Cantidad", "CantidadAlterna", "Existencia" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

			string[] camposTabla6 = { "stkMoviCabeEntr", "var", "stkMoviCabeEntr1" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

			stkEntradasCDDS dsTipado = new stkEntradasCDDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.grdMoviDespa.TableName, dsTipado.Ubicaciones.TableName, dsTipado.EnTransito.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}
	}
}
