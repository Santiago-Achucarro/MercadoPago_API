Create Table espConfPtoVtaKSK(
	Empresa_Id Int,
	SubTipoMov_Id Int, 
	Efectivo int , 
	Cheques Int, 
	TDebito Int,
	TCredito Int,
	Transferencia Int,
	PRIMARY KEY(Empresa_Id)
)
GO

Alter table espConfPtoVtaKSK add Constraint FkespConfPtoVtaKSKEmp
Foreign Key (Empresa_Id) REFERENCES genEmpresas (genEmpresas)
GO

Alter table espConfPtoVtaKSK add Constraint FkespConfPtoVtaKSKSTM 
Foreign Key (SubTipoMov_Id) REFERENCES venSubTipomov (venSubTipomov)
GO

Alter table espConfPtoVtaKSK add Constraint FkespConfPtoVtaKSKEF
Foreign Key (Efectivo) REFERENCES tesIdentifica (tesIdentifica)
GO

Alter table espConfPtoVtaKSK add Constraint FkespConfPtoVtaKSKCH
Foreign Key (Cheques) REFERENCES tesIdentifica (tesIdentifica)
GO

Alter table espConfPtoVtaKSK add Constraint FkespConfPtoVtaKSKTD
Foreign Key (TDebito) REFERENCES tesIdentifica (tesIdentifica)
GO

Alter table espConfPtoVtaKSK add Constraint FkespConfPtoVtaKSKTC
Foreign Key (TCredito) REFERENCES tesIdentifica (tesIdentifica)
GO


Alter table espConfPtoVtaKSK add Constraint FkespConfPtoVtaKSKTran
Foreign Key (Transferencia) REFERENCES tesIdentifica (tesIdentifica)
GO

CREATE TABLE espParaAutorizarKSK
(
	venMovimientos BigInt NOT NULL, 
	tesMovimientos BigInt , 
	Causa VarChar(250) NOT NULL, 
	Estado Char(1) NOT NULL, 
	Usuario_Id Int,
	Primary Key(venMovimientos)
)
GO

Alter table espParaAutorizarKSK add Constraint FkespParaAutorizarKSKVM
Foreign Key (venMovimientos) References venMovimientos
GO

Alter table espParaAutorizarKSK add Constraint FkespParaAutorizarKSKUA
Foreign Key (Usuario_Id) References genUsuarios
GO


Alter table espParaAutorizarKSK add Constraint FkespParaAutorizarKSKTM
Foreign Key (tesMovimientos) References tesMovimientos
GO

Insert Into venTipoMov (venTipoMov, Descripcion, Signo, TipoMovResumido) Values ('Z', 'Comanda', 1, 'COM')
Go

INSERT INTO genVersionEmpresas (Version) Values(250)
GO