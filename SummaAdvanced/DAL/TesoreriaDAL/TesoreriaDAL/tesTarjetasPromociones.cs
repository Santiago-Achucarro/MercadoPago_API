using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesoreriaDAL
{
    public class tesTarjetasPromociones
    {
        public static void Eliminar(string /*0*/pCartera_Id, int /*1*/pPromocion_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableString(/*0*/pCartera_Id), new Generalidades.NullableInt(/*1*/pPromocion_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("tesTarjetasPromocionesEliminar", parametros);
        }


        public static void Guardar(string /*0*/pCartera_Id, int /*1*/pPromocion_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id, /*1*/pPromocion_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("tesTarjetasPromocionesGuardar", parametros);
        }
    }
}
