using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;
namespace SueldosDAL
{
    public class sueConstantes
    {
		public static sueConstantesDS Datos( string /*0*/ pAuxiliar)
		{
			Object[] parametros = new Object[] { };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("sueConstantesDatos", parametros);

			string[] camposTabla0 = { "Ver", "Codigo" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Codigo", "Ver" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			string[] camposTabla2 = { "Codigo", "Ver" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

			sueConstantesDS dsTipado = new sueConstantesDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Gan.TableName, dsTipado.Variable.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}


	}
}
