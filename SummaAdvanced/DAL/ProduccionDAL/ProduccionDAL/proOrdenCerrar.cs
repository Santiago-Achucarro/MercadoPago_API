using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using ProduccionCommon;
using System.Data;

namespace ProduccionDAL
{
    public class proOrdenCerrar
    {
        public static proOrdenCerrarrDS Datos(string /*0*/pSegmento_Id, int /*1*/pSegmento1N, int /*2*/pSegmento2N, int /*3*/pSegmento3N, int /*4*/pSegmento4N, string /*5*/pSegmento1C, string /*6*/pSegmento2C, string /*7*/pSegmento3C, string /*8*/pSegmento4C, int /*9*/pEmpresa_Id, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pSegmento_Id, /*1*/pSegmento1N, /*2*/pSegmento2N, /*3*/pSegmento3N, /*4*/pSegmento4N, /*5*/pSegmento1C, /*6*/pSegmento2C, /*7*/pSegmento3C, /*8*/pSegmento4C, /*9*/pEmpresa_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("proOrdenCerrarrDatos", parametros);

            string[] camposTabla0 = { "proOrden", "Observaciones", "Causa_Id", "DescripcionCausa" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "FechaEmision", "FechaNecesidad", "FechaProduccion", "CantPendiente" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "proOrden" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "proOrden", "Cambio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla4 = { "proOrden", "SubRecurso_Id", "DescripcionSubRecurso", "UsaSubRecurso" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            string[] camposTabla5 = { "proOrden", "PorcentajeCosto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "Cantidad", "Vencimiento", "Existencia", "Marcado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            string[] camposTabla7 = { "Vencimiento", "Ubicacion_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            string[] camposTabla8 = { "Cantidad", "CantidadAlterna", "Existencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

            proOrdenCerrarrDS dsTipado = new proOrdenCerrarrDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Orden.TableName, dsTipado.Productos.TableName, dsTipado.Trabajos3.TableName, dsTipado.Recursos.TableName, dsTipado.Producciones.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.SerieProduccion.TableName, dsTipado.Ubicaciones.TableName, dsTipado.UbicacionesE.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static proOrdenCerrarrCalcularDS Calcular(int /*0*/pproOrden, decimal /*1*/pCantidad, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pproOrden, /*1*/pCantidad };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proOrdenCerrarrCalcular", parametros);

            string[] camposTabla0 = { "proOrden", "Cantidad" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "FechaEmision", "FechaNecesidad", "FechaProduccion", "CantPendiente" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Cantidad", "Deposito_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Cantidad", "Preciouni" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla4 = { "Cantidad" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            string[] camposTabla5 = { "Cantidad", "Deposito_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            proOrdenCerrarrCalcularDS dsTipado = new proOrdenCerrarrCalcularDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Orden.TableName, dsTipado.Productos.TableName, dsTipado.Trabajos3.TableName, dsTipado.Recursos.TableName, dsTipado.Produccion.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static proCierresCostoDS CostoCierre(long /*0*/stkMoviCabe, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/stkMoviCabe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("proCierresCosto", parametros);

            string[] camposTabla2 = { "CostoTotal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            proCierresCostoDS dsTipado = new proCierresCostoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Costos.TableName, dsTipado.Producciones.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }






    }
}
