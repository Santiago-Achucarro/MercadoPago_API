using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasDAL
{
    public class venLogCorreo
    {
        public static void Guardar(DateTime /*0*/pFechaHora, string /*1*/pPara, long /*2*/pvenMovimientos, string /*3*/pRespuesta, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFechaHora, /*1*/pPara, /*2*/pvenMovimientos, /*3*/pRespuesta };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venLogCorreosGuardar", parametros);
        }


    }
}
