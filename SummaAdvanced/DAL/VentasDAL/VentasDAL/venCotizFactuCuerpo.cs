using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using interfaceDAAB;
using System.Data;
namespace VentasDAL
{
    public class venCotizFactuCuerpo
    {
		public static venCotizFactuCuerpoDS Datos(long /*0*/pvenMovimientos, int /*1*/pRenglonCuerpo, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenMovimientos, new Generalidades.NullableInt(/*1*/pRenglonCuerpo) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("venCotizFactuCuerpoDatos", parametros);

			string[] camposTabla0 = { "venCotizaciones", "Renglon_Co" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			venCotizFactuCuerpoDS dsTipado = new venCotizFactuCuerpoDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Eliminar(long /*0*/pvenMovimientos, int /*1*/pRenglonCuerpo, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pRenglonCuerpo };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("venCotizFactuCuerpoEliminar", parametros);
		}

		public static void Insertar(long /*0*/pvenMovimientos, int /*1*/pRenglonCuerpo, int /*2*/pvenCotizaciones, int /*3*/pRenglon_Co, decimal /*4*/pCantidad, string /*5*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pRenglonCuerpo, /*2*/pvenCotizaciones, /*3*/pRenglon_Co, /*4*/pCantidad };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("venCotizFactuCuerpoInsertar", parametros);
		}




	}
}
