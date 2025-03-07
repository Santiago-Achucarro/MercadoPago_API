-- EspCreaTablaLog 'conAsientoscon'
-- EspCreaTriggerLog 'conAsientosCon'

DROP PROCEDURE EspCreaTriggerLog
GO
CREATE PROCEDURE EspCreaTriggerLog(@Tabla VarChar(100))
as

Declare @Id as Int
Declare @Name as VarChar(100)
Declare @Campos VarChar(max)
Declare @Sqli VarChar(max)
Declare @Sqlu VarChar(max)
Declare @Sqld VarChar(max)
Declare @ColOrden int
Declare @Texto VarChar(max)
Declare @I int
SELECT @Id = id ,@Name = Name FROM sysobjects 
	where type = 'U' AND name = @Tabla

SET @Sqli = 'Create trigger til_'+@Name+' on '+@Name+' for Insert '+char(13)+'as '+char(13)+'begin'+char(13)
SET @Sqli = @Sqli + 'Insert into '+@Name+'_log ('

SET @Sqlu = 'Create trigger tul_'+@Name+' on '+@Name+' for Update '+char(13)+'as '+char(13)+'begin'+char(13)
SET @Sqlu = @Sqlu + 'Insert into '+@Name+'_log ('

SET @Sqld = 'Create trigger tdl_'+@Name+' on '+@Name+' for Delete '+char(13)+'as '+char(13)+'begin'+char(13)
SET @Sqld = @Sqld + 'Insert into '+@Name+'_log ('



DECLARE CUR_CUERPO CURSOR FOR
select c.colorder, c.name 
 -- c.prec, c.scale, t.uid
 from syscolumns c  inner join systypes t on 
	t.xusertype = c.xusertype
where  c.id = @Id
order by 1

OPEN CUR_CUERPO
SET @Campos= ''
SET @I = 1
FETCH NEXT FROM CUR_CUERPO INTO @ColOrden, @Texto
WHILE @@FETCH_STATUS= 0
BEGIN
	
	SET @Campos = @Campos + @Texto+',' 
	IF @I=5
	BEGIN
		SET @I=0
		SET @Campos = @Campos + CHAR(13)

	END
	SET @I=@I+1
	FETCH NEXT FROM CUR_CUERPO INTO @ColOrden, @Texto
END
CLOSE CUR_CUERPO;
DEALLOCATE CUR_CUERPO;  
SET @SQLi = @SQLi + @Campos +'Operacion )'+char(13)+
		' SELECT '+@Campos+'''I'' FROM Inserted '+char(13)+'End'+char(13)+'GO'

SET @SQLu = @SQLu + @Campos +'Operacion )'+char(13)+
		' SELECT '+@Campos+'''U'' FROM Inserted '+char(13)+'End'+char(13)+'GO'

SET @SQLd = @SQLd + @Campos +'Operacion )'+char(13)+
		' SELECT '+@Campos+'''D'' FROM deleted '+char(13)+'End'+char(13)+'GO'

SELECT @SQLi+char(13)+@SQLu+char(13)+@SQLd+char(13)
GO

