
drop PROCEDURE Inf_venLibros0
go
CREATE PROCEDURE Inf_venLibros0 (
@Libro_Id VarChar(5), 
@FechaDesde DateTime, 
@FechaHasta DateTime,
@SucursalDesde VarChar(4),
@SucursalHasta VarChar(4),
@Empresa Int, 
@SoloPendientes bit,
@AgrupaCF int
)
as

DECLARE @Sql1 NVarchar(max)
Declare @lColumna1 varchar(20), @lColumna2 varchar(20), @lColumna3 varchar(20), @lColumna4 varchar(20), @lColumna5 varchar(20), @lColumna6 varchar(20), 
	@lColumna7 varchar(20), @lColumna8 varchar(20), @lColumna9 varchar(20), @lColumna10 varchar(20), @lColumna11 varchar(20), @lColumna12 varchar(20)

Set @lColumna1 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From venLibrosColumnas where Columna = 1 And venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ')
Set @lColumna2 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From venLibrosColumnas where Columna = 2 And venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ')
Set @lColumna3 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From venLibrosColumnas where Columna = 3 And venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ')
Set @lColumna4 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From venLibrosColumnas where Columna = 4 And venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ')
Set @lColumna5 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From venLibrosColumnas where Columna = 5 And venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ')
Set @lColumna6 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From venLibrosColumnas where Columna = 6 And venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ')
Set @lColumna7 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From venLibrosColumnas where Columna = 7 And venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ')
Set @lColumna8 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From venLibrosColumnas where Columna = 8 And venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ')
Set @lColumna9 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From venLibrosColumnas where Columna = 9 And venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ')
Set @lColumna10 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From venLibrosColumnas where Columna = 10 And venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ')
Set @lColumna11 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From venLibrosColumnas where Columna = 11 And venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ')
Set @lColumna12 = IsNull((SELECT dbo.Func_EliminaCaracteres(Titulo) From venLibrosColumnas where Columna = 12 And venLibros = dbo.FuncFKvenLIbros(@Libro_id)), ' ')

--Select * From venLibrosColumnas

CREATE TABLE #TempTable (
		
        Fecha datetime,
        SegmentoStr VARCHAR(30),
		TipoMovResumido char(30),
		DescTipoMov varchar(50),
		Cliente_Id varchar(15),
		ClaveFiscal varchar(36),
		Cuit varchar(25),
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
		venMovimientos bigint,
		Provincia_Id varchar(5),
		DescripcionProvincia varchar(35),
		ProvEntrega_Id varchar(5),
		DescripcionProvEntrega varchar(35),
		NMetodoPago varchar(3),
		Revertida int,
		CondFisc_Id varchar(5),
		DescripcionCondFiscal varchar(35),
		Grupo varchar(10),
		DescripcionGrupo varchar(50)
		)
/*
Set @Sql1 = 'Alter table #TempTable Add Columna01 numeric(19,2)'
EXEC sp_executesql @SQL1
Set @Sql1 = 'Alter table #TempTable Add Columna02 numeric(19,2)'
EXEC sp_executesql @SQL1
Set @Sql1 = 'Alter table #TempTable Add Columna03 numeric(19,2)'
EXEC sp_executesql @SQL1
Set @Sql1 = 'Alter table #TempTable Add Columna04 numeric(19,2)'
EXEC sp_executesql @SQL1
Set @Sql1 = 'Alter table #TempTable Add Columna05 numeric(19,2)'
EXEC sp_executesql @SQL1
Set @Sql1 = 'Alter table #TempTable Add Columna06 numeric(19,2)'
EXEC sp_executesql @SQL1
Set @Sql1 = 'Alter table #TempTable Add Columna07 numeric(19,2)'
EXEC sp_executesql @SQL1
Set @Sql1 = 'Alter table #TempTable Add Columna08 numeric(19,2)'
EXEC sp_executesql @SQL1
Set @Sql1 = 'Alter table #TempTable Add Columna09 numeric(19,2)'
EXEC sp_executesql @SQL1
Set @Sql1 = 'Alter table #TempTable Add Columna10 numeric(19,2)'
EXEC sp_executesql @SQL1
Set @Sql1 = 'Alter table #TempTable Add Columna11 numeric(19,2)'
EXEC sp_executesql @SQL1
Set @Sql1 = 'Alter table #TempTable Add Columna12 numeric(19,2)'
EXEC sp_executesql @SQL1

Alter table #TempTable Add 
		venMovimientos bigint,
		Provincia_Id varchar(5),
		DescripcionProvincia varchar(35),
		ProvEntrega_Id varchar(5),
		DescripcionProvEntrega varchar(35),
		NMetodoPago varchar(3),
		Revertida int,
		CondFisc_Id varchar(5),
		DescripcionCondFiscal varchar(35),
		Grupo varchar(10),
		DescripcionGrupo varchar(50)
*/

--print 'antes'
INSERT INTO #TempTable EXEC Inf_venLibros @Libro_Id, @FechaDesde, @FechaHasta, @SucursalDesde, @SucursalHasta, @Empresa, @SoloPendientes, @AgrupaCF
--print 'despúes'

Set @Sql1 = 'Select venMovimientos, Fecha, Cliente_Id, SegmentoStr, TipoMovResumido, ClaveFiscal, Cuit, RazonSocial, Provincia_Id, DescripcionProvincia, ' +
		'ProvEntrega_Id, DescripcionProvEntrega, NMetodoPago, Revertida, CondFisc_Id, DescripcionCondFiscal, Columna01 ' + @lColumna1 + ', Columna02 ' + @lColumna2 + 
		', Columna03 ' + @lColumna3 + ', Columna04 ' + @lColumna4 + ', Columna05 ' + @lColumna5 + ', Columna06 ' + @lColumna6 + ', Columna07 ' + @lColumna7 + 
		', Columna08 ' + @lColumna8 + ', Columna09 ' + @lColumna9 + ', Columna10 ' + @lColumna10 + ', Columna11 ' + @lColumna11 + ', Columna12 ' + @lColumna12  +
		' From #TempTable '

--Set @Sql1 = 'Select *, Columna05 Iva From #TempTable'
EXEC sp_executesql @SQL1

--Set @Sql1 = 'Alter table #TempTable Drop Column Columna05'
--EXEC sp_executesql @SQL1

Drop table #TempTable

/*


IF @SoloPendientes = 0
BEGIN



SELECT XXX.Fecha, XXX.SegmentoStr, XXX.TipoMovResumido, XXX.Cliente_Id , XXX.ClaveFiscal, XXX.Cuit, 
XXX.RazonSocial, SUM(XXX.Columna01*xxx.Signo) as Columna01,
	SUM(XXX.Columna02*xxx.Signo) as Columna02, SUM(XXX.Columna03*xxx.Signo) as Columna03,
		SUM(XXX.Columna04*xxx.Signo) as Columna04, SUM(XXX.Columna05*xxx.Signo) as Columna05, 
		 SUM(XXX.Columna06*xxx.Signo) as Columna06,  SUM(XXX.Columna07*xxx.Signo) as Columna07, 
		  SUM(XXX.Columna08*xxx.Signo) as Columna08,  SUM(XXX.Columna09*xxx.Signo) as Columna09, 
		   SUM(XXX.Columna10*xxx.Signo) as Columna10,  SUM(XXX.Columna11*xxx.Signo) as Columna11, 
		    SUM(XXX.Columna12*xxx.Signo) as Columna12, 
				xxx.venMovimientos, xxx.Provincia_Id, xxx.DescripcionProvincia, xxx.ProvEntrega_Id, xxx.DescripcionProvEntrega,
				ISNULL(XXX.NMetodoPago ,'') MetodoPago, 
				XXX.Revertida, XXX.CondFisc_Id, XXX.DescripcionCondFiscal

FROM (


SELECT venMovimientos.venMovimientos, conAsientos.Fecha, 
	Venclientes.Cliente_Id,
	dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N) as SegmentoStr,
	venTipoMov.TipoMovResumido, conAsientos.Cambio, venTipoMov.Signo,
	ISNULL(venMovimientosFiscal.ClaveFiscal, ' ') as ClaveFiscal, 
	genEntidades.Cuit, case when conASientos.Anulado=0 then  venClientes.RazonSocial else 'Anulado' end RazonSocial, 
	Case when venLibrosImpuestos.Columna = 1 and conASientos.Anulado=0 then
	case  venLibrosImpuestos.TipoRenglon 
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end 
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end  AS Columna01,
		Case when venLibrosImpuestos.Columna = 2 and conASientos.Anulado=0 then
		case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end  AS Columna02,
		
		Case when venLibrosImpuestos.Columna = 3 and conASientos.Anulado=0 then
		case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end 
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end AS Columna03,
		
		Case when venLibrosImpuestos.Columna = 4 and conASientos.Anulado=0 then
		case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end 
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end AS Columna04,
		
		Case when venLibrosImpuestos.Columna = 5 and conASientos.Anulado=0 then
		case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end 
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end AS Columna05,

				Case when venLibrosImpuestos.Columna = 6 and conASientos.Anulado=0 then
		case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end 
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end AS Columna06,

		Case when venLibrosImpuestos.Columna = 7 and conASientos.Anulado=0 then
		case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end 
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end AS Columna07,

		Case when venLibrosImpuestos.Columna = 8 and conASientos.Anulado=0 then
		case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end 
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end AS Columna08,

				Case when venLibrosImpuestos.Columna = 9 and conASientos.Anulado=0 then
		case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end 
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end AS Columna09,

				Case when venLibrosImpuestos.Columna = 10 and conASientos.Anulado=0 then
		case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end 
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end AS Columna10,

				Case when venLibrosImpuestos.Columna = 11 and conASientos.Anulado=0 then
		case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end 
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end AS Columna11,

				Case when venLibrosImpuestos.Columna = 12 and conASientos.Anulado=0 then
		case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end 
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end  AS Columna12,
		genProvincias.Provincia_Id, genProvincias.Descripcion DescripcionProvincia, 
		genProvEntrega.Provincia_Id ProvEntrega_Id, genProvEntrega.Descripcion DescripcionProvEntrega,
		venMovimientosMetodoPago.NMetodoPago , 
		CASE WHEN Exists(select 1 from genAsiSegmentos  genAsiSegmentosr
			WHERE
				genAsiSegmentosr.Segmento_id = genAsiSegmentos.Segmento_Id and 
				genAsiSegmentosr.Segmento1N = genAsiSegmentos.Segmento1N and 
				genAsiSegmentosr.Segmento2N = genAsiSegmentos.Segmento2N and 
				genAsiSegmentosr.Segmento3N = genAsiSegmentos.Segmento3N and 
				genAsiSegmentosr.Segmento4N = genAsiSegmentos.Segmento4N and 
				CASE genAsiSegmentosr.Segmento1C WHEN 'V' THEN 'F' 
				WHEN 'W' THEN 'R' ELSE ' ' END 	= genAsiSegmentos.Segmento1C and 
				genAsiSegmentosr.Segmento2C = genAsiSegmentos.Segmento2C and 
				genAsiSegmentosr.Segmento3C = genAsiSegmentos.Segmento3C and 
				genAsiSegmentosr.Segmento4C = genAsiSegmentos.Segmento4C and 
				genAsiSegmentosr.Empresa_Id = genAsiSegmentos.Empresa_Id) THEN 1 ELSE 0 END AS Revertida,
		venCondFiscal.CondFisc_Id, venCondFiscal.Descripcion DescripcionCondFiscal
		

FROM venMovimientos 
INNER JOIN conAsientos ON venMovimientos.venMovimientos = conAsientos.conAsientos
	INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
	LEFT JOIN venMovimientosFiscal ON venMovimientosFiscal.venMovimientos = venMovimientos.venMovimientos
	INNER JOIN genEntidades ON genEntidades.genEntidades = venMovimientos.Cliente_Id
	INNER JOIN venClientes ON venClientes.genEntidades = genEntidades.genEntidades
	INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id 
	INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
	inner join genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
	CROSS JOIN (venLibrosImpuestos Inner Join venLibros On venLibros.venLibros = venLibrosImpuestos.venLibros)
	Inner Join venClieHabitual On venClieHabitual.genEntidades = venMovimientos.Cliente_Id And venClieHabitual.Sucursal = venMovimientos.Sucursal
	Inner Join genProvincias On genProvincias.genProvincias = venClieHabitual.Provincia_Id_Fact
	Inner Join genProvincias genProvEntrega On genProvEntrega.genProvincias = venClieHabitual.Provincia_Id_Entr
	LEFT JOIN venMovimientosMetodoPago ON venMovimientosMetodoPago.venMovimientos  = venMovimientos.venMovimientos 
	CROSS JOIN geninstalacion
	Inner Join venCondFiscal On venCondFiscal.venCondFiscal = venMovimientos.CondFisc_Id
WHERE 
conAsientos.Posteado = 1 and
conAsientos.Anulado = 0 And 
(geninstalacion.Dominio_Id != 'MX' OR venMovimientosFiscal.ClaveFiscal IS NOT NULL OR venMovimientos.venTipoMov IN('V','W')) AND 
conAsientos.Fecha between @FechaDesde and @FechaHasta and  
genSucursalesEmpr.Sucursal between @SucursalDesde And @SucursalHasta and 
conAsientos.Empresa_Id = @Empresa and
isnull(venLibros.Empresa_Id,@Empresa) = @Empresa And venLibros.Libro_Id = @Libro_Id And
venTipoMov.venTipoMov in ('F','R','D', 'I', 'B', 'E','V','W')) AS XXX
group by XXX.Fecha, XXX.SegmentoStr, XXX.ClaveFiscal, XXX.Cuit, XXX.Cliente_Id,
XXX.RazonSocial, xxx.venMovimientos, XXX.TipoMovResumido, xxx.venMovimientos, xxx.Provincia_Id, xxx.DescripcionProvincia, 
XXX.ProvEntrega_Id, XXX.DescripcionProvEntrega,
XXX.NMetodoPago, XXX.Revertida, XXX.CondFisc_Id, XXX.DescripcionCondFiscal
ORDER BY 1,2
END
ELSE
BEGIN

SELECT XXX.Fecha, XXX.SegmentoStr, XXX.TipoMovResumido, XXX.ClaveFiscal, XXX.Cliente_Id, XXX.Cuit, 
XXX.RazonSocial, SUM(XXX.Columna01*xxx.Signo) as Columna01,
	SUM(XXX.Columna02*xxx.Signo) as Columna02, SUM(XXX.Columna03*xxx.Signo) as Columna03,
		SUM(XXX.Columna04*xxx.Signo) as Columna04, SUM(XXX.Columna05*xxx.Signo) as Columna05, 
		 SUM(XXX.Columna06*xxx.Signo) as Columna06,  SUM(XXX.Columna07*xxx.Signo) as Columna07, 
		  SUM(XXX.Columna08*xxx.Signo) as Columna08,  SUM(XXX.Columna09*xxx.Signo) as Columna09, 
		   SUM(XXX.Columna10*xxx.Signo) as Columna10,  SUM(XXX.Columna11*xxx.Signo) as Columna11, 
		    SUM(XXX.Columna12*xxx.Signo) as Columna12, 
				xxx.venMovimientos, xxx.Provincia_Id, xxx.DescripcionProvincia, xxx.ProvEntrega_Id, xxx.DescripcionProvEntrega,
				ISNULL(XXX.NMetodoPago ,'') MetodoPago,
					XXX.Revertida, XXX.CondFisc_Id, XXX.DescripcionCondFiscal

FROM (


SELECT venMovimientos.venMovimientos, conAsientos.Fecha, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C,genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N) as SegmentoStr,
	venTipoMov.TipoMovResumido, conAsientos.Cambio, venTipoMov.Signo, venclientes.Cliente_Id,
	ISNULL(venMovimientosFiscal.ClaveFiscal, ' ') as ClaveFiscal, 
	genEntidades.Cuit, case when conASientos.Anulado=0 then  venClientes.RazonSocial else 'Anulado' end RazonSocial, 
	Case when venLibrosImpuestos.Columna = 1 and conASientos.Anulado=0 then
	case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end 
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end  AS Columna01,
		Case when venLibrosImpuestos.Columna = 2 and conASientos.Anulado=0 then
		case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end  AS Columna02,
		
		Case when venLibrosImpuestos.Columna = 3 and conASientos.Anulado=0 then
		case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end 
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end AS Columna03,
		
		Case when venLibrosImpuestos.Columna = 4 and conASientos.Anulado=0 then
		case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end 
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end AS Columna04,
		
		Case when venLibrosImpuestos.Columna = 5 and conASientos.Anulado=0 then
		case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end 
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end AS Columna05,

				Case when venLibrosImpuestos.Columna = 6 and conASientos.Anulado=0 then
		case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end 
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end AS Columna06,

		Case when venLibrosImpuestos.Columna = 7 and conASientos.Anulado=0 then
		case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end 
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end AS Columna07,

		Case when venLibrosImpuestos.Columna = 8 and conASientos.Anulado=0 then
		case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end 
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end AS Columna08,

				Case when venLibrosImpuestos.Columna = 9 and conASientos.Anulado=0 then
		case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 

		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end 
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end AS Columna09,

				Case when venLibrosImpuestos.Columna = 10 and conASientos.Anulado=0 then
		case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 

		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end 
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end AS Columna10,

				Case when venLibrosImpuestos.Columna = 11 and conASientos.Anulado=0 then
		case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 

		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end 
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end AS Columna11,

				Case when venLibrosImpuestos.Columna = 12 and conASientos.Anulado=0 then
		case  venLibrosImpuestos.TipoRenglon
		WHEN 'TO' THEN
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')
		WHEN 'IM' THEN 
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos
				Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And conMovCont.Renglon = venMovImpuestos.conRenglon
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 

		WHEN 'GR' THEN 		 
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos and 
				venMovimpuestos.Impuesto_Id = venLibrosImpuestos.Impuesto_Id),0) 
		WHEN 'EX' THEN 		 
			(Select Sum(Importe) Importe From conMovCont Where conMovCont.conAsientos = venMovimientos.venMovimientos And conMovCont.Clase = 'CLI')  -
			ISNULL((SELECT SUM(BaseImponibleMonedaNac) FROM venMovimpuestos
				Inner Join venImpuestos On venImpuestos.venImpuestos = venMovImpuestos.Impuesto_Id
				Inner Join impTipoImpuesto On impTipoImpuesto.TipoImpuesto = venImpuestos.TipoImpuesto
				where
				venMovimpuestos.venMovimientos = venMovimientos.venMovimientos And impTipoImpuesto.Referencia01 = 'IVA'),0) -
			ISNULL((SELECT SUM(conMovCont.Importe) FROM venMovimpuestos 
			Inner Join conMovCont On conMovCont.conAsientos = venMovImpuestos.venMovimientos And
						conMovCont.Renglon = venMovImpuestos.conRenglon And conMovCont.conAsientos = venMovimientos.venMovimientos),0) 
		else 0 END else 0 end 
		* case when @SoloPendientes = 1 then venMovimientos.Saldo / venMovimientos.Importe else 1 end  AS Columna12,
		genProvincias.Provincia_Id, genProvincias.Descripcion DescripcionProvincia,
		genProvEntrega.Provincia_Id ProvEntrega_Id, genProvEntrega.Descripcion DescripcionProvEntrega,
			venMovimientosMetodoPago.NMetodoPago, 
					CASE WHEN Exists(select 1 from genAsiSegmentos  genAsiSegmentosr
			WHERE
				genAsiSegmentosr.Segmento_id = genAsiSegmentos.Segmento_Id and 
				genAsiSegmentosr.Segmento1N = genAsiSegmentos.Segmento1N and 
				genAsiSegmentosr.Segmento2N = genAsiSegmentos.Segmento2N and 
				genAsiSegmentosr.Segmento3N = genAsiSegmentos.Segmento3N and 
				genAsiSegmentosr.Segmento4N = genAsiSegmentos.Segmento4N and 
				CASE genAsiSegmentosr.Segmento1C WHEN 'V' THEN 'F' 
				WHEN 'W' THEN 'R' ELSE ' ' END 	= genAsiSegmentos.Segmento1C and 
				genAsiSegmentosr.Segmento2C = genAsiSegmentos.Segmento2C and 
				genAsiSegmentosr.Segmento3C = genAsiSegmentos.Segmento3C and 
				genAsiSegmentosr.Segmento4C = genAsiSegmentos.Segmento4C and 
				genAsiSegmentosr.Empresa_Id = genAsiSegmentos.Empresa_Id) THEN 1 ELSE 0 END AS Revertida,
		venCondFiscal.CondFisc_Id, venCondFiscal.Descripcion DescripcionCondFiscal
FROM (SELECT venMovimientos.venMovimientos, venMovimientos.Cliente_Id, 
	venMovimientos.venSubTipoMov_Id, venmovimientos.Sucursal, venMovimientos.venTipoMov, 
	venMovimientos.Importe, venMovimientos.Saldo +
		ISNULL((SELECT sum(genCancMov.importe) from genCancMov , conAsientos
			Where
				conAsientos.conAsientos =genCancMov.Asiento_Id_Ap and
				conAsientos.Anulado = 0 and
				genCancMov.Asiento_Id = venMovimientos.venMovimientos and 
				genCancMov.FechaAplicacion > @FechaHasta),0) +
				ISNULL((SELECT sum(genCancMov.importe) from genCancMov , conAsientos
			Where
				conAsientos.conAsientos =genCancMov.Asiento_Id and
				conAsientos.Anulado = 0 and
				genCancMov.Asiento_Id_ap = venMovimientos.venMovimientos and 
				genCancMov.FechaAplicacion > @FechaHasta),0) as Saldo, CondFisc_Id
	From venMovimientos) AS venMovimientos 
INNER JOIN conAsientos ON venMovimientos.venMovimientos = conAsientos.conAsientos
	INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_id = conAsientos.conAsientos
	LEFT JOIN venMovimientosFiscal ON venMovimientosFiscal.venMovimientos = venMovimientos.venMovimientos
	INNER JOIN genEntidades ON genEntidades.genEntidades = venMovimientos.Cliente_Id
	INNER JOIN venClientes ON venClientes.genEntidades = genEntidades.genEntidades
	INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id 
	INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
	inner join genSucursalesEmpr ON genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
	CROSS JOIN (venLibrosImpuestos Inner Join venLibros On venLibros.venLibros = venLibrosImpuestos.venLibros)
	Inner Join venClieHabitual On venClieHabitual.genEntidades = venMovimientos.Cliente_Id And venClieHabitual.Sucursal = venMovimientos.Sucursal
	Inner Join genProvincias On genProvincias.genProvincias = venClieHabitual.Provincia_Id_Fact
	Inner Join genProvincias genProvEntrega On genProvEntrega.genProvincias = venClieHabitual.Provincia_Id_Entr
	LEFT JOIN venMovimientosMetodoPago ON venMovimientosMetodoPago.venMovimientos  = venMovimientos.venMovimientos 
	CROSS JOIN genInstalacion
	Inner Join venCondFiscal On venCondFiscal.venCondFiscal = venMovimientos.CondFisc_Id
WHERE 
(geninstalacion.Dominio_Id != 'MX' OR venMovimientosFiscal.ClaveFiscal IS NOT NULL OR venMovimientos.venTipoMov IN('V','W')) AND 
conAsientos.Fecha <= @FechaHasta and  
conAsientos.Anulado = 0 and 
conAsientos.Posteado = 1 and 
venMovimientos.Saldo > 0 and 
genSucursalesEmpr.Sucursal between @SucursalDesde And @SucursalHasta and 
conAsientos.Empresa_Id = @Empresa and
ISNULL(venLibros.Empresa_Id,@Empresa) = @Empresa And venLibros.Libro_Id = @Libro_Id And
venTipoMov.venTipoMov in ('F','R','D', 'I', 'B', 'E','V','W')) AS XXX
group by XXX.Fecha, XXX.SegmentoStr, XXX.ClaveFiscal, XXX.Cuit, XXX.Cliente_Id,
XXX.RazonSocial, xxx.venMovimientos, XXX.TipoMovResumido, xxx.venMovimientos, xxx.Provincia_Id, 
xxx.DescripcionProvincia, XXX.ProvEntrega_Id, XXX.DescripcionProvEntrega, xxx.NMetodoPago,XXX.Revertida, XXX.CondFisc_Id, XXX.DescripcionCondFiscal
ORDER BY 1,2

END
*/
GO


