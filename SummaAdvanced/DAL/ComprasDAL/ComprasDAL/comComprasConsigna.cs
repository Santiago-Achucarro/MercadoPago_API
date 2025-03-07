using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ComprasCommon;

namespace ComprasDAL
{
    public class comComprasConsigna
    {

		public static comComprasConsPendDS Datos(string /*0*/Producto_Id, string /*1*/Deposito_Id, int /*2*/Empresa_Id, string /*3*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/Producto_Id, /*1*/Deposito_Id, /*2*/Empresa_Id };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("comComprasConsPendDatos", parametros);

			string[] camposTabla0 = { "Producto_Id", "Deposito_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Cantidad", "Cuenta_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			comComprasConsPendDS dsTipado = new comComprasConsPendDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

	}
}
