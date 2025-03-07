using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
	public class venPediAutoriza
	{

		public static venPediAutorizaDS Datos(string /*0*/pCliente_Id, int /*1*/pEmpresa_Id, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pCliente_Id), /*1*/pEmpresa_Id };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("venPediAutorizaDatos", parametros);

			string[] camposTabla0 = { "Registro" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Segmento", "ObservEstado", "UsuarioAutoriz_Id" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			venPediAutorizaDS dsTipado = new venPediAutorizaDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.PedidosPendientes.TableName, dsTipado.Clientes.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static venPediAutorizaClienteDS ClientesDatos(string /*0*/pCliente_Id, string /*1*/pTipoClie_Id, string /*2*/pVendedor_Id, string /*3*/pCobrador_Id, string /*4*/pZona_Id, string /*5*/pFormaEntrega_Id, string /*6*/pSucursal_Id, int /*7*/pEmpresa_Id, string /*8*/ pAuxiliar)
		{
			Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pCliente_Id), new Generalidades.NullableString(/*1*/pTipoClie_Id), new Generalidades.NullableString(/*2*/pVendedor_Id), new Generalidades.NullableString(/*3*/pCobrador_Id), new Generalidades.NullableString(/*4*/pZona_Id), new Generalidades.NullableString(/*5*/pFormaEntrega_Id), new Generalidades.NullableString(/*6*/pSucursal_Id), /*7*/pEmpresa_Id };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("venPediAutorizaClienteDatos", parametros);

			venPediAutorizaClienteDS dsTipado = new venPediAutorizaClienteDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Clientes.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}


	}
}

