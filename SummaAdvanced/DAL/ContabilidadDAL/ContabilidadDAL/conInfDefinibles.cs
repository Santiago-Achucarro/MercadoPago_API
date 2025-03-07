using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using ContabilidadCommon;


namespace ContabilidadDAL
{
    public class conInfDefinibles
    {
        public static conInfDefiniblesDS Datos(string /*0*/pInforme_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pInforme_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conInfDefiniblesDatos", parametros);

            string[] camposTabla0 = { "Usuario_Id", "DescripcionUsuario", "Empresa_Id", "PTodasEmpresas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            conInfDefiniblesDS dsTipado = new conInfDefiniblesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Filas.TableName, dsTipado.Cuentas.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(string /*0*/pInforme_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pInforme_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conInfDefiniblesEliminar", parametros);
        }

        public static int Guardar(string /*0*/pInforme_Id, string /*1*/pInforme_Id_Nuevo, string /*2*/pDescripcion, int /*3*/pUsuario_Id, int /*4*/pEmpresa_Id, bool /*5*/pInactivo, bool /*6*/pPosteado, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pInforme_Id, /*1*/pInforme_Id_Nuevo, /*2*/pDescripcion, /*3*/pUsuario_Id, new Generalidades.NullableInt(/*4*/pEmpresa_Id), /*5*/pInactivo, /*6*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("conInfDefiniblesGuardar", parametros);
        }


        public static conInfDefiniblesMenGenerarDS DatosMen(string /*0*/Informe_Id, int /*1*/Ejercicio, int /*2*/PeriodoHasta, string /*3*/Centro1Desde, string /*4*/Centro1Hasta, string /*5*/Centro2Desde, string /*6*/Centro2Hasta, int /*7*/Empresa_Id, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Informe_Id, /*1*/Ejercicio, /*2*/PeriodoHasta, /*3*/Centro1Desde, /*4*/Centro1Hasta, /*5*/Centro2Desde, /*6*/Centro2Hasta, /*7*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conInfDefiniblesMenGenerar", parametros);

            string[] camposTabla1 = { "Per01", "Per02", "Per03", "Per04", "Per05", "Per06", "Per07", "Per08", "Per09", "Per10", "Per11", "Per12", "FechaHasta", "Ejercicio", "PeriodoHasta", "Centro1Desde", "Centro1Hasta", "Centro2Desde", "Centro2Hasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Telefono", "Usuario_Id", "logo", "CarpetaEspecial", "CtaMercaEnTransitoImpor", "CodLocalidad", "CodColonia", "CodMunicipio", "CondFiscal", "PaginaWeb", "Dominio_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            conInfDefiniblesMenGenerarDS dsTipado = new conInfDefiniblesMenGenerarDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cabecera.TableName, dsTipado.Empresas.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static conInfDefiniblesAcuGenerarDS DatosMesAnt(string /*0*/Informe_Id, int /*1*/Ejercicio, int /*2*/PeriodoHasta, string /*3*/Centro1Desde, string /*4*/Centro1Hasta, string /*5*/Centro2Desde, string /*6*/Centro2Hasta, int /*7*/Empresa_Id, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Informe_Id, /*1*/Ejercicio, /*2*/PeriodoHasta, /*3*/Centro1Desde, /*4*/Centro1Hasta, /*5*/Centro2Desde, /*6*/Centro2Hasta, /*7*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conInfDefiniblesAcuGenerar", parametros);

            string[] camposTabla1 = { "Periodo", "PeriodoAnt", "FechaHasta", "Ejercicio", "PeriodoHasta", "Centro1Desde", "Centro1Hasta", "Centro2Desde", "Centro2Hasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            conInfDefiniblesAcuGenerarDS dsTipado = new conInfDefiniblesAcuGenerarDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cabecera.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static conInfDefiniblesAcu1GenerarDS DatosAnioAnt(string /*0*/Informe_Id, int /*1*/Ejercicio, int /*2*/PeriodoHasta, string /*3*/Centro1Desde, string /*4*/Centro1Hasta, string /*5*/Centro2Desde, string /*6*/Centro2Hasta, int /*7*/Empresa_Id, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Informe_Id, /*1*/Ejercicio, /*2*/PeriodoHasta, /*3*/Centro1Desde, /*4*/Centro1Hasta, /*5*/Centro2Desde, /*6*/Centro2Hasta, /*7*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conInfDefiniblesAcu1Generar", parametros);

            string[] camposTabla1 = { "Periodo", "PeriodoAnt", "FechaHasta", "Ejercicio", "PeriodoHasta", "Centro1Desde", "Centro1Hasta", "Centro2Desde", "Centro2Hasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            conInfDefiniblesAcu1GenerarDS dsTipado = new conInfDefiniblesAcu1GenerarDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cabecera.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }








    }
}
