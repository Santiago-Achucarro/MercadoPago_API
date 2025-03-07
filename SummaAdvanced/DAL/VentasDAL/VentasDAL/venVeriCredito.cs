using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;

namespace VentasDAL
{
    public class venVeriCredito
    {
        public static bool TieneMovimientosTipo(int pEmpresa_Id, string pCliente_Id, string pSubTipoMov_Id, string pAuxiliar)
        {
            Object[] parametros = new Object[] {pEmpresa_Id, /*0*/pCliente_Id, pSubTipoMov_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("TieneMovimientosTipo", parametros);

            return (ds.Tables[0].Rows.Count > 0);
        }

        public static decimal SaldoCtaCte(int pEmpresa_Id, string pCliente_Id, string pMonedaLimCred, string pAuxiliar)
        {
            Object[] parametros = new Object[] {pEmpresa_Id, pCliente_Id, pMonedaLimCred};

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("CalculoSaldoCtaCte", parametros);

            if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0]["Saldo"] != DBNull.Value)
                return Convert.ToDecimal(ds.Tables[0].Rows[0]["Saldo"]);
            return 0;
        }

        public static decimal SaldoDocumento(int pEmpresa_Id, string pCliente_Id, string pAuxiliar)
        {
            Object[] parametros = new Object[] {pEmpresa_Id, pCliente_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("CalculoSaldoDocumentada", parametros);

            if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0]["Saldo"] != DBNull.Value)
                return Convert.ToDecimal(ds.Tables[0].Rows[0]["Saldo"]);
            return 0;
        }


        public static decimal SaldoCtaCteVencida(int pEmpresa_Id, string pCliente_Id, string pMonedaLimCred, string pAuxiliar)
        {
            Object[] parametros = new Object[] { pEmpresa_Id, pCliente_Id, pMonedaLimCred };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("CalculoSaldoCtaCteVencida", parametros);

            if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0]["Saldo"] != DBNull.Value)
                return Convert.ToDecimal(ds.Tables[0].Rows[0]["Saldo"]);
            return 0;
        }

        public static int MaxAntiguedad(int pEmpresa_Id, string pCliente_Id, string pAuxiliar)
        {
            Object[] parametros = new Object[] { pEmpresa_Id, pCliente_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("CalculoMaxAntiguedad", parametros);

            return Convert.ToInt32(ds.Tables[0].Rows[0]["Dias"]);

        }
    }
}
