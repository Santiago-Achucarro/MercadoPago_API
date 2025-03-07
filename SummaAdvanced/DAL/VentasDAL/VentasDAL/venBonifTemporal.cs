using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venBonifTemporal
    {
		public static venBonifTemporalDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venBonifTemporalDatos", parametros);

			string[] camposTabla0 = { "PTodasLasEmpresas" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			venBonifTemporalDS dsTipado = new venBonifTemporalDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}



		public static venBonifTemporalDS DatosInt(int /*0*/pvenBonifTemporal, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenBonifTemporal };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venBonifTemporalDatosId", parametros);

			string[] camposTabla0 = { "PTodasLasEmpresas" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			venBonifTemporalDS dsTipado = new venBonifTemporalDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}


		public static void Eliminar(int /*0*/pvenBonifTemporal, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenBonifTemporal };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("venBonifTemporalEliminar", parametros);
		}
		public static int Guardar(int /*0*/pvenBonifTemporal, string /*1*/pDescripcion, int /*2*/pEmpresa_Id, DateTime /*3*/pFechaDesde, DateTime /*4*/pFechaHasta, string /*5*/pSucursalDesde, string /*6*/pSucursalHasta, string /*7*/pClienteDesde, string /*8*/pClienteHasta, int /*9*/pSucursalClieDesde, int /*10*/pSucursalClieHasta, string /*11*/pTipoClieDesde, string /*12*/pTipoClieHasta, string /*13*/pProductoDesde, string /*14*/pProductoHasta, string /*15*/pTipoProductoDesde, string /*16*/pTipoProductoHasta, string /*17*/pBonificacion, string /*18*/pFamiliaDesde, string /*19*/pFamiliaHasta, string /*20*/pGrupoDesde, string /*21*/pGrupoHasta, int /*22*/pUsuario_Id, bool /*23*/pInactivo, bool /*24*/pPosteado, int /*25*/pPrioridad, string /*26*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenBonifTemporal, /*1*/pDescripcion, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pFechaDesde, /*4*/pFechaHasta, /*5*/pSucursalDesde, /*6*/pSucursalHasta, /*7*/pClienteDesde, /*8*/pClienteHasta, /*9*/pSucursalClieDesde, /*10*/pSucursalClieHasta, /*11*/pTipoClieDesde, /*12*/pTipoClieHasta, /*13*/pProductoDesde, /*14*/pProductoHasta, /*15*/pTipoProductoDesde, /*16*/pTipoProductoHasta, /*17*/pBonificacion, /*18*/pFamiliaDesde, /*19*/pFamiliaHasta, /*20*/pGrupoDesde, /*21*/pGrupoHasta, /*22*/pUsuario_Id, /*23*/pInactivo, /*24*/pPosteado, /*25*/pPrioridad };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			return ((int)oiDAAB.guardar("venBonifTemporalGuardar", parametros));
		}



		public static venBonifTemporalHayOtraDS HayOtras(int /*0*/pvenBonifTemporal, int /*1*/pEmpresa_Id, DateTime /*2*/pFechaDesde, DateTime /*3*/pFechaHasta, string /*4*/pSucursalDesde, string /*5*/pSucursalHasta, string /*6*/pClienteDesde, string /*7*/pClienteHasta, int /*8*/pSucursalClieDesde, int /*9*/pSucursalClieHasta, string /*10*/pTipoClieDesde, string /*11*/pTipoClieHasta, string /*12*/pProductoDesde, string /*13*/pProductoHasta, string /*14*/pTipoProductoDesde, string /*15*/pTipoProductoHasta, string /*16*/pBonificacion, string /*17*/pFamiliaDesde, string /*18*/pFamiliaHasta, string /*19*/pGrupoDesde, string /*20*/pGrupoHasta, string /*21*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenBonifTemporal, new Generalidades.NullableInt(/*1*/pEmpresa_Id), /*2*/pFechaDesde, /*3*/pFechaHasta, /*4*/pSucursalDesde, /*5*/pSucursalHasta, /*6*/pClienteDesde, /*7*/pClienteHasta, /*8*/pSucursalClieDesde, /*9*/pSucursalClieHasta, /*10*/pTipoClieDesde, /*11*/pTipoClieHasta, /*12*/pProductoDesde, /*13*/pProductoHasta, /*14*/pTipoProductoDesde, /*15*/pTipoProductoHasta, /*16*/pBonificacion, /*17*/pFamiliaDesde, /*18*/pFamiliaHasta, /*19*/pGrupoDesde, /*20*/pGrupoHasta };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venBonifTemporalHayOtra", parametros);

			string[] camposTabla0 = { "Bonif" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			venBonifTemporalHayOtraDS dsTipado = new venBonifTemporalHayOtraDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}



		public static QueBonifDS QueBonif(int /*0*/Empresa_Id, string /*1*/Cliente_Id, int /*2*/SucursalClie, string /*3*/Producto_Id, DateTime /*4*/Fecha, string /*5*/Sucursal, string /*6*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/Cliente_Id, /*2*/SucursalClie, /*3*/Producto_Id, /*4*/Fecha, /*5*/Sucursal };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("QueBonif", parametros);

			QueBonifDS dsTipado = new QueBonifDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}






	}
}
