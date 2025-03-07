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
    public class comOCArticulo
    {
        public static comOCArticuloDS Datos(int /*0*/pcomOrdenComp, int /*1*/pRenglon_OC, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, /*1*/pRenglon_OC };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comOCArticuloDatos", parametros);

            string[] camposTabla0 = { "Producto_id", "DescripcionProductos", "Deposito_Id", "DescripcionDepositos" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comOCArticuloDS dsTipado = new comOCArticuloDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(int /*0*/pcomOrdenComp, int /*1*/pRenglon_OC, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, /*1*/ new Generalidades.NullableInt(pRenglon_OC) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comOCArticuloEliminar", parametros);
        }
        public static void Guardar(int /*0*/pcomOrdenComp, int /*1*/pRenglon_OC, string /*2*/pProducto_Id, 
            decimal /*3*/pFactor, decimal /*4*/pCantidadOriginal, decimal /*5*/pPrecioOriginal, string /*6*/pDeposito_Id,
            string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomOrdenComp, /*1*/pRenglon_OC, new Generalidades.NullableString(/*2*/pProducto_Id),
                /*3*/pFactor, /*4*/pCantidadOriginal, /*5*/pPrecioOriginal, new Generalidades.NullableString(/*6*/pDeposito_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comOCArticuloGuardar", parametros);

        }
    }
}
