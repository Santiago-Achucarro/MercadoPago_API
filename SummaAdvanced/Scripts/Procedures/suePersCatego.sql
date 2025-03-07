DROP PROCEDURE suePersCategoGuardar
GO
CREATE PROCEDURE suePersCategoGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pCategoria_Id varchar(5) = NULL,
@pUsuario_Id int
)
AS
SET NOCOUNT ON 
set @pLegajo=(select genEntidades from suePersonal where Legajo=@pLegajo)
IF (EXISTS (SELECT 1 FROM suePersCatego WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersCatego
	SET		FechaHasta = isnull((select min(Catego2.FechaDesde) 
		from suePersCatego Catego2 
		where 
		Catego2.Legajo = suePersCatego.Legajo and 
		Catego2.FechaDesde>suePersCatego.FechaDesde),@pFechaHasta),
		Categoria_Id = dbo.FuncFKsueCategorias(@pCategoria_Id),
		Usuario_Id = @pUsuario_Id
	WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
if not exists (select 1 from suePersCatego where suePersCatego.Legajo=@pLegajo)
BEGIN
set @pFechaDesde= (select FechaIngreso from suePersonal where suePersonal.genEntidades=@pLegajo)
end
if (not exists(select Categoria_Id from suePersCatego where (Legajo = @pLegajo) AND (FechaHasta = '29990101')and Categoria_Id= dbo.FuncFKsueCategorias(@pCategoria_Id)))
begin
update suePersCatego set FechaHasta=DATEADD(dd,-1, @pFechaDesde) where FechaHasta='29990101' and 	Legajo = @pLegajo
	INSERT INTO suePersCatego
	(
		Legajo,
		FechaDesde,
		FechaHasta,
		Categoria_Id,
		Usuario_Id
	)
	VALUES 
	(
		@pLegajo,
		@pFechaDesde,
		@pFechaHasta,
		dbo.FuncFKsueCategorias(@pCategoria_Id),
		@pUsuario_Id
	)
END 
end
GO

DROP PROCEDURE suePersCategoDatos
GO
CREATE PROCEDURE suePersCategoDatos
(
@pLegajo int
)
AS
SET NOCOUNT ON 

SELECT suePersCatego.Legajo, suePersCatego.FechaDesde, suePersCatego.FechaHasta, sueCategorias.Categoria_Id,
	sueCategorias.Descripcion as DescripcionCategorias, suePersCatego.Usuario_Id
FROM suePersCatego 
LEFT JOIN sueCategorias  ON (sueCategorias.sueCategorias = suePersCatego.Categoria_Id)
inner join suePersonal on suePersonal.genEntidades=suePersCatego.Legajo
WHERE (suePersonal.Legajo = @pLegajo)
 
 RETURN @@Error 

GO

DROP PROCEDURE suePersCategoEliminar
GO
CREATE PROCEDURE suePersCategoEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePersCatego 
WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
AND (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
 RETURN @@Error 

GO

GO
