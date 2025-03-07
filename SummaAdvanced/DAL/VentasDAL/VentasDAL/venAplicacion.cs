using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using interfaceDAAB;
using System.Data;

namespace VentasDAL
{
    public class venAplicacion
    {
		public static venAplicacionCobranzaDS Datos(string /*0*/Segmento_Id, int /*1*/Segmento1N, int /*2*/Segmento2N, int /*3*/Segmento3N, int /*4*/Segmento4N, string /*5*/Segmento1C, string /*6*/Segmento2C, string /*7*/Segmento3C, string /*8*/Segmento4C, int /*9*/Empresa_Id, string /*10*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/Segmento_Id, /*1*/Segmento1N, /*2*/Segmento2N, /*3*/Segmento3N, /*4*/Segmento4N, /*5*/Segmento1C, /*6*/Segmento2C, /*7*/Segmento3C, /*8*/Segmento4C, /*9*/Empresa_Id };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("venAplicacionCobranzaDatos", parametros);

			string[] camposTabla1 = { "Aplicar" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			venAplicacionCobranzaDS dsTipado = new venAplicacionCobranzaDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

	}
}
