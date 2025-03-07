--select * from stkInventarios
--select * from stkInventCuerpo
--select * from stkInvenSegmentos
--Exec stkInventarioDatos 1, 'INV', 3, 0, 0, 0, '0001', '', '', ''

drop procedure stkInventarioDatos
go
create procedure stkInventarioDatos
(
@pEmpresa_Id int,
@pSegmento_Id VarChar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20)
)
as
SET NOCOUNT ON

declare @stkInventario as int
set @stkInventario =(select stkInventarios 
from stkInvenSegmentos 
where (Empresa_Id = @pEmpresa_Id) AND 
	(Segmento_Id = dbo.FuncFkgenSegmentos(@pSegmento_Id)) AND 
	(Segmento1N = @pSegmento1N) AND 
	(Segmento2N = @pSegmento2N) AND 
	(Segmento3N = @pSegmento3N) AND 
	(Segmento4N = @pSegmento4N) AND 
	(Segmento1C = @pSegmento1C) AND 
	(Segmento2C = @pSegmento2C) AND 
	(Segmento3C = @pSegmento3C) AND 
	(Segmento4C = @pSegmento4C))

select stkInventarios.stkInventarios, stkInvenSegmentos.Empresa_Id,
stkInvenSegmentos.Segmento1N, stkInvenSegmentos.Segmento2N, stkInvenSegmentos.Segmento3N, stkInvenSegmentos.Segmento4N,
stkInvenSegmentos.Segmento1C, stkInvenSegmentos.Segmento2C, stkInvenSegmentos.Segmento3C,
stkInvenSegmentos.Segmento4C,
stkInventarios.FechaInventario, stkInventarios.FechaCarga, stkDepositos.Deposito_Id, stkInventarios.FechaAutorizo,
UsuarioAuto.genUsuarios as UsuarioAutorizo, UsuarioRespo.Usuario_Id as UsuRespo_Id, genUsuarios.Usuario_Id,
stkInventarios.Posteado, ' ' as Desde, ' ' as Hasta, ' ' as Segmento_Id, ' ' as Apellido_y_Nombres, ' ' as DescripcionDeposito,
' ' as ExtencionArchivo, '' as FamiliaDesde, '' as FamiliaHasta, '' as GrupoDesde, '' as GrupoHasta, conCentro1.Centro1_Id, conCentro1.Descripcion Centro1Descripcion,
conCentro2.Centro2_Id, conCentro2.Descripcion Centro2Descripcion
From stkInventarios
inner join stkInvenSegmentos on stkInventarios.stkInventarios=stkInvenSegmentos.stkInventarios
inner join genUsuarios on stkInventarios.Usuario_Id=genUsuarios.genUsuarios
inner join stkDepositos on stkInventarios.Deposito_Id=stkDepositos.stkDepositos
inner join genUsuarios UsuarioRespo on stkInventarios.UsuRespo_Id=UsuarioRespo.genUsuarios
left join genUsuarios UsuarioAuto on UsuarioAuto.genUsuarios=stkInventarios.UsuarioAutorizo
Left Join conCentro1 On conCentro1.conCentro1 = stkInventarios.Centro1_Id
Left Join conCentro2 On conCentro2.conCentro2 = stkInventarios.Centro2_Id
where @stkInventario=stkInventarios.stkInventarios


Select stkProductos.Producto_Id, Cantidad, stkUniMed.Medida_Id, CantidadAlterna, UniMedAlterna.Medida_Id as MedidaAlterna_Id, stkProductos.Descripcion as DescripcionProducto
from stkInventCuerpo
inner join stkProductos on stkInventCuerpo.Producto_Id=stkProductos.stkProductos
inner join stkUniMed on stkProductos.Medida_Id=stkUniMed.stkUniMed
left join stkUniMed UniMedAlterna on stkProductos.MedidaAlterna=stkUniMed.stkUniMed
where stkInventarios=@stkInventario

Exec genAtributosGeneralesIdentityDatos @stkInventario, 'stkInventarios'

Exec stkInventDespachoDatos @stkInventario
Exec stkInventSerieDatos @stkInventario

return @@error
go

drop procedure stkInventarioGuardar
go
create procedure stkInventarioGuardar
(
@pDeposito_Id varchar(15),
@pFechaInventario datetime,
@pFechaCarga datetime,
@pFechaAutorizo datetime=null,
@pUsuarioAutorizo int=null,
@pUsuRespo_Id varchar(25),
@pCentro1_Id varChar(8) = Null,
@pCentro2_Id varChar(8) = Null,
@pUsuario_Id int,
@pPosteado SiNo,

@pEmpresa_Id int,
@pSegmento_Id VarChar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pTieneAutomatico bit
)
as
SET NOCOUNT ON
set @pDeposito_Id=dbo.FuncFKstkDepositos(@pDeposito_Id)
set @pUsuRespo_Id=dbo.FuncFKgenUsuarios(@pUsuRespo_Id)
DECLARE @pstkInventarios as Int
SET @pstkInventarios = (SELECT stkInventarios 
	FROM stkInvenSegmentos WHERE 
	(Empresa_Id = @pEmpresa_Id) AND 
	(Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) AND 
	(Segmento1N = @pSegmento1N) AND 
	(Segmento2N = @pSegmento2N) AND 
	(Segmento3N = @pSegmento3N) AND 
	(Segmento4N = @pSegmento4N) AND 
	(Segmento1C = @pSegmento1C) AND 
	(Segmento2C = @pSegmento2C) AND 
	(Segmento3C = @pSegmento3C) AND 
	(Segmento4C = @pSegmento4C))
if(@pstkInventarios is not null)
begin
	update stkInventarios set
	Deposito_Id = @pDeposito_Id,
	FechaInventario = @pFechaInventario,
	FechaCarga = @pFechaCarga,
	FechaAutorizo = @pFechaAutorizo,
	UsuarioAutorizo = @pUsuarioAutorizo,
	UsuRespo_Id = @pUsuRespo_Id,
	Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id),
	Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id),
	Usuario_Id = @pUsuario_Id,
	Posteado = @pPosteado
	where stkInventarios = @pstkInventarios
end
else
begin

if ((@pTieneAutomatico=1) AND (@pSegmento1N = 0))
		BEGIN
			
			set @pSegmento1N = ISNULL((SELECT MAX(Segmento1N) 
				FROM stkInvenSegmentos inner join genSegmentos ON
				stkInvenSegmentos.Segmento_id = genSegmentos.genSegmentos
				WHERE
				(stkInvenSegmentos.Empresa_Id = @pEmpresa_Id) AND 
				(genSegmentos.Segmento_Id = @pSegmento_Id) AND 
				(Segmento2N = @pSegmento2N) AND 
				(Segmento3N = @pSegmento3N) AND 
				(Segmento4N = @pSegmento4N) AND 
				(Segmento1C = @pSegmento1C) AND 
				(Segmento2C = @pSegmento2C) AND 
				(Segmento3C = @pSegmento3C) AND 
				(Segmento4C = @pSegmento4C)),0) + 1

		END

insert into stkInventarios
(
	Deposito_Id,
	FechaInventario,
	FechaCarga,
	FechaAutorizo,
	UsuarioAutorizo,
	UsuRespo_Id,
	Centro1_Id,
	Centro2_Id,
	Usuario_Id,
	Posteado
)
Values
(
	@pDeposito_Id,
	@pFechaInventario,
	@pFechaCarga,
	@pFechaAutorizo,
	@pUsuarioAutorizo,
	@pUsuRespo_Id,
	dbo.FuncFKconCentro1(@pCentro1_Id),
	dbo.FuncFKconCentro2(@pCentro2_Id),
	@pUsuario_Id,
	@pPosteado
)
SET @pstkInventarios =  Cast(SCOPE_IDENTITY() as int) 
end
Select @pstkInventarios as RetVal 
go

drop procedure stkInventarioEliminar
go
create procedure stkInventarioEliminar
(
@pstkInventario int
)
as
SET NOCOUNT ON
delete from stkInventarios where stkInventarios=@pstkInventario
return @@error
go

DROP PROCEDURE stkInventarioDatosInt
GO
CREATE PROCEDURE stkInventarioDatosInt
( @pstkInventarios int)
as
	select stkInvenSegmentos.stkInventarios, stkInvenSegmentos.Empresa_Id, 
	stkInvenSegmentos.Segmento1N,stkInvenSegmentos.Segmento2N, stkInvenSegmentos.Segmento3N, stkInvenSegmentos.Segmento4N, 
	stkInvenSegmentos.Segmento1C, stkInvenSegmentos.Segmento2C, stkInvenSegmentos.Segmento3C, stkInvenSegmentos.Segmento4C
	from stkInvenSegmentos
	Where
	stkInvenSegmentos.stkInventarios = @pstkInventarios

go

drop procedure stkAgregarListaProductos
go
create procedure stkAgregarListaProductos
(
@pProductoDesde_Id varchar(25),
@pProductoHasta_Id varchar(25),
@pFamiliaDesde varchar(15),
@pFamiliaHasta varchar(15),
@pGrupoDesde varchar(15),
@pGrupoHasta varchar(15),
@pEmpresa_Id Int
)
as
set nocount on
select Producto_Id, stkProductos.Descripcion, stkUniMed.Medida_Id, stkUniMedAlterna.Medida_Id as MedidaAlterna from stkProductos
inner join stkUniMed on stkUniMed=stkProductos.Medida_Id
left join stkUniMed as stkUniMedAlterna on stkUniMedAlterna.stkUniMed=stkProductos.MedidaAlterna
left join stkFamilias on stkProductos.Familia_Id=stkFamilias.stkFamilias
left join stkGrupos on stkGrupos.stkGrupos=stkProductos.Grupo_Id
where stkProductos.Producto_Id Between @pProductoDesde_Id and @pProductoHasta_Id  and 
ISNULL(stkFamilias.Familia_Id,' ') BETWEEN @pFamiliaDesde and @pFamiliaHasta and
ISNULL(stkGrupos.Grupo_Id,' ') between @pGrupoDesde and @pGrupoHasta and
	(Clase='E' or Clase='-') and stkProductos.Inactivo = 0 and stkProductos.Posteado = 1 and
ISNULL(stkProductos.Empresa_Id,@pEmpresa_Id) = @pEmpresa_Id
go

drop procedure stkInventariosAutorizar
go
create procedure stkInventariosAutorizar
(
@pstkInventarios int,
@pUsuarioAutorizo int
)
as
set nocount on
update stkInventarios set UsuarioAutorizo=@pUsuarioAutorizo, FechaAutorizo=getdate() where stkInventarios=@pstkInventarios
go


