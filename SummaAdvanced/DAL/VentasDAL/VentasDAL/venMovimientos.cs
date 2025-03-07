using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using interfaceDAAB;
using System.Data;


namespace VentasDAL
{
    public class venMovimientos
    {

        public static venMovimientosConStockDS DatosConStock(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venMovimientosConStockDatos", parametros);

            string[] camposTabla0 = { "Observaciones", "Cliente_Id", "Sucursal", "NombreFantasia", "SubTipoMov_Id", "DescripcionSubTipoMov", "CondPagoCli_Id", "DescripcionCondPago", "Vendedor_Id", "DescripcionVendedores", "Cobrador_Id", "DescripcionCobradores", "FormaEntrega_Id", "DescripcionFormaEntrega", "CondFisc_Id", "DescripcionCondFiscal", "SubTotal", "SubTotalBonif", "ComprobanteDesde", "Incoterm_Id", "DescripcionIncoterm", "CtaClientes", "DescripcionCtaClientes", "Centro1DXV_Id", "DescripcionCentro1DXV", "Centro2DXV_Id", "DescripcionCentro2DXV", "TipomovCont", "Clase", "ImporteContable", "LlamarAlWSFE", "SegmentoStr", "NoRecalcular", "SinEntrega", "EsSaldoInicial", "AceptarDatosExternos" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla2 = { "RenglonReferencia", "Producto_Id", "CFVenta_Id", "DescripcionProductos", "Deposito_Id", "DescripcionDepositos", "Medida_Id", "DescripcionUniMed", "MedidaAlterna", "Observaciones", "CantidadAduana", "UnidadAduana", "ValorUnitarioAduana", "ValorDolares", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "Despacho_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla4 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            string[] camposTabla5 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla8 = { "ClaveFiscal", "Fecha", "Letra", "Comprobante_Id", "DescripcionTipoComp", "EsFactElec", "Motivo", "XMLFiscal", "SelloDigital", "FechaString", "SelloFiscal", "NoCertificadoFiscal", "NoCertificadoPropio", "FechaAutorizacion", "FechaDesde", "NumeroDesde", "NumeroHasta", "RfcProvCertif", "Leyenda", "TipoProceso", "TipoComite", "idContabilidad" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

            string[] camposTabla9 = { "Ambito" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[9], camposTabla9);

            string[] camposTabla10 = { "MetodoPago", "CuentaPago", "NMetodoPago", "UsoCfdi" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[10], camposTabla10);

            string[] camposTabla11 = { "Motivo_id", "NumCertificadoOrigen", "NumeroExportadorConfiable", "Observaciones", "TipoCambioUSD", "TotalUSD", "PropNumRegIdTrib", "PropResidenciaFiscal", "ReceptorNumRegIdTrib", "Destinatario_id", "SucursalDest" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[11], camposTabla11);

            string[] camposTabla12 = { "TipoRelacion", "Segmento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[12], camposTabla12);

            string[] camposTabla13 = { "TipoRelacion", "Segmento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[13], camposTabla13);

            string[] camposTabla14 = { "Cantidad", "Vencimiento", "Ubicacion_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[14], camposTabla14);

            string[] camposTabla21 = { "Causa" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[21], camposTabla21);

            string[] camposTabla22 = { "UnidadPeso", "Remolque1", "DescripcionRemolque1", "Remolque2", "DescripcionRemolque2", "RFCRemitente", "NombreRemitente", "NumRegIdTribO", "NumEstacionO", "NombreEstacionO", "NavegacionTraficoO", "NumeroExteriorOrigen", "NumerointeriorOrigen", "ColoiniaOrigen", "DescripcionColoniaO", "LocalidadOrigen", "DescripcionLocalidadO", "ReferenciaOrigen", "MunicipioOrigen", "DescripcionMunicipioO", "EstadoO", "CodigoPostalOrigen", "RFCDestinatario", "NombreDestinatario", "NumRegIdTribD", "NumEstacionD", "NombreEstacionD", "NavegacionTraficoD", "NumeroExteriorDestino", "NumerointeriorDestino", "ColoiniaDestino", "DescripcionColoniaD", "LocalidadDestino", "DescripcionLocalidadD", "ReferenciaDestino", "MunicipioDestino", "DescripcionMunicipioD", "EstadoD", "CodigoPostalDestino" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[22], camposTabla22);

            string[] camposTabla23 = { "BienesTransp", "ClaveSTCC", "Descripcion", "Dimensiones", "MaterialPeligroso", "CveMaterialPeligroso", "Embalaje", "DescripEmbalaje", "FraccionArancelaria", "UUIDComercioExt" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[23], camposTabla23);

            string[] camposTabla24 = { "Importe", "Ponderado", "T3Coeficiente" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[24], camposTabla24);

            venMovimientosConStockDS dsTipado = new venMovimientosConStockDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.venMovConStock.TableName, dsTipado.grdCuerpo.TableName, dsTipado.grdCuentasRenglon.TableName, dsTipado.grdImpuestos.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.grdCuotas.TableName, dsTipado.grdImpuestosRenglon.TableName, dsTipado.venMovFiscal.TableName, dsTipado.venMovFiscalINE.TableName, dsTipado.venMovMetodoPago.TableName, dsTipado.venMovExportaciones.TableName, dsTipado.venComprobAsoc.TableName, dsTipado.venMovimientosCFDIR.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.Anticipo.TableName, dsTipado.Ubicaciones.TableName, dsTipado.UbicacionesE.TableName, dsTipado.ConsStock.TableName, dsTipado.ConsDetalle.TableName, dsTipado.Cotizacion.TableName, dsTipado.Anulacion.TableName, dsTipado.CartaPorte.TableName, dsTipado.CPMercancias.TableName, dsTipado.Cobranza.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static venMovimientosDS Datos(long /*0*/pIdentity, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pIdentity };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venMovimientosDatos", parametros);

            string[] camposTabla0 = { "Observaciones", "Cliente_Id", "Sucursal", "NombreFantasia", "SubTipoMov_Id", "DescripcionSubTipoMov",
                "CondPagoCli_Id", "DescripcionCondPago", "Vendedor_Id", "DescripcionVendedores", "Cobrador_Id", "DescripcionCobradores",
                "FormaEntrega_Id", "DescripcionFormaEntrega", "CondFisc_Id", "DescripcionCondFiscal", "ComprobanteDesde", "Incoterm_Id",
                "DescripcionIncoterm", "CtaClientes", "DescripcionCtaClientes", "Centro1DXV_Id", "DescripcionCentro1DXV", "Centro2DXV_Id",
                "DescripcionCentro2DXV", "TipomovCont", "Clase", "ImporteContable", "LlamarAlWSFE", "SegmentoStr", "NoRecalcular", "SinEntrega",
                "EsSaldoInicial", "AceptarDatosExternos", "SubTotal", "SubTotalBonif"};

            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venMovimientosDS dsTipado = new venMovimientosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pvenMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pvenMovimientos };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("venMovimientosEliminar", parametros);
        }

        public static void Guardar(int /*0*/pEmpresa_Id, long /*1*/pvenMovimientos, string /*2*/pCliente_Id, int /*3*/pSucursal,
            string /*4*/pvenSubTipoMov_Id, string /*5*/pCondPagoCli_Id, string /*6*/pVendedor_Id, string /*7*/pCobrador_Id, string /*8*/pFormaEntrega_Id,
            string /*9*/pCondFisc_Id, decimal /*10*/pImporte, decimal /*11*/pSaldo, decimal /*12*/pSubTotal, decimal /*13*/pSubTotalBonif,
            decimal /*14*/pComision1, decimal /*15*/pComision2, decimal /*16*/pBonificacion1, decimal /*17*/pBonificacion2, decimal /*18*/pBonificacion3,
            decimal /*19*/pBonificacion4, decimal /*20*/pBonificacion5, decimal /*21*/pDato1, decimal /*22*/pDato2, decimal /*23*/pDato3,
            bool /*24*/pCobraAbasto, bool /*25*/pCambioFijo, int /*26*/pComprobanteDesde, int /*27*/pTipoPago, string /*28*/pIncoterm_Id,
            string /*29*/pVenTipoMov, string /*30*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pvenMovimientos, new Generalidades.NullableString(/*2*/pCliente_Id),
                new Generalidades.NullableInt(/*3*/pSucursal), new Generalidades.NullableString(/*4*/pvenSubTipoMov_Id),
                new Generalidades.NullableString(/*5*/pCondPagoCli_Id), new Generalidades.NullableString(/*6*/pVendedor_Id),
                new Generalidades.NullableString(/*7*/pCobrador_Id), new Generalidades.NullableString(/*8*/pFormaEntrega_Id),
                new Generalidades.NullableString(/*9*/pCondFisc_Id), /*10*/pImporte, /*11*/pSaldo, /*12*/pSubTotal, /*13*/pSubTotalBonif,
                /*14*/pComision1, /*15*/pComision2, /*16*/pBonificacion1, /*17*/pBonificacion2, /*18*/pBonificacion3, /*19*/pBonificacion4,
                /*20*/pBonificacion5, /*21*/pDato1, /*22*/pDato2, /*23*/pDato3, /*24*/pCobraAbasto, /*25*/pCambioFijo,
                new Generalidades.NullableInt(/*26*/pComprobanteDesde), /*27*/pTipoPago, new Generalidades.NullableString(/*28*/pIncoterm_Id),
                /*29*/pVenTipoMov };

            Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("venMovimientosGuardar", parametros);
        }

        public static venMovimientosSinStockDS DatosSinStock(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venMovimientosSinStockDatos", parametros);

            string[] camposTabla0 = { "Observaciones", "Cliente_Id", "Sucursal", "NombreFantasia", "SubTipoMov_Id", "DescripcionSubTipoMov", "CondPagoCli_Id", "DescripcionCondPago", "Vendedor_Id", "DescripcionVendedores", "Cobrador_Id", "DescripcionCobradores", "FormaEntrega_Id", "DescripcionFormaEntrega", "CondFisc_Id", "DescripcionCondFiscal", "ComprobanteDesde", "Incoterm_Id", "DescripcionIncoterm", "CtaClientes", "DescripcionCtaClientes", "Centro1DXV_Id", "DescripcionCentro1DXV", "Centro2DXV_Id", "DescripcionCentro2DXV", "TipomovCont", "Clase", "ImporteContable", "LlamarAlWSFE", "SegmentoStr", "NoRecalcular", "SinEntrega", "EsSaldoInicial", "AceptarDatosExternos" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "CFVenta_Id", "DescripcionCondFisVenta", "Medida_Id", "DescripcionUniMed", "Cuenta_Id", "DescripcionCuenta", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2", "CodigoFiscal", "Producto_Id", "CuentaPredial" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla6 = { "ClaveFiscal", "Fecha", "Letra", "Comprobante_Id", "DescripcionTipoComp", "EsFactElec", "Motivo", "XMLFiscal", "SelloDigital", "FechaString", "SelloFiscal", "NoCertificadoFiscal", "NoCertificadoPropio", "FechaAutorizacion", "FechaDesde", "NumeroDesde", "NumeroHasta", "RfcProvCertif", "Leyenda", "TipoProceso", "TipoComite" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            string[] camposTabla7 = { "Ambito" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            string[] camposTabla8 = { "MetodoPago", "CuentaPago", "NMetodoPago", "UsoCfdi" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

            string[] camposTabla9 = { "TipoRelacion", "Segmento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[9], camposTabla9);

            string[] camposTabla10 = { "TipoRelacion", "Segmento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[10], camposTabla10);

            string[] camposTabla12 = { "Importe" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[12], camposTabla12);

            string[] camposTabla13 = { "Causa" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[13], camposTabla13);

            venMovimientosSinStockDS dsTipado = new venMovimientosSinStockDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName, dsTipado.grdImpuestos.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.grdCuotas.TableName, dsTipado.grdImpuestosRenglon.TableName, dsTipado.venMovFiscal.TableName, dsTipado.venMovFiscalINE.TableName, dsTipado.venMovMetodoPago.TableName, dsTipado.venComprobAsoc.TableName, dsTipado.venMovimientosCFDIR.TableName, dsTipado.Anticipo.TableName, dsTipado.DifCambio.TableName, dsTipado.Anulacion.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





        public static venMovimientosConsultaDS DatosConsulta(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venMovimientosConsultaDatos", parametros);

            string[] camposTabla0 = { "Observaciones", "Cliente_Id", "Sucursal", "NombreFantasia", "SubTipoMov_Id", "DescripcionSubTipoMov", "CondPagoCli_Id", "DescripcionCondPago", "Vendedor_Id", "DescripcionVendedores", "Cobrador_Id", "DescripcionCobradores", "FormaEntrega_Id", "DescripcionFormaEntrega", "CondFisc_Id", "DescripcionCondFiscal", "ComprobanteDesde", "Incoterm_Id", "DescripcionIncoterm", "CtaClientes", "DescripcionCtaClientes", "Centro1DXV_Id", "DescripcionCentro1DXV", "Centro2DXV_Id", "DescripcionCentro2DXV", "TipomovCont", "Clase", "ImporteContable", "LlamarAlWSFE", "SegmentoStr", "NoRecalcular", "SinEntrega", "EsSaldoInicial", "AceptarDatosExternos" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla2 = { "Producto_Id", "Detalle", "CFVenta_Id", "DescripcionCondFisVenta", "Deposito_Id", "DescripcionDepositos", "Medida_Id", "DescripcionUniMed", "MedidaAlterna", "Observaciones", "FechaEntrega" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla4 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            string[] camposTabla8 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

            string[] camposTabla9 = { "ClaveFiscal", "Fecha", "Letra", "Comprobante_Id", "DescripcionTipoComp", "EsFactElec", "Motivo", "XMLFiscal", "SelloDigital", "FechaString", "SelloFiscal", "NoCertificadoFiscal", "NoCertificadoPropio", "FechaAutorizacion", "FechaDesde", "NumeroDesde", "NumeroHasta", "RfcProvCertif", "Leyenda", "TipoProceso", "TipoComite" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[9], camposTabla9);

            string[] camposTabla11 = { "Causa" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[11], camposTabla11);

            venMovimientosConsultaDS dsTipado = new venMovimientosConsultaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.venMovConStock.TableName, dsTipado.grdCuerpo.TableName, dsTipado.grdImpuestos.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.grdCuotas.TableName, dsTipado.grdImpuestosRenglonCS.TableName, dsTipado.grdImpuestosRenglonSS.TableName, dsTipado.grdCuentasRenglon.TableName, dsTipado.venMovimientosFiscal.TableName, dsTipado.Anticipo.TableName, dsTipado.Anulacion.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static XmlComprobanteDS DatosCFDI(long /*0*/Asiento_Id, string /*1*/TipoPrecio, string /*2*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/Asiento_Id, /*1*/TipoPrecio };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("Ventas_XmlComprobante", parametros);

            string[] camposTabla0 = { "NoCertificado", "Certificado", "CondicionesDePago", "SubTotal", "Descuento", "Moneda", "LugarExpedicion" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "TipoRelacion" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "TipoRelacion", "UUID" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "EmpPrivateKey", "Colonia", "Localidad", "Municipio", "Provincia", "Pais", "CodLocalidad", "CodColonia", "CodMunicipio" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla4 = { "Provincia", "Pais", "RegimenFiscalReceptor", "ObjetoImp" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            string[] camposTabla5 = { "NoIdentificacion", "ClaveUnidad", "Descripcion", "ValorUnitario", "Importe", "Descuento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "NroPedimento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            string[] camposTabla8 = { "Impuesto", "TasaOCuota", "Importe" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

            string[] camposTabla9 = { "Impuesto", "TasaOCuota" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[9], camposTabla9);

            string[] camposTabla11 = { "Impuesto", "TasaOCuota" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[11], camposTabla11);

            string[] camposTabla12 = { "Impuesto", "TasaOCuota", "Importe" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[12], camposTabla12);

            string[] camposTabla13 = { "UUID", "FechaTimbrado", "SelloCFD", "NoCertificadoSAT", "SelloSAT" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[13], camposTabla13);

            string[] camposTabla14 = { "TipoProceso", "TipoComite" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[14], camposTabla14);

            string[] camposTabla15 = { "Ambito" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[15], camposTabla15);

            string[] camposTabla16 = { "Motivo_id", "NumeroExportadorConfiable", "Observaciones", "TipoCambioUSD", "TotalUSD", "PropNumRegIdTrib", "PropResidenciaFiscal", "ReceptorNumRegIdTrib", "Destinatario_id", "SucursalDest", "RazonSocial", "Calle", "NroExterior", "NroInterior", "Colonia", "Localidad", "Provincia", "Pais", "CodigoPostal", "NumRegIdTrib" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[16], camposTabla16);

            string[] camposTabla17 = { "CantidadAduana", "UnidadAduana", "ValorUnitarioAduana", "ValorDolares", "FraccionArancelaria" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[17], camposTabla17);

            string[] camposTabla18 = { "UnidadPeso", "Patente_Id", "Descripcion", "Modelo", "ConfVehicular", "Marca", "NroPoliza", "NombreAseg", "TipoPermisoSCT", "NroPermisoSCT", "AseguraMedAmb", "PolizaMedAmbiente", "AseguraCarga", "PolizaCarga", "PrimaSeguro", "PatenteR1", "DescripcionR1", "ModeloR1", "ConfVehicularR1", "MarcaR1", "NroPolizaR1", "NombreAsegR1", "TipoPermisoSCTR1", "NroPermisoSCTR1", "AseguraMedAmbR1", "PolizaMedAmbienteR1", "AseguraCargaR1", "PolizaCargaR1", "PrimaSeguroR1", "PatenteR2", "DescripcionR2", "ModeloR2", "ConfVehicularR2", "MarcaR2", "NroPolizaR2", "NombreAsegR2", "TipoPermisoSCTR2", "NroPermisoSCTR2", "AseguraMedAmbR2", "PolizaMedAmbienteR2", "AseguraCargaR2", "PolizaCargaR2", "PrimaSeguroR2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[18], camposTabla18);

            string[] camposTabla19 = { "TipoEstacion", "DistanciaRecorrida" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[19], camposTabla19);

            string[] camposTabla20 = { "RFCRemitente", "NombreRemitente", "NumRegIdTrib", "ResidenciaFiscal", "NumEstacion", "NombreEstacion", "NavegacionTrafico", "NumeroExterior", "Numerointerior", "Colonia", "Localidad", "Referencia", "Municipio", "Estado", "Pais", "CodigoPostal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[20], camposTabla20);

            string[] camposTabla21 = { "RFCDestinatario", "NombreDestinatario", "NumRegIdTrib", "ResidenciaFiscal", "NumEstacion", "NombreEstacion", "NavegacionTrafico", "NumeroExterior", "Numerointerior", "Colonia", "Localidad", "Referencia", "Municipio", "Estado", "Pais", "CodigoPostal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[21], camposTabla21);

            string[] camposTabla22 = { "BienesTransp", "ClaveSTCC", "Descripcion", "Medida_id", "Dimensiones", "MaterialPeligroso", "CveMaterialPeligroso", "Embalaje", "DescripEmbalaje", "PesoEnKg", "ValorMercancia", "FraccionArancelaria", "UUIDComercioExt" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[22], camposTabla22);

            string[] camposTabla23 = { "NumRegIdTrib", "Nombre", "NumeroExterior", "Numerointerior", "Colonia", "Localidad", "Referencia", "Municipio", "Estado", "Pais", "CodigoPostal" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[23], camposTabla23);

            string[] camposTabla24 = { "ConfVehicular", "PropArre", "Rfc", "Nombre", "ResidenciaFiscal", "NumRegIdTrib", "Calle", "NumeroExterior", "Numerointerior", "Colonia", "Localidad", "Municipio", "CodigoPostal", "Estado", "Referencia", "Pais" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[24], camposTabla24);

            string[] camposTabla25 = { "ResidenciaFiscal", "NumeroExterior", "Numerointerior", "Colonia", "Localidad", "Municipio", "CodigoPostal", "Estado", "Referencia", "Pais" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[25], camposTabla25);

            XmlComprobanteDS dsTipado = new XmlComprobanteDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.TipoRelacion.TableName, dsTipado.TipoRelaciones.TableName, dsTipado.Emisor.TableName, dsTipado.Receptor.TableName, dsTipado.Concepto.TableName, dsTipado.Pedimento.TableName, dsTipado.CuentaPredial.TableName, dsTipado.RetencionProd.TableName, dsTipado.TrasladoProd.TableName, dsTipado.Impuestos.TableName, dsTipado.Traslados.TableName, dsTipado.Retenciones.TableName, dsTipado.Complemento.TableName, dsTipado.INE.TableName, dsTipado.INECuerpo.TableName, dsTipado.Exportaciones.TableName, dsTipado.ExportacionCuerpo.TableName, dsTipado.CartaPorte.TableName, dsTipado.Ubicaciones.TableName, dsTipado.Origenes.TableName, dsTipado.Destinos.TableName, dsTipado.Mercancias.TableName, dsTipado.Destinatarios.TableName, dsTipado.Camiones.TableName, dsTipado.Operadores.TableName, dsTipado.Global.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }







        public static venMovimientosDS DatosSeg(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N,
    int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C,
    string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N,
                /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venMovimientosDatosSeg", parametros);

            string[] camposTabla0 = { "Observaciones", "Cliente_Id", "Sucursal", "NombreFantasia", "SubTipoMov_Id", "DescripcionSubTipoMov",
                "CondPagoCli_Id", "DescripcionCondPago", "Vendedor_Id", "DescripcionVendedores", "Cobrador_Id", "DescripcionCobradores",
                "FormaEntrega_Id", "DescripcionFormaEntrega", "CondFisc_Id", "DescripcionCondFiscal", "ComprobanteDesde", "Incoterm_Id",
                "DescripcionIncoterm", "CtaClientes", "DescripcionCtaClientes", "Centro1DXV_Id", "DescripcionCentro1DXV", "Centro2DXV_Id",
                "DescripcionCentro2DXV", "TipomovCont", "Clase", "ImporteContable", "LlamarAlWSFE", "SegmentoStr", "NoRecalcular", "SinEntrega",
                "EsSaldoInicial", "AceptarDatosExternos", "SubTotal", "SubTotalBonif"};

            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venMovimientosDS dsTipado = new venMovimientosDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static venCancPendientesDS PendientesCanc(DateTime /*0*/FechaDesde, DateTime /*1*/FechaHasta, int /*2*/Empresa, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/FechaDesde, /*1*/FechaHasta, /*2*/Empresa };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("venCancPendientes", parametros);

            string[] camposTabla0 = { "FechaDesde", "FechaHasta" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venCancPendientesDS dsTipado = new venCancPendientesDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Movimientos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static venMovimientosConsultaDrillDownDS DatosDrillDown(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venMovimientosConsultaDrillDown", parametros);

            string[] camposTabla0 = { "Observaciones", "Cliente_Id", "Sucursal", "NombreFantasia", "SubTipoMov_Id", "DescripcionSubTipoMov", "CondPagoCli_Id", "DescripcionCondPago", "Vendedor_Id", "DescripcionVendedores", "Cobrador_Id", "DescripcionCobradores", "FormaEntrega_Id", "DescripcionFormaEntrega", "CondFisc_Id", "DescripcionCondFiscal", "SubTotal", "SubTotalBonif", "ComprobanteDesde", "Incoterm_Id", "DescripcionIncoterm", "CtaClientes", "DescripcionCtaClientes", "Centro1DXV_Id", "DescripcionCentro1DXV", "Centro2DXV_Id", "DescripcionCentro2DXV", "TipomovCont", "Clase", "ImporteContable", "LlamarAlWSFE", "SegmentoStr", "NoRecalcular", "SinEntrega", "EsSaldoInicial", "AceptarDatosExternos" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Producto_Id", "Observaciones", "SubTotal", "MedidaAlterna" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "ClaveFiscal", "Fecha", "Letra", "Comprobante_Id", "DescripcionTipoComp", "EsFactElec", "Motivo", "XMLFiscal", "SelloDigital", "FechaString", "SelloFiscal", "NoCertificadoFiscal", "NoCertificadoPropio", "FechaAutorizacion", "FechaDesde", "NumeroDesde", "NumeroHasta", "RfcProvCertif", "Leyenda", "TipoProceso", "TipoComite", "idContabilidad" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla4 = { "Ambito" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[4], camposTabla4);

            string[] camposTabla5 = { "MetodoPago", "CuentaPago", "NMetodoPago", "UsoCfdi" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "TipoRelacion", "Segmento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            string[] camposTabla7 = { "TipoRelacion", "Segmento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            string[] camposTabla9 = { "Cantidad", "Vencimiento", "Ubicacion_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[9], camposTabla9);

            string[] camposTabla13 = { "Relacionado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[13], camposTabla13);

            string[] camposTabla14 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[14], camposTabla14);

            venMovimientosConsultaDrillDownDS dsTipado = new venMovimientosConsultaDrillDownDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName, dsTipado.Impuestos.TableName, dsTipado.venMovFiscal.TableName, dsTipado.venMovFiscalINE.TableName, dsTipado.venMovMetodoPago.TableName, dsTipado.venComprobAsoc.TableName, dsTipado.venMovimientosCFDIR.TableName, dsTipado.Anticipo.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.MoviAnticipo.TableName, dsTipado.UbicacionesE.TableName, dsTipado.Ubicaciones.TableName, dsTipado.Relacionados.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.venMovConStock.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


public static venCartaPorteDS DatosCartaDatos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venCartaPorteDatos", parametros);

            string[] camposTabla0 = { "FechaHoraSalida", "Camion_Id", "Remolque1", "Remolque2", "Operador_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Parada", "DistanciaRecorrida", "c_ColoniaEntr", "c_LocalidadEntr", "c_MunicipioEntr", "TotalDistRec", "FechaHoraProgLlegada", "FechaCP" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "BienesTransp", "Descripcion", "PesoEnKg", "MaterialPeligroso", "CveMaterialPeligroso", "Embalaje", "Marca" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            venCartaPorteDS dsTipado = new venCartaPorteDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Facturas.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }



        public static venMovimientosCPDS DatosFactCartaPorte(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venMovimientosCPDatos", parametros);

            string[] camposTabla0 = { "c_ColoniaEntr", "c_LocalidadEntr", "c_MunicipioEntr", "TotalDistRec", "FechaHoraProgLlegada", "FechaCP" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "BienesTransp", "Descripcion", "PesoEnKg", "MaterialPeligroso", "CveMaterialPeligroso", "Embalaje", "Marca" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            venMovimientosCPDS dsTipado = new venMovimientosCPDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.Cuerpo.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static venMovimientoRelacionadoDS RelacionDatos(long /*0*/venMovimientos, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/venMovimientos };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("venMovimientoRelacionadoDatos", parametros);

            string[] camposTabla0 = { "UUID" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            venMovimientoRelacionadoDS dsTipado = new venMovimientoRelacionadoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }





    }
}
