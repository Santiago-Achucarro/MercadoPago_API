using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesCheqTercerosCambio
    {
        public static tesCheqTercerosCambioDS TraeCheques(DateTime /*0*/FechaVencimiento, string /*1*/Banco_Id, int /*2*/numCheque, decimal /*3*/Importe, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] { new Generalidades.NullableDate(/*0*/FechaVencimiento), new Generalidades.NullableString(/*1*/Banco_Id), new Generalidades.NullableInt(/*2*/numCheque), new Generalidades.NullableDecimal(/*3*/Importe) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesCheqTercerosCambioDatos", parametros);

            string[] camposTabla0 = { "FechaVencimiento", "Banco_Id", "numCheque", "Importe" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Segmento", "Empresa_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            tesCheqTercerosCambioDS dsTipado = new tesCheqTercerosCambioDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cheques.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}   
