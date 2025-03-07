using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using KSKCommon;
using System.Data;

namespace KSKDAL
{
    public class espvenClieContactoKSK
	{
		public static espvenClieContactoKSKDS Datos(long /*0*/pCliente_Id, int /*1*/pSucursal, int /*2*/pNroContacto, string /*3*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pCliente_Id, /*1*/pSucursal, /*2*/pNroContacto };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("espvenClieContactoKSKDatos", parametros);

			string[] camposTabla0 = { "Observaciones" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			espvenClieContactoKSKDS dsTipado = new espvenClieContactoKSKDS();
			string[] nombreTablas = { dsTipado.grdContactos.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Eliminar(long /*0*/pCliente_Id, int /*1*/pSucursal, int /*2*/pNroContacto, string /*3*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pCliente_Id, /*1*/pSucursal, /*2*/pNroContacto };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("espvenClieContactoKSKEliminar", parametros);
		}

		public static void Guardar(long /*0*/pCliente_Id, int /*1*/pSucursal, int /*2*/pNroContacto, string /*8*/pInstragram, string /*9*/pFacebook, string /*10*/pLinkedin, string /*11*/pYoutube, string /*19*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pCliente_Id, /*1*/pSucursal, /*2*/pNroContacto, /*3*/pInstragram, /*4*/pFacebook, /*5*/pLinkedin, /*6*/pYoutube};

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("espvenClieContactoKSKGuardar", parametros);
		}





	}
}
