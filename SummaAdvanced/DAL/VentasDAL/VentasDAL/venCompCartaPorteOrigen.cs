using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venCompCartaPorteOrigen
    {
		public static venCompCartaPorteOrigenDS Datos(long /*0*/pvenmovimientos, int /*1*/pUbicacion, int /*2*/pidOrigen, string /*3*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenmovimientos, new Generalidades.NullableInt(/*1*/pUbicacion), new Generalidades.NullableInt(/*2*/pidOrigen) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venCompCartaPorteOrigenDatos", parametros);

			string[] camposTabla0 = { "RFCRemitente", "NombreRemitente", "NumRegIdTrib", "ResidenciaFiscal", "NumEstacion", "NombreEstacion", "NavegacionTrafico", "NumeroExterior", "Numerointerior", "Colonia", "Localidad", "Referencia", "Municipio", "Estado", "Pais_Id", "CodigoPostal" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			venCompCartaPorteOrigenDS dsTipado = new venCompCartaPorteOrigenDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}


		public static void Eliminar(long /*0*/pvenmovimientos, int /*1*/pUbicacion, int /*2*/pidOrigen, string /*3*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenmovimientos, new Generalidades.NullableInt(/*1*/pUbicacion), new Generalidades.NullableInt(/*2*/pidOrigen) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("venCompCartaPorteOrigenEliminar", parametros);
		}

		public static void Guardar(long /*0*/pvenmovimientos, int /*1*/pUbicacion, int /*2*/pidOrigen, string /*3*/pRFCRemitente, string /*4*/pNombreRemitente, string /*5*/pNumRegIdTrib, short /*6*/pResidenciaFiscal, string /*7*/pNumEstacion, string /*8*/pNombreEstacion, string /*9*/pNavegacionTrafico, DateTime /*10*/pFechaHoraSalida, string /*11*/pCalle, string /*12*/pNumeroExterior, string /*13*/pNumerointerior, string /*14*/pColonia, string /*15*/pLocalidad, string /*16*/pReferencia, string /*17*/pMunicipio, string /*18*/pEstado, short /*19*/pPais, string /*20*/pCodigoPostal, string /*21*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenmovimientos, /*1*/pUbicacion, /*2*/pidOrigen, new Generalidades.NullableString(/*3*/pRFCRemitente), new Generalidades.NullableString(/*4*/pNombreRemitente), new Generalidades.NullableString(/*5*/pNumRegIdTrib), new Generalidades.NullableShort(/*6*/pResidenciaFiscal), new Generalidades.NullableString(/*7*/pNumEstacion), new Generalidades.NullableString(/*8*/pNombreEstacion), new Generalidades.NullableString(/*9*/pNavegacionTrafico), /*10*/pFechaHoraSalida, /*11*/pCalle, new Generalidades.NullableString(/*12*/pNumeroExterior), new Generalidades.NullableString(/*13*/pNumerointerior), new Generalidades.NullableString(/*14*/pColonia), new Generalidades.NullableString(/*15*/pLocalidad), new Generalidades.NullableString(/*16*/pReferencia), new Generalidades.NullableString(/*17*/pMunicipio), new Generalidades.NullableString(/*18*/pEstado), new Generalidades.NullableShort(/*19*/pPais), new Generalidades.NullableString(/*20*/pCodigoPostal) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("venCompCartaPorteOrigenGuardar", parametros);
		}


	}
}
