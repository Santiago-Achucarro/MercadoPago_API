CREATE TABLE [proOrdenPedido](
	[proOrden] [int] NOT NULL,
	[venPedidos] [int] NOT NULL,
	[Renglon_Pe] [int] NOT NULL,
 CONSTRAINT [XPKproOrdenPedido] PRIMARY KEY CLUSTERED 
(
	[proOrden] ASC,
	[venPedidos] ASC,
	[Renglon_Pe] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [proOrdenPedido]  WITH CHECK ADD  CONSTRAINT [V2POR_3738] FOREIGN KEY([proOrden])
REFERENCES [proOrden] ([proOrden])
GO

ALTER TABLE [proOrdenPedido] CHECK CONSTRAINT [V2POR_3738]
GO

ALTER TABLE [proOrdenPedido]  WITH CHECK ADD  CONSTRAINT [V2POR_3740] FOREIGN KEY([venPedidos], [Renglon_Pe])
REFERENCES [venPediCuerpo] ([venPedidos], [Renglon_Pe])
GO

ALTER TABLE [proOrdenPedido] CHECK CONSTRAINT [V2POR_3740]
GO

INSERT INTO genVersion (Version) VALUES (1115.14)
Go

