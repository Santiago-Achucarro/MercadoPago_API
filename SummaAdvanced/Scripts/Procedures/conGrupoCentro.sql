Drop Procedure conGrupoCentroGuardar
GO
Create Procedure conGrupoCentroGuardar
(
@pGrupo_Id varchar(5), 
@pCentro1_id varchar(8), 
@pCentro2_id varchar(8) 
) 
AS 
SET NOCOUNT ON  
	INSERT INTO  conGrupoCentro
	(Grupo_Id , 
	Centro1_Id , 
	Centro2_Id ) 
	Values 
	(dbo.FuncFKconGruposCont(@pGrupo_Id) , 
	dbo.FuncFKconCentro1(@pCentro1_Id) , 
	dbo.FuncFKconCentro2(@pCentro2_Id) ) 
RETURN @@Error 

GO
Drop Procedure conGrupoCentroDatos
GO
CREATE PROCEDURE conGrupoCentroDatos(
@pGrupo_Id int,
@pCentro1_Id VarChar(8)=null,
@pCentro2_Id VarChar(8)=null
)
AS
SELECT conGruposCont.conGruposCont,  conGruposCont.Grupo_Id, conCentro1.Centro1_Id, conCentro2.Centro2_Id ,
	conCentro1.Descripcion as DescripcionconCentro1 ,
	conCentro2.Descripcion as DescripcionconCentro2
 FROM conGrupoCentro  INNER JOIN conCentro1
	ON conCentro1.conCentro1=conGrupoCentro.Centro1_Id
 INNER JOIN conCentro2
	ON conCentro2.conCentro2=conGrupoCentro.Centro2_Id
 INNER JOIN conGruposCont
	ON conGruposCont.conGruposCont=conGrupoCentro.Grupo_Id
 Where 
	conGrupoCentro.Grupo_Id = @pGrupo_Id and 
	conCentro1.Centro1_Id = ISNULL(@pCentro1_Id,conCentro1.Centro1_Id) and 
	conCentro2.Centro2_Id = ISNULL(@pCentro2_Id, conCentro2.Centro2_Id)

GO
Drop Procedure conGrupoCentroEliminar
GO
Create Procedure conGrupoCentroEliminar(
@pGrupo_Id int, 
@pCentro1_Id VarChar(8)=null,
@pCentro2_Id VarChar(8)=null 
) 
AS 
SET NOCOUNT ON  
DELETE FROM conGrupoCentro 
	 Where 
	conGrupoCentro.Grupo_Id = @pGrupo_Id and 
	conGrupoCentro.Centro1_Id = isnull(dbo.FuncFKconCentro1(@pCentro1_Id), conGrupoCentro.Centro1_Id) and 
	conGrupoCentro.Centro2_Id = ISNULL(dbo.FuncFKconCentro1(@pCentro2_Id), conGrupoCentro.Centro2_Id)
 
 RETURN @@Error 

GO


