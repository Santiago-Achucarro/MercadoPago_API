using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using interfaceDAAB;
using ComprasCommon;


namespace ComprasDAL
{
    public class comMovPOC
    {
        public static comMovPOCDS Datos(long /*0*/pcomMovProv, int /*1*/pcomOrdenComp, int /*2*/pRenglon_OC, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pcomOrdenComp, new Generalidades.NullableInt(/*2*/pRenglon_OC) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comMovPOCDatos", parametros);

            string[] camposTabla0 = { "Producto_id", "Detalle" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comMovPOCDS dsTipado = new comMovPOCDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(long /*0*/pcomMovProv, int /*1*/pcomOrdenComp, int /*2*/pRenglon_OC, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pcomOrdenComp, /*2*/pRenglon_OC };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comMovPOCEliminar", parametros);
        }
        public static void Guardar(long /*0*/pcomMovProv, int /*1*/pcomOrdenComp, int /*2*/pRenglon_OC, decimal /*3*/pCantidad, decimal /*4*/pCantidadOriginal, decimal /*5*/pFactor, decimal /*6*/pCambio, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pcomOrdenComp, /*2*/pRenglon_OC, /*3*/pCantidad, /*4*/pCantidadOriginal, /*5*/pFactor, /*6*/pCambio };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comMovPOCInsertar", parametros);
        }


    }
}
