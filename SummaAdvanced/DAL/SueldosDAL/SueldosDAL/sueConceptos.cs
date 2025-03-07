using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class sueConceptos
    {
        public static sueConceptosDS Datos(int /*0*/pConcepto_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pConcepto_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("sueConceptosDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas", "CuentaDebe", "DescripcionCuentaDebe", "CuentaHaber", "DescripcionCuentaHaber", "SubCuentaDebe", "DescripcionSubCuentasDebe", "SubCuentaHaber", "DescripcionSubCuentasHaber", "TipoPercepcion", "DescripcionTipoPercepcion", "TipoDeduccion", "DescripcionTipoDeduccion", "TipoOtro", "DescripcionTipoOtro", "TipoHora", "TipoIncapacidad", "Usuario_Id", "DescripcionUsuario", "Observacion" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "SiNo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            sueConceptosDS dsTipado = new sueConceptosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Propiedades.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(int /*0*/pConcepto_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pConcepto_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueConceptosEliminar", parametros);
        }

        public static int Guardar(int /*0*/pConcepto_Id, int /*1*/pConcepto_Id_Nuevo, string /*2*/pDescripcion, int /*3*/pEmpresa_Id, string /*4*/pFormula, bool /*5*/pLlevaDato, string /*6*/pCuentaDebe, string /*7*/pCuentaHaber, string /*8*/pSubCuentaDebe, string /*9*/pSubCuentaHaber, bool /*10*/pRetroactivo, bool /*11*/pExtraordinario, string /*12*/pTipoPercepcion, string /*13*/pTipoDeduccion, string /*14*/pTipoOtro, string /*15*/pTipoHora, string /*16*/pTipoIncapacidad, bool /*17*/pEsExento, string /*18*/pObservacion, bool /*19*/pInactivo, bool /*20*/pPosteado, int /*21*/pUsuario_Id, short /*22*/pSigno, short /*23*/pColumnaRecibo, string /*24*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pConcepto_Id, /*1*/pConcepto_Id_Nuevo, /*2*/pDescripcion, new Generalidades.NullableInt(/*3*/pEmpresa_Id), /*4*/pFormula, /*5*/pLlevaDato, new Generalidades.NullableString(/*6*/pCuentaDebe), new Generalidades.NullableString(/*7*/pCuentaHaber), new Generalidades.NullableString(/*8*/pSubCuentaDebe), new Generalidades.NullableString(/*9*/pSubCuentaHaber), /*10*/pRetroactivo, /*11*/pExtraordinario, new Generalidades.NullableString(/*12*/pTipoPercepcion), new Generalidades.NullableString(/*13*/pTipoDeduccion), new Generalidades.NullableString(/*14*/pTipoOtro), new Generalidades.NullableString(/*15*/pTipoHora), new Generalidades.NullableString(/*16*/pTipoIncapacidad), /*17*/pEsExento, new Generalidades.NullableString(/*18*/pObservacion), /*19*/pInactivo, /*20*/pPosteado, new Generalidades.NullableInt(/*21*/pUsuario_Id), /*22*/pSigno, /*23*/pColumnaRecibo };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("sueConceptosGuardar", parametros));
        }
    }
}
