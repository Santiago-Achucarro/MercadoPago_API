using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venClieHabitual
    {
		public static venClieHabitualDS Datos(string /*0*/pCliente_Id, int /*1*/pSucursal, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pCliente_Id, /*1*/pSucursal };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venClieHabitualDatos", parametros);

			string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "CondFisc_Id", "DescripcionCondFiscal", "MonedaLimCred", "CategCred_Id", "DescripcionCategCredito", "Estado_Id", "DescripcionClieEstados", "FacturaCredito", "MontoFacturaCredito", "CbuBanco", "Provincia_Id_Fact", "DescripcionProvincia_Id_Fact", "Pais_Id_Fact", "DescripcionPais_Id_Fact", "Provincia_Id_Entr", "DescripcionProvincia_Id_Entr", "Pais_Id_Entr", "DescripcionPais_Id_Entr", "TipoClie_Id", "DescripcionTiposClie", "ListaPrecio_Id", "DescripcionListasPrecios", "FormaEntrega_Id", "DescripcionFormaEntrega", "CondPagoCli_Id", "DescripcionCondPago", "Vendedor_Id", "DescripcionVendedores", "Cobrador_Id", "DescripcionCobradores", "Zona_Id", "DescripcionZona", "Region_Id", "DescripcionRegion", "Observaciones", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "ClieConsolida", "DescripcionClieConsolida", "Dominio_Id", "C_UsoCFDI", "N_MetodoPago", "UsaComplementoINE", "LatitudGPS", "LongitudGPS", "c_ColoniaEntr", "c_LocalidadEntr", "c_MunicipioEntr", "Regimen" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

			string[] camposTabla3 = { "FechaHasta" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

			string[] camposTabla4 = { "Observaciones" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

			venClieHabitualDS dsTipado = new venClieHabitualDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuentas.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.genJurisCoeficientes.TableName, dsTipado.grdContactos.TableName, dsTipado.Adjuntos.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}




		public static void Eliminar(string /*0*/pCliente_Id, int /*1*/pSucursal, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pCliente_Id, new Generalidades.NullableInt(/*1*/pSucursal) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("venClieHabitualEliminar", parametros);
		}


		public static void Guardar(long /*0*/pgenEntidades, int /*1*/pSucursal, string /*2*/pNombreFantasia, string /*3*/pDireccion1_Fact, string /*4*/pDireccion2_Fact, string /*5*/pLocalidad_Fact, string /*6*/pCodPostal_Fact, string /*7*/pProvincia_Id_Fact, short /*8*/pPais_Id_Fact, string /*9*/pTelefonos, string /*10*/pFax, string /*11*/pEMail, string /*12*/pDireccion1_Entr, string /*13*/pDireccion2_Entr, string /*14*/pLocalidad_Entr, string /*15*/pCodPostal_Entr, string /*16*/pProvincia_Id_Entr, short /*17*/pPais_Id_Entr, string /*18*/pTipoClie_Id, string /*19*/pListaPrecio_Id, string /*20*/pFormaEntrega_Id, string /*21*/pCondPagoCli_Id, string /*22*/pVendedor_Id, string /*23*/pCobrador_Id, string /*24*/pZona_Id, string /*25*/pRegion_Id, string /*26*/pContactos, bool /*27*/pInactivo, int /*28*/pUsuario_Id_Alta, DateTime /*29*/pFechaAlta, DateTime /*30*/pFechaUltContacto, DateTime /*31*/pFechaModificacion, string /*32*/pObservaciones, decimal /*33*/pBonificacion1, decimal /*34*/pBonificacion2, decimal /*35*/pBonificacion3, string /*36*/pCentro1_Id, string /*37*/pCentro2_Id, string /*38*/pClieConsolida, string /*39*/pNroExterior_Fact, string /*40*/pNroInterior_Fact, string /*41*/pNroExterior_Entr, string /*42*/pNroInterior_Entr, string /*43*/pReclamos, string /*44*/pMetodoDePago, string /*45*/pNumCuenta, string /*46*/pC_UsoCFDI, string /*47*/pN_MetodoPago, bool /*48*/pUsaComplementoINE, decimal /*49*/pLongitudGPS, decimal /*50*/pLatitudGPS, string /*51*/pc_ColoniaEntr, string /*52*/pc_LocalidadEntr, string /*53*/pc_MunicipioEntr, string /*54*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pgenEntidades, /*1*/pSucursal, /*2*/pNombreFantasia, /*3*/pDireccion1_Fact, /*4*/pDireccion2_Fact, /*5*/pLocalidad_Fact, /*6*/pCodPostal_Fact, new Generalidades.NullableString(/*7*/pProvincia_Id_Fact), new Generalidades.NullableShort(/*8*/pPais_Id_Fact), /*9*/pTelefonos, /*10*/pFax, /*11*/pEMail, /*12*/pDireccion1_Entr, /*13*/pDireccion2_Entr, /*14*/pLocalidad_Entr, /*15*/pCodPostal_Entr, new Generalidades.NullableString(/*16*/pProvincia_Id_Entr), new Generalidades.NullableShort(/*17*/pPais_Id_Entr), new Generalidades.NullableString(/*18*/pTipoClie_Id), new Generalidades.NullableString(/*19*/pListaPrecio_Id), new Generalidades.NullableString(/*20*/pFormaEntrega_Id), new Generalidades.NullableString(/*21*/pCondPagoCli_Id), new Generalidades.NullableString(/*22*/pVendedor_Id), new Generalidades.NullableString(/*23*/pCobrador_Id), new Generalidades.NullableString(/*24*/pZona_Id), new Generalidades.NullableString(/*25*/pRegion_Id), /*26*/pContactos, /*27*/pInactivo, /*28*/pUsuario_Id_Alta, /*29*/pFechaAlta, /*30*/pFechaUltContacto, /*31*/pFechaModificacion, new Generalidades.NullableString(/*32*/pObservaciones), /*33*/pBonificacion1, /*34*/pBonificacion2, /*35*/pBonificacion3, new Generalidades.NullableString(/*36*/pCentro1_Id), new Generalidades.NullableString(/*37*/pCentro2_Id), new Generalidades.NullableString(/*38*/pClieConsolida), /*39*/pNroExterior_Fact, /*40*/pNroInterior_Fact, /*41*/pNroExterior_Entr, /*42*/pNroInterior_Entr, /*43*/pReclamos, /*44*/pMetodoDePago, /*45*/pNumCuenta, /*46*/pC_UsoCFDI, /*47*/pN_MetodoPago, /*48*/pUsaComplementoINE, /*49*/pLongitudGPS, /*50*/pLatitudGPS, new Generalidades.NullableString(/*51*/pc_ColoniaEntr), new Generalidades.NullableString(/*52*/pc_LocalidadEntr), new Generalidades.NullableString(/*53*/pc_MunicipioEntr) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("venClieHabitualGuardar", parametros);
		}



	}
}
