using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesoreriaDAL
{
    public class tesRengMoviRetClie
    {
        public static void Eliminar(long /*0*/ptesMovimientos, int /*1*/pconRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, new Generalidades.NullableInt(/*1*/pconRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesRengMoviRetClieEliminar", parametros);
        }



        public static void Guardar(long /*0*/ptesMovimientos, int /*1*/pconRenglon, string /*2*/pSucursalRet,
            int /*3*/pComprobanteRet, decimal /*4*/pBaseImponible, decimal /*5*/pPorcentaje, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesMovimientos, /*1*/pconRenglon, /*2*/pSucursalRet, /*3*/pComprobanteRet,
                /*4*/pBaseImponible, /*5*/pPorcentaje };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesRengMoviRetClieGuardar", parametros);
        }
    }
}
