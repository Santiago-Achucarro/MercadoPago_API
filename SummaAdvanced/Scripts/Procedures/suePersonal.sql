DROP PROCEDURE suePersonalGuardar
GO
CREATE PROCEDURE suePersonalGuardar
(
@pgenEntidades bigint,
@pLegajo int,
@pLegajo_Nuevo int,
@pEmpresa_Id int = NULL,
@pNombres varchar(40),
@pApellidoPaterno varchar(30),
@pApellidoMaterno varchar(30),
@pNumeroDoc varchar(20),
@pNroSegSocial varchar(20),
@pTelefonos varchar(120),
@pCelular varchar(60),
@pFechaNacimiento qFecha,
@pSexo char(1),
@pNacionalidad_Id smallint = NULL,
@pCodigoNatural char(1) = NULL,
@peMail varchar(100),
@pFechaIngreso qFecha,
@pFechaBaja qFecha = NULL,
@pAniosReconocidos int,
@pMesesReconocidos int,
@pGrupoSanguineo char(2),
@pRH char(1),
@pBancoSucursal char(5),
@pBancoCuenta char(15),
@pBancoTipoCta char(3),
@pCuentaInactiva Sino,
@pClaveBancaria varchar(25),
@pObservaciones varchar(max) = NULL,
@pUMF varchar(3),
@pAvisarA varchar(max) = NULL,
@pInactivo Sino,
@pPosteado Sino,
@pFecha datetime,
@pUsuario_Id int = NULL,
@pActividad_Id varchar(3)= NULL,
@pAfore_Id varchar(5)= NULL,
@pCategoria_Id varchar(5)= NULL,
@pCondServicio varchar(2)= NULL,
@pConvenio_Id varchar(5)= NULL,
@pDireccion1 varchar(100),
@pDireccion2 varchar(100),
@pNroExterior varchar(10),
@pNroInterior varchar(10),
@pLocalidad varchar(100) ,
@pCodigoPostal varchar(40),
@pEntreCalle1 varchar(60),
@pEntreCalle2 varchar(60),
@pProvincia_Id varchar(5)= NULL,
@pEstadoCivil_Id varchar(3),
@pLocalidad_Id varchar(2) = NULL,
@pModContrata_Id varchar(3)= NULL,
@pPuesto_Id varchar(5)= NULL,
@pSiniestro_Id varchar(2)= NULL,
@pSituacionRevi varchar(2)= NULL,
@pSucursal Sucursal= NULL,
@pTipoContrato varchar(2)= NULL,
@pTipoEmpleador_Id varchar(2)= NULL,
@pTipoJornada varchar(2)= NULL,
@pTipoPago_Id varchar(5)= NULL,
@pTipoRegimen varchar(2)= NULL,
@pTipoSDI char= NULL,
@pRebaja qPorcentaje = Null,
@pReduccion qMonedaD2 = Null,
@pAdicional qMonedaD2 = Null,
@pVoluntario qMonedaD2 = Null,
@pObraSocial varChar(6) = Null
)
AS
DECLARE @FechaIng DateTime

SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM suePersonal WHERE (suePersonal.Legajo = @pLegajo)))
BEGIN 

	--- AJ MAY 2020 SI cambio la fecha de Ingreso la fecha debe ser la de ingreso
	SET @FechaIng = (select FechaIngreso from suePersonal where Legajo = @pLegajo)
	if @FechaIng != @pFechaIngreso
		begin
		SET @pFecha = @pFechaIngreso
		end

	UPDATE suePersonal
	SET		Legajo = @pLegajo_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Nombres = @pNombres,
		ApellidoPaterno = @pApellidoPaterno,
		ApellidoMaterno = @pApellidoMaterno,
		NumeroDoc = @pNumeroDoc,
		NroSegSocial = @pNroSegSocial,
		Telefonos = @pTelefonos,
		Celular = @pCelular,
		FechaNacimiento = @pFechaNacimiento,
		Sexo = @pSexo,
		Nacionalidad_Id = dbo.FuncFKgenPaises(@pNacionalidad_Id),
		CodigoNatural = @pCodigoNatural,
		eMail = @peMail,
		FechaIngreso = @pFechaIngreso,
		FechaBaja = @pFechaBaja,
		AniosReconocidos = @pAniosReconocidos,
		MesesReconocidos = @pMesesReconocidos,
		GrupoSanguineo = @pGrupoSanguineo,
		RH = @pRH,
		BancoSucursal = @pBancoSucursal,
		BancoCuenta = @pBancoCuenta,
		BancoTipoCta = @pBancoTipoCta,
		CuentaInactiva = @pCuentaInactiva,
		ClaveBancaria = @pClaveBancaria,
		Observaciones = @pObservaciones,
		UMF = @pUMF,
		AvisarA = @pAvisarA,
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id
	WHERE (suePersonal.Legajo = @pLegajo)
END 
ELSE 
BEGIN 
	-- es nuevo la fehca es la de ingreso
	SET @pFecha = @pFechaIngreso
	INSERT INTO suePersonal
	(
		genEntidades,
		Legajo,
		Empresa_Id,
		Nombres,
		ApellidoPaterno,
		ApellidoMaterno,
		NumeroDoc,
		NroSegSocial,
		Telefonos,
		Celular,
		FechaNacimiento,
		Sexo,
		Nacionalidad_Id,
		CodigoNatural,
		eMail,
		FechaIngreso,
		FechaBaja,
		AniosReconocidos,
		MesesReconocidos,
		GrupoSanguineo,
		RH,
		BancoSucursal,
		BancoCuenta,
		BancoTipoCta,
		CuentaInactiva,
		ClaveBancaria,
		Observaciones,
		UMF,
		AvisarA,
		Inactivo,
		Posteado,
		Usuario_Id
	)
	VALUES 
	(
		@pgenEntidades,
		@pLegajo,
		@pEmpresa_Id,
		@pNombres,
		@pApellidoPaterno,
		@pApellidoMaterno,
		@pNumeroDoc,
		@pNroSegSocial,
		@pTelefonos,
		@pCelular,
		@pFechaNacimiento,
		@pSexo,
		dbo.FuncFKgenPaises(@pNacionalidad_Id),
		@pCodigoNatural,
		@peMail,
		@pFechaIngreso,
		@pFechaBaja,
		@pAniosReconocidos,
		@pMesesReconocidos,
		@pGrupoSanguineo,
		@pRH,
		@pBancoSucursal,
		@pBancoCuenta,
		@pBancoTipoCta,
		@pCuentaInactiva,
		@pClaveBancaria,
		@pObservaciones,
		@pUMF,
		@pAvisarA,
		@pInactivo,
		@pPosteado,
		@pUsuario_Id
	)
END 

set @pLegajo = @pLegajo_Nuevo
if not @pActividad_Id is null
begin exec suePersActividadGuardar @pLegajo, @pFecha, '29990101', @pActividad_Id, @pUsuario_Id end



if not @pAfore_Id is null
begin exec suePersAforeGuardar @pLegajo, @pFecha, '29990101',@pAfore_Id, @pUsuario_Id end

if not @pCategoria_Id is null
begin exec suePersCategoGuardar @pLegajo, @pFecha,'29990101' ,@pCategoria_Id, @pUsuario_Id end

if not @pCondServicio is null
begin exec suePersCondServicioGuardar @pLegajo, @pFecha, '29990101',@pCondServicio, @pUsuario_Id end 

if not @pConvenio_Id is null
begin exec suePersConvenioGuardar @pLegajo, @pFecha, '29990101',@pConvenio_Id,@pUsuario_Id end

exec suePersDomicilioGuardar @pLegajo, @pFecha, '29990101',@pDireccion1, @pDireccion2, @pNroExterior, @pNroInterior, @pLocalidad, @pCodigoPostal, @pEntreCalle1, @pEntreCalle2, @pProvincia_Id, @pUsuario_Id

if not @pEstadoCivil_Id is null
begin exec suePersEstadoCivilGuardar @pLegajo, @pFecha, '29990101', @pEstadoCivil_Id, @pUsuario_Id end
if not @pLocalidad_Id is null
begin exec suePersLocalidadGuardar @pLegajo, @pFecha, '29990101', @pLocalidad_Id, @pUsuario_Id end

if not @pModContrata_Id is null
begin exec suePersModContrataGuardar @pLegajo, @pFecha, '29990101', @pModContrata_Id, @pUsuario_Id end
if not @pPuesto_Id is null
begin exec suePersPuestosGuardar @pLegajo, @pFecha, '29990101', @pPuesto_Id, @pUsuario_Id end
if not @pSiniestro_Id is null
begin exec suePersSiniestradoGuardar @pLegajo, @pFecha, '29990101', @pSiniestro_Id, @pUsuario_Id end 
if not @pSituacionRevi is null
begin exec suePersSituacionReviGuardar @pLegajo, @pFecha, '29990101', @pSituacionRevi, @pUsuario_Id end
if not @pSucursal is null
begin exec suePersSucursalGuardar @pLegajo, @pFecha, '29990101', @pSucursal, @pUsuario_Id end

if not @pTipoContrato is null
begin exec suePersTipoContratoGuardar @pLegajo, @pFecha, '29990101', @pTipoContrato, @pUsuario_Id end

if not @pTipoEmpleador_Id is null
begin exec suePersTipoEmpleadorGuardar @pLegajo, @pFecha, '29990101', @pTipoEmpleador_Id, @pUsuario_Id end

if not @pTipoJornada is null
begin exec suePersTipoJornadaGuardar @pLegajo, @pFecha, '29990101', @pTipoJornada, @pUsuario_Id end
--print 8
if not @pTipoPago_Id is null
begin exec suePersTipoPagoGuardar @pLegajo, @pFecha, '29990101', @pTipoPago_Id, @pUsuario_Id end
if not @pTipoRegimen is null
begin exec suePersTipoRegimenGuardar @pLegajo, @pFecha, '29990101', @pTipoRegimen, @pUsuario_Id end

if not @pTipoSDI is null
begin exec suePersTipoSDIGuardar @pLegajo, @pFecha, '29990101', @pTipoSDI, @pUsuario_Id end

If Not @pRebaja Is Null
Begin Exec suePersRebPromoGuardar @pLegajo, @pFecha, '29990101', @pRebaja, @pUsuario_Id End

If Not @pReduccion Is Null
Begin Exec suePersRedZonalGuardar @pLegajo, @pFecha, '29990101', @pReduccion, @pUsuario_Id End

If Not @pAdicional Is Null
Begin Exec suePersAporteAdicGuardar @pLegajo, @pFecha, '29990101', @pAdicional, @pUsuario_Id End

If Not @pVoluntario Is Null
Begin Exec suePersAporteVoluntarioGuardar @pLegajo, @pFecha, '29990101', @pVoluntario, @pUsuario_Id End

If Not @pObraSocial Is Null
Begin Exec suePersObraSocialGuardar @pLegajo, @pFecha, '29990101', @pObraSocial, @pUsuario_Id End

GO


drop procedure suePersonalDatos
go
create procedure suePersonalDatos
(
@pLegajo int,
@pFecha datetime
)
as
select genEntidades.genEntidades, suePersonal.Legajo, suePersonal.Empresa_Id, Nombres, ApellidoPaterno, ApellidoMaterno, NumeroDoc, NroSegSocial, Telefonos, Celular, FechaNacimiento, 
Sexo, genPaises.Pais_Id as Nacionalidad, genPaises.Descripcion as DescripcionNacionalidad, CodigoNatural, DescCodNatural.Descripcion as DescripcionCodigoNatural, suePersonal.eMail, FechaIngreso, FechaBaja, AniosReconocidos, 
MesesReconocidos, GrupoSanguineo, RH, BancoSucursal, BancoCuenta, BancoTipoCta, CuentaInactiva, ClaveBancaria, Observaciones, UMF, AvisarA, suePersonal.Inactivo,
suePersonal.Posteado, suePersonal.Usuario_Id, suePersActividad.Actividad_Id, DescActividades.Descripcion as DescripcionActividad, suePersAfore.Afore_Id,
DescAfore.Descripcion as DescripcionAfore, sueCategorias.Categoria_Id, sueCategorias.Descripcion as DescripcionCategoria, suePersCondServicio.CondServicio_Id,
DescCondServicio.Descripcion as DescripcionCondServicio, conCuentas.Cuenta_Id,conCuentas.Descripcion as DescripcionCuenta, sueConvenio.Convenio_Id, 
sueConvenio.Descripcion as Descripcionconvenio, suePersDomicilio.Direccion1, suePersDomicilio.CodigoPostal, suePersDomicilio.Direccion2, suePersDomicilio.EntreCalle1,
suePersDomicilio.EntreCalle2, suePersDomicilio.Localidad, suePersDomicilio.NroExterior, suePersDomicilio.NroInterior, DomicilioProvincia.Provincia_Id, 
DomicilioProvincia.Descripcion as DescripcionProvincia, suePersEstadoCivil.EstadoCivil_Id, DescEdoCivil.Descripcion as DescripcionEdoCivil, suePersLocalidad.Localidad_Id,
DescLocalidad.Descripcion as DescripcionLocalidad, suePersModContrata.Modalidad_Id as ModContrata_Id, DescModContrata.Descripcion as DescripcionModContrata, 
suePuestos.Puesto_Id, suePuestos.Descripcion as DescripcionPuesto, suePersSiniestrado.Siniestro_Id, DescSinestrado.Descripcion as DescripcionSiniestro,
suePersSituacionRevi.Situacion_Id as SituacionRevi_Id, DescSituacionRevi.Descripcion as DescripcionSituacionRevi, genSucursalesEmpr.Sucursal, 
genSucursalesEmpr.Descripcion as DescripcionSucursal, suePersTipoContrato.TipoContrato,
DescTipoContrato.Descripcion as DescripcionTipoContrato, suePersTipoEmpleador.TipoEmpleador_Id, DescTipoEmpleador.Descripcion as DescripcionTipoEmpleador, 
suePersTipoJornada.TipoJornada, DescTipoJornada.Descripcion as DescripcionTipoJornada, sueTipoPago.TipoPago_Id, sueTipoPago.Descripcion as DescripcionTipoPago, 
suePersTipoRegimen.TipoRegimen, DescTipoRegimen.Descripcion as DescripcionTipoRegimen, suePersTipoSDI.TipoSDI, DescTipoSDI.Descripcion as DescripcionTipoSDI, 
conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id, 
conCentro2.Descripcion as DescripcionCentro2, suePersContableDatos.Porcentaje, @pFecha as Fecha,
genEntidades.Cuit, genEntidades.IdFiscal, genEntidades.TipoDoc, cast('20190717' as datetime) as FechaOculta,
suePersRebPromo.Rebaja, suePersRedZonal.Reduccion, suePersAporteAdic.Adicional, suePersAporteVoluntario.Voluntario,
suePersObraSocial.ObraSocial, DescObraSocial.Descripcion DescObraSocial
From suePersonal
left join genPaises on genPaises.genPaises=suePersonal.Nacionalidad_Id
left join suePersActividad on suePersActividad.Legajo=suePersonal.genEntidades and @pFecha between suePersActividad.FechaDesde and suePersActividad.FechaHasta
left join suePersAfore on suePersAfore.Legajo=suePersonal.genEntidades and @pFecha between suePersAfore.FechaDesde and suePersAfore.FechaHasta
left join suePersCatego on suePersCatego.Legajo=suePersonal.genEntidades and @pFecha between suePersCatego.FechaDesde and suePersCatego.FechaHasta
left join sueCategorias on sueCategorias.sueCategorias=suePersCatego.Categoria_Id
left join suePersCondServicio on suePersCondServicio.Legajo=suePersonal.genEntidades and @pFecha between suePersCondServicio.FechaDesde and suePersCondServicio.FechaHasta
left join suePersContable on suePersContable.Legajo=suePersonal.genEntidades and @pFecha between suePersContable.FechaDesde and suePersContable.FechaHasta
left join suePersConvenio on suePersConvenio.Legajo=suePersonal.genEntidades and @pFecha between suePersConvenio.FechaDesde and suePersConvenio.FechaHasta
left join sueConvenio on sueConvenio.sueConvenio=suePersConvenio.Convenio_Id
left join suePersDomicilio on suePersDomicilio.Legajo=suePersonal.genEntidades and @pFecha between suePersDomicilio.FechaDesde and suePersDomicilio.FechaHasta
left join suePersEstadoCivil on suePersEstadoCivil.Legajo=suePersonal.genEntidades and @pFecha between suePersEstadoCivil.FechaDesde and suePersEstadoCivil.FechaHasta
left join suePersLocalidad on suePersLocalidad.Legajo=suePersonal.genEntidades and @pFecha between suePersLocalidad.FechaDesde and suePersLocalidad.FechaHasta
left join suePersModContrata on suePersModContrata.Legajo=suePersonal.genEntidades and @pFecha between suePersModContrata.FechaDesde and suePersModContrata.FechaHasta
left join suePersPuestos on suePersPuestos.Legajo=suePersonal.genEntidades and @pFecha between suePersPuestos.FechaDesde and suePersPuestos.FechaHasta
left join suePuestos on suePuestos.suePuestos= suePersPuestos.Puesto_Id
left join suePersSiniestrado on suePersSiniestrado.Legajo=suePersonal.genEntidades and @pFecha between suePersSiniestrado.FechaDesde and suePersSiniestrado.FechaHasta
left join suePersSituacionRevi on suePersSituacionRevi.Legajo=suePersonal.genEntidades and @pFecha between suePersSituacionRevi.FechaDesde and suePersSituacionRevi.FechaHasta
left join suePersSucursal on suePersSucursal.Legajo=suePersonal.genEntidades and @pFecha between suePersSucursal.FechaDesde and suePersSucursal.FechaHasta
left join genSucursalesEmpr on genSucursalesEmpr.genSucursalesEmpr=suePersSucursal.Sucursal
left join suePersTipoContrato on suePersTipoContrato.Legajo=suePersonal.genEntidades and @pFecha between suePersTipoContrato.FechaDesde and suePersTipoContrato.FechaHasta
left join suePersTipoEmpleador on suePersTipoEmpleador.Legajo=suePersonal.genEntidades and @pFecha between suePersTipoEmpleador.FechaDesde and suePersTipoEmpleador.FechaHasta
left join suePersTipoJornada on suePersTipoJornada.Legajo=suePersonal.genEntidades and @pFecha between suePersTipoJornada.FechaDesde and suePersTipoJornada.FechaHasta
left join suePersTipoPago on suePersTipoPago.Legajo=suePersonal.genEntidades and @pFecha between suePersTipoPago.FechaDesde and suePersTipoPago.FechaHasta
left join sueTipoPago on suePersTipoPago.TipoPago_Id=sueTipoPago.sueTipoPago
left join suePersTipoRegimen on suePersTipoRegimen.Legajo=suePersonal.genEntidades and @pFecha between suePersTipoRegimen.FechaDesde and suePersTipoRegimen.FechaHasta
left join suePersTipoSDI on suePersTipoSDI.Legajo=suePersonal.genEntidades and @pFecha between suePersTipoSDI.FechaDesde and suePersTipoSDI.FechaHasta
left join suePersContableDatos on suePersContable.Legajo=suePersContableDatos.Legajo and suePersContable.FechaDesde=suePersContableDatos.FechaDesde
left join genProvincias DomicilioProvincia on DomicilioProvincia.genProvincias= suePersDomicilio.Provincia_Id
left join conCuentas on conCuentas.conCuentas= suePersContableDatos.Cuenta_Id
left join conCentro1 on conCentro1.conCentro1=suePersContableDatos.Centro1_Id
left join concentro2 on conCentro2.conCentro2=suePersContableDatos.Centro2_Id
left join genEntidadesBasicasValor DescActividades on DescActividades.Entidad_Id=1501 and DescActividades.Clave=suePersActividad.Actividad_Id
left join genEntidadesBasicasValor DescAfore on DescAfore.Entidad_Id=1502 and DescAfore.Clave=suePersAfore.Afore_Id
left join genEntidadesBasicasValor DescCondServicio on DescCondServicio.Entidad_Id=1503 and DescCondServicio.Clave=suePersCondServicio.CondServicio_Id
left join genEntidadesBasicasValor DescEdoCivil on DescEdoCivil.Entidad_Id=1504 and DescEdoCivil.Clave=suePersEstadoCivil.EstadoCivil_Id
left join genEntidadesBasicasValor DescLocalidad on DescLocalidad.Entidad_Id=1505 and DescLocalidad.Clave=suePersLocalidad.Localidad_Id
left join genEntidadesBasicasValor DescModContrata on DescModContrata.Entidad_Id=1506 and DescModContrata.Clave=suePersModContrata.Modalidad_Id
left join genEntidadesBasicasValor DescSinestrado on DescSinestrado.Entidad_Id=1507 and DescSinestrado.Clave=suePersSiniestrado.Siniestro_Id
left join genEntidadesBasicasValor DescSituacionRevi on DescSituacionRevi.Entidad_Id=1508 and DescSituacionRevi.Clave=suePersSituacionRevi.Situacion_Id
left join genEntidadesBasicasValor DescTipoContrato on DescTipoContrato.Entidad_Id=1509 and DescTipoContrato.Clave=suePersTipoContrato.TipoContrato
left join genEntidadesBasicasValor DescTipoEmpleador on DescTipoEmpleador.Entidad_Id=1510 and DescTipoEmpleador.Clave=suePersTipoEmpleador.TipoEmpleador_Id
left join genEntidadesBasicasValor DescTipoJornada on DescTipoJornada.Entidad_Id=1511 and DescTipoJornada.Clave=suePersTipoJornada.TipoJornada
left join genEntidadesBasicasValor DescTipoRegimen on DescTipoRegimen.Entidad_Id=1512 and DescTipoRegimen.Clave=suePersTipoRegimen.TipoRegimen
left join genEntidadesBasicasValor DescTipoSDI on DescTipoSDI.Entidad_Id=1513 and DescTipoSDI.Clave=suePersTipoSDI.TipoSDI
Left Join suePersRebPromo On suePersRebPromo.Legajo = suePersonal.genEntidades And @pFecha Between suePersRebPromo.FechaDesde And suePersRebPromo.FechaHasta
Left Join suePersRedZonal On suePersRedZonal.Legajo = suePersonal.genEntidades And @pFecha Between suePersRedZonal.FechaDesde And suePersRedZonal.FechaHasta
Left Join suePersAporteAdic On suePersAporteAdic.Legajo = suePersonal.genEntidades And @pFecha Between suePersAporteAdic.FechaDesde And suePersAporteAdic.FechaHasta
Left Join suePersAporteVoluntario On suePersAporteVoluntario.Legajo = suePersonal.genEntidades And @pFecha Between suePersAporteVoluntario.FechaDesde And suePersAporteVoluntario.FechaHasta
Left Join suePersObraSocial On suePersObraSocial.Legajo = suePersonal.genEntidades And @pFecha Between suePersObraSocial.FechaDesde And suePersObraSocial.FechaHasta
Left Join genEntidadesBasicasValor DescObraSocial on DescObraSocial.Entidad_Id=1607 and DescObraSocial.Clave = suePersObraSocial.ObraSocial
inner join genEntidades on genEntidades.genEntidades=suePersonal.genEntidades
left join genEntidadesBasicasValor DescCodNatural on DescCodNatural.Entidad_Id=1514 and DescCodNatural.Clave=suePersonal.CodigoNatural
Where
	suePersonal.Legajo = @pLegajo

exec suePersActividadDatos @pLegajo
exec suePersAforeDatos @pLegajo
exec suePersCategoDatos @pLegajo
exec suePersCondServicioDatos @pLegajo
exec suePersContableDatosSP @pLegajo
exec suePersContableDatosDatos @pLegajo, null
exec suePersConvenioDatos @pLegajo
exec suePersDomicilioDatos @pLegajo
exec suePersEstadoCivilDatos @pLegajo
exec suePersLocalidadDatos @pLegajo
exec suePersModContrataDatos @pLegajo
exec suePersPuestosDatos @pLegajo
exec suePersSiniestradoDatos @pLegajo
exec suePersSituacionReviDatos @pLegajo
exec suePersSucursalDatos @pLegajo
exec suePersTipoContratoDatos @pLegajo
exec suePersTipoEmpleadorDatos @pLegajo
exec suePersTipoJornadaDatos @pLegajo
exec suePersTipoPagoDatos @pLegajo
exec suePersTipoRegimenDatos @pLegajo
exec suePersTipoSDIDatos @pLegajo
Exec suePersRebPromoDatos @pLegajo
Exec suePersRedZonalDatos @pLegajo
Exec suePersAporteAdicDatos @pLegajo
Exec suePersAporteVoluntarioDatos @pLegajo
Exec suePersObraSocialDatos @pLegajo

Select conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas, conCentro1.Centro1_Id, conCentro1.Descripcion as
DescripcionCentro1, conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, Porcentaje
From 
	suePersContableDatos INNER join suePersContable on 
		suePersContableDatos.Legajo=suePersContable.Legajo and 
		suePersContable.FechaDesde=suePersContableDatos.FechaDesde
		left join conCuentas on 
			conCuentas.conCuentas=suePersContableDatos.Cuenta_Id
		left join conCentro1 on 
			conCentro1.conCentro1=suePersContableDatos.Centro1_Id
	left join conCentro2 on 
			conCentro2.conCentro2=suePersContableDatos.Centro2_Id
Where 
	@pFecha between suePersContable.FechaDesde  and suePersContable.FechaHasta and 
			suePersContable.Legajo= dbo.FuncFKsuePersonal(@pLegajo)

Declare @pidentity bigint= dbo.FuncFKsuePersonal(@pLegajo)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'suePersonal'

go


DROP PROCEDURE suePersonalEliminar
GO
CREATE PROCEDURE suePersonalEliminar
(
@pgenEntidades bigint
)
AS
SET NOCOUNT ON 

DELETE FROM suePersonal 
WHERE (genEntidades = @pgenEntidades)
 
 RETURN @@Error 

GO

-- exec suePersEditable 1, '20190901'



drop procedure suePersEditable
go
create procedure suePersEditable
(
@pLegajo int,
@pFecha datetime
)
as

SET @pLegajo = (SELECT genEntidades FROM suePersonal where Legajo = @pLegajo)

select case when exists(select 1 from suePersActividad where FechaDesde>=@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then cast(0  as bit)
when exists(select 1 from suePersAfore where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then cast(0  as bit)
when exists(select 1 from suePersActividad where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then cast(0  as bit)
when exists(select 1 from suePersCatego where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then cast(0  as bit)
when exists(select 1 from suePersCondServicio where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then cast(0  as bit)
when exists(select 1 from suePersContable where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then cast(0  as bit)
when exists(select 1 from suePersConvenio where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then cast(0  as bit)
when exists(select 1 from suePersDomicilio where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then cast(0  as bit)
when exists(select 1 from suePersEstadoCivil where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then cast(0  as bit)
when exists(select 1 from suePersLocalidad where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then cast(0  as bit)
when exists(select 1 from suePersModContrata where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then cast(0  as bit)
when exists(select 1 from suePersPuestos where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then cast(0  as bit)
when exists(select 1 from suePersSiniestrado where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then cast(0  as bit)
when exists(select 1 from suePersSituacionRevi where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then cast(0  as bit)
when exists(select 1 from suePersSucursal where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then cast(0  as bit)
when exists(select 1 from suePersTipoContrato where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then cast(0  as bit)
when exists(select 1 from suePersTipoEmpleador where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then cast(0  as bit)
when exists(select 1 from suePersTipoJornada where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then cast(0  as bit)
when exists(select 1 from suePersTipoPago where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then cast(0  as bit)
when exists(select 1 from suePersTipoRegimen where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then cast(0  as bit)
when exists(select 1 from suePersTipoSDI where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then cast(0  as bit)
When Exists(Select 1 From suePersRebPromo Where FechaDesde > @pFecha And FechaHasta = '29990101' And Legajo = @pLegajo) Then Cast(0  as bit)
When Exists(Select 1 From suePersRedZonal Where FechaDesde > @pFecha And FechaHasta = '29990101' And Legajo = @pLegajo) Then Cast(0  as bit)
When Exists(Select 1 From suePersAporteAdic Where FechaDesde > @pFecha And FechaHasta = '29990101' And Legajo = @pLegajo) Then Cast(0  as bit)
When Exists(Select 1 From suePersAporteVoluntario Where FechaDesde > @pFecha And FechaHasta = '29990101' And Legajo = @pLegajo) Then Cast(0  as bit)
When Exists(Select 1 From suePersObraSocial Where FechaDesde > @pFecha And FechaHasta = '29990101' And Legajo = @pLegajo) Then Cast(0  as bit)
else cast(1 as bit) end as Editable, 
case when exists(select 1 from suePersActividad where FechaDesde>=@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then 'Actividad'
when exists(select 1 from suePersAfore where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then 'Afore'
when exists(select 1 from suePersActividad where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then 'Actividad'
when exists(select 1 from suePersCatego where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then 'Categoria'
when exists(select 1 from suePersCondServicio where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then 'Condicion_Servicio'
when exists(select 1 from suePersContable where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then 'Contable'
when exists(select 1 from suePersConvenio where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then 'Convenio'
when exists(select 1 from suePersDomicilio where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then 'Domicilio'
when exists(select 1 from suePersEstadoCivil where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then 'Estado_Civil'
when exists(select 1 from suePersLocalidad where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then 'Localidad'
when exists(select 1 from suePersModContrata where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then 'Modalidad_Contratacion'
when exists(select 1 from suePersPuestos where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then 'Puestos'
when exists(select 1 from suePersSiniestrado where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then 'Siniestrado'
when exists(select 1 from suePersSituacionRevi where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then 'Situacion_Revista'
when exists(select 1 from suePersSucursal where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then 'Sucursal'
when exists(select 1 from suePersTipoContrato where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then 'Tipo_Contrato'
when exists(select 1 from suePersTipoEmpleador where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then 'Tipo_Empleador'
when exists(select 1 from suePersTipoJornada where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then 'Tipo_Jornada'
when exists(select 1 from suePersTipoPago where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then 'Tipo_Pago'
when exists(select 1 from suePersTipoRegimen where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then 'Tipo_Regimen'
when exists(select 1 from suePersTipoSDI where FechaDesde>@pFecha and FechaHasta='29990101' and Legajo = @pLegajo) then 'Tipo_SDI'
When Exists(Select 1 From suePersRebPromo Where FechaDesde > @pFecha And FechaHasta = '29990101' And Legajo = @pLegajo) Then 'RebPromo'
When Exists(Select 1 From suePersRedZonal Where FechaDesde > @pFecha And FechaHasta = '29990101' And Legajo = @pLegajo) Then 'RedZonal'
When Exists(Select 1 From suePersAporteAdic Where FechaDesde > @pFecha And FechaHasta = '29990101' And Legajo = @pLegajo) Then 'AporteAdic'
When Exists(Select 1 From suePersAporteVoluntario Where FechaDesde > @pFecha And FechaHasta = '29990101' And Legajo = @pLegajo) Then 'AporteVoluntario'
When Exists(Select 1 From suePersObraSocial Where FechaDesde > @pFecha And FechaHasta = '29990101' And Legajo = @pLegajo) Then 'ObraSocial'
else '' end as Tabla 
go

drop function dbo.FuncFKsuePersonal
go
create function dbo.FuncFKsuePersonal
(
@pLegajo_Id int
)
returns int
as
begin
declare @Identity bigint = (select suePersonal.genEntidades from suePersonal where suePersonal.Legajo=@pLegajo_Id) 
return @Identity
end