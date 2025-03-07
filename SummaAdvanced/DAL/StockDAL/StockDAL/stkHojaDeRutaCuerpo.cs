using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkHojaDeRutaCuerpo
    {
		public static stkHojaDeRutaCuerpoDS Datos(int /*0*/pstkHojaDeRuta, long /*1*/pconAsientos, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pstkHojaDeRuta), /*1*/pconAsientos };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("stkHojaDeRutaCuerpoDatos", parametros);

			string[] camposTabla0 = { "Comprobante", "HojaRuta" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			stkHojaDeRutaCuerpoDS dsTipado = new stkHojaDeRutaCuerpoDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Eliminar(int /*0*/pstkHojaDeRuta, long /*1*/pconAsientos, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pstkHojaDeRuta, new Generalidades.NullableInt64(/*1*/pconAsientos) };
			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);
			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("stkHojaDeRutaCuerpoEliminar", parametros);
		}

		public static void Guardar(int /*0*/pstkHojaDeRuta, long /*1*/pconAsientos, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pstkHojaDeRuta, /*1*/pconAsientos };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("stkHojaDeRutaCuerpoGuardar", parametros);
		}





	}
}
