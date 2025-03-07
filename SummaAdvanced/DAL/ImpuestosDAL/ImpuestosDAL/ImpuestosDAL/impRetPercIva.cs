using ImpuestosCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpuestosDAL
{
    public class impRetPercIva
    {
		public static impRetPercIvaDS Datos(int /*0*/pEmpresa_Id, DateTime /*1*/pFechaDesde, DateTime /*2*/pFechaHasta, string /*3*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pFechaDesde, /*2*/pFechaHasta };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("impRetPercIva", parametros);

			string[] camposTabla0 = { "FechaDesde", "FechaHasta", "Retenciones", "Percepciones" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Importe", "TipoImpuesto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			impRetPercIvaDS dsTipado = new impRetPercIvaDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Retenciones.TableName, dsTipado.Percepciones.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}
	}
}
