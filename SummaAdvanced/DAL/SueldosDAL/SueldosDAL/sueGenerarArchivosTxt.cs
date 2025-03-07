using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SueldosCommon;
namespace SueldosDAL
{
    public class sueGenerarArchivosTxt
    {
        public static sueGenerarArchivosTxtDS Datos(string /*0*/pArchivo_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pArchivo_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueGenerarArchivosTxtDatos", parametros);

            string[] camposTabla0 = { "FechaDesde", "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            sueGenerarArchivosTxtDS dsTipado = new sueGenerarArchivosTxtDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }






        public static sueGenerarArchivosTxtDatos2DS Datos2(string /*0*/pArchivo_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pArchivo_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueGenerarArchivosTxtDatos2", parametros);

            string[] camposTabla0 = { "FechaDesde", "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Formato" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Res1Archivo_Id", "Res2Archivo_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Formato" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla4 = { "Formato" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            sueGenerarArchivosTxtDatos2DS dsTipado = new sueGenerarArchivosTxtDatos2DS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.Resumenes.TableName, dsTipado.Resumen1.TableName, dsTipado.Resumen2.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static sueArchivoTxtObtenerEmpleDS ObtenerEmple(int /*0*/LegajoDesde, int /*1*/LegajaHasta, string /*2*/Tipo, DateTime /*3*/FechaDesde, DateTime /*4*/FechaHasta, int /*5*/Anio, int /*6*/Mes, int /*7*/Quincena, int /*8*/Vez, int /*9*/Semana, int /*10*/Decena, string /*11*/SucursalDesde, string /*12*/SucursalHasta, string /*13*/TipoPagoDesde, string /*14*/TipoPagoHasta, int /*15*/Empresa, string /*16*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/LegajoDesde, /*1*/LegajaHasta, /*2*/Tipo, /*3*/FechaDesde, /*4*/FechaHasta, /*5*/Anio, /*6*/Mes, /*7*/Quincena, /*8*/Vez, /*9*/Semana, /*10*/Decena, /*11*/SucursalDesde, /*12*/SucursalHasta, /*13*/TipoPagoDesde, /*14*/TipoPagoHasta, /*15*/Empresa };


            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueArchivoTxtObtenerEmple", parametros);

            sueArchivoTxtObtenerEmpleDS dsTipado = new sueArchivoTxtObtenerEmpleDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static sueArchivoTxtObtenerConceptosDS ObtenerConceptos(int /*0*/pLegajo, int /*1*/pAnio, int /*2*/pMes, int /*3*/pQuincena, int /*4*/pVez, int /*5*/pSemana, int /*6*/pDecena, int /*7*/pEmpresa, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pLegajo, /*1*/pAnio, /*2*/pMes, /*3*/pQuincena, /*4*/pVez, /*5*/pSemana, /*6*/pDecena, /*7*/pEmpresa };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("sueArchivoTxtObtenerConceptos", parametros);

            sueArchivoTxtObtenerConceptosDS dsTipado = new sueArchivoTxtObtenerConceptosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

    }
}
