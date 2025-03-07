using ImpuestosCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImpuestosDAL
{
    public class impArbaTxtModif
    {
		public static impArbaTxtModifDS Datos(short /*0*/Mes, short /*1*/Anio, string /*2*/CUIT, string /*3*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/Mes, /*1*/Anio, /*2*/CUIT };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("impArbaTxtModifDatos", parametros);

			string[] camposTabla0 = { "AlicuotaRet" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			impArbaTxtModifDS dsTipado = new impArbaTxtModifDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Guardar(short /*0*/Mes, short /*1*/Anio, string /*2*/CUIT, decimal /*3*/AliPer, decimal /*4*/AliRet, string /*5*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/Mes, /*1*/Anio, /*2*/CUIT, /*3*/AliPer, /*4*/AliRet };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("impArbaTxtModifGuardar", parametros);
		}
	}
}
