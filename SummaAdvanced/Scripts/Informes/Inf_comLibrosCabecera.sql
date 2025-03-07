drop PROCEDURE Inf_comLibrosCabecera
go
CREATE PROCEDURE Inf_comLibrosCabecera (
@Libro_Id VarChar(5), 
@FechaDesde DateTime, 
@FechaHasta DateTime,
@Empresa_Id Int,
@SoloCompras bit, 
@SoloPendientes bit,
@AgrupaCF bit
)
as

SELECT ISNULL((SELECT Titulo from comLibrosColumnas where Columna = 1 and 
			comLibros = dbo.FuncFKcomLIbros(@Libro_id)), ' ') as Columna01, 
			ISNULL((SELECT Titulo from comLibrosColumnas where Columna = 2 and 
			comLibros = dbo.FuncFKcomLIbros(@Libro_id)), ' ') as Columna02, 
			ISNULL((SELECT Titulo from comLibrosColumnas where Columna = 3 and 
			comLibros = dbo.FuncFKcomLIbros(@Libro_id)), ' ') as Columna03, 
			ISNULL((SELECT Titulo from comLibrosColumnas where Columna = 4 and 
			comLibros = dbo.FuncFKcomLIbros(@Libro_id)), ' ') as Columna04, 
			ISNULL((SELECT Titulo from comLibrosColumnas where Columna = 5 and 
			comLibros = dbo.FuncFKcomLIbros(@Libro_id)), ' ') as Columna05,
			ISNULL((SELECT Titulo from comLibrosColumnas where Columna = 6 and 
			comLibros = dbo.FuncFKcomLIbros(@Libro_id)), ' ') as Columna06,
			ISNULL((SELECT Titulo from comLibrosColumnas where Columna = 7 and 
			comLibros = dbo.FuncFKcomLIbros(@Libro_id)), ' ') as Columna07,
			ISNULL((SELECT Titulo from comLibrosColumnas where Columna = 8 and 
			comLibros = dbo.FuncFKcomLIbros(@Libro_id)), ' ') as Columna08,
			ISNULL((SELECT Titulo from comLibrosColumnas where Columna = 9 and 
			comLibros = dbo.FuncFKcomLIbros(@Libro_id)), ' ') as Columna09,
			ISNULL((SELECT Titulo from comLibrosColumnas where Columna = 10 and 
			comLibros = dbo.FuncFKcomLIbros(@Libro_id)), ' ') as Columna10,
			ISNULL((SELECT Titulo from comLibrosColumnas where Columna = 11 and 
			comLibros = dbo.FuncFKcomLIbros(@Libro_id)), ' ') as Columna11,
			ISNULL((SELECT Titulo from comLibrosColumnas where Columna = 12 and 
			comLibros = dbo.FuncFKcomLIbros(@Libro_id)), ' ') as Columna12,
			(select COUNT(1) from comLibrosColumnas where comLibros = dbo.FuncFKcomLIbros(@Libro_id)) as NumeroColumnas

GO

