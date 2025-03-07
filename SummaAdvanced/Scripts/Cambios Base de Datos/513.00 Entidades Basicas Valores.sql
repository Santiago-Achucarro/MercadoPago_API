--SELECT * FROM genEntidadesBasicas where Entidad_Id between 1500 and 1600

-- ESTADOS CIVILES
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1504,'MX','SOL', 'SOLTERO')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1504,'MX','CAS', 'CASADO')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1504,'MX','VIU', 'VIUDO')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1504,'MX','DIV', 'DIVORCIADO')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1504,'MX','UNL', 'UNION LIBRE')
GO

-- CODIGOS NATURALIZACION

INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1514,'MX','N', 'NATIVO')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1514,'MX','M', 'NATURALIZADO')

-- SEXO
INSERT INTO genEntidadesBasicas (Entidad_Id, Descripcion) Values(1515, 'SEXO')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1515,'MX','M', 'MASCULINO')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1515,'MX','F', 'FEMENINO')
GO

-- TIPO SDI
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1513,'MX','1', 'FIJO')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1513,'MX','2', 'VARIABLE')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1513,'MX','3', 'MIXTO')

-- TIPO CONTRATO
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1509,'MX','01', 'Contrato de trabajo por tiempo indeterminado')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1509,'MX','02', 'Contrato de trabajo para obra determinada')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1509,'MX','03', 'Contrato de trabajo por tiempo determinado')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1509,'MX','04', 'Contrato de trabajo por temporada')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1509,'MX','05', 'Contrato de trabajo sujeto a prueba')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1509,'MX','06', 'Contrato de trabajo con capacitación inicial')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1509,'MX','07', 'Modalidad de contratación por pago de hora laborada')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1509,'MX','08', 'Modalidad de trabajo por comisión laboral')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1509,'MX','09', 'Modalidades de contratación donde no existe relación de trabajo')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1509,'MX','10', 'Jubilación, pensión, retiro.')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1509,'MX','13', 'Indemnización o Sepeación')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1509,'MX','99', 'Otro Contrato')
GO

-- TIPO JORNADA

INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1511,'MX','01', 'Diurna')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1511,'MX','02', 'Nocturna')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1511,'MX','03', 'Mixta')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1511,'MX','04', 'Por Hora')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1511,'MX','05', 'Reducida')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1511,'MX','06', 'Continua')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1511,'MX','07', 'Partida Por Turnos')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1511,'MX','99', 'Otra')

GO

-- REGIMEN
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1512,'MX','2', 'Sueldos y salarios')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1512,'MX','3', 'Jubilados')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1512,'MX','4', 'Pensionados')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1512,'MX','5', 'Asimilados a salarios, Miembros de las Sociedades Cooperativas de Producción.')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1512,'MX','6', 'Asimilados Integrantes Sociedades Asociaciones Civiles')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1512,'MX','7', 'Asimilados Miembros consejos')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1512,'MX','8', 'Asimilados a salarios, Actividad empresarial (comisionistas)')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1512,'MX','9', 'Asimilados a salarios, Honorarios asimilados a salarios')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1512,'MX','10', 'Asimilados a salarios, Ingresos acciones o títulos valor')


-- AFORES
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1502,'MX','AFIRM', 'AFIRME BAJÍO')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1502,'MX','AZTE ', 'AZTECA')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1502,'MX','BCOM ', 'BANCOMER')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1502,'MX','BMX  ', 'BANAMEX')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1502,'MX','BNOR ', 'BANORTE GENERALI')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1502,'MX','COP  ', 'COPPEL')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1502,'MX','GNP  ', 'PROFUTURO GNP')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1502,'MX','INB  ', 'INBURSA')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1502,'MX','ING  ', 'ING')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1502,'MX','INVC ', 'INVERCAP')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1502,'MX','ISSTE', 'PENSIÓN ISSTE')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1502,'MX','MET  ', 'METLIFE')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1502,'MX','PRIN ', 'PRINCIPAL')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1502,'MX','SA   ', 'SIN AFORE')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1502,'MX','XXI  ', 'XXI')
INSERT INTO genEntidadesBasicasValor(Entidad_Id, Dominio_Id , Clave, Descripcion) values(1502,'MX','N', 'NINGUNA')

go

alter table suePersTipoJornada alter column TipoJornada char(2)
go

insert into genVersion (Version) values  (513.00)
