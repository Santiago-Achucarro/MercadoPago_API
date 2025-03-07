using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ActivoFijoCommon;

namespace ActivoFijoDAL
{
    public class aficonMovCont
    {
        public static void AsiInsertar(long /*0*/pconAsientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pconAsientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("AficonMovcontAsiInsertar", parametros);
        }

        public static AficonMovcontDS Datos(long /*0*/pconAsientos, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pconAsientos, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("AficonMovcontDatos", parametros);

            string[] camposTabla0 = { "Empresa_Id", "ActivoFijo_Id", "DescripcionActivoFijo" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            AficonMovcontDS dsTipado = new AficonMovcontDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(long /*0*/pconAsientos, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pconAsientos, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("AficonMovcontEliminar", parametros);
        }

        public static void Guardar(long /*0*/pconAsientos, int /*1*/pRenglon, string /*2*/pActivoFijo_Id, bool /*3*/pInactivo, int /*4*/Empresa_Id, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pconAsientos, /*1*/pRenglon, new Generalidades.NullableString(/*2*/pActivoFijo_Id), /*3*/pInactivo, /*4*/Empresa_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("AficonMovcontGuardar", parametros);
        }

        public static AficonMovcontPendDS PendDatos(int /*0*/Empresa_id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("AficonMovcontPendDatos", parametros);

            string[] camposTabla0 = { "Comprobante" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            AficonMovcontPendDS dsTipado = new AficonMovcontPendDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





    }
}
