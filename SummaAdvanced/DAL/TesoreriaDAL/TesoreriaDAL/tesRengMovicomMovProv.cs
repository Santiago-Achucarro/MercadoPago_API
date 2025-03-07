using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesoreriaCommon;
using interfaceDAAB;
using System.Data;

namespace TesoreriaDAL
{
    public class tesRengMovicomMovProv
    {
        public static tesRengMovicomMovProvDS Datos(long /*0*/ptesMovimientos, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesRengMovicomMovProvDatos", parametros);

            tesRengMovicomMovProvDS dsTipado = new tesRengMovicomMovProvDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/ptesMovimientos, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesRengMovicomMovProvEliminar", parametros);
        }

        public static void Guardar(long /*0*/ptesMovimientos, int /*1*/pRenglon, long /*2*/pcomMovProv, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, /*1*/pRenglon, /*2*/pcomMovProv };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesRengMovicomMovProvGuardar", parametros);
        }
        public static tesRengMovicomMovProvDS DatosXcomMovProv(long /*0*/pcomMovProv, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesRengMovicomMovProvDatosXcomMovProv", parametros);

            string[] camposTabla0 = { "comMovProv" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            tesRengMovicomMovProvDS dsTipado = new tesRengMovicomMovProvDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
