using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using SueldosCommon;

namespace SueldosDAL
{
    public class sueGenerarInfDefinibles
    {
        public static sueGenerarInfDefiniblesDS Datos(string /*0*/pInforme_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, int /*10*/pEmpresa_Id, string /*11*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pInforme_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueGenerarInfDefiniblesDatos", parametros);

            string[] camposTabla0 = { "TamanioHoja", "Empresa_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "FechaInicial", "FechaFinal", "Periodo_Id", "DescripcionPeriodicidad" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            sueGenerarInfDefiniblesDS dsTipado = new sueGenerarInfDefiniblesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.sueLiquidacion.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }







    }
}
