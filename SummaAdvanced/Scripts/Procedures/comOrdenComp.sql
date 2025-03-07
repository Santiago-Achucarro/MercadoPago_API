

-- comordencompDatos 1, 'OC',0,0,0,0, ' ',' ',' ',' '
DROP PROCEDURE comOrdenCompGuardar
GO
CREATE PROCEDURE comOrdenCompGuardar
(
@pEmpresa_Id int,
@pSegmento_Id VarChar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pTieneAutomatico bit,
@pFecha qFecha,
@pProveed_Id VarChar(15) = NULL,
@pTipoPermi_Id varchar(5) = NULL,
@pMoneda_Id varchar(3) = NULL,
@pAutorizo int = NULL,
@pCondPago_Id varchar(5) = NULL,
@pImpreso Sino,
@pObservaciones QMemo = NULL,
@pEstado_Id char(1),
@pSaldo_Anticipo qMonedaD2,
@pImporteImpuestos qMonedaD2,
@pSaldo_NC qMonedaD2,
@pCambio qMonedaD8,
@pUsuario_Id int,
@pPosteado Sino
)
AS
SET NOCOUNT ON 
DECLARE @pComOrdenComp as Int
SET @pComOrdenComp = (SELECT comOrdenComp 
	FROM comOCSegmentos WHERE 
	(Empresa_Id = @pEmpresa_Id) AND 
	(Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) AND 
	(Segmento1N = @pSegmento1N) AND 
	(Segmento2N = @pSegmento2N) AND 
	(Segmento3N = @pSegmento3N) AND 
	(Segmento4N = @pSegmento4N) AND 
	(Segmento1C = @pSegmento1C) AND 
	(Segmento2C = @pSegmento2C) AND 
	(Segmento3C = @pSegmento3C) AND 
	(Segmento4C = @pSegmento4C))

IF (@pComOrdenComp is not null)
	-- Actualizamos la orden Posteada o no.
	
		BEGIN 
			UPDATE comOrdenComp
			SET		
				Fecha = @pFecha,
				Proveed_Id = dbo.FuncFKcomProveedores(@pProveed_Id),
				TipoPermi_Id = dbo.FuncFKcomTipoPermi(@pTipoPermi_Id),
				Moneda_Id = dbo.FuncFKgenMonedas(@pMoneda_Id),
				Autorizo = @pAutorizo,
				CondPago_Id = dbo.FuncFKcomConPago(@pCondPago_Id),
				Impreso = @pImpreso,
				Observaciones = @pObservaciones,
				Estado_Id = @pEstado_Id,
				Saldo_Anticipo = @pSaldo_Anticipo,
				ImporteImpuestos = @pImporteImpuestos,
				Saldo_NC = @pSaldo_NC,
				Cambio = @pCambio,
				Usuario_Id = @pUsuario_Id,
				Posteado = @pPosteado
			WHERE 
				comOrdencomp.comOrdencomp = @pcomOrdencomp
		
		if (@pSegmento1N < 0) and (@pPosteado = 1)
						Set @pSegmento1N = (SELECT Case When MAX(Segmento1N) < 0 Then 0 Else Max(Segmento1N) End
						FROM comOcSegmentos inner join genSegmentos ON
						comOcSegmentos.Segmento_id = genSegmentos.genSegmentos
						WHERE
						(comOcSegmentos.Empresa_Id = @pEmpresa_Id) AND 
						(genSegmentos.Segmento_Id = @pSegmento_Id) AND 
						(Segmento2N = @pSegmento2N) AND 
						(Segmento3N = @pSegmento3N) AND 
						(Segmento4N = @pSegmento4N) AND 
						(Segmento1C = @pSegmento1C) AND 
						(Segmento2C = @pSegmento2C) AND 
						(Segmento3C = @pSegmento3C) AND 
						(Segmento4C = @pSegmento4C)) + 1

					If @pSegmento1N Is Null
					SET @pSegmento1N = (SELECT genContadorSegmento.PrimerNumero AS Segmento1N 
						FROM genContadorSegmento Where
							(genContadorSegmento.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) AND 
							(genContadorSegmento.Segmento2N = @pSegmento2N) AND 
							(genContadorSegmento.Segmento3N = @pSegmento3N) AND 
							(genContadorSegmento.Segmento4N = @pSegmento4N) AND 
							(genContadorSegmento.Segmento1C = @pSegmento1C) AND 
							(genContadorSegmento.Segmento2C = @pSegmento2C) AND 
							(genContadorSegmento.Segmento3C = @pSegmento3C) AND 
							(genContadorSegmento.Segmento4C = @pSegmento4C) And
							genContadorSegmento.Empresa_Id = @pEmpresa_Id)

					If (@pSegmento1N Is Null) or (@pSegmento1N < 0)
						Set @pSegmento1N = 1
					Update comOcSegmentos set Segmento1N = @pSegmento1N 	WHERE 
							comOcSegmentos.comOrdencomp = @pcomOrdencomp
		END  
		
ELSE 
-- Si tiene Automatico Averiguo cual Sigue
BEGIN

		if ((@pTieneAutomatico=1) AND (@pSegmento1N = 0))
			if @pPosteado = 1
				BEGIN
			
					set @pSegmento1N = (SELECT MAX(Segmento1N) 
						FROM 	comOcSegmentos inner join genSegmentos ON
						comOcSegmentos.Segmento_id = genSegmentos.genSegmentos
						WHERE
						(comOcSegmentos.Empresa_Id = @pEmpresa_Id) AND 
						(genSegmentos.Segmento_Id = @pSegmento_Id) AND 
						(Segmento2N = @pSegmento2N) AND 
						(Segmento3N = @pSegmento3N) AND 
						(Segmento4N = @pSegmento4N) AND 
						(Segmento1C = @pSegmento1C) AND 
						(Segmento2C = @pSegmento2C) AND 
						(Segmento3C = @pSegmento3C) AND 
						(Segmento4C = @pSegmento4C)) + 1

					If @pSegmento1N Is Null
					SET @pSegmento1N = (SELECT genContadorSegmento.PrimerNumero AS Segmento1N 
						FROM genContadorSegmento Where
							(genContadorSegmento.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) AND 
							(genContadorSegmento.Segmento2N = @pSegmento2N) AND 
							(genContadorSegmento.Segmento3N = @pSegmento3N) AND 
							(genContadorSegmento.Segmento4N = @pSegmento4N) AND 
							(genContadorSegmento.Segmento1C = @pSegmento1C) AND 
							(genContadorSegmento.Segmento2C = @pSegmento2C) AND 
							(genContadorSegmento.Segmento3C = @pSegmento3C) AND 
							(genContadorSegmento.Segmento4C = @pSegmento4C) And
							genContadorSegmento.Empresa_Id = @pEmpresa_Id)

					If (@pSegmento1N Is Null) or (@pSegmento1N < 0)
						Set @pSegmento1N = 1

					END
		Else
				BEGIN

					SET @pSegmento1N = isnull((SELECT MIN(comOcSegmentos.Segmento1N) AS Segmento1N 
							FROM 	comOcSegmentos inner join genSegmentos ON
								comOcSegmentos.Segmento_id =   dbo.FuncFKgenSegmentos(@pSegmento_Id) And
								comOcSegmentos.Segmento1N < 0 and 
								comOcSegmentos.Empresa_id = @pEmpresa_Id and 
								comOcSegmentos.Segmento2N = @pSegmento2N And
								comOcSegmentos.Segmento3N = @pSegmento3N And
								comOcSegmentos.Segmento4N = @pSegmento4N And
								comOcSegmentos.Segmento1C = @pSegmento1C And
								comOcSegmentos.Segmento2C = @pSegmento2C And
								comOcSegmentos.Segmento3C = @pSegmento3C And
								comOcSegmentos.Segmento4C = @pSegmento4C),0)-1

					If (@pSegmento1N = 0)
						Set @pSegmento1N = -1

		
								
				End	
		/* FM 08/06/2020 Corregir el BE para que no pase esto
		if (@pSegmento1N = 0)
			SET @pSegmento1N = 1
		*/
	INSERT INTO comOrdenComp
	(
		Fecha,
		Proveed_Id,
		TipoPermi_Id,
		Moneda_Id,
		Autorizo,
		CondPago_Id,
		Impreso,
		Observaciones,
		Estado_Id,
		Saldo_Anticipo,
		ImporteImpuestos,
		Saldo_NC,
		Cambio,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pFecha,
		dbo.FuncFKcomProveedores(@pProveed_Id),
		dbo.FuncFKcomTipoPermi(@pTipoPermi_Id),
		dbo.FuncFKgenMonedas(@pMoneda_Id),
		@pAutorizo,
		dbo.FuncFKcomConPago(@pCondPago_Id),
		@pImpreso,
		@pObservaciones,
		@pEstado_Id,
		@pSaldo_Anticipo,
		@pImporteImpuestos,
		@pSaldo_NC,
		@pCambio,
		@pUsuario_Id,
		@pPosteado
	)
	
	SET @pComOrdencomp =  Cast(SCOPE_IDENTITY() as int) 
	
	-- Inserto en la Cabecera
	EXEC comOCSegmentosInsertar @pEmpresa_Id ,@pSegmento_Id , @pSegmento1N ,@pSegmento2N ,
		@pSegmento3N ,@pSegmento4N , @pSegmento1C ,@pSegmento2C ,@pSegmento3C ,
		@pSegmento4C , @pComOrdenComp
		
	
END 

Select @pComOrdencomp as RetVal 

GO


DROP PROCEDURE comOrdenCompDatos
GO
CREATE PROCEDURE comOrdenCompDatos
(
@pEmpresa_Id int,
@pSegmento_Id VarChar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20)
)
AS
SET NOCOUNT ON 

DECLARE @pComOrdenComp as Int
SET @pComOrdenComp = (SELECT comOrdenComp 
	FROM comOCSegmentos WHERE 
	(Empresa_Id = @pEmpresa_Id) AND 
	(Segmento_Id = dbo.FuncFkgenSegmentos(@pSegmento_Id)) AND 
	(Segmento1N = @pSegmento1N) AND 
	(Segmento2N = @pSegmento2N) AND 
	(Segmento3N = @pSegmento3N) AND 
	(Segmento4N = @pSegmento4N) AND 
	(Segmento1C = @pSegmento1C) AND 
	(Segmento2C = @pSegmento2C) AND 
	(Segmento3C = @pSegmento3C) AND 
	(Segmento4C = @pSegmento4C))



SELECT comOrdenComp.comOrdenComp, comOCSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
	comOCSegmentos.Segmento1N,comOCSegmentos.Segmento2N, comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N, 
	comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C, comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C,
	comOrdenComp.Fecha, comProveedores.Proveed_Id, comProveedores.RazonSocial as DescripcionProveedores,
	comTipoPermi.TipoPermi_Id, comTipoPermi.Descripcion as DescripcionTipoPermi, 
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, comOrdenComp.Autorizo as NroUsuAuto,
	Autorizo.Usuario_Id as Autorizo, Autorizo.Apellido_y_Nombres as DescripcionUsuarioAutorizo, 
	comConPago.CondPago_Id, comConPago.Descripcion as DescripcionConPago,
	comOrdenComp.Impreso, comOrdenComp.Observaciones, 
	comOcEstados.Estado_Id, comOcEstados.Descripcion as DescripcionOcEstados,
	comOrdenComp.Saldo_Anticipo, comOrdenComp.ImporteImpuestos, 
	comOrdenComp.Saldo_NC, comOrdenComp.Cambio,
	genUsuarios2.Usuario_Id, genUsuarios2.Apellido_y_Nombres as DescripcionUsuario, 
	comOrdenComp.Posteado, comTipoPermi.TipoCuerpo, 
	ISNULL((SELECT SUM(Cantidad*Precio) from comOCCuerpo where
			comOCCuerpo.comOrdenComp = comOrdenComp.comOrdenComp),0) as SubTotal,
	comOrdenComp.ImporteImpuestos + ISNULL((SELECT SUM(Cantidad*Precio) from comOCCuerpo where
			comOCCuerpo.comOrdenComp = comOrdenComp.comOrdenComp),0) as Total, dbo.FechaActual() as FechaNueva
FROM comOrdenComp 
LEFT JOIN comProveedores  ON (comProveedores.genEntidades = comOrdenComp.Proveed_Id)
LEFT JOIN comTipoPermi  ON (comTipoPermi.comTipoPermi = comOrdenComp.TipoPermi_Id)
LEFT JOIN genMonedas  ON (genMonedas.genMonedas = comOrdenComp.Moneda_Id)
LEFT JOIN genUsuarios  as Autorizo ON (Autorizo.genUsuarios = comOrdenComp.Autorizo)
LEFT JOIN comConPago  ON (comConPago.comConPago = comOrdenComp.CondPago_Id)
INNER JOIN comOcEstados  ON (comOcEstados.Estado_Id = comOrdenComp.Estado_Id)
INNER JOIN genUsuarios genUsuarios2 ON (genUsuarios2.genUsuarios = comOrdenComp.Usuario_Id)
INNER JOIN comOcSegmentos ON comOcSegmentos.comOrdencomp = comOrdencomp.comOrdenComp
INNER JOIN genSegmentos  ON (genSegmentos.genSegmentos = comOCSegmentos.Segmento_Id)
WHERE  
	comOrdenComp.comOrdenComp = @pComOrdenComp

 exec comOcArticuloDatos @pComOrdenComp
 exec comOCMemoDatos @pComOrdenComp
 Exec genAtributosGeneralesIdentityDatos @pComOrdenComp, 'comOrdenComp'
 exec comOCAutorizandoDatos @pComOrdenComp, null

-- Solo necesito la estructura porque se llama a demanda desde otra acción --
exec genAdjuntosIdentityDatos 'comOrdenComp',  0	

RETURN @@Error 

GO

DROP PROCEDURE comOrdenCompEliminar
GO
CREATE PROCEDURE comOrdenCompEliminar
(
 @pComordencomp int
)
AS
SET NOCOUNT ON 

DELETE FROM comOrdenComp 
WHERE  
	comordencomp = @pComordencomp
 RETURN @@Error 

GO

DROP PROCEDURE comOrdenCompDatosInt
GO
CREATE PROCEDURE comOrdenCompDatosInt
( @pComOrdenComp int)
as
	select comOcSegmentos.comOrdenComp, comOCSegmentos.Empresa_Id, genSegmentos.Segmento_Id,
	comOCSegmentos.Segmento1N,comOCSegmentos.Segmento2N, comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N, 
	comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C, comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C
	from comOcSegmentos INNER JOIN genSegmentos ON
	comOcSegmentos.Segmento_Id = genSegmentos.genSegmentos
	Where
	comOcSegmentos.comOrdenComp = @pcomOrdenComp

GO

DROP PROCEDURE comOrdenCompCambiarEstado
GO

CREATE PROCEDURE comOrdenCompCambiarEstado(
	@pComOrdenComp Int, 
	@pEstado_Id Char(1),
	@pUsuario_Id Int
	)
	as
	
	Update ComOrdenComp set Estado_Id = @pEstado_Id,
		Autorizo = 
			case when @pEstado_Id IN ('R','A') THEN @pUsuario_id else Autorizo end
	Where
		comOrdenComp = @pComOrdenComp
GO

DROP PROCEDURE comOrdenCompDatosTPermi
GO
CREATE PROCEDURE comOrdenCompDatosTPermi
(
@pTipoPermi_Id varchar(20)
)
AS
SET NOCOUNT ON 

DECLARE @pComOrdenComp as Int
SET @pComOrdenComp = isNull((SELECT Min(comOrdenComp)
	FROM comOrdenComp WHERE 
	TipoPermi_Id = dbo.FuncFKcomTipoPermi(@pTipoPermi_Id)), 0)



SELECT comOrdenComp.comOrdenComp, comOCSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
	comOCSegmentos.Segmento1N,comOCSegmentos.Segmento2N, comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N, 
	comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C, comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C,
	comOrdenComp.Fecha, comProveedores.Proveed_Id, comProveedores.RazonSocial as DescripcionProveedores,
	comTipoPermi.TipoPermi_Id, comTipoPermi.Descripcion as DescripcionTipoPermi, 
	genMonedas.Moneda_Id, genMonedas.Descripcion as DescripcionMonedas, comOrdenComp.Autorizo as NroUsuAuto,
	Autorizo.Usuario_Id as Autorizo, Autorizo.Apellido_y_Nombres as DescripcionUsuarioAutorizo, 
	comConPago.CondPago_Id, comConPago.Descripcion as DescripcionConPago,
	comOrdenComp.Impreso, comOrdenComp.Observaciones, 
	comOcEstados.Estado_Id, comOcEstados.Descripcion as DescripcionOcEstados,
	comOrdenComp.Saldo_Anticipo, comOrdenComp.ImporteImpuestos, 
	comOrdenComp.Saldo_NC, comOrdenComp.Cambio,
	genUsuarios2.Usuario_Id, genUsuarios2.Apellido_y_Nombres as DescripcionUsuario, 
	comOrdenComp.Posteado, comTipoPermi.TipoCuerpo, 
	ISNULL((SELECT SUM(Cantidad*Precio) from comOCCuerpo where
			comOCCuerpo.comOrdenComp = comOrdenComp.comOrdenComp),0) as SubTotal,
	comOrdenComp.ImporteImpuestos + ISNULL((SELECT SUM(Cantidad*Precio) from comOCCuerpo where
			comOCCuerpo.comOrdenComp = comOrdenComp.comOrdenComp),0) as Total, dbo.FechaActual() as FechaNueva
FROM comOrdenComp 
LEFT JOIN comProveedores  ON (comProveedores.genEntidades = comOrdenComp.Proveed_Id)
LEFT JOIN comTipoPermi  ON (comTipoPermi.comTipoPermi = comOrdenComp.TipoPermi_Id)
LEFT JOIN genMonedas  ON (genMonedas.genMonedas = comOrdenComp.Moneda_Id)
LEFT JOIN genUsuarios  as Autorizo ON (Autorizo.genUsuarios = comOrdenComp.Autorizo)
LEFT JOIN comConPago  ON (comConPago.comConPago = comOrdenComp.CondPago_Id)
INNER JOIN comOcEstados  ON (comOcEstados.Estado_Id = comOrdenComp.Estado_Id)
INNER JOIN genUsuarios genUsuarios2 ON (genUsuarios2.genUsuarios = comOrdenComp.Usuario_Id)
INNER JOIN comOcSegmentos ON comOcSegmentos.comOrdencomp = comOrdencomp.comOrdenComp
INNER JOIN genSegmentos  ON (genSegmentos.genSegmentos = comOCSegmentos.Segmento_Id)
WHERE  
	comOrdenComp.comOrdenComp = @pComOrdenComp

 exec comOcArticuloDatos @pComOrdenComp
 exec comOCMemoDatos @pComOrdenComp
 Exec genAtributosGeneralesIdentityDatos @pComOrdenComp, 'comOrdenComp'
 exec comOCAutorizandoDatos @pComOrdenComp, null

-- Solo necesito la estructura porque se llama a demanda desde otra acción --
exec genAdjuntosIdentityDatos 'comOrdenComp',  0	

RETURN @@Error 

GO

	