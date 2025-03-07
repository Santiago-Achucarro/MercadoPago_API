using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ActivoFijoCommon;
namespace ActivoFijoDAL
{
    public class AfiMovimientos
    {
        public static AfiMovimientosDS Datos(int /*0*/pAfiActivoFijo, int /*1*/pRenglon, long /*2*/pconAsientos, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pAfiActivoFijo), new Generalidades.NullableInt(/*1*/pRenglon), /*2*/pconAsientos };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("AfiMovimientosDatos", parametros);

            string[] camposTabla0 = { "DescripcionActivoFijo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            AfiMovimientosDS dsTipado = new AfiMovimientosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(int /*0*/pAfiActivoFijo, int /*1*/pRenglon, long /*2*/pconAsientos, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pAfiActivoFijo), new Generalidades.NullableInt(/*1*/pRenglon), /*2*/pconAsientos };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("AfiMovimientosEliminar", parametros);
        }

        public static void Guardar(int /*0*/pAfiActivoFijo, int /*1*/pRenglon, long /*2*/pconAsientos, string /*3*/pTipoMov, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pAfiActivoFijo, /*1*/pRenglon, /*2*/pconAsientos, /*3*/pTipoMov };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("AfiMovimientosGuardar", parametros);
        }



    }
}
