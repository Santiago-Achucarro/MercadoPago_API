using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralesDAL
{
    public class genSemaforo
    {
        public static void Guardar(string /*0*/pSemaforo, int /*1*/pEmpresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSemaforo, /*1*/pEmpresa_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genSemaforoGuardar", parametros);
        }


    }
}
