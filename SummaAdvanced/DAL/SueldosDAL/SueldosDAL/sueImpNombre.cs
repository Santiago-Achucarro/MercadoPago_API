using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;
namespace SueldosDAL
{
    public class sueImpNombre
    {
        public static sueImpNombreDS Datos(int /*0*/pImporte_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pImporte_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueImpNombreDatos", parametros);

            string[] camposTabla0 = { "Usuario_Id", "DescripcionUsuario" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            sueImpNombreDS dsTipado = new sueImpNombreDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pImporte_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pImporte_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueImpNombreEliminar", parametros);
        }

        public static void Guardar(int /*0*/pImporte_Id, string /*1*/pDescripcion, int /*2*/pUsuario_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pImporte_Id, /*1*/pDescripcion, new Generalidades.NullableInt(/*2*/pUsuario_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueImpNombreGuardar", parametros);
        }

    }
}
