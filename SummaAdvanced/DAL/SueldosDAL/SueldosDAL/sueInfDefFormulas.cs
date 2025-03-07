using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class sueInfDefFormulas
    {
        public static void Eliminar(string /*0*/pInforme_Id, int /*1*/pColumna, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pInforme_Id, new Generalidades.NullableInt(/*1*/pColumna) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("sueInfDefFormulasEliminar", parametros);
        }

        public static void Guardar(int /*0*/psueInfDefinibles, int /*1*/pColumna, string /*2*/pAlias, string /*3*/pTitulo, string /*4*/pFormula, string /*5*/pFormato, decimal /*6*/pAncho, int /*7*/pOrden, string /*8*/pTipo, bool /*9*/pCheckCero, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/psueInfDefinibles, /*1*/pColumna, /*2*/pAlias, /*3*/pTitulo, /*4*/pFormula, /*5*/pFormato, /*6*/pAncho, /*7*/pOrden, /*8*/pTipo, /*9*/pCheckCero };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("sueInfDefFormulasGuardar", parametros);
        }
    }
}
