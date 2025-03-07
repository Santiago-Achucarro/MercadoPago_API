using GeneralesCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GeneralesDAL
{
    public class genAplicaciones
    {
        public static genAplicacionesDS Datos(long /*0*/pAsiento_Id_Ap, short /*1*/pCuotaNro_Ap, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id_Ap, new Generalidades.NullableShort(/*1*/pCuotaNro_Ap) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genAplicacionesDatos", parametros);

            string[] camposTabla0 = { "Asiento_Id_Ap" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genAplicacionesDS dsTipado = new genAplicacionesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Aplicaciones.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
