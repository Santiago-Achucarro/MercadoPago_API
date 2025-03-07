using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkCierre
    {
        public static void ActuAsiento(long /*0*/StkMoviCabe, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/StkMoviCabe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stockActuAsientoCierre", parametros);
        }
        public static void ActuCosto(long /*0*/StkMoviCabe, DateTime /*1*/FechaCierre, int /*2*/Empresa_id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/StkMoviCabe, /*1*/FechaCierre, /*2*/Empresa_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stockActuCostoCierre", parametros);
        }

        public static void ActuCostoSucursal(long /*0*/StkMoviCabe, DateTime /*1*/FechaCierre, int /*2*/Empresa_id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/StkMoviCabe, /*1*/FechaCierre, /*2*/Empresa_id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stockActuCostoCierreSucursal", parametros);
        }


        public static void InicioCierre(DateTime /*0*/FechaCierre, DateTime /*1*/FechaCierreAnt, int /*2*/Empresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/FechaCierre, /*1*/FechaCierreAnt, /*2*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stockInicioCierre", parametros);
        }

        public static stockMovCuerpoCierreDS CuerpoCierre(long /*0*/StkMoviCabe, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/StkMoviCabe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stockMovCuerpoCierre", parametros);

            string[] camposTabla0 = { "stkProductos", "CtaAjuInventario", "Deposito_Id", "Centro1_Id", "Centro2_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stockMovCuerpoCierreDS dsTipado = new stockMovCuerpoCierreDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static stockMovimientosCierreDS MovimientosCierre(DateTime /*0*/FechaCierreAnt, DateTime /*1*/FechaCierre, int /*2*/Empresa_Id, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/FechaCierreAnt, /*1*/FechaCierre, /*2*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stockMovimientosCierre", parametros);

            string[] camposTabla0 = { "stkmoviCabeReva" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stockMovimientosCierreDS dsTipado = new stockMovimientosCierreDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static StockCerrarDS DatosFechas(int /*0*/Empresa_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("StockCerrar", parametros);

            StockCerrarDS dsTipado = new StockCerrarDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static stkAsiCierreDatosCierreDS Datos(DateTime /*0*/pFecha, int /*1*/Empresa_Id, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pFecha, /*1*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkAsiCierreDatosCierre", parametros);

            string[] camposTabla0 = { "Fecha" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stkAsiCierreDatosCierreDS dsTipado = new stkAsiCierreDatosCierreDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static void CierreTransito(long /*0*/pStkMoviCabeEntr, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pStkMoviCabeEntr };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkProductosCierreTransito", parametros);
        }






    }
}
