using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralesCommon;
namespace GeneralesDAL
{
    public class genCodPostal
    {
		public static genCodPostalDS Datos(string /*0*/pCodigoPostal, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pCodigoPostal };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("genCodPostalDatos", parametros);

			string[] camposTabla0 = { "CodigoUso", "Provincia_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			genCodPostalDS dsTipado = new genCodPostalDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}


		public static void Eliminar(string /*0*/pCodigoPostal, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pCodigoPostal) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("genCodPostalEliminar", parametros);
		}

		public static void Guardar(string /*0*/pCodigoPostal, string /*1*/pEstado, string /*2*/pMunicipio, string /*3*/pLocalidad, bool /*4*/pFranjaFonteriza, string /*5*/pCodigoUso, string /*6*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pCodigoPostal, /*1*/pEstado, /*2*/pMunicipio, /*3*/pLocalidad, /*4*/pFranjaFonteriza, new Generalidades.NullableString(/*5*/pCodigoUso) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("genCodPostalGuardar", parametros);
		}




	}
}
