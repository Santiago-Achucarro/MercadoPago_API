using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using ComprasCommon;

namespace ComprasDAL
{
    public class comPFXDatos
    {
        public static comPFXDS Datos(int /*0*/pEmpresa_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comPFXDatos", parametros);

            string[] camposTabla0 = { "ArchivoPFX", "ClavePFX" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comPFXDS dsTipado = new comPFXDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
