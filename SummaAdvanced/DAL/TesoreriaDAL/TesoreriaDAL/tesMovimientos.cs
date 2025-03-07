using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesMovimientos
    {
        public static tesMovimientosDatosBaseDS Datos(int /*0*/Empresa_Id, string /*1*/Segmento_Id, int /*2*/Segmento1N, int /*3*/Segmento2N, int /*4*/Segmento3N, int /*5*/Segmento4N, string /*6*/Segmento1C, string /*7*/Segmento2C, string /*8*/Segmento3C, string /*9*/Segmento4C, string /*10*/pCliente_id, string /*11*/pMoneda_Id, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/Segmento_Id, /*2*/Segmento1N, /*3*/Segmento2N, /*4*/Segmento3N, /*5*/Segmento4N, /*6*/Segmento1C, /*7*/Segmento2C, /*8*/Segmento3C, /*9*/Segmento4C, new Generalidades.NullableString(/*10*/pCliente_id), new Generalidades.NullableString(/*11*/pMoneda_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesCreditosBancariosDatos", parametros);

            string[] camposTabla0 = { "Observaciones", "Cliente_Id", "RazonSocialCliente", "Proveed_Id", "RazonSocialProveedor", "TotalDebe", "TotalHaber", "TotalHabilitado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp", "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta", "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id", "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing", "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id", "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal", "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "Provincia_Id", "FPDescripcionPcia", "FPCondFiscal_Id", "FPDescripcionCondFiscal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal", "FPTipoCompFE", "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet", "AcumTot", "FacturaRet", "comMovProv", "SucursalRet", "ComprobanteRet", "TDFormaDePagoP", "TDNumOperacion", "TDCtaOrdenante", "TDRfcEmisorCtaOrd", "TDNomBancoOrdExt", "TDTipoCadPago", "TDCadPago", "TDSelloPago", "TDCertPago", "Diferencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp", "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta", "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id", "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing", "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id", "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal", "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "Provincia_Id", "FPDescripcionPcia", "FPCondFiscal_Id", "FPDescripcionCondFiscal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal", "FPTipoCompFE", "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet", "AcumTot", "FacturaRet", "comMovProv", "SucursalRet", "ComprobanteRet", "TDFormaDePagoP", "TDNumOperacion", "TDCtaOrdenante", "TDRfcEmisorCtaOrd", "TDNomBancoOrdExt", "TDTipoCadPago", "TDCadPago", "TDSelloPago", "TDCertPago", "Diferencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla5 = { "Cambio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            string[] camposTabla7 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            tesMovimientosDatosBaseDS dsTipado = new tesMovimientosDatosBaseDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Debe.TableName, 
                dsTipado.Haber.TableName, dsTipado.ConciliacDebe.TableName, 
                dsTipado.ConciliacHaber.TableName, dsTipado.TiposCambio.TableName, 
                dsTipado.CarteraUnica.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static tesMovimientosDatosBaseDS DatosDebitos(int /*0*/Empresa_Id, string /*1*/Segmento_Id, int /*2*/Segmento1N, int /*3*/Segmento2N, int /*4*/Segmento3N, int /*5*/Segmento4N, string /*6*/Segmento1C, string /*7*/Segmento2C, string /*8*/Segmento3C, string /*9*/Segmento4C, string /*10*/pCliente_id, string /*11*/pMoneda_Id, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/Segmento_Id, /*2*/Segmento1N, /*3*/Segmento2N, /*4*/Segmento3N, /*5*/Segmento4N, /*6*/Segmento1C, /*7*/Segmento2C, /*8*/Segmento3C, /*9*/Segmento4C, new Generalidades.NullableString(/*10*/pCliente_id), new Generalidades.NullableString(/*11*/pMoneda_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesDebitosBancariosDatos", parametros);

            string[] camposTabla0 = { "Observaciones", "Cliente_Id", "RazonSocialCliente", "Proveed_Id", "RazonSocialProveedor", "TotalDebe", "TotalHaber", "TotalHabilitado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp", "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta", "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id", "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing", "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id", "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal", "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "Provincia_Id", "FPDescripcionPcia", "FPCondFiscal_Id", "FPDescripcionCondFiscal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal", "FPTipoCompFE", "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet", "AcumTot", "FacturaRet", "comMovProv", "SucursalRet", "ComprobanteRet", "TDFormaDePagoP", "TDNumOperacion", "TDCtaOrdenante", "TDRfcEmisorCtaOrd", "TDNomBancoOrdExt", "TDTipoCadPago", "TDCadPago", "TDSelloPago", "TDCertPago", "Diferencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp", "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta", "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id", "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing", "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id", "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal", "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "Provincia_Id", "FPDescripcionPcia", "FPCondFiscal_Id", "FPDescripcionCondFiscal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal", "FPTipoCompFE", "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet", "AcumTot", "FacturaRet", "comMovProv", "SucursalRet", "ComprobanteRet", "TDFormaDePagoP", "TDNumOperacion", "TDCtaOrdenante", "TDRfcEmisorCtaOrd", "TDNomBancoOrdExt", "TDTipoCadPago", "TDCadPago", "TDSelloPago", "TDCertPago", "Diferencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla5 = { "Cambio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            string[] camposTabla7 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            tesMovimientosDatosBaseDS dsTipado = new tesMovimientosDatosBaseDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Debe.TableName, dsTipado.Haber.TableName, dsTipado.ConciliacDebe.TableName, dsTipado.ConciliacHaber.TableName, dsTipado.TiposCambio.TableName, dsTipado.CarteraUnica.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static tesMovimientosDatosBaseDS Datos(int /*0*/Empresa_Id, string /*1*/Segmento_Id, string /*2*/Segmento1C, string /*3*/Segmento2C, string /*4*/Segmento3C, string /*5*/Segmento4C, int /*6*/Segmento1N, int /*7*/Segmento2N, int /*8*/Segmento3N, int /*9*/Segmento4N, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/Segmento_Id, /*2*/Segmento1C, /*3*/Segmento2C, /*4*/Segmento3C, /*5*/Segmento4C, /*6*/Segmento1N, /*7*/Segmento2N, /*8*/Segmento3N, /*9*/Segmento4N };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("tesMovimientosDatosBase", parametros);

            string[] camposTabla0 = { "Observaciones", "Cliente_Id", "RazonSocialCliente", "Proveed_Id", "RazonSocialProveedor", "TotalDebe", "TotalHaber", "TotalHabilitado", "ControlaFormulario", "Diferencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ImporteOrig", "Importe", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp", "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta", "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id", "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing", "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id", "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal", "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal", "FPTipoCompFE", "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet", "AcumTot", "FacturaRet", "comMovProv", "SucursalRet", "ComprobanteRet", "TDFormaDePagoP", "TDNumOperacion", "TDCtaOrdenante", "TDRfcEmisorCtaOrd", "TDNomBancoOrdExt", "TDTipoCadPago", "TDCadPago", "TDSelloPago", "TDCertPago", "Diferencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "ImporteOrig", "Importe", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp", "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta", "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id", "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing", "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id", "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal", "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal", "FPTipoCompFE", "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet", "AcumTot", "FacturaRet", "comMovProv", "SucursalRet", "ComprobanteRet", "TDFormaDePagoP", "TDNumOperacion", "TDCtaOrdenante", "TDRfcEmisorCtaOrd", "TDNomBancoOrdExt", "TDTipoCadPago", "TDCadPago", "TDSelloPago", "TDCertPago", "Diferencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla5 = { "Marca", "DescripcionBanco", "Cliente_Id", "RazonSocial" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Base_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            string[] camposTabla7 = { "CtaDebe", "DescripcionCuentaDebe", "CtaHaber", "DescripcionCuentaHaber", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            string[] camposTabla8 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Base_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

            string[] camposTabla9 = { "CtaDebe", "DescripcionCuentaDebe", "CtaHaber", "DescripcionCuentaHaber", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[9], camposTabla9);

            string[] camposTabla10 = { "SegmentoSTR", "SaldoOri", "NMetodoPago" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[10], camposTabla10);

            string[] camposTabla12 = { "SegmentoSTR" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[12], camposTabla12);

            string[] camposTabla14 = { "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[14], camposTabla14);

            string[] camposTabla15 = { "Monto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[15], camposTabla15);

            string[] camposTabla16 = { "Cambio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[16], camposTabla16);

            string[] camposTabla17 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[17], camposTabla17);

            string[] camposTabla18 = { "FechaHasta", "FechaDesde", "Marca" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[18], camposTabla18);

            string[] camposTabla19 = { "Marca", "DescripcionBanco", "Cliente_Id", "RazonSocial" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[19], camposTabla19);

            string[] camposTabla20 = { "SegmentoSTR" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[20], camposTabla20);

            string[] camposTabla21 = { "SegmentoSTR" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[21], camposTabla21);

            string[] camposTabla24 = { "ReqCompPago" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[24], camposTabla24);

            string[] camposTabla25 = { "tesMovimientos", "conRenglon" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[25], camposTabla25);

            string[] camposTabla27 = { "tesMovimientos", "BaseImponible", "Importe" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[27], camposTabla27);

            tesMovimientosDatosBaseDS dsTipado = new tesMovimientosDatosBaseDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Debe.TableName, dsTipado.Haber.TableName, dsTipado.ConciliacDebe.TableName, dsTipado.ConciliacHaber.TableName, dsTipado.CheqTercerosHaber.TableName, dsTipado.FactAneCuerpoDebe.TableName, dsTipado.FactAneImpuestoDebe.TableName, dsTipado.FactAneCuerpoHaber.TableName, dsTipado.FactAneImpuestoHaber.TableName, dsTipado.FactClientes.TableName, dsTipado.AntClientes.TableName, dsTipado.FactProveedores.TableName, dsTipado.AntProveedores.TableName, dsTipado.CarteraUnica.TableName, dsTipado.Reversa.TableName, dsTipado.TiposCambio.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.CarteraUnicaContra.TableName, dsTipado.CheqTercerosDebe.TableName, dsTipado.RengMoviRetProvDebe.TableName, dsTipado.RengMoviRetProvHaber.TableName, dsTipado.MoviGravadoDebe.TableName, dsTipado.MoviGravadoHaber.TableName, dsTipado.ReqCompPago.TableName, dsTipado.Adjuntos.TableName, dsTipado.SegmentoContrap.TableName, dsTipado.Impuestos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(long /*0*/ptesMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesMovimientosEliminar", parametros);
        }

        public static void Guardar(long /*0*/ptesMovimientos, string /*1*/pSubTipo_Id, DateTime /*2*/pFecha_Real, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, /*1*/pSubTipo_Id, /*2*/pFecha_Real };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesMovimientosGuardar", parametros);
        }

        public static tesMovimientosDatosBaseDS CobranzasDatos(int /*0*/Empresa_Id, string /*1*/Segmento_Id, int /*2*/Segmento1N,
            int /*3*/Segmento2N, int /*4*/Segmento3N, int /*5*/Segmento4N, string /*6*/Segmento1C, string /*7*/Segmento2C,
            string /*8*/Segmento3C, string /*9*/Segmento4C, string /*10*/pCliente_id, string /*11*/pMoneda_Id, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/Segmento_Id, /*2*/Segmento1N, /*3*/Segmento2N, /*4*/Segmento3N, 
                /*5*/Segmento4N, /*6*/Segmento1C, /*7*/Segmento2C, /*8*/Segmento3C, /*9*/Segmento4C,
                new Generalidades.NullableString(/*10*/pCliente_id), new Generalidades.NullableString(/*11*/pMoneda_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesCobranzasDatos", parametros);

            string[] camposTabla0 = { "Observaciones", "Cliente_Id", "RazonSocialCliente", "Proveed_Id", "RazonSocialProveedor",
                "TotalDebe", "TotalHaber", "TotalHabilitado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp",
                "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta",
                "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id",
                "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing",
                "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id",
                "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal",
                "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "Provincia_Id", "FPDescripcionPcia",
                "FPCondFiscal_Id", "FPDescripcionCondFiscal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal",
                "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N",
                "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet",
                "AcumTot", "FacturaRet" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp",
                "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta",
                "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id",
                "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing",
                "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id",
                "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal",
                "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "Provincia_Id", "FPDescripcionPcia",
                "FPCondFiscal_Id", "FPDescripcionCondFiscal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal",
                "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N",
                "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet",
                "AcumTot", "FacturaRet" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla5 = { "SegmentoSTR", "SaldoOri", "MontoACobrar", "CambioCobra", "NMetodoPago" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla7 = { "Cambio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            string[] camposTabla8 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

            tesMovimientosDatosBaseDS dsTipado = new tesMovimientosDatosBaseDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Debe.TableName, dsTipado.Haber.TableName,
                dsTipado.ConciliacDebe.TableName, dsTipado.ConciliacHaber.TableName, dsTipado.FactClientes.TableName,
                dsTipado.AntClientes.TableName, dsTipado.TiposCambio.TableName, dsTipado.genAtributosGenerales.TableName,
                dsTipado.ReqCompPago.TableName};
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static tesMovimientosDatosBaseDS CobranzasDatosPendientes(int /*0*/Empresa_Id,  string /*10*/pCliente_Id,
            string /*11*/pMoneda_Id, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*10*/pCliente_Id, pMoneda_Id };

            //Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesCobranzasDatosPendientes", parametros);

            string[] camposTabla0 = { "Observaciones", "Cliente_Id", "RazonSocialCliente", "Proveed_Id", "RazonSocialProveedor",
                "TotalDebe", "TotalHaber", "TotalHabilitado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp",
                "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta",
                "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id",
                "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing",
                "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id",
                "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal",
                "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "Provincia_Id", "FPDescripcionPcia",
                "FPCondFiscal_Id", "FPDescripcionCondFiscal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal",
                "FPTipoCompFE",
                "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N",
                "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet",
                "AcumTot", "FacturaRet" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp",
                "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta",
                "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id",
                "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing",
                "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id",
                "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal",
                "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "Provincia_Id", "FPDescripcionPcia",
                "FPCondFiscal_Id", "FPDescripcionCondFiscal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal",
                "FPTipoCompFE",
                "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N",
                "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet",
                "AcumTot", "FacturaRet" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla5 = { "SegmentoSTR", "SaldoOri", "MontoACobrar", "CambioCobra", "NMetodoPago" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla7 = { "Cambio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            string[] camposTabla8 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

            tesMovimientosDatosBaseDS dsTipado = new tesMovimientosDatosBaseDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Debe.TableName, dsTipado.Haber.TableName,
                dsTipado.ConciliacDebe.TableName, dsTipado.ConciliacHaber.TableName, dsTipado.FactClientes.TableName,
                dsTipado.AntClientes.TableName, dsTipado.TiposCambio.TableName, dsTipado.genAtributosGenerales.TableName,
                dsTipado.ReqCompPago.TableName};
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static tesMovimientosDatosBaseDS PagosProvDatos(int /*0*/Empresa_Id, string /*1*/Segmento_Id, int /*2*/Segmento1N, 
            int /*3*/Segmento2N, int /*4*/Segmento3N, int /*5*/Segmento4N, string /*6*/Segmento1C, string /*7*/Segmento2C, 
            string /*8*/Segmento3C, string /*9*/Segmento4C, string /*10*/pProveed_Id, string pMoneda_Id, string /*11*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/Segmento_Id, /*2*/Segmento1N, /*3*/Segmento2N, /*4*/Segmento3N,
                /*5*/Segmento4N, /*6*/Segmento1C, /*7*/Segmento2C, /*8*/Segmento3C, /*9*/Segmento4C,
                new Generalidades.NullableString(/*10*/pProveed_Id), new Generalidades.NullableString(/*10*/pMoneda_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesPagosProvDatos", parametros);

            string[] camposTabla0 = { "Observaciones", "Cliente_Id", "RazonSocialCliente", "Proveed_Id", "RazonSocialProveedor",
                "TotalDebe", "TotalHaber", "TotalHabilitado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp", "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta", "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id", "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing", "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id", "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal", "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "Provincia_Id", "FPDescripcionPcia", "FPCondFiscal_Id", "FPDescripcionCondFiscal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal", "FPTipoCompFE", "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet", "AcumTot", "FacturaRet", "comMovProv", "SucursalRet", "ComprobanteRet", "TDFormaDePagoP", "TDNumOperacion", "TDCtaOrdenante", "TDRfcEmisorCtaOrd", "TDNomBancoOrdExt", "TDTipoCadPago", "TDCadPago", "TDSelloPago", "TDCertPago", "Diferencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp", "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta", "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id", "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing", "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id", "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal", "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "Provincia_Id", "FPDescripcionPcia", "FPCondFiscal_Id", "FPDescripcionCondFiscal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal", "FPTipoCompFE", "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet", "AcumTot", "FacturaRet", "comMovProv", "SucursalRet", "ComprobanteRet", "TDFormaDePagoP", "TDNumOperacion", "TDCtaOrdenante", "TDRfcEmisorCtaOrd", "TDNomBancoOrdExt", "TDTipoCadPago", "TDCadPago", "TDSelloPago", "TDCertPago", "Diferencia" };

            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla5 = { "SegmentoSTR", "SaldoOri", "CambioPago" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla7 = { "Cambio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            string[] camposTabla8 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

            string[] camposTabla11 = { "tesMovimientos", "conRenglon" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[11], camposTabla11);


            tesMovimientosDatosBaseDS dsTipado = new tesMovimientosDatosBaseDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Debe.TableName, dsTipado.Haber.TableName,
                dsTipado.ConciliacDebe.TableName, dsTipado.ConciliacHaber.TableName, dsTipado.FactProveedores.TableName,
                dsTipado.AntProveedores.TableName, dsTipado.TiposCambio.TableName, dsTipado.genAtributosGenerales.TableName,
                dsTipado.MoviGravadoHaber.TableName , dsTipado.ReqCompPago.TableName, dsTipado.Adjuntos.TableName};
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static tesMovimientosDatosBaseDS CobraProvDatos(int /*0*/Empresa_Id, string /*1*/Segmento_Id, int /*2*/Segmento1N, int /*3*/Segmento2N, int /*4*/Segmento3N, int /*5*/Segmento4N, string /*6*/Segmento1C, string /*7*/Segmento2C, string /*8*/Segmento3C, string /*9*/Segmento4C, string /*10*/pProveed_Id, string /*11*/pMoneda_Id, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/Segmento_Id, /*2*/Segmento1N, /*3*/Segmento2N, /*4*/Segmento3N, /*5*/Segmento4N, /*6*/Segmento1C, /*7*/Segmento2C, /*8*/Segmento3C, /*9*/Segmento4C, new Generalidades.NullableString(/*10*/pProveed_Id), new Generalidades.NullableString(/*11*/pMoneda_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesCobraProvDatos", parametros);

            string[] camposTabla0 = { "Observaciones", "Cliente_Id", "RazonSocialCliente", "Proveed_Id", "RazonSocialProveedor", "TotalDebe", "TotalHaber", "TotalHabilitado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp", "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta", "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id", "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing", "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id", "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal", "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "Provincia_Id", "FPDescripcionPcia", "FPCondFiscal_Id", "FPDescripcionCondFiscal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal", "FPTipoCompFE", "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet", "AcumTot", "FacturaRet", "comMovProv", "SucursalRet", "ComprobanteRet", "TDFormaDePagoP", "TDNumOperacion", "TDCtaOrdenante", "TDRfcEmisorCtaOrd", "TDNomBancoOrdExt", "TDTipoCadPago", "TDCadPago", "TDSelloPago", "TDCertPago" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla3 = { "SegmentoSTR", "SaldoOri", "CambioPago" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla5 = { "Cambio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            tesMovimientosDatosBaseDS dsTipado = new tesMovimientosDatosBaseDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Debe.TableName, dsTipado.ConciliacDebe.TableName, dsTipado.FactProveedores.TableName, dsTipado.AntProveedores.TableName, dsTipado.TiposCambio.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.MoviGravadoDebe.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static tesMovimientosDatosBaseDS DatosReversion(int /*0*/Empresa_Id, string /*1*/Segmento_Id, string /*2*/Segmento1C, string /*3*/Segmento2C, string /*4*/Segmento3C, string /*5*/Segmento4C, int /*6*/Segmento1N, int /*7*/Segmento2N, int /*8*/Segmento3N, int /*9*/Segmento4N, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/Segmento_Id, /*2*/Segmento1C, /*3*/Segmento2C, /*4*/Segmento3C, /*5*/Segmento4C, /*6*/Segmento1N, /*7*/Segmento2N, /*8*/Segmento3N, /*9*/Segmento4N };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesReversionOPDatos", parametros);

            string[] camposTabla0 = { "Observaciones", "Cliente_Id", "RazonSocialCliente", "Proveed_Id", "RazonSocialProveedor", "TotalDebe", "TotalHaber", "TotalHabilitado" };
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

            tesMovimientosDatosBaseDS dsTipado = new tesMovimientosDatosBaseDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Debe.TableName, dsTipado.Haber.TableName, dsTipado.ConciliacDebe.TableName, dsTipado.ConciliacHaber.TableName, dsTipado.FactProveedores.TableName, dsTipado.AntProveedores.TableName, dsTipado.Reversa.TableName, dsTipado.TiposCambio.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static tesMovimientosSIDS DatosSi(string /*0*/Cartera_Id, int /*1*/Empresa, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Cartera_Id, /*1*/Empresa };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesMovimientosSIDatos", parametros);

            string[] camposTabla0 = { "Cartera_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            tesMovimientosSIDS dsTipado = new tesMovimientosSIDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Movimientos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





    }
}
