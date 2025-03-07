using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;

namespace ProduccionDAL
{
    public class proCausas
    {
        public static proCausasDS Datos(string /*0*/pCausa_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCausa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proCausasDatos", parametros);

            string[] camposTabla0 = { "Usuario_Id", "DescripcionUsuario" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            proCausasDS dsTipado = new proCausasDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pCausa_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCausa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("proCausasEliminar", parametros);
        }

        public static int Guardar(string /*0*/pCausa_Id, string /*1*/pCausa_Id_Nueva, string /*2*/pDescripcion, bool /*3*/pInactivo, bool /*4*/pPosteado, int /*5*/pUsuario_Id, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCausa_Id, /*1*/pCausa_Id_Nueva, /*2*/pDescripcion, /*3*/pInactivo, /*4*/pPosteado, new Generalidades.NullableInt(/*5*/pUsuario_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

           return (int) oiDAAB.guardar("proCausasGuardar", parametros);
        }


    }
}
