-- Inf_sueEmpleadosMX 0, 99999, ' ','ZZZ', 1,1
DROP PROCEDURE Inf_sueEmpleadosMX
GO
CREATE PROCEDURE Inf_sueEmpleadosMX
(
	@LegajoDesde Int,
	@LegajoHasta Int,
	@SucursalDesde VarChar(4),
	@SucursalHasta VarChar(4),
	@Empresa_Id int, 
	@SoloActivos bit
)

as
DECLARE @Fecha DateTime
SET @Fecha = GetDate()



SELECT suePersonal.Legajo, suePersonal.ApellidoPaterno,	suePersonal.ApellidoMaterno,
	suePersonal.Nombres, suePersonal.FechaIngreso, 
	isnull(CONVERT(CHAR(10),suePersonal.FechaBaja,103),'')  AS FechaBaja, 
	genEntidades.CUIT as RFC , suePersonal.NumeroDoc as CURP, 
	suePersonal.NroSegSocial as IMSS, suePersonal.Telefonos, 
	suePersonal.Celular as Movil, suePersonal.FechaNacimiento, suePersonal.Sexo, 
	suePersonal.eMail, suePersonal.GrupoSanguineo, suePersonal.RH, 
	suePersonal.ClaveBancaria as CLABE, suePersonal.Observaciones, 
	suePersonal.UMF, suePersonal.AvisarA, suePersonal.Inactivo, 
	suePersonal.AniosReconocidos, suePersonal.MesesReconocidos,
	gensucursalesEmpr.Sucursal, gensucursalesEmpr.Descripcion as DescripcionSuc, 
	Nacionalidad.Descripcion as Nacionalidad, suePersonal.CodigoNatural, 
	suePersAfore.Afore_Id, Afore.Descripcion as DescripcionAfore, 
	sueCategorias.Categoria_Id, sueCategorias.Descripcion as DescripcionCategoria, 
	suePersDomicilio.Direccion1 Calle, suePersDomicilio.NroExterior, suePersDomicilio.NroInterior, 
	suePersDomicilio.Direccion2 Colonia, suePersDomicilio.Localidad, suePersDomicilio.CodigoPostal, 
	suePersDomicilio.EntreCalle1, suePersDomicilio.EntreCalle2, genProvincias.Descripcion as Estado, 
	EstadoCivil.Descripcion as EstadoCivil, suePuestos.Puesto_Id, suePuestos.Descripcion  as DescripcionPuesto, 
	ISNULL(suePersTipoContrato.TipoContrato,'') TipoContrato, ISNULL(suePersTipoJornada.TipoJornada,'') TipoJornada, 
	ISNULL(suePersTipoRegimen.TipoRegimen,'') TipoRegimen, ISNULL(suePersTipoSDI.TipoSDI,'') TipoSDI, 
	sueTipoPago.TipoPago_Id, sueTipoPago.Descripcion as DescripcionTipoPago
From suePersonal
	INNER JOIN suePersSucursal ON
			suePersSucursal.Legajo = suePersonal.genEntidades  and 
			@Fecha between suePersSucursal.FechaDesde and suePersSucursal.FechaHasta
	INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = suePersSucursal.Sucursal
	INNER JOIN genEntidades ON genEntidades.genEntidades = suePersonal.genEntidades
	INNER JOIN genPaises as Nacionalidad ON
		Nacionalidad.genPaises = suePersonal.Nacionalidad_Id
	LEFT JOIN suePersAfore ON
			suePersAfore.Legajo = suePersonal.genEntidades  and 
			@Fecha between suePersAfore.FechaDesde and suePersAfore.FechaHasta
	LEFT JOIN genEntidadesBasicasValor as Afore ON
		Afore.Entidad_id = 1502 and 
		Afore.Dominio_Id = 'MX' AND 
		Afore.Clave = suePersAfore.Afore_id
	INNER JOIN suePersCatego ON
			suePersCatego.Legajo = suePersonal.genEntidades  and 
			@Fecha between suePersCatego.FechaDesde and suePersCatego.FechaHasta
	INNER JOIN sueCategorias ON
		sueCategorias.sueCategorias = suePersCatego.Categoria_Id
	INNER JOIN suePersDomicilio ON
			suePersDomicilio.Legajo = suePersonal.genEntidades  and 
			@Fecha between suePersDomicilio.FechaDesde and suePersDomicilio.FechaHasta
	INNER JOIN genProvincias ON
		genProvincias.genProvincias = suePersDomicilio.Provincia_Id
	INNER JOIN suePersEstadoCivil ON
			suePersEstadoCivil.Legajo = suePersonal.genEntidades  and 
			@Fecha between suePersEstadoCivil.FechaDesde and suePersEstadoCivil.FechaHasta			
	LEFT JOIN genEntidadesBasicasValor as EstadoCivil ON
		EstadoCivil.Entidad_id = 1504 and 
		EstadoCivil.Dominio_Id = 'MX' AND 
		EstadoCivil.Clave = suePersEstadoCivil.EstadoCivil_Id
	INNER JOIN suePersPuestos ON
			suePersPuestos.Legajo = suePersonal.genEntidades  and 
			@Fecha between suePersPuestos.FechaDesde and suePersPuestos.FechaHasta				
	INNER JOIN suePuestos ON
		suePuestos.suePuestos = suePersPuestos.Puesto_Id
	LEFT JOIN suePersTipoContrato ON --INNER JOIN
			suePersTipoContrato.Legajo = suePersonal.genEntidades  and 
			@Fecha between suePersTipoContrato.FechaDesde and suePersTipoContrato.FechaHasta				
	LEFT JOIN suePersTipoJornada ON --INNER JOIN
			suePersTipoJornada.Legajo = suePersonal.genEntidades  and 
			@Fecha between suePersTipoJornada.FechaDesde and suePersTipoJornada.FechaHasta				
	INNER JOIN suePersTipoPago ON
			suePersTipoPago.Legajo = suePersonal.genEntidades  and 
			@Fecha between suePersTipoPago.FechaDesde and suePersTipoPago.FechaHasta				
	INNER JOIN sueTipoPago ON
		sueTipoPago.sueTipoPago = suePersTipoPago.TipoPago_id
	LEFT JOIN suePersTipoRegimen ON --INNER JOIN
			suePersTipoRegimen.Legajo = suePersonal.genEntidades  and 
			@Fecha between suePersTipoRegimen.FechaDesde and suePersTipoRegimen.FechaHasta				
	LEFT JOIN suePersTipoSDI ON --INNER JOIN
			suePersTipoSDI.Legajo = suePersonal.genEntidades  and 
			@Fecha between suePersTipoSDI.FechaDesde and suePersTipoSDI.FechaHasta				
Where
	ISNULL(suePersonal.Empresa_Id,@Empresa_Id) = @Empresa_Id and 
	(@SoloActivos=0 or suePersonal.FechaBaja IS NULL) AND
	suePersonal.Legajo BETWEEN @LegajoDesde And @LegajoHasta  and 
	genSucursalesEmpr.Sucursal Between @SucursalDesde And @SucursalHasta

ORDER BY 1
GO

