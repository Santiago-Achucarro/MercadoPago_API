using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venCotizAnul
    {
        public static venCotizAnulDS Datos(int /*0*/pCotizacion_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCotizacion_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venCotizAnulDatos", parametros);

            string[] camposTabla0 = { "venCotizaciones", "Fecha", "Operacion", "Usuario_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venCotizAnulDS dsTipado = new venCotizAnulDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pCotizacion_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCotizacion_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venCotizAnulEliminar", parametros);
        }

        public static void Guardar(int /*0*/pCotizacion_Id, DateTime /*1*/pFecha, string /*2*/pOperacion, int /*3*/pUsuario_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pCotizacion_Id), new Generalidades.NullableDate(/*1*/pFecha), new Generalidades.NullableString(/*2*/pOperacion), new Generalidades.NullableInt(/*3*/pUsuario_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venCotizAnulGuardar", parametros);
        }

    }
}
