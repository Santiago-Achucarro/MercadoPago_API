
IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 17.02)
begin

INSERT INTO genVersion(Version) Values(17.02);

CREATE TABLE dbo.stkEliminaRemiPend
(
    stkMoviCabe bigint NOT NULL,
    Usuario_Id int NOT NULL,
	Fecha DateTime NOT NULL
);
alter table stkEliminaRemiPend 
add foreign key (stkMoviCabe) References stkMoviCabe
alter table stkEliminaRemiPend
add Foreign key (Usuario_Id) References genUsuarios

end


		
		



