using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockDAL
{
    public class stkSolicitudCuerpo
    {
        public static void Eliminar(long /*0*/pstkSolicitudCD, int /*1*/pRenglon, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkSolicitudCD, new Generalidades.NullableInt(/*1*/pRenglon) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkSolicitudCDCuerpoEliminar", parametros);
        }

        public static void Guardar(long /*0*/pstkSolicitudCD, int /*1*/pRenglon, string /*2*/pProducto_Id, string /*3*/pDepositoOrigen, string /*4*/pObservaciones, decimal /*5*/pCantidad, decimal /*6*/pCantidadPendiente, string /*7*/pMedida_Id, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkSolicitudCD, /*1*/pRenglon, new Generalidades.NullableString(/*2*/pProducto_Id), new Generalidades.NullableString(/*3*/pDepositoOrigen), new Generalidades.NullableString(/*4*/pObservaciones), /*5*/pCantidad, /*6*/pCantidadPendiente, new Generalidades.NullableString(/*7*/pMedida_Id) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkSolicitudCDCuerpoGuardar", parametros);
        }




    }
}
