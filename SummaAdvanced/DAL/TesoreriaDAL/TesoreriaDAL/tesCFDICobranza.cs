using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesCFDICobranza
    {
        public static tesCFDICobranzaDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesCFDICobranzaDatos", parametros);

            string[] camposTabla0 = { "RfcProvCertif", "Leyenda" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            tesCFDICobranzaDS dsTipado = new tesCFDICobranzaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static tesCFDICobranzaDS DatosInt(int ptesCFDICobranza, string  pAuxiliar)
        {
            Object[] parametros = new Object[] { ptesCFDICobranza };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesCFDICobranzaDatosInt", parametros);

            string[] camposTabla0 = { "RfcProvCertif", "Leyenda" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            tesCFDICobranzaDS dsTipado = new tesCFDICobranzaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(int /*0*/ptesCFDICobranza, string /*1*/pAnulada, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesCFDICobranza, /*1*/pAnulada };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesCFDICobranzaEliminar", parametros);
        }

        public static void Eliminar(int /*0*/ptesCFDICobranza, string /*1*/pAnulada, string /*2*/pMotivo, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesCFDICobranza, /*1*/pAnulada, /*2*/pMotivo };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesCFDICobranzaEliminar", parametros);
        }




        public static tesXmlComprobantePagoDS DatosXML(int /*0*/TesCFDICobranza, int /*1*/Empresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/TesCFDICobranza, /*1*/Empresa_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("tesXmlComprobantePagoDatos", parametros);

            string[] camposTabla0 = { "TesCFDICobranza", "NoCertificado", "Certificado", "SubTotal", "Descuento", "Moneda", "Total", "TipoCambio", "LugarExpedicion" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "EmpPrivateKey" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Rfc", "ResidenciaFiscal", "Pais", "RegimenFiscalReceptor" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Renglon", "ValorUnitario", "Importe", "Descuento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla4 = { "SelloCFD", "SelloSAT" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            string[] camposTabla5 = { "Comprobante", "FormaDePagoP", "MonedaP", "Monto", "NumOperacion", "RfcEmisorCtaOrd", "NomBancoOrdExt", "CtaOrdenante", "CtaBeneficiario", "TipoCadPago", "CertPago", "CadPago", "SelloPago" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "idDocumento", "MonedaDR", "MetodoPago", "NumParcialidad", "ImpSaldoAnt", "TipoPago" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            string[] camposTabla9 = { "TotalRetencionesIVA", "TotalRetencionesISR", "TotalTrasladosBaseIVA16", "TotalTrasladosImpuestoIVA16", "TotalTrasladosBaseIVA8", "TotalTrasladosImpuestoIVA8", "TotalTrasladosBaseIVA0", "TotalTrasladosImpuestoIVA0", "TotalTrasladosBaseIVAExento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[9], camposTabla9);

            tesXmlComprobantePagoDS dsTipado = new tesXmlComprobantePagoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Emisor.TableName, dsTipado.Receptor.TableName, dsTipado.Concepto.TableName, dsTipado.Complemento.TableName, dsTipado.Pago.TableName, dsTipado.CuerpoPago.TableName, dsTipado.TipoRelacion.TableName, dsTipado.Relacionados.TableName, dsTipado.Totales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static tesTimbradoCobraDS DatosTimbrado(int /*0*/Empresa_Id, DateTime /*1*/FechaDesde, DateTime /*2*/FechaHata, string /*3*/ClienteDesde, string /*4*/ClienteHasta, bool /*5*/UnTimbrePorCob, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/FechaDesde, /*2*/FechaHata, /*3*/ClienteDesde, /*4*/ClienteHasta, /*5*/UnTimbrePorCob };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("tesTimbradoCobraDatos", parametros);

            string[] camposTabla0 = { "FechaDesde", "FechaHasta", "ClienteDesde", "ClienteHasta", "UnTimbrePorCob" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "EnviaAlSat" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Comprobante", "Marca" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            tesTimbradoCobraDS dsTipado = new tesTimbradoCobraDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Generados.TableName, dsTipado.Cuerpo.TableName, dsTipado.Relacionado.TableName, dsTipado.grdGenerados.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static int Guardar(int /*0*/ptesCFDICobranza, string /*1*/pCliente_Id, string /*2*/pMoneda_Id, DateTime /*3*/pFecha, string /*4*/pSelloDigital, string /*5*/pXml, string /*6*/pCadena, string /*7*/pNoCertificado, string /*8*/pUUID, string /*9*/pFechaTimbrado, string /*10*/pSelloSat, string /*11*/pNoCertificadoSat, string /*12*/pRfcProvCertif, string /*13*/pLeyenda, string /*14*/pAnulada, string /*15*/pSucursal, string /*16*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesCFDICobranza, /*1*/pCliente_Id, /*2*/pMoneda_Id, /*3*/pFecha, /*4*/pSelloDigital, /*5*/pXml, /*6*/pCadena, /*7*/pNoCertificado, /*8*/pUUID, /*9*/pFechaTimbrado, /*10*/pSelloSat, /*11*/pNoCertificadoSat, new Generalidades.NullableString(/*12*/pRfcProvCertif), new Generalidades.NullableString(/*13*/pLeyenda), /*14*/pAnulada, /*15*/pSucursal };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("tesCFDICobranzaGuardar", parametros));
        }




        public static tesCdfiCobranzaTieneRelDS TieneRel(long /*0*/tesMovmientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/tesMovmientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesCdfiCobranzaTieneRel", parametros);

            tesCdfiCobranzaTieneRelDS dsTipado = new tesCdfiCobranzaTieneRelDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static tesCFDICobranzaRelacinadoDS DatosRelacionados(long /*0*/ptesCFDICobranza, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesCFDICobranza };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("tesCFDICobranzaRelacinadoDatos", parametros);

            tesCFDICobranzaRelacinadoDS dsTipado = new tesCFDICobranzaRelacinadoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void CancelarSAT(int /*0*/ptesCFDICobranza, string /*1*/pRazonCancelacion, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesCFDICobranza, /*1*/pRazonCancelacion };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesCFDICobranzaCancelarSAT", parametros);
        }



    }
}
