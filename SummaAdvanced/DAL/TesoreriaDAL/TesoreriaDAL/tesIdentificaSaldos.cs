using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesoreriaCommon;
using System.Data;
using interfaceDAAB;
namespace TesoreriaDAL
{
    public class tesIdentificaSaldos
    {
        public static tesIdentificaSaldoDS Datos(string /*0*/pCartera_Id, int /*1*/pEmpresa, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCartera_Id, /*1*/pEmpresa };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesIdentificaSaldo", parametros);

            string[] camposTabla0 = { "SaldoContable", "SaldoBanco" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Importe24", "Importe48", "Importe72" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Importe24", "Importe48", "Importe72" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            tesIdentificaSaldoDS dsTipado = new tesIdentificaSaldoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Saldos.TableName, dsTipado.Debitos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
