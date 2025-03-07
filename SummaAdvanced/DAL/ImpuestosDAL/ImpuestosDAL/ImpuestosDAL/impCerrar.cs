using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ImpuestosCommon;
using interfaceDAAB;
using System.Data;

namespace ImpuestosDAL
{
    public class impCerrar
    {
        public static impCerrarDS Datos(int /*0*/Empresa_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impCerrar", parametros);

            string[] camposTabla0 = { "UltimoCierre" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            impCerrarDS dsTipado = new impCerrarDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
