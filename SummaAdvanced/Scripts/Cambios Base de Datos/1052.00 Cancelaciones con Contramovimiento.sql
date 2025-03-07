if EXISTS(select 1 from genInstalacion where Dominio_Id = 'MX')
BEGIN
INSERT INTO venTipoMov (venTipoMov,Descripcion,Signo,TipoMovResumido) Values('V','Cancelacion de Factura',-1,'CFA')
INSERT INTO venTipoMov (venTipoMov,Descripcion,Signo,TipoMovResumido) Values('W','Cancelacion de Nota de Credito',-1,'CNC')

INSERT INTO venSubTipoMov(SubTipoMov_Id,Empresa_Id,venTipoMov,Descripcion,MueveStock,EsVentaContado,AdmiteDevolucion,ModificaPrecio,
Reservado,GeneraRemito,SegmentoRemito_Id,NCxDevolucion,UsuarioAutorizado,AdmiteBoniRenglon,Centro1_Id,Centro2_Id,PideCambio,ModFecha,ModCondPago,
ModVendedor,ModCobrador,PideObervaciones,CantidadCopias,ModDeposito,ModListaPrecios,PideFechaEntrega,PideObsReng,CtaDefecto,ModCtaDefecto,
ModCentro1,ModCentro2,PideOtrosCargos,CtaOtrosCargos,PermModCtaOtCar,FechaEntregaporRen,AdmiteFactsinEntr,ModiUniMed,AfectaComVenta,
AfectaComCobra,MaxCantItems,EsPorDifPrecio,AfectaEstadistica,ClaveAcceso,EsPorDifCambio,TipoPrecioForm,SoloImpuestos,CodigoFormulario,BajoCosto,
Administrativa,PideReferencia,PideOrdenCompra,PideCongelarCambio,PideMarcaReserva,PermiteSoloEntrega,CodigoFiscal,PidePredial,PideCodProd,
PideComExpoMX,Reporte_Id,EsquemaAuto_Id,PorCotizacion,Inactivo,Usuario_Id,Posteado,UsaCartaPorte)
VALUES('-FC',NULL,'V','Cancelacion de Factura',1,0,0,1,1,0,null,1,2,1,null,null,1,1,1,
1,1,1,1,1,1,1,1,null,1,1,1,1,null,1,1,1,1,1,0,0,0,1,'',0,1,0,null,1,0,0,1,0,0,0,'',0,1,
0,null,null,0,0,1,1,0)

INSERT INTO venSubTipoMov(SubTipoMov_Id,Empresa_Id,venTipoMov,Descripcion,MueveStock,EsVentaContado,AdmiteDevolucion,ModificaPrecio,
Reservado,GeneraRemito,SegmentoRemito_Id,NCxDevolucion,UsuarioAutorizado,AdmiteBoniRenglon,Centro1_Id,Centro2_Id,PideCambio,ModFecha,ModCondPago,
ModVendedor,ModCobrador,PideObervaciones,CantidadCopias,ModDeposito,ModListaPrecios,PideFechaEntrega,PideObsReng,CtaDefecto,ModCtaDefecto,
ModCentro1,ModCentro2,PideOtrosCargos,CtaOtrosCargos,PermModCtaOtCar,FechaEntregaporRen,AdmiteFactsinEntr,ModiUniMed,AfectaComVenta,
AfectaComCobra,MaxCantItems,EsPorDifPrecio,AfectaEstadistica,ClaveAcceso,EsPorDifCambio,TipoPrecioForm,SoloImpuestos,CodigoFormulario,BajoCosto,
Administrativa,PideReferencia,PideOrdenCompra,PideCongelarCambio,PideMarcaReserva,PermiteSoloEntrega,CodigoFiscal,PidePredial,PideCodProd,
PideComExpoMX,Reporte_Id,EsquemaAuto_Id,PorCotizacion,Inactivo,Usuario_Id,Posteado,UsaCartaPorte)
VALUES('-NC',NULL,'W','Cancelacion de Nota de Credito',1,0,0,1,1,0,null,1,2,1,null,null,1,1,1,
1,1,1,1,1,1,1,1,null,1,1,1,1,null,1,1,1,1,1,0,0,0,1,'',0,1,0,null,1,0,0,1,0,0,0,'',0,1,
0,null,null,0,0,1,1,0)


END
GO

insert into genGlobales(Empresa_Id,Nombre_Var,Descripcion,Tipo,Longitud,Decimales,nValor,cValor,fValor,
mValor,SubSistema,SoloLectura,lupIdentidad,WhereF10)
SELECT genEmpresas, 'VENCANCCONTRA','Cancela con Contramovimiento','N',1,0,0,NULL,NULL, NULL, 'VEN',0, NULL, NULL
from genEmpresas
GO

--este indice optimiza las lupas de movimientos

CREATE NONCLUSTERED INDEX idxconAsientosFormu1
ON [dbo].[conAsientos] ([Empresa_Id],[Formulario_Id])
GO

INSERT INTO genVersion(Version) Values(1052.00)
GO
