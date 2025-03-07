using System;
using System.Data;
using interfaceDAAB;
using ImpuestosCommon;

namespace ImpuestosDAL
{
    public class impRetencionesCFDI
    {

        public static impRetencionesCFDIDS Datos(int /*0*/pFolio, int /*1*/pEmpresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFolio, /*1*/pEmpresa_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("impRetencionesCFDIDatos", parametros);

            string[] camposTabla0 = { "FechaCancelacion", "FechaTimbre", "RfcProvCertif", "Leyenda", "Xml", "CodPostal", "UtilidadBimestral", "ISRCorrespondiente" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "TipoPagoRet" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "DescrMontOtrosConceptDistr" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla7 = { "Pais_id", "BeneRFC", "BeneCURP", "NomDenRazSocB", "BeneConceptoPago", "BeneDescripcionConcepto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            string[] camposTabla9 = { "Provincia_id", "DescripcionProvincia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[9], camposTabla9);

            impRetencionesCFDIDS dsTipado = new impRetencionesCFDIDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.impRetCFDIDetalle.TableName, dsTipado.impRetCFDIArrenda.TableName, dsTipado.impRetCFDIDividendos.TableName, dsTipado.impRetCFDIEnajAccion.TableName, dsTipado.impRetCFDIFiedeEmpr.TableName, dsTipado.impRetCFDIOperConDeriv.TableName, dsTipado.impRetCFDIPagosExtr.TableName, dsTipado.impRetCFDIPlanesRet.TableName, dsTipado.impRetCFDIPremios.TableName, dsTipado.impRetCFDISecFinan.TableName, dsTipado.impRetCFDIIntereses.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static impRetencionesCFDIDS DatosInt(int /*0*/pimpRetenciones, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetenciones };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impRetencionesCFDIDatosInt", parametros);

            string[] camposTabla0 = { "FechaCancelacion", "FechaTimbre", "RfcProvCertif", "Leyenda", "Xml", "CodPostal", "UtilidadBimestral", "ISRCorrespondiente" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);


            string[] camposTabla7 = { "Pais_id", "BeneRFC", "BeneCURP", "NomDenRazSocB", "BeneConceptoPago", "BeneDescripcionConcepto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            string[] camposTabla9 = { "Provincia_id", "DescripcionProvincia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[9], camposTabla9);

            impRetencionesCFDIDS dsTipado = new impRetencionesCFDIDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.impRetCFDIDetalle.TableName, dsTipado.impRetCFDIArrenda.TableName, dsTipado.impRetCFDIDividendos.TableName, dsTipado.impRetCFDIEnajAccion.TableName, dsTipado.impRetCFDIFiedeEmpr.TableName, dsTipado.impRetCFDIOperConDeriv.TableName, dsTipado.impRetCFDIPagosExtr.TableName, dsTipado.impRetCFDIPlanesRet.TableName, dsTipado.impRetCFDIPremios.TableName, dsTipado.impRetCFDISecFinan.TableName,dsTipado.impRetCFDIIntereses.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(int /*0*/pFolio, int /*1*/pEmpresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFolio, /*1*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("impRetencionesCFDIEliminar", parametros);
        }

        public static int Guardar(int /*0*/pFolio, string /*1*/pSello, string /*2*/pNumCert, DateTime /*3*/pFechaExp, string /*4*/pCveRetenc, string /*5*/pDescRetenc, string /*6*/pNacionalidad, string /*7*/pRFC, string /*8*/pRazonSocial, string /*9*/pCURP, string /*10*/pNroRegIdTrib, int /*11*/pEjercicio, short /*12*/pMesIni, short /*13*/pMesFin, decimal /*14*/pmontoTotOperacion, decimal /*15*/pmontoTotGrav, decimal /*16*/pmontoTotExent, decimal /*17*/pmontoTotRet, bool /*18*/pCancelado, DateTime /*19*/pFechaCancelacion, string /*20*/pFechaTimbre, string /*21*/pSelloSAT, string /*22*/pNoCertificadoSAT, string /*23*/pUUID, string /*24*/pRfcProvCertif, string /*25*/pLeyenda, int /*26*/pUsuario_Id, int /*27*/pEmpresa_Id, string /*28*/pXml, string /*29*/pCodPostal, decimal /*30*/pUtilidadBimestral, decimal /*31*/pISRCorrespondiente, string /*32*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFolio, /*1*/pSello, /*2*/pNumCert, /*3*/pFechaExp, new Generalidades.NullableString(/*4*/pCveRetenc), /*5*/pDescRetenc, /*6*/pNacionalidad, /*7*/pRFC, /*8*/pRazonSocial, /*9*/pCURP, /*10*/pNroRegIdTrib, /*11*/pEjercicio, /*12*/pMesIni, /*13*/pMesFin, /*14*/pmontoTotOperacion, /*15*/pmontoTotGrav, /*16*/pmontoTotExent, /*17*/pmontoTotRet, /*18*/pCancelado, new Generalidades.NullableDate(/*19*/pFechaCancelacion), /*20*/pFechaTimbre, /*21*/pSelloSAT, /*22*/pNoCertificadoSAT, /*23*/pUUID, new Generalidades.NullableString(/*24*/pRfcProvCertif), new Generalidades.NullableString(/*25*/pLeyenda), /*26*/pUsuario_Id, /*27*/pEmpresa_Id, /*28*/pXml, new Generalidades.NullableString(/*29*/pCodPostal), new Generalidades.NullableDecimal(/*30*/pUtilidadBimestral), new Generalidades.NullableDecimal(/*31*/pISRCorrespondiente) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("impRetencionesCFDIGuardar", parametros);
        }


        public static void Cancelar(int /*0*/pFolio, int /*1*/pEmpresa_Id, int /*2*/pUsuario_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFolio, /*1*/pEmpresa_Id, /*2*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("impRetencionesCFDICancelar", parametros);
        }






    }
}
