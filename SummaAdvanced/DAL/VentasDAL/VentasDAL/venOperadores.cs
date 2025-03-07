using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venOperadores
    {
		public static venOperadoresDS Datos(string /*0*/pOperador_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pOperador_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venOperadoresDatos", parametros);

			string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "NumeroExterior", "Numerointerior", "Colonia", "Localidad", "Referencia", "Municipio", "Estado", "CodigoPostal" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			venOperadoresDS dsTipado = new venOperadoresDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Eliminar(string /*0*/pOperador_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pOperador_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("venOperadoresEliminar", parametros);
		}

		public static int Guardar(string /*0*/pOperador_Id, string /*1*/pOperador_Id_Nueva, int /*2*/pEmpresa_Id, bool /*3*/pInactivo, bool /*4*/pPosteado, string /*5*/pRfcOperador, string /*6*/pNumLicencia, string /*7*/pNombreOperador, string /*8*/pNumRegIdTribOperador, short /*9*/pResidenciaFiscalOperador, string /*10*/pCalle, string /*11*/pNumeroExterior, string /*12*/pNumerointerior, string /*13*/pColonia, string /*14*/pLocalidad, string /*15*/pReferencia, string /*16*/pMunicipio, string /*17*/pEstado, short /*18*/pPais, string /*19*/pCodigoPostal, int /*20*/pUsuario_Id, string /*21*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pOperador_Id, /*1*/pOperador_Id_Nueva, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pInactivo, /*4*/pPosteado, /*5*/pRfcOperador, /*6*/pNumLicencia, /*7*/pNombreOperador, /*8*/pNumRegIdTribOperador, /*9*/pResidenciaFiscalOperador, /*10*/pCalle, new Generalidades.NullableString(/*11*/pNumeroExterior), new Generalidades.NullableString(/*12*/pNumerointerior), new Generalidades.NullableString(/*13*/pColonia), new Generalidades.NullableString(/*14*/pLocalidad), new Generalidades.NullableString(/*15*/pReferencia), new Generalidades.NullableString(/*16*/pMunicipio), new Generalidades.NullableString(/*17*/pEstado), new Generalidades.NullableShort(/*18*/pPais), new Generalidades.NullableString(/*19*/pCodigoPostal), /*20*/pUsuario_Id };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			return (int) oiDAAB.guardar("venOperadoresGuardar", parametros);
		}




	}
}
