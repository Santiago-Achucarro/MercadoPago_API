using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using interfaceDAAB;
using System.Data;

namespace VentasDAL
{
    public class venCotizPediCuerpo
    {
		public static venCotizPediCuerpoDS Datos(int /*0*/pvenPedidos, int /*1*/pRenglon_Pe, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenPedidos, new Generalidades.NullableInt(/*1*/pRenglon_Pe) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("venCotizPediCuerpoDatos", parametros);

			string[] camposTabla0 = { "venCotizaciones", "Renglon_Co" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			venCotizPediCuerpoDS dsTipado = new venCotizPediCuerpoDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}
		public static void Eliminar(int /*0*/pvenPedidos, int /*1*/pRenglon_Pe, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenPedidos, /*1*/pRenglon_Pe };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("venCotizPediCuerpoEliminar", parametros);
		}

		public static void Insertar(int /*0*/pvenPedidos, int /*1*/pRenglon_Pe, int /*2*/pvenCotizaciones, int /*3*/pRenglon_Co, decimal /*4*/pCantidad, string /*5*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenPedidos, /*1*/pRenglon_Pe, /*2*/pvenCotizaciones, /*3*/pRenglon_Co, /*4*/pCantidad };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("venCotizPediCuerpoInsertar", parametros);
		}




	}
}
