using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesChequerasCheques
    {
        public static tesChequerasChequesDS Datos(int /*0*/pEmpresa_Id, string /*1*/pCartera_Id, int /*2*/pChequera_Id, int /*3*/pnumCheque, 
            string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pCartera_Id, /*2*/pChequera_Id, new Generalidades.NullableInt(/*3*/pnumCheque) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesChequerasChequesDatos", parametros);

            string[] camposTabla0 = { "Cartera_Id", "Chequera_Id", "numCheque" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Moneda_Id", "Segmento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            tesChequerasChequesDS dsTipado = new tesChequerasChequesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cheques.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
