DROP PROCEDURE venListasPrecBoniRecGuardar
GO
CREATE PROCEDURE venListasPrecBoniRecGuardar
(
@pListaPrecio_Id int,
@pNroBonifRecargo smallint,
@pNombre varchar(20),
@pFormula qFormula,
@pUsaCtasProducto Sino,
@pCtaBonificacion varChar(25),
@pCtaRecargo varChar(25)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venListasPrecBoniRec WHERE (ListaPrecio_Id = @pListaPrecio_Id) AND (NroBonifRecargo = @pNroBonifRecargo)))
BEGIN 
	UPDATE venListasPrecBoniRec
	SET Nombre = @pNombre,
		Formula = @pFormula,
		UsaCtasProducto = @pUsaCtasProducto,
		CtaBonificacion = dbo.FuncFKconCuentas(@pCtaBonificacion),
		CtaRecargo = dbo.FuncFKconCuentas(@pCtaRecargo)
	WHERE (ListaPrecio_Id = @pListaPrecio_Id) AND (NroBonifRecargo = @pNroBonifRecargo)
END 
ELSE 
BEGIN 
	INSERT INTO venListasPrecBoniRec
	(
		ListaPrecio_Id,
		NroBonifRecargo,
		Nombre,
		Formula,
		UsaCtasProducto,
		CtaBonificacion,
		CtaRecargo
	)
	VALUES 
	(
		@pListaPrecio_Id,
		@pNroBonifRecargo,
		@pNombre,
		@pFormula,
		@pUsaCtasProducto,
		dbo.FuncFKconCuentas(@pCtaBonificacion),
		dbo.FuncFKconCuentas(@pCtaRecargo)
	)
END 

GO

DROP PROCEDURE venListasPrecBoniRecDatos
GO
CREATE PROCEDURE venListasPrecBoniRecDatos
(
@pListaPrecio_Id varchar(5),
@pNroBonifRecargo smallint
)
AS
SET NOCOUNT ON 

SELECT venListasPrecios.venListasPrecios, venListasPrecios.ListaPrecio_Id, venListasPrecBoniRec.NroBonifRecargo, venListasPrecBoniRec.Nombre, venListasPrecBoniRec.Formula,
venListasPrecBoniRec.UsaCtasProducto, CtaBonif.Cuenta_Id CtaBonificacion, CtaBonif.Descripcion DescripcionCtaBonif,  
CtaRecargo.Cuenta_Id CtaRecargo, CtaRecargo.Descripcion DescripcionCtaRecargo
FROM venListasPrecBoniRec
Inner Join venListasPrecios On venListasPrecios.venListasPrecios = venListasPrecBoniRec.ListaPrecio_Id
Left Join conCuentas CtaBonif On CtaBonif.conCuentas = venListasPrecBoniRec.CtaBonificacion
Left Join conCuentas CtaRecargo On CtaRecargo.conCuentas = venListasPrecBoniRec.CtaRecargo
WHERE (venListasPrecios.ListaPrecio_Id = @pListaPrecio_Id)
AND (NroBonifRecargo = @pNroBonifRecargo)
 
 RETURN @@Error 

GO

DROP PROCEDURE venListasPrecBoniRecEliminar
GO
CREATE PROCEDURE venListasPrecBoniRecEliminar
(
@pListaPrecio_Id varchar(5),
@pNroBonifRecargo smallint = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venListasPrecBoniRec 
WHERE (ListaPrecio_Id = dbo.FuncFKvenListasPrecios(@pListaPrecio_id))
AND (NroBonifRecargo = ISNULL(@pNroBonifRecargo, NroBonifRecargo)) 

 RETURN @@Error 

GO

DROP PROCEDURE venListasPrecBoniRecTodos
GO
CREATE PROCEDURE venListasPrecBoniRecTodos
(
@pListaPrecio_Id varchar(5)
)
AS
SELECT 
XXX.NroBonifRecargo, ISNULL(venListasPrecBoniRec.Nombre, 'Descuento '+str(xxx.NroBonifRecargo,1) ) AS Nombre , 
ISNULL(venListasPrecBoniRec.Formula,'0') AS Formula, 
isNull(venListasPrecBoniRec.UsaCtasProducto, 1) UsaCtasProducto, CtaBonif.Cuenta_Id CtaBonificacion, CtaBonif.Descripcion DescripcionCtaBonif,  
CtaRecargo.Cuenta_Id CtaRecargo, CtaRecargo.Descripcion DescripcionCtaRecargo
FROM (SELECT Cast(1 As smallint) AS NroBonifRecargo
		UNION ALL
		SELECT Cast(2 As smallint) AS NroBonifRecargo
		UNION ALL
		SELECT Cast(3 As smallint) AS NroBonifRecargo
		UNION ALL
		SELECT Cast(4 As smallint) AS NroBonifRecargo
		UNION ALL
		SELECT Cast(5 As smallint) AS NroBonifRecargo) AS XXX 
LEFT OUTER JOIN  (venListasPrecBoniRec Inner Join venListasPrecios ON 
				venListasPrecios.venListasPrecios = venListasPrecBoniRec.ListaPrecio_Id AND 
				venListasPrecios.ListaPrecio_Id = @pListaPrecio_Id	) ON
				XXX.NroBonifRecargo = venListasPrecBoniRec.NroBonifRecargo
Left Join conCuentas CtaBonif On CtaBonif.conCuentas = venListasPrecBoniRec.CtaBonificacion
Left Join conCuentas CtaRecargo On CtaRecargo.conCuentas = venListasPrecBoniRec.CtaRecargo
ORDER BY 1