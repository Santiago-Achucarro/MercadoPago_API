using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genTamanioHoja
    {
        public static genTamanioHojaDS Datos(string /*0*/pTamanioHoja, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTamanioHoja };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genTamanioHojaDatos", parametros);

            genTamanioHojaDS dsTipado = new genTamanioHojaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
