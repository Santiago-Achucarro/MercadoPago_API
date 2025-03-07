using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContabilidadCommon;
using System.Data;
using interfaceDAAB;

namespace ContabilidadDAL
{
    public class conAnexosOrigenes
    {
        public static conAnexosOrigenesDS Datos(short /*0*/pOrigen, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pOrigen };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conAnexosOrigenesDatos", parametros);

            conAnexosOrigenesDS dsTipado = new conAnexosOrigenesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(short /*0*/pOrigen, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableShort(/*0*/pOrigen) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conAnexosOrigenesEliminar", parametros);
        }


        public static void Guardar(short /*0*/pOrigen, string /*1*/pDescripcion, string /*2*/pTipoRubro, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pOrigen, /*1*/pDescripcion, /*2*/pTipoRubro };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conAnexosOrigenesGuardar", parametros);
        }


    }
}
