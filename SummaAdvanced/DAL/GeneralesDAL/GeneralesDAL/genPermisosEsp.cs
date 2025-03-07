using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using GeneralesCommon;
namespace GeneralesDAL
{
    public class genPermisosEsp
    {
        public static genPermisosEspDS Datos(int /*0*/pPermiso_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPermiso_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genPermisosEspDatos", parametros);

            genPermisosEspDS dsTipado = new genPermisosEspDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pPermiso_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pPermiso_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genPermisosEspEliminar", parametros);
        }

        public static void Guardar(int /*0*/pPermiso_Id, string /*1*/pDescripcion, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPermiso_Id, /*1*/pDescripcion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genPermisosEspGuardar", parametros);
        }

    }
}
