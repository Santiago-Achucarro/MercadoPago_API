DROP PROCEDURE provarGlobalesGuardar
GO
CREATE PROCEDURE provarGlobalesGuardar
(
@pVariable_Id smallint,
@pDescripcion varchar(100),
@pValor qCantidadD8
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM provarGlobales WHERE (Variable_Id = @pVariable_Id)))
BEGIN 
	UPDATE provarGlobales
	SET		Descripcion = @pDescripcion,
		Valor = @pValor
	WHERE (Variable_Id = @pVariable_Id)
END 
ELSE 
BEGIN 
	INSERT INTO provarGlobales
	(
		Variable_Id,
		Descripcion,
		Valor
	)
	VALUES 
	(
		@pVariable_Id,
		@pDescripcion,
		@pValor
	)
END 

GO

DROP PROCEDURE provarGlobalesDatos
GO
CREATE PROCEDURE provarGlobalesDatos
(
@pVariable_Id smallint
)
AS
SET NOCOUNT ON 

SELECT provarGlobales.Variable_Id, provarGlobales.Descripcion, provarGlobales.Valor
FROM provarGlobales 
WHERE (Variable_Id = @pVariable_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE provarGlobalesEliminar
GO
CREATE PROCEDURE provarGlobalesEliminar
(
@pVariable_Id smallint = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM provarGlobales 
WHERE (Variable_Id = ISNULL(@pVariable_Id, Variable_Id))
 
 RETURN @@Error 

GO
drop Procedure proFormulasConVar
go
create Procedure proFormulasConVar

as
select proRecetas.Receta_Id,Renglon,stkProductos.Producto_Id,EntradaSalida,stkUniMed.Medida_Id,Formula,Cantidad,PorcentajeCosto,stkDepositos.Deposito_Id,proRecetasProd.Observaciones,TomaDepoT3 from proRecetasProd 
inner join stkProductos on stkProductos.stkProductos=proRecetasProd.Producto_Id
inner join stkUniMed on stkUniMed=proRecetasProd.Medida_Id
inner join stkDepositos on stkDepositos=proRecetasProd.Deposito_Id
inner join proRecetas on proRecetas=proRecetasProd.Receta_Id
where Formula like ('%var%')

GO
