Drop procedure inf_conGruposCont
Go

Create procedure inf_conGruposCont
(
@GrupoDesde varChar(5),
@GrupoHasta varChar(5)
)
As
Select conGruposCont.Grupo_Id, conGruposCont.Descripcion DescripcionGrupo, conCentro1.Centro1_Id, conCentro1.Descripcion DescripcionCentro1,
conCentro2.Centro2_Id, conCentro2.Descripcion DescripcionCentro2
From conGruposCont
Inner Join conGrupoCentro On conGrupoCentro.Grupo_Id = conGruposCont.conGruposCont
Inner Join conCentro1 On conCentro1.conCentro1 = conGrupoCentro.Centro1_Id
Inner Join conCentro2 On conCentro2.conCentro2 = conGrupoCentro.Centro2_Id
Where conGruposCont.Grupo_Id Between @GrupoDesde And @GrupoHasta
Order By conGruposCont.Grupo_Id, conGrupoCentro.Centro1_Id, conGrupoCentro.Centro2_Id
Go
