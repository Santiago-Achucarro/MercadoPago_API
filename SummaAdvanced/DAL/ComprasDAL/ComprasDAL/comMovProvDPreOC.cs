using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using ComprasCommon;

namespace ComprasDAL
{
    public class comMovProvDPreOC
    {

        public static comMovProvDPreOCDS Datos(long /*0*/pcomMovProv, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comMovProvDPreOCDatos", parametros);

            string[] camposTabla0 = { "comMovProvFactOrig", "comOrdenComp", "Renglon_OC" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comMovProvDPreOCDS dsTipado = new comMovProvDPreOCDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pcomMovProv, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comMovProvDPreOCEliminar", parametros);
        }

        public static void Insertar(long /*0*/pcomMovProv, int /*1*/pRenglon, long /*2*/pcomMovProvFactOrig, int /*3*/pcomOrdenComp, int /*4*/pRenglon_OC, decimal /*5*/pCantidadOriginal, decimal /*6*/pCantidad, decimal /*7*/pDescuento, decimal /*8*/pMonto, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pRenglon, /*2*/pcomMovProvFactOrig, /*3*/pcomOrdenComp, /*4*/pRenglon_OC, /*5*/pCantidadOriginal, /*6*/pCantidad, /*7*/pDescuento, /*8*/pMonto };

            //Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comMovProvDPreOCInsertar", parametros);
        }


    }
}
