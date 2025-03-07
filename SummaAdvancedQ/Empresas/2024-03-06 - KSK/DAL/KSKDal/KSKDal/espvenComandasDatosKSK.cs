using KSKCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSKDAL
{
    public class espvenComandasDatosKSK
    {
		public static espvenComandasDatosKSKDS Datos(DateTime /*0*/pFecha, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pFecha };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("espvenComandasDatosKSK", parametros);

			string[] camposTabla0 = { "Fecha" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "Ticket" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			espvenComandasDatosKSKDS dsTipado = new espvenComandasDatosKSKDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Comandas.TableName, dsTipado.Productos.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Modificar(long /*0*/pconAsientos, DateTime /*1*/pFecha, string /*2*/pCliente_Id, string /*3*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pconAsientos, /*1*/pFecha, /*2*/pCliente_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("espTicketModificar", parametros);
		}
	}
}
