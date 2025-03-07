--prorecetasdatos 'AR-M-001'
drop procedure proRecetasDatos
go
create procedure proRecetasDatos
(
@pReceta_Id varchar(25)
)
as
set nocount on
--Principal
select proRecetas, Receta_Id, proRecetas.Descripcion, proRecetas.Empresa_Id, proCentroProductivo.CtroProd_Id, 
proCentroProductivo.Descripcion as descripcionCentroProd, TamBatch, Agrupa, Corte, proRecetas.Inactivo, proRecetas.Posteado,
genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, proRecetas.Notas, '' ParaPegar,
proRecetas.Tiempo, proRecetas.UnidadTiempo, proRecetas.Setup, proRecetas.SetupUT 
from proRecetas
left join proCentroProductivo on proCentroProductivo.proCentroProductivo=proRecetas.CtroProd_Id
left join genUsuarios on genUsuarios.genUsuarios= proRecetas.Usuario_Id
where Receta_Id=@pReceta_Id

--Productos
select proRecetas, Renglon, stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos, EntradaSalida,
stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, Formula, Cantidad, PorcentajeCosto, stkDepositos.Deposito_Id,
stkDepositos.Descripcion as DescripcionDeposito, proRecetasProd.Observaciones, TomaDepoT3
from proRecetasProd
inner join proRecetas on proRecetas=proRecetasProd.Receta_Id
left join stkproductos on stkProductos=proRecetasProd.Producto_Id
left join stkUniMed on stkUniMed=proRecetasProd.Medida_Id
left join stkDepositos on stkDepositos=proRecetasProd.Deposito_Id
where proRecetas.Receta_Id=@pReceta_Id

--Recursos
select proRecetas.proRecetas,Renglon,proRecursos.Recurso_Id, proRecursos.Descripcion as DescripcionRecurso, Cantidad 
from proRecetasRecursos
inner join proRecetas on proRecetas.proRecetas= proRecetasRecursos.proRecetas
left join proRecursos on proRecursos.proRecursos=proRecetasRecursos.Recurso_Id
where proRecetas.Receta_Id=@pReceta_Id

--Trabajo3
select proRecetas.proRecetas, proRecetas.Receta_Id, proRecetas.Descripcion as DescripcionReceta, 
proTrabajo3.proTrabajo3, proTrabajo3.Trabajo3_Id, proTrabajo3.Descripcion as DescripcionTrabajo3
from proRecetasTrabajo3
inner join proRecetas on proRecetas.proRecetas=proRecetasTrabajo3.Receta_Id
inner join proTrabajo3 on proTrabajo3.proTrabajo3=proRecetasTrabajo3.Trabajo3_Id
where proRecetas.Receta_Id=@pReceta_Id

Declare @pidentity bigint= dbo.FuncFKproRecetas(@pReceta_Id)
--genAtributosGenerales
Exec genAtributosGeneralesIdentityDatos @pidentity, 'proRecetas'

--Adjuntos
exec genAdjuntosIdentityDatos 'proRecetas', 0

RETURN @@Error 
go



DROP PROCEDURE proRecetasGuardar
GO
CREATE PROCEDURE proRecetasGuardar
(
@pReceta_Id varchar(25),
@pReceta_Id_Nuevo varchar(25),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(80),
@pCtroProd_Id varchar(8) = NULL,
@pTamBatch qCantidadD8,
@pAgrupa Sino,
@pCorte Sino,
@pInactivo Sino,
@pPosteado Sino,
@pUsuario_Id int = NULL,
@pFechaModificacion qFechaHora,
@pNotas Qmemo = Null,
@pTiempo numeric(15,4),
@pUnidadTiempo varchar(2),
@pSetup numeric(15,4),
@pSetupUT varchar(2)
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM proRecetas WHERE (Receta_Id = @pReceta_Id)))
BEGIN 
	UPDATE proRecetas
	SET		@lIdentidad = proRecetas,
		Receta_Id = @pReceta_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		CtroProd_Id = dbo.FuncFKproCentroProductivo(@pCtroProd_Id),
		TamBatch = @pTamBatch,
		Agrupa = @pAgrupa,
		Corte = @pCorte,
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id,
		FechaModificacion = @pFechaModificacion,
		Notas = @pNotas,
		Tiempo = @pTiempo,
		UnidadTiempo = @pUnidadTiempo,
		Setup = @pSetup,
		SetupUT = @pSetupUT
	WHERE (Receta_Id = @pReceta_Id)
END 
ELSE 
BEGIN 
	INSERT INTO proRecetas
	(
		Receta_Id,
		Empresa_Id,
		Descripcion,
		CtroProd_Id,
		TamBatch,
		Agrupa,
		Corte,
		Inactivo,
		Posteado,
		Usuario_Id,
		FechaModificacion,
		Notas,
		Tiempo,
		UnidadTiempo,
		Setup,
		SetupUT
	)
	VALUES 
	(
		@pReceta_Id,
		@pEmpresa_Id,
		@pDescripcion,
		dbo.FuncFKproCentroProductivo(@pCtroProd_Id),
		@pTamBatch,
		@pAgrupa,
		@pCorte,
		@pInactivo,
		@pPosteado,
		@pUsuario_Id,
		@pFechaModificacion,
		@pNotas,
		@pTiempo,
		@pUnidadTiempo,
		@pSetup,
		@pSetupUT
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO



DROP PROCEDURE proRecetasEliminar
GO
CREATE PROCEDURE proRecetasEliminar
(
@pReceta_Id varchar(25) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM proRecetas 
WHERE (Receta_Id = @pReceta_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKproRecetas
GO

CREATE FUNCTION FuncFKproRecetas
(
@pReceta_Id varchar (25)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = proRecetas FROM proRecetas WHERE 
	Receta_Id = @pReceta_Id
  RETURN @pIdentity
END


GO


DROP PROCEDURE proRecetasCambioProductoGuardar
GO

CREATE PROCEDURE proRecetasCambioProductoGuardar
(
	@ProductoOriginal VarChar(25),
	@ProductoNuevo VarChar(25),
	@Empresa_Id int
)

as
	Update proRecetasProd SET 
		Producto_Id = dbo.FuncFKstkProductos(@ProductoNuevo)
		Where
			Producto_Id = dbo.FuncFKstkProductos(@ProductoOriginal) and 
			Exists(SELECT 1 FROM proRecetas WHERE
				proRecetas.proRecetas = proRecetasProd.Receta_Id and 
				ISNULL(proRecetas.Empresa_Id,@Empresa_Id) = @Empresa_Id)

GO