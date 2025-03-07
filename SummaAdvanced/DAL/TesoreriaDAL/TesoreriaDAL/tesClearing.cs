using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesClearing
    {
        public static tesClearingDS Datos(string /*0*/pClearing, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pClearing };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesClearingDatos", parametros);

            tesClearingDS dsTipado = new tesClearingDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(string /*0*/pClearing, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pClearing) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesClearingEliminar", parametros);
        }
        public static void Guardar(string /*0*/pClearing, string /*1*/pDescripcion, int /*2*/pDias, string /*3*/pcVariable, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pClearing, /*1*/pDescripcion, /*2*/pDias, /*3*/pcVariable };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesClearingGuardar", parametros);
        }
    }
}
