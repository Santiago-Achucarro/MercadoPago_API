using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprasDAL
{
    public class comMovProvDevengaCtas
    {
        public static void Eliminar(long /*0*/pcomMovProv, string /*1*/pCuenta_Id, string /*2*/pCentro1_Id, string /*3*/pCentro2_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, new Generalidades.NullableString(/*1*/pCuenta_Id), new Generalidades.NullableString(/*2*/pCentro1_Id), new Generalidades.NullableString(/*3*/pCentro2_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comMovProvDevengaCtasEliminar", parametros);
        }

        public static void Guardar(long /*0*/pcomMovProv, string /*1*/pCuenta_Id, string /*2*/pCentro1_Id, string /*3*/pCentro2_Id, decimal /*4*/pPorcentaje, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pCuenta_Id, /*2*/pCentro1_Id, /*3*/pCentro2_Id, /*4*/pPorcentaje };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comMovProvDevengaCtasGuardar", parametros);
        }
    }
}
