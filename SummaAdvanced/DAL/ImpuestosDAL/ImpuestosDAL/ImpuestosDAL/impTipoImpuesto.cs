using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ImpuestosCommon;

namespace ImpuestosDAL
{
    public class impTipoImpuesto
    {
        public static impTipoImpuestoDS Datos(int /*0*/pTipoImpuesto, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoImpuesto };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impTipoImpuestoDatos", parametros);

            string[] camposTabla0 = { "CodigoFiscal", "Juris_Id", "DescripcionJurisdicciones", "Referencia01", "Referencia02",
                "Referencia03", "Referencia04", "Referencia05", "Referencia06", "Referencia07", "Referencia08", "Referencia09",
                "Referencia10" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            impTipoImpuestoDS dsTipado = new impTipoImpuestoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(int /*0*/pTipoImpuesto, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pTipoImpuesto) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("impTipoImpuestoEliminar", parametros);
        }


        public static void Guardar(int /*0*/pTipoImpuesto, string /*1*/pDescripcion, string /*2*/pCodigoFiscal, string /*3*/pJuris_Id,
            string /*4*/pReferencia01, string /*5*/pReferencia02, string /*6*/pReferencia03, string /*7*/pReferencia04, 
            string /*8*/pReferencia05, string /*9*/pReferencia06, string /*10*/pReferencia07, string /*11*/pReferencia08, 
            string /*12*/pReferencia09, string /*13*/pReferencia10, string /*14*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoImpuesto, /*1*/pDescripcion,
                new Generalidades.NullableString(/*2*/pCodigoFiscal), new Generalidades.NullableString(/*3*/pJuris_Id),
                new Generalidades.NullableString(/*4*/pReferencia01), new Generalidades.NullableString(/*5*/pReferencia02),
                new Generalidades.NullableString(/*6*/pReferencia03), new Generalidades.NullableString(/*7*/pReferencia04),
                new Generalidades.NullableString(/*8*/pReferencia05), new Generalidades.NullableString(/*9*/pReferencia06),
                new Generalidades.NullableString(/*10*/pReferencia07), new Generalidades.NullableString(/*11*/pReferencia08),
                new Generalidades.NullableString(/*12*/pReferencia09), new Generalidades.NullableString(/*13*/pReferencia10) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("impTipoImpuestoGuardar", parametros);
        }


    }
}
