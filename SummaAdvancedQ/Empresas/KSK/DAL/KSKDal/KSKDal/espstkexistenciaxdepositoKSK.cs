using KSKCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSKDAL
{
    public class espstkexistenciaxdepositoKSK
    {
		public static espstkexistenciaxdepositoKSKDS Datos(string /*0*/ProductoDesde, string /*1*/Sucursal, int /*2*/Empresa, string /*3*/ListaPrecios,  string /*4*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/ProductoDesde, /*1*/Sucursal, /*2*/Empresa, /*3*/ListaPrecios };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("espstkexistenciaxdepositoKSK", parametros);

			string[] camposTabla0 = { "Producto", "Sucursal", "Empresa", "Lista" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			espstkexistenciaxdepositoKSKDS dsTipado = new espstkexistenciaxdepositoKSKDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdcuerpo.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}


	}
}



