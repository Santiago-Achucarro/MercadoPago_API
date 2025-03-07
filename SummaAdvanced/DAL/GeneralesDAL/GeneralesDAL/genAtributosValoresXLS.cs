using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genAtributosValoresXLS
    {
        public static void Guardar(string /*0*/pClave_Id, int /*1*/pAtributoNro, string /*2*/pTabla_Id, string /*3*/pValorC, string /*4*/pValorF, int /*5*/pValorN, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pClave_Id, /*1*/pAtributoNro, /*2*/pTabla_Id,new Generalidades.NullableString(pValorC), new Generalidades.NullableString(pValorF), new Generalidades.NullableInt(pValorN)};
            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);
            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genAtributosValoresXLSGuardar", parametros);
        }
        public static genAtributosValoresXLSValidaClaveDS ValidarCodigo(string /*0*/pClave_Id, int /*1*/pAtributoNro, string /*2*/pTabla_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pClave_Id, /*1*/pAtributoNro, /*2*/pTabla_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genAtributosValoresXLSValidaClave", parametros);

            genAtributosValoresXLSValidaClaveDS dsTipado = new genAtributosValoresXLSValidaClaveDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.AtributoGral.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static genAtributosValoresXLSDS Datos(string /*0*/pTabla_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabla_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genAtributosValoresXLS", parametros);

            string[] camposTabla1 = { "type" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "type" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            genAtributosValoresXLSDS dsTipado = new genAtributosValoresXLSDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Funcion.TableName, dsTipado.Tabla.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

    }
}
