using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ProduccionCommon;

namespace ProduccionDAL
{
    public class proProgramaSegmento
    {
        public static void Guardar(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, bool /*10*/pTieneAutomatico, int /*11*/pproPrograma, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { /*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pTieneAutomatico, /*11*/pproPrograma};



            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("proProgramaSegmentoGuardar", parametros);
        }

    }
}
