using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ImpuestosCommon;


namespace ImpuestosDAL
{
   public class impCalcular
    {
        public static impCalularDS Calcular(string /*0*/Impuesto_Id, DateTime /*1*/FechaDesde, DateTime /*2*/FechaHasta, int /*3*/Empresa_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Impuesto_Id, /*1*/FechaDesde, /*2*/FechaHasta, /*3*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impCalularDatos", parametros);

            string[] camposTabla0 = { "FechaDesde", "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Debe", "Haber" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            impCalularDS dsTipado = new impCalularDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuenta.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
