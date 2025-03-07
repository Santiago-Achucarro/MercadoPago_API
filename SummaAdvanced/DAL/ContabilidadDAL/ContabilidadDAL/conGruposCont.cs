using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conGruposCont
    {
        public static conGruposContDS Datos(string /*0*/pGrupo_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pGrupo_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conGruposContDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "PTodasEmpresas" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            conGruposContDS dsTipado = new conGruposContDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCentros.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





        public static void Eliminar(string /*0*/pGrupo_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pGrupo_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conGruposContEliminar", parametros);
        }

        public static int Guardar(string /*0*/pGrupo_Id, string /*1*/pGrupo_Id_Nuevo, int /*2*/pEmpresa_Id, string /*3*/pDescripcion, bool /*4*/pInactivo, int /*5*/pUsuario_Id, bool /*6*/pPosteado, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pGrupo_Id, /*1*/pGrupo_Id_Nuevo, /*2*/new Generalidades.NullableInt(pEmpresa_Id), /*3*/pDescripcion, /*4*/pInactivo, /*5*/pUsuario_Id, /*6*/pPosteado };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("conGruposContGuardar", parametros);
        }


    }
}
