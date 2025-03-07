using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genGlobales
    {
        public static genGlobalesDS Datos(int /*0*/pEmpresa_Id, string /*1*/pNombre_Var, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pNombre_Var };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genGlobalesDatos", parametros);

            string[] camposTabla0 = { "nValor", "cValor", "fValor", "mValor", "lupIdentidad", "WhereF10" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genGlobalesDS dsTipado = new genGlobalesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(int /*0*/pEmpresa_Id, string /*1*/pNombre_Var, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pNombre_Var };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genGlobalesEliminar", parametros);
        }

        public static void Guardar(int /*0*/pEmpresa_Id, string /*1*/pNombre_Var, string /*2*/pDescripcion, 
            string /*3*/pTipo, short /*4*/pLongitud, decimal /*5*/pDecimales, decimal /*6*/pnValor, string /*7*/pcValor, 
            DateTime /*8*/pfValor, string /*9*/pmValor, string /*10*/pSubSistema, bool /*11*/pSoloLectura,
            string /*12*/plupIdentidad, string /*13*/pWhereF10, string /*14*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pNombre_Var, /*2*/pDescripcion, /*3*/pTipo,
                /*4*/pLongitud, /*5*/pDecimales, /*6*/pnValor, new Generalidades.NullableString(/*7*/pcValor),
                new Generalidades.NullableDate(/*8*/pfValor), new Generalidades.NullableString(/*9*/pmValor), 
                /*10*/pSubSistema, /*11*/pSoloLectura, /*12*/plupIdentidad, new Generalidades.NullableString(/*13*/pWhereF10) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genGlobalesGuardar", parametros);
        }


        public static void Set(int /*0*/pEmpresa_Id, string /*1*/pNombre_Var, decimal /*2*/pnValor, 
            string /*3*/pcValor, DateTime /*4*/pfValor, string pmValor, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*2*/pNombre_Var,  new Generalidades.NullableDecimal( pnValor),
                new Generalidades.NullableString( pcValor),new Generalidades.NullableDate(pfValor),
            new Generalidades.NullableString(pmValor)};
            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genGlobalesSet", parametros);
        }

    }
}
