-- inf_CadenaProduccion 'CH-105-100EP '

DROP PROCEDURE inf_proCadenaProduccionAux
GO
CREATE PROCEDURE inf_proCadenaProduccionAux
(
	@pReceta_id INT, 
	@TablaTemp VarChar(50), 
	@Nivel Int
)

AS

Declare @Sql VarChar(max)


set @Sql = 
'INSERT INTO '+@TablaTemp+
' Select proRecetas.Receta_Id, proRecetas.Descripcion, 	proCentroProductivo.CtroProd_Id,  proCentroProductivo.Descripcion as DescripcionCentro, '+
	str(@Nivel,3)+' AS Nivel
From proRecetas INNER JOIN proProductosReceta ON
proProductosReceta.Receta_Id =  proRecetas.proRecetas 
INNER JOIN proCentroProductivo ON
proCentroProductivo.proCentroProductivo = proRecetas.CtroProd_Id
Where
	proRecetas.proRecetas = '+STR(@pReceta_Id,10)

Exec sp_sqlexec @Sql

DECLARE @Receta_Id int
DECLARE @Renglon INT

-- BUSCO EL CUERPO
DECLARE CUERPO_CURSOR1 CURSOR LOCAL DYNAMIC FOR
SELECT  proProductosReceta.Receta_id, proRecetasProd.Renglon
from proProductosReceta 
inner join proRecetasProd ON 
	proRecetasProd.Producto_Id = proProductosReceta.Producto_Id  and 
	proRecetasProd.EntradaSalida = 'C' and 
	proProductosReceta.Principal = 1
Where
	proRecetasProd.Receta_Id = @pReceta_Id
order by 2

OPEN CUERPO_CURSOR1
  

FETCH NEXT FROM CUERPO_CURSOR1
INTO @Receta_Id, @Renglon
set @Nivel =   @Nivel+1

WHILE @@FETCH_STATUS = 0  
BEGIN  

	exec inf_proCadenaProduccionAux @Receta_id, '##TempCadena', @Nivel

	FETCH NEXT FROM CUERPO_CURSOR1
	INTO @Receta_Id, @Renglon
END
CLOSE CUERPO_CURSOR1;  
DEALLOCATE CUERPO_CURSOR1;  

go


DROP PROCEDURE inf_proCadenaProduccion
GO
CREATE PROCEDURE inf_proCadenaProduccion
(
	@Producto_id VarChar(25)
)

AS

select proRecetas.Receta_Id, proRecetas.Descripcion, 
	proCentroProductivo.CtroProd_Id,  proCentroProductivo.Descripcion as DescripcionCentro, 
	1 AS Nivel
INTO ##TempCadena
From proRecetas INNER JOIN proProductosReceta ON
proProductosReceta.Receta_Id =  proRecetas.proRecetas 
inner join stkProductos ON
stkProductos.stkProductos = proProductosReceta.Producto_Id and 
proProductosReceta.Principal = 1
INNER JOIN proCentroProductivo ON
proCentroProductivo.proCentroProductivo = proRecetas.CtroProd_Id
Where
	stkProductos.Producto_Id = @Producto_Id
	
DECLARE @Receta_Id int
DECLARE @Renglon INT
set @Receta_Id = (select max(proProductosReceta.Receta_Id) from 
	proProductosReceta inner join stkProductos ON 
	stkProductos.stkProductos = proProductosReceta.Producto_Id and 
	proProductosReceta.Principal = 1
	Where 
	stkProductos.Producto_Id = @Producto_Id	)



DECLARE CUERPO_CURSOR CURSOR FOR
SELECT  proProductosReceta.Receta_id, proRecetasProd.Renglon
from proProductosReceta 
inner join proRecetasProd ON 
	proRecetasProd.Producto_Id = proProductosReceta.Producto_Id  and 
	proRecetasProd.EntradaSalida = 'C' and 
	proProductosReceta.Principal = 1
Where
	proRecetasProd.Receta_Id = @Receta_Id
order by 2

OPEN CUERPO_CURSOR 
  

FETCH NEXT FROM CUERPO_CURSOR
INTO @Receta_Id, @Renglon
  
WHILE @@FETCH_STATUS = 0  
BEGIN  

	exec inf_proCadenaProduccionAux @Receta_id, '##TempCadena', 2

	FETCH NEXT FROM CUERPO_CURSOR
	INTO @Receta_Id, @Renglon
END
CLOSE CUERPO_CURSOR;  
DEALLOCATE CUERPO_CURSOR;  
SELECT * FROM ##TempCadena
DROP TABLE ##TempCadena
go

