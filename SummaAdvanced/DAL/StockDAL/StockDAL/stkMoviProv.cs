using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using StockCommon;
using System.Data;
namespace StockDAL
{
    public class stkMoviProv
    {

        public static stkMoviProvDS Datos(long /*0*/pstkMoviCabe, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkMoviProvDatos", parametros);

            stkMoviProvDS dsTipado = new stkMoviProvDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
        public static void Eliminar(long /*0*/pstkMoviCabe, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkMoviProvEliminar", parametros);
        }

        public static void Guardar(long /*0*/pstkMoviCabe, string /*1*/pProveed_Id, string /*2*/ pRemitoProv, 
            DateTime /*3*/ pFechaRemito, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pProveed_Id, /*2*/ pRemitoProv, pFechaRemito };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkMoviProvGuardar", parametros);
        }

        public static stkRemiProvDS DatosRemi(int /*0*/pEmpresa_id, string /*1*/pSegmento_id, int /*2*/pSegmento1N, 
            int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, 
            string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_id, /*1*/pSegmento_id, /*2*/pSegmento1N, /*3*/pSegmento2N,
                /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkRemiProvDatos", parametros);

            string[] camposTabla0 = { "DistribuyeContrapartida", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Deposito_Id", "DescripcionDepositos", "Producto_Id", "DescripcionProductos", "Medida_Id",
                "DescripcionUniMed", "MedidaAlterna", "DescripcionMedidaAlterna", "Observaciones", "Centro1Debe",
                "DescripcionCentro1Debe", "Centro2Debe", "DescripcionCentro2Debe", "Centro1Haber", "DescripcionCentro1Haber",
                "Centro2Haber", "DescripcionCentro2Haber", "Despacho_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Cantidad", "Vencimiento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla5 = { "Cantidad" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            stkRemiProvDS dsTipado = new stkRemiProvDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName,
                dsTipado.genAtributosGenerales.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.grdMoviDespa.TableName,
                dsTipado.Ubicaciones.TableName, dsTipado.Remitentes.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }
    }
}
