using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using VentasCommon;

namespace VentasDAL
{
    public class venIncoterm
    {
        public static venIncotermDS Datos(string /*0*/pIncoterm_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pIncoterm_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venIncotermDatos", parametros);

            string[] camposTabla1 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            venIncotermDS dsTipado = new venIncotermDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(string /*0*/pIncoterm_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pIncoterm_id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venIncotermEliminar", parametros);
        }
        public static int Guardar(string /*0*/pIncoterm_id, string /*1*/pIncoterm_id_Nuevo, string /*2*/pDescripcion, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pIncoterm_id, /*1*/pIncoterm_id_Nuevo, /*2*/pDescripcion };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("venIncotermGuardar", parametros);
        }
    }
}
