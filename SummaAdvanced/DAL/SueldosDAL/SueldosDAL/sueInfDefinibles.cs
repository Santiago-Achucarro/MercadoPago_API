using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;


namespace SueldosDAL
{
    public class sueInfDefinibles
    {
        public static sueInfDefiniblesDS Datos(string /*0*/pInforme_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pInforme_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueInfDefiniblesDatos", parametros);

            string[] camposTabla0 = { "TamanioHoja", "DescripcionTamanioHoja", "Empresa_Id", "PTodasEmpresas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            sueInfDefiniblesDS dsTipado = new sueInfDefiniblesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Formulas.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(string /*0*/pInforme_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pInforme_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueInfDefiniblesEliminar", parametros);
        }

        public static int Guardar(string /*0*/pInforme_Id, string /*1*/pInforme_Id_Nuevo, string /*2*/pDescripcion, string /*3*/pAgrupadoPor, string /*4*/pTamanioHoja, bool /*5*/pHorizontal, string /*6*/pUm, int /*7*/pLegajoDesde, int /*8*/pLegajoHasta, string /*9*/pSucursalDesde, string /*10*/pSucursaHasta, string /*11*/pConvenioDesde, string /*12*/pConvenioHasta, decimal /*13*/pAnchoNombre, string /*14*/pCentro1Desde, string /*15*/pCentro1Hasta, string /*16*/pCentro2Desde, string /*17*/pCentro2Hasta, int /*18*/pUsuario_Id, int /*19*/pEmpresa_Id, bool /*20*/pInactivo, bool /*21*/pPosteado, string /*22*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pInforme_Id, /*1*/pInforme_Id_Nuevo, /*2*/pDescripcion, /*3*/pAgrupadoPor, new Generalidades.NullableString(/*4*/pTamanioHoja), /*5*/pHorizontal, /*6*/pUm, /*7*/pLegajoDesde, /*8*/pLegajoHasta, /*9*/pSucursalDesde, /*10*/pSucursaHasta, /*11*/pConvenioDesde, /*12*/pConvenioHasta, /*13*/pAnchoNombre, /*14*/pCentro1Desde, /*15*/pCentro1Hasta, /*16*/pCentro2Desde, /*17*/pCentro2Hasta, /*18*/pUsuario_Id, new Generalidades.NullableInt(/*19*/pEmpresa_Id), /*20*/pInactivo, /*21*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("sueInfDefiniblesGuardar", parametros));
        }
        public static sueInfDefiniblesImpresionDS DatosImpresion(string /*0*/pInforme_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pInforme_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("sueInfDefiniblesImpresionDatos", parametros);

            string[] camposTabla0 = { "FechaDesde", "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            sueInfDefiniblesImpresionDS dsTipado = new sueInfDefiniblesImpresionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static sueInfDefEmpleadosDS DatosEmpleados(int /*0*/Anio, int /*1*/Mes, int /*2*/Quincena, int /*3*/Vez, int /*4*/Semana, int /*5*/Decena, string /*6*/GeneraBy, DateTime /*7*/FechaDesde, DateTime /*8*/FechaHasta, int /*9*/LegajoDesde, int /*10*/LegajoHasta, string /*11*/SucursalDesde, string /*12*/SucursalHasta, string /*13*/ConvenioDesde, string /*14*/ConvenioHasta, string /*15*/Centro1Desde, string /*16*/Centro1Hasta, string /*17*/Centro2Desde, string /*18*/Centro2Hasta, int /*19*/Empresa_Id, string /*20*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Anio, /*1*/Mes, /*2*/Quincena, /*3*/Vez, /*4*/Semana, /*5*/Decena, /*6*/GeneraBy, /*7*/FechaDesde, /*8*/FechaHasta, /*9*/LegajoDesde, /*10*/LegajoHasta, /*11*/SucursalDesde, /*12*/SucursalHasta, /*13*/ConvenioDesde, /*14*/ConvenioHasta, /*15*/Centro1Desde, /*16*/Centro1Hasta, /*17*/Centro2Desde, /*18*/Centro2Hasta, /*19*/Empresa_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("sueInfDefEmpleadosDatos", parametros);

            sueInfDefEmpleadosDS dsTipado = new sueInfDefEmpleadosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
