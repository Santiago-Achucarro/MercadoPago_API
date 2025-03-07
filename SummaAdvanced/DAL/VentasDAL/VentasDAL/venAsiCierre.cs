using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venAsiCierre
    {

        public static venAsiCierreCalculoDS CalculoDatos(DateTime /*0*/Fecha, int /*1*/Empresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Fecha, /*1*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venAsiCierreCalculoDatos", parametros);

            string[] camposTabla0 = { "Fecha" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Importe", "ImporteMonedaOriginal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            venAsiCierreCalculoDS dsTipado = new venAsiCierreCalculoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static venAsiCierreDS Datos(DateTime /*0*/pFecha, string /*1*/pMoneda_id, int /*2*/pEmpresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFecha, /*1*/pMoneda_id, /*2*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venAsiCierreDatos", parametros);

            string[] camposTabla0 = { "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venAsiCierreDS dsTipado = new venAsiCierreDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static venAsiCierreDatosCierreDS DatosCierre(DateTime /*0*/pFecha, int /*1*/Empresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFecha, /*1*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venAsiCierreDatosCierre", parametros);

            string[] camposTabla0 = { "Fecha" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venAsiCierreDatosCierreDS dsTipado = new venAsiCierreDatosCierreDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/Asiento_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Asiento_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venAsiCierreEliminar", parametros);
        }

        public static void Guardar(long /*0*/pAsiento_Id, DateTime /*1*/pFecha, string /*2*/pMoneda_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pFecha, /*2*/pMoneda_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venAsiCierreGuardar", parametros);
        }


    }
}
