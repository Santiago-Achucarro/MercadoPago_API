using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL  
{
    public class stkCFVenImp
    {

        public static void Eliminar(string /*0*/pCondFisc_id, string /*1*/pvenImpuestos, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCondFisc_id, new Generalidades.NullableString(/*1*/pvenImpuestos) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkCFVenImpEliminar", parametros);
        }


        public static void Insertar(int /*0*/pstkCondFisVenta, string /*1*/pvenImpuestos, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkCondFisVenta, /*1*/pvenImpuestos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkCFVenImpInsertar", parametros);
        }

    }
}
