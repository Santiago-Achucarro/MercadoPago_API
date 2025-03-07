using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesSolicitud
    {
        public static tesSolicitudDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesSolicitudDatos", parametros);

            string[] camposTabla0 = { "Causa", "UsuarioAutorizo", "DescripcionUsuarioAutorizo", "FechaAutorizo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            tesSolicitudDS dsTipado = new tesSolicitudDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static void Eliminar(long /*0*/ptesSolicitud, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesSolicitud };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesSolicitudEliminar", parametros);
        }

        public static Int64 Guardar(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/pSolicitante_Id, string /*11*/pCausa, DateTime /*12*/pFecha, decimal /*13*/pMonto, string /*14*/pEstado, string /*15*/pUsuarioAutorizo, DateTime /*16*/pFechaAutorizo, int /*17*/pUsuario_Id, DateTime /*18*/pFechaCarga, string /*19*/pCartera_Id, string /*20*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pSolicitante_Id, new Generalidades.NullableString(/*11*/pCausa), /*12*/pFecha, /*13*/pMonto, /*14*/pEstado, new Generalidades.NullableString(/*15*/pUsuarioAutorizo), new Generalidades.NullableDate(/*16*/pFechaAutorizo), /*17*/pUsuario_Id, /*18*/pFechaCarga, /*19*/pCartera_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (Int64) oiDAAB.guardar("tesSolicitudGuardar", parametros);
        }



        public static tesSolicitudParaAutorizarDS ParaAutorizar(int /*0*/pEmpresa_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesSolicitudParaAutorizar", parametros);

            string[] camposTabla0 = { "Empresa" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "SegmentoSTR", "Causa" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            tesSolicitudParaAutorizarDS dsTipado = new tesSolicitudParaAutorizarDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void CambiarEstado(long /*0*/ptesSolicitud, int /*1*/pUsuario, string /*2*/pEstado, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesSolicitud, /*1*/pUsuario, /*2*/pEstado };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesSolicitudCambiarEstado", parametros);
        }



        public static TesoreriaCommon.tesMovimientosDatosBaseDS DatosPago(int /*0*/Empresa_Id, string /*1*/Segmento_Id, int /*2*/Segmento1N, int /*3*/Segmento2N, int /*4*/Segmento3N, int /*5*/Segmento4N, string /*6*/Segmento1C, string /*7*/Segmento2C, string /*8*/Segmento3C, string /*9*/Segmento4C, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/Segmento_Id, /*2*/Segmento1N, /*3*/Segmento2N, /*4*/Segmento3N, /*5*/Segmento4N, /*6*/Segmento1C, /*7*/Segmento2C, /*8*/Segmento3C, /*9*/Segmento4C };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesSolicitudPago", parametros);

            string[] camposTabla0 = { "Observaciones", "Cliente_Id", "RazonSocialCliente", "Proveed_Id", "RazonSocialProveedor", "TotalDebe", "TotalHaber", "TotalHabilitado", "ControlaFormulario", "TotalDebeOriginal", "TotalHaberOriginal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp", "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta", "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id", "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing", "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id", "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal", "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "Provincia_Id", "FPDescripcionPcia", "FPCondFiscal_Id", "FPDescripcionCondFiscal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal", "FPTipoCompFE", "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet", "AcumTot", "FacturaRet", "comMovProv", "SucursalRet", "ComprobanteRet", "TDFormaDePagoP", "TDNumOperacion", "TDCtaOrdenante", "TDRfcEmisorCtaOrd", "TDNomBancoOrdExt", "TDTipoCadPago", "TDCadPago", "TDSelloPago", "TDCertPago", "Diferencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp", "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta", "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id", "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing", "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id", "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal", "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "Provincia_Id", "FPDescripcionPcia", "FPCondFiscal_Id", "FPDescripcionCondFiscal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal", "FPTipoCompFE", "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet", "AcumTot", "FacturaRet", "comMovProv", "SucursalRet", "ComprobanteRet", "TDFormaDePagoP", "TDNumOperacion", "TDCtaOrdenante", "TDRfcEmisorCtaOrd", "TDNomBancoOrdExt", "TDTipoCadPago", "TDCadPago", "TDSelloPago", "TDCertPago", "Diferencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla5 = { "Cambio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla7 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            TesoreriaCommon.tesMovimientosDatosBaseDS dsTipado = new TesoreriaCommon.tesMovimientosDatosBaseDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Debe.TableName, dsTipado.Haber.TableName,
                dsTipado.ConciliacDebe.TableName, dsTipado.ConciliacHaber.TableName,
                dsTipado.TiposCambio.TableName, dsTipado.Reversa.TableName,
                dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static TesoreriaCommon.tesMovimientosDatosBaseDS DatosRendicion(int /*0*/Empresa_Id, string /*1*/Segmento_Id, int /*2*/Segmento1N, int /*3*/Segmento2N, int /*4*/Segmento3N, int /*5*/Segmento4N, string /*6*/Segmento1C, string /*7*/Segmento2C, string /*8*/Segmento3C, string /*9*/Segmento4C, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/Segmento_Id, /*2*/Segmento1N, /*3*/Segmento2N, /*4*/Segmento3N, /*5*/Segmento4N, /*6*/Segmento1C, /*7*/Segmento2C, /*8*/Segmento3C, /*9*/Segmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesSolicitudRendicion", parametros);

            string[] camposTabla0 = { "Observaciones", "Cliente_Id", "RazonSocialCliente", "Proveed_Id", "RazonSocialProveedor", "TotalDebe", "TotalHaber", "TotalHabilitado", "ControlaFormulario", "TotalDebeOriginal", "TotalHaberOriginal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp", "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta", "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id", "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing", "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id", "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal", "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "Provincia_Id", "FPDescripcionPcia", "FPCondFiscal_Id", "FPDescripcionCondFiscal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal", "FPTipoCompFE", "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet", "AcumTot", "FacturaRet", "comMovProv", "SucursalRet", "ComprobanteRet", "TDFormaDePagoP", "TDNumOperacion", "TDCtaOrdenante", "TDRfcEmisorCtaOrd", "TDNomBancoOrdExt", "TDTipoCadPago", "TDCadPago", "TDSelloPago", "TDCertPago", "Diferencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp", "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta", "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id", "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing", "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id", "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal", "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "Provincia_Id", "FPDescripcionPcia", "FPCondFiscal_Id", "FPDescripcionCondFiscal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal", "FPTipoCompFE", "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet", "AcumTot", "FacturaRet", "comMovProv", "SucursalRet", "ComprobanteRet", "TDFormaDePagoP", "TDNumOperacion", "TDCtaOrdenante", "TDRfcEmisorCtaOrd", "TDNomBancoOrdExt", "TDTipoCadPago", "TDCadPago", "TDSelloPago", "TDCertPago", "Diferencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla5 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Base_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "CtaDebe", "DescripcionCuentaDebe", "CtaHaber", "DescripcionCuentaHaber", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            string[] camposTabla7 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Base_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            string[] camposTabla8 = { "CtaDebe", "DescripcionCuentaDebe", "CtaHaber", "DescripcionCuentaHaber", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

            string[] camposTabla10 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[10], camposTabla10);

            TesoreriaCommon.tesMovimientosDatosBaseDS dsTipado = new TesoreriaCommon.tesMovimientosDatosBaseDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Debe.TableName, dsTipado.Haber.TableName,
                    dsTipado.ConciliacDebe.TableName, dsTipado.ConciliacHaber.TableName,
                    dsTipado.FactAneCuerpoDebe.TableName, dsTipado.FactAneImpuestoDebe.TableName,
                    dsTipado.FactAneCuerpoHaber.TableName, dsTipado.FactAneImpuestoHaber.TableName,
                    dsTipado.Reversa.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);

        }



    }
}
