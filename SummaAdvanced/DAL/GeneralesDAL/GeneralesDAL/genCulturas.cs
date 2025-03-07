using GeneralesCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GeneralesDAL
{
    public class genCulturas
    {
        public static genCulturasDS Datos(string /*0*/pCultura, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCultura };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genCulturasDatos", parametros);

            genCulturasDS dsTipado = new genCulturasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
