using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using SueldosCommon;

namespace SueldosDAL
{
    public class sueRecibos
    {

        public static sueRecibosDS Datos(string /*0*/pSegmento_Id, int /*1*/pSegmento1N, int /*2*/pSegmento2N, int /*3*/pSegmento3N, int /*4*/pSegmento4N, string /*5*/pSegmento1C, string /*6*/pSegmento2C, string /*7*/pSegmento3C, string /*8*/pSegmento4C, int /*9*/Legajo, int /*10*/Empresa_Id, string /*11*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_Id, /*1*/pSegmento1N, /*2*/pSegmento2N, /*3*/pSegmento3N, /*4*/pSegmento4N, /*5*/pSegmento1C, /*6*/pSegmento2C, /*7*/pSegmento3C, /*8*/pSegmento4C, /*9*/Legajo, /*10*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("sueRecibosDatos", parametros);

            string[] camposTabla0 = { "DiasPagados", "Neto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Percepciones", "Deducciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            sueRecibosDS dsTipado = new sueRecibosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




    }
}
