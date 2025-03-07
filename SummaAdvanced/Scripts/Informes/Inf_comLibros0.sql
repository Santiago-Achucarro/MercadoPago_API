/* AJ NOV 18 AGREGUE SOLO COMPRAS */

-- Inf_comLibros 'IVACP', '20220801','20220801', 1, 1, 0,1
drop PROCEDURE Inf_comLibros0
go
CREATE PROCEDURE Inf_comLibros0
(
	@Libro_Id VarChar(5), 
	@FechaDesde DateTime, 
	@FechaHasta DateTime,
	@Empresa_Id Int, 
	@SoloCompras bit, 
	@SoloPendientes bit,
	@AgrupaCF bit
)
as

DECLARE @Sql1 NVarchar(max)
Declare @lColumna1 varchar(20), @lColumna2 varchar(20), @lColumna3 varchar(20), @lColumna4 varchar(20), @lColumna5 varchar(20), @lColumna6 varchar(20), 
	@lColumna7 varchar(20), @lColumna8 varchar(20), @lColumna9 varchar(20), @lColumna10 varchar(20), @lColumna11 varchar(20), @lColumna12 varchar(20)

Set @lColumna1 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From comLibrosColumnas where Columna = 1 And comLibros = dbo.FuncFKcomLibros(@Libro_id)), ' ')
Set @lColumna2 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From comLibrosColumnas where Columna = 2 And comLibros = dbo.FuncFKcomLibros(@Libro_id)), ' ')
Set @lColumna3 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From comLibrosColumnas where Columna = 3 And comLibros = dbo.FuncFKcomLibros(@Libro_id)), ' ')
Set @lColumna4 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From comLibrosColumnas where Columna = 4 And comLibros = dbo.FuncFKcomLibros(@Libro_id)), ' ')
Set @lColumna5 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From comLibrosColumnas where Columna = 5 And comLibros = dbo.FuncFKcomLibros(@Libro_id)), ' ')
Set @lColumna6 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From comLibrosColumnas where Columna = 6 And comLibros = dbo.FuncFKcomLibros(@Libro_id)), ' ')
Set @lColumna7 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From comLibrosColumnas where Columna = 7 And comLibros = dbo.FuncFKcomLibros(@Libro_id)), ' ')
Set @lColumna8 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From comLibrosColumnas where Columna = 8 And comLibros = dbo.FuncFKcomLibros(@Libro_id)), ' ')
Set @lColumna9 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From comLibrosColumnas where Columna = 9 And comLibros = dbo.FuncFKcomLibros(@Libro_id)), ' ')
Set @lColumna10 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From comLibrosColumnas where Columna = 10 And comLibros = dbo.FuncFKcomLibros(@Libro_id)), ' ')
Set @lColumna11 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From comLibrosColumnas where Columna = 11 And comLibros = dbo.FuncFKcomLibros(@Libro_id)), ' ')
Set @lColumna12 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From comLibrosColumnas where Columna = 12 And comLibros = dbo.FuncFKcomLibros(@Libro_id)), ' ')


CREATE TABLE #TempTable 
(
        Fecha datetime,
		FechaContable datetime,
        SegmentoStr VARCHAR(30),
		TipoMov char(1),
		ClaveFiscal varchar(36),
		Cuit varchar(25),
		comMovProv bigint,
		Origen_Id smallint,
		Descripcion varchar(70),
		RazonSocial varchar(120),
		Columna01 numeric(19,2),
		Columna02 numeric(19,2),
		Columna03 numeric(19,2),
		Columna04 numeric(19,2),
		Columna05 numeric(19,2),
		Columna06 numeric(19,2),
		Columna07 numeric(19,2),
		Columna08 numeric(19,2),
		Columna09 numeric(19,2),
		Columna10 numeric(19,2),
		Columna11 numeric(19,2),
		Columna12 numeric(19,2),
		CondFiscal_Id varchar(5),
		DescripcionCondFiscal varchar(35)
)

INSERT INTO #TempTable EXEC Inf_comLibros @Libro_Id, @FechaDesde, @FechaHasta, @Empresa_Id, @SoloCompras, @SoloPendientes, @AgrupaCF


Set @Sql1 = 'Select Fecha, FechaContable, SegmentoStr, TipoMov, ClaveFiscal, Cuit, comMovProv, Origen_Id, Descripcion, RazonSocial, Columna01 ' + @lColumna1 + ', Columna02 ' + @lColumna2 + 
		', Columna03 ' + @lColumna3 + ', Columna04 ' + @lColumna4 + ', Columna05 ' + @lColumna5 + ', Columna06 ' + @lColumna6 + ', Columna07 ' + @lColumna7 + 
		', Columna08 ' + @lColumna8 + ', Columna09 ' + @lColumna9 + ', Columna10 ' + @lColumna10 + ', Columna11 ' + @lColumna11 + ', Columna12 ' + @lColumna12  +
		', CondFiscal_Id, DescripcionCondFiscal From #TempTable '

--print @Sql1

EXEC sp_executesql @SQL1

Drop table #TempTable

GO


