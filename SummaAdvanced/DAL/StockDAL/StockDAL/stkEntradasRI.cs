using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using StockCommon;

namespace StockDAL
{
    public class stkEntradasRI
    {
        public static stkEntradasRIDS Datos(int /*0*/pEmpresa_id, string /*1*/pSegmento_id, int /*2*/pSegmento1N,
            int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, 
            string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/pSegmento_id_RI, int /*11*/pSegmento1N_RI, 
            int /*12*/pSegmento2N_RI, int /*13*/pSegmento3N_RI, int /*14*/pSegmento4N_RI, string /*15*/pSegmento1C_RI, 
            string /*16*/pSegmento2C_RI, string /*17*/pSegmento3C_RI, string /*18*/pSegmento4C_RI, string /*19*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_id, /*1*/pSegmento_id, /*2*/pSegmento1N, /*3*/pSegmento2N, 
                /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C,
                /*10*/pSegmento_id_RI, /*11*/pSegmento1N_RI, /*12*/pSegmento2N_RI, /*13*/pSegmento3N_RI, /*14*/pSegmento4N_RI,
                /*15*/pSegmento1C_RI, /*16*/pSegmento2C_RI, /*17*/pSegmento3C_RI, /*18*/pSegmento4C_RI };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkEntradasRIDatos", parametros);

            string[] camposTabla0 = { "DistribuyeContrapartida", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla2 = { "stkMoviCabe", "MedidaAlterna", "DescripcionMedidaAlterna", "CantidadAlternaForm",
                "CuentaDebe", "DescripcionCuentaDebe", "Centro1Debe", "DescripcionCentro1Debe", "Centro2Debe",
                "DescripcionCentro2Debe", "ImporteContableDebe", "ImporteContableHaber" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla4 = { "Cantidad", "Vencimiento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            string[] camposTabla6 = { "Cantidad" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            stkEntradasRIDS dsTipado = new stkEntradasRIDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.ReqInt.TableName, dsTipado.Cuerpo.TableName,
                dsTipado.genAtributosGenerales.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.grdMoviDespa.TableName,
                dsTipado.Ubicaciones.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
