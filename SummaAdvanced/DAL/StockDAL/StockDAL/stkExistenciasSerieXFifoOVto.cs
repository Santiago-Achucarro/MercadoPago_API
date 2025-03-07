using interfaceDAAB;
using StockCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StockDAL
{
    public class stkExistenciasSerieXFifoOVto
    {
		public static stkExistenciaSerieXFifoOVtoDS Datos(int /*0*/pEmpresa_Id, string /*1*/pProducto_Id, string /*2*/pDeposito_Id, decimal /*3*/pCantidad, string /*4*/pSegmento_Id, int /*5*/pSegmento1N, int /*6*/pSegmento2N, int /*7*/pSegmento3N, int /*8*/pSegmento4N, string /*9*/pSegmento1C, string /*10*/pSegmento2C, string /*11*/pSegmento3C, string /*12*/pSegmento4C, string /*13*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pProducto_Id, /*2*/pDeposito_Id, /*3*/pCantidad, new Generalidades.NullableString(/*4*/pSegmento_Id), new Generalidades.NullableInt(/*5*/pSegmento1N), new Generalidades.NullableInt(/*6*/pSegmento2N), new Generalidades.NullableInt(/*7*/pSegmento3N), new Generalidades.NullableInt(/*8*/pSegmento4N), new Generalidades.NullableString(/*9*/pSegmento1C), new Generalidades.NullableString(/*10*/pSegmento2C), new Generalidades.NullableString(/*11*/pSegmento3C), new Generalidades.NullableString(/*12*/pSegmento4C) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("stkExistenciaSerieXFifoOVto", parametros);

			string[] camposTabla0 = { "Producto_Id", "Deposito_Id", "Cantidad", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			stkExistenciaSerieXFifoOVtoDS dsTipado = new stkExistenciaSerieXFifoOVtoDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Series.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}


	}
}
