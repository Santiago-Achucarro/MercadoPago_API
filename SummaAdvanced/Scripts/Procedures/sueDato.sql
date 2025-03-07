DROP PROCEDURE sueDatoGuardar
GO
CREATE PROCEDURE sueDatoGuardar
(
@pLegajo bigint,
@pConcepto_Id int,
@pDato QCantidad,
@pDato2 QCantidad,
@pUsuario_Id int = NULL,
@pFechaRegistro qFechaHora,
@pSegmento_Id varchar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 
declare @sueLiquidacion bigint =
(select Asiento_Id from genAsiSegmentos where
Segmento_Id= dbo.FuncFKgenSegmentos(@pSegmento_Id) and
Segmento1N=@pSegmento1N and Segmento2N=@pSegmento2N and
Segmento3N=@pSegmento3N and Segmento4N=@pSegmento4N and
Segmento1C=@pSegmento1C and Segmento2C= @pSegmento2C and
Segmento3C=@pSegmento3C and Segmento4C=@pSegmento4C and
Empresa_Id=@pEmpresa_Id
)
--print @sueliquidacion
IF (EXISTS (SELECT 1 FROM sueDato WHERE (sueLiquidacion = @sueLiquidacion) AND 
	(Legajo = dbo.FuncFKsuePersonal(@pLegajo)) AND 
	(Concepto_Id = dbo.FuncFKsueConceptos(@pConcepto_Id))))
BEGIN 
	UPDATE sueDato
	SET		Dato = @pDato,
		Dato2 = @pDato2,
		Usuario_Id = @pUsuario_Id,
		FechaRegistro = getDate() 
	WHERE sueLiquidacion = @sueLiquidacion AND 
	Legajo = dbo.FuncFKsuePersonal(@pLegajo) AND 
	Concepto_Id = dbo.FuncFKsueConceptos(@pConcepto_Id)

END 
ELSE 
BEGIN 
	INSERT INTO sueDato
	(
		sueLiquidacion,
		Legajo,
		Concepto_Id,
		Dato,
		Dato2,
		Usuario_Id,
		FechaRegistro
	)
	VALUES 
	(
		@sueLiquidacion,
		dbo.FuncFKsuePersonal(@pLegajo),
		dbo.FuncFKsueConceptos(@pConcepto_Id),
		@pDato,
		@pDato2,
		@pUsuario_Id,
		getDate()
	)
END 

GO
-- EXEC sueDatoDatos 1,'SLIQ',2019,9,1,1,' ',' ',' ',' ',1,1

DROP PROCEDURE sueDatoDatos
GO
CREATE PROCEDURE sueDatoDatos
(
@pLegajo int,
@pSegmento_Id varchar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pEmpresa_Id int,
@pGrupo_Id int
)
AS
SET NOCOUNT ON 
declare @sueLiquidacion bigint =
(select Asiento_Id from genAsiSegmentos where
Segmento_Id=dbo.FuncFKgenSegmentos(@pSegmento_Id) and
Segmento1N=@pSegmento1N and Segmento1C=@pSegmento1C and
Segmento2N=@pSegmento2N and Segmento2C=@pSegmento2C and
Segmento3N=@pSegmento3N and Segmento3C=@pSegmento3C and
Segmento4N= @pSegmento4N and Segmento4C= @pSegmento4C and
Empresa_Id=@pEmpresa_Id)

select @pSegmento_Id as Segmento_Id, @pSegmento1N as Segmento1N, @pSegmento2N as Segmento2N, @pSegmento3N as Segmento3N,
@pSegmento4N as Segmento4N, @pSegmento1C as Segmento1C, @pSegmento2C as Segmento2C, @pSegmento3C as Segmento3C,
@pSegmento4C as Segmento4C, suePersonal.Legajo, suePersonal.ApellidoPaterno as DescripcionLegajo, sueLiquidacion.FechaInicial, 
FechaFinal, sueGrupos.Grupo_Id, sueGrupos.Descripcion as DescripcionGrupo, cast(0 as int) as DatoOculto , 
sueLiquidacion.Anio, sueLiquidacion.Mes, sueLiquidacion.Decena, sueLiquidacion.Quincena, sueLiquidacion.Semana, sueLiquidacion.Vez, 
sueLiquidacion.Periodo_Id
from sueLiquidacion 
left join sueGrupos on sueGrupos.sueGrupos= 
	isnull(sueLiquidacion.Grupo_Id, dbo.FuncFKsueGrupos(@pGrupo_Id))
left join suePersonal on suePersonal.Legajo= @pLegajo
where 
sueLiquidacion.sueLiquidacion=@sueLiquidacion

select suePersonal.Legajo, suePersonal.ApellidoPaterno+','+ suePersonal.ApellidoMaterno +','+
suePersonal.Nombres as DescripcionLegajo,
sueConceptos.Concepto_Id, sueConceptos.Descripcion as DescripcionConcepto, 
	sueLiquidacion.sueLiquidacion, sueDato.Dato, sueDato.Dato2, 
	sueDato.FechaRegistro, sueDato.Usuario_Id
from sueVariable
inner join suePersonal on suePersonal.genEntidades=sueVariable.Legajo
inner join sueGrupos on sueGrupos.sueGrupos=sueVariable.Grupo_Id and sueGrupos.Grupo_Id=@pGrupo_Id
inner join sueConceptos on sueConceptos.sueConceptos=sueVariable.Concepto_Id
left join sueLiquidacion on sueLiquidacion.sueLiquidacion=@sueLiquidacion
left join sueDato on sueDato.Concepto_Id=sueConceptos.sueConceptos and sueDato.Legajo=suePersonal.genEntidades and sueDato.sueLiquidacion=sueLiquidacion.sueLiquidacion
where
suePersonal.Legajo=@pLegajo and
sueConceptos.LlevaDato=1
order by 1,3

SELECT sueDatoRetro.sueLiquidacion, suePersonal.Legajo, suePersonal.ApellidoPaterno as DescripcionPersonal, sueConceptos.Concepto_Id, sueConceptos.Descripcion as DescripcionConcepto,
	sueDatoRetro.AnioRetro, sueDatoRetro.MesRetro, sueDatoRetro.Dato, sueDatoRetro.Dato2
FROM sueVariable
inner join suePersonal on sueVariable.Legajo=suePersonal.genEntidades
inner join sueConceptos on sueConceptos.sueConceptos = sueVariable.Concepto_Id 
inner JOIN sueDato  ON (sueDato.sueLiquidacion = @sueLiquidacion) AND (sueDato.Legajo = suePersonal.genEntidades) AND (sueDato.Concepto_Id = sueConceptos.sueConceptos 
and Grupo_Id=dbo.FuncFKsueGrupos(@pGrupo_Id))
inner join sueDatoRetro on sueDato.Concepto_Id=sueDatoRetro.Concepto_Id and sueDato.Legajo= sueDatoRetro.Legajo and sueDatoRetro.sueLiquidacion=@sueLiquidacion
WHERE 
(suePersonal.Legajo = @pLegajo) and
sueConceptos.LlevaDato=1
order by 2,4

RETURN @@Error 

GO

DROP PROCEDURE sueDatoEliminar
GO
CREATE PROCEDURE sueDatoEliminar
(
@pLegajo int,
@pConcepto_Id int,
@pSegmento_Id varchar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 
declare @sueLiquidacion bigint =
(select Asiento_Id from genAsiSegmentos where
Segmento_Id= dbo.FuncFKgenSegmentos(@pSegmento_Id) and
Segmento1N=@pSegmento1N and Segmento2N=@pSegmento2N and
Segmento3N=@pSegmento3N and Segmento4N=@pSegmento4N and
Segmento1C=@pSegmento1C and Segmento2C= @pSegmento2C and
Segmento3C=@pSegmento3C and Segmento4C=@pSegmento4C and
Empresa_Id=@pEmpresa_Id
)

DELETE FROM sueDato 
WHERE (sueLiquidacion = @sueLiquidacion)
AND (Legajo = @pLegajo)
AND (Concepto_Id = dbo.FuncFKsueConceptos(@pConcepto_Id))
 
 RETURN @@Error 

GO

GO


DROP PROCEDURE sueDatoXConceptoDatos
GO
CREATE PROCEDURE sueDatoXConceptoDatos
(
@pGrupo_Id int,
@pSegmento_Id varchar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pEmpresa_Id int,
@pConcepto_Id int
)
AS
SET NOCOUNT ON 
declare @sueLiquidacion bigint =
(select Asiento_Id from genAsiSegmentos where
Segmento_Id=dbo.FuncFKgenSegmentos(@pSegmento_Id) and
Segmento1N=@pSegmento1N and Segmento1C=@pSegmento1C and
Segmento2N=@pSegmento2N and Segmento2C=@pSegmento2C and
Segmento3N=@pSegmento3N and Segmento3C=@pSegmento3C and
Segmento4N= @pSegmento4N and Segmento4C= @pSegmento4C and
Empresa_Id=@pEmpresa_Id)

select @pSegmento_Id as Segmento_Id, @pSegmento1N as Segmento1N, @pSegmento2N as Segmento2N, @pSegmento3N as Segmento3N,
@pSegmento4N as Segmento4N, @pSegmento1C as Segmento1C, @pSegmento2C as Segmento2C, @pSegmento3C as Segmento3C,
@pSegmento4C as Segmento4C, sueConceptos.Concepto_Id, sueConceptos.Descripcion as DescripcionConcepto, sueLiquidacion.FechaInicial, 
FechaFinal, sueGrupos.Grupo_Id, sueGrupos.Descripcion as DescripcionGrupo, cast(0 as int) as DatoOculto,
sueLiquidacion.Anio, sueLiquidacion.Mes, sueLiquidacion.Decena, sueLiquidacion.Quincena, sueLiquidacion.Semana, sueLiquidacion.Vez
from sueLiquidacion 
left join sueGrupos on sueGrupos.sueGrupos= 
	isnull(sueLiquidacion.Grupo_Id, dbo.FuncFKsueGrupos(@pGrupo_Id))
left join sueConceptos on sueConceptos.Concepto_Id=@pConcepto_Id
where 
sueLiquidacion.sueLiquidacion=@sueLiquidacion 
 

select suePersonal.Legajo, suePersonal.ApellidoPaterno+','+ suePersonal.ApellidoMaterno+','+suePersonal.Nombres as DescripcionLegajo,
sueConceptos.Concepto_Id, sueConceptos.Descripcion as DescripcionConcepto, sueLiquidacion.sueLiquidacion, sueDato.Dato, sueDato.Dato2, 
sueDato.FechaRegistro, sueDato.Usuario_Id
from sueVariable
inner join suePersonal on suePersonal.genEntidades=sueVariable.Legajo
inner join sueGrupos on sueGrupos.sueGrupos=sueVariable.Grupo_Id and sueGrupos.Grupo_Id=@pGrupo_Id
inner join sueConceptos on sueConceptos.sueConceptos=sueVariable.Concepto_Id
left join sueLiquidacion on sueLiquidacion.sueLiquidacion=@sueLiquidacion
left join sueDato on sueDato.Concepto_Id=sueConceptos.sueConceptos and sueDato.Legajo=suePersonal.genEntidades and sueDato.sueLiquidacion=sueLiquidacion.sueLiquidacion
where
sueConceptos.Concepto_Id=@pConcepto_Id and
sueConceptos.LlevaDato=1 and 
suePersonal.Empresa_Id = @pEmpresa_Id

SELECT sueDatoRetro.sueLiquidacion, suePersonal.Legajo, suePersonal.ApellidoPaterno+','+ suePersonal.ApellidoMaterno+','+suePersonal.Nombres as DescripcionPersonal, sueConceptos.Concepto_Id, sueConceptos.Descripcion as DescripcionConcepto,
	sueDatoRetro.AnioRetro, sueDatoRetro.MesRetro, sueDato.Dato, sueDato.Dato2, '' as DatoOculto
FROM 
sueLiquidacion inner join sueDato ON sueDato.sueLiquidacion = sueLiquidacion.sueLiquidacion
inner join suePersonal on sueDato.Legajo=suePersonal.genEntidades
inner join sueConceptos on sueConceptos.sueConceptos = sueDato.Concepto_Id 
INNER JOIN sueGrupos ON  sueGrupos.sueGrupos = sueLiquidacion.Grupo_Id
inner join sueDatoRetro on sueDato.Concepto_Id=sueDatoRetro.Concepto_Id and sueDato.Legajo= sueDatoRetro.Legajo and sueDatoRetro.sueLiquidacion=sueDato.sueLiquidacion
WHERE 
sueConceptos.Concepto_Id=@pConcepto_Id  and
sueConceptos.LlevaDato=1 and
sueLiquidacion.sueLiquidacion = @sueLiquidacion and
suePersonal.Empresa_Id = @pEmpresa_Id

RETURN @@Error 

GO