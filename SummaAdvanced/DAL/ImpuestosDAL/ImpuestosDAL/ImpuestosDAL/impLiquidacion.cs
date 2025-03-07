using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using ImpuestosCommon;


namespace ImpuestosDAL
{
  public  class impLiquidacion
    {
        public static impLiquidacionDS Datos(string /*0*/pSegmento_Id, int /*1*/pSegmento1N, int /*2*/pSegmento2N, int /*3*/pSegmento3N, int /*4*/pSegmento4N, string /*5*/pSegmento1C, string /*6*/pSegmento2C, string /*7*/pSegmento3C, string /*8*/pSegmento4C, int /*9*/pEmpresa_Id, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_Id, /*1*/pSegmento1N, /*2*/pSegmento2N, /*3*/pSegmento3N, /*4*/pSegmento4N, /*5*/pSegmento1C, /*6*/pSegmento2C, /*7*/pSegmento3C, /*8*/pSegmento4C, /*9*/pEmpresa_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("impLiquidacionDatos", parametros);

            string[] camposTabla0 = { "tesMovimientos" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            impLiquidacionDS dsTipado = new impLiquidacionDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static void Eliminar(long /*0*/pconAsientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pconAsientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("impLiquidacionEliminar", parametros);
        }

        public static void Guardar(long /*0*/pconAsientos, string /*1*/pImpuesto_Id, DateTime /*2*/pFechaPago, DateTime /*3*/pFechaDesde, DateTime /*4*/pFechaHasta, decimal /*5*/pTotalaPagar, bool /*6*/pSePaga, long /*7*/ptesMovimientos, string /*8*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pconAsientos, /*1*/pImpuesto_Id, /*2*/pFechaPago, /*3*/pFechaDesde, /*4*/pFechaHasta, /*5*/pTotalaPagar, /*6*/pSePaga, /*7*/ new Generalidades.NullableInt64(ptesMovimientos) };
            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);
            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("impLiquidacionGuardar", parametros);
        }

        public static void Pagar(long /*0*/pconAsientos, long /*1*/ptesMovimientos, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pconAsientos, /*1*/new Generalidades.NullableInt64(ptesMovimientos) };
            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("impLiquidacionPagar", parametros);
        }

        public static impLiquidacionFechaDS DatosFecha(DateTime /*0*/pFechaDesde, string /*1*/pImpuesto_Id, int /*2*/pEmpresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFechaDesde, /*1*/pImpuesto_Id, /*2*/pEmpresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("impLiquidacionFechaDatos", parametros);

            string[] camposTabla0 = { "Segmento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            impLiquidacionFechaDS dsTipado = new impLiquidacionFechaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




    }
}
