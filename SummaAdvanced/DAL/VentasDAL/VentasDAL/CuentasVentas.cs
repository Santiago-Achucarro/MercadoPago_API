using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasDAL
{
    public static class CuentasVentas
    {
        public static decimal dTodo(int /*0*/pEmpresa_Id, long pvenMovimientos, string /*1*/pImpuesto_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, pvenMovimientos, /*1*/pImpuesto_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((decimal)oiDAAB.guardar("dTodo", parametros));
        }

        public static decimal PorceAsoc(long /*0*/pvenMovimientos, string /*1*/pImpuesto_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pImpuesto_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((decimal)oiDAAB.guardar("PorceAsoc", parametros));
        }
    }
}

