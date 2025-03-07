using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSKDAL
{
    public class espVenVendedoresAuxiliarKSK
    {
		public static espVenVendedoresAuxiliarKSKDS Datos(long /*0*/pVenVendedores, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pVenVendedores };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("espVenVendedoresAuxiliarKSKDatos", parametros);

			string[] camposTabla0 = { "TieneMascota" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			espVenVendedoresAuxiliarKSKDS dsTipado = new espVenVendedoresAuxiliarKSKDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

	}
}
