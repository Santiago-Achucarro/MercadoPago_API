using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;
namespace StockDAL
{
    public class stkEntradasEmbarque
    {

        public static stkEntradasEmbarqueDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N,
            int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, 
            string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/pSegmento_Id_Emb, int /*11*/pSegmento1N_Emb, 
            int /*12*/pSegmento2N_Emb, int /*13*/pSegmento3N_Emb, int /*14*/pSegmento4N_Emb, string /*15*/pSegmento1C_Emb, 
            string /*16*/pSegmento2C_Emb, string /*17*/pSegmento3C_Emb, string /*18*/pSegmento4C_Emb, string /*19*/pProveed_Id, 
            string /*20*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N,
                /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C,
                /*10*/pSegmento_Id_Emb, /*11*/pSegmento1N_Emb, /*12*/pSegmento2N_Emb, /*13*/pSegmento3N_Emb, /*14*/pSegmento4N_Emb,
                /*15*/pSegmento1C_Emb, /*16*/pSegmento2C_Emb, /*17*/pSegmento3C_Emb, /*18*/pSegmento4C_Emb, /*19*/pProveed_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkEntradasEmbarqueDatos", parametros);

            string[] camposTabla0 = { "DistribuyeContrapartida", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "stkMoviCabe", "Renglon", "Cantidad", "MedidaAlterna", "DescripcionMedidaAlterna",
                "CantidadAlternaForm", "Observaciones", "Centro1Debe", "DescripcionCentro1Debe", "Centro2Debe",
                "DescripcionCentro2Debe", "Centro1Haber", "DescripcionCentro1Haber", "Centro2Haber", "DescripcionCentro2Haber",
                "Despacho_Id", "CantidadEmb", "CantidadRecibidaEmb" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla4 = { "Cantidad", "Vencimiento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            stkEntradasEmbarqueDS dsTipado = new stkEntradasEmbarqueDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName, dsTipado.stkMoviEmbarque.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.grdMoviDespa.TableName, dsTipado.Ubicaciones.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



    }
}
