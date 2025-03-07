IF NOT EXISTS(SELECT 1 FROM genVersion WHERE Version = 40.05)
begin
UPDATE disTablas
set TipoControl = 'SummaAdvDisenio.Controles.DisenioGridView'
where TipoControl = 'System.Windows.Forms.DataGridView';

INSERT INTO genVersion(Version) Values(40.05);

end

