using ComprasCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprasDAL
{
    public class comMovProvDevenga
    {
		public static comMovProvDevengaDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("comMovProvDevengaDatos", parametros);

			string[] camposTabla0 = { "Tipomov", "Observaciones", "TipoCtaProv", "DescripcionProveedoresTipoPasivo", "Origen_Id", "DescripcionOrCredFisc", "CondPago_Id", "DescripcionConPago", "CondFiscal_Id", "DescripcionCondFiscal", "FechaFiscal", "ClaveFiscal", "VieneDeFiscal", "TipoCompFE", "DescripcionTipoCompFE", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "FechaVencimiento", "Cierre", "RenglonDtoFin" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Cuenta_Id", "DescripcionCuenta", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Base_Id", "DescripcionBaseDistri" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			string[] camposTabla2 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

			string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

			string[] camposTabla7 = { "Importe" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

			string[] camposTabla8 = { "Cuenta_Id", "DescripcionCuentas" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

			string[] camposTabla10 = { "Asiento", "Importe" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[10], camposTabla10);

			comMovProvDevengaDS dsTipado = new comMovProvDevengaDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName, dsTipado.grdImpuestos.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.grdCuotas.TableName, dsTipado.tesRendicion.TableName, dsTipado.Adjuntos.TableName, dsTipado.ImpuestosVaAlCosto.TableName, dsTipado.Devenga.TableName, dsTipado.DevengaCtas.TableName, dsTipado.DevengaCont.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Eliminar(long /*0*/pcomMovProv, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pcomMovProv };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("comMovProvDevengaEliminar", parametros);
		}

		public static void Guardar(long /*0*/pcomMovProv, DateTime /*1*/pVigenciaDesde, DateTime /*2*/pVigenciaHasta, decimal /*3*/pImporteADevengar, string /*4*/pCtaADevengar, string /*5*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pVigenciaDesde, /*2*/pVigenciaHasta, /*3*/pImporteADevengar, new Generalidades.NullableString(/*4*/pCtaADevengar) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("comMovProvDevengaGuardar", parametros);
		}
	}
}
