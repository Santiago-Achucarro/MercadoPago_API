DROP PROCEDURE sueTipoPagoGuardar
GO
CREATE PROCEDURE sueTipoPagoGuardar
(
@pTipoPago_Id varchar(5),
@pTipoPago_Id_Nueva varchar(5),
@pDescripcion varchar(60),
@pEmpresa_Id int = NULL,
@pInactivo Sino,
@pPosteado Sino,
@pUsuario_Id int
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM sueTipoPago WHERE @pTipoPago_Id=TipoPago_Id))
BEGIN 
	UPDATE sueTipoPago
	SET		@lIdentidad = sueTipoPago,
		TipoPago_Id = @pTipoPago_Id_Nueva,
		Descripcion = @pDescripcion,
		Empresa_Id = @pEmpresa_Id,
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id
	WHERE 
	TipoPago_Id=@pTipoPago_Id
END 
ELSE 
BEGIN 
	INSERT INTO sueTipoPago
	(
		TipoPago_Id,
		Descripcion,
		Empresa_Id,
		Inactivo,
		Posteado,
		Usuario_Id
	)
	VALUES 
	(
		@pTipoPago_Id,
		@pDescripcion,
		@pEmpresa_Id,
		@pInactivo,
		@pPosteado,
		@pUsuario_Id
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE sueTipoPagoDatos
GO
create procedure sueTipoPagoDatos
(
@pTipoPago_Id varchar(5)
)
as
select sueTipoPago, TipoPago_Id, Descripcion, Empresa_Id, Inactivo, Posteado, Usuario_Id ,
cast(case when sueTipoPago.Empresa_Id is null then 1 else 0 end as bit) as PTodasEmpresas
from sueTipoPago
where TipoPago_Id=@pTipoPago_Id
 Declare @pidentity bigint= dbo.FuncFKsueTipoPago(@pTipoPago_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'sueTipoPago'
 RETURN @@Error 
 go

 drop procedure sueTipoPagoEliminar
 go
 create procedure sueTipoPagoEliminar
 (
 @pTipoPago_Id varchar(5)
 )
 as
 delete sueTipoPago where TipoPago_Id=@pTipoPago_Id
 return @@Error
 go

 DROP FUNCTION FuncFKsueTipoPago
GO

CREATE FUNCTION FuncFKsueTipoPago
(
@pTipoPago_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = sueTipoPago FROM sueTipoPago WHERE 
	TipoPago_Id = @pTipoPago_Id
  RETURN @pIdentity
END


GO
