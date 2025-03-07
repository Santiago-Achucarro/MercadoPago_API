

--venListasPreciosDatos 1,'l'

DROP PROCEDURE venListasPreciosGuardar
GO
CREATE PROCEDURE venListasPreciosGuardar
(
@pListaPrecio_Id varchar(5),
@pListaPrecio_Id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(35),
@pMoneda_Id varchar(3) = NULL,
@pLlevaImpuestoInclu bit,
@pUsuAutorizado varchar(25) = NULL,
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit, 
@pDecimalesPu Int
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM venListasPrecios WHERE (ListaPrecio_Id = @pListaPrecio_Id)))
BEGIN 
	UPDATE venListasPrecios
	SET		@lIdentidad = venListasPrecios,
		ListaPrecio_Id = @pListaPrecio_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id),
		LlevaImpuestoInclu = @pLlevaImpuestoInclu,
		UsuAutorizado = dbo.FuncFKgenUsuarios(@pUsuAutorizado),
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado, 
		DecimalesPu = @pDecimalesPu
	WHERE (ListaPrecio_Id = @pListaPrecio_Id)
END 
ELSE 
BEGIN 
	INSERT INTO venListasPrecios
	(
		ListaPrecio_Id,
		Empresa_Id,
		Descripcion,
		Moneda_Id,
		LlevaImpuestoInclu,
		UsuAutorizado,
		Inactivo,
		Usuario_Id,
		Posteado, 
		DecimalesPu
	)
	VALUES 
	(
		@pListaPrecio_Id,
		@pEmpresa_Id,
		@pDescripcion,
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		@pLlevaImpuestoInclu,
		dbo.FuncFKgenUsuarios(@pUsuAutorizado),
		@pInactivo,
		@pUsuario_Id,
		@pPosteado, 
		@pDecimalesPu
	)
	SET @lIdentidad =  Cast(SCOPE_IdENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE venListasPreciosDatosCabe
GO
CREATE PROCEDURE venListasPreciosDatosCabe
(
@pEmpresa_Id int,
@pListaPrecio_Id varchar(5)

)
AS
SET NOCOUNT ON 

SELECT venListasPrecios.venListasPrecios, '' as ListaPrecio_Id_Nueva, venListasPrecios.ListaPrecio_Id, venListasPrecios.Empresa_Id, Cast( Case When venListasPrecios.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	venListasPrecios.Descripcion, genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, venListasPrecios.LlevaImpuestoInclu,
	UsuarioAutorizado.Usuario_Id AS UsuarioAutorizado, genUsuarios.Apellido_y_Nombres as DescripcionUsuarioAutorizado, venListasPrecios.Inactivo, 
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, venListasPrecios.Posteado, '' as Excel, 
	venListasPrecios.DecimalesPu
FROM venListasPrecios 
LEFT JOIN genMonedas  ON (genMonedas.genMonedas = venListasPrecios.Moneda_Id)
LEFT JOIN genUsuarios  AS UsuarioAutorizado ON (UsuarioAutorizado.genUsuarios = venListasPrecios.UsuAutorizado)
INNER JOIN genUsuarios ON (genUsuarios.genUsuarios = venListasPrecios.Usuario_Id)
WHERE (venListasPrecios.ListaPrecio_Id = @pListaPrecio_Id)

SELECT '' Producto_Id, '' Descripcion,
	Cast(0 As numeric(19,8)) as PrecioLista, 
	Cast(0 As numeric(19,8)) as PrecioPromocion, 
	Cast(0 as Bit) as AdmiteRegalo, 
	Cast(0 as Bit) AS Marca

Exec venListasPrecBoniRecTodos @pListaPrecio_Id

Declare @pidentity bigint= dbo.FuncFKvenListasPrecios(@pListaPrecio_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'venListasPrecios'

go

DROP PROCEDURE venListasPreciosDatos
GO
CREATE PROCEDURE venListasPreciosDatos
(
@pEmpresa_Id int,
@pListaPrecio_Id varchar(5), 
@pVersion Int = null
)
AS
SET NOCOUNT ON 

IF @pVersion IS NULL
	SET @pVersion = isnull((SELECT MAX(Version) 
		from 	venListasVersion 
		inner join venListasPrecios ON
		venListasPrecios.venListasPrecios= venListasVersion.ListaPrecio_Id and 
		venListasPrecios.ListaPrecio_Id = @pListaPrecio_Id),1)

--Exec venListasPreciosDatosCabe @pEmpresa_Id, @pListaPrecio_Id
SELECT venListasPrecios.venListasPrecios, '' as ListaPrecio_Id_Nueva, 
	venListasPrecios.ListaPrecio_Id, venListasPrecios.Empresa_Id, Cast( Case When venListasPrecios.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	venListasPrecios.Descripcion, genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, venListasPrecios.LlevaImpuestoInclu,
	UsuarioAutorizado.Usuario_Id AS UsuarioAutorizado, UsuarioAutorizado.Apellido_y_Nombres as DescripcionUsuarioAutorizado, venListasPrecios.Inactivo, 
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, venListasPrecios.Posteado, '' as Excel, 
	venListasPrecios.DecimalesPu, venListasVersion.Version, 
	venListasVersion.VigenciaDesde, venListasVersion.VigenciaHasta
FROM venListasPrecios 
LEFT JOIN genMonedas  ON (genMonedas.genMonedas = venListasPrecios.Moneda_Id)
LEFT JOIN genUsuarios  AS UsuarioAutorizado ON (UsuarioAutorizado.genUsuarios = venListasPrecios.UsuAutorizado)
INNER JOIN genUsuarios ON (genUsuarios.genUsuarios = venListasPrecios.Usuario_Id)
INNER JOIN venListasVersion ON venListasVersion.ListaPrecio_Id = venListasPrecios.venListasPrecios AND 
	venListasVersion.Version = @pVersion
WHERE (venListasPrecios.ListaPrecio_Id = @pListaPrecio_Id)

 
SELECT stkProductos.Producto_Id, stkProductos.Descripcion,
	ISNULL(venListasPrecProd.PrecioLista, 0) as PrecioLista, 
	ISNULL(venListasPrecProd.PrecioPromocion,0) as PrecioPromocion, 
	Cast(ISNULL(venListasPrecProd.AdmiteRegalo, 0) as Bit) as AdmiteRegalo, 
	CAST(CASE WHEN venListasPrecProd.PrecioLista IS NULL THEN 0 ELSE 1 END AS BIT) AS Marca
FROM stkProductos 
LEFT  JOIN (
		venListasPrecProd  INNER JOIN venListasPrecios ON 
		venListasPrecProd.ListaPrecio_Id = venListasPrecios.venListasPrecios AND 	
		venListasPrecios.ListaPrecio_Id = @pListaPrecio_Id and 
		venListasPrecProd.Version = @pVersion) 
ON venListasPrecProd.Producto_Id = stkProductos.stkProductos
WHERE
	stkProductos.Acepta_Ventas = 1 and 
	stkProductos.Posteado = 1 and 
	stkProductos.Inactivo = 0 and 
	isnull(stkProductos.Empresa_Id,@pEmpresa_Id) = @pEmpresa_Id 
order by 1
	
		

Exec venListasPrecBoniRecTodos @pListaPrecio_Id

 Declare @pidentity bigint= dbo.FuncFKvenListasPrecios(@pListaPrecio_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'venListasPrecios'
 RETURN @@Error 

GO

DROP PROCEDURE venListasPreciosEliminar
GO
CREATE PROCEDURE venListasPreciosEliminar
(
@pListaPrecio_Id varchar(5) 
)
AS
SET NOCOUNT ON 

DELETE FROM venListasPrecios 
WHERE (ListaPrecio_Id = @pListaPrecio_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKvenListasPrecios
GO

CREATE FUNCTION FuncFKvenListasPrecios
(
@pListaPrecio_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = venListasPrecios FROM venListasPrecios WHERE 
	ListaPrecio_Id = @pListaPrecio_Id
  RETURN @pIdentity
END


GO

Drop Procedure venListaCopiar
GO
Create Procedure venListaCopiar
(
 @pLista int,
 @pVersion Int,
 @pLista_Ap int,
 @pVersion_Ap Int,
 @pCoeficiente numeric(18,8),
 @pDecimales int, 
 @pProductoDesde VarChar(25),
 @pProductoHasta VarChar(25),
 @pFamiliaDesde VarChar(15),
 @pFamiliaHasta VarChar(15),
 @pGrupoDesde VarChar(15),
 @pGrupoHasta VarChar(15)
)
as
if(@pLista=@pLista_Ap and @pVersion = @pVersion_ap)
begin
update venListasPrecProd set
PrecioLista = round((PrecioLista*@pCoeficiente),@pDecimales),
PrecioPromocion=round((PrecioPromocion*@pCoeficiente),@pDecimales)
where ListaPrecio_Id=@pLista and 
	Version = @pVersion and 
Exists(select 1 
	from stkProductos LEFT JOIN stkFamilias ON 
	stkProductos.Familia_id = stkFamilias.stkFamilias 
	LEFT JOIN stkGrupos ON
	stkProductos.Grupo_Id = stkGrupos.stkGrupos
	Where
	stkProductos.stkProductos = venListasPrecProd.Producto_Id and
	stkProductos.Producto_Id between @pProductoDesde and @pProductoHasta and 
	isnull(stkFamilias.Familia_id,' ') between @pFamiliaDesde and @pFamiliaHasta and 
	isnull(stkGrupos.Grupo_Id,' ') between @pGrupoDesde and @pGrupoHasta)
		
end
else
begin
delete from venListasPrecProd where ListaPrecio_Id=@pLista_Ap and 
	Version = @pVersion_ap and 
	Exists(select 1 
		from stkProductos LEFT JOIN stkFamilias ON 
		stkProductos.Familia_id = stkFamilias.stkFamilias 
		LEFT JOIN stkGrupos ON
		stkProductos.Grupo_Id = stkGrupos.stkGrupos
		Where
		stkProductos.stkProductos = venListasPrecProd.Producto_Id and
		stkProductos.Producto_Id between @pProductoDesde and @pProductoHasta and 
		isnull(stkFamilias.Familia_id,' ') between @pFamiliaDesde and @pFamiliaHasta and 
		isnull(stkGrupos.Grupo_Id,' ') between @pGrupoDesde and @pGrupoHasta)
	

insert into venListasPrecProd
(
ListaPrecio_Id,
Version,
Producto_Id,
PrecioLista,
PrecioPromocion,
AdmiteRegalo
)
select @pLista_Ap, @pVersion_ap, Producto_Id, round((PrecioLista*@pCoeficiente),@pDecimales), round((PrecioPromocion*@pCoeficiente),@pDecimales),AdmiteRegalo
from venListasPrecProd
where ListaPrecio_Id=@pLista and 
	Version = @pVersion and 
	Exists(select 1 
	from stkProductos LEFT JOIN stkFamilias ON 
	stkProductos.Familia_id = stkFamilias.stkFamilias 
	LEFT JOIN stkGrupos ON
	stkProductos.Grupo_Id = stkGrupos.stkGrupos
	Where
	stkProductos.stkProductos = venListasPrecProd.Producto_Id and
	stkProductos.Producto_Id between @pProductoDesde and @pProductoHasta and 
	isnull(stkFamilias.Familia_id,' ') between @pFamiliaDesde and @pFamiliaHasta and 
	isnull(stkGrupos.Grupo_Id,' ') between @pGrupoDesde and @pGrupoHasta)

delete from venListasPrecBoniRec where ListaPrecio_Id=@pLista_Ap 

insert into venListasPrecBoniRec
(
ListaPrecio_Id,
NroBonifRecargo,
Nombre,
Formula,
UsaCtasProducto
)
select @pLista_Ap, NroBonifRecargo, Nombre, Formula, UsaCtasProducto
from venListasPrecBoniRec
where ListaPrecio_Id=@pLista
end
go



DROP PROCEDURE venListasPreciosTraerProductos
GO
CREATE PROCEDURE venListasPreciosTraerProductos
(
@pEmpresa_Id int,
@pListaPrecio_Id varchar(5),
@pVer Char(1), 
@pVersion Int  
)
AS
SET NOCOUNT ON 

SELECT venListasPrecios.venListasPrecios, '' as ListaPrecio_Id_Nueva, venListasPrecios.ListaPrecio_Id, venListasPrecios.Empresa_Id, Cast( Case When venListasPrecios.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	venListasPrecios.Descripcion, genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, venListasPrecios.LlevaImpuestoInclu,
	UsuarioAutorizado.Usuario_Id AS UsuarioAutorizado, genUsuarios.Apellido_y_Nombres as DescripcionUsuarioAutorizado, venListasPrecios.Inactivo, 
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, venListasPrecios.Posteado, '' as Excel,
	@pVer as Ver, venListasPrecios.DecimalesPu, 
	venListasVersion.Version,venListasVersion.VigenciaDesde, venListasVersion.VigenciaHasta
FROM venListasPrecios 
LEFT JOIN genMonedas  ON (genMonedas.genMonedas = venListasPrecios.Moneda_Id)
LEFT JOIN genUsuarios  AS UsuarioAutorizado ON (UsuarioAutorizado.genUsuarios = venListasPrecios.UsuAutorizado)
INNER JOIN genUsuarios ON (genUsuarios.genUsuarios = venListasPrecios.Usuario_Id)
INNER JOIN venListasVersion ON 
	venListasVersion.ListaPrecio_Id = venListasPrecios.venListasPrecios
WHERE 
	(venListasPrecios.ListaPrecio_Id = @pListaPrecio_Id)
 
SELECT stkProductos.Producto_Id, stkProductos.Descripcion,
	ISNULL(venListasPrecProd.PrecioLista, 0) as PrecioLista, 
	ISNULL(venListasPrecProd.PrecioPromocion,0) as PrecioPromocion, 
	Cast(ISNULL(venListasPrecProd.AdmiteRegalo, 0) as Bit) as AdmiteRegalo, 
	CAST(1 AS BIT) AS Marca
FROM venListasPrecios 
Inner JOIN venListasPrecProd ON venListasPrecProd.ListaPrecio_Id = venListasPrecios.venListasPrecios  and 
	venListasPrecProd.Version = @pVersion
INNER JOIN stkProductos ON venListasPrecProd.Producto_Id = stkProductos.stkProductos 	
Where (@pVer = 'L' Or @pVer = 'T') And
	venListasPrecios.ListaPrecio_Id = @pListaPrecio_Id And
		stkProductos.Acepta_ventas = 1 And 
		(stkProductos.Empresa_Id IS NULL or venListasPrecios.Empresa_Id Is Null Or
			stkProductos.Empresa_Id = venListasPrecios.Empresa_Id) And
		IsNull(stkProductos.Empresa_Id, @pEmpresa_Id) = @pEmpresa_Id And
		stkProductos.Inactivo = 0 And stkProductos.Posteado = 1
Union
SELECT stkProductos.Producto_Id, stkProductos.Descripcion,
	0 as PrecioLista, 
	0 as PrecioPromocion, 
	Cast(0 as Bit) as AdmiteRegalo, 
	CAST(0 AS BIT) AS Marca
FROM stkProductos
Where 
isnull(stkProductos.Empresa_Id,@pEmpresa_Id) = @pEmpresa_Id and 
Not Exists (Select 1 From venListasPrecProd Where 
					venListasPrecProd.ListaPrecio_Id = dbo.FuncFKvenListasPrecios(@pListaPrecio_Id) And
					venListasPrecProd.Producto_Id = stkProductos.stkProductos and 
					venListasPrecProd.Version = @pVersion) And
		(@pVer = 'F' Or @pVer = 'T') And
		stkProductos.Acepta_ventas = 1 And 
		IsNull(stkProductos.Empresa_Id, @pEmpresa_Id) = @pEmpresa_Id And
		stkProductos.Inactivo = 0 And stkProductos.Posteado = 1
ORDER BY 1

Exec venListasPrecBoniRecTodos @pListaPrecio_Id

 Declare @pidentity bigint= dbo.FuncFKvenListasPrecios(@pListaPrecio_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'venListasPrecios'
 RETURN @@Error
 Go


 DROP PROCEDURE venlistasHayOrta
 go

 CREATE PROCEDURE venlistasHayOrta
 (
	@ListaPrecio_Id VarChar(5),
	@Version Int,
	@VigenciaDesde DateTime, 
	@VigenciaHasta DateTime
 )
 AS

 SELECT venListasPrecios.ListaPrecio_Id, venListasVersion.Version,
		venListasVersion.VigenciaDesde  , venListasVersion.VigenciaHasta 
 from venListasPrecios 
 INNER JOIN venListasVersion ON
 venListasVersion.ListaPrecio_Id = venListasPrecios.venListasPrecios
 Where
		venListasPrecios.ListaPrecio_Id = @ListaPrecio_Id and
		venListasVersion.Version != @Version and 
		(@VigenciaDesde between venListasVersion.VigenciaDesde  and venListasVersion.VigenciaHasta  or
		 @VigenciaHasta between venListasVersion.VigenciaDesde  and venListasVersion.VigenciaHasta  )

GO

