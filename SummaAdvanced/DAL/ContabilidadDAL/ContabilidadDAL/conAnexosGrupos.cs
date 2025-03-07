using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conAnexosGrupos
    {
        public static conAnexosGruposDS Datos(string /*0*/pGrupoAne_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pGrupoAne_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conAnexosGruposDatos", parametros);

            string[] camposTabla0 = { "Origen" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            conAnexosGruposDS dsTipado = new conAnexosGruposDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Guardar(string /*0*/pGrupoAne_Id, string /*1*/pDescripcion, int /*2*/pOrden, int /*3*/pOrigen, string /*4*/pDescription, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pGrupoAne_Id, /*1*/pDescripcion, /*2*/pOrden, /*3*/pOrigen, /*4*/pDescription };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conAnexosGruposGuardar", parametros);
        }



        public static void Eliminar(string /*0*/pGrupoAne_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pGrupoAne_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conAnexosGruposEliminar", parametros);
        }


    }
}
