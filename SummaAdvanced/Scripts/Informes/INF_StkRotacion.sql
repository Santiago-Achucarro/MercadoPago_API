-- INF_StkRotacion '20170701','20170831', ' ','ZZZ', ' ','ZZZ', 1,' ','ZZZ',' ','ZZZ',1

DROP PROCEDURE INF_StkRotacion 
GO
CREATE PROCEDURE INF_StkRotacion (
@FechaDesde DateTime,
@FechaHasta DateTime,
@ProductoDesde VarChar(25),
@ProductoHasta VarChar(25),
@DepositoDesde VarChar(5),
@DepositoHasta VarChar(5),
@Empresa Int,
@FamiliaDesde varchar(15),
@FamiliaHasta varchar(15),
@GrupoDesde varchar(15),
@GrupoHasta varchar(15),
@SoloEnExistencia bit
)

AS

CREATE TABLE #Rotacion (
	Producto_Id VarChar(25), 
	Descripcion VarChar(80),
	Rotacion Numeric(18,4),
	Periodos Int, 
	SumaExistencias Numeric(18,4),
	Salidas Numeric(18,4),
	Primary Key(Producto_Id))

DECLARE @Producto_Id VarChar(25)
DECLARE @Descripcion VarChar(80)
DECLARE @stkProductos Int	
DECLARE @Fecha DateTime
DECLARE @Periodos int
DECLARE @ExistenciaFinal NUMERIC(18,4)
DECLARE @Salidas NUMERIC(18,4)



	DECLARE curProductos CURSOR  FOR Select stkProductos.Producto_id, stkProductos.Descripcion , stkProductos
		from stkProductos
		left join stkFamilias on stkProductos.Familia_Id= stkFamilias.stkFamilias
		left join stkGrupos on stkProductos.Grupo_Id=stkGrupos.stkGrupos
	--	left join Existencia on stkProductos.stkProductos=Existencia.Producto_Id 
	Where 

	stkProductos.Producto_id between @ProductoDesde and @ProductoHasta AND 
	isnull(stkFamilias.Familia_Id,'') between @FamiliaDesde and @FamiliaHasta and
	isnull(stkGrupos.Grupo_Id,'') between @GrupoDesde and @GrupoHasta and
	ISNULL(stkProductos.Empresa_Id,@Empresa) = @Empresa and 
	--( @SoloEnExistencia =0 or Exists(select 1 from stkExistencia where	
	--	stkExistencia.Producto_Id = stkProductos.stkProductos and 
	--	stkExistencia.Cantidad > 0)) 
	--	and
	Clase IN ('E','-')


OPEN curProductos

FETCH NEXT FROM curProductos INTO @Producto_id, @Descripcion, @stkProductos;  

WHILE @@FETCH_STATUS=0
BEGIN
	SET @Fecha= @FechaDesde
	SET @Periodos = 0
	
	SET @ExistenciaFinal=0
	WHILE @Fecha <= @FechaHasta
	BEGIN

		SET @Periodos = @Periodos +1
		set @ExistenciaFinal = @ExistenciaFinal+ ISNULL((
			SELECT SUM(stkMoviCuerpo.Cantidad*stkMoviCabe.Signo) as Cantidad
			FROM stkMoviCabe INNER JOIN stkMoviCuerpo ON 
			stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe 
			INNER JOIN conAsientos ON
			conAsientos.conAsientos = stkMoviCabe.stkMoviCabe 
			INNER JOIN stkDepositos ON
			stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
			WHERE
			conAsientos.Anulado = 0 and 
			stkMoviCuerpo.Producto_Id = @stkProductos and 
			conAsientos.Fecha <= @Fecha and 
			conAsientos.Empresa_Id = @Empresa and 
			stkDepositos.Deposito_Id BETWEEN @DepositoDesde and @DepositoHasta),0)

			SET @Fecha = DATEADD(month,1,@Fecha)
       END

	    
		set @Salidas = ISNULL((
			SELECT SUM(stkMoviCuerpo.Cantidad) as Cantidad
			FROM stkMoviCabe INNER JOIN stkMoviCuerpo ON 
			stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe 
			INNER JOIN conAsientos ON
			conAsientos.conAsientos = stkMoviCabe.stkMoviCabe 
			INNER JOIN stkDepositos ON
			stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
			INNER JOIN stkSubTipoMov ON
			stkSubTipoMov.SubTipomov_id = stkMoviCabe.SubTipoMov_id
			WHERE
			conAsientos.Anulado = 0 and 
			stkSubTipoMov.Consumo = 1 and
			stkMoviCabe.Signo = -1 and 
			stkMoviCuerpo.Producto_Id = @stkProductos and 
			conAsientos.Fecha <= @Fecha and 
			conAsientos.Empresa_Id = @Empresa and 
			stkDepositos.Deposito_Id BETWEEN @DepositoDesde and @DepositoHasta),0)


		INSERT INTO #Rotacion (Producto_Id,Descripcion, Rotacion, Periodos,SumaExistencias , Salidas) 
			Values(@Producto_id,  @Descripcion, case when @ExistenciaFinal=0 then 0 else
				@Salidas / (@ExistenciaFinal/@Periodos) end , @Periodos, @ExistenciaFinal, @Salidas)

		FETCH NEXT FROM curProductos INTO @Producto_id, @Descripcion, @stkProductos;  

END

close curProductos
deallocate curProductos

SELECT * FROM #Rotacion where (@SoloEnExistencia =0 or SumaExistencias!=0) ORDER BY Producto_Id 
DROP TABLE #Rotacion

GO



