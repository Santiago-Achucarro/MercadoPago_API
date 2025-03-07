INSERT INTO venSubTipoMov(Administrativa, AdmiteBoniRenglon, AdmiteDevolucion, AdmiteFactsinEntr, AfectaComCobra, AfectaComVenta, AfectaEstadistica, BajoCosto, CantidadCopias, Centro1_Id, Centro2_Id, ClaveAcceso, CodigoFiscal, 
CodigoFormulario, CtaDefecto, CtaOtrosCargos, Descripcion, Empresa_Id, EsPorDifCambio, EsPorDifPrecio, EsquemaAuto_Id, EsVentaContado, 
FechaEntregaporRen, GeneraRemito, Inactivo, MaxCantItems, ModCentro1, ModCentro2, ModCobrador, ModCondPago, ModCtaDefecto, 
ModDeposito, ModFecha, ModificaPrecio, ModiUniMed, ModListaPrecios, ModVendedor, MueveStock, NCxDevolucion, PermiteSoloEntrega, 
PermModCtaOtCar, PideCambio, PideCodProd, PideComExpoMX, PideCongelarCambio, PideFechaEntrega, PideMarcaReserva, PideObervaciones, 
PideObsReng, PideOrdenCompra, PideOtrosCargos, PidePredial, PideReferencia, PorCotizacion, Posteado, Reporte_Id, 
Reservado, SegmentoRemito_Id, SoloImpuestos, SubTipoMov_Id, TipoPrecioForm, Usuario_Id, UsuarioAutorizado, venTipoMov) 
VALUES(0, 0, 0, 0, 0, 0, 0, 0, 1, Null, Null, '', Null, Null, NULL, Null, 'Factura por cheque rechazado', 1, 0, 0, Null, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, NULL, 0, Null, 0, 'FCCHR', 'S', 1, 2,  'F')
GO

Insert Into comMovTipos (TipoMov, Descripcion, Signo) Values ('H', 'Cheque_rechazado', -1)

INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema, SoloLectura, lupIdentidad, WhereF10, cValor, nValor, fValor, mValor) VALUES(1, 'UMCADAUNO','Codigo de UM que representa Unidades', 'C',5,0,'STK', 0, null, null, NULL, NULL, Null, null)	
INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema, SoloLectura, lupIdentidad, WhereF10, cValor, nValor, fValor, mValor) VALUES(1, 'CFVentasRenglonGravado','CF Gravado renglon facturacion', 'C',5,0,'VEN', 0, null, null, NULL, NULL, Null, null)	
INSERT INTO genGlobales (Empresa_Id, Nombre_Var, Descripcion, Tipo, Longitud, Decimales, SubSistema, SoloLectura, lupIdentidad, WhereF10, cValor, nValor, fValor, mValor) VALUES(1, 'SUBTIPOCHR','Codigo de SubTipoMov Cheque Rechazado', 'C',5,0,'VEN', 0, null, null, NULL, NULL, Null, null)	
Go


INSERT INTO genVersion (Version) Values(1018.10)