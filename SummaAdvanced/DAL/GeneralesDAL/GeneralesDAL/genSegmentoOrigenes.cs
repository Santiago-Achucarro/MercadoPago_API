using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genSegmentoOrigenes
    {
        public static genSegmentoOrigenesDS Datos(short /*0*/pOrigeSeg_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pOrigeSeg_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genSegmentoOrigenesDatos", parametros);

            genSegmentoOrigenesDS dsTipado = new genSegmentoOrigenesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(short /*0*/pOrigeSeg_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableShort(/*0*/pOrigeSeg_id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genSegmentoOrigenesEliminar", parametros);
        }

        public static void Guardar(short /*0*/pOrigeSeg_id, string /*1*/pDescripcion, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pOrigeSeg_id, /*1*/pDescripcion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genSegmentoOrigenesGuardar", parametros);
        }



    }
}
