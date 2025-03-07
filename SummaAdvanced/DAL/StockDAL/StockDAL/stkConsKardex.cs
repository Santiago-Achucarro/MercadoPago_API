using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using StockCommon;
using interfaceDAAB;
namespace StockDAL
{
    public class stkConsKardex
    {
		public static stkConsKardexDS Datos(string /*0*/Producto_Id, string /*1*/DepositoDesde, string /*2*/DepositoHasta, DateTime /*3*/FechaDesde, DateTime /*4*/FechaHasta, bool /*5*/IncluCanc, int /*6*/Empresa_Id, string /*7*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/Producto_Id, /*1*/DepositoDesde, /*2*/DepositoHasta, /*3*/FechaDesde, /*4*/FechaHasta, /*5*/IncluCanc, /*6*/Empresa_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("stkConsKardex", parametros);

			string[] camposTabla0 = { "DepositoDesde", "DepositoHasta", "FechaDesde", "FechaHasta", "IncluCanc" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "stkInventarios", "Comprobante", "Comprobante2", "Total", "PrecioVenta", "SaldoCant", "AcumEntradas", "AcumSalidas", "Saldo" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			stkConsKardexDS dsTipado = new stkConsKardexDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}



	}
}
