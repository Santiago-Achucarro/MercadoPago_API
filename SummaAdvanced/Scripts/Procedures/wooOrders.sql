DROP PROCEDURE wooOrdersGuardar
GO
CREATE PROCEDURE wooOrdersGuardar
(
@pid int = NULL,
@pparent_id int = NULL,
@pnumber varchar(30) = NULL,
@porder_key varchar(30) = NULL,
@pcreated_via varchar(30) = NULL,
@pversion varchar(30) = NULL,
@pstatus varchar(15) = NULL,
@pcurrency varchar(3) = NULL,
@pdate_created datetime = NULL,
@pdate_created_gmt datetime = NULL,
@pdate_modified datetime = NULL,
@pdate_modified_gmt datetime = NULL,
@pdiscount_total qCantidadD8 = NULL,
@pdiscount_tax qCantidadD8 = NULL,
@pshipping_total qCantidadD8 = NULL,
@pshipping_tax qCantidadD8 = NULL,
@pcart_tax qCantidadD8 = NULL,
@ptotal qCantidadD8 = NULL,
@ptotal_tax qCantidadD8 = NULL,
@pprices_include_tax bit = NULL,
@pcustomer_id int = NULL,
@pcustomer_ip_address varchar(20) = NULL,
@pcustomer_user_agent varchar(200) = NULL,
@pcustomer_note varchar(200) = NULL,
@ppayment_method varchar(30) = NULL,
@ppayment_method_title varchar(30) = NULL,
@ptransaction_id varchar(30) = NULL,
@pdate_paid datetime = NULL,
@pdate_paid_gmt datetime = NULL,
@pdate_completed datetime = NULL,
@pdate_completed_gmt datetime = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM wooOrders WHERE id=@pid))
BEGIN 
	UPDATE wooOrders
	SET		id = @pid,
		parent_id = @pparent_id,
		number = @pnumber,
		order_key = @porder_key,
		created_via = @pcreated_via,
		version = @pversion,
		status = @pstatus,
		currency = @pcurrency,
		date_created = @pdate_created,
		date_created_gmt = @pdate_created_gmt,
		date_modified = @pdate_modified,
		date_modified_gmt = @pdate_modified_gmt,
		discount_total = @pdiscount_total,
		discount_tax = @pdiscount_tax,
		shipping_total = @pshipping_total,
		shipping_tax = @pshipping_tax,
		cart_tax = @pcart_tax,
		total = @ptotal,
		total_tax = @ptotal_tax,
		prices_include_tax = @pprices_include_tax,
		customer_id = @pcustomer_id,
		customer_ip_address = @pcustomer_ip_address,
		customer_user_agent = @pcustomer_user_agent,
		customer_note = @pcustomer_note,
		payment_method = @ppayment_method,
		payment_method_title = @ppayment_method_title,
		transaction_id = @ptransaction_id,
		date_paid = @pdate_paid,
		date_paid_gmt = @pdate_paid_gmt,
		date_completed = @pdate_completed,
		date_completed_gmt = @pdate_completed_gmt
	WHERE 
    id=@pid
END 
ELSE 
BEGIN 
	INSERT INTO wooOrders
	(
		id,
		parent_id,
		number,
		order_key,
		created_via,
		version,
		status,
		currency,
		date_created,
		date_created_gmt,
		date_modified,
		date_modified_gmt,
		discount_total,
		discount_tax,
		shipping_total,
		shipping_tax,
		cart_tax,
		total,
		total_tax,
		prices_include_tax,
		customer_id,
		customer_ip_address,
		customer_user_agent,
		customer_note,
		payment_method,
		payment_method_title,
		transaction_id,
		date_paid,
		date_paid_gmt,
		date_completed,
		date_completed_gmt
	)
	VALUES 
	(
		@pid,
		@pparent_id,
		@pnumber,
		@porder_key,
		@pcreated_via,
		@pversion,
		@pstatus,
		@pcurrency,
		@pdate_created,
		@pdate_created_gmt,
		@pdate_modified,
		@pdate_modified_gmt,
		@pdiscount_total,
		@pdiscount_tax,
		@pshipping_total,
		@pshipping_tax,
		@pcart_tax,
		@ptotal,
		@ptotal_tax,
		@pprices_include_tax,
		@pcustomer_id,
		@pcustomer_ip_address,
		@pcustomer_user_agent,
		@pcustomer_note,
		@ppayment_method,
		@ppayment_method_title,
		@ptransaction_id,
		@pdate_paid,
		@pdate_paid_gmt,
		@pdate_completed,
		@pdate_completed_gmt
	)
END 

GO

DROP PROCEDURE wooOrdersDatos
GO
CREATE PROCEDURE wooOrdersDatos
(
    @pId int=null
)
AS
SET NOCOUNT ON 

SELECT wooOrders.id, wooOrders.parent_id, wooOrders.number, wooOrders.order_key,
	wooOrders.created_via, wooOrders.version, wooOrders.status, wooOrders.currency,
	wooOrders.date_created, wooOrders.date_created_gmt, wooOrders.date_modified, wooOrders.date_modified_gmt,
	wooOrders.discount_total, wooOrders.discount_tax, wooOrders.shipping_total, wooOrders.shipping_tax,
	wooOrders.cart_tax, wooOrders.total, wooOrders.total_tax, wooOrders.prices_include_tax,
	wooOrders.customer_id, wooOrders.customer_ip_address, wooOrders.customer_user_agent, wooOrders.customer_note,
	wooOrders.payment_method, wooOrders.payment_method_title, wooOrders.transaction_id, wooOrders.date_paid,
	wooOrders.date_paid_gmt, wooOrders.date_completed, wooOrders.date_completed_gmt, facturado, wooOrdenesCuit.Cuit, wooOrdenesCuit.UsoCFDI, wooOrdenesCuit.Regimen
FROM wooOrders 
inner join wooOrdenesCuit on wooOrdenesCuit.Order_Id=wooOrders.id
WHERE id=@pId


SELECT wooOrdersBillingProperties.order_id, wooOrdersBillingProperties.first_name, wooOrdersBillingProperties.last_name, wooOrdersBillingProperties.company,
	wooOrdersBillingProperties.address_1, wooOrdersBillingProperties.address_2, wooOrdersBillingProperties.city, wooOrdersBillingProperties.state,
	wooOrdersBillingProperties.postcode, wooOrdersBillingProperties.country, wooOrdersBillingProperties.email, wooOrdersBillingProperties.phone
FROM wooOrdersBillingProperties 
WHERE order_id=@pId

SELECT wooOrdersLineItemProperties.order_id, wooOrdersLineItemProperties.item_id, wooOrdersLineItemProperties.name, wooOrdersLineItemProperties.product_id,
	wooOrdersLineItemProperties.variation_id, wooOrdersLineItemProperties.quantity, wooOrdersLineItemProperties.tax_class, wooOrdersLineItemProperties.subtotal,
	wooOrdersLineItemProperties.subtotal_tax, wooOrdersLineItemProperties.total, wooOrdersLineItemProperties.total_tax, wooOrdersLineItemProperties.sku,
	wooOrdersLineItemProperties.price
FROM wooOrdersLineItemProperties 
WHERE  order_id=@pId

SELECT wooOrdersShippingProperties.order_id, wooOrdersShippingProperties.first_name, wooOrdersShippingProperties.last_name, wooOrdersShippingProperties.company,
	wooOrdersShippingProperties.address_1, wooOrdersShippingProperties.address_2, wooOrdersShippingProperties.city, wooOrdersShippingProperties.state,
	wooOrdersShippingProperties.postcode, wooOrdersShippingProperties.country
FROM wooOrdersShippingProperties 
WHERE  order_id=@pId

RETURN @@Error 

GO

DROP PROCEDURE wooOrdersBillingPropertiesGuardar
GO
CREATE PROCEDURE wooOrdersBillingPropertiesGuardar
(
@porder_id int = NULL,
@pfirst_name varchar(120) = NULL,
@plast_name varchar(120) = NULL,
@pcompany varchar(200) = NULL,
@paddress_1 varchar(200) = NULL,
@paddress_2 varchar(200) = NULL,
@pcity varchar(120) = NULL,
@pstate varchar(50) = NULL,
@ppostcode varchar(20) = NULL,
@pcountry varchar(120) = NULL,
@pemail varchar(200) = NULL,
@pphone varchar(30) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM wooOrdersBillingProperties WHERE order_id=@porder_id))
BEGIN 
	UPDATE wooOrdersBillingProperties
	SET		--order_id = @porder_id,
		first_name = @pfirst_name,
		last_name = @plast_name,
		company = @pcompany,
		address_1 = @paddress_1,
		address_2 = @paddress_2,
		city = @pcity,
		state = @pstate,
		postcode = @ppostcode,
		country = @pcountry,
		email = @pemail,
		phone = @pphone
	WHERE order_id=@porder_id
END 
ELSE 
BEGIN 
	INSERT INTO wooOrdersBillingProperties
	(
		order_id,
		first_name,
		last_name,
		company,
		address_1,
		address_2,
		city,
		state,
		postcode,
		country,
		email,
		phone
	)
	VALUES 
	(
		@porder_id,
		@pfirst_name,
		@plast_name,
		@pcompany,
		@paddress_1,
		@paddress_2,
		@pcity,
		@pstate,
		@ppostcode,
		@pcountry,
		@pemail,
		@pphone
	)
END 

GO

DROP PROCEDURE wooOrdersLineItemPropertiesGuardar
GO
CREATE PROCEDURE wooOrdersLineItemPropertiesGuardar
(
@porder_id int = NULL,
@pitem_id int = NULL,
@pname varchar(80) = NULL,
@pproduct_id int = NULL,
@pvariation_id int = NULL,
@pquantity qCantidadD8 = NULL,
@ptax_class varchar(30) = NULL,
@psubtotal qCantidadD8 = NULL,
@psubtotal_tax qCantidadD8 = NULL,
@ptotal qCantidadD8 = NULL,
@ptotal_tax qCantidadD8 = NULL,
@psku varchar(25) = NULL,
@pprice qCantidadD8 = NULL,
@pRenglon int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM wooOrdersLineItemProperties WHERE order_id=@porder_id and Renglon=@pRenglon))
BEGIN 
	UPDATE wooOrdersLineItemProperties
	SET		--order_id = @porder_id,
		item_id = @pitem_id,
		name = @pname,
		product_id = @pproduct_id,
		variation_id = @pvariation_id,
		quantity = @pquantity,
		tax_class = @ptax_class,
		subtotal = @psubtotal,
		subtotal_tax = @psubtotal_tax,
		total = @ptotal,
		total_tax = @ptotal_tax,
		sku = @psku,
		price = @pprice
	WHERE order_id=@porder_id and Renglon=@pRenglon
END 
ELSE 
BEGIN 
	INSERT INTO wooOrdersLineItemProperties
	(
		order_id,
		item_id,
		name,
		product_id,
		variation_id,
		quantity,
		tax_class,
		subtotal,
		subtotal_tax,
		total,
		total_tax,
		sku,
		price,
		Renglon
	)
	VALUES 
	(
		@porder_id,
		@pitem_id,
		@pname,
		@pproduct_id,
		@pvariation_id,
		@pquantity,
		@ptax_class,
		@psubtotal,
		@psubtotal_tax,
		@ptotal,
		@ptotal_tax,
		@psku,
		@pprice,
		@pRenglon
	)
END 

GO


DROP PROCEDURE wooOrdersShippingPropertiesGuardar
GO
CREATE PROCEDURE wooOrdersShippingPropertiesGuardar
(
@porder_id int = NULL,
@pfirst_name varchar(120) = NULL,
@plast_name varchar(120) = NULL,
@pcompany varchar(200) = NULL,
@paddress_1 varchar(200) = NULL,
@paddress_2 varchar(200) = NULL,
@pcity varchar(120) = NULL,
@pstate varchar(50) = NULL,
@ppostcode varchar(20) = NULL,
@pcountry varchar(120) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM wooOrdersShippingProperties WHERE order_id=@porder_id))
BEGIN 
	UPDATE wooOrdersShippingProperties
	SET		--order_id = @porder_id,
		first_name = @pfirst_name,
		last_name = @plast_name,
		company = @pcompany,
		address_1 = @paddress_1,
		address_2 = @paddress_2,
		city = @pcity,
		state = @pstate,
		postcode = @ppostcode,
		country = @pcountry
	WHERE 
    order_id=@porder_id
END 
ELSE 
BEGIN 
	INSERT INTO wooOrdersShippingProperties
	(
		order_id,
		first_name,
		last_name,
		company,
		address_1,
		address_2,
		city,
		state,
		postcode,
		country
	)
	VALUES 
	(
		@porder_id,
		@pfirst_name,
		@plast_name,
		@pcompany,
		@paddress_1,
		@paddress_2,
		@pcity,
		@pstate,
		@ppostcode,
		@pcountry
	)
END 

GO

--exec wooorderssubido 93149
drop procedure wooOrdersReservado
go
create procedure wooOrdersReservado
(
    @pId int,
	@pstkMoviCabe bigint
)
as
update wooOrders set stkMoviCabe=@pstkMoviCabe where id=@pId
GO

drop procedure wooOrdersFacturado
go
create procedure wooOrdersFacturado
(
    @pId int,
	@pvenMovimientos bigint
)
as
update wooOrders set Facturado=1, venmovimientos=@pvenMovimientos where id=@pId
GO



DROP PROCEDURE wooOrdersLineItemPropertiesEliminar
GO
CREATE PROCEDURE wooOrdersLineItemPropertiesEliminar
(
@porder_id int = NULL
)
as
delete wooOrdersLineItemProperties where order_id=@porder_id
go

drop procedure wooOrdenesVencidas
go
create procedure wooOrdenesVencidas
(
	@pFecha datetime
)
as
select wooOrders.id, wooOrders.Cancelado, wooOrders.venMovimientos, wooOrders.stkMoviCabe, stkEnTransito.stkMoviCabeEntr, 
stkDepositos.Deposito_Id, stkDepositos.Descripcion as DescripcionDeposito,
genSegmentos.Segmento_Id, Segmento1N, Segmento2N, Segmento3N, Segmento4N, Segmento1C, Segmento2C,
Segmento3C, Segmento4C, genAsiSegmentos.Empresa_Id from wooOrders
inner join genAsiSegmentos on genAsiSegmentos.Asiento_Id=wooOrders.stkMoviCabe
inner join genSegmentos on genSegmentos.genSegmentos=genAsiSegmentos.Segmento_Id
inner join stkEnTransito on stkEnTransito.stkMoviCabe=wooOrders.stkMoviCabe
inner join stkDepositos on stkDepositos.stkDepositos=stkEnTransito.Deposito_Id
 where date_modified<@pFecha and venMovimientos is null and (Cancelado=0 or Cancelado is null)
GO

drop procedure wooOrdenesCancelar
go
create procedure wooOrdenesCancelar
(
	@pOrder_id int
)
as
update wooorders set Cancelado=1 where id=@pOrder_id
GO
