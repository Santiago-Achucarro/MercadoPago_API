using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesReversionOP
    {
        public static tesReversionOPDS Datos(int /*0*/Empresa_Id, string /*1*/Segmento_Id, string /*2*/Segmento1C, string /*3*/Segmento2C, string /*4*/Segmento3C, string /*5*/Segmento4C, int /*6*/Segmento1N, int /*7*/Segmento2N, int /*8*/Segmento3N, int /*9*/Segmento4N, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/Segmento_Id, /*2*/Segmento1C, /*3*/Segmento2C, /*4*/Segmento3C, /*5*/Segmento4C, /*6*/Segmento1N, /*7*/Segmento2N, /*8*/Segmento3N, /*9*/Segmento4N };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesReversionOPDatos", parametros);

            string[] camposTabla0 = { "Observaciones", "Cliente_Id", "RazonSocialCliente", "Proveed_Id", "RazonSocialProveedor", "TotalDebe", "TotalHaber", "TotalHabilitado", "ControlaFormulario" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp", "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta", "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id", "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing", "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id", "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal", "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "Provincia_Id", "FPDescripcionPcia", "FPCondFiscal_Id", "FPDescripcionCondFiscal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal", "FPTipoCompFE", "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet", "AcumTot", "FacturaRet", "comMovProv", "SucursalRet", "ComprobanteRet", "TDFormaDePagoP", "TDNumOperacion", "TDCtaOrdenante", "TDRfcEmisorCtaOrd", "TDNomBancoOrdExt", "TDTipoCadPago", "TDCadPago", "TDSelloPago", "TDCertPago", "Diferencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp", "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta", "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id", "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing", "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id", "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal", "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "Provincia_Id", "FPDescripcionPcia", "FPCondFiscal_Id", "FPDescripcionCondFiscal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal", "FPTipoCompFE", "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet", "AcumTot", "FacturaRet", "comMovProv", "SucursalRet", "ComprobanteRet", "TDFormaDePagoP", "TDNumOperacion", "TDCtaOrdenante", "TDRfcEmisorCtaOrd", "TDNomBancoOrdExt", "TDTipoCadPago", "TDCadPago", "TDSelloPago", "TDCertPago", "Diferencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla5 = { "SegmentoSTR", "SaldoOri" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla8 = { "Cambio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

            string[] camposTabla9 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[9], camposTabla9);

            tesReversionOPDS dsTipado = new tesReversionOPDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Debe.TableName, dsTipado.Haber.TableName, dsTipado.ConciliacDebe.TableName, dsTipado.ConciliacHaber.TableName, dsTipado.FactProveedores.TableName, dsTipado.AntProveedores.TableName, dsTipado.Reversa.TableName, dsTipado.TipoCambio.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
