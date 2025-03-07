using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genFechasAplicacion
    {
        public static genFechasAplicacionDS Datos(long /*0*/Asiento_id, long /*1*/Asiento_Id_Ap, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Asiento_id, /*1*/Asiento_Id_Ap };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genFechasAplicacion", parametros);

            genFechasAplicacionDS dsTipado = new genFechasAplicacionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
