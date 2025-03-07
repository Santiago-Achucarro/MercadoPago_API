using interfaceDAAB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VentasCommon;

namespace VentasDAL
{
    public static class venMovConStock
    {
        public static venMovConStockDS Datos(long /*0*/pvenMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venMovConStockDatos", parametros);

            string[] camposTabla1 = { "RenglonReferencia", "Producto_Id", "CFVenta_Id", "DescripcionProductos", "Deposito_Id",
                "DescripcionDepositos", "Medida_Id", "DescripcionUniMed", "MedidaAlterna", "SubTotal", "Observaciones",
                "CantidadAduana", "UnidadAduana", "ValorUnitarioAduana", "ValorDolares" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Despacho_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            venMovConStockDS dsTipado = new venMovConStockDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdVenConStockCr.TableName,
                dsTipado.grdVenConStockCrCtas.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(long /*0*/pvenMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venMovConStockEliminar", parametros);
        }

        public static void Guardar(long /*0*/pvenMovimientos, string /*1*/pListaPrecio_id, string /*2*/pTipoPrecioForm, 
            string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos, /*1*/pListaPrecio_id, /*2*/pTipoPrecioForm };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venMovConStockGuardar", parametros);
        }
    }
}
