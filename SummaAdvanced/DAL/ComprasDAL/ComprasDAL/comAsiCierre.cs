using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using ComprasCommon;


namespace ComprasDAL
{
    public class comAsiCierre
    {
        public static comAsiCierreDS Datos(DateTime /*0*/pFecha, string /*1*/pMoneda_id, int /*2*/pEmpresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFecha, /*1*/pMoneda_id, /*2*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comAsiCierreDatos", parametros);

            string[] camposTabla0 = { "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comAsiCierreDS dsTipado = new comAsiCierreDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





        public static void Guardar(long /*0*/pAsiento_Id, DateTime /*1*/pFecha, string /*2*/pMoneda_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pFecha, /*2*/pMoneda_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comAsiCierreGuardar", parametros);
        }


        public static void Eliminar(long pAsiento_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comAsiCierreEliminar", parametros);
        }



        public static comAsiCierreCalculoDS CalculoDatos(DateTime /*0*/Fecha, int /*1*/Empresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Fecha, /*1*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comAsiCierreCalculoDatos", parametros);

            string[] camposTabla0 = { "Fecha" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Importe", "ImporteMonedaOriginal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            comAsiCierreCalculoDS dsTipado = new comAsiCierreCalculoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static comAsiCierreDatosCierreDS DatosCierre(DateTime /*0*/pFecha, int /*1*/Empresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFecha, /*1*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comAsiCierreDatosCierre", parametros);

            string[] camposTabla0 = { "Fecha" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comAsiCierreDatosCierreDS dsTipado = new comAsiCierreDatosCierreDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





    }
}
