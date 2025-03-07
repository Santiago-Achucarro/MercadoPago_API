USE [SummaAdv]
GO
/****** Object:  StoredProcedure [dbo].[espvenClienteKSKNumerMaximo]    Script Date: 5/3/2024 9:33:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter  procedure [dbo].[espvenClienteKSKNumerMaximo]
@sucursal varchar(4) = '0243'
-- exec espvenClienteKSKNumerMaximo '0225'

as
-- Gustavo 09/05/2024 - le saco el primer caracter a la sucursal a pedido de Angel y le agrego un numero mas a la parte derecha del codigo
--set @sucursal = right(@sucursal,3)

declare @numero int = (select  max(convert(int,isnull(right(cliente_id,7),'0')))  from venclientes where cliente_id like  @sucursal + '%')
set @numero = isnull(@numero,0) + 1

declare @sNumero varchar(11) = (select @sucursal +  replicate('0',7-len(@numero))) + convert(varchar(7),@numero)
Select @sNumero

