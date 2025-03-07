using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genSaldosAnticipos
    {
        public static genSaldoAnticipoDS Datos(long /*0*/pAsiento_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genSaldoAnticipo", parametros);

            string[] camposTabla0 = { "Importe" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genSaldoAnticipoDS dsTipado = new genSaldoAnticipoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
