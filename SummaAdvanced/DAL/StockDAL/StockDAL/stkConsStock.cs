using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;
namespace StockDAL
{
    public class stkConsStock
    {
        public static stkConsStockDS Datos(string /*0*/Producto_id, string /*1*/Deposito_Id, int /*2*/Empresa, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Producto_id, /*1*/Deposito_Id, /*2*/Empresa };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkConsStockDatos", parametros);

            string[] camposTabla0 = { "Producto_Id", "Deposito_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Fecha", "Existencia", "Compras", "Embarques", "Pedidos", "TransitoLocal", "Final" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            stkConsStockDS dsTipado = new stkConsStockDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static stkConsStockDetalleDS DatosCompras(string /*0*/Producto_id, string /*1*/Deposito_Id, DateTime /*2*/Fecha, int /*3*/Empresa, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Producto_id, /*1*/Deposito_Id, /*2*/Fecha, /*3*/Empresa };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkConsStockCompras", parametros);

            string[] camposTabla0 = { "Cantidad", "SegmentoSTR" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stkConsStockDetalleDS dsTipado = new stkConsStockDetalleDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static stkConsStockDetalleDS DatosEmbarques(string /*0*/Producto_id, string /*1*/Deposito_Id, DateTime /*2*/Fecha, int /*3*/Empresa, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Producto_id, /*1*/Deposito_Id, /*2*/Fecha, /*3*/Empresa };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkConsStockEmbarques", parametros);

            string[] camposTabla0 = { "Cantidad", "SegmentoSTR" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stkConsStockDetalleDS dsTipado = new stkConsStockDetalleDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static stkConsStockDetalleDS DatosEnTransito(string /*0*/Producto_id, string /*1*/Deposito_Id, int /*2*/Empresa, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Producto_id, /*1*/Deposito_Id, /*2*/Empresa };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkConsStockEnTransito", parametros);

            string[] camposTabla0 = { "Entidad_Id", "Descripcion", "SegmentoSTR" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stkConsStockDetalleDS dsTipado = new stkConsStockDetalleDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static stkConsStockDetalleDS DatosPedidos(string /*0*/Producto_id, string /*1*/Deposito_Id, DateTime /*2*/Fecha, string /*3*/Vendedor_id, int /*4*/Empresa, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Producto_id, /*1*/Deposito_Id, /*2*/Fecha, new Generalidades.NullableString(/*3*/Vendedor_id), /*4*/Empresa };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkConsStockPedidos", parametros);

            string[] camposTabla0 = { "Cantidad", "SegmentoSTR" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            stkConsStockDetalleDS dsTipado = new stkConsStockDetalleDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



    }
}
