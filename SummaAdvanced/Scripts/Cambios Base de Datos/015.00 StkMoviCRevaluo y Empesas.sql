IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 15.00)
begin

INSERT INTO genVersion(Version) Values(15.00);

sp_rename 'stkMoviCRevaluo.stkMoviCabe', 'conAsientos';


ALTER TABLE stkMoviCRevaluo  drop constraint [FK__stkMoviCR__stkMo__577FAD00];


ALTER TABLE stkMoviCRevaluo  ADD FOREIGN KEY(conAsientos) REFERENCES conAsientos;

Alter table genMenus Add Empresa_Id Int; 

ALTER TABLE genMenus add FOREIGN KEY(Empresa_Id) REFERENCES genEmpresas;

END


