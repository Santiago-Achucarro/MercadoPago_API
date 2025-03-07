using GeneralesCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GeneralesDAL
{
    public class genFavoritosUsuarios
    {

        public static genFavoritosUsuariosDS Datos(int /*0*/pUsuario_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genFavoritosUsuariosDatos", parametros);

            genFavoritosUsuariosDS dsTipado = new genFavoritosUsuariosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Formularios.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pUsuario_Id, string /*1*/pFormulario_id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_Id, /*1*/pFormulario_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genFavoritosUsuariosEliminar", parametros);
        }

        public static void Guardar(int /*0*/pUsuario_Id, string /*1*/pFormulario_id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_Id, /*1*/pFormulario_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genFavoritosUsuariosGuardar", parametros);
        }



    }
}
