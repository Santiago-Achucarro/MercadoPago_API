
IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 19.02)
begin

INSERT INTO genVersion(Version) Values(19.02);
-- RevisarCuenta Contable
exec venSubTipoMovGuardar @pSubTipoMov_Id='NCI',@pSubTipoMov_Id_Nuevo='NCI',@pEmpresa_Id=1,@pvenTipoMov='X',
@pDescripcion='Nota de Credito Interna',@pMueveStock=0,@pEsVentaContado=0,@pAdmiteDevolucion=0,@pModificaPrecio=0
,@pReservado=0,@pGeneraRemito=0,@pSegmentoRemito_Id=NULL,@pNCxDevolucion=0,@pUsuarioAutorizado='ELMUNDO',
@pAdmiteBoniRenglon=0,@pCentro1_Id=NULL,@pCentro2_Id=NULL,@pPideCambio=1,@pModFecha=1,@pModCondPago=0,@pModVendedor=0,
@pModCobrador=0,@pPideObervaciones=1,@pCantidadCopias=1,@pModDeposito=0,@pModListaPrecios=0,@pPideFechaEntrega=0,
@pPideObsReng=0,

@pCtaDefecto='7200-102',

@pModCtaDefecto=0,@pModCentro1=0,@pModCentro2=0,@pPideOtrosCargos=0,
@pCtaOtrosCargos=NULL,@pPermModCtaOtCar=0,@pFechaEntregaporRen=0,@pAdmiteFactsinEntr=0,@pModiUniMed=0,@pAfectaComVenta=0,
@pAfectaComCobra=0,@pMaxCantItems=0,@pEsPorDifPrecio=0,@pAfectaEstadistica=0,@pClaveAcceso='',@pEsPorDifCambio=0,
@pTipoPrecioForm=' ',@pSoloImpuestos=0,@pCodigoFormulario=NULL,@pBajoCosto=0,@pAdministrativa=1,@pPideReferencia=0
,@pPideOrdenCompra=0,@pPideCongelarCambio=0,@pPideMarcaReserva=0,@pPermiteSoloEntrega=0,@pInactivo=0,@pUsuario_Id=1,
@pPosteado=1,@pPidePredial=0,@pPideCodProd=0,@pPideComExpoMX=0,@pCodigoFiscal=NULL,@pReporte_Id=NULL;


exec venSubTipoMovGuardar @pSubTipoMov_Id='NDI',@pSubTipoMov_Id_Nuevo='NDI',@pEmpresa_Id=1,@pvenTipoMov='Y',
@pDescripcion='Nota de Debito Interno',@pMueveStock=0,@pEsVentaContado=0,@pAdmiteDevolucion=0,@pModificaPrecio=0,
@pReservado=0,@pGeneraRemito=0,@pSegmentoRemito_Id=NULL,@pNCxDevolucion=0,@pUsuarioAutorizado='ELMUNDO',
@pAdmiteBoniRenglon=0,@pCentro1_Id=NULL,@pCentro2_Id=NULL,@pPideCambio=1,@pModFecha=1,@pModCondPago=0,@pModVendedor=0,
@pModCobrador=0,@pPideObervaciones=1,@pCantidadCopias=1,@pModDeposito=0,@pModListaPrecios=0,@pPideFechaEntrega=0,
@pPideObsReng=0,

@pCtaDefecto='7200-102',

@pModCtaDefecto=0,@pModCentro1=0,@pModCentro2=0,@pPideOtrosCargos=0,
@pCtaOtrosCargos=NULL,@pPermModCtaOtCar=0,@pFechaEntregaporRen=0,@pAdmiteFactsinEntr=0,@pModiUniMed=0,@pAfectaComVenta=0,
@pAfectaComCobra=0,@pMaxCantItems=0,@pEsPorDifPrecio=0,@pAfectaEstadistica=0,@pClaveAcceso='',@pEsPorDifCambio=0,
@pTipoPrecioForm=' ',@pSoloImpuestos=0,@pCodigoFormulario=NULL,@pBajoCosto=0,@pAdministrativa=1,@pPideReferencia=0,
@pPideOrdenCompra=0,@pPideCongelarCambio=0,@pPideMarcaReserva=0,@pPermiteSoloEntrega=0,@pInactivo=0,@pUsuario_Id=1,
@pPosteado=1,@pPidePredial=0,@pPideCodProd=0,@pPideComExpoMX=0,@pCodigoFiscal=NULL,@pReporte_Id=NULL;

alter table genEmpresas add Servidor varchar(100), Puerto int, Correo varchar(200),UsuarioCorreo varchar(100),Clave varchar(100),
Seguridad varchar(3),CFVenta_Id int,Medida_Id int, EnviaFacturas bit, EnviaRecibo bit, EnviaOC bit,  MailClientesSinMail varchar(200);
alter table genEmpresas add Foreign key (CFVenta_Id) references stkCondFisVenta;
alter table genEmpresas add foreign key (Medida_Id) references stkUniMed;
end
go
