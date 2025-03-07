using GeneralesCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GeneralesDAL
{
    public class genUltPaginasVisitadasUsuarios
    {
        
        public static genUltPaginasVisitadasUsuariosDS Datos(int /*0*/pUsuario_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genUltPaginasVisitadasUsuariosDatos", parametros);

            genUltPaginasVisitadasUsuariosDS dsTipado = new genUltPaginasVisitadasUsuariosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Formularios.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pUsuario_Id, string /*1*/pFormulario_id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_Id, /*1*/pFormulario_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genUltPaginasVisitadasUsuariosEliminar", parametros);
        }


        public static void Guardar(int /*0*/pUsuario_Id, string /*1*/pFormulario_id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pUsuario_Id, /*1*/pFormulario_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genUltPaginasVisitadasUsuariosGuardar", parametros);
        }

    }
}
