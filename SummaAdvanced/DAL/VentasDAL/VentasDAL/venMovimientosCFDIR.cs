using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venMovimientosCFDIR
    {
        public static void Eliminar(long /*0*/pvenMovimientos, long /*1*/pvenMovimientosR, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {new Generalidades.NullableLong(/*0*/pvenMovimientos),
                new Generalidades.NullableLong( /*1*/pvenMovimientosR)};

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venMovimientosCFDIREliminar", parametros);
        }

        public static void Guardar(long /*0*/pvenMovimientos, long /*1*/pvenMovimientosR, string /*2*/pTipoRelacion,
            string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pvenMovimientosR,
                new Generalidades.NullableString(/*2*/pTipoRelacion) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venMovimientosCFDIRGuardar", parametros);
        }
    }
}
