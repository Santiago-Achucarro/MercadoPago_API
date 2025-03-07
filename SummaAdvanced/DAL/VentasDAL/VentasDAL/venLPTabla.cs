using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
namespace VentasDAL
{
    public class venLPTabla
    {
        public static venLPTablaDS Datos(int /*0*/pTabla_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabla_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venLPTablaDatos", parametros);

            venLPTablaDS dsTipado = new venLPTablaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pTabla_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pTabla_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venLPTablaEliminar", parametros);
        }

        public static void Guardar(int /*0*/pTabla_Id, string /*1*/pDescripcion, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabla_Id, /*1*/pDescripcion };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venLPTablaGuardar", parametros);
        }



    }
}
