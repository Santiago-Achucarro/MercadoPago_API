using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using System.Data;
using ComprasCommon;

namespace ComprasDAL
{
    public class comMovProvRemiPend
    {
        public static comMovProvRemiPendDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/pProveed_Id, string /*11*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pProveed_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comMovProvRemiPendDatos", parametros);

            string[] camposTabla0 = { "Tipomov", "Observaciones", "Origen_Id", "DescripcionOrCredFisc", "CondPago_Id", "DescripcionConPago", "CondFiscal_Id", "DescripcionCondFiscal", "FechaFiscal", "ClaveFiscal", "VieneDeFiscal", "TipoCompFE", "DescripcionTipoCompFE", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "FechaVencimiento", "Cierre" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Renglon", "SegmentoStr" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla5 = { "SegmentoStr", "Marca", "Monto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            comMovProvRemiPendDS dsTipado = new comMovProvRemiPendDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName, dsTipado.grdImpuestos.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.grdCuotas.TableName, dsTipado.grdRemitos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static comMovProvRemiPendDatosRemiDS DatosUnRemi(long /*0*/pStkMoviCabe, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pStkMoviCabe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comMovProvRemiPendDatosRemi", parametros);

            string[] camposTabla0 = { "CantidadOriginal", "SegmentoStr" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comMovProvRemiPendDatosRemiDS dsTipado = new comMovProvRemiPendDatosRemiDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }








    }
}
