drop procedure genAtributosValoresXLSGuardar
go
create procedure genAtributosValoresXLSGuardar
(
    @pClave_Id varchar(100),
    @pAtributoNro int,
    @pTabla_Id varchar(100),
    @pValorC varchar(255)=null,
    @pValorF varchar(10)=null,
    @pValorN int=null
)
as

declare @sp NVARCHAR(max)= 'if exists(select 1 from genAtributosValores 
where Tabla_Id='''+@pTabla_Id+''' and  Identity_Id = dbo.FuncFK'+@pTabla_Id+'('''+@pClave_Id+''') and AtributoNro='+
str(@pAtributoNro)+') 
begin 
update genAtributosValores set ValorC='''+isnull(@pValorC,'')+''', ValorF='+case when @pValorF is null then 'null'
 else +''''+ @pValorF+''' ' end+ ', ValorN='+isnull(str(@pValorN),'null')+' 
where Tabla_Id='''+@pTabla_Id+''' and Identity_Id= dbo.FuncFK'+@pTabla_Id+'('''+@pClave_Id+''') and AtributoNro='+
str(@pAtributoNro)+'
END 
ELSE 
begin 
insert into genAtributosValores (Identity_Id, AtributoNro, Tabla_Id, ValorC, ValorF, ValorN) values (
    dbo.FuncFK'+@pTabla_Id+'('''+
@pClave_Id+'''), '+str(@pAtributoNro)+', '''+@pTabla_Id+''', '''+isnull(@pValorC,'null')+''','+
case when @pValorF is null then 'null' else +''''+ @pValorF+''' 'end +','+isnull(str(@pValorN),'null')
+') 
end'

--print @sp
exec sp_executesql @sp
go

drop procedure genAtributosValoresXLSValidaClave
go
create procedure genAtributosValoresXLSValidaClave
(
    @pClave_Id varchar(100),
    @pAtributoNro int,
    @pTabla_Id varchar(100)
)
as

declare @sp NVARCHAR(max)= 'select 1 as Verificado from '+ @pTabla_Id+ ' where '+ @pTabla_Id+'.'+@pTabla_Id+ '=dbo.FuncFK'+@pTabla_Id+'('''+ @pClave_Id+''')'

exec sp_executesql @sp
select * from genAtributosGenerales where Tabla_Id=@pTabla_Id and AtributoNro=@pAtributoNro
go



drop  procedure genAtributosValoresXLS
go
create procedure genAtributosValoresXLS
(
    @pTabla_Id varchar(100)
)
as
select '' as Upload
select name as Funcion, type from sys.all_objects where name = 'FuncFK'+@pTabla_Id and type='FN'
select name as Tabla, type from sys.all_objects where name=@pTabla_Id and type='U'
go

