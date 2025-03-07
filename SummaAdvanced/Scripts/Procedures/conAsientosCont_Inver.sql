DROP PROCEDURE conAsientosInverDatos
GO
CREATE PROCEDURE conAsientosInverDatos
(
@pEmpresa_id int, 
@pSegmento_id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20),
@pSegmento_id_Inver VarChar(10), 
@pSegmento1N_Inver int,
@pSegmento2N_Inver int,
@pSegmento3N_Inver int,
@pSegmento4N_Inver int,
@pSegmento1C_Inver VarChar(20),
@pSegmento2C_Inver VarChar(20),
@pSegmento3C_Inver VarChar(20),
@pSegmento4C_Inver VarChar(20)
)
AS
if @pSegmento1N_Inver is null or @pSegmento1N_Inver=0
begin 

exec conAsientosContDatos @pEmpresa_Id, @pSegmento_Id,@pSegmento1N,@pSegmento2N,@pSegmento3N,@pSegmento4N,@pSegmento1C,@pSegmento2C,@pSegmento3C,@pSegmento4C

select conEjercicio.Ejercicio,conAsientosInver.Asiento_Id_Inver as Asiento_Id,genSegmentos.Segmento_Id, SegmentoOri.Segmento1N as Segmento1N, SegmentoOri.Segmento2N as Segmento2N, SegmentoOri.Segmento3N as Segmento3N,
SegmentoOri.Segmento4N as Segmento4N, SegmentoOri.Segmento1C as Segmento1C, SegmentoOri.Segmento2C as Segmento2C,SegmentoOri.Segmento3C as Segmento3C,
genAsiSegmentos.Segmento4C as Segmento4C
from conAsientos 
left join conAsientosInver on conAsientos.conAsientos=conAsientosInver.Asiento_Id
left join genAsiSegmentos on genAsiSegmentos.Asiento_Id=conAsientosInver.Asiento_Id_Inver
inner join genAsiSegmentos SegmentoOri on SegmentoOri.Asiento_Id=conAsientos.conAsientos
inner join genSegmentos on genAsiSegmentos.Segmento_Id=genSegmentos.genSegmentos
inner join conPeriodos on conAsientos.Fecha between conPeriodos.Fecha_Desde and conPeriodos.Fecha_Hasta
inner join conEjercicio on conPeriodos.Ejercicio=conEjercicio.Ejercicio
where
genAsiSegmentos.Empresa_id = @pEmpresa_id and 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N and 
	genAsiSegmentos.Segmento2N = @pSegmento2N and 
	genAsiSegmentos.Segmento3N = @pSegmento3N and 
	genAsiSegmentos.Segmento4N = @pSegmento4N and 
	genAsiSegmentos.Segmento1C = @pSegmento1C and 
	genAsiSegmentos.Segmento2C = @pSegmento2C and 
	genAsiSegmentos.Segmento3C = @pSegmento3C and 
	genAsiSegmentos.Segmento4C = @pSegmento4C 
end
else
begin
Declare @pidentity bigint = (select Asiento_id
 from genAsiSegmentos
 Where
	genAsiSegmentos.Empresa_id = @pEmpresa_id and 
	genAsiSegmentos.Segmento_id = dbo.FuncFKgenSegmentos(@pSegmento_id_Inver) and 
	genAsiSegmentos.Segmento1N = @pSegmento1N_Inver and 
	genAsiSegmentos.Segmento2N = @pSegmento2N_Inver and 
	genAsiSegmentos.Segmento3N = @pSegmento3N_Inver and 
	genAsiSegmentos.Segmento4N = @pSegmento4N_Inver and 
	genAsiSegmentos.Segmento1C = @pSegmento1C_Inver and 
	genAsiSegmentos.Segmento2C = @pSegmento2C_Inver and 
	genAsiSegmentos.Segmento3C = @pSegmento3C_Inver and 
	genAsiSegmentos.Segmento4C = @pSegmento4C_Inver )
exec conAsientosContDatos @pEmpresa_Id, @pSegmento_Id_Inver,@pSegmento1N_Inver,@pSegmento2N_Inver,@pSegmento3N_Inver,@pSegmento4N_Inver,@pSegmento1C_Inver,
@pSegmento2C_Inver,@pSegmento3C_Inver,@pSegmento4C_Inver

select conEjercicio.Ejercicio,genAsiSegmentos.Asiento_Id, genSegmentos.Segmento_Id, Segmento1N, Segmento2N, Segmento3N, Segmento4N, Segmento1C, Segmento2C, Segmento3C, Segmento4C
 from genAsiSegmentos 
 left join conAsientosInver on conAsientosInver.Asiento_Id_Inver=@pidentity
 inner join genSegmentos on genSegmentos=genAsiSegmentos.Segmento_Id 
 inner join conAsientos on conAsientos.conAsientos=genAsiSegmentos.Asiento_Id
 inner join conPeriodos on conAsientos.Fecha between conPeriodos.Fecha_Desde and conPeriodos.Fecha_Hasta
 inner join conEjercicio on conPeriodos.Ejercicio=conEjercicio.Ejercicio

 where conAsientosInver.Asiento_Id= genAsiSegmentos.Asiento_Id


end
go

DROP PROCEDURE conAsientosInverGuardar
GO
CREATE PROCEDURE conAsientosInverGuardar
(
@pAsiento_Id bigint,
@pAsiento_Id_Inver bigint
)
AS
SET NOCOUNT ON 

	INSERT INTO conAsientosInver
	(
		Asiento_Id,
		Asiento_Id_Inver
	)
	VALUES 
	(
		@pAsiento_Id,
		@pAsiento_Id_Inver
	)

GO


DROP PROCEDURE conAsientosInverEliminar
GO
CREATE PROCEDURE conAsientosInverEliminar
(
@pAsiento_Id bigint,
@pAsiento_Id_Inver bigint
)
AS
SET NOCOUNT ON 

DELETE FROM conAsientosInver 
WHERE (Asiento_Id = @pAsiento_Id)
AND (Asiento_Id_Inver = @pAsiento_Id_Inver)
 
 RETURN @@Error 

GO

GO
