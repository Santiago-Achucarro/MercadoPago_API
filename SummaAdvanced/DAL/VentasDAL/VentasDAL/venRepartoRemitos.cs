using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public class venRepartoRemitos
    {
        public static venRepartoRemitosDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, 
            int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, 
            string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N,
                /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venRepartoRemitosDatos", parametros);

            string[] camposTabla0 = { "Segmento_Id", "Segmento1C", "Segmento2C", "Segmento3C", "Segmento4C", "Segmento1N", "Segmento2N",
                "Segmento3N", "Segmento4N" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venRepartoRemitosDS dsTipado = new venRepartoRemitosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Comprobantes.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
