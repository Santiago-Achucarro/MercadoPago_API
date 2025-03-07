using interfaceDAAB;
using StockCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StockDAL
{
    public class stkExistenciasXDepositoXLote
    {
		public static stkExistenciasXDepositoXLoteDS Datos(int /*0*/pEmpresa_Id, string /*1*/pProductoDesde, string /*2*/pProductoHasta, string /*3*/pDepositoDesde, string /*4*/pDepositoHasta, string /*5*/pLoteDesde, string /*6*/pLoteHasta, string /*7*/pFamiliaDesde, string /*8*/pFamiliaHasta, string /*9*/pGrupoDesde, string /*10*/pGrupoHasta, DateTime /*11*/pFecha, string /*12*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pProductoDesde, /*2*/pProductoHasta, /*3*/pDepositoDesde, /*4*/pDepositoHasta, /*5*/pLoteDesde, /*6*/pLoteHasta, /*7*/pFamiliaDesde, /*8*/pFamiliaHasta, /*9*/pGrupoDesde, /*10*/pGrupoHasta, /*11*/pFecha };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("stkExistenciasXDepositoXLote", parametros);

			string[] camposTabla0 = { "ProductoDesde", "ProductoHasta", "DepositoDesde", "DepositoHasta", "LoteDesde", "LoteHasta", "FamiliaDesde", "FamiliaHasta", "GrupoDesde", "GrupoHasta" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla2 = { "Vencimiento", "Cantidad" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

			string[] camposTabla3 = { "Total" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

			stkExistenciasXDepositoXLoteDS dsTipado = new stkExistenciasXDepositoXLoteDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Depositos.TableName, dsTipado.Cuerpo.TableName, dsTipado.Resultado.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}


	}
}
