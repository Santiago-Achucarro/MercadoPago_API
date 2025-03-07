

CREATE TABLE comOrdenCompDesechado
( 
	comOrdenComp         integer  NOT NULL ,
	Usuario_Id           integer  NOT NULL ,
	Fecha                datetime  NOT NULL ,
	PRIMARY KEY  (comOrdenComp ASC)
)
go

ALTER TABLE comOrdenCompDesechado
	ADD CONSTRAINT comOrdenCompDesechadoOC FOREIGN KEY (comOrdenComp) REFERENCES comOrdenComp(comOrdenComp)
go




ALTER TABLE comOrdenCompDesechado
	ADD CONSTRAINT comOrdenCompDesechadoUSU FOREIGN KEY (Usuario_Id) REFERENCES genUsuarios(genUsuarios)
go


Insert Into genVersion (Version) Values (594)
go



