using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using SueldosCommon;
using System.Data;

namespace SueldosDAL
{
    public class sueVacTomadas
    {
        public static sueVacTomadasDS Datos(int /*0*/pLegajo, int /*1*/pAnio, DateTime /*2*/pFechaDesde, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pAnio, new Generalidades.NullableDate(/*2*/pFechaDesde) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueVacTomadasDatos", parametros);

            string[] camposTabla0 = { "Anio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            sueVacTomadasDS dsTipado = new sueVacTomadasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pLegajo, int /*1*/pAnio, DateTime /*2*/pFechaDesde, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pAnio, new Generalidades.NullableDate(/*2*/pFechaDesde) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueVacTomadasEliminar", parametros);
        }

        public static void Guardar(int /*0*/pLegajo, int /*1*/pAnio, DateTime /*2*/pFechaDesde, int /*3*/pDias, DateTime /*4*/pFechaHasta, int /*5*/pUsuario_Id, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pAnio, /*2*/pFechaDesde, /*3*/pDias, /*4*/pFechaHasta, /*5*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueVacTomadasGuardar", parametros);
        }


        public static sueVacTomadasDatosDetalladoDS DatosDetallado(int /*0*/pLegajo, int /*1*/pAnio, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pAnio };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueVacTomadasDatosDetallado", parametros);

            string[] camposTabla0 = { "Anio", "Antiguedad", "Convenio_Id", "DescripcionConvenio", "Dias", "Saldo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            sueVacTomadasDatosDetalladoDS dsTipado = new sueVacTomadasDatosDetalladoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

    }
}
