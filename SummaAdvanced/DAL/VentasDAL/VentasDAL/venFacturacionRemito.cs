using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using VentasCommon;
using System.Data;

namespace VentasDAL
{
    public class venFacturacionRemito
    {
        public static venFacturacionRemitoDS DatosRemito(long /*0*/lIdentity, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/lIdentity };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venFacturacionRemitoDatos", parametros);

            string[] camposTabla0 = { "Fecha", "Cliente_Id", "Sucursal", "NombreFantasia", "Moneda_Id", "DescripcionMonedas", "MonedaFacturacion", "DescripcionMonFacturacion", "CondPagoCli_Id", "DescripcionCondPago", "ListaPrecio_Id", "DescripcionListasPrecios", "Vendedor_Id", "DescripcionVendedores", "FormaEntrega_Id", "DescripcionFormaEntrega", "FechaAutorizo", "Observaciones", "ObservEstado", "Motivo_Id", "ObsAnticipo", "Cambio", "Incoterm_Id", "DescripcionIncoterm", "MetodoPago", "UsoCfdi", "DescripcionUsoCfdi", "DescripcionMetodoPago", "Timbrar", "SegmentoStr" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Producto_Id", "DescripcionProductos", "Medida_Id", "DescripcionUniMed", "Deposito_Id", "DescripcionDepositos", "CantidadAFacturar", "CantidadAFacturarAlterna", "CFVenta_Id", "Observaciones", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            venFacturacionRemitoDS dsTipado = new venFacturacionRemitoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.genAtributosGenerales.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static venRemitosPendienteClieDS RemiPendDatos(string /*0*/Cliente_Id, int /*1*/Sucursal, string /*2*/Moneda_Id, int /*3*/Empresa_Id, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Cliente_Id, /*1*/Sucursal, /*2*/Moneda_Id, /*3*/Empresa_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venRemitosPendienteClieDatos", parametros);

            string[] camposTabla0 = { "FechaPedido", "Moneda_Id", "DescripcionMonedas", "MonedaFacturacion", "DescripcionMonFacturacion", "CondPagoCli_Id", "DescripcionCondPago", "ListaPrecio_Id", "DescripcionListasPrecios", "Vendedor_Id", "DescripcionVendedores", "FormaEntrega_Id", "DescripcionFormaEntrega", "CongelaCambio", "UsoCfdi", "DescripcionUsoCfdi", "DescripcionMetodoPago", "Timbrar", "FechaNueva" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Marca", "Remito", "Pedido", "Monto" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "CantidadFacturada", "CantidadAFacturar", "CantidadAFacturarAlterna", "Especial", "Observaciones", "Pendiente", "ReservaMercaderia", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Cantidad" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            venRemitosPendienteClieDS dsTipado = new venRemitosPendienteClieDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Remitos.TableName, dsTipado.Cuerpo.TableName, dsTipado.grdMoviSerie.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

    }
}
