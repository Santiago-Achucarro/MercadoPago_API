using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkDevolucionesProv
    {
		public static stkDevolucionesProvDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/pSegmento_Id_OC, int /*11*/pSegmento1N_OC, int /*12*/pSegmento2N_OC, int /*13*/pSegmento3N_OC, int /*14*/pSegmento4N_OC, string /*15*/pSegmento1C_OC, string /*16*/pSegmento2C_OC, string /*17*/pSegmento3C_OC, string /*18*/pSegmento4C_OC, string /*19*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pSegmento_Id_OC, /*11*/pSegmento1N_OC, /*12*/pSegmento2N_OC, /*13*/pSegmento3N_OC, /*14*/pSegmento4N_OC, /*15*/pSegmento1C_OC, /*16*/pSegmento2C_OC, /*17*/pSegmento3C_OC, /*18*/pSegmento4C_OC };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("stkDevolucionesProvDatos", parametros);

			string[] camposTabla0 = { "DistribuyeContrapartida", "Observaciones" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla2 = { "stkMoviCabe", "Cantidad", "CantidadForm", "MedidaAlterna", "DescripcionMedidaAlterna", "CantidadAlternaForm", "Centro1Debe", "DescripcionCentro1Debe", "Centro2Debe", "DescripcionCentro2Debe", "ImporteContableDebe", "CuentaHaber", "DescripcionCuentaHaber", "ImporteContableHaber" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

			string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

			string[] camposTabla4 = { "Cantidad", "Vencimiento" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

			string[] camposTabla7 = { "Cantidad" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

			stkDevolucionesProvDS dsTipado = new stkDevolucionesProvDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.OrdenCompra.TableName, dsTipado.Cuerpo.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.grdMoviDespa.TableName, dsTipado.Remito.TableName, dsTipado.Ubicaciones.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}







	}
}
