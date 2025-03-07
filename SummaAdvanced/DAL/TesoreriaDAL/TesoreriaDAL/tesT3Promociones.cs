using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesT3Promociones
    {
		public static tesT3PromocionesDS Datos(int /*0*/pPromocion_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pPromocion_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("tesT3PromocionesDatos", parametros);

			string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "Usuario_Id", "DescripcionUsuario" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

			tesT3PromocionesDS dsTipado = new tesT3PromocionesDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.PromocionCuotas.TableName, dsTipado.PromocionTarjetas.TableName, dsTipado.genAtributosGenerales.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Eliminar(int /*0*/pPromocion_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pPromocion_Id) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("tesT3PromocionesEliminar", parametros);
		}


		public static int Guardar(int /*0*/pPromocion_Id, int /*1*/pPromocion_Id_Nuevo, string /*2*/pDescripcion, int /*3*/pEmpresa_Id, DateTime /*4*/pVigenciaDesde, DateTime /*5*/pVigenciaHasta, bool /*6*/pInactivo, bool /*7*/pPosteado, int /*8*/pUsuario_Id, string /*9*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pPromocion_Id, /*1*/pPromocion_Id_Nuevo, /*2*/pDescripcion, new Generalidades.NullableInt(/*3*/pEmpresa_Id), /*4*/pVigenciaDesde, /*5*/pVigenciaHasta, /*6*/pInactivo, /*7*/pPosteado, new Generalidades.NullableInt(/*8*/pUsuario_Id) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			return ((int)oiDAAB.guardar("tesT3PromocionesGuardar", parametros));
		}

		public static tesT3PromocionesVigentesDS Vigentes(int /*0*/pEmpresa_Id, DateTime /*1*/pFecha, string /*2*/pCartera_Id, string /*3*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pFecha, /*2*/pCartera_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("tesT3PromocionesVigentes", parametros);

			tesT3PromocionesVigentesDS dsTipado = new tesT3PromocionesVigentesDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}
	}
}
