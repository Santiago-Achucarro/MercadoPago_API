using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KSKDAL
{
   public class espgenUsuariosCambSucursalKSK
    {

        public static void Guardar(int /*0*/pSucursal_Id, string /*1*/pUsuario_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSucursal_Id, /*1*/pUsuario_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("espgenUsuariosCambSucursalKSK", parametros);
        }
    }
}
