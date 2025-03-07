using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using SueldosCommon;
using System.Data;

namespace SueldosDAL
{
    public class sueVacCorresponden
    {
        public static sueVacCorrespondenDS Datos(int /*0*/pLegajo, int /*1*/pAnio, int /*2*/pEmpresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pAnio, /*2*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueVacCorrespondenDatos", parametros);

            sueVacCorrespondenDS dsTipado = new sueVacCorrespondenDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(int /*0*/pAnio, int /*1*/pLegajo, int /*2*/pEmpresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAnio, new Generalidades.NullableInt(/*1*/pLegajo), /*2*/pEmpresa_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueVacCorrespondenEliminar", parametros);
        }



        public static void Guardar(int /*0*/pLegajo, int /*1*/pAnio, int /*2*/pDias, int /*3*/pSaldo, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pAnio, /*2*/pDias, new Generalidades.NullableInt(/*3*/pSaldo) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueVacCorrespondenGuardar", parametros);
        }

        public static sueVacCorrespondenDatosRangoDS DatosRango(int /*0*/pAnio, int /*1*/pLegajoDesde, int /*2*/pLegajoHasta, int /*3*/pEmpresa_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAnio, /*1*/pLegajoDesde, /*2*/pLegajoHasta, /*3*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueVacCorrespondenDatosRango", parametros);

            string[] camposTabla0 = { "Anio", "LegajoDesde", "LegajoHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Anio", "Dias", "Saldo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            sueVacCorrespondenDatosRangoDS dsTipado = new sueVacCorrespondenDatosRangoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





    }
}
