using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesCheqPropImpresion
    {
        public static tesCheqPropImpresionDS Datos(int /*0*/pEmpresa_Id, string /*1*/pCartera_Id, int /*2*/pChequera_Id, 
            int /*3*/pNumChequeDesde, int /*4*/pNumChequeHasta, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pCartera_Id, /*2*/pChequera_Id, /*3*/pNumChequeDesde,
                new Generalidades.NullableInt(/*4*/pNumChequeHasta) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesCheqPropImpresion", parametros);

            string[] camposTabla0 = { "Cartera_Id", "Chequera_Id", "NumChequeDesde" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            tesCheqPropImpresionDS dsTipado = new tesCheqPropImpresionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cheques.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

    }
}
