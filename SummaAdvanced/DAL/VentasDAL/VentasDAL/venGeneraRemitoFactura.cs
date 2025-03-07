using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using interfaceDAAB;
using System.Data;


namespace VentasDAL
{
    public class venGeneraRemitoFactura
    {
        public static venGeneraRemitoFacturaDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, bool /*10*/pSoloRemito, bool /*11*/pConRemito, string /*12*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pSoloRemito, /*11*/pConRemito };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venGeneraRemitoFactura", parametros);

            string[] camposTabla1 = { "Sucursal", "MedidaAlterna", "Observaciones", "Pedido", "Centro1_Id", "Centro2_Id", "stkMoviCabe" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Cambio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Vencimiento", "Ubicacion_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            venGeneraRemitoFacturaDS dsTipado = new venGeneraRemitoFacturaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.venRepaPedi.TableName, dsTipado.Cambios.TableName, dsTipado.grdSeries.TableName, dsTipado.Ubicaciones.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
