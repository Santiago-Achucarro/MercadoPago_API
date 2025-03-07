using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockCommon;
using System.Data;
using interfaceDAAB;

namespace StockDAL
{
    public class stkProductoXDeposito
    {
		public static stkExistenciasXDepositoDS Datos(int /*0*/pEmpresa_Id, string /*1*/pProductoDesde, string /*2*/pProductoHasta, string /*3*/pDepositoDesde, string /*4*/pDepositoHasta, string /*5*/pFamiliaDesde, string /*6*/pFamiliaHasta, string /*7*/pGrupoDesde, string /*8*/pGrupoHasta, string /*9*/pTipoDesde, string /*10*/pTipoHasta, string /*11*/ pAuxiliar)
		{
			Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pEmpresa_Id), /*1*/pProductoDesde, /*2*/pProductoHasta, /*3*/pDepositoDesde, /*4*/pDepositoHasta, /*5*/pFamiliaDesde, /*6*/pFamiliaHasta, /*7*/pGrupoDesde, /*8*/pGrupoHasta, /*9*/pTipoDesde, /*10*/pTipoHasta };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("stkExistenciasXDeposito", parametros);

			string[] camposTabla2 = { "Cantidad" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

			stkExistenciasXDepositoDS dsTipado = new stkExistenciasXDepositoDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Depositos.TableName, dsTipado.Cuerpo.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}





	}
}