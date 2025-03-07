using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genReportesTodos
    {

        public static genReportesTodosDS Datos(string /*1*/ pAuxiliar)
        {

            Object[] parametros = new Object[] { };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("genReportesDatosTodos", parametros);

            string[] camposTabla0 = { "Carpeta", "Estandar", "Local", "StoreProcedure", "TipoReporte", "TamanioHoja", "AnchoHoja", "AltoHoja" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            genReportesTodosDS dsTipado = new genReportesTodosDS();
            //string[] nombreTablas = { dsTipado.Reportes.TableName };
            //Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Reportes.Merge(ds.Tables[0]);
            return (dsTipado);
        }
    }
}
