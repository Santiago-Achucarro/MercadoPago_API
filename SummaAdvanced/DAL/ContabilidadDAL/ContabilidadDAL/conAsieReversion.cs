using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conAsieReversion
    {
        public static conAsieReversionDS Datos(long /*0*/pAsiento_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("conAsieReversionDatos", parametros);

            conAsieReversionDS dsTipado = new conAsieReversionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(long /*0*/pAsiento_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conAsieReversionEliminar", parametros);
        }
        public static void Guardar(long /*0*/pAsiento_Id, long /*1*/pAsiento_Rever, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pAsiento_Rever };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conAsieReversionGuardar", parametros);
        }
     }
}
