DROP function FechaActual
GO
Create function FechaActual()
returns dateTime
as
begin
return (
SELECT top 1 DATEADD(HH,genInstalacion.UsoHorario ,GETUTCDATE()  ) from genInstalacion)
end
Go
