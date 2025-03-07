using ImpuestosCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpuestosDAL
{
    public class impeSicol
    {
		public static impeSicolDS Datos(int /*0*/pEmpresa_Id, DateTime /*1*/pFechaDesde, DateTime /*2*/pFechaHasta, string /*3*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pFechaDesde, /*2*/pFechaHasta };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("impeSicol", parametros);

			string[] camposTabla0 = { "FechaDesde", "FechaHasta" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "BaseImponible" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			impeSicolDS dsTipado = new impeSicolDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Percepciones.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}
	}
}
