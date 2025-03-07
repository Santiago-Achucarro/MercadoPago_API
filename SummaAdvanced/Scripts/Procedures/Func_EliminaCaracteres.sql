Drop function dbo.Func_EliminaCaracteres
Go
Create function dbo.Func_EliminaCaracteres
(
	@pCadena varchar(200)
)

returns varchar(200)

As

Begin
	Return Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(@pCadena, ' ', '_'), '.', '_'), '%', '_'), ',', '_'), 'á', 'a'), 'é', 'e'), 'í', 'i'), 'ó', 'o'), 'ú', 'u'), '-', '_')
End

