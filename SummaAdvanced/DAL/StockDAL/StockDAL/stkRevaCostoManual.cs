using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;
namespace StockDAL
{
    public class stkRevaCostoManual
    {

        public static stkRevaCostoManualDS Datos(string /*0*/Segmento_Id, string /*1*/Segmento1C, string /*2*/Segmento2C, string /*3*/Segmento3C, string /*4*/Segmento4C, int /*5*/Segmento1N, int /*6*/Segmento2N, int /*7*/Segmento3N, int /*8*/Segmento4N, string /*9*/ProductoDesde, string /*10*/ProductoHasta, string /*11*/Centro1_Id, string /*12*/Centro2_Id, int /*13*/Empresa_Id,string pSucursal,  string /*14*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Segmento_Id, /*1*/Segmento1C, /*2*/Segmento2C, /*3*/Segmento3C, /*4*/Segmento4C, /*5*/Segmento1N, /*6*/Segmento2N, /*7*/Segmento3N, /*8*/Segmento4N, /*9*/ProductoDesde, /*10*/ProductoHasta, /*11*/Centro1_Id, /*12*/Centro2_Id, /*13*/Empresa_Id, pSucursal };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkRevaCostoManual", parametros);

            string[] camposTabla0 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "ProductoDesde", "ProductoHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stkRevaCostoManualDS dsTipado = new stkRevaCostoManualDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
