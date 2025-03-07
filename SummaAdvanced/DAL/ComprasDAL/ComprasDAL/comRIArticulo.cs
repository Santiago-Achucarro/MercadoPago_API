using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using ComprasCommon;

namespace ComprasDAL
{
    public class comRIArticulo
    {
        public static void Eliminar(int /*0*/pcomReqInterno, int /*1*/pRenglon_RI, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomReqInterno, /*1*/new Generalidades.NullableInt(pRenglon_RI) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);
            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comRIArticuloEliminar", parametros);
        }

        public static void Guardar(int /*0*/pcomReqInterno, int /*1*/pRenglon_RI, string /*2*/pProducto_Id, decimal /*3*/pFactor, decimal /*4*/pCantidadOriginal, decimal /*5*/pPrecioOriginal, string /*6*/pDeposito_Id, string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomReqInterno, /*1*/pRenglon_RI, new Generalidades.NullableString(/*2*/pProducto_Id), /*3*/pFactor, /*4*/pCantidadOriginal, /*5*/pPrecioOriginal, new Generalidades.NullableString(/*6*/pDeposito_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comRIArticuloGuardar", parametros);
        }

        public static comRIArticuloDS Datos(int /*0*/pcomReqInterno, int /*1*/pRenglon_RI, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomReqInterno, new Generalidades.NullableInt(/*1*/pRenglon_RI) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comRIArticuloDatos", parametros);

            string[] camposTabla0 = { "Observaciones", "Cuenta_Id", "DescripcionCuentas", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Medida_Id", "DescripcionUniMed", "Producto_Id", "DescripcionProductos", "Deposito_Id", "DescripcionDepositos" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comRIArticuloDS dsTipado = new comRIArticuloDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
