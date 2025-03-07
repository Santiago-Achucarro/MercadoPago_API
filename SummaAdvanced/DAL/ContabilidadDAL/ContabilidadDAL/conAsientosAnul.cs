using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using ContabilidadCommon;
using System.Data;

namespace ContabilidadDAL
{
    public class conAsientosAnul
    {
        public static conAsientosAnulDS Datos(long /*0*/pAsiento_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("conAsientosAnulDatos", parametros);

            string[] camposTabla0 = { "Causa" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            conAsientosAnulDS dsTipado = new conAsientosAnulDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(long /*0*/pAsiento_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conAsientosAnulEliminar", parametros);
        }

        public static void Guardar(long /*0*/pAsiento_Id, int /*1*/pUsuario_Id, string /*2*/pTipoEnvio, string /*3*/pCausa, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id, /*1*/pUsuario_Id, /*2*/pTipoEnvio, new Generalidades.NullableString(/*3*/pCausa) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conAsientosAnulGuardar", parametros);
        }





    }
}
