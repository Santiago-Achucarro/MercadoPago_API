using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using System.Data;
using interfaceDAAB;

namespace VentasDAL
{
    public class venClieSaldosIni
    {
		public static venClientesSaldoIniDS Datos(string /*0*/ClienteDesde, string /*1*/ClienteHasta, int /*2*/pEmpresa_Id, string /*3*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/ClienteDesde, /*1*/ClienteHasta, /*2*/pEmpresa_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venClientesSaldoIniDatos", parametros);

			string[] camposTabla0 = { "ClienteDesde", "ClienteHasta", "Empresa_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "SegmentoStr", "ClaveFiscal", "Sucursal", "Aplicado" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			venClientesSaldoIniDS dsTipado = new venClientesSaldoIniDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName, dsTipado.grdImpuestos.TableName, dsTipado.ClientesParaRecorrer.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}


	}
}
