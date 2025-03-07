using GeneralesCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GeneralesDAL
{
    public class genTiposCompAfip
    {
        public static genTiposCompAfipDS Datos(int /*0*/pComprobante_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pComprobante_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genTiposCompAfipDatos", parametros);

            genTiposCompAfipDS dsTipado = new genTiposCompAfipDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
