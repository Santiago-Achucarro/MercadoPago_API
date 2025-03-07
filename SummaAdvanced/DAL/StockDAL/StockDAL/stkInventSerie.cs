using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockDAL
{
    public class stkInventSerie
    {
        public static void Eliminar(int /*0*/pstkInventarios, string /*1*/pProducto_Id, string /*2*/pSerie, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkInventarios, new Generalidades.NullableString(/*1*/pProducto_Id), new Generalidades.NullableString(/*2*/pSerie) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkInventSerieEliminar", parametros);
        }

        public static void Insertar(int /*0*/pstkInventarios, string /*1*/pProducto_Id, string /*2*/pSerie, decimal /*3*/pCantidad, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkInventarios, /*1*/pProducto_Id, /*2*/pSerie, /*3*/pCantidad };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkInventSerieGuardar", parametros);
        }
    }
}
