using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public static class CuentasTesoreria
    {
        public static decimal tRet(Int32 pEmpresa_Id, DateTime /*0*/pFechaDesde, DateTime /*1*/pFechaHasta, string /*2*/pProveed_Id,
            string /*3*/pCartera_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { pEmpresa_Id, /*0*/pFechaDesde, /*1*/pFechaHasta, /*2*/pProveed_Id, /*3*/pCartera_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);


            decimal lRet = (decimal)oiDAAB.guardar("FuncTesotRet", parametros);

            return lRet;
        }

        public static decimal Acum(Int32 pEmpresa_Id, DateTime /*0*/pFechaDesde, DateTime /*1*/pFechaHasta, string /*2*/pProveed_Id,
            Int32 pTipoPasivo, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {pEmpresa_Id, /*0*/pFechaDesde, /*1*/pFechaHasta, /*2*/pProveed_Id, 
                new Generalidades.NullableInt(/*3*/pTipoPasivo) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            decimal lRet = (decimal)oiDAAB.guardar("FuncTesoAcum", parametros);

            return lRet;
        }

        public static decimal Tabla(Int32 pEmpresa_Id, Int32 pTabla_Id, decimal pHasta, string pAuxiliar)
        {
            Object[] parametros = new Object[] { pEmpresa_Id, /*0*/pTabla_Id, /*1*/pHasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            decimal lRet = (decimal)oiDAAB.guardar("FuncTesoTabla", parametros);

            return lRet;

        }

        public static decimal AcumUsu(Int32 pEmpresa_Id, DateTime /*0*/pFechaDesde, DateTime /*1*/pFechaHasta, string /*2*/pProveed_Id,
            Int32 pTipoPasivo, string pCartera_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {pEmpresa_Id, /*0*/pFechaDesde, /*1*/pFechaHasta, /*2*/pProveed_Id, pTipoPasivo, /*3*/pCartera_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            decimal lRet = (decimal)oiDAAB.guardar("FuncTesoAcumUsu", parametros);

            return lRet;
        }
    }
}
