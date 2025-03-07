
drop PROCEDURE sueGenerarArchivosTxtDatos
go


CREATE PROCEDURE sueGenerarArchivosTxtDatos(

@pArchivo_Id varchar(15)
)

AS
SET NOCOUNT ON 
DECLARE @Fecha DATETIME


SET @Fecha= (SELECT GETDATE())


SELECT 
sueArchivosTxt.Archivo_Id, sueArchivosTxt.Descripcion,sueArchivosTxt.Inactivo,sueArchivosTxt.Posteado,@Fecha as FechaDesde,@Fecha as FechaHasta,'' as Segmento_Id,
0 AS Segmento1N,0 AS Segmento2N,0 AS Segmento3N,0 AS Segmento4N,
'' as Segmento1C,'' as Segmento2C,'' as Segmento3C,'' as Segmento4C,0 as
LegajoDesde,99999999 as LegajoHasta,' ' as SucursalDesde,'ZZZZ' as SucursalHasta,'S' as GenerarBy,'' as DescripcionGrupos,'' as Txt,'' as Grupo_Id, '' as GrupoDescripcion
, 0 as Anio,0 as Mes,0 as Quincena,0 Semana,0 Decena,0 Vez,' ' as TipoPagoDesde ,'ZZZZZ' as TipoPagoHasta, '' Texto1, '' Texto2, '' Texto3,
GETDATE() Fecha1, GETDATE() Fecha2, GETDATE() Fecha3, 0 LegajoActual

From sueArchivosTxt

WHERE 
	@pArchivo_Id =sueArchivosTxt.Archivo_Id

RETURN @@Error 




GO
