using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genMunicipios
    {

        public static genMunicipiosDS Datos(string /*0*/c_Municipio, string /*1*/Estado, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/c_Municipio, /*1*/Estado };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("genMunicipiosDatos", parametros);

            genMunicipiosDS dsTipado = new genMunicipiosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
