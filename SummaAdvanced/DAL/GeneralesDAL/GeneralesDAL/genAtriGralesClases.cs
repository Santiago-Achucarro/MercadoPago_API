using GeneralesCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GeneralesDAL
{
    public class genAtriGralesClases
    {
        public static genAtriGralesClasesDS Datos(string /*0*/pTabla_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabla_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genAtriGralesClasesDatos", parametros);

            genAtriGralesClasesDS dsTipado = new genAtriGralesClasesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

    }
}
