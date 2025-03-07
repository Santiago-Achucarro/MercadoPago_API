using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venTipoMov
    {
        public static venTipoMovDS Datos(string /*0*/pvenTipoMov, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenTipoMov };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venTipoMovDatos", parametros);

            venTipoMovDS dsTipado = new venTipoMovDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(string /*0*/pvenTipoMov, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pvenTipoMov) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venTipoMovEliminar", parametros);
        }
        public static void Guardar(string /*0*/pvenTipoMov, string /*1*/pDescripcion, short /*2*/pSigno, string /*3*/pTipoMovResumido, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenTipoMov, /*1*/pDescripcion, /*2*/pSigno, /*3*/pTipoMovResumido };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venTipoMovGuardar", parametros);
        }
    }
}
