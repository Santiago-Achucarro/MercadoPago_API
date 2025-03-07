using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using interfaceDAAB;
using System.Data;

namespace VentasDAL
{
    public class venAnuladas
    {

		public static venMovAnuladosDS Datos(DateTime /*0*/FechaDesde, DateTime /*1*/FechaHasta, string /*2*/ClienteDesde, string /*3*/ClienteHasta, int /*4*/Empresa_Id, string /*5*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/FechaDesde, /*1*/FechaHasta, /*2*/ClienteDesde, /*3*/ClienteHasta, /*4*/Empresa_Id };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("venMovAnulados", parametros);

			string[] camposTabla0 = { "FechaDesde", "FechaHasta", "ClienteDesde", "ClienteHasta" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Comprobante", "Acuse" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			venMovAnuladosDS dsTipado = new venMovAnuladosDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Anuladas.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}






	}
}
