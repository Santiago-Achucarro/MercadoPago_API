using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComprasDAL
{
    public class comProveedoresRetencion
    {
        public static void Eliminar(long /*0*/pProveed_Id, string /*1*/pCartera_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProveed_Id, new Generalidades.NullableString(/*1*/pCartera_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comProveedoresRetencionEliminar", parametros);
        }

        public static void Guardar(long /*0*/pProveed_Id, string /*1*/pCartera_Id, decimal /*2*/pExencion, 
            DateTime /*3*/pFechaHasta, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProveed_Id, /*1*/pCartera_Id, /*2*/pExencion,
                new Generalidades.NullableDate(/*3*/pFechaHasta) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comProveedoresRetencionGuardar", parametros);
        }
    }
}
