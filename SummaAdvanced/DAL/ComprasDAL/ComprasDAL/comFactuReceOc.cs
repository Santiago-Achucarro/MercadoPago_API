using ComprasCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ComprasDAL
{
    public class comFactuReceOc
    {
        public static void Eliminar(long /*0*/pcomMovProv, int /*1*/pcomOrdenComp, int /*2*/pRenglon_OC, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, new Generalidades.NullableInt(/*1*/pcomOrdenComp),
                new Generalidades.NullableInt(/*2*/pRenglon_OC) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comFactuReceOcEliminar", parametros);
        }


        public static void Guardar(long /*0*/pcomMovProv, int /*1*/pcomOrdenComp, int /*2*/pRenglon_OC, long /*3*/pcomOcRecepcion,
            int /*4*/pconRenglon, decimal pCantidad, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pcomOrdenComp, /*2*/pRenglon_OC, /*3*/pcomOcRecepcion,
                /*4*/pconRenglon, pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comFactuReceOcGuardar", parametros);
        }


        public static comFactuReceOcDS CalcularPendiente(int /*1*/pcomOrdenComp, int /*2*/pRenglon_OC, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {pcomOrdenComp, pRenglon_OC };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comFactuReceOcCalcularPendiente", parametros);

            string[] camposTabla0 = { "comMovProv", "comOrdenComp", "Renglon_OC" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Renglon_OC" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            comFactuReceOcDS dsTipado = new comFactuReceOcDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Recepciones.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);

        }

        public static comFactuReceOcDS Datos(long /*0*/pcomMovProv, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comFactuReceOcDatos", parametros);

            string[] camposTabla0 = { "comMovProv" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comFactuReceOcDS dsTipado = new comFactuReceOcDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Recepciones.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

    }
}
