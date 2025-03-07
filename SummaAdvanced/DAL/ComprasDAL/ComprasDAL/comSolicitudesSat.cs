using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasCommon;
using interfaceDAAB;
using System.Data;

namespace ComprasDAL
{
    public class comSolicitudesSAT
    {
		public static comSolicitudesSatDS Datos(int /*0*/pSolicitud, int /*1*/pEmpresa_Id, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pSolicitud, /*1*/pEmpresa_Id };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("comSolicitudesSatDatos", parametros);

			string[] camposTabla0 = { "Empresa_Id", "Emitidos", "Descargados", "Fecha", "Usuario_Id", "Pendiente", "SolicitudSat" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "SolicitudSat", "Emitidos", "Fecha", "Pendiente", "UltimaRespuestaSat" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			comSolicitudesSatDS dsTipado = new comSolicitudesSatDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Pendientes.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

        public static void Eliminar(int /*0*/pSolicitud, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pSolicitud) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comSolicitudesSatEliminar", parametros);
        }

        public static int Guardar(int /*0*/pSolicitud, DateTime /*1*/pFechaDesde, DateTime /*2*/pFechaHasta, int /*3*/pEmpresa_Id, bool /*4*/pEmitidos, bool /*5*/pDescargados, DateTime /*6*/pFecha, int /*7*/pUsuario_Id, string /*8*/pSolicitud_Sat, string /*9*/pRespuestaSat, bool /*10*/pMetaDatos, string /*11*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSolicitud, /*1*/pFechaDesde, /*2*/pFechaHasta, new Generalidades.NullableInt(/*3*/pEmpresa_Id), new Generalidades.NullableBool(/*4*/pEmitidos), new Generalidades.NullableBool(/*5*/pDescargados), new Generalidades.NullableDate(/*6*/pFecha), new Generalidades.NullableInt(/*7*/pUsuario_Id), /*8*/pSolicitud_Sat, /*9*/pRespuestaSat, /*10*/pMetaDatos };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("comSolicitudesSatGuardar", parametros);
        }

        public static comSolicitudesSatDS DatosXEmpresa(int /*0*/pEmpresa_Id, bool /*1*/pPendientes, string /*2*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pPendientes };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("comSolicitudesSatDatosXEmpresa", parametros);

			string[] camposTabla0 = { "Empresa_Id", "Emitidos", "Descargados", "Fecha", "Usuario_Id", "Pendiente", "SolicitudSat" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			string[] camposTabla1 = { "SolicitudSat", "Emitidos", "Fecha", "Pendiente", "UltimaRespuestaSat" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

			comSolicitudesSatDS dsTipado = new comSolicitudesSatDS();
			string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Pendientes.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}
	}
}
