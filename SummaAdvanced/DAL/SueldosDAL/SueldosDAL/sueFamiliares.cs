using SueldosCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SueldosDAL
{
    public class sueFamiliares
    {

		public static void Eliminar(int /*0*/pLegajo, string /*1*/pTipoDoc, string /*2*/pNroDoc, string /*3*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pLegajo, new Generalidades.NullableString(/*1*/pTipoDoc), new Generalidades.NullableString(/*2*/pNroDoc) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("sueFamiliaresEliminar", parametros);
		}

		public static void Guardar(int /*0*/pLegajo, string /*1*/pTipoDoc, string /*2*/pNroDoc, string /*3*/pRelacion, string /*4*/pApellidoyNombre, string /*5*/pSexo, DateTime /*6*/pFechaNacimiento, DateTime /*7*/pACargoDesde, DateTime /*8*/pFechaBaja, DateTime /*9*/pFechaCarga, bool /*10*/pGanancias, bool /*11*/pIncapacitado, bool /*12*/pAdhObSocial, int /*13*/pUsuario_Id, string /*14*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pTipoDoc, /*2*/pNroDoc, /*3*/pRelacion, /*4*/pApellidoyNombre, /*5*/pSexo, /*6*/pFechaNacimiento, /*7*/pACargoDesde, new Generalidades.NullableDate(/*8*/pFechaBaja), /*9*/pFechaCarga, /*10*/pGanancias, /*11*/pIncapacitado, /*12*/pAdhObSocial, new Generalidades.NullableInt(/*13*/pUsuario_Id) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("sueFamiliaresGuardar", parametros);
		}

		public static sueLegajoFamiliaresDS LegajoDatos(int /*0*/pLegajo, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pLegajo};

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("sueLegajoFamiliaresDatos", parametros);

			string[] camposTabla1 = { "FechaBaja", "Usuario_Id", "DescripcionUsuario" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			sueLegajoFamiliaresDS dsTipado = new sueLegajoFamiliaresDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Familiares.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}


	}
}
