using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using ActivoFijoCommon;

namespace ActivoFijoDAL
{
    public class afiActivoFijo
    {
        public static afiActivoFijoDS Datos(string /*0*/pActivoFijo_Id, int /*1*/pEmpresa, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pActivoFijo_Id, /*1*/pEmpresa };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("afiActivoFijoDatos", parametros);

            string[] camposTabla0 = { "FechaBaja", "Rubro_Id", "DescripcionRubros", "CtaValorOrigen_Id", "DescripcionCuentasOrigen", "CtaAmortAcum_Id", "DescripcionCtaAmortAcum_Id", "CtaAmortizacion", "DescripcionCtaAmortizacion", "Usuario_Id", "DescripcionUsuario", "TieneMovimientos", "AsientoOrigen", "RenglonOrigen" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla2 = { "Responsable_Id", "DescripcionResponsable" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            afiActivoFijoDS dsTipado = new afiActivoFijoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Centros.TableName, dsTipado.Responsables.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.Adjuntos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static int Guardar(string /*0*/pActivoFijo_Id, string /*1*/pActivoFijo_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, DateTime /*4*/pFechaAlta, DateTime /*5*/pFechaIniDepre, DateTime /*6*/pFechaBaja, decimal /*7*/pValorInicial, decimal /*8*/pValorFiscal, int /*9*/pVidaUtil, int /*10*/pVidaUtilRestante, decimal /*11*/pPorResidual, decimal /*12*/pAmortAcumulada, string /*13*/pRubro_Id, decimal /*14*/pCantidad, string /*15*/pCtaValorOrigen_Id, string /*16*/pCtaAmortAcum_Id, string /*17*/pCtaAmortizacion_Id, string /*18*/pTipo, decimal /*19*/pValorInicialSI, decimal /*20*/pAmortAcumSI, int /*21*/pUsuario_Id, string /*22*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pActivoFijo_Id, /*1*/pActivoFijo_Id_Nuevo, /*2*/pEmpresa_Id, new Generalidades.NullableString(/*3*/pDescripcion), /*4*/pFechaAlta, /*5*/pFechaIniDepre, new Generalidades.NullableDate(/*6*/pFechaBaja), /*7*/pValorInicial, /*8*/pValorFiscal, /*9*/pVidaUtil, /*10*/pVidaUtilRestante, /*11*/pPorResidual, /*12*/pAmortAcumulada, new Generalidades.NullableString(/*13*/pRubro_Id), /*14*/pCantidad, new Generalidades.NullableString(/*15*/pCtaValorOrigen_Id), new Generalidades.NullableString(/*16*/pCtaAmortAcum_Id), new Generalidades.NullableString(/*17*/pCtaAmortizacion_Id), /*18*/pTipo, /*19*/pValorInicialSI, /*20*/pAmortAcumSI, new Generalidades.NullableInt(/*21*/pUsuario_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("afiActivoFijoGuardar", parametros);
        }




        public static void Eliminar(string /*0*/pActivoFijo_Id, int pEmpresa_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pActivoFijo_Id, pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("afiActivoFijoEliminar", parametros);
        }

        public static AfiCalcDepreDS CalcDepre(DateTime /*0*/FechaHasta, string /*1*/Tipo, int /*2*/Empresa_id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/FechaHasta, /*1*/Tipo, /*2*/Empresa_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("AfiCalcDepre", parametros);

            string[] camposTabla0 = { "ValorInicial", "AmortAcumulada", "Amortizacion" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            AfiCalcDepreDS dsTipado = new AfiCalcDepreDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void ActuDepAcum(string /*0*/pActivoFijo_Id, int /*1*/pEmpresa_Id, int /*2*/pVidaUtil, decimal /*3*/pAmortAcumulada, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pActivoFijo_Id, /*1*/pEmpresa_Id, /*2*/pVidaUtil, /*3*/pAmortAcumulada };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("afiActivoFijoActuDepAcum", parametros);
        }

        public static afiActivoFijoAmortDS Amortizaciones(DateTime /*0*/pFechaHasta, int /*1*/pEmpresa_Id, string /*2*/pTipo, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFechaHasta, /*1*/pEmpresa_Id, /*2*/pTipo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("afiActivoFijoAmortDatos", parametros);

            string[] camposTabla0 = { "Tipo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            afiActivoFijoAmortDS dsTipado = new afiActivoFijoAmortDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Baja(string /*0*/pActivoFijo_Id, int /*1*/pEmpresa_Id, decimal /*2*/pCantidad, decimal /*3*/pMontoVO, decimal /*4*/pMontoFiscal, decimal /*5*/pMontoDepreciacion, DateTime /*6*/pFechaBaja, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pActivoFijo_Id, /*1*/pEmpresa_Id, /*2*/pCantidad, /*3*/pMontoVO, /*4*/pMontoFiscal, /*5*/pMontoDepreciacion, 
                    /*6*/ new Generalidades.NullableDate(pFechaBaja) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);
            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("AfiActivoFijoBaja", parametros);
        }




        public static AfiFijoCerrarDS DatosCierre(int /*0*/Empresa_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("AfiFijoCerrar", parametros);

            AfiFijoCerrarDS dsTipado = new AfiFijoCerrarDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static afiActivoFijoOtrosDS OtrosDatos(string /*0*/pActivoFijo_Id, int /*1*/pEmpresa, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pActivoFijo_Id, /*1*/pEmpresa };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("afiActivoFijoOtrosDatos", parametros);

            string[] camposTabla0 = { "FechaBaja", "Rubro_Id", "DescripcionRubros", "CtaValorOrigen_Id", "DescripcionCuentasOrigen", "CtaAmortAcum_Id", "DescripcionCtaAmortAcum_Id", "CtaAmortizacion", "DescripcionCtaAmortizacion", "Usuario_Id", "DescripcionUsuario", "TieneMovimientos", "AsientoOrigen", "RenglonOrigen" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla2 = { "Responsable_Id", "DescripcionResponsable" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla5 = { "Comprobante", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            afiActivoFijoOtrosDS dsTipado = new afiActivoFijoOtrosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Centros.TableName, dsTipado.Responsables.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.Adjuntos.TableName, dsTipado.Pendientes.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





        public static afiActivoFijoDS DatosInt(int /*0*/pActivoFijo_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pActivoFijo_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("afiActivoFijoDatosInt", parametros);

            string[] camposTabla0 = { "FechaBaja", "Rubro_Id", "DescripcionRubros", "CtaValorOrigen_Id", "DescripcionCuentasOrigen", "CtaAmortAcum_Id", "DescripcionCtaAmortAcum_Id", "CtaAmortizacion", "DescripcionCtaAmortizacion", "Usuario_Id", "DescripcionUsuario", "TieneMovimientos", "AsientoOrigen", "RenglonOrigen" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            afiActivoFijoDS dsTipado = new afiActivoFijoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Centros.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Desactivar(long /*0*/pconAsientos, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pconAsientos, /*1*/pRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("AfiActivoFijoOtrosDesactivar", parametros);
        }

        public static AfiActivoFijoXLSCatalogoDS DatosXLS(string /*0*/pActivoFijoDesde, string /*1*/pActivoFijoHasta, int Empresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pActivoFijoDesde, /*1*/pActivoFijoHasta, Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("AfiActivoFijoXLSCatalogo", parametros);

            string[] camposTabla0 = { "ActivoFijoDesde", "ActivoFijoHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "FechaBaja", "Rubro_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            AfiActivoFijoXLSCatalogoDS dsTipado = new AfiActivoFijoXLSCatalogoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Activos.TableName, dsTipado.Porcentajes.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

    }
}
