using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conArbolResultados
    {
        public static conArbolAsientosDS DatosER(int /*0*/Ejercicio, short /*1*/PeriodoHasta, int /*2*/Empresa, string /*3*/Centro1Desde, string /*4*/Centro1Hasta, string /*5*/Centro2Desde, string /*6*/Centro2Hasta, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Ejercicio, /*1*/PeriodoHasta, /*2*/Empresa, /*3*/Centro1Desde, /*4*/Centro1Hasta, /*5*/Centro2Desde, /*6*/Centro2Hasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conArbolAsientosDatos", parametros);

            string[] camposTabla0 = { "Periodo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Total" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            conArbolAsientosDS dsTipado = new conArbolAsientosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Arbol.TableName, dsTipado.Resumen.TableName, dsTipado.Detalle.TableName, dsTipado.PeriodoDetalle.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static conArbolAsientosDS DatosBAL(int /*0*/Ejercicio, short /*1*/PeriodoHasta, int /*2*/Empresa, string /*3*/Centro1Desde, string /*4*/Centro1Hasta, string /*5*/Centro2Desde, string /*6*/Centro2Hasta, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Ejercicio, /*1*/PeriodoHasta, /*2*/Empresa, /*3*/Centro1Desde, /*4*/Centro1Hasta, /*5*/Centro2Desde, /*6*/Centro2Hasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conArbolAsientosSFDatos", parametros);

            string[] camposTabla0 = { "Periodo", "Centro1Desde", "Centro1Hasta", "Centro2Desde", "Centro2Hasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Imputable", "Total" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            conArbolAsientosDS dsTipado = new conArbolAsientosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Arbol.TableName, dsTipado.Resumen.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static conResumenDS DatosResumen(string /*0*/Cuenta_Id, int /*1*/Ejercicio, int /*2*/Periodo, int /*3*/Empresa, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Cuenta_Id, /*1*/Ejercicio, /*2*/Periodo, /*3*/Empresa };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conResumenDatos", parametros);

            string[] camposTabla0 = { "Cuenta_Id", "Ejercicio", "Periodo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Debe", "Haber" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            conResumenDS dsTipado = new conResumenDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Resumen.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static conDetalleDS DatosDetalle(string /*0*/Cuenta_Id, string /*1*/Centro1_Id, string /*2*/Centro2_Id, string /*3*/Formulario_Id, int /*4*/Ejercicio, int /*5*/Periodo, int /*6*/Empresa, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Cuenta_Id, /*1*/Centro1_Id, /*2*/Centro2_Id, /*3*/Formulario_Id, /*4*/Ejercicio, /*5*/Periodo, /*6*/Empresa };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conDetalleDatos", parametros);

            string[] camposTabla0 = { "Cuenta_Id", "Centro1_Id", "Centro2_Id", "Formulario_Id", "Ejercicio", "Periodo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Segmento", "Entidad", "Detalle", "Observaciones", "Debe", "Haber" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            conDetalleDS dsTipado = new conDetalleDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Detalle.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




    }
}
