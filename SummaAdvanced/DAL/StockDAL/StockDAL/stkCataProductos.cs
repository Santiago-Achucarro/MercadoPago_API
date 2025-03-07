using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using StockCommon;

namespace StockDAL
{
    public class stkCataProductos
    {
		public static stkCataProductosDS Datos(string /*0*/ProductoDesde, string /*1*/ProductoHasta, string /*2*/FamiliaDesde, string /*3*/FamiliaHasta, string /*4*/GrupoDesde, string /*5*/GrupoHasta, int /*6*/Empresa_Id, string /*7*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/ProductoDesde, /*1*/ProductoHasta, /*2*/FamiliaDesde, /*3*/FamiliaHasta, /*4*/GrupoDesde, /*5*/GrupoHasta, /*6*/Empresa_Id };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("stkCataProductosDatos", parametros);

			string[] camposTabla0 = { "ProductoDesde", "ProductoHasta", "FamiliaDesde", "FamiliaHasta", "GrupoDesde", "GrupoHasta" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Familia_Id", "Grupo_Id", "PTodasEmpresas", "CodigoFiscal", "FraccionArancelaria" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			string[] camposTabla2 = { "CodigoBarras" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

			stkCataProductosDS dsTipado = new stkCataProductosDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Productos.TableName, dsTipado.Factores.TableName, dsTipado.Componentes.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}




	}
}
