using ComprasCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ComprasDAL
{
   public class comFactuReceStk
    {
        public static void Eliminar(long /*0*/pcomMovProv, int /*1*/pcomOrdenComp, int /*2*/pRenglon_OC, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, new Generalidades.NullableInt(/*1*/pcomOrdenComp),
                new Generalidades.NullableInt(/*2*/pRenglon_OC) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comFactuReceStkEliminar", parametros);
        }

        public static void Guardar(long /*0*/pcomMovProv, int /*1*/pcomOrdenComp, int /*2*/pRenglon_OC, long /*3*/pstkMoviCabe, 
            int /*4*/pRenglon, decimal pCantidad, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pcomOrdenComp, /*2*/pRenglon_OC, /*3*/pstkMoviCabe,
                /*4*/pRenglon, pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comFactuReceStkGuardar", parametros);
        }

        public static comFactuReceStkDS CalcularPendiente(int /*0*/pcomOrdenComp, int /*1*/pRenglon_OC, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, /*1*/pRenglon_OC };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comFactuReceStkCalcularPendiente", parametros);

            string[] camposTabla0 = { "comMovProv" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comFactuReceStkDS dsTipado = new comFactuReceStkDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Recepciones.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static comFactuReceStkDS Datos(long /*0*/pcomMovProv, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comFactuReceStkDatos", parametros);

            string[] camposTabla0 = { "comMovProv" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comFactuReceStkDS dsTipado = new comFactuReceStkDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Recepciones.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

    }
}
