--select * from venLibrosColumnas
-- inf_venLibrosCabecera 'LIVAV','20220401','20220430','','ZZZZ',1,0

drop PROCEDURE Inf_venLibrosCabecera
go
CREATE PROCEDURE Inf_venLibrosCabecera (
@Libro_Id VarChar(5), 
@FechaDesde DateTime, 
@FechaHasta DateTime,
@SucursalDesde VarChar(4),
@SucursalHasta VarChar(4),
@Empresa_Id Int,
@SoloPendientes bit,
@AgrupaCF INT
)
as

SELECT ISNULL((SELECT Titulo from venLibrosColumnas where Columna = 1 and 
			venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ')  as Columna01, 
			ISNULL((SELECT Titulo from venLibrosColumnas where Columna = 2 and 
			venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ') as Columna02, 
			ISNULL((SELECT Titulo from venLibrosColumnas where Columna = 3 and 
			venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ') as Columna03, 
			ISNULL((SELECT Titulo from venLibrosColumnas where Columna = 4 and 
			venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ') as Columna04, 
			ISNULL((SELECT Titulo from venLibrosColumnas where Columna = 5 and 
			venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ') as Columna05,			 
			ISNULL((SELECT Titulo from venLibrosColumnas where Columna = 6 and 
			venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ') as Columna06, 
			ISNULL((SELECT Titulo from venLibrosColumnas where Columna = 7 and 
			venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ') as Columna07, 
			ISNULL((SELECT Titulo from venLibrosColumnas where Columna = 8 and 
			venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ') as Columna08, 
			ISNULL((SELECT Titulo from venLibrosColumnas where Columna = 9 and 
			venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ') as Columna09, 
			ISNULL((SELECT Titulo from venLibrosColumnas where Columna = 10 and 
			venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ') as Columna10, 
			ISNULL((SELECT Titulo from venLibrosColumnas where Columna = 11 and 
			venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ') as Columna11, 
			ISNULL((SELECT Titulo from venLibrosColumnas where Columna = 12 and 
			venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ') as Columna12
			go