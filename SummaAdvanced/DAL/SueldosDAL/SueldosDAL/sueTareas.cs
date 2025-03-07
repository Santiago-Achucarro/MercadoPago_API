using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class sueTareas
    {
        public static sueTareasDS Datos(string /*0*/pTarea_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTarea_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueTareasDatos", parametros);

            string[] camposTabla0 = { "Usuario_Id", "DescripcionUsuario" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            sueTareasDS dsTipado = new sueTareasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pTarea_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pTarea_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueTareasEliminar", parametros);
        }

        public static void Guardar(string /*0*/pTarea_Id, string /*1*/pTarea_Id_Nuevo, string /*2*/pDescripcion, bool /*3*/pInactivo, bool /*4*/pPosteado, int /*5*/pUsuario_Id, int /*6*/pEmpresas, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTarea_Id, /*1*/pTarea_Id_Nuevo, /*2*/pDescripcion, /*3*/pInactivo, /*4*/pPosteado, new Generalidades.NullableInt(/*5*/pUsuario_Id), /*6*/pEmpresas };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueTareasGuardar", parametros);
        }

    }
}
