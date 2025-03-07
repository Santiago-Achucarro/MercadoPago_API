using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComprasDAL
{
    public class comPagosHabilitados
    {

        public static void Eliminar(string /*0*/pProveed_Id, int /*1*/pEmpresa_Id, int /*2*/pSecuencia, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pProveed_Id, /*1*/pEmpresa_Id, new Generalidades.NullableInt(/*2*/pSecuencia) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comPagosHabilitadosEliminar", parametros);
        }

        public static void Guardar(long /*0*/pcomMovProv, int /*1*/pSecuencia, int /*2*/pUsuario_Id,
            DateTime /*3*/pFechaHabilitacion, decimal /*4*/pImporteHabilitado, long /*5*/ptesMovimientos, 
            decimal /*6*/pImporte1, decimal /*7*/pImporte2, decimal /*8*/pImporte3, string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv, /*1*/pSecuencia, /*2*/pUsuario_Id, /*3*/pFechaHabilitacion,
                /*4*/pImporteHabilitado, new Generalidades.NullableLong(/*5*/ptesMovimientos), /*6*/pImporte1, /*7*/pImporte2,
                /*8*/pImporte3 };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comPagosHabilitadosGuardar", parametros);
        }


        /// <summary>
        /// Vuelve a Marcar como Habilitado un pago por cancelacion marca las 2 tablas
        /// </summary>
        /// <param name="pTesMovimientos"></param>
        /// <param name="pAuxiliar"></param>
        public static void VolveraHabilitar(long /*0*/pTesMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTesMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comPagosHabilitadosVolveraHabi", parametros);
        }

        public static void EliminarFact(long /*0*/pcomMovProv, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomMovProv };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comPagosHabilitadosEliminarFact", parametros);
        }
    }
}
