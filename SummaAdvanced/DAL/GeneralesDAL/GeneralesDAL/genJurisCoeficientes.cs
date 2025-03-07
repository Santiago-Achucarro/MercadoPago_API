using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralesDAL
{
    public class genJurisCoeficientes
    {
        public static void Eliminar(long /*0*/pgenEntidades, string /*1*/pJuris_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pgenEntidades, new Generalidades.NullableString(/*1*/pJuris_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("genJurisCoeficientesEliminar", parametros);
        }

        public static void Guardar(long /*0*/pgenEntidades, string /*1*/pJuris_Id, string /*2*/pSituacion, 
            decimal /*3*/pCoeficiente, decimal /*4*/pExencion, DateTime /*5*/pFechaHasta, string /*6*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pgenEntidades, /*1*/pJuris_Id, /*2*/pSituacion, /*3*/pCoeficiente,
                /*4*/pExencion, new Generalidades.NullableDate(/*5*/pFechaHasta) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genJurisCoeficientesGuardar", parametros);
        }
    }
}
