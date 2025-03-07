using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using StockCommon;

namespace StockDAL
{
    public class stkEntradasRemi
    {

		public static stkEntradasCancRemiDS Datos(long /*0*/pstkMoviCabeEntrada, int /*1*/pRenglonEntrada, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pstkMoviCabeEntrada, new Generalidades.NullableInt(/*1*/pRenglonEntrada) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("stkEntradasCancRemiDatos", parametros);

			stkEntradasCancRemiDS dsTipado = new stkEntradasCancRemiDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}
		public static void Eliminar(long /*0*/pstkMoviCabeEntrada, int /*1*/pRenglonEntrada, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pstkMoviCabeEntrada, new Generalidades.NullableInt(/*1*/pRenglonEntrada) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("stkEntradasCancRemiEliminar", parametros);
		}

		public static void Guardar(long /*0*/pstkMoviCabeEntrada, int /*1*/pRenglonEntrada, long /*2*/pstkMoviCabeRemi, int /*3*/pRenglonRemi, decimal /*4*/pCantidad, string /*5*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pstkMoviCabeEntrada, /*1*/pRenglonEntrada, /*2*/pstkMoviCabeRemi, /*3*/pRenglonRemi, /*4*/pCantidad };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("stkEntradasCancRemiGuardar", parametros);
		}





		public static stkEntradasCancRemiPendDS DatosPend(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/pSegmento_IdRemi, int /*11*/pSegmento1NRemi, int /*12*/pSegmento2NRemi, int /*13*/pSegmento3NRemi, int /*14*/pSegmento4NRemi, string /*15*/pSegmento1CRemi, string /*16*/pSegmento2CRemi, string /*17*/pSegmento3CRemi, string /*18*/pSegmento4CRemi, string /*19*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pSegmento_IdRemi, /*11*/pSegmento1NRemi, /*12*/pSegmento2NRemi, /*13*/pSegmento3NRemi, /*14*/pSegmento4NRemi, /*15*/pSegmento1CRemi, /*16*/pSegmento2CRemi, /*17*/pSegmento3CRemi, /*18*/pSegmento4CRemi };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("stkEntradasCancRemiPend", parametros);

			string[] camposTabla0 = { "DistribuyeContrapartida", "Observaciones" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Total" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			string[] camposTabla2 = { "stkMoviCabe", "Cantidad", "CantidadForm", "MedidaAlterna", "DescripcionMedidaAlterna", "Observaciones", "ImporteContableDebe", "ImporteContableHaber" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

			string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

			string[] camposTabla4 = { "Cantidad", "Vencimiento" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

			string[] camposTabla6 = { "Cantidad" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

			stkEntradasCancRemiPendDS dsTipado = new stkEntradasCancRemiPendDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Remision.TableName, dsTipado.Cuerpo.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.grdMoviDespa.TableName, dsTipado.Ubicaciones.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}




	}
}
