using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasDAL
{
    public class venMovConStockCrCtas
    {
        public static void Eliminar(long /*0*/pvenMovimientos, int /*1*/pRenglonCuerpo, int /*2*/pRenglon, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, new Generalidades.NullableInt(/*1*/pRenglonCuerpo), new Generalidades.NullableInt(/*2*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venMovConStockCrCtasEliminar", parametros);
        }

        public static void Guardar(long /*0*/pvenMovimientos, int /*1*/pRenglonCuerpo, int /*2*/pRenglon, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pRenglonCuerpo, /*2*/pRenglon };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venMovConStockCrCtasGuardar", parametros);
        }
    }
}
