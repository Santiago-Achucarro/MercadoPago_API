using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venCompCartaPorteMercancia
    {
		public static venCompCartaPorteMercanciaDS Datos(long /*0*/pvenmovimientos, int /*1*/pRenglon, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenmovimientos, new Generalidades.NullableInt(/*1*/pRenglon) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venCompCartaPorteMercanciaDatos", parametros);

			string[] camposTabla0 = { "BienesTransp", "ClaveSTCC", "Descripcion", "Medida_Id", "Dimensiones", "MaterialPeligroso", "CveMaterialPeligroso", "Embalaje", "DescripEmbalaje", "FraccionArancelaria", "UUIDComercioExt" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			venCompCartaPorteMercanciaDS dsTipado = new venCompCartaPorteMercanciaDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Eliminar(long /*0*/pvenmovimientos, int /*1*/pRenglon, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenmovimientos, new Generalidades.NullableInt(/*1*/pRenglon) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("venCompCartaPorteMercanciaEliminar", parametros);
		}

		public static void Guardar(long /*0*/pvenmovimientos, int /*1*/pidDestino, int /*2*/pRenglon, string /*3*/pBienesTransp, string /*4*/pClaveSTCC, string /*5*/pDescripcion, decimal /*6*/pCantidad, string /*7*/pMedida_id, string /*8*/pDimensiones, string /*9*/pMaterialPeligroso, string /*10*/pCveMaterialPeligroso, string /*11*/pEmbalaje, string /*12*/pDescripEmbalaje, decimal /*13*/pPesoEnKg, decimal /*14*/pValorMercancia, string /*15*/pFraccionArancelaria, string /*16*/pUUIDComercioExt, string /*17*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenmovimientos, /*1*/pidDestino, /*2*/pRenglon, new Generalidades.NullableString(/*3*/pBienesTransp), new Generalidades.NullableString(/*4*/pClaveSTCC), new Generalidades.NullableString(/*5*/pDescripcion), /*6*/pCantidad, new Generalidades.NullableString(/*7*/pMedida_id), new Generalidades.NullableString(/*8*/pDimensiones), new Generalidades.NullableString(/*9*/pMaterialPeligroso), new Generalidades.NullableString(/*10*/pCveMaterialPeligroso), new Generalidades.NullableString(/*11*/pEmbalaje), new Generalidades.NullableString(/*12*/pDescripEmbalaje), /*13*/pPesoEnKg, /*14*/pValorMercancia, new Generalidades.NullableString(/*15*/pFraccionArancelaria), new Generalidades.NullableString(/*16*/pUUIDComercioExt) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("venCompCartaPorteMercanciaGuardar", parametros);
		}





	}
}
