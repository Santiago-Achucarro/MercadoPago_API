using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conSituPatri
    {
        public static conSituPatriDS Datos(string /*0*/pRubro_Balance, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pRubro_Balance };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conSituPatriDatos", parametros);

            conSituPatriDS dsTipado = new conSituPatriDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(string /*0*/pRubro_Balance, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pRubro_Balance) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conSituPatriEliminar", parametros);
        }

        public static void Guardar(string /*0*/pRubro_Balance, string /*1*/pRubro_Id, string /*2*/pDescripcion, int /*3*/pOrden, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pRubro_Balance, /*1*/pRubro_Id, /*2*/pDescripcion, /*3*/pOrden };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conSituPatriGuardar", parametros);
        }
    }
}
