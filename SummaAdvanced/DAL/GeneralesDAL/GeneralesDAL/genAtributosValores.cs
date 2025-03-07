using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genAtributosValores
    {

        public static genAtributosValoresDS Datos(long /*0*/pIdentity_Id, int /*1*/pAtributoNro, string /*2*/pTabla_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pIdentity_Id, /*1*/pAtributoNro, /*2*/pTabla_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genAtributosValoresDatos", parametros);

            string[] camposTabla0 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genAtributosValoresDS dsTipado = new genAtributosValoresDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pIdentity_Id, int /*1*/pAtributoNro, string /*2*/pTabla_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pIdentity_Id, new Generalidades.NullableInt(/*1*/pAtributoNro), /*2*/pTabla_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genAtributosValoresEliminar", parametros);
        }

        public static void Guardar(long /*0*/pIdentity_Id, int /*1*/pAtributoNro, string /*2*/pTabla_Id,
            decimal /*3*/pValorN, string /*4*/pValorC, DateTime /*5*/pValorF, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pIdentity_Id, /*1*/pAtributoNro, /*2*/pTabla_Id, /*3*/pValorN, new Generalidades.NullableString(/*4*/pValorC), new Generalidades.NullableDate(/*5*/pValorF) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genAtributosValoresGuardar", parametros);
        }

        public static genAtributosValoresValoresDS Valores(int /*0*/pAtributoNro, string /*1*/pTabla_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAtributoNro, /*1*/pTabla_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genAtributosValoresValores", parametros);

            string[] camposTabla0 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genAtributosValoresValoresDS dsTipado = new genAtributosValoresValoresDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }






    }
}
