using ImpuestosCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ImpuestosDAL
{
    public class impArbaTxt
    {
        public static long Importar(string pArchivo, Int16 pMes, Int16 pAnio, string pRegimen, string pAuxiliar)
        {
            object[] parametros = { pArchivo, pMes, pAnio, pRegimen };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return (long)oiDAAB.guardar("impArbaTxtImportar", parametros);
        }

        public static impArbaTxtDS Datos(Int16 pMes, Int16 pAnio, string pAuxiliar)
        {
            object[] parametros = { pMes, pAnio };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impArbaTxtDatos", parametros);

            string[] camposTabla0 = { "Mes", "Anio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "VigDesde", "VigHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            impArbaTxtDS dsTipado = new impArbaTxtDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Vigencias.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
