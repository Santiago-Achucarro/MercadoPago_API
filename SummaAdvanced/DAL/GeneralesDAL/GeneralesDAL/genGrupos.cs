using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genGrupos
    {
        public static genGruposPertenceDS Pertenece(string /*0*/Grupo_id, int /*1*/Usuario_id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Grupo_id, /*1*/Usuario_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genGruposPertence", parametros);

            string[] camposTabla0 = { "Pertenese" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genGruposPertenceDS dsTipado = new genGruposPertenceDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static genGruposDS Datos(string /*0*/Usuario_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Usuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genGruposDatos", parametros);

            string[] camposTabla0 = { "Posteado", "PTEmpresas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genGruposDS dsTipado = new genGruposDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





        public static void Eliminar(int /*0*/Grupo_Id, int /*1*/Usuario_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Grupo_Id, new Generalidades.NullableInt(/*1*/Usuario_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genGruposEliminar", parametros);
        }

        public static void Guardar(int /*0*/Usuario_Id, int /*1*/Grupo_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Usuario_Id, /*1*/Grupo_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genGruposGuardar", parametros);
        }



    }
}