ALTER TABLE venFormaEntrega	Drop CONSTRAINT R_3309

Update venFormaEntrega Set CondFisc_Id = comCondFiscal.comCondFiscal From venCondFiscal, comCondFiscal Where venCondFiscal.CondFisc_Id = comCondFiscal.CondFiscal_Id And
	venCondFiscal.venCondFiscal = venFormaEntrega.CondFisc_Id


Update venFormaEntrega Set CondFisc_Id = (select top 1 comCondFiscal.comCondFiscal 
	From comCondFiscal )
	Where not exists(
		select 1 from comCondFiscal 
		where 
		comCondFiscal.comCondFiscal = venFormaEntrega.CondFisc_Id )
GO

ALTER TABLE venFormaEntrega
	ADD CONSTRAINT RR_4094 FOREIGN KEY (CondFisc_Id) REFERENCES comCondFiscal(comCondFiscal)
go

Insert into genVersion (Version) Values (90.10)
Go
