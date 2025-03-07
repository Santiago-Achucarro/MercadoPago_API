using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using StockCommon;
using System.Data;

namespace StockDAL
{
    public class stkRemiConforma
    {

		public static stkRemiConformaDS Datos(string /*0*/pSegmento_Id, string /*1*/pSegmento1C, string /*2*/pSegmento2C, string /*3*/pSegmento3C, string /*4*/pSegmento4C, int /*5*/pSegmento1N, int /*6*/pSegmento2N, int /*7*/pSegmento3N, int /*8*/pSegmento4N, int /*9*/pEmpresa_Id, string /*10*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pSegmento_Id, /*1*/pSegmento1C, /*2*/pSegmento2C, /*3*/pSegmento3C, /*4*/pSegmento4C, /*5*/pSegmento1N, /*6*/pSegmento2N, /*7*/pSegmento3N, /*8*/pSegmento4N, /*9*/pEmpresa_Id };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("stkRemiConformaDatos", parametros);

			string[] camposTabla0 = { "Observaciones" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			stkRemiConformaDS dsTipado = new stkRemiConformaDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.Adjuntos.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}




		public static void Eliminar(long /*0*/pstkMoviCabe, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pstkMoviCabe };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("stkRemiConformaEliminar", parametros);
		}

		public static void Guardar(long /*0*/pstkMoviCabe, int /*1*/pUsuario_Id, DateTime /*2*/pFechaConforma, string /*3*/pObservaciones, string /*4*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pUsuario_Id, /*2*/pFechaConforma, new Generalidades.NullableString(/*3*/pObservaciones) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("stkRemiConformaGuardar", parametros);
		}



	}
}
