using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using TesoreriaCommon;
using System.Data;
namespace TesoreriaDAL
{
    public class tesPagosClie
    {
        public static tesMovimientosDatosBaseDS Datos(int /*0*/Empresa_Id, string /*1*/Segmento_Id, int /*2*/Segmento1N, int /*3*/Segmento2N, int /*4*/Segmento3N, int /*5*/Segmento4N, string /*6*/Segmento1C, string /*7*/Segmento2C, string /*8*/Segmento3C, string /*9*/Segmento4C, string /*10*/pCliente_id, string /*11*/pMoneda_Id, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/Segmento_Id, /*2*/Segmento1N, /*3*/Segmento2N, /*4*/Segmento3N, /*5*/Segmento4N, /*6*/Segmento1C, /*7*/Segmento2C, /*8*/Segmento3C, /*9*/Segmento4C, new Generalidades.NullableString(/*10*/pCliente_id), new Generalidades.NullableString(/*11*/pMoneda_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesPagosClieDatos", parametros);

            string[] camposTabla0 = { "Observaciones", "Cliente_Id", "RazonSocialCliente", "Proveed_Id", "RazonSocialProveedor", "TotalDebe", "TotalHaber", "TotalHabilitado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp", "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta", "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id", "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing", "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id", "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal", "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "Provincia_Id", "FPDescripcionPcia", "FPCondFiscal_Id", "FPDescripcionCondFiscal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal", "FPTipoCompFE", "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet", "AcumTot", "FacturaRet", "comMovProv", "SucursalRet", "ComprobanteRet", "TDFormaDePagoP", "TDNumOperacion", "TDCtaOrdenante", "TDRfcEmisorCtaOrd", "TDNomBancoOrdExt", "TDTipoCadPago", "TDCadPago", "TDSelloPago", "TDCertPago", "Diferencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp", "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta", "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id", "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing", "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id", "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal", "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "Provincia_Id", "FPDescripcionPcia", "FPCondFiscal_Id", "FPDescripcionCondFiscal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal", "FPTipoCompFE", "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet", "AcumTot", "FacturaRet", "comMovProv", "SucursalRet", "ComprobanteRet", "TDFormaDePagoP", "TDNumOperacion", "TDCtaOrdenante", "TDRfcEmisorCtaOrd", "TDNomBancoOrdExt", "TDTipoCadPago", "TDCadPago", "TDSelloPago", "TDCertPago", "Diferencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla5 = { "SegmentoSTR", "SaldoOri" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "Cambio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            string[] camposTabla7 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            tesMovimientosDatosBaseDS dsTipado = new tesMovimientosDatosBaseDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Debe.TableName, dsTipado.Haber.TableName, dsTipado.ConciliacDebe.TableName, dsTipado.ConciliacHaber.TableName, dsTipado.FactClientes.TableName, dsTipado.TiposCambio.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static tesMovimientosDatosBaseDS DatosPendiente(int /*0*/Empresa_Id, string /*1*/pCliente_id, string /*2*/pMoneda_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/pCliente_id, /*2*/pMoneda_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesPagosClieDatosPendientes", parametros);

            string[] camposTabla0 = { "Observaciones", "Cliente_Id", "RazonSocialCliente", "Proveed_Id", "RazonSocialProveedor", "TotalDebe", "TotalHaber", "TotalHabilitado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp", "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta", "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id", "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing", "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id", "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal", "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "Provincia_Id", "FPDescripcionPcia", "FPCondFiscal_Id", "FPDescripcionCondFiscal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal", "FPTipoCompFE", "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet", "AcumTot", "FacturaRet", "comMovProv", "SucursalRet", "ComprobanteRet", "TDFormaDePagoP", "TDNumOperacion", "TDCtaOrdenante", "TDRfcEmisorCtaOrd", "TDNomBancoOrdExt", "TDTipoCadPago", "TDCadPago", "TDSelloPago", "TDCertPago", "Diferencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp", "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta", "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id", "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing", "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id", "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal", "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "Provincia_Id", "FPDescripcionPcia", "FPCondFiscal_Id", "FPDescripcionCondFiscal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal", "FPTipoCompFE", "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet", "AcumTot", "FacturaRet", "comMovProv", "SucursalRet", "ComprobanteRet", "TDFormaDePagoP", "TDNumOperacion", "TDCtaOrdenante", "TDRfcEmisorCtaOrd", "TDNomBancoOrdExt", "TDTipoCadPago", "TDCadPago", "TDSelloPago", "TDCertPago", "Diferencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla5 = { "SegmentoSTR", "SaldoOri", "MontoACobrar", "CambioCobra" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "Cambio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            string[] camposTabla7 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            tesMovimientosDatosBaseDS dsTipado = new tesMovimientosDatosBaseDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Debe.TableName, dsTipado.Haber.TableName, dsTipado.ConciliacDebe.TableName, dsTipado.ConciliacHaber.TableName, dsTipado.FactClientes.TableName, dsTipado.TiposCambio.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



    }
}
