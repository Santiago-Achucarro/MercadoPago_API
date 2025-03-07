USE [SummaAdv]
GO
/****** Object:  StoredProcedure [dbo].[espvenClieEspecialKsk]    Script Date: 7/26/2023 10:59:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[espvenClieEspecialKsk]

@clientedesde varchar(15),

@clientehasta varchar(15),

@condfiscal int null

as

select

Cliente_Id,

RazonSocial,

case CondFisc_Id when 1 then 'CONS_FINAL' when 7 then 'RI' else 'OTRO' end as CondFiscal,

LimiteCredito

from venclientes

where Cliente_Id between @clientedesde and @clientehasta

and CondFisc_Id =  @condfiscal or @condfiscal is null

