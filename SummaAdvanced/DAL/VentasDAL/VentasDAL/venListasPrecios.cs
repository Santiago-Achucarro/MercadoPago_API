using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using interfaceDAAB;
using System.Data;

namespace VentasDAL
{
    public class venListasPrecios
    {
		public static venListasPreciosDS Datos(int /*0*/pEmpresa_Id, string /*1*/pListaPrecio_Id, int /*2*/pVersion, string /*3*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pListaPrecio_Id, new Generalidades.NullableInt(/*2*/pVersion) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venListasPreciosDatos", parametros);

			string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Moneda_Id", "DescripcionMonedas", "UsuarioAutorizado" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "AdmiteRegalo", "Marca" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			string[] camposTabla2 = { "NroBonifRecargo", "Nombre" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

			string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

			venListasPreciosDS dsTipado = new venListasPreciosDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdProductos.TableName, dsTipado.grdBonifReca.TableName, dsTipado.genAtributosGenerales.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}


		public static venListasPreciosDS TraerProductos(int /*0*/pEmpresa_Id, string /*1*/pListaPrecio_Id, string /*2*/pVer, int /*3*/pVersion, string /*4*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pListaPrecio_Id, /*2*/pVer, /*3*/pVersion };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venListasPreciosTraerProductos", parametros);

			string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Moneda_Id", "DescripcionMonedas", "UsuarioAutorizado", "Ver" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "AdmiteRegalo", "Marca" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			string[] camposTabla2 = { "NroBonifRecargo", "Nombre" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

			string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

			venListasPreciosDS dsTipado = new venListasPreciosDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdProductos.TableName, dsTipado.grdBonifReca.TableName, dsTipado.genAtributosGenerales.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}


		public static void Eliminar(string /*0*/pListaPrecio_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pListaPrecio_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venListasPreciosEliminar", parametros);
        }

		public static int Guardar(string /*0*/pListaPrecio_Id, string /*1*/pListaPrecio_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, string /*4*/pMoneda_Id, bool /*5*/pLlevaImpuestoInclu, string /*6*/pUsuAutorizado, bool /*7*/pInactivo, int /*8*/pUsuario_Id, bool /*9*/pPosteado, int /*10*/pDecimalesPu, string /*11*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pListaPrecio_Id, /*1*/pListaPrecio_Id_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, new Generalidades.NullableString(/*4*/pMoneda_Id), /*5*/pLlevaImpuestoInclu, new Generalidades.NullableString(/*6*/pUsuAutorizado), /*7*/pInactivo, /*8*/pUsuario_Id, /*9*/pPosteado, /*10*/pDecimalesPu };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			return (int) oiDAAB.guardar("venListasPreciosGuardar", parametros);
		}




		public static void Copiar(int /*0*/pLista, int /*1*/pVersion, int /*2*/pLista_Ap, int /*3*/pVersion_Ap, decimal /*4*/pCoeficiente, int /*5*/pDecimales, string /*6*/pProductoDesde, string /*7*/pProductoHasta, string /*8*/pFamiliaDesde, string /*9*/pFamiliaHasta, string /*10*/pGrupoDesde, string /*11*/pGrupoHasta, string /*12*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pLista, /*1*/pVersion, /*2*/pLista_Ap, /*3*/pVersion_Ap, /*4*/pCoeficiente, /*5*/pDecimales, /*6*/pProductoDesde, /*7*/pProductoHasta, /*8*/pFamiliaDesde, /*9*/pFamiliaHasta, /*10*/pGrupoDesde, /*11*/pGrupoHasta };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("venListaCopiar", parametros);
		}





		public static venListasPreciosDS DatosCabe(int /*0*/pEmpresa_Id, string /*1*/pListaPrecio_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pListaPrecio_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venListasPreciosDatosCabe", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Moneda_Id", "DescripcionMonedas", "UsuarioAutorizado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "AdmiteRegalo", "Marca" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "NroBonifRecargo", "Nombre" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            venListasPreciosDS dsTipado = new venListasPreciosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdProductos.TableName, dsTipado.grdBonifReca.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


		public static venListasPreciosXLSCatalogoDS DatosXLS(string /*0*/pListaDesde, string /*1*/pListaHasta, string /*2*/pProductoDesde, string /*3*/pProductoHasta, DateTime /*4*/pFecha, string /*5*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pListaDesde, /*1*/pListaHasta, /*2*/pProductoDesde, /*3*/pProductoHasta, /*4*/pFecha };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venListasPreciosXLSCatalogo", parametros);

			string[] camposTabla0 = { "ListaDesde", "ListaHasta", "ProductoDesde", "ProductoHasta", "Fecha" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			venListasPreciosXLSCatalogoDS dsTipado = new venListasPreciosXLSCatalogoDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Listas.TableName, dsTipado.Productos.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static venlistasHayOrtaDS HayOtra(string /*0*/ListaPrecio_Id, int /*1*/Version, DateTime /*2*/VigenciaDesde, DateTime /*3*/VigenciaHasta, string /*4*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/ListaPrecio_Id, /*1*/Version, /*2*/VigenciaDesde, /*3*/VigenciaHasta };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venlistasHayOrta", parametros);

			venlistasHayOrtaDS dsTipado = new venlistasHayOrtaDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}


	}
}
