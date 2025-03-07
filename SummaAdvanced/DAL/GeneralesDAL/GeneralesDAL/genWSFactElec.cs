using GeneralesCommon;
using GeneralesDAL;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GeneralesDAL
{
    public class genWSFactElec
    {
        public static genWSFactElecDS Datos(string /*0*/pTipoFE, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTipoFE };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genWSFactElecDatos", parametros);

            genWSFactElecDS dsTipado = new genWSFactElecDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
