using ImpuestosCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ImpuestosDAL
{
   public class impSicore
    {
        public static impSicoreDS Datos(int /*0*/pEmpresa_Id, DateTime /*1*/pFechaDesde,
            DateTime /*2*/pFechaHasta, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pFechaDesde, /*2*/pFechaHasta };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impSicore", parametros);

            string[] camposTabla0 = { "Empresa_Id", "FechaDesde", "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "TipoImpuesto", "ImporteTotal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            impSicoreDS dsTipado = new impSicoreDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Comprobantes.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

    }
}
