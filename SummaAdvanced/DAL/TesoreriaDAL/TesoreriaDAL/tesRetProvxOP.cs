using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TesoreriaCommon;

namespace TesoreriaDAL
{
    public class tesRetProvxOP
    {
        public static tesRetProvxOPDS Datos(int /*0*/pEmpresa_Id, int /*1*/pSegmento1N_OP, int /*2*/pSegmento2N_OP, int /*3*/pSegmento3N_OP,
            int /*4*/pSegmento4N_OP, string /*5*/pSegmento1C_OP, string /*6*/pSegmento2C_OP, string /*7*/pSegmento3C_OP, string /*8*/pSegmento4C_OP, 
            string /*9*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento1N_OP, /*2*/pSegmento2N_OP, /*3*/pSegmento3N_OP, /*4*/pSegmento4N_OP,
                /*5*/pSegmento1C_OP, /*6*/pSegmento2C_OP, /*7*/pSegmento3C_OP, /*8*/pSegmento4C_OP };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("tesRetProvxOPDatos", parametros);

            string[] camposTabla0 = { "Segmento1N_OP", "Segmento2N_OP", "Segmento3N_OP", "Segmento4N_OP", "Segmento1C_OP", "Segmento2C_OP",
                "Segmento3C_OP", "Segmento4C_OP" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Reporte_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            tesRetProvxOPDS dsTipado = new tesRetProvxOPDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Retenciones.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
