using StockCommon;
using System;

namespace StockDAL
{
    public class stkExistenciaXSerieXUbi
    {
		public static stkExistenciaXSerieXUbiDS Datos(int /*0*/pEmpresa_Id, string /*1*/pProducto_Id, string /*2*/pMedida_Id, string /*3*/pDeposito_Id, string /*4*/pTipoSerieUni, string /*5*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pProducto_Id, /*2*/pMedida_Id, /*3*/pDeposito_Id, /*4*/pTipoSerieUni };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("stkExistenciaXSerieXUbi", parametros);

			string[] camposTabla0 = { "Producto_Id", "Medida_Id", "Deposito_Id", "TipoSerieUni" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "stkMoviCabe", "Cantidad", "CantidadAlterna", "Vencimiento", "Existencia" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			string[] camposTabla2 = { "stkMoviCabe", "Cantidad", "CantidadAlterna", "Existencia" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

			stkExistenciaXSerieXUbiDS dsTipado = new stkExistenciaXSerieXUbiDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.ExistenciasSerie.TableName, dsTipado.ExistenciaUbi.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}
	}
}
