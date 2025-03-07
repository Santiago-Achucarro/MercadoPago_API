using System;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genInstalacion
    {
        public static genInstalacionDS Datos(string /*0*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("genInstalacionDatos", parametros);

            string[] camposTabla0 = { "Dominio_Id", "DescripcionDominios", "RptServidor", "RptCarpeta", "RptUsuario", "RptClave", "RptDominio",  "TamanioHoja", "LongitudClave", "DiasDuracionClave", "LoginGracia", "CantIntentosFallidos", "ClaveSimbolos", "ClaveNumero", "ClaveMayuscula", "ClaveMinuscula", "ClaveComunes", "TwoFactor", "EntrarSiFallaCorreo", "DuracionCookie" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genInstalacionDS dsTipado = new genInstalacionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Guardar(string /*0*/pDominio_Id, string /*2*/pRptServidor, string /*3*/pRptCarpeta, string /*4*/pRptUsuario, string /*5*/pRptClave, string /*6*/pRptDominio, int /*7*/pUsoHorario, string /*12*/pTamanioHoja, int /*13*/pLongitudClave, int /*14*/pDiasDuracionClave, int /*15*/pLoginGracia, int /*16*/pCantIntentosFallidos, bool /*17*/pClaveSimbolos, bool /*18*/pClaveNumero, bool /*19*/pClaveMayuscula, bool /*20*/pClaveMinuscula, bool /*21*/pClaveComunes, short /*22*/pconDigiCta, short /*23*/pconDigiSubCta, string /*24*/pcontMascaraCuenta, string /*25*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pDominio_Id), new Generalidades.NullableString(/*2*/pRptServidor), new Generalidades.NullableString(/*3*/pRptCarpeta), new Generalidades.NullableString(/*4*/pRptUsuario), new Generalidades.NullableString(/*5*/pRptClave), new Generalidades.NullableString(/*6*/pRptDominio), /*7*/pUsoHorario, new Generalidades.NullableString(/*12*/pTamanioHoja), /*13*/pLongitudClave, /*14*/pDiasDuracionClave, /*15*/pLoginGracia, /*16*/pCantIntentosFallidos, /*17*/pClaveSimbolos, /*18*/pClaveNumero, /*19*/pClaveMayuscula, /*20*/pClaveMinuscula, /*21*/pClaveComunes, /*22*/pconDigiCta, /*23*/pconDigiSubCta, /*24*/pcontMascaraCuenta };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genInstalacionGuardar", parametros);
        }

        public static void SeguridadGuardar(string /*0*/pDominio_Id, int /*1*/pUsoHorario, string /*2*/pTamanioHoja, int /*3*/pLongitudClave, int /*4*/pDiasDuracionClave, int /*5*/pLoginGracia, int /*6*/pCantIntentosFallidos, bool /*7*/pClaveSimbolos, bool /*8*/pClaveNumero, bool /*9*/pClaveMayuscula, bool /*10*/pClaveMinuscula, bool /*11*/pClaveComunes, short /*12*/pconDigiCta, short /*13*/pconDigiSubCta, string /*14*/pcontMascaraCuenta, bool /*15*/pTwoFactor, bool /*16*/pEntrarSiFallaCorreo, int /*17*/pDuracionCookie, string /*18*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pDominio_Id), /*1*/pUsoHorario, new Generalidades.NullableString(/*2*/pTamanioHoja), /*3*/pLongitudClave, /*4*/pDiasDuracionClave, /*5*/pLoginGracia, /*6*/pCantIntentosFallidos, /*7*/pClaveSimbolos, /*8*/pClaveNumero, /*9*/pClaveMayuscula, /*10*/pClaveMinuscula, /*11*/pClaveComunes, /*12*/pconDigiCta, /*13*/pconDigiSubCta, /*14*/pcontMascaraCuenta, /*15*/pTwoFactor, /*16*/pEntrarSiFallaCorreo, /*17*/pDuracionCookie };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genInstalacionSeguridadGuardar", parametros);
        }

        //public static void LicenciaGuardar(DateTime /*0*/pFecha, int /*1*/pUsuarios, string /*2*/pClave, bool /*3*/pPorEmpresa, string /*4*/pLicencia, string /*5*/ pAuxiliar)
        //{
        //    Object[] parametros = new Object[] {/*0*/pFecha, /*1*/pUsuarios, /*2*/pClave, /*3*/pPorEmpresa, /*4*/pLicencia };

        //    iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

        //    oiDAAB.guardar("genLicenciaGuardar", parametros);
        //}


    }
}
