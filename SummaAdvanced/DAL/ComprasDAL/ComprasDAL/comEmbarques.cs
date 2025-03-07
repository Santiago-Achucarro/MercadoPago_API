using ComprasCommon;
using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ComprasDAL
{
    public class comEmbarques
    {
        public static comEmbarquesDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comEmbarquesDatos", parametros);

            string[] camposTabla1 = { "SegmentoStr" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            comEmbarquesDS dsTipado = new comEmbarquesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.comEmbCuerpo.TableName, dsTipado.comEmbGastos.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.OC.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(int /*0*/pIdentity, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pIdentity };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("comEmbarquesEliminar", parametros);
        }

        public static void Guardar(long /*0*/pcomEmbarques, string /*1*/pTipoTransporte, string /*2*/pNroOrdenExterior,
            DateTime /*3*/pFechaEmbarque, DateTime /*4*/pFechaArribo, decimal /*5*/pPesoTotal, string /*6*/pEstado_Id,
            string /*7*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomEmbarques, /*1*/pTipoTransporte, /*2*/pNroOrdenExterior,
                /*3*/pFechaEmbarque, /*4*/pFechaArribo, /*5*/pPesoTotal, /*6*/pEstado_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comEmbarquesGuardar", parametros);
        }


        public static comOCEmbCuerpoTraeOCDS TraeDatosOC(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comOCEmbCuerpoTraeOC", parametros);

            string[] camposTabla0 = { "SegmentoStr", "CantidadPendiente" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comOCEmbCuerpoTraeOCDS dsTipado = new comOCEmbCuerpoTraeOCDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static comEmbarqueEdtoCtaDS EstadoCuenta(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comEmbarqueEdtoCta", parametros);

            string[] camposTabla0 = { "Cerrando", "stkMoviCabeReva" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "SegmentoStr", "Saldo", "SaldoBase" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Asiento_Id", "Cuota_Nro", "Cambio", "Monto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla5 = { "OrdenDeCompra" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            comEmbarqueEdtoCtaDS dsTipado = new comEmbarqueEdtoCtaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.CompAplic.TableName, dsTipado.Aplicados.TableName, dsTipado.Gastos.TableName, dsTipado.Productos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static comEmbarquesCostoRealDS CostoReal(long /*0*/comEmbarques, decimal /*1*/Cambio, DateTime /*2*/Fecha, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/comEmbarques, /*1*/Cambio, /*2*/ new Generalidades.NullableDate(Fecha) };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);
            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comEmbarquesCostoReal", parametros);

            string[] camposTabla0 = { "Cantidad", "PrecioCalculado", "Costo", "CtaAjuInventario" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "ImporteReal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            comEmbarquesCostoRealDS dsTipado = new comEmbarquesCostoRealDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Gastos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static comEmbarquesOEFARDS OEFAR(long /*0*/comEmbarques, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/comEmbarques };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("comEmbarquesOEFAR", parametros);

            string[] camposTabla0 = { "Monto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            comEmbarquesOEFARDS dsTipado = new comEmbarquesOEFARDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void CambiarEstado(long /*0*/pcomEmbarques, string /*1*/pEstado, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomEmbarques, /*1*/pEstado };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comEmbarquesCambiarEstado", parametros);
        }


        public static void BorrarCierre(long /*0*/pcomEmbarques, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pcomEmbarques };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("comEmbarqueEdtoCtaBorrarCierre", parametros);
        }
    }
}
