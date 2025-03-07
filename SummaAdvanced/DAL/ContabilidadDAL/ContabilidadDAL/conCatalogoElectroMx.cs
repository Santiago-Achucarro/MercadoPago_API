using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conCatalogoElectroMx
    {
		public static conCatalogoElectroMXDS Datos(int /*0*/pEmpresa_Id, int /*1*/pNivel, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pNivel };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("conCatalogoElectroMX", parametros);

			string[] camposTabla0 = { "Anio", "Mes", "Genera_Catalogo", "Genera_Balanza", "Genera_Poliza" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "TipoSat_Id", "SubcuentaDe" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			conCatalogoElectroMXDS dsTipado = new conCatalogoElectroMXDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}




	}
}
