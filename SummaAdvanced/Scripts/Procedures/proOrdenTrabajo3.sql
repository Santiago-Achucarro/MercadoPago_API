DROP PROCEDURE proOrdenTrabajos3Guardar
GO
CREATE PROCEDURE proOrdenTrabajos3Guardar
(
@pproOrden int,
@pRenglon int,
@pproTrabajo3 varchar(25),
@pProveed_Id varchar(15) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM proOrdenTrabajos3 WHERE (proOrden = @pproOrden) AND (Renglon = @pRenglon)))
BEGIN 
	UPDATE proOrdenTrabajos3
	SET		proTrabajo3 = dbo.FuncFKproTrabajo3(@pproTrabajo3),
		Proveed_Id = dbo.FuncFKcomProveedores(@pProveed_Id)
	WHERE (proOrden = @pproOrden) AND (Renglon = @pRenglon)
END 
ELSE 
BEGIN 
	INSERT INTO proOrdenTrabajos3
	(
		proOrden,
		Renglon,
		proTrabajo3,
		Proveed_Id
	)
	VALUES 
	(
		@pproOrden,
		@pRenglon,
		dbo.FuncFKproTrabajo3(@pproTrabajo3),
		dbo.FuncFKcomProveedores(@pProveed_Id)
	)
END 

GO

DROP PROCEDURE proOrdenTrabajos3Datos
GO
CREATE PROCEDURE proOrdenTrabajos3Datos
(
@pproOrden int,
@pRenglon int
)
AS
SET NOCOUNT ON 

SELECT proOrdenTrabajos3.proOrden, proOrdenTrabajos3.Renglon, proTrabajo3.Trabajo3_Id,
	proTrabajo3.Descripcion as DescripcionTrabajo3, comProveedores.Proveed_Id, comProveedores.RazonSocial as DescripcionProveedor
FROM proOrdenTrabajos3 
INNER JOIN proOrden  ON (proOrden.proOrden = proOrdenTrabajos3.proOrden)
inner join proTrabajo3 on proTrabajo3.proTrabajo3=proOrdenTrabajos3.proTrabajo3
left join comProveedores on comProveedores.genEntidades=proOrdenTrabajos3.Proveed_Id
WHERE (proOrden.proOrden = @pproOrden)
AND (Renglon = @pRenglon)
 
 RETURN @@Error 

GO

DROP PROCEDURE proOrdenTrabajos3Eliminar
GO
CREATE PROCEDURE proOrdenTrabajos3Eliminar
(
@pproOrden int,
@pRenglon int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM proOrdenTrabajos3 
WHERE (proOrden = @pproOrden)
AND (Renglon = ISNULL(@pRenglon, Renglon))
 
 RETURN @@Error 

GO

GO
