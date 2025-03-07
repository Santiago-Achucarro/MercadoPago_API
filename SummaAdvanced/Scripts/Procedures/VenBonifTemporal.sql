DROP PROCEDURE venBonifTemporalGuardar
GO
CREATE PROCEDURE venBonifTemporalGuardar
(
@pvenBonifTemporal Int,
@pDescripcion VarChar(150),
@pEmpresa_Id int = NULL,
@pFechaDesde datetime,
@pFechaHasta datetime,
@pSucursalDesde varchar(15),
@pSucursalHasta varchar(15),
@pClienteDesde varchar(15),
@pClienteHasta varchar(15),
@pSucursalClieDesde int,
@pSucursalClieHasta int,
@pTipoClieDesde varchar(5),
@pTipoClieHasta varchar(5),
@pProductoDesde varchar(25),
@pProductoHasta varchar(25),
@pTipoProductoDesde varchar(5),
@pTipoProductoHasta varchar(5),
@pBonificacion varchar(max),
@pFamiliaDesde varchar(15),
@pFamiliaHasta varchar(15),
@pGrupoDesde varchar(15),
@pGrupoHasta varchar(15),
@pUsuario_Id int, 
@pInactivo Bit, 
@pPosteado Bit, 
@pPrioridad Int
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM venBonifTemporal WHERE venBonifTemporal = @pvenBonifTemporal ))
BEGIN 
	UPDATE venBonifTemporal
	SET		@lIdentidad = venBonifTemporal,
		Descripcion = @pDescripcion,
		Empresa_Id = @pEmpresa_Id,
		FechaDesde = @pFechaDesde,
		FechaHasta = @pFechaHasta,
		SucursalDesde = @pSucursalDesde,
		SucursalHasta = @pSucursalHasta,
		ClienteDesde = @pClienteDesde,
		ClienteHasta = @pClienteHasta,
		SucursalClieDesde = @pSucursalClieDesde,
		SucursalClieHasta = @pSucursalClieHasta,
		TipoClieDesde = @pTipoClieDesde,
		TipoClieHasta = @pTipoClieHasta,
		ProductoDesde = @pProductoDesde,
		ProductoHasta = @pProductoHasta,
		TipoProductoDesde = @pTipoProductoDesde,
		TipoProductoHasta = @pTipoProductoHasta,
		Bonificacion = @pBonificacion,
		FamiliaDesde = @pFamiliaDesde,
		FamiliaHasta = @pFamiliaHasta,
		GrupoDesde = @pGrupoDesde,
		GrupoHasta = @pGrupoHasta,
		FechaRegistro = dbo.FechaActual() ,
		Usuario_Id = @pUsuario_Id, 
		Inactivo = @pInactivo , 
		Posteado = @pPosteado, 
		Prioridad = @pPrioridad
	WHERE 
		venBonifTemporal = @pvenBonifTemporal
END 
ELSE 
BEGIN 
	INSERT INTO venBonifTemporal
	(
		Descripcion,
		Empresa_Id,
		FechaDesde,
		FechaHasta,
		SucursalDesde,
		SucursalHasta,
		ClienteDesde,
		ClienteHasta,
		SucursalClieDesde,
		SucursalClieHasta,
		TipoClieDesde,
		TipoClieHasta,
		ProductoDesde,
		ProductoHasta,
		TipoProductoDesde,
		TipoProductoHasta,
		Bonificacion,
		FamiliaDesde,
		FamiliaHasta,
		GrupoDesde,
		GrupoHasta,
		FechaRegistro,
		Usuario_Id, 
		Inactivo,
		Posteado, 
		Prioridad
	)
	VALUES 
	(
		@pDescripcion,
		@pEmpresa_Id,
		@pFechaDesde,
		@pFechaHasta,
		@pSucursalDesde,
		@pSucursalHasta,
		@pClienteDesde,
		@pClienteHasta,
		@pSucursalClieDesde,
		@pSucursalClieHasta,
		@pTipoClieDesde,
		@pTipoClieHasta,
		@pProductoDesde,
		@pProductoHasta,
		@pTipoProductoDesde,
		@pTipoProductoHasta,
		@pBonificacion,
		@pFamiliaDesde,
		@pFamiliaHasta,
		@pGrupoDesde,
		@pGrupoHasta,
		dbo.FechaActual(),
		@pUsuario_Id, 
		@pInactivo,
		@pPosteado, 
		@pPrioridad
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 
GO

DROP PROCEDURE venBonifTemporalDatosId
GO

CREATE PROCEDURE venBonifTemporalDatosId
(
	@pvenBonifTemporal Int
)
AS

SELECT 
	venBonifTemporal.venBonifTemporal,  venBonifTemporal.Descripcion,
	genSegmentos.Segmento_Id, venBonifTemporalSegmento.Segmento1N, 
	venBonifTemporalSegmento.Segmento2N, venBonifTemporalSegmento.Segmento3N,
	venBonifTemporalSegmento.Segmento4N, venBonifTemporalSegmento.Segmento1C,
	venBonifTemporalSegmento.Segmento2C, venBonifTemporalSegmento.Segmento3C,
	venBonifTemporalSegmento.Segmento4C,
	Cast(case When venBonifTemporal.Empresa_Id is null then 1 else 0 end as bit) as PTodasLasEmpresas,
	FechaDesde,FechaHasta,SucursalDesde,SucursalHasta,ClienteDesde,ClienteHasta,
	SucursalClieDesde,SucursalClieHasta,TipoClieDesde,TipoClieHasta,ProductoDesde,ProductoHasta,
	TipoProductoDesde,TipoProductoHasta,Bonificacion,FamiliaDesde,FamiliaHasta,
	GrupoDesde,GrupoHasta,FechaRegistro,genUsuarios.Usuario_Id, 
	venBonifTemporal.Inactivo, venBonifTemporal.Posteado, venBonifTemporal.Prioridad
From venBonifTemporal
inner join genUsuarios ON venBonifTemporal.Usuario_Id = genUsuarios.genUsuarios
inner join venBonifTemporalSegmento ON venBonifTemporalSegmento.venBonifTemporal = venBonifTemporal.venBonifTemporal
INNER JOIN genSegmentos ON genSegmentos.genSegmentos = venBonifTemporalSegmento.Segmento_Id
where
	venBonifTemporal.venBonifTemporal = @pvenBonifTemporal

GO
DROP Procedure venBonifTemporalDatos
GO

CREATE Procedure venBonifTemporalDatos(
@pEmpresa_Id int, 
@pSegmento_id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20)
)
as

Declare @pVenBonifTemporal Int

set @pVenBonifTemporal = (SELECT venBonifTemporal 
	from venBonifTemporalSegmento 
	inner join  genSegmentos ON  genSegmentos.genSegmentos = venBonifTemporalSegmento.Segmento_Id
	WHERE
		genSegmentos.Segmento_Id = @pSegmento_id AND 
		venBonifTemporalSegmento.Segmento1C = @pSegmento1C AND 
		venBonifTemporalSegmento.Segmento2C = @pSegmento2C AND 
		venBonifTemporalSegmento.Segmento3C = @pSegmento3C AND 
		venBonifTemporalSegmento.Segmento4C = @pSegmento4C AND 
		venBonifTemporalSegmento.Segmento1N = @pSegmento1N AND 
		venBonifTemporalSegmento.Segmento2N = @pSegmento2N AND 
		venBonifTemporalSegmento.Segmento3N = @pSegmento3N AND 
		venBonifTemporalSegmento.Segmento4N = @pSegmento4N AND 
		venBonifTemporalSegmento.Empresa_Id = @pEmpresa_Id)

Exec venBonifTemporalDatosId @pVenBonifTemporal

GO



DROP PROCEDURE venBonifTemporalEliminar
GO

CREATE PROCEDURE venBonifTemporalEliminar
(
	@pvenBonifTemporal Int
)
AS

Delete from venBonifTemporal WHERE venBonifTemporal = @pvenBonifTemporal
GO

DROP PROCEDURE venBonifTemporalHayOtra
GO

CREATE PROCEDURE venBonifTemporalHayOtra(
	
	@pvenBonifTemporal Int,
	@pEmpresa_Id int = NULL,
	@pFechaDesde datetime,
	@pFechaHasta datetime,
	@pSucursalDesde varchar(15),
	@pSucursalHasta varchar(15),
	@pClienteDesde varchar(15),
	@pClienteHasta varchar(15),
	@pSucursalClieDesde int,
	@pSucursalClieHasta int,
	@pTipoClieDesde varchar(5),
	@pTipoClieHasta varchar(5),
	@pProductoDesde varchar(25),
	@pProductoHasta varchar(25),
	@pTipoProductoDesde varchar(5),
	@pTipoProductoHasta varchar(5),
	@pBonificacion varchar(max),
	@pFamiliaDesde varchar(15),
	@pFamiliaHasta varchar(15),
	@pGrupoDesde varchar(15),
	@pGrupoHasta varchar(15)
)
AS

SELECT dbo.Segmento(venBonifTemporalSegmento.Segmento_Id, 
	venBonifTemporalSegmento.Segmento1C, venBonifTemporalSegmento.Segmento2C,
	venBonifTemporalSegmento.Segmento3C, venBonifTemporalSegmento.Segmento4C,
	venBonifTemporalSegmento.Segmento1N,venBonifTemporalSegmento.Segmento2N,
	venBonifTemporalSegmento.Segmento3N,venBonifTemporalSegmento.Segmento4N) AS Bonif,
	venBonifTemporal.Descripcion,
	genUsuarios.Apellido_y_Nombres Usuario 
	 FROM venBonifTemporal INNER JOIN  genUsuarios ON
	 venBonifTemporal.Usuario_Id = genUsuarios.genUsuarios
	 INNER JOIN venBonifTemporalSegmento ON 
		venBonifTemporalSegmento.venBonifTemporal =venBonifTemporal.venBonifTemporal
		where 
			venBonifTemporal.Inactivo = 0 AND 
			venBonifTemporal.Posteado = 1 AND 
			isnull(venBonifTemporal.Empresa_Id,0) = @pEmpresa_Id and 
			venBonifTemporal.venBonifTemporal != @pvenBonifTemporal and 
	 (ClienteDesde BETWEEN @pClienteDesde and @pClienteHasta  or 
	 ClienteHasta BETWEEN @pClienteDesde and @pClienteHasta or 
	 (ClienteDesde < @pClienteDesde and ClienteHasta > @pClienteHasta )) and  
	 (TipoClieDesde BETWEEN @pTipoClieDesde and @pTipoClieHasta  or 
	 TipoClieHasta BETWEEN @pTipoClieDesde and @pTipoClieHasta or 
	 (TipoClieDesde < @pTipoClieDesde and TipoClieHasta > @pTipoClieHasta )) and  
	 (SucursalDesde BETWEEN @pSucursalDesde and @pSucursalHasta or 
	 SucursalHasta BETWEEN @pSucursalDesde and @pSucursalHasta or 
	 (SucursalDesde < @pSucursalDesde and SucursalHasta > @pSucursalHasta )) and  
	 (ProductoDesde BETWEEN @pProductoDesde and @pProductoHasta or 
	 ProductoHasta BETWEEN @pProductoDesde and @pProductoHasta or  
	 (ProductoDesde < @pProductoDesde and ProductoHasta > @pProductoHasta )) and  
	 (TipoProductoDesde BETWEEN @pTipoProductoDesde and @pTipoProductoHasta  or 
	 TipoProductoHasta BETWEEN @pTipoProductoDesde and @pTipoProductoHasta or 
	 (TipoProductoDesde < @pTipoProductoDesde and TipoProductoHasta > @pTipoProductoHasta )) and  
	 (FechaDesde BETWEEN @pFechaDesde and @pFechaHasta or 
	 FechaHasta BETWEEN @pFechaDesde and @pFechaHasta or  
	 (FechaDesde < @pFechaDesde and FechaHasta > @pFechaHasta ))  and 
	 (FamiliaDesde BETWEEN @pFamiliaDesde and @pFamiliaHasta  or 
	 FamiliaHasta BETWEEN @pFamiliaDesde and @pFamiliaHasta or 
	 (FamiliaDesde < @pFamiliaDesde and FamiliaHasta > @pFamiliaHasta )) and  
	 (GrupoDesde BETWEEN @pGrupoDesde and @pGrupoHasta or 
	 GrupoHasta BETWEEN @pGrupoDesde and @pGrupoHasta or 
	 (GrupoDesde < @pGrupoDesde and GrupoHasta > @pGrupoHasta )) 
GO
DROP Procedure QueBonif
GO

-- QueBonif 1,'01004',0,'1002','20220315','0006'

CREATE Procedure QueBonif(
	@Empresa_Id int,
	@Cliente_Id VarChar(15),
	@SucursalClie Int,
	@Producto_Id VarChar(25), 
	@Fecha DateTime, 
	@Sucursal VarChar(4)
)

as

SELECT venBonifTemporal.Prioridad, venBonifTemporal.FechaDesde, 
venBonifTemporal.Bonificacion, venClientes.Cliente_Id, venClieHabitual.Sucursal as SucursalClie,
	stkProductos.Producto_Id, GETDATE() as Fecha, genSucursalesEmpr.Sucursal, 
	venBonifTemporal.ClienteDesde, venBonifTemporal.ClienteHasta, 
	venBonifTemporal.FamiliaDesde, venBonifTemporal.FamiliaHasta, 
	venBonifTemporal.GrupoDesde, venBonifTemporal.GrupoHasta, 
	venBonifTemporal.ProductoDesde, venBonifTemporal.ProductoHasta, 
	venBonifTemporal.TipoProductoDesde, venBonifTemporal.TipoProductoHasta,
	venBonifTemporal.FechaHasta, venBonifTemporal.venBonifTemporal
From venBonifTemporal 
INNER JOIN venClientes ON  venClientes.Cliente_Id = @Cliente_Id 
INNER JOIN venClieHabitual ON  venClieHabitual.genEntidades = venClientes.genEntidades and 
venClieHabitual.Sucursal = @SucursalClie 
INNER JOIN venTiposClie ON  venTiposClie.venTiposClie = venClieHabitual.TipoClie_Id
INNER JOIN stkProductos on stkProductos.Producto_Id = @Producto_Id
INNER JOIN stkTipos ON  stkTipos.stkTipos = stkProductos.Tipo_Id
INNER JOIN genSucursalesEmpr ON genSucursalesEmpr.Sucursal = @Sucursal
Left JOIN stkFamilias ON  stkFamilias.stkFamilias = stkProductos.Familia_Id
Left JOIN stkGrupos ON  stkGrupos.stkGrupos = stkProductos.Grupo_Id
Where
	venBonifTemporal.Inactivo = 0 and 
	venBonifTemporal.Posteado = 1 and 
	isnull(venBonifTemporal.Empresa_Id,@Empresa_Id) =  @Empresa_Id and
	@Fecha between venBonifTemporal.FechaDesde and venBonifTemporal.FechaHasta and
	venClientes.Cliente_Id between venBonifTemporal.ClienteDesde and venBonifTemporal.ClienteHasta and
	venClieHabitual.Sucursal Between venBonifTemporal.SucursalClieDesde and venBonifTemporal.SucursalClieHasta and
	venTiposClie.TipoClie_Id  Between venBonifTemporal.TipoClieDesde and venBonifTemporal.TipoClieHasta and 
	stkTipos.Tipo_Id Between venBonifTemporal.TipoProductoDesde and venBonifTemporal.TipoProductoHasta and 
	ISNULL(stkFamilias.Familia_Id,' ') between venBonifTemporal.FamiliaDesde and venBonifTemporal.FamiliaHasta and 
	ISNULL(stkGrupos.Grupo_Id,' ') between venBonifTemporal.GrupoDesde and venBonifTemporal.GrupoHasta and 
	stkProductos.Producto_Id BETWEEN venBonifTemporal.ProductoDesde AND venBonifTemporal.ProductoHasta AND 
	genSucursalesEmpr.Sucursal Between venBonifTemporal.SucursalDesde and venBonifTemporal.SucursalHasta
ORDER BY 1, 2 Desc
	
go
