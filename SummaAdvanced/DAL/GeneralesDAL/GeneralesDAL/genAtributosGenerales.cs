using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genAtributosGenerales
    {
        public static genAtributosGeneralesDS Datos(int /*0*/pAtributoNro, string /*1*/pTabla_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAtributoNro, /*1*/pTabla_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genAtributosGeneralesDatos", parametros);

            genAtributosGeneralesDS dsTipado = new genAtributosGeneralesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(int /*0*/pAtributoNro, string /*1*/pTabla_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pAtributoNro), new Generalidades.NullableString(/*1*/pTabla_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genAtributosGeneralesEliminar", parametros);
        }

        public static void Guardar(int /*0*/pAtributoNro, string /*1*/pTabla_Id, string /*2*/pDescripcion, string /*3*/pTipo, bool /*4*/pEnGrilla, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAtributoNro, /*1*/pTabla_Id, /*2*/pDescripcion, /*3*/pTipo, /*4*/pEnGrilla };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genAtributosGeneralesGuardar", parametros);
        }


    }
}
