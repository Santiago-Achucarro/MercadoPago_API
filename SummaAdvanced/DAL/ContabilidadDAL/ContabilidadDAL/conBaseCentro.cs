using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ContabilidadCommon;

namespace ContabilidadDAL
{
    public class conBaseCentro
    {

        public static void Eliminar(int /*0*/pBase_Id, int /*1*/pCentro1_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pBase_Id, new Generalidades.NullableInt(/*1*/pCentro1_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("conBaseCentroEliminar", parametros);
        }

        public static void Guardar(int /*0*/pBase_Id, int /*1*/pCentro1_Id, decimal /*2*/pValor, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pBase_Id, /*1*/pCentro1_Id, /*2*/pValor };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("conBaseCentroGuardar", parametros);
        }
    }
}
