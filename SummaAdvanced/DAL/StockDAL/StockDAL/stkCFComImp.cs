using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkCFComImp
    {

        public static void Eliminar(string /*0*/pCFComp_id, string /*1*/pcomImpuestos, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCFComp_id, new Generalidades.NullableString(/*1*/pcomImpuestos) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkCFComImpEliminar", parametros);
        }


        public static void Insertar(int /*0*/pstkCondFisCompra, string /*1*/pcomImpuestos, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkCondFisCompra, /*1*/pcomImpuestos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkCFComImpInsertar", parametros);
        }


    }
}
