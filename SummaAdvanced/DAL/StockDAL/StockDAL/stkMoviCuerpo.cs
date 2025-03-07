using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkMoviCuerpo
    {
        public static stkMoviCuerpoDS Datos(long /*0*/pstkMoviCabe, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkMoviCuerpoDatos", parametros);

            string[] camposTabla0 = { "Deposito_Id", "DescripcionDepositos", "Producto_Id", "DescripcionProductos", "Medida_Id",
                "DescripcionUniMed", "MedidaAlterna", "DescripcionMedidaAlterna", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stkMoviCuerpoDS dsTipado = new stkMoviCuerpoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pstkMoviCabe, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkMoviCuerpoEliminar", parametros);
        }

        public static void Guardar(long /*0*/pstkMoviCabe, int /*1*/pRenglon, DateTime /*2*/pFecha,
            string /*3*/pDeposito_Id, string /*4*/pProducto_Id, string /*5*/pMedida_Id, decimal /*6*/pFactor,
            decimal /*7*/pCantidad, decimal /*8*/pCantidadForm, decimal /*9*/pCostoUnitario,
            decimal /*10*/pPrecioOriginal, string /*11*/pMedidaAlterna, decimal /*12*/pCantidadalternaForm,
            string /*13*/pObservaciones, decimal /*14*/pDescuento, int /*15*/pconRenglonDebe,
            int /*16*/pconRenglonHaber, string /*17*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pRenglon, /*2*/pFecha,
                new Generalidades.NullableString(/*3*/pDeposito_Id), new Generalidades.NullableString(/*4*/pProducto_Id),
                new Generalidades.NullableString(/*5*/pMedida_Id), /*6*/pFactor, /*7*/pCantidad, /*8*/pCantidadForm,
                /*9*/pCostoUnitario, /*10*/pPrecioOriginal, new Generalidades.NullableString(/*11*/pMedidaAlterna)
                , /*12*/pCantidadalternaForm, new Generalidades.NullableString(/*13*/pObservaciones),
                /*14*/pDescuento, /*15*/pconRenglonDebe, /*16*/pconRenglonHaber };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkMoviCuerpoGuardar", parametros);
        }

        public static void CambiarCosto(long /*0*/pstkMoviCabe, int /*1*/pRenglon, decimal /*2*/pCosto, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pRenglon, /*2*/pCosto };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkMoviCuerpoCambiarCosto", parametros);
        }
    }
}
