using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasCommon;

namespace VentasDAL
{
    public class venCartaPorteLibre
    {
		public static venCompCartaPorteLibreDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venCompCartaPorteLibreDatos", parametros);

			string[] camposTabla0 = { "FechaHoraSalida", "Camion_Id", "Remolque1", "Remolque2", "Operador_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "TipoEstacion", "Rfc", "Nombre", "NumeroExterior", "Numerointerior", "Colonia", "Localidad", "Municipio", "CodigoPostal", "Estado", "DescripcionEstado", "NumRegIdTrib", "Referencia", "Mi_Sucursal" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			string[] camposTabla2 = { "BienesTransp", "Descripcion", "MaterialPeligroso", "CveMaterialPeligroso", "Embalaje", "DescripEmbalaje", "Dimensiones", "FraccionArancelaria", "UUIDComercioExt" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

			venCompCartaPorteLibreDS dsTipado = new venCompCartaPorteLibreDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Ubicaciones.TableName, dsTipado.Materiales.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}



	}
}
