using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
namespace VentasDAL
{
    public class venPropArrenda
    {
		public static venPropietarioArrendaDS Datos(string /*0*/pPropArre_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pPropArre_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venPropietarioArrendaDatos", parametros);

			string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "NumeroExterior", "Numerointerior", "Colonia", "Localidad", "Referencia", "Municipio", "Estado", "CodigoPostal" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			venPropietarioArrendaDS dsTipado = new venPropietarioArrendaDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Eliminar(string /*0*/pPropArre_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pPropArre_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("venPropietarioArrendaEliminar", parametros);
		}

		public static int Guardar(string /*0*/pPropArre_Id, string /*1*/pPropArre_Id_Nueva, int /*2*/pEmpresa_Id, int /*3*/pPropArre, string /*4*/pRfc, string /*5*/pNombre, string /*6*/pNumRegIdTrib, short /*7*/pResidenciaFiscal, string /*8*/pCalle, string /*9*/pNumeroExterior, string /*10*/pNumerointerior, string /*11*/pColonia, string /*12*/pLocalidad, string /*13*/pReferencia, string /*14*/pMunicipio, string /*15*/pEstado, short /*16*/pPais, string /*17*/pCodigoPostal, int /*18*/pUsuario_Id, string /*19*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pPropArre_Id, /*1*/pPropArre_Id_Nueva, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pPropArre, /*4*/pRfc, /*5*/pNombre, /*6*/pNumRegIdTrib, /*7*/pResidenciaFiscal, /*8*/pCalle, new Generalidades.NullableString(/*9*/pNumeroExterior), new Generalidades.NullableString(/*10*/pNumerointerior), new Generalidades.NullableString(/*11*/pColonia), new Generalidades.NullableString(/*12*/pLocalidad), new Generalidades.NullableString(/*13*/pReferencia), new Generalidades.NullableString(/*14*/pMunicipio), new Generalidades.NullableString(/*15*/pEstado), new Generalidades.NullableShort(/*16*/pPais), new Generalidades.NullableString(/*17*/pCodigoPostal), /*18*/pUsuario_Id };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			return (int) oiDAAB.guardar("venPropietarioArrendaGuardar", parametros);
		}



	}
}
