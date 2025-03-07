using GeneralesCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GeneralesDAL
{
    public class genAtributosProvincia
    {
		public static genAtributosProvinciaDS Datos(string /*0*/pProvinciaC, int /*1*/pProvinciaN, int /*2*/pAtributoNro, string /*3*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pProvinciaC, new Generalidades.NullableInt(/*1*/pProvinciaN), new Generalidades.NullableInt(/*2*/pAtributoNro) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("genAtributosProvinciaDatos", parametros);

			genAtributosProvinciaDS dsTipado = new genAtributosProvinciaDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}
	}
}
