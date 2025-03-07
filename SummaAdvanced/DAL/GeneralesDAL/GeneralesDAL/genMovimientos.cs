using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;


namespace GeneralesDAL
{
    public class genMovimientos
    {
        public static genMovimientosDS Datos(long /*0*/pAsiento_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("genMovimientosDatos", parametros);

            string[] camposTabla0 = { "genEntidades", "ClieProv_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genMovimientosDS dsTipado = new genMovimientosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(long /*0*/pAsiento_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genMovimientosEliminar", parametros);
        }

        public static void Guardar(long /*0*/pAsiento_Id, long /*1*/pgenEntidades, short /*2*/pCantCuotas, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAsiento_Id,  new Generalidades.NullableInt64(/*1*/pgenEntidades), /*2*/pCantCuotas };
            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genMovimientosGuardar", parametros);
        }

        public static genMovimientosIntDS DatosInt(long /*0*/Asiento_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Asiento_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genMovimientosIntDatos", parametros);

            genMovimientosIntDS dsTipado = new genMovimientosIntDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
