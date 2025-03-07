using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkNotasCreditoXDevolucion
    {
		public static stkNotasCreditoXDevolucionDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/pSegmento_IdNC, int /*11*/pSegmento1NNC, int /*12*/pSegmento2NNC, int /*13*/pSegmento3NNC, int /*14*/pSegmento4NNC, string /*15*/pSegmento1CNC, string /*16*/pSegmento2CNC, string /*17*/pSegmento3CNC, string /*18*/pSegmento4CNC, string /*19*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pSegmento_IdNC, /*11*/pSegmento1NNC, /*12*/pSegmento2NNC, /*13*/pSegmento3NNC, /*14*/pSegmento4NNC, /*15*/pSegmento1CNC, /*16*/pSegmento2CNC, /*17*/pSegmento3CNC, /*18*/pSegmento4CNC };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("stkNotasCreditoXDevolucionDatos", parametros);

			string[] camposTabla0 = { "Segmento_IdNC", "Segmento1NNC", "Segmento2NNC", "Segmento3NNC", "Segmento4NNC", "Segmento1CNC", "Segmento2CNC", "Segmento3CNC", "Segmento4CNC", "Centro1_Id", "Centro2_Id", "Sucursal", "ComprobanteDesde", "Observaciones" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla2 = { "Observaciones" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

			stkNotasCreditoXDevolucionDS dsTipado = new stkNotasCreditoXDevolucionDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Despacho.TableName, dsTipado.Cuerpo.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}













		public static void Guardar(long /*0*/pstkMoviCabe, long /*1*/pvenMovimientosNC, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pvenMovimientosNC };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("stkNotasCreditoXDevolucionGuardar", parametros);
		}



	}
}
