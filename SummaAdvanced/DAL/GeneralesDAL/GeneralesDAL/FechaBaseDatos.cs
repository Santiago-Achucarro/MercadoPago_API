using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class FechaBaseDatos
    {
		public static FechaBaseDS Datos(string /*0*/ pAuxiliar)
		{
			Object[] parametros = new Object[] { };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("FechaBaseDatos", parametros);

			string[] camposTabla0 = { "Fecha" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			FechaBaseDS dsTipado = new FechaBaseDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}


	}
}
