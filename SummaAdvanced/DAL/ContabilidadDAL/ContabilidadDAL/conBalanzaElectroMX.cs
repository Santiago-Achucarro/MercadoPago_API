using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContabilidadCommon;
using interfaceDAAB;
using System.Data;

namespace ContabilidadDAL
{
    public class conBalanzaElectroMX
    {
		public static conBalanzaElectroMXDS Datos(int /*0*/pAnio, int /*1*/pMes, int /*2*/pNivel, int /*3*/pEmpresa, string /*4*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pAnio, /*1*/pMes, /*2*/pNivel, /*3*/pEmpresa };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("conBalanzaElectroMX", parametros);

			string[] camposTabla0 = { "Anio", "Mes", "Nivel" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Saldoinicial", "Debe", "Haber" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			conBalanzaElectroMXDS dsTipado = new conBalanzaElectroMXDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}





	}
}
