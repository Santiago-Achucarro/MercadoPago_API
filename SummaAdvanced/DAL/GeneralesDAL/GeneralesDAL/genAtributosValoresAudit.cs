using GeneralesCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GeneralesDAL
{
    public class genAtributosValoresAudit
    {
        public static genAtributosValoresAuditFechaDS Datos(long /*0*/pIdentity_Id, int /*1*/pAtributoNro, string /*2*/pTabla_Id, 
            DateTime /*3*/pFecha, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pIdentity_Id, /*1*/pAtributoNro, /*2*/pTabla_Id, /*3*/pFecha };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genAtributosValoresAuditFechaDatos", parametros);

            string[] camposTabla0 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genAtributosValoresAuditFechaDS dsTipado = new genAtributosValoresAuditFechaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
