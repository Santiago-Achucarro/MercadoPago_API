using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesoreriaCommon;
using interfaceDAAB;
using System.Data;
namespace TesoreriaDAL
{
    public class tesDeposito
    {
        public static tesDepositoDS Datos(long /*0*/ptesMovimientos, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, /*1*/pRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesDepositoDatos", parametros);

            string[] camposTabla0 = { "NumOperacion", "NomBancoOrdExt", "CtaOrdenante", "TipoCadPago", "CertPago", "CadPago", "SelloPago", "RfcEmisorCtaOrd" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            tesDepositoDS dsTipado = new tesDepositoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static tesDepositosXBancosDS DatosXBancos(int /*0*/Empresa_Id, DateTime /*1*/pFechaDesde, DateTime /*2*/pFechaHasta, string /*3*/pCartera, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id, /*1*/pFechaDesde, /*2*/pFechaHasta, /*3*/pCartera };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesDepositosXBancosDatos", parametros);

            string[] camposTabla0 = { "FechaDesde", "FechaHasta", "Cartera_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "SegmentoSTR", "NumOperacion", "NomBancoOrdExt", "CtaOrdenante", "TipoCadPago", "CertPago", "CadPago", "SelloPago", "RfcEmisorCtaOrd" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            tesDepositosXBancosDS dsTipado = new tesDepositosXBancosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(long /*0*/ptesMovimientos, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesDepositoEliminar", parametros);
        }


        public static void Guardar(long /*0*/ptesMovimientos, int /*1*/pRenglon, string /*2*/pFormaDePagoP, string /*3*/pNumOperacion, string /*4*/pNomBancoOrdExt, string /*5*/pCtaOrdenante, string /*6*/pTipoCadPago, string /*7*/pCertPago, string /*8*/pCadPago, string /*9*/pSelloPago, string /*10*/pRfcEmisorCtaOrd, string /*11*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, /*1*/pRenglon, /*2*/pFormaDePagoP, new Generalidades.NullableString(/*3*/pNumOperacion), new Generalidades.NullableString(/*4*/pNomBancoOrdExt), new Generalidades.NullableString(/*5*/pCtaOrdenante), new Generalidades.NullableString(/*6*/pTipoCadPago), new Generalidades.NullableString(/*7*/pCertPago), new Generalidades.NullableString(/*8*/pCadPago), new Generalidades.NullableString(/*9*/pSelloPago), new Generalidades.NullableString(/*10*/pRfcEmisorCtaOrd) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesDepositoGuardar", parametros);
        }




    }
}
