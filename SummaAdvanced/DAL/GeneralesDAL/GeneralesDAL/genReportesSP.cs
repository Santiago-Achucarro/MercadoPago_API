using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genReportesSP
    {
        public static genReportesSPDS Datos(string /*0*/pReporte_ID, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pReporte_ID, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genReportesSPDatos", parametros);

            genReportesSPDS dsTipado = new genReportesSPDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Guardar(string /*0*/pReporte_ID, int /*1*/pRenglon, string /*2*/pStoreProcedure, string /*3*/pDataTable, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pReporte_ID, /*1*/pRenglon, /*2*/pStoreProcedure, /*3*/pDataTable };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genReportesSPGuardar", parametros);
        }


        public static void Eliminar(int /*0*/pgenReportes, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pgenReportes, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genReportesSPEliminar", parametros);
        }



    }
}
