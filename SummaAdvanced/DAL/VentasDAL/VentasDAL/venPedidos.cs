using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using interfaceDAAB;
using System.Data;

namespace VentasDAL
{
    public class venPedidos
    {
        public static venPedidosDS Datos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venPedidosDatos", parametros);

            string[] camposTabla0 = { "Segmento", "Cliente_Id", "Sucursal", "NombreFantasia", "Moneda_Id", "DescripcionMonedas", "MonedaFacturacion", "DescripcionMonFacturacion", "CondPagoCli_Id", "DescripcionCondPago", "ListaPrecio_Id", "DescripcionListasPrecios", "Vendedor_Id", "DescripcionVendedores", "FormaEntrega_Id", "DescripcionFormaEntrega", "UsuarioAutoriz_Id", "DescripcionUsuarioAutoriz", "FechaAutorizo", "Observaciones", "ObservEstado", "Motivo_Id", "ObsAnticipo", "Incoterm_Id", "DescripcionIncoterm", "MetodoPago", "UsoCfdi", "DescripcionUsoCfdi", "DescripcionMetodoPago", "SucursalUsu", "AceptaDatosExternos" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Producto_Id", "DescripcionProductos", "ObservacionesProductos", "Medida_Id", "DescripcionUniMed", "Deposito_Id", "DescripcionDepositos", "CFVenta_Id", "Observaciones", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "SubTotalNeto", "Anular" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla5 = { "Agregar" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "Fecha" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            string[] camposTabla7 = { "EsquemaAuto_Id", "DescripcionEsquema" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            string[] camposTabla8 = { "Usuario_Id", "DescripciongenUsuarios", "Fecha" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

            string[] camposTabla11 = { "Segmento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[11], camposTabla11);

            string[] camposTabla13 = { "Fecha", "Anulado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[13], camposTabla13);

            string[] camposTabla14 = { "Fecha", "Anulado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[14], camposTabla14);

            string[] camposTabla15 = { "Fecha", "Cerrado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[15], camposTabla15);

            venPedidosDS dsTipado = new venPedidosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.ConsStock.TableName, dsTipado.ConsDetalle.TableName, dsTipado.Cotizacion.TableName, dsTipado.AAutorizar.TableName, dsTipado.Esquema.TableName, dsTipado.venNPAutorizando.TableName, dsTipado.ValidacionComercial.TableName, dsTipado.LimiteCredito.TableName, dsTipado.PendClie.TableName, dsTipado.Adjuntos.TableName, dsTipado.Remitos.TableName, dsTipado.Facturas.TableName, dsTipado.Repartos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static venPedidosDS DatosIdentity(int /*0*/lIdentity, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/lIdentity };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venPedidosDatos_Identity", parametros);

            string[] camposTabla0 = { "Segmento", "Cliente_Id", "Sucursal", "NombreFantasia", "Moneda_Id", "DescripcionMonedas", "MonedaFacturacion", "DescripcionMonFacturacion", "CondPagoCli_Id", "DescripcionCondPago", "ListaPrecio_Id", "DescripcionListasPrecios", "Vendedor_Id", "DescripcionVendedores", "FormaEntrega_Id", "DescripcionFormaEntrega", "UsuarioAutoriz_Id", "DescripcionUsuarioAutoriz", "FechaAutorizo", "Observaciones", "ObservEstado", "Motivo_Id", "ObsAnticipo", "Incoterm_Id", "DescripcionIncoterm", "MetodoPago", "UsoCfdi", "DescripcionUsoCfdi", "DescripcionMetodoPago", "SucursalUsu" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Producto_Id", "DescripcionProductos", "Medida_Id", "DescripcionUniMed", "Deposito_Id", "DescripcionDepositos", "CFVenta_Id", "Observaciones", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla6 = { "Fecha" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            string[] camposTabla7 = { "EsquemaAuto_Id", "DescripcionEsquema" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            string[] camposTabla8 = { "Usuario_Id", "DescripciongenUsuarios", "Fecha" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

            string[] camposTabla11 = { "Segmento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[11], camposTabla11);

            venPedidosDS dsTipado = new venPedidosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.ConsStock.TableName, dsTipado.ConsDetalle.TableName, dsTipado.Cotizacion.TableName, dsTipado.AAutorizar.TableName, dsTipado.Esquema.TableName, dsTipado.venNPAutorizando.TableName, dsTipado.ValidacionComercial.TableName, dsTipado.LimiteCredito.TableName, dsTipado.PendClie.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static venFacturacionPedidoDS DatosFacturacion(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venFacturacionPedidoDatos", parametros);

            string[] camposTabla0 = { "Fecha", "Cliente_Id", "Sucursal", "NombreFantasia", "Moneda_Id", "DescripcionMonedas", "MonedaFacturacion", "DescripcionMonFacturacion", "CondPagoCli_Id", "DescripcionCondPago", "ListaPrecio_Id", "DescripcionListasPrecios", "Vendedor_Id", "DescripcionVendedores", "FormaEntrega_Id", "DescripcionFormaEntrega", "UsuarioAutoriz_Id", "DescripcionUsuarioAutoriz", "FechaAutorizo", "Observaciones", "ObservEstado", "Motivo_Id", "ObsAnticipo", "Cambio", "Incoterm_Id", "DescripcionIncoterm", "MetodoPago", "UsoCfdi", "DescripcionUsoCfdi", "DescripcionMetodoPago", "Timbrar", "SegmentoStr" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Producto_Id", "DescripcionProductos", "Medida_Id", "DescripcionUniMed", "Deposito_Id", "DescripcionDepositos", "CantidadAFacturar", "CantidadAEntregar", "CantidadPendiente", "MedidaAlterna", "CantidadAFacturarAlterna", "CantidadAEntregarAlterna", "CFVenta_Id", "Observaciones", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Existencia", "Marcado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla4 = { "Cantidad", "CantidadAlterna", "Existencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            venFacturacionPedidoDS dsTipado = new venFacturacionPedidoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.Ubicaciones.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static venFacturacionPedidoDS DatosFacturaIdentity(int /*0*/lIdentity, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/lIdentity };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venFacturacionPedidoDatos_Identity", parametros);

            string[] camposTabla0 = { "Fecha", "Cliente_Id", "Sucursal", "NombreFantasia", "Moneda_Id", "DescripcionMonedas", "MonedaFacturacion", "DescripcionMonFacturacion", "CondPagoCli_Id", "DescripcionCondPago", "ListaPrecio_Id", "DescripcionListasPrecios", "Vendedor_Id", "DescripcionVendedores", "FormaEntrega_Id", "DescripcionFormaEntrega", "UsuarioAutoriz_Id", "DescripcionUsuarioAutoriz", "FechaAutorizo", "Observaciones", "ObservEstado", "Motivo_Id", "ObsAnticipo", "Cambio", "Incoterm_Id", "DescripcionIncoterm", "MetodoPago", "UsoCfdi", "DescripcionUsoCfdi", "DescripcionMetodoPago", "Timbrar", "SegmentoStr" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Producto_Id", "DescripcionProductos", "Medida_Id", "DescripcionUniMed", "Deposito_Id", "DescripcionDepositos", "CantidadAFacturar", "CantidadAEntregar", "CantidadPendiente", "CantidadAFacturarAlterna", "CantidadAEntregarAlterna", "CFVenta_Id", "Observaciones", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla4 = { "Cantidad" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            venFacturacionPedidoDS dsTipado = new venFacturacionPedidoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.Ubicaciones.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static venPedidosPendClieDS PendClie(string /*0*/pCliente_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pCliente_Id };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venPedidosPendClie", parametros);

            string[] camposTabla0 = { "Segmento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venPedidosPendClieDS dsTipado = new venPedidosPendClieDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static venPedidosPorClienteDS PedidosPorCliente(string /*0*/Cliente_Id, int /*1*/Empresa_Id, bool /*2*/Historico, DateTime /*3*/FechaDesde, DateTime /*4*/FechaHasta,  string Vendedor_Id, string /*5*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Cliente_Id, /*1*/Empresa_Id, /*2*/Historico, /*3*/FechaDesde, /*4*/FechaHasta, new Generalidades.NullableString(Vendedor_Id) };
            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);
            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venPedidosPorCliente", parametros);

            string[] camposTabla0 = { "Historico", "FechaDesde", "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Segmento", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Pedidos", "Remitidos", "Precio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            venPedidosPorClienteDS dsTipado = new venPedidosPorClienteDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Pedidos.TableName, dsTipado.Productos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }




        public static void Eliminar(int /*0*/lIdentity, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/lIdentity };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venPedidosEliminar", parametros);
        }

        public static int Guardar(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N,
           int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C,
           string /*10*/pSubTipoMov_Id, DateTime /*11*/pFecha, string /*12*/pCliente_Id, int /*13*/pSucursal, string /*14*/pSucursalUsu,
           string /*15*/pMoneda_Id, string /*16*/pMonedaFacturacion, string /*17*/pCondPagoCli_Id, string /*18*/pListaPrecio_Id,
           string /*19*/pVendedor_Id, string /*20*/pFormaEntrega_Id, string /*21*/pEstado, string /*22*/pUsuarioAutoriz_Id,
           DateTime /*23*/pFechaAutorizo, string /*24*/pObservaciones, string /*25*/pObservEstado, short /*26*/pMotivo_Id, decimal /*27*/pImporteTotal,
           decimal /*28*/pBonificacion1, decimal /*29*/pBonificacion2, decimal /*30*/pBonificacion3, decimal /*31*/pBonificacion4,
           decimal /*32*/pBonificacion5, decimal /*33*/pDato1, decimal /*34*/pDato2, decimal /*35*/pDato3, DateTime /*36*/pFechaUltMod,
           string /*37*/pCliOrdenCompra, string /*38*/pvenNroPedido, bool /*39*/pFacturaAnticipo, bool /*40*/pTrabaDespacho, decimal /*41*/pPorAnticipo,
           decimal /*42*/pAnticipo, decimal /*43*/pAnticipoPendiente, string /*44*/pObsAnticipo, string /*45*/pTipoPrecioForm,
           bool /*46*/pCongelaCambio, DateTime /*47*/pFecha_Registro, decimal /*48*/pCambio, string /*49*/pIncoterm_Id, bool /*50*/pSoloEntrega,
           int /*51*/pUsuario_Id, bool /*52*/pPosteado, string /*53*/pMetodoPago, string /*54*/pUsoCfdi, decimal /*55*/pSubTotal,
           decimal /*56*/pSubTotalBonif, string /*57*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N,
                /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C, /*10*/pSubTipoMov_Id, /*11*/pFecha,
                new Generalidades.NullableString(/*12*/pCliente_Id), new Generalidades.NullableInt(/*13*/pSucursal), /*14*/pSucursalUsu,
                new Generalidades.NullableString(/*15*/pMoneda_Id), new Generalidades.NullableString(/*16*/pMonedaFacturacion),
                new Generalidades.NullableString(/*17*/pCondPagoCli_Id), new Generalidades.NullableString(/*18*/pListaPrecio_Id),
                new Generalidades.NullableString(/*19*/pVendedor_Id), new Generalidades.NullableString(/*20*/pFormaEntrega_Id), /*21*/pEstado,
                new Generalidades.NullableString(/*22*/pUsuarioAutoriz_Id), new Generalidades.NullableDate(/*23*/pFechaAutorizo),
                new Generalidades.NullableString(/*24*/pObservaciones), new Generalidades.NullableString(/*25*/pObservEstado),
                new Generalidades.NullableShort(/*26*/pMotivo_Id), /*27*/pImporteTotal, /*28*/pBonificacion1, /*29*/pBonificacion2,
                /*30*/pBonificacion3, /*31*/pBonificacion4, /*32*/pBonificacion5, /*33*/pDato1, /*34*/pDato2, /*35*/pDato3, /*36*/pFechaUltMod,
                /*37*/pCliOrdenCompra, /*38*/pvenNroPedido, /*39*/pFacturaAnticipo, /*40*/pTrabaDespacho, /*41*/pPorAnticipo, /*42*/pAnticipo,
                /*43*/pAnticipoPendiente, new Generalidades.NullableString(/*44*/pObsAnticipo), /*45*/pTipoPrecioForm, /*46*/pCongelaCambio,
                /*47*/pFecha_Registro, /*48*/pCambio, new Generalidades.NullableString(/*49*/pIncoterm_Id), /*50*/pSoloEntrega, /*51*/pUsuario_Id,
                /*52*/pPosteado, /*53*/pMetodoPago, /*54*/pUsoCfdi, /*55*/pSubTotal, /*56*/pSubTotalBonif };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            return ((int)oiDAAB.guardar("venPedidosGuardar", parametros));
        }


        public static void Autorizar(int /*0*/pvenPedidos, int /*1*/pUsuario_Id, string /*2*/pObservEstado, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos, /*1*/pUsuario_Id, /*2*/pObservEstado };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venPedidosAutorizar", parametros);
        }

        public static void Rechazar(int /*0*/pvenPedidos, int /*1*/pUsuario_Id, string /*2*/pObservEstado, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos, /*1*/pUsuario_Id, /*2*/pObservEstado };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venPedidosRechazar", parametros);
        }

        public static venPedidosAnticipoDS DatosAnticipo(int /*0*/pEmpresa_Id, string /*1*/pSegmento_id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venPedidosAnticipoDatos", parametros);

            string[] camposTabla0 = { "FechaFactura", "Cliente_Id", "Sucursal", "NombreFantasia", "Moneda_Id", "DescripcionMonedas", "MonedaFacturacion", "DescripcionMonFacturacion", "CondPagoCli_Id", "DescripcionCondPago", "ListaPrecio_Id", "DescripcionListasPrecios", "Vendedor_Id", "DescripcionVendedores", "FormaEntrega_Id", "DescripcionFormaEntrega", "UsuarioAutoriz_Id", "DescripcionUsuarioAutoriz", "Observaciones", "ObsAnticipo", "MetodoPago", "UsoCfdi", "DescripcionUsoCfdi", "DescripcionMetodoPago", "Timbrar" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venPedidosAnticipoDS dsTipado = new venPedidosAnticipoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void AplicarAnticipo(int /*0*/pvenPedidos, decimal /*1*/pMonto, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos, /*1*/pMonto };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venPedidosAplicarAnticipo", parametros);
        }


        public static venPedidosFacturaAnticipoDS DatosFacturaAnticipo(int /*0*/pVenPedidos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pVenPedidos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venPedidosFacturaAnticipo", parametros);

            venPedidosFacturaAnticipoDS dsTipado = new venPedidosFacturaAnticipoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void CambiarEstado(int /*0*/pvenPedidos, string /*1*/pEstado, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos, /*1*/pEstado };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venPedidosCambiarEstado", parametros);
        }


        public static venPedidosEstadoDS EstadoDatos(int /*0*/pvenPedidos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venPedidosEstadoDatos", parametros);

            string[] camposTabla0 = { "UsuarioAutoriz_Id", "Pendiente", "CantidadPedida", "CantidadRemitida", "CantidadFacturada" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venPedidosEstadoDS dsTipado = new venPedidosEstadoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        /// <summary>
        /// Regresa los saldos de anticipos Facturados
        /// </summary>
        /// <param name="venPedidos"></param>
        /// <param name="pAuxiliar"></param>
        /// <returns></returns>
        public static venPedidosAnticipoFactDS DatosAniticposFact(int /*0*/venPedidos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/venPedidos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venPedidosAnticipoFactDatos", parametros);

            string[] camposTabla0 = { "ImporteFac", "ImporteOriginalFac", "ImporteNC", "ImporteOriginalNC" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venPedidosAnticipoFactDS dsTipado = new venPedidosAnticipoFactDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void MotivoGuardar(int /*0*/pvenPedidos, short /*1*/pMotivo, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenPedidos, /*1*/new Generalidades.NullableShort(pMotivo) };
            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venPedidosMotivosGuardar", parametros);
        }




    }
}
