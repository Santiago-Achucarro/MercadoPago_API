DROP PROCEDURE genMovimientosGuardar
GO
CREATE PROCEDURE genMovimientosGuardar
(
@pAsiento_Id bigint,
@pgenEntidades bigint = Null,
@pCantCuotas smallint
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genMovimientos WHERE (Asiento_Id = @pAsiento_Id)))
BEGIN 
	UPDATE genMovimientos
	SET		genEntidades = @pgenEntidades,
		CantCuotas = @pCantCuotas
	WHERE (Asiento_Id = @pAsiento_Id)
END 
ELSE 
BEGIN 
	INSERT INTO genMovimientos
	(
		Asiento_Id,
		genEntidades,
		CantCuotas
	)
	VALUES 
	(
		@pAsiento_Id,
		@pgenEntidades,
		@pCantCuotas
	)
END 

GO

DROP PROCEDURE genMovimientosDatos
GO
CREATE PROCEDURE genMovimientosDatos
(
@pAsiento_Id bigint
)
AS
SET NOCOUNT ON 

Select genMovimientos.Asiento_Id, genMovimientos.genEntidades, genMovimientos.CantCuotas, 'P' ClieProv, comMovTipos.Signo,
comProveedores.Proveed_Id ClieProv_Id, genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N
From genMovimientos
Inner Join comMovprov ON genMovimientos.Asiento_Id = comMovprov.comMovProv
Inner Join comMovTipos ON comMovTipos.TipoMov = comMovprov.TipoMov
Inner Join comProveedores On comProveedores.genEntidades = comMovProv.Proveed_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = comMovProv.comMovProv
Where (genMovimientos.Asiento_Id = @pAsiento_Id)
Union All
Select genMovimientos.Asiento_Id, genMovimientos.genEntidades, genMovimientos.CantCuotas, 'C' ClieProv, venTipoMov.Signo,
venClientes.Cliente_Id ClieProv_Id, genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N
From genMovimientos
Inner Join venMovimientos ON genMovimientos.Asiento_Id = venMovimientos.venMovimientos
Inner Join venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
Inner Join venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
left Join venClientes On venClientes.genEntidades = venMovimientos.Cliente_Id
Inner Join genAsiSegmentos On genAsiSegmentos.Asiento_Id = venMovimientos.venMovimientos
Where (genMovimientos.Asiento_Id = @pAsiento_Id)
 
RETURN @@Error 

GO

DROP PROCEDURE genMovimientosEliminar
GO
CREATE PROCEDURE genMovimientosEliminar
(
@pAsiento_Id bigint
)
AS
SET NOCOUNT ON 

DELETE FROM genMovimientos WHERE (Asiento_Id = @pAsiento_Id)
 
 RETURN @@Error 

GO

DROP Procedure genMovimientosIntDatos
GO
Create Procedure genMovimientosIntDatos
(
	 @Asiento_id bigInt
)
AS

SELECT comMovTipos.Signo, genMovimientos.Asiento_Id
	FROM genMovimientos 
	INNER JOIn comMovprov ON genMovimientos.Asiento_Id = comMovprov.comMovProv
	INNER JOIN comMovTipos ON comMovTipos.TipoMov = comMovprov.TipoMov
	Where
	comMovprov.comMovProv = @Asiento_id
UNION ALL
SELECT venTipoMov.Signo, genMovimientos.Asiento_Id
	FROM genMovimientos 
	INNER JOIn venMovimientos ON genMovimientos.Asiento_Id = venMovimientos.venMovimientos
	INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
	Where
		genMovimientos.Asiento_Id = @Asiento_id
GO