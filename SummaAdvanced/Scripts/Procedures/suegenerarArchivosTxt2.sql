drop PROCEDURE sueGenerarArchivosTxtDatos2
go


CREATE PROCEDURE sueGenerarArchivosTxtDatos2(

@pArchivo_Id varchar(15)
)

AS
SET NOCOUNT ON 
DECLARE @Fecha DATETIME

SET @Fecha = (SELECT GETDATE())



--encabezado
exec sueGenerarArchivosTxtDatos @pArchivo_Id
/*
SELECT 
sueArchivosTxt.Archivo_id, sueArchivosTxt.Descripcion,sueArchivosTxt.Inactivo,sueArchivosTxt.Posteado,@Fecha as FechaDesde,@Fecha as FechaHasta,'' as Segmento_Id,
0 AS Segmento1N,0 AS Segmento2N,0 AS Segmento3N,0 AS Segmento4N,
'' as Segmento1C,'' as Segmento2C,'' as Segmento3C,'' as Segmento4C,0 as
LegajoDesde,0 as LegajoHasta,' ' as SucursalDesde,'ZZZZ' as SucursalHasta,'S' as GenerarBy,'' as DescripcionGrupos,'' as Txt,'' as Grupo_id, '' as GrupoDescripcion
, 0 as Anio,0 as Mes,0 as Quincena,0 Semana,0 Decena,0 Vez
from sueArchivosTxt
	WHERE 
	@pArchivo_Id =sueArchivosTxt.Archivo_Id

*/

	--cuerpo

SELECT sueArchivosTxt.Archivo_Id,sueArchivosTxt.Descripcion as DescripcionCabecera,Columna,Formula,Tipo,Longitud,Decimales,Relleno,sueArchivosTxtCuerpo.Descripcion,Orden,Formato
From sueArchivosTxtCuerpo
inner join sueArchivosTxt on sueArchivosTxt.sueArchivosTxt=sueArchivosTxtCuerpo.sueArchivosTxt 
where
@pArchivo_Id =sueArchivosTxt.Archivo_Id

--resumenes
select Res1.Archivo_Id as Res1Archivo_Id,sueArchivosTxt.PosicionResumen1, Res2.Archivo_Id as Res2Archivo_Id ,sueArchivosTxt.PosicionResumen2

From sueArchivosTxt
left join sueArchivosTxt as Res1 on Res1.sueArchivosTxt=sueArchivosTxt.Resumen1
left join sueArchivosTxt as Res2 on Res2.sueArchivosTxt=sueArchivosTxt.Resumen2
where 
@pArchivo_Id =sueArchivosTxt.Archivo_Id

---formulas resumen1
SELECT Res1.Archivo_Id,Res1.Descripcion as DescripcionCabecera,Columna,Formula,Tipo,Longitud,Decimales,Relleno,sueArchivosTxtCuerpo.Descripcion,Orden,Formato
From sueArchivosTxtCuerpo
inner join sueArchivosTxt on sueArchivosTxt.sueArchivosTxt=sueArchivosTxtCuerpo.sueArchivosTxt 
inner join sueArchivosTxt as Res1 on Res1.sueArchivosTxt=sueArchivosTxt.Resumen1
where
@pArchivo_Id =sueArchivosTxt.Archivo_Id

---formulas resumen2
SELECT Res2.Archivo_Id,Res2.Descripcion as DescripcionCabecera,Columna,Formula,Tipo,Longitud,Decimales,Relleno,sueArchivosTxtCuerpo.Descripcion,Orden,Formato
From sueArchivosTxtCuerpo
inner join sueArchivosTxt on sueArchivosTxt.sueArchivosTxt=sueArchivosTxtCuerpo.sueArchivosTxt 
inner join sueArchivosTxt as Res2 on Res2.sueArchivosTxt=sueArchivosTxt.Resumen2
where
@pArchivo_Id =sueArchivosTxt.Archivo_Id

RETURN @@Error 
GO