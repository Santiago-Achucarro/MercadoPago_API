IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 1004.05)
begin
	-- estas se llaman desde otro form
	if (EXISTS (SELECT 1 FROM genMenus WHERE Orden = 'Z0000'))
	begin
		DELETE FROM genMenus WHERE Orden = 'Z0000'
		INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('Z000',1 ,'Otros', 'S', NULL,'D', 0)
		INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('Z100',2 ,'Aplicar', 'C', dbo.FuncFKdisFormularios('frmvenAplicaciones'),'D', 0)
	end
INSERT INTO genVersion (Version) Values(1004.05)	
end
GO