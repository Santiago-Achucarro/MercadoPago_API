using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class sueVarGlobales
    {
        public static sueVarGlobalesDS Datos(int /*0*/pVarGlobal_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pVarGlobal_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("sueVarGlobalesDatos", parametros);

            string[] camposTabla0 = { "Usuario_Id", "DescripcionUsuario", "Codigo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            sueVarGlobalesDS dsTipado = new sueVarGlobalesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static void Eliminar(int /*0*/pVarGlobal_Id, string /*1*/ pAuxiliar)
    {
        Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pVarGlobal_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueVarGlobalesEliminar", parametros);
        }

    public static void Guardar(int /*0*/pVarGlobal_Id, string /*1*/pDescripcion, bool /*2*/pPorEmpresa, int /*3*/pUsuario_Id, string /*4*/pCodigo, string /*5*/ pAuxiliar)
    {
        Object[] parametros = new Object[] {/*0*/pVarGlobal_Id, /*1*/pDescripcion, /*2*/pPorEmpresa, new Generalidades.NullableInt(/*3*/pUsuario_Id), /*4*/pCodigo };

        Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

        interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

        oiDAAB.guardar("sueVarGlobalesGuardar", parametros);
    }


    public static bool Editable(int /*0*/pVarGlobal, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pVarGlobal };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((bool)oiDAAB.guardar("sueVarGlobalesEditable", parametros));
        }

    }
}
