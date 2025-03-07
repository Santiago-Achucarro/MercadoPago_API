DROP PROCEDURE venAbonosFactuSegmentosGuardar  
Go
CREATE PROCEDURE venAbonosFactuSegmentosGuardar  
(  
@pEmpresa_Id int,  
@pSegmento_Id VarChar(10),  
@pSegmento1N int,  
@pSegmento2N int,  
@pSegmento3N int,  
@pSegmento4N int,  
@pSegmento1C varchar(20),  
@pSegmento2C varchar(20),  
@pSegmento3C varchar(20),  
@pSegmento4C varchar(20),  
@pvenAbonosFacturacion bigint,   
@pTieneAutomatico bit,  
@pPosteado bit  
)  
AS  
SET NOCOUNT ON   
  
  
  
IF (EXISTS (SELECT 1 FROM venAbonosFactuSegmentos WHERE   
 (Empresa_Id = @pEmpresa_Id) AND   
 (Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) AND   
 (Segmento1N = @pSegmento1N) AND   
 (Segmento2N = @pSegmento2N) AND   
 (Segmento3N = @pSegmento3N) AND   
 (Segmento4N = @pSegmento4N) AND   
 (Segmento1C = @pSegmento1C) AND   
 (Segmento2C = @pSegmento2C) AND   
 (Segmento3C = @pSegmento3C) AND   
 (Segmento4C = @pSegmento4C)))  
  
    
  
  if @pPosteado=1 and @pSegmento1N < 0  
  begin   
   -- Esta posteando uno pendiente  
   SELECT @pSegmento1N =   
   (SELECT MAX(PrimerNumero)  
   FROM (SELECT   
    MAX(venAbonosFactuSegmentos.Segmento1N)+1 AS PrimerNumero  
     FROM venAbonosFactuSegmentos   
     Where  
      venAbonosFactuSegmentos.Segmento1N > 0 and   
      venAbonosFactuSegmentos.Empresa_id = @pEmpresa_Id and   
      venAbonosFactuSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) And  
      venAbonosFactuSegmentos.Segmento2N = @pSegmento2N And  
      venAbonosFactuSegmentos.Segmento3N = @pSegmento3N And  
      venAbonosFactuSegmentos.Segmento4N = @pSegmento4N And  
      venAbonosFactuSegmentos.Segmento1C = @pSegmento1C And  
      venAbonosFactuSegmentos.Segmento2C = @pSegmento2C And  
      venAbonosFactuSegmentos.Segmento3C = @pSegmento3C And  
      venAbonosFactuSegmentos.Segmento4C = @pSegmento4C  
    UNION ALL  
     SELECT PrimerNumero  
     FROM genContadorSegmento Where  
      (genContadorSegmento.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) AND   
      (genContadorSegmento.Segmento2N = @pSegmento2N) AND   
      (genContadorSegmento.Segmento3N = @pSegmento3N) AND   
      (genContadorSegmento.Segmento4N = @pSegmento4N) AND   
      (genContadorSegmento.Segmento1C = @pSegmento1C) AND   
      (genContadorSegmento.Segmento2C = @pSegmento2C) AND   
      (genContadorSegmento.Segmento3C = @pSegmento3C) AND   
      (genContadorSegmento.Segmento4C = @pSegmento4C) and   
      genContadorSegmento.Empresa_id = @pEmpresa_id and   
      genContadorSegmento.Segmento_Id =dbo.FuncFKgenSegmentos(@pSegmento_Id)) AS XXX)   
        
   -- esto solo pasa si empieza en 1 esta prendido  
   if @pSegmento1N is null or @pSegmento1N < 0  
   begin  
    set @pSegmento1N = 1  
   end   
  
   UPDATE venAbonosFactuSegmentos SET Empresa_Id = @pEmpresa_Id,  
     Segmento1N = @pSegmento1N   
     WHERE venAbonosFacturacion = @pvenAbonosFacturacion  
  
  end  
  
 else  
  BEGIN   
   UPDATE venAbonosFactuSegmentos  
   SET Empresa_Id = @pEmpresa_Id,  
    venAbonosFacturacion = @pvenAbonosFacturacion  
   WHERE (Empresa_Id = @pEmpresa_Id) AND   
    (Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) AND   
    (Segmento1N = @pSegmento1N) AND   
    (Segmento2N = @pSegmento2N) AND   
    (Segmento3N = @pSegmento3N) AND   
    (Segmento4N = @pSegmento4N) AND   
    (Segmento1C = @pSegmento1C) AND   
    (Segmento2C = @pSegmento2C) AND   
    (Segmento3C = @pSegmento3C) AND   
    (Segmento4C = @pSegmento4C)  
  END   
   
ELSE   
BEGIN   
   
 -- Averiguo el que sigue  
   
 if (@pTieneAutomatico=1)  
 BEGIN  
    
  if @pPosteado=1  
  BEGIN  
   SET @pSegmento1N =(SELECT MAX(PrimerNumero)  
   FROM (SELECT   
    MAX(venAbonosFactuSegmentos.Segmento1N)+1 AS PrimerNumero  
     FROM venAbonosFactuSegmentos   
     Where  
      venAbonosFactuSegmentos.Segmento1N > 0 and   
      venAbonosFactuSegmentos.Empresa_id = @pEmpresa_Id and   
      venAbonosFactuSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) And  
      venAbonosFactuSegmentos.Segmento2N = @pSegmento2N And  
      venAbonosFactuSegmentos.Segmento3N = @pSegmento3N And  
      venAbonosFactuSegmentos.Segmento4N = @pSegmento4N And  
      venAbonosFactuSegmentos.Segmento1C = @pSegmento1C And  
      venAbonosFactuSegmentos.Segmento2C = @pSegmento2C And  
      venAbonosFactuSegmentos.Segmento3C = @pSegmento3C And  
      venAbonosFactuSegmentos.Segmento4C = @pSegmento4C  
    UNION ALL  
     SELECT PrimerNumero  
     FROM genContadorSegmento Where  
      (genContadorSegmento.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id)) AND   
      (genContadorSegmento.Segmento2N = @pSegmento2N) AND   
      (genContadorSegmento.Segmento3N = @pSegmento3N) AND   
      (genContadorSegmento.Segmento4N = @pSegmento4N) AND   
      (genContadorSegmento.Segmento1C = @pSegmento1C) AND   
      (genContadorSegmento.Segmento2C = @pSegmento2C) AND   
      (genContadorSegmento.Segmento3C = @pSegmento3C) AND   
      (genContadorSegmento.Segmento4C = @pSegmento4C) and   
      genContadorSegmento.Empresa_id = @pEmpresa_id and   
      genContadorSegmento.Segmento_Id =dbo.FuncFKgenSegmentos(@pSegmento_Id)) AS XXX)   
        
        
   -- esto solo pasa si empieza en 1 esta prendido  
   if @pSegmento1N is null or @pSegmento1N < 0  
   begin  
    set @pSegmento1N = 1  
   end   
  
  
  END  
  ELSE  
   BEGIN  
  
   SET @pSegmento1N = isnull((SELECT MIN(venAbonosFactuSegmentos.Segmento1N) AS Segmento1N   
     FROM venAbonosFactuSegmentos   
     Where  
      venAbonosFactuSegmentos.Segmento1N  < 0 and   
      venAbonosFactuSegmentos.Empresa_id = @pEmpresa_Id and   
      venAbonosFactuSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_Id) And  
      venAbonosFactuSegmentos.Segmento2N = @pSegmento2N And  
      venAbonosFactuSegmentos.Segmento3N = @pSegmento3N And  
      venAbonosFactuSegmentos.Segmento4N = @pSegmento4N And  
      venAbonosFactuSegmentos.Segmento1C = @pSegmento1C And  
      venAbonosFactuSegmentos.Segmento2C = @pSegmento2C And  
      venAbonosFactuSegmentos.Segmento3C = @pSegmento3C And  
      venAbonosFactuSegmentos.Segmento4C = @pSegmento4C),0)-1  
        
    
  END  
     
 END  
   
 INSERT INTO venAbonosFactuSegmentos  
 (  
  Empresa_Id,  
  Segmento_Id,  
  Segmento1N,  
  Segmento2N,  
  Segmento3N,  
  Segmento4N,  
  Segmento1C,  
  Segmento2C,  
  Segmento3C,  
  Segmento4C,  
  venAbonosFacturacion  
 )  
 VALUES   
 (  
  @pEmpresa_Id,  
  dbo.FuncFKgenSegmentos(@pSegmento_Id),  
  @pSegmento1N,  
  @pSegmento2N,  
  @pSegmento3N,  
  @pSegmento4N,  
  @pSegmento1C,  
  @pSegmento2C,  
  @pSegmento3C,  
  @pSegmento4C,  
  @pvenAbonosFacturacion  
 )  
   
END   
SELECT @pSegmento1N as RetVal  
  