IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 1003.05)
begin

update disControlesTexto
set CharCasing = 'Passwo'
where exists (select 1 
			  from disControles 
			  where disControles.Formulario_Id = disControlesTexto.Formulario_Id
			  and disControles.Control_Id = disControlesTexto.Control_Id
			  and disControles.TextoControlVacio = '*')

update disControles
set TextoControlVacio = NULL
where disControles.TextoControlVacio = '*'

INSERT INTO genVersion (Version) Values(1003.05)
end
GO