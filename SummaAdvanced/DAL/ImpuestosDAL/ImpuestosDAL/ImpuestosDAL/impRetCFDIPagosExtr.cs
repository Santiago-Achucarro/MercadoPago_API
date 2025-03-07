using System;
using System.Data;
using interfaceDAAB;
using ImpuestosCommon;


namespace ImpuestosDAL
{
    public class impRetCFDIPagosExtr
    {

        public static impRetCFDIPagosExtrDS Datos(int /*0*/pimpRetencionesCFDI, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impRetCFDIPagosExtrDatos", parametros);

            string[] camposTabla0 = { "Pais_id", "BeneRFC", "BeneCURP", "NomDenRazSocB", "BeneConceptoPago", "BeneDescripcionConcepto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            impRetCFDIPagosExtrDS dsTipado = new impRetCFDIPagosExtrDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pimpRetencionesCFDI, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("impRetCFDIPagosExtrEliminar", parametros);
        }

        public static void Guardar(int /*0*/pimpRetencionesCFDI, string /*1*/pEsBenefEfectDelCobro, int /*2*/pPais_id, string /*3*/pConceptoPago, string /*4*/pDescripcionConcepto, string /*5*/pBeneRFC, string /*6*/pBeneCURP, string /*7*/pNomDenRazSocB, string /*8*/pBeneConceptoPago, string /*9*/pBeneDescripcionConcepto, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pimpRetencionesCFDI, /*1*/pEsBenefEfectDelCobro, new Generalidades.NullableInt(/*2*/pPais_id), /*3*/pConceptoPago, /*4*/pDescripcionConcepto, new Generalidades.NullableString(/*5*/pBeneRFC), new Generalidades.NullableString(/*6*/pBeneCURP), new Generalidades.NullableString(/*7*/pNomDenRazSocB), new Generalidades.NullableString(/*8*/pBeneConceptoPago), new Generalidades.NullableString(/*9*/pBeneDescripcionConcepto) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("impRetCFDIPagosExtrGuardar", parametros);
        }




    }
}
