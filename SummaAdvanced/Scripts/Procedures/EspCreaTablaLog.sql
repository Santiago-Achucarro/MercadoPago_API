--EspCreaTablaLog 'conasientos'
DROP PROCEDURE EspCreaTablaLog 
GO
CREATE PROCEDURE EspCreaTablaLog (@Tabla VarChar(100))
as

Declare @Id as Int
Declare @Name as VarChar(100)
Declare @Sql VarChar(max)
Declare @ColOrden int
Declare @Texto VarChar(max)

SELECT @Id = id ,@Name = Name FROM sysobjects 
	where type = 'U' AND name = @Tabla

SET @Sql = 'Create Table '+@Name+'_Log ('+char(13)



DECLARE CUR_CUERPO CURSOR FOR
select c.colorder, 
c.name +' '+ t.name + 
CASE WHEN t.name='char' THEN 
 '('+ ltrim(STR(c.length,4)) +')' 
 WHEN t.name='numeric' THEN 
 '('+ ltrim(STR(c.prec,4)) +',' + ltrim(STR(c.scale,4)) +')' 
 ELSE '' END  +
 CASE WHEN c.isnullable = 0 then ' NOT NULL ' ELSE '' END AS Texto
 -- c.prec, c.scale, t.uid
 from syscolumns c  inner join systypes t on 
	t.xusertype = c.xusertype
where  c.id = @Id
order by 1

OPEN CUR_CUERPO

FETCH NEXT FROM CUR_CUERPO INTO @ColOrden, @Texto
WHILE @@FETCH_STATUS= 0
BEGIN
	SET @SQL = @SQL + @Texto+',' +CHAR(13)
	FETCH NEXT FROM CUR_CUERPO INTO @ColOrden, @Texto
END
CLOSE CUR_CUERPO;
DEALLOCATE CUR_CUERPO;  
SET @SQL = @SQL + ' Operacion Char(1) NOT NULL, '+CHAR(13)+
				  ' FechaLog Datetime default dbo.FechaActual() NOT NULL)'+CHAR(13)+'GO'+CHAR(13)
SELECT @SQL
GO

