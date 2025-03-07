
DROP PROCEDURE venPedidosPendAuto
GO
CREATE PROCEDURE venPedidosPendAuto 
( 
@Empresa_Id int,
@pUsuario_Id int
)
AS

SELECT @Empresa_Id AS Empresa_Id


Select Distinct venPedidos.venPedidos, venPediSegmentos.Segmento_Id, 
dbo.Segmento(venPediSegmentos.Segmento_Id, venPediSegmentos.Segmento1C, venPediSegmentos.Segmento2C, venPediSegmentos.Segmento3C, 
venPediSegmentos.Segmento4C, venPediSegmentos.Segmento1N, venPediSegmentos.Segmento2N, venPediSegmentos.Segmento3N, 
venPediSegmentos.Segmento4N) Segmento,
venClientes.Cliente_Id, venClientes.RazonSocial, venPedidos.Fecha, venPedidos.ObservEstado, 'P' Estado, venPedidos.ImporteTotal,
venNivelesAuto.NivelAuto_Id, venNivelesAuto.Descripcion DescripcionNivel, venNPAutorizando.Secuencia, venNPAutorizando.ResultadoFormula,
venPediValiComer.MVendedor, venPediValiComer.MListaP, venPediValiComer.MFormaE, venPediValiComer.MBonifDato, venPediValiComer.MPrecioReng,
venPediValiComer.MBonifReng
FROM venPedidos
Inner Join venClieHabitual On venPedidos.Cliente_Id = venClieHabitual.genEntidades And venPedidos.Sucursal = venClieHabitual.Sucursal
Inner Join venPediSegmentos On venPediSegmentos.venPedidos = venPedidos.venPedidos
Inner Join venClientes On venClientes.genEntidades = venPedidos.Cliente_Id
Inner Join venNPAutorizando On venNPAutorizando.venPedidos = venPedidos.venPedidos
Inner Join venNivelesAuto On venNPAutorizando.NivelAuto_Id = venNivelesAuto.venNivelesAuto
Inner Join venNivelesAutoUsu ON venNivelesAutoUsu.NivelAuto_Id = venNivelesAuto.venNivelesAuto
Left Join venPediValiComer On venPediValiComer.venPedidos = venPedidos.venPedidos
WHERE
venPedidos.Estado = 'C'
And venNPAutorizando.Usuario_Id Is Null
And venNivelesAutoUsu.Usuario_Id = @pUsuario_Id
Order By venClientes.Cliente_Id, venPediSegmentos.Segmento_Id, 3


Go

