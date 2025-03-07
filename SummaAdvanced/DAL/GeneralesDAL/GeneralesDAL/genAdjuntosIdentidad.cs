using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genAdjuntosIdentidad
    {

        public static genAdjuntosIdentidadDS Datos(string /*0*/pTabla_Id, long /*1*/pIdentity_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabla_Id, /*1*/pIdentity_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genAdjuntosIdentityDevolverDatos", parametros);

            string[] camposTabla1 = { "ArchivoBase64", "Estado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            genAdjuntosIdentidadDS dsTipado = new genAdjuntosIdentidadDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Adjuntos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);

        }


    }
}
