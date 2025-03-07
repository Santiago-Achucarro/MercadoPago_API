using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesRengMovi
    {

        public static tesRengMoviDHDS Datos(long /*0*/ptesMovimientos, int /*1*/pTipomov, int /*2*/pconRenglon, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, /*1*/pTipomov, new Generalidades.NullableInt(/*2*/pconRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesRengMoviDHDatos", parametros);

            string[] camposTabla0 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "tesCheqProp", "CPChequera_Id", "CPnumCheque", "CPEstado_Id", "CPTipoChequera", "CPChequeraDesde", "CPChequeraHasta", "CPChequeraProximo", "CPFechaVencimiento", "CPAlaOrden", "CPCuit", "CPCuentaDestino", "CPBanco_Id", "CPDescripcionBanco", "CPBancoDestinoExt", "tesCheqTerceros", "CTBanco_Id", "CTDescripcionBanco", "CTClearing", "CTVariable", "CTClearingDias", "CTFechaVencimiento", "CTsucBanco", "CTcuentaBanco", "CTnumCheque", "CTEstado_Id", "CTCliente_Id", "CTRazonSocial", "FPAsiento_Id", "FPFecha_Ane", "FPFechaFiscal", "FPCuit", "FPTipoDoc", "FPIdFiscal", "FPRazonSocial", "FPDireccion1", "FPDireccion2", "Localidad", "Cod_Postal", "Provincia_Id", "FPDescripcionPcia", "FPCondFiscal_Id", "FPDescripcionCondFiscal", "FPOrigen_Id", "FPDescripcionOrigen", "FPVieneDeFiscal", "FPXMLFiscal", "FPClaveFiscal", "FPconRenglonProv", "Segmento_Id", "Segmento1N", "Segmento2N", "Segmento3N", "Segmento4N", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Porcentaje", "Exencion", "BaseImponible", "Acum", "TRet", "AcumTot", "FacturaRet", "comMovProv" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            tesRengMoviDHDS dsTipado = new tesRengMoviDHDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }








        public static void Eliminar(long /*0*/ptesMovimientos, int /*1*/pconRenglon,  string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, /*1*/pconRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesRengMoviEliminar", parametros);
        }

        public static void Guardar(long /*0*/ptesMovimientos, int /*1*/pconRenglon, string /*2*/pCartera_Id, decimal pCambio, decimal pTipomovCont,  string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, /*1*/pconRenglon, /*2*/pCartera_Id,  pCambio, pTipomovCont };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesRengMoviGuardar", parametros);
        }


    }
}
