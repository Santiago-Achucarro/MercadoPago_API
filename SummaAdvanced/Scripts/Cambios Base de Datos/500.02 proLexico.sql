insert into genLexico values('PROLEXICO','MAX','Devuelve_el_maximo_valor_entre_los_dos_numeros',168,'N')
insert into genLexico values('PROLEXICO','MIN','Devuelve_el_minimo_valor_entre_los_dos_numeros',168,'N')
insert into genLexico values('PROLEXICO','IIF','Funcion_condicional',113,'N')
insert into genLexico values('PROLEXICO','VAR','Devuelve_el_valor_de_una_variable_global',100,'N')

create table proProductosReceta
(
Producto_Id int,
Receta_Id int,
Principal bit
primary key (Producto_Id, Receta_Id),
Foreign key (Receta_Id) References proRecetas(proRecetas),
foreign key (Producto_Id) references stkProductos(stkProductos)
)

insert into genVersion (Version) values(500.02)
