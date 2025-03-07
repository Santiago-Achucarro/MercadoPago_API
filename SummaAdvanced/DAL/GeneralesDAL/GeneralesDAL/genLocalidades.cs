using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genLocalidades
    {
        public static genLocalidadesDS Datos(string /*0*/c_Localidad, string /*1*/Estado, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/c_Localidad, /*1*/Estado };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("genLocalidadesDatos", parametros);

            genLocalidadesDS dsTipado = new genLocalidadesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
