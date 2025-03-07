using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public static class venMovimientosFiscal
    {
        public static venMovimientosFiscalDS Datos(long /*0*/pvenMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venMovimientosFiscalDatos", parametros);

            string[] camposTabla0 = { "ClaveFiscal", "Fecha", "Letra", "Comprobante_Id", "DescripcionTipoComp", "EsFactElec",
                "Motivo", "XMLFiscal", "SelloDigital", "FechaString", "SelloFiscal", "NoCertificadoFiscal", "NoCertificadoPropio",
                "FechaAutorizacion", "FechaDesde", "NumeroDesde", "NumeroHasta", "RfcProvCertif", "leyenda", "TipoProceso",
                "TipoComite", "idContabilidad" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venMovimientosFiscalDS dsTipado = new venMovimientosFiscalDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(long /*0*/pvenMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venMovimientosFiscalEliminar", parametros);
        }


        public static void Guardar(long /*0*/pvenMovimientos, string /*1*/pClaveFiscal, DateTime /*2*/pFecha, string /*3*/pLetra,
            int /*4*/pComprobante_Id, bool /*5*/pEsFactElec, string /*6*/pMotivo, string /*7*/pXMLFiscal, string /*8*/pSelloDigital, 
            string /*9*/pFechaString, string /*10*/pSelloFiscal, string /*11*/pNoCertificadoFiscal, string /*12*/pNoCertificadoPropio,
            DateTime /*13*/pFechaAutorizacion, DateTime /*14*/pFechaDesde, int /*15*/pNumeroDesde, int /*16*/pNumeroHasta, 
            string /*17*/pRfcProvCertif, string /*18*/pLeyenda, string /*19*/pTipoProceso, string /*20*/pTipoComite, 
            decimal /*21*/pidContabilidad, string /*22*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, new Generalidades.NullableString(/*1*/pClaveFiscal),
                new Generalidades.NullableDate(/*2*/pFecha), new Generalidades.NullableString(/*3*/pLetra),
                new Generalidades.NullableInt(/*4*/pComprobante_Id), new Generalidades.NullableBool(/*5*/pEsFactElec),
                new Generalidades.NullableString(/*6*/pMotivo), new Generalidades.NullableString(/*7*/pXMLFiscal),
                new Generalidades.NullableString(/*8*/pSelloDigital), new Generalidades.NullableString(/*9*/pFechaString),
                new Generalidades.NullableString(/*10*/pSelloFiscal), new Generalidades.NullableString(/*11*/pNoCertificadoFiscal),
                new Generalidades.NullableString(/*12*/pNoCertificadoPropio), new Generalidades.NullableDate(/*13*/pFechaAutorizacion),
                new Generalidades.NullableDate(/*14*/pFechaDesde), new Generalidades.NullableInt(/*15*/pNumeroDesde),
                new Generalidades.NullableInt(/*16*/pNumeroHasta), new Generalidades.NullableString(/*17*/pRfcProvCertif),
                new Generalidades.NullableString(/*18*/pLeyenda), new Generalidades.NullableString(/*19*/pTipoProceso),
                new Generalidades.NullableString(/*20*/pTipoComite), /*21*/pidContabilidad };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venMovimientosFiscalGuardar", parametros);
        }

        public static void ActuAcuse(long /*0*/pvenMovimientos, string /*1*/pAcuse, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pAcuse };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venMovimientosFiscalActuAcuse", parametros);
        }


    }
}
