using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ImpuestosCommon;

namespace ImpuestosDAL
{
    public class impFacturasCompras
    {
		public static impFacturasComprasDS Datos(DateTime /*0*/FechaDesde, DateTime /*1*/FechaHasta, string /*2*/ProveedDesde, string /*3*/ProveedHasta, int /*4*/Empresa_Id, string /*5*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/FechaDesde, /*1*/FechaHasta, /*2*/ProveedDesde, /*3*/ProveedHasta, /*4*/Empresa_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("impFacturasCompras", parametros);

			string[] camposTabla0 = { "Comprobante" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			impFacturasComprasDS dsTipado = new impFacturasComprasDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}


	}
}
