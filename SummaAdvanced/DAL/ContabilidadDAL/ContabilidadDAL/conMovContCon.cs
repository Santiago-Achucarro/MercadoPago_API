using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conMovContCon
    {
        public static conMovContConDS Datos(long /*0*/pconAsientos, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pconAsientos, /*1*/pRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conMovContConDatos", parametros);

            string[] camposTabla0 = { "Cuenta_Id", "DescripcionCuentas", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "ReferenciaT", "Referencia1", "Referencia2", "Referencia3", "Referencia4", "Referencia5", "Base_Id", "DescripcionBaseDistri" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            conMovContConDS dsTipado = new conMovContConDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(long /*0*/pconAsientos, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pconAsientos, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conMovContConEliminar", parametros);
        }
        public static void Guardar(long /*0*/pconAsientos, int /*1*/pRenglon, string /*2*/pCuenta_Id, string /*3*/pLeyendaLibroMayor, decimal /*4*/pImporte, decimal /*5*/pTipoMov, string /*6*/pCentro1_Id, string /*7*/pCentro2_Id, string /*8*/pReferenciaT, string /*9*/pReferencia1, string /*10*/pReferencia2, string /*11*/pReferencia3, string /*12*/pReferencia4, string /*13*/pReferencia5, string /*14*/pBase_Id, string /*15*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pconAsientos, /*1*/pRenglon, new Generalidades.NullableString(/*2*/pCuenta_Id), /*3*/pLeyendaLibroMayor, /*4*/pImporte, /*5*/pTipoMov, new Generalidades.NullableString(/*6*/pCentro1_Id), new Generalidades.NullableString(/*7*/pCentro2_Id), new Generalidades.NullableString(/*8*/pReferenciaT), new Generalidades.NullableString(/*9*/pReferencia1), new Generalidades.NullableString(/*10*/pReferencia2), new Generalidades.NullableString(/*11*/pReferencia3), new Generalidades.NullableString(/*12*/pReferencia4), new Generalidades.NullableString(/*13*/pReferencia5), new Generalidades.NullableString(/*14*/pBase_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conMovContConGuardar", parametros);
        }
    }
}
