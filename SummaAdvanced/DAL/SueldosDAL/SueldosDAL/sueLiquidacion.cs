using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class sueLiquidacion
    {
        public static sueLiquidacionDS Datos(string /*0*/pSegmento_Id, int /*1*/pSegmento1N, int /*2*/pSegmento2N, int /*3*/pSegmento3N, int /*4*/pSegmento4N, string /*5*/pSegmento1C, string /*6*/pSegmento2C, string /*7*/pSegmento3C, string /*8*/pSegmento4C, DateTime /*9*/pFechaDesde, DateTime /*10*/pFechaHasta, int /*11*/pEmpresa_Id, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_Id, /*1*/pSegmento1N, /*2*/pSegmento2N, /*3*/pSegmento3N, /*4*/pSegmento4N, /*5*/pSegmento1C, /*6*/pSegmento2C, /*7*/pSegmento3C, /*8*/pSegmento4C, new Generalidades.NullableDate(/*9*/pFechaDesde), new Generalidades.NullableDate(/*10*/pFechaHasta), /*11*/pEmpresa_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("sueLiquidacionDatos", parametros);

            string[] camposTabla0 = { "FechaDeposito", "PeriodoDeposito", "FechaInicial", "FechaFinal", "Periodo_Id", "DescripcionPeriodicidad", "FechaDesde", "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            sueLiquidacionDS dsTipado = new sueLiquidacionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static void Eliminar(long /*0*/psueLiquidacion, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueLiquidacion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueLiquidacionEliminar", parametros);
        }

        public static Int64 Guardar(long /*0*/psueLiquidacion, int /*1*/pGrupo_Id, string /*2*/pDescripcion, DateTime /*3*/pFechaPago, DateTime /*4*/pFechaDeposito, string /*5*/pPeriodoDeposito, string /*6*/pCtaSueldosAPagar, DateTime /*7*/pFechaInicial, DateTime /*8*/pFechaFinal, string /*9*/pPeriodo_Id, bool /*10*/pPorEmpleado, int /*11*/pAnio, int /*12*/pMes, int /*13*/pQuincena, int /*14*/pSemana, int /*15*/pDecena, int /*16*/pVez, DateTime /*17*/pFechaContabilizacion, string /*18*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueLiquidacion, /*1*/pGrupo_Id, /*2*/pDescripcion, /*3*/pFechaPago, new Generalidades.NullableDate(/*4*/pFechaDeposito), new Generalidades.NullableString(/*5*/pPeriodoDeposito), /*6*/pCtaSueldosAPagar, new Generalidades.NullableDate(/*7*/pFechaInicial), new Generalidades.NullableDate(/*8*/pFechaFinal), new Generalidades.NullableString(/*9*/pPeriodo_Id), /*10*/pPorEmpleado, /*11*/pAnio, /*12*/pMes, /*13*/pQuincena, /*14*/pSemana, /*15*/pDecena, /*16*/pVez, new Generalidades.NullableDate(/*17*/pFechaContabilizacion) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((Int64)oiDAAB.guardar("sueLiquidacionGuardar", parametros));
        }


        public static sueLiquidacionGenerarDS DatosGenerar(string /*0*/pSegmento_Id, int /*1*/pSegmento1N, int /*2*/pSegmento2N, int /*3*/pSegmento3N, int /*4*/pSegmento4N, string /*5*/pSegmento1C, string /*6*/pSegmento2C, string /*7*/pSegmento3C, string /*8*/pSegmento4C, int /*9*/pEmpresa_Id, int /*10*/LegajoDesde, int /*11*/LegajoHasta, string /*12*/SucursalDesde, string /*13*/SucursalHasta, string /*14*/TipoLiq, string /*15*/pPeriodo_Id, DateTime /*16*/pFechaDesde, DateTime /*17*/pFechaHasta, string /*18*/pCentro1Desde, string /*19*/pCentro1Hasta, string /*20*/pConvenioDesde, string /*21*/pConvenioHasta, string /*22*/pTipoPagoDesde, string /*23*/pTipoPagoHasta, string /*24*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_Id, /*1*/pSegmento1N, /*2*/pSegmento2N, /*3*/pSegmento3N, /*4*/pSegmento4N, /*5*/pSegmento1C, /*6*/pSegmento2C, /*7*/pSegmento3C, /*8*/pSegmento4C, /*9*/pEmpresa_Id, /*10*/LegajoDesde, /*11*/LegajoHasta, /*12*/SucursalDesde, /*13*/SucursalHasta, /*14*/TipoLiq, new Generalidades.NullableString(/*15*/pPeriodo_Id), /*16*/pFechaDesde, /*17*/pFechaHasta, /*18*/pCentro1Desde, /*19*/pCentro1Hasta, /*20*/pConvenioDesde, /*21*/pConvenioHasta, /*22*/pTipoPagoDesde, /*23*/pTipoPagoHasta };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("sueLiquidacionGenerarDatos", parametros);

            string[] camposTabla0 = { "FechaDeposito", "PeriodoDeposito", "FechaInicial", "FechaFinal", "TodosLosPeriodos", "Periodo_Id", "DescripcionPeriodicidad", "LegajoDesde", "LegajoHasta", "SucursalDesde", "SucursalHasta", "TipoLiq", "DescargarWS", "FechaDesde", "FechaHasta", "Centro1Desde", "Centro1Hasta", "ConvenioDesde", "ConvenioHasta", "TipoPagoDesde", "TipoPagoHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            sueLiquidacionGenerarDS dsTipado = new sueLiquidacionGenerarDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.Empleados.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static sueLiqEmpleadosDS Empleados(string /*0*/pSegmento_Id, int /*1*/pSegmento1N, int /*2*/pSegmento2N, int /*3*/pSegmento3N, int /*4*/pSegmento4N, string /*5*/pSegmento1C, string /*6*/pSegmento2C, string /*7*/pSegmento3C, string /*8*/pSegmento4C, int /*9*/pEmpresa_Id, int /*10*/LegajoDesde, int /*11*/LegajoHasta, string /*12*/SucursalDesde, string /*13*/SucursalHasta, string /*14*/TipoLiq, string /*15*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_Id, /*1*/pSegmento1N, /*2*/pSegmento2N, /*3*/pSegmento3N, /*4*/pSegmento4N, /*5*/pSegmento1C, /*6*/pSegmento2C, /*7*/pSegmento3C, /*8*/pSegmento4C, /*9*/pEmpresa_Id, /*10*/LegajoDesde, /*11*/LegajoHasta, /*12*/SucursalDesde, /*13*/SucursalHasta, /*14*/TipoLiq };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("sueLiqEmpleados", parametros);

            string[] camposTabla0 = { "FechaInicial", "FechaFinal", "Periodo_Id", "DescripcionPeriodicidad", "LegajoDesde", "LegajoHasta", "SucursalDesde", "SucursalHasta", "TipoLiq" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            sueLiqEmpleadosDS dsTipado = new sueLiqEmpleadosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Empleados.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static sueLiqAsientoResDS AsientoRes(long /*0*/sueLiquidacion, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/sueLiquidacion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueLiqAsientoResDatos", parametros);

            string[] camposTabla0 = { "Debe", "Haber" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            sueLiqAsientoResDS dsTipado = new sueLiqAsientoResDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static sueLiquidacionNetoDS Neto(long /*0*/pSueLiquidacion, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSueLiquidacion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueLiquidacionNeto", parametros);

            string[] camposTabla0 = { "Monto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            sueLiquidacionNetoDS dsTipado = new sueLiquidacionNetoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void MarcaPorEmple(long /*0*/pSueLiquidacion, bool /*1*/pPorEmpleado, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSueLiquidacion, /*1*/pPorEmpleado };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueLiquidacionMarcaPorEmple", parametros);
        }

        public static sueLiquidacionDS DatosInt(long /*0*/sueLiquidacion, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/sueLiquidacion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueLiquidacionIntDatos", parametros);

            string[] camposTabla0 = { "FechaDeposito", "PeriodoDeposito", "FechaInicial", "FechaFinal", "Periodo_Id", "DescripcionPeriodicidad" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            sueLiquidacionDS dsTipado = new sueLiquidacionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static sueLiqEmpleadosEliminarDS DatosEliminar(string /*0*/pSegmento_Id, int /*1*/pSegmento1N, int /*2*/pSegmento2N, int /*3*/pSegmento3N, int /*4*/pSegmento4N, string /*5*/pSegmento1C, string /*6*/pSegmento2C, string /*7*/pSegmento3C, string /*8*/pSegmento4C, int /*9*/pEmpresa_Id, int /*10*/LegajoDesde, int /*11*/LegajoHasta, string /*12*/SucursalDesde, string /*13*/SucursalHasta, string /*14*/TipoLiq, string /*15*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_Id, /*1*/pSegmento1N, /*2*/pSegmento2N, /*3*/pSegmento3N, /*4*/pSegmento4N, /*5*/pSegmento1C, /*6*/pSegmento2C, /*7*/pSegmento3C, /*8*/pSegmento4C, /*9*/pEmpresa_Id, /*10*/LegajoDesde, /*11*/LegajoHasta, /*12*/SucursalDesde, /*13*/SucursalHasta, /*14*/TipoLiq };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueLiqEmpleadosEliminarDatos", parametros);

            string[] camposTabla0 = { "FechaInicial", "FechaFinal", "Periodo_Id", "DescripcionPeriodicidad", "LegajoDesde", "LegajoHasta", "SucursalDesde", "SucursalHasta", "TipoLiq" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            sueLiqEmpleadosEliminarDS dsTipado = new sueLiqEmpleadosEliminarDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Empleados.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




    }
}
