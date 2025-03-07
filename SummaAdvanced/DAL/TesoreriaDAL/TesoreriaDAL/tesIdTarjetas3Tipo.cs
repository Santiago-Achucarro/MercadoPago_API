using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesIdTarjetas3Tipo
    {
		public static tesIdTarjetasTipoDS Datos(string /*0*/pTipoTarjeta, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTipoTarjeta };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("tesIdTarjetasTipoDatos", parametros);

			string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Usuario_Id", "DescripcionUsuario" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			tesIdTarjetasTipoDS dsTipado = new tesIdTarjetasTipoDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Eliminar(string /*0*/pTipoTarjeta, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTipoTarjeta };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("tesIdTarjetasTipoEliminar", parametros);
		}

		public static int Guardar(string /*0*/pTipoTarjeta, string /*1*/pTipoTarjeta_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, string /*4*/pClase, int /*5*/pUsuario_Id, bool /*6*/pInactivo, bool /*7*/pPosteado, string /*8*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pTipoTarjeta, /*1*/pTipoTarjeta_Nuevo, new Generalidades.NullableInt(/*2*/pEmpresa_Id), /*3*/pDescripcion, /*4*/pClase, new Generalidades.NullableInt(/*5*/pUsuario_Id), /*6*/pInactivo, /*7*/pPosteado };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			return ((int)oiDAAB.guardar("tesIdTarjetasTipoGuardar", parametros));
		}
	}
}
