create table venCartaPorteFact(
	venMovimientosFactCP BigInt,  
	venMovimientosFact  BigInt, 
	Primary Key(venMovimientosFactCP))
GO

Alter Table venCartaPorteFact add constraint fkvenCartaPorteFactCP
	FOREIGN KEY (venMovimientosFactCP) References venMovimientos
GO

Alter Table venCartaPorteFact add constraint fkvenCartaPorteFactFact
	FOREIGN KEY (venMovimientosFact) References venMovimientos
GO

INSERT INTO venSubTipoMov(SubTipoMov_Id,Empresa_Id,venTipoMov,Descripcion,MueveStock,EsVentaContado,AdmiteDevolucion,ModificaPrecio,
Reservado,GeneraRemito,SegmentoRemito_Id,NCxDevolucion,UsuarioAutorizado,AdmiteBoniRenglon,Centro1_Id,Centro2_Id,PideCambio,
ModFecha,ModCondPago,ModVendedor,ModCobrador,PideObervaciones,CantidadCopias,ModDeposito,ModListaPrecios,PideFechaEntrega,
PideObsReng,CtaDefecto,ModCtaDefecto,ModCentro1,ModCentro2,PideOtrosCargos,CtaOtrosCargos,PermModCtaOtCar,FechaEntregaporRen,
AdmiteFactsinEntr,ModiUniMed,AfectaComVenta,AfectaComCobra,MaxCantItems,EsPorDifPrecio,AfectaEstadistica,ClaveAcceso,
EsPorDifCambio,TipoPrecioForm,SoloImpuestos,CodigoFormulario,BajoCosto,Administrativa,PideReferencia,PideOrdenCompra,
PideCongelarCambio,PideMarcaReserva,PermiteSoloEntrega,CodigoFiscal,PidePredial,PideCodProd,PideComExpoMX,Reporte_Id,
Inactivo,Usuario_Id,Posteado,EsquemaAuto_Id,PorCotizacion,UsaCartaPorte)
values('CPO',NULL,'M','Carta Porte',0, 0, 0,0,
1,0,null,0,2,0,null,null,0,
1,0,0,0,0,1,0,0,0,
0,null,1,1,1,0,null,0,0,
0,0,0,0,0,0,0,'',
0,'C',0,NULL,1,0,0,0,
0,0,0,NULL,0,0,0,dbo.FuncFKgenReportes('VENTRANSMX'),
0,1,1,null,0,0)
go
update venMovimientos set venSubTipoMov_Id = dbo.FuncFKvenSubTipoMov('CPO') where venTipomov = 'M'
go

insert into genVersion(Version) Values(1065.00)
GO

