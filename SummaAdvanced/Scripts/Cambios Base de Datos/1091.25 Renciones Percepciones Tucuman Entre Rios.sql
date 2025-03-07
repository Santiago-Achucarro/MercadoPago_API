INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('445065',3 ,'Exportacion_Percep_/_Retención_Tucuman', 'C',dbo.FuncFKdisFormularios('frmimpPercRetTucuman'),'D', 1)
INSERT INTO genMenus (Orden, Nivel, Opcion, Tipo, Formulario_id, Orientacion,Especial) Values('445070',3 ,'Exportacion_Percep_/_Retención_Entre_Rios', 'C',dbo.FuncFKdisFormularios('frmimpPercRetEntreRios'),'D', 1)

insert into genVersion(Version) values(1091.25)