using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockDAL
{
    public class stkSolicitudCDSegmentos
    {
        public static void Eliminar(int /*0*/pSegmento_Id, int /*1*/pSegmento1N, int /*2*/pSegmento2N, int /*3*/pSegmento3N, int /*4*/pSegmento4N, string /*5*/pSegmento1C, string /*6*/pSegmento2C, string /*7*/pSegmento3C, string /*8*/pSegmento4C, string /*9*/pEmpresa_Id, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableInt(/*0*/pSegmento_Id), new Generalidades.NullableInt(/*1*/pSegmento1N), new Generalidades.NullableInt(/*2*/pSegmento2N), new Generalidades.NullableInt(/*3*/pSegmento3N), new Generalidades.NullableInt(/*4*/pSegmento4N), new Generalidades.NullableString(/*5*/pSegmento1C), new Generalidades.NullableString(/*6*/pSegmento2C), new Generalidades.NullableString(/*7*/pSegmento3C), new Generalidades.NullableString(/*8*/pSegmento4C), /*9*/pEmpresa_Id };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkSolicitudCDSegmentoEliminar", parametros);
        }

        public static int Guardar(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, long /*10*/pstkSolicitudCD, bool /*11*/pTieneAutomatico, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pstkSolicitudCD, /*11*/pTieneAutomatico };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (int) oiDAAB.guardar("stkSolicitudCDSegmentoGuardar", parametros);
        }

    }
}
