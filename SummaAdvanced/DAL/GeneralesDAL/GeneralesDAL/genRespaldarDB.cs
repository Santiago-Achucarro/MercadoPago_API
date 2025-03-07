using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralesDAL
{
    public class genRespaldarDB
    {
        public static void Guardar(string /*0*/pBase, string /*1*/pRuta, string /*2*/pNombre, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pBase, /*1*/pRuta, /*2*/pNombre };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("genRespaldarDB", parametros);
        }


    }
}
