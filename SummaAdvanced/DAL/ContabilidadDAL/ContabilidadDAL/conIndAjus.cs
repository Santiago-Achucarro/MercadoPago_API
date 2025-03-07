using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using ContabilidadCommon;
using System.Data;

namespace ContabilidadDAL
{
    public class conIndAjus
    {
        public static conIndAjusDS Datos(string /*0*/pIndice_Id, short /*1*/pEjercicio, int /*2*/pEmpresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pIndice_Id, /*1*/pEjercicio, /*2*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conIndAjusDatos", parametros);

            string[] camposTabla0 = { "Ejercicio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Indice_Id", "Indice", "DescripcionEmpresa" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            conIndAjusDS dsTipado = new conIndAjusDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pIndice_Id, short /*1*/pEjercicio, int /*2*/pEmpresa, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pIndice_Id, new Generalidades.NullableShort(/*1*/pEjercicio), /*2*/pEmpresa };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conIndAjusEliminar", parametros);
        }

        public static void Guardar(string /*0*/pIndice_Id, string /*1*/pDescripcion, decimal /*2*/pIndice, short /*3*/pEjercicio, int /*4*/pEmpresa, short /*5*/pPeriodo, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pIndice_Id, /*1*/pDescripcion, /*2*/pIndice, /*3*/pEjercicio, /*4*/pEmpresa, /*5*/pPeriodo };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conIndAjusGuardar", parametros);
        }


    }
}
