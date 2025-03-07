DROP PROCEDURE stkSolicitudCDGuardar
GO
CREATE PROCEDURE stkSolicitudCDGuardar
(
    @pstkSolicitudCD bigint,
@pDepositoDestino varchar(15) = NULL,
@pFecha datetime = NULL,
@pEstado char,
@pPosteado SiNo,
@pUsuario_Id int,
@pObservaciones qMemo
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad bigint
IF (EXISTS (SELECT 1 FROM stkSolicitudCD WHERE stkSolicitudCD=@pstkSolicitudCD))
BEGIN 
	UPDATE stkSolicitudCD
	SET		@lIdentidad = stkSolicitudCD,
		DepositoDestino = dbo.FuncFKstkDepositos(@pDepositoDestino),
		Fecha = @pFecha,
		Estado=@pEstado,
		Posteado=@pPosteado,
		Usuario_Id=@pUsuario_Id,
		Observaciones=@pObservaciones
	WHERE stkSolicitudCD=@pstkSolicitudCD
END 
ELSE 
BEGIN 
	INSERT INTO stkSolicitudCD
	(
		DepositoDestino,
		Fecha,
		Estado,
		Posteado,
		Usuario_Id,
		Observaciones
	)
	VALUES 
	(
		dbo.FuncFKstkDepositos(@pDepositoDestino),
		@pFecha,
		@pEstado,
		@pPosteado,
		@pUsuario_Id,
		@pObservaciones
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as bigint) 
END 
Select @lIdentidad as RetVal 

GO


DROP PROCEDURE stkSolicitudCDDatos
GO
CREATE PROCEDURE stkSolicitudCDDatos
(
@pSegmento_Id varchar(25),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 
declare @pstkSolicitudCD int =(select stkSolicitudCD from stkSolicitudCDSegmento WHERE
Segmento_Id=dbo.FuncFKgenSegmentos(@pSegmento_Id) and Segmento1N=@pSegmento1N and Segmento2N=@pSegmento2N AND Segmento3N=@pSegmento3N and Segmento4N=@pSegmento4N AND
Segmento1C=@pSegmento1C and Segmento2C=@pSegmento2C and Segmento3C=@pSegmento3C and Segmento4C=@pSegmento4C and Empresa_Id=@pEmpresa_Id)

SELECT stkSolicitudCD.stkSolicitudCD, stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDepositos, stkSolicitudCD.Fecha,
genSegmentos.Segmento_Id, stkSolicitudCDSegmento.Segmento1N, stkSolicitudCDSegmento.Segmento2N, stkSolicitudCDSegmento.Segmento3N, stkSolicitudCDSegmento.Segmento4N, 
stkSolicitudCDSegmento.Segmento1C, stkSolicitudCDSegmento.Segmento2C, stkSolicitudCDSegmento.Segmento3C, stkSolicitudCDSegmento.Segmento4C, Estado, stkSolicitudCD.Posteado, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres, Observaciones
FROM stkSolicitudCD 
LEFT JOIN stkDepositos  ON (stkDepositos.stkDepositos = stkSolicitudCD.DepositoDestino)
inner join stkSolicitudCDSegmento on stkSolicitudCDSegmento.stkSolicitudCD=stkSolicitudCD.stkSolicitudCD
inner join genSegmentos on genSegmentos.genSegmentos=stkSolicitudCDSegmento.Segmento_Id
inner join genUsuarios on genUsuarios.genUsuarios=stkSolicitudCD.Usuario_Id
WHERE (stkSolicitudCD.stkSolicitudCD = @pstkSolicitudCD)

select stkSolicitudCD,  stkSolicitudCDCuerpo.Renglon, stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProducto, stkDepositos.Deposito_Id as DepositoOrigen, stkDepositos.Descripcion as DescripcionDeposito,
stkSolicitudCDCuerpo.Observaciones, stkSolicitudCDCuerpo.Cantidad, CantidadPendiente, 0 as CantidadForm, stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionMedida from stkSolicitudCDCuerpo
inner join stkProductos on stkProductos.stkProductos=stkSolicitudCDCuerpo.Producto_Id
inner join stkDepositos on stkDepositos.stkDepositos=stkSolicitudCDCuerpo.DepositoOrigen
inner join stkUniMed on stkUniMed.stkUniMed=stkSolicitudCDCuerpo.Medida_Id
where stkSolicitudCDCuerpo.stkSolicitudCD=@pstkSolicitudCD 
RETURN @@Error 

GO

DROP PROCEDURE stkSolicitudCDEliminar
GO
CREATE PROCEDURE stkSolicitudCDEliminar
(
@pstkSolicitudCD bigint 
)
AS
SET NOCOUNT ON 

DELETE FROM stkSolicitudCD 
WHERE (stkSolicitudCD = @pstkSolicitudCD)
 
 RETURN @@Error 

GO

GO
