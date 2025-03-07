using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class sueGanancias
    {
        public static void Eliminar(int /*0*/pTabGan_Id, decimal /*1*/pHasta, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabGan_Id, new Generalidades.NullableDecimal(/*1*/pHasta) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueGananciasEliminar", parametros);
        }

        public static void Guardar(int /*0*/pTabGan_Id, decimal /*1*/pHasta, decimal /*2*/pPorcentaje, decimal /*3*/pMinimo, int /*4*/pVer, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pTabGan_Id, /*1*/pHasta, /*2*/pPorcentaje, /*3*/pMinimo, /*4*/pVer };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueGananciasGuardar", parametros);
        }




    }
}