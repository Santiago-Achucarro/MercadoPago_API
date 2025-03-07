CREATE TABLE venOtcFormula
( 
	venOtcFormula        integer IDENTITY ( 1,1 ) ,
	Formula_Id           integer  NOT NULL ,
	Empresa_Id           integer  NULL ,
	Descripcion          varchar(60)  NOT NULL ,
	Formula              qFormula ,
	Posteado             Sino ,
	Usuario_Id           integer  NOT NULL ,
	CONSTRAINT XPKvenOtcFormula PRIMARY KEY  CLUSTERED (venOtcFormula ASC)
)
go

CREATE UNIQUE NONCLUSTERED INDEX XAK1venOtcFormula ON venOtcFormula
( 
	Formula_Id            ASC
)
go


ALTER TABLE venOtcFormula
	ADD CONSTRAINT V30R_4797 FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go




ALTER TABLE venOtcFormula
	ADD CONSTRAINT V30R_4798 FOREIGN KEY (Empresa_Id) REFERENCES genEmpresas(genEmpresas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



Alter table venMovimientos add DatoOtCargos qMonedaD2 Null, RenglonCtaOtCargos integer NULL
Go
Update venMovimientos Set DatoOtCargos = 0
Go
Alter table venMovimientos alter column DatoOtCargos qMonedaD2 Not Null
Go

ALTER TABLE venMovimientos
	ADD CONSTRAINT V30R_4801 FOREIGN KEY (venMovimientos,RenglonCtaOtCargos) REFERENCES conMovCont(conAsientos,Renglon)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


Alter table venPedidos add ImpOtCargos qMonedaD2 Null, DescOtrosCargos varchar(60) NULL, DatoOtCargos qMonedaD2 Null, CtaOtrosCargos integer NULL
Go
Update venPedidos Set ImpOtCargos = 0, DatoOtCargos = 0
Go
Alter table venPedidos alter column ImpOtCargos qMonedaD2 Not Null
Go
Alter table venPedidos alter column DatoOtCargos qMonedaD2 Not Null
Go

ALTER TABLE venPedidos
	ADD CONSTRAINT V30R_4800 FOREIGN KEY (CtaOtrosCargos) REFERENCES conCuentas(conCuentas)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

Alter table venSubTipoMov Add CodFormula integer  NULL

Insert Into genLexico (SetFunciones, Funcion, Descripcion, Token, TipoDato) Values ('VENTASOTCARGOS', 'DATO', 'Dato_ingresado_en_el_Formulario_Parametro_valor_predeterminado', 100, 'N')
Go
Insert Into genVersion (Version) Values (1116.10)
Go
