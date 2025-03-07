using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using interfaceDAAB;
using System.Data;

namespace VentasDAL
{
    public class venMovConforma
    {
        public static venMovConformaDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venMovConformaDatos", parametros);

            string[] camposTabla0 = { "Usuario_Id", "DescripcionUsuario", "FechaConforma", "FechaRegistro", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venMovConformaDS dsTipado = new venMovConformaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Adjuntos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





        public static void Eliminar(long /*0*/pvenMovimientos, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenMovimientos };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("venMovConformaEliminar", parametros);
		}

		public static void Guardar(long /*0*/pvenMovimientos, int /*1*/pUsuario_Id, DateTime /*2*/pFechaConforma, DateTime /*3*/pFechaRegistro, string /*4*/pObservaciones, string /*5*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pUsuario_Id, /*2*/pFechaConforma, /*3*/pFechaRegistro, new Generalidades.NullableString(/*4*/pObservaciones) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("venMovConformaGuardar", parametros);
		}


		public static void ActuFecha(long /*0*/pAsiento_Id, int /*1*/pDias, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pDias };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("genMovCuotasActuFecha", parametros);
		}



	}
}
