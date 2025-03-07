IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 15.02)
begin

	INSERT INTO genVersion(Version) Values(15.02);


iNSERT INTO venSubTipoMov(SubTipoMov_Id, Empresa_Id, venTipoMov, Descripcion, MueveStock, EsVentaContado, AdmiteDevolucion, ModificaPrecio, Reservado, GeneraRemito, SegmentoRemito_Id, NCxDevolucion, UsuarioAutorizado, AdmiteBoniRenglon, Centro1_Id, Centro2_Id, PideCambio, ModFecha, ModCondPago, ModVendedor, ModCobrador, PideObervaciones, CantidadCopias, ModDeposito, ModListaPrecios, PideFechaEntrega, PideObsReng, CtaDefecto, ModCtaDefecto, ModCentro1, ModCentro2, PideOtrosCargos, CtaOtrosCargos, PermModCtaOtCar, FechaEntregaporRen, AdmiteFactsinEntr, ModiUniMed, AfectaComVenta, AfectaComCobra, MaxCantItems, EsPorDifPrecio, AfectaEstadistica, ClaveAcceso, EsPorDifCambio, TipoPrecioForm, SoloImpuestos, CodigoFormulario, BajoCosto, Administrativa, PideReferencia, PideOrdenCompra, PideCongelarCambio, PideMarcaReserva, Inactivo, Usuario_Id, Posteado, PermiteSoloEntrega, CodigoFiscal, PidePredial, PideCodProd, PideComExpoMX) 
VALUES('PAGOS', 1, 'P', 'Pagos a Clientes', 0, 0, 0, 0, 0, 0, Null, 0, 2, 0, Null, Null, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, Null, 0, 0, 0, 0, Null, 0, 0, 0, 0, 0, 0, 0, 0, 0, '', 0, '', 0, Null, 0, 0, 0, 0, 0, 0, 0, 1,1, 0, Null, 0, 0, 0)

end