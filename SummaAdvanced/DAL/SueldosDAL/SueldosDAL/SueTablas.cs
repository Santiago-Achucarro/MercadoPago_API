using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class SueTablas
    {
        public static void Eliminar(int /*0*/pTabla_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabla_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueTablaEliminar", parametros);
        }

        public static void Guardar(int /*0*/pTabla_Id, decimal /*1*/pFila, decimal /*2*/pValor, int /*3*/pVer, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabla_Id, /*1*/pFila, /*2*/pValor, /*3*/pVer };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueTablaGuardar", parametros);
        }




    }
}
