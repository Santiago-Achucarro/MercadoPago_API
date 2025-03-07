using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesCheqPropDiferidos
    {
        public static tesCheqPropDiferidosDS Datos(DateTime /*0*/pFechaHasta, Int32 pEmpresa, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFechaHasta, pEmpresa };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesCheqPropDiferidosDatos", parametros);

            string[] camposTabla0 = { "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Centro1_Id", "Centro2_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            tesCheqPropDiferidosDS dsTipado = new tesCheqPropDiferidosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Pendientes.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
