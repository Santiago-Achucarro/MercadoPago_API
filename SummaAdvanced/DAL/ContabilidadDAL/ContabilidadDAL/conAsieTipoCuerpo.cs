using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conAsieTipoCuerpo
    {
        public static conAsieTipoCuerpoDS Datos(int /*0*/pAsiTipo_Id, short /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiTipo_Id, new Generalidades.NullableShort(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conAsieTipoCuerpoDatos", parametros);

            string[] camposTabla0 = { "Cuenta_Id", "DescripcionCuentas", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            conAsieTipoCuerpoDS dsTipado = new conAsieTipoCuerpoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(int /*0*/pAsiTipo_Id, short /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiTipo_Id, new Generalidades.NullableShort(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conAsieTipoCuerpoEliminar", parametros);
        }
        public static void Guardar(int /*0*/pAsiTipo_Id, short /*1*/pRenglon, string /*2*/pCuenta_Id, string /*3*/pCentro1_Id, string /*4*/pCentro2_Id, string /*5*/pLeyendaLibroMayor, decimal /*6*/pHaber, decimal /*7*/pDebe, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiTipo_Id, /*1*/pRenglon, new Generalidades.NullableString(/*2*/pCuenta_Id), new Generalidades.NullableString(/*3*/pCentro1_Id), new Generalidades.NullableString(/*4*/pCentro2_Id), /*5*/pLeyendaLibroMayor, /*6*/pHaber, /*7*/pDebe };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conAsieTipoCuerpoInsertar", parametros);
        }
    }
}
