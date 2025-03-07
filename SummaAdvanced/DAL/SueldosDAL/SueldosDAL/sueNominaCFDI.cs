using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SueldosCommon;
using interfaceDAAB;

namespace SueldosDAL
{
    public class sueNominaCFDI
    {

        public static sueNominaCfdiDS Datos(int /*0*/pFolio, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFolio };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueNominaCfdiDatos", parametros);

            string[] camposTabla0 = { "SelloDigital", "Xml", "UUID", "FechaTimbrado", "SelloSat", "noCertificadoSAT", "RfcProvCertif", "Leyenda" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            sueNominaCfdiDS dsTipado = new sueNominaCfdiDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pFolio, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pFolio) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueNominaCfdiCancelar", parametros);
        }

        public static int Guardar(int /*0*/pFolio, long /*1*/psueLiquidacion, int /*2*/pLegajo, string /*3*/pSelloDigital, string /*4*/pXml, string /*5*/pNoCertificado, string /*6*/pUUID, string /*7*/pFechaTimbrado, string /*8*/pSelloSat, string /*9*/pnoCertificadoSAT, string /*10*/pFecha, bool /*11*/pAnulada, string /*12*/pRfcProvCertif, string /*13*/pLeyenda, string /*14*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFolio, /*1*/psueLiquidacion, /*2*/pLegajo, new Generalidades.NullableString(/*3*/pSelloDigital), new Generalidades.NullableString(/*4*/pXml), /*5*/pNoCertificado, new Generalidades.NullableString(/*6*/pUUID), new Generalidades.NullableString(/*7*/pFechaTimbrado), new Generalidades.NullableString(/*8*/pSelloSat), new Generalidades.NullableString(/*9*/pnoCertificadoSAT), /*10*/pFecha, /*11*/pAnulada, new Generalidades.NullableString(/*12*/pRfcProvCertif), new Generalidades.NullableString(/*13*/pLeyenda) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("sueNominaCfdiGuardar", parametros);
        }


        public static sueXmlReciboDS DatosXml(long /*0*/pSueliquidacion, int /*1*/Legajo, string /*2*/pTipoNomina, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSueliquidacion, /*1*/Legajo, /*2*/pTipoNomina };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueXmlReciboDatos", parametros);

            string[] camposTabla0 = { "Folio", "Fecha", "NoCertificado", "Certificado", "SubTotal", "Descuento", "Moneda", "Total", "LugarExpedicion" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla2 = { "UUID" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "EmpPrivateKey", "Provincia", "Pais", "CodLocalidad", "CodColonia", "CodMunicipio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla4 = { "ResidenciaFiscal", "Pais" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            string[] camposTabla5 = { "ValorUnitario", "Descuento", "Importe" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "TipoNomina", "FechaInicial", "FechaFinal", "NumDiasPagado", "TotalPercepciones", "TotalDeducciones", "TotalOtros" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            string[] camposTabla7 = { "RegPatronal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            string[] camposTabla9 = { "Antig", "PeriodicidadPago" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[9], camposTabla9);

            string[] camposTabla10 = { "TotalSueldos", "TotalSeparacionIndemnizacion", "TotalJubilacionPensionRetiro", "TotalGravado", "TotalExento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[10], camposTabla10);

            string[] camposTabla11 = { "TipoPercepcion", "ImporteGravado", "ImporteExento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[11], camposTabla11);

            string[] camposTabla12 = { "TipoHoras" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[12], camposTabla12);

            string[] camposTabla15 = { "TotalOtrasDeducciones", "TotalImpuestosRetenidos" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[15], camposTabla15);

            string[] camposTabla16 = { "TipoDeduccion", "Importe" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[16], camposTabla16);

            string[] camposTabla17 = { "TipoIncapacidad", "ImporteMonetario" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[17], camposTabla17);

            string[] camposTabla18 = { "TotalOtros" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[18], camposTabla18);

            string[] camposTabla19 = { "TipoOtroPago", "Importe" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[19], camposTabla19);

            string[] camposTabla20 = { "SubsidioCausado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[20], camposTabla20);

            string[] camposTabla21 = { "AnioRetro", "RemanenteSalFav" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[21], camposTabla21);

            sueXmlReciboDS dsTipado = new sueXmlReciboDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.TipoRelacion.TableName, dsTipado.TipoRelaciones.TableName, dsTipado.Emisor.TableName, dsTipado.Receptor.TableName, dsTipado.Concepto.TableName, dsTipado.Complemento.TableName, dsTipado.comEmisor.TableName, dsTipado.comRecursos.TableName, dsTipado.comReceptor.TableName, dsTipado.comPercepciones.TableName, dsTipado.comPercepcion.TableName, dsTipado.comHorasExtra.TableName, dsTipado.comJubilacionRet.TableName, dsTipado.comSeparacion.TableName, dsTipado.comDeducciones.TableName, dsTipado.comDeduccion.TableName, dsTipado.comInacpacidad.TableName, dsTipado.comOtros.TableName, dsTipado.comOtro.TableName, dsTipado.comSubsidio.TableName, dsTipado.comSaldoFavor.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static sueNominasQueEmpleadosDS QueEmpleados(long /*0*/sueLiquidacion, int /*1*/LegajoDesde, int /*2*/LegajoHasta, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/sueLiquidacion, /*1*/LegajoDesde, /*2*/LegajoHasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueNominasQueEmpleadosDatos", parametros);

            sueNominasQueEmpleadosDS dsTipado = new sueNominasQueEmpleadosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static sueNominasQueEmpleadosDescargarDS DescargarDatos(long /*0*/sueLiquidacion, int /*1*/LegajoDesde, int /*2*/LegajoHasta, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/sueLiquidacion, /*1*/LegajoDesde, /*2*/LegajoHasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueNominasQueEmpleadosDescargarDatos", parametros);

            sueNominasQueEmpleadosDescargarDS dsTipado = new sueNominasQueEmpleadosDescargarDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static sueNominasQueEmpleadosCancelarSATDS QueEmpleadosCancelar(long /*0*/sueLiquidacion, int /*1*/LegajoDesde, int /*2*/LegajoHasta, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/sueLiquidacion, /*1*/LegajoDesde, /*2*/LegajoHasta };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("sueNominasQueEmpleadosCancelarSAT", parametros);

            sueNominasQueEmpleadosCancelarSATDS dsTipado = new sueNominasQueEmpleadosCancelarSATDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void CancelarSAT(int /*0*/pFolio, string /*1*/pRazonCancelacion, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFolio, /*1*/pRazonCancelacion };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueNominaCfdiCancelarSAT", parametros);
        }


        public static sueNominaCfdiRelacinadoDS RelacionadosDatos(long /*0*/sueLiquidacion, int /*1*/Legajo, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/sueLiquidacion, /*1*/Legajo };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("sueNominaCfdiRelacinadoDatos", parametros);

            sueNominaCfdiRelacinadoDS dsTipado = new sueNominaCfdiRelacinadoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





    }
}
