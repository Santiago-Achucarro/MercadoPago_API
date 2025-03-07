using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkInventCuerpo
    {
        public static void Eliminar(int /*0*/pstkInventarios, string /*1*/pProducto_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkInventarios, new Generalidades.NullableString(/*1*/pProducto_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkInventCuerpoEliminar", parametros);
        }

        public static void Insertar(int /*0*/pstkInventarios, string /*1*/pProducto_Id, decimal /*2*/pCantidad, decimal /*3*/pCantidadAlterna, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkInventarios, /*1*/pProducto_Id, /*2*/pCantidad, /*3*/pCantidadAlterna };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkInventCuerpoInsertar", parametros);
        }

        public static void Eliminar(int /*0*/pstkInventarios, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkInventarios };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkInventCuerpoEliminar", parametros);
        }


    }
}
