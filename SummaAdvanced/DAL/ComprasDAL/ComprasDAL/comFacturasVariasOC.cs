using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ComprasCommon;
using interfaceDAAB;

namespace ComprasDAL
{
    public class comFacturasVariasOC
    {
		public static comFacturasVariasOCDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/pProveed_id, string /*11*/pMoneda_Id, string /*12*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pProveed_id, /*11*/pMoneda_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("comFacturasVariasOCDatos", parametros);

			string[] camposTabla0 = { "Tipomov", "Observaciones", "TipoCtaProv", "DescripcionProveedoresTipoPasivo", "Origen_Id", "DescripcionOrCredFisc", "CondPago_Id", "DescripcionConPago", "CondFiscal_Id", "DescripcionCondFiscal", "FechaFiscal", "ClaveFiscal", "VieneDeFiscal", "TipoCompFE", "DescripcionTipoCompFE", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "FechaVencimiento", "Cierre", "RenglonDtoFin" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "comMovProv", "Segmento_str", "Cantidad", "CantidadForm", "CantidadPendiente" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			string[] camposTabla2 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

			string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

			string[] camposTabla6 = { "RenglonDtoFin", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

			comFacturasVariasOCDS dsTipado = new comFacturasVariasOCDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.Impuestos.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.Cuotas.TableName, dsTipado.MonedaOC.TableName, dsTipado.DescuentoFin.TableName, dsTipado.Adjuntos.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}


	}
}
