using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using VentasCommon;
using System.Data;

namespace VentasDAL
{
    public class venIndicadores
    {

		public static ventasIndVentasDS Datos(DateTime /*0*/FechaDesde, DateTime /*1*/FechaHasta, string /*2*/VendedorDesde, string /*3*/VendedorHasta, string /*4*/ClienteDesde, string /*5*/ClienteHasta, string /*6*/FamiliaDesde, string /*7*/FamiliaHasta, string /*8*/GrupoDesde, string /*9*/GrupoHasta, string /*10*/ProductoDesde, string /*11*/ProductoHasta, int /*12*/Empresa_Id, string /*13*/SucursalDesde, string /*14*/SucursalHasta, string /*15*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/FechaDesde, /*1*/FechaHasta, /*2*/VendedorDesde, /*3*/VendedorHasta, /*4*/ClienteDesde, /*5*/ClienteHasta, /*6*/FamiliaDesde, /*7*/FamiliaHasta, /*8*/GrupoDesde, /*9*/GrupoHasta, /*10*/ProductoDesde, /*11*/ProductoHasta, /*12*/Empresa_Id, /*13*/SucursalDesde, /*14*/SucursalHasta };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("ventasIndVentasDatos", parametros);

			string[] camposTabla0 = { "FechaDesde", "FechaHasta", "VendedorDesde", "VendedorHasta", "ClienteDesde", "ClienteHasta", "FamiliaDesde", "FamiliaHasta", "GrupoDesde", "GrupoHasta", "ProductoDesde", "ProductoHasta", "Empresa_Id", "VentaTotal", "VentaMismoPerAnioAnt", "VentaPerAnterior", "SucursalDesde", "SucursalHasta" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			ventasIndVentasDS dsTipado = new ventasIndVentasDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Monto.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}




		public static venGraTortaClienteDS DatosCliente(DateTime /*0*/FechaDesde, DateTime /*1*/FechaHasta, string /*2*/ClienteDesde, string /*3*/ClienteHasta, string /*4*/VendedorDesde, string /*5*/VendedorHasta, int /*6*/Empresa_Id, string /*7*/SucursalDesde, string /*8*/SucursalHasta, string /*9*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/FechaDesde, /*1*/FechaHasta, /*2*/ClienteDesde, /*3*/ClienteHasta, /*4*/VendedorDesde, /*5*/VendedorHasta, /*6*/Empresa_Id, /*7*/SucursalDesde, /*8*/SucursalHasta };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venGraTortaClienteDatos", parametros);

			string[] camposTabla0 = { "FechaDesde", "FechaHasta", "ClienteDesde", "ClienteHasta", "Empresa_Id", "VendedorDesde", "VendedorHasta", "SucursalDesde", "SucursalHasta" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Serie", "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			venGraTortaClienteDS dsTipado = new venGraTortaClienteDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Torta.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}





		public static venGraTortaVendedorDS DatosVendedor(DateTime /*0*/FechaDesde, DateTime /*1*/FechaHasta, string /*2*/VendedorDesde, string /*3*/VendedorHasta, int /*4*/Empresa_Id, string /*5*/SucursalDesde, string /*6*/SucursalHasta, string /*7*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/FechaDesde, /*1*/FechaHasta, /*2*/VendedorDesde, /*3*/VendedorHasta, /*4*/Empresa_Id, /*5*/SucursalDesde, /*6*/SucursalHasta };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venGraTortaVendedorDatos", parametros);

			string[] camposTabla0 = { "FechaDesde", "FechaHasta", "VendedorDesde", "VendedorHasta", "Empresa_Id", "SucursalDesde", "SucursalHasta" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Serie", "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			venGraTortaVendedorDS dsTipado = new venGraTortaVendedorDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Torta.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}



		public static venGraTortaFamiliaDS DatosFamilia(DateTime /*0*/FechaDesde, DateTime /*1*/FechaHasta, string /*2*/FamiliaDesde, string /*3*/FamiliaHasta, string /*4*/ClienteDesde, string /*5*/ClienteHasta, int /*6*/Empresa_Id, string /*7*/SucursalDesde, string /*8*/SucursalHasta, string /*9*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/FechaDesde, /*1*/FechaHasta, /*2*/FamiliaDesde, /*3*/FamiliaHasta, /*4*/ClienteDesde, /*5*/ClienteHasta, /*6*/Empresa_Id, /*7*/SucursalDesde, /*8*/SucursalHasta };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venGraTortaFamiliaDatos", parametros);

			string[] camposTabla0 = { "FechaDesde", "FechaHasta", "FamiliaDesde", "FamiliaHasta", "ClienteDesde", "ClienteHasta", "Empresa_Id", "SucursalDesde", "SucursalHasta" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Serie", "Monto", "Familia_Id", "Descripcion" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			venGraTortaFamiliaDS dsTipado = new venGraTortaFamiliaDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Monto.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}




		public static venGraTortaGrupoDS DatosGrupo(DateTime /*0*/FechaDesde, DateTime /*1*/FechaHasta, string /*2*/FamiliaDesde, string /*3*/FamiliaHasta, string /*4*/GrupoDesde, string /*5*/GrupoHasta, int /*6*/Empresa_Id, string /*7*/SucursalDesde, string /*8*/SucursalHasta, string /*9*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/FechaDesde, /*1*/FechaHasta, /*2*/FamiliaDesde, /*3*/FamiliaHasta, /*4*/GrupoDesde, /*5*/GrupoHasta, /*6*/Empresa_Id, /*7*/SucursalDesde, /*8*/SucursalHasta };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venGraTortaGrupoDatos", parametros);

			string[] camposTabla0 = { "FechaDesde", "FechaHasta", "FamiliaDesde", "FamiliaHasta", "GrupoDesde", "GrupoHasta", "Empresa_Id", "SucursalDesde", "SucursalHasta" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Serie", "Monto", "Grupo_Id", "Descripcion" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			venGraTortaGrupoDS dsTipado = new venGraTortaGrupoDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Monto.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}




		public static venGraTortaProductoDS DatosProducto(DateTime /*0*/FechaDesde, DateTime /*1*/FechaHasta, string /*2*/FamiliaDesde, string /*3*/FamiliaHasta, string /*4*/GrupoDesde, string /*5*/GrupoHasta, string /*6*/ProductoDesde, string /*7*/ProductoHasta, int /*8*/Empresa_Id, string /*9*/SucursalDesde, string /*10*/SucursalHasta, string /*11*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/FechaDesde, /*1*/FechaHasta, /*2*/FamiliaDesde, /*3*/FamiliaHasta, /*4*/GrupoDesde, /*5*/GrupoHasta, /*6*/ProductoDesde, /*7*/ProductoHasta, /*8*/Empresa_Id, /*9*/SucursalDesde, /*10*/SucursalHasta };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venGraTortaProductoDatos", parametros);

			string[] camposTabla0 = { "FechaDesde", "FechaHasta", "FamiliaDesde", "FamiliaHasta", "GrupoDesde", "GrupoHasta", "ProductoDesde", "ProductoHasta", "Empresa_Id", "SucursalDesde", "SucursalHasta" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Serie", "Monto" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			venGraTortaProductoDS dsTipado = new venGraTortaProductoDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Monto.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}



	}
}
