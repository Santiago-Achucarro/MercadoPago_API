using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venCartaPorteCompUbi
    {
		public static venCompCartaPorteUbiDS Datos(long /*0*/pvenmovimientos, int /*1*/pUbicacion, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenmovimientos, new Generalidades.NullableInt(/*1*/pUbicacion) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("venCompCartaPorteUbiDatos", parametros);

			string[] camposTabla0 = { "TipoEstacion" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			venCompCartaPorteUbiDS dsTipado = new venCompCartaPorteUbiDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}


		public static void Eliminar(long /*0*/pvenmovimientos, int /*1*/pUbicacion, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenmovimientos, new Generalidades.NullableInt(/*1*/pUbicacion) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("venCompCartaPorteUbiEliminar", parametros);
		}

		public static void Guardar(long /*0*/pvenmovimientos, int /*1*/pUbicacion, string /*2*/pTipoEstacion, decimal /*3*/pDistanciaRecorrida, string /*4*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenmovimientos, /*1*/pUbicacion, new Generalidades.NullableString(/*2*/pTipoEstacion), /*3*/pDistanciaRecorrida };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("venCompCartaPorteUbiGuardar", parametros);
		}




	}
}
