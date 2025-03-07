using ContabilidadCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ContabilidadDAL
{
    public class conIndicesAjustes
    {
        public static conIndicesAjustesDS Datos(string /*0*/pIndice_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pIndice_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conIndicesAjustesDatos", parametros);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            conIndicesAjustesDS dsTipado = new conIndicesAjustesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pIndice_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pIndice_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conIndicesAjustesEliminar", parametros);
        }

        public static int Guardar(string /*0*/pIndice_Id, string /*1*/pIndice_Id_Nuevo, string /*2*/pDescripcion, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pIndice_Id, /*1*/pIndice_Id_Nuevo, /*2*/pDescripcion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("conIndicesAjustesGuardar", parametros));
        }
    }
}
