using ComprasCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprasDAL
{
    public class comMovProvDevengaCont
    {
		public static comMovProvDevengaContDS Datos(long /*0*/pcomMovProv, long /*1*/pconAsientos, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pconAsientos };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("comMovProvDevengaContDatos", parametros);

			string[] camposTabla0 = { "Asiento", "Importe" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			comMovProvDevengaContDS dsTipado = new comMovProvDevengaContDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Eliminar(long /*0*/pcomMovProv, long /*1*/pconAsientos, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pconAsientos };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("comMovProvDevengaContEliminar", parametros);
		}

		public static void Guardar(long /*0*/pcomMovProv, long /*1*/pconAsientos, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pconAsientos };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("comMovProvDevengaContGuardar", parametros);
		}
	}
}
