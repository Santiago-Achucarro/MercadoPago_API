using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using GeneralesCommon;

namespace GeneralesDAL
{
	public class genControlesSeteos
	{
		public static genControlesSeteosDS Datos(string /*0*/pFormulario_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pFormulario_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("genControlesSeteosDatos", parametros);

			string[] camposTabla0 = { "DescripcionFormularios" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Valor" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			genControlesSeteosDS dsTipado = new genControlesSeteosDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Controles.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}


		public static void Eliminar(string /*0*/pFormulario_Id, string /*1*/pControl_Id, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pFormulario_Id, new Generalidades.NullableString(/*1*/pControl_Id) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("genControlesSeteosEliminar", parametros);
		}


		public static void Guardar(string /*0*/pFormulario_Id, string /*1*/pControl_Id, int /*2*/pOrden, string /*3*/pValor, bool /*4*/pModificoValor, bool /*5*/pDeshabilitar, bool /*6*/pOcultar, bool /*7*/pSeteadoPorSistema, int /*8*/pUsuario_Id, string /*9*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pFormulario_Id, /*1*/pControl_Id, /*2*/pOrden, new Generalidades.NullableString(/*3*/pValor), /*4*/pModificoValor, /*5*/pDeshabilitar, /*6*/pOcultar, /*7*/pSeteadoPorSistema, /*8*/pUsuario_Id };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("genControlesSeteosGuardar", parametros);
		}



	}

}