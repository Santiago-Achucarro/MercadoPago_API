DROP PROCEDURE sueCategoriasGuardar
GO
CREATE PROCEDURE sueCategoriasGuardar
(
@pCategoria_Id varchar(5),
@pCategoria_Id_Nuevo varchar(5),
@pDescripcion varchar(100),
@pPeriodo_Id char(1) = NULL,
@pInactivo Sino,
@pPosteado Sino,
@pUsuario_Id int = NULL,
@pEmpresa_Id int=null
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM sueCategorias WHERE (Categoria_Id = @pCategoria_Id)))
BEGIN 
	UPDATE sueCategorias
	SET		@lIdentidad = sueCategorias,
		Categoria_Id = @pCategoria_Id_Nuevo,
		Descripcion = @pDescripcion,
		Periodo_Id = @pPeriodo_Id,
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id,
		Empresa_Id=@pEmpresa_Id
		
	WHERE (Categoria_Id = @pCategoria_Id)
END 
ELSE 
BEGIN 
	INSERT INTO sueCategorias
	(
		Categoria_Id,
		Descripcion,
		Periodo_Id,
		Inactivo,
		Posteado,
		Usuario_Id,
		Empresa_Id
	)
	VALUES 
	(
		@pCategoria_Id,
		@pDescripcion,
		@pPeriodo_Id,
		@pInactivo,
		@pPosteado,
		@pUsuario_Id,
		@pEmpresa_Id
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE sueCategoriasDatos
GO
CREATE PROCEDURE sueCategoriasDatos
(
@pCategoria_Id varchar(5),
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

SELECT sueCategorias.sueCategorias, sueCategorias.Categoria_Id, sueCategorias.Descripcion, sueCategorias.Periodo_Id,
	suePeriodicidad.Descripcion as DescripcionPeriodicidad, sueCategorias.Inactivo, sueCategorias.Posteado, sueCategorias.Usuario_Id, sueCategorias.Empresa_Id,
	cast(case when sueCategorias.Empresa_Id is null then 1 else 0 end as bit) as PTodasEmpresas, dbo.FechaActual() as Fecha
FROM sueCategorias 
LEFT JOIN suePeriodicidad  ON (suePeriodicidad.Periodo_Id = sueCategorias.Periodo_Id)
WHERE (Categoria_Id = @pCategoria_Id)
 

 select sueCategorias.Categoria_Id, sueCategorias.Descripcion as DescripcionCategoria, sueCateNombre.CateNombre_Id, sueCateNombre.Descripcion as DescripcionCateNombre, 
Fecha_Desde, isnull(Valor,0) as Valor, sueLiqImpCatego.Usuario_Id, 0 as Empresa_Id from sueCateNombre
left join sueLiqImpCatego on sueCateNombre.CateNombre_Id=sueLiqImpCatego.CateNombre_Id and  sueLiqImpCatego.Categoria_Id=dbo.FuncFKsueCategorias(@pCategoria_Id) and
dbo.FechaActual() between sueLiqImpCatego.Fecha_Desde and Fecha_Hasta
left join sueCategorias on sueCategorias.sueCategorias=sueLiqImpCatego.Categoria_Id 
where sueCateNombre.PorEmpresa=0

union all
select sueCategorias.Categoria_Id, sueCategorias.Descripcion as DescripcionCategoria, sueCateNombre.CateNombre_Id, sueCateNombre.Descripcion as DescripcionCateNombre, 
Fecha_Desde, isnull(Valor, 0) as Valor, sueLiqEmpCatego.Usuario_Id, sueLiqEmpCatego.Empresa_Id from sueCateNombre
left join sueLiqEmpCatego on sueCateNombre.CateNombre_Id=sueLiqEmpCatego.CateNombre_Id and
sueLiqEmpCatego.Categoria_Id=dbo.FuncFKsueCategorias(@pCategoria_Id) and
sueLiqEmpCatego.Empresa_Id=@pEmpresa_Id and
dbo.FechaActual() between Fecha_Desde and Fecha_Hasta
left join sueCategorias on sueCategorias.sueCategorias=sueLiqEmpCatego.Categoria_Id
where sueCateNombre.PorEmpresa=1



  Declare @pidentity bigint= dbo.FuncFKsueCategorias(@pCategoria_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'sueCategorias'
 RETURN @@Error 

GO

DROP PROCEDURE sueCategoriasEliminar
GO
CREATE PROCEDURE sueCategoriasEliminar
(
@pCategoria_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM sueCategorias 
WHERE (Categoria_Id = @pCategoria_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKsueCategorias
GO

CREATE FUNCTION FuncFKsueCategorias
(
@pCategoria_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = sueCategorias FROM sueCategorias WHERE 
	Categoria_Id = @pCategoria_Id
  RETURN @pIdentity
END


GO
