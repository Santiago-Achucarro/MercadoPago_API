using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace VentasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class venRemitosPendienteClieActionExchange : Framework.Core.Exchange{

        public String Cliente_Id {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public Int32 Sucursal {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public String SubTipoMov_Id {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["SubTipoMov_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].SubTipoMov_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].SubTipoMov_Id = value;
               }
	          }
        public bool IsSubTipoMov_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsSubTipoMov_IdNull();
             }
	        }
        public String DescripcionSubTipoMov {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["DescripcionSubTipoMov"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].DescripcionSubTipoMov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].DescripcionSubTipoMov = value;
               }
	          }
        public bool IsDescripcionSubTipoMovNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsDescripcionSubTipoMovNull();
             }
	        }
        public DateTime FechaPedido {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["FechaPedido"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].FechaPedido;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].FechaPedido = value;
               }
	          }
        public bool IsFechaPedidoNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsFechaPedidoNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public String MonedaFacturacion {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["MonedaFacturacion"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].MonedaFacturacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].MonedaFacturacion = value;
               }
	          }
        public bool IsMonedaFacturacionNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsMonedaFacturacionNull();
             }
	        }
        public String DescripcionMonFacturacion {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["DescripcionMonFacturacion"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].DescripcionMonFacturacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].DescripcionMonFacturacion = value;
               }
	          }
        public bool IsDescripcionMonFacturacionNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsDescripcionMonFacturacionNull();
             }
	        }
        public String CondPagoCli_Id {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["CondPagoCli_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].CondPagoCli_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].CondPagoCli_Id = value;
               }
	          }
        public bool IsCondPagoCli_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsCondPagoCli_IdNull();
             }
	        }
        public String DescripcionCondPago {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["DescripcionCondPago"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].DescripcionCondPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].DescripcionCondPago = value;
               }
	          }
        public bool IsDescripcionCondPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsDescripcionCondPagoNull();
             }
	        }
        public String ListaPrecio_Id {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["ListaPrecio_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].ListaPrecio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].ListaPrecio_Id = value;
               }
	          }
        public bool IsListaPrecio_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsListaPrecio_IdNull();
             }
	        }
        public String DescripcionListasPrecios {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["DescripcionListasPrecios"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].DescripcionListasPrecios;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].DescripcionListasPrecios = value;
               }
	          }
        public bool IsDescripcionListasPreciosNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsDescripcionListasPreciosNull();
             }
	        }
        public String Vendedor_Id {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Vendedor_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Vendedor_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Vendedor_Id = value;
               }
	          }
        public bool IsVendedor_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsVendedor_IdNull();
             }
	        }
        public String DescripcionVendedores {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["DescripcionVendedores"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].DescripcionVendedores;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].DescripcionVendedores = value;
               }
	          }
        public bool IsDescripcionVendedoresNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsDescripcionVendedoresNull();
             }
	        }
        public String FormaEntrega_Id {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["FormaEntrega_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].FormaEntrega_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].FormaEntrega_Id = value;
               }
	          }
        public bool IsFormaEntrega_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsFormaEntrega_IdNull();
             }
	        }
        public String DescripcionFormaEntrega {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["DescripcionFormaEntrega"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].DescripcionFormaEntrega;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].DescripcionFormaEntrega = value;
               }
	          }
        public bool IsDescripcionFormaEntregaNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsDescripcionFormaEntregaNull();
             }
	        }
        public String Estado {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Estado"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Estado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Estado = value;
               }
	          }
        public bool IsEstadoNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsEstadoNull();
             }
	        }
        public String Observaciones {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public Decimal Dato1 {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Dato1"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Dato1;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Dato1 = value;
               }
	          }
        public bool IsDato1Null {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsDato1Null();
             }
	        }
        public Decimal Dato2 {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Dato2"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Dato2;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Dato2 = value;
               }
	          }
        public bool IsDato2Null {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsDato2Null();
             }
	        }
        public Decimal Dato3 {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Dato3"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Dato3;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Dato3 = value;
               }
	          }
        public bool IsDato3Null {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsDato3Null();
             }
	        }
        public String CliOrdenCompra {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["CliOrdenCompra"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].CliOrdenCompra;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].CliOrdenCompra = value;
               }
	          }
        public bool IsCliOrdenCompraNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsCliOrdenCompraNull();
             }
	        }
        public String venNroPedido {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["venNroPedido"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].venNroPedido;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].venNroPedido = value;
               }
	          }
        public bool IsvenNroPedidoNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsvenNroPedidoNull();
             }
	        }
        public String TipoPrecioForm {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["TipoPrecioForm"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].TipoPrecioForm;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].TipoPrecioForm = value;
               }
	          }
        public bool IsTipoPrecioFormNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsTipoPrecioFormNull();
             }
	        }
        public Boolean CongelaCambio {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["CongelaCambio"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].CongelaCambio;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].CongelaCambio = value;
               }
	          }
        public bool IsCongelaCambioNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsCongelaCambioNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public Decimal CambioMonedaOriginal {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["CambioMonedaOriginal"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].CambioMonedaOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].CambioMonedaOriginal = value;
               }
	          }
        public bool IsCambioMonedaOriginalNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsCambioMonedaOriginalNull();
             }
	        }
        public String Incoterm_Id {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Incoterm_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Incoterm_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Incoterm_Id = value;
               }
	          }
        public bool IsIncoterm_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsIncoterm_IdNull();
             }
	        }
        public String DescripcionIncoterm {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["DescripcionIncoterm"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].DescripcionIncoterm;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].DescripcionIncoterm = value;
               }
	          }
        public bool IsDescripcionIncotermNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsDescripcionIncotermNull();
             }
	        }
        public String MetodoPago {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["MetodoPago"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].MetodoPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].MetodoPago = value;
               }
	          }
        public bool IsMetodoPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsMetodoPagoNull();
             }
	        }
        public String UsoCfdi {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["UsoCfdi"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].UsoCfdi;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].UsoCfdi = value;
               }
	          }
        public bool IsUsoCfdiNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsUsoCfdiNull();
             }
	        }
        public String DescripcionUsoCfdi {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["DescripcionUsoCfdi"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].DescripcionUsoCfdi;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].DescripcionUsoCfdi = value;
               }
	          }
        public bool IsDescripcionUsoCfdiNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsDescripcionUsoCfdiNull();
             }
	        }
        public String DescripcionMetodoPago {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["DescripcionMetodoPago"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].DescripcionMetodoPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].DescripcionMetodoPago = value;
               }
	          }
        public bool IsDescripcionMetodoPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsDescripcionMetodoPagoNull();
             }
	        }
        public Boolean Timbrar {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Timbrar"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Timbrar;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Timbrar = value;
               }
	          }
        public bool IsTimbrarNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsTimbrarNull();
             }
	        }
        public String Segmento_IdFact {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Segmento_IdFact"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Segmento_IdFact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Segmento_IdFact = value;
               }
	          }
        public bool IsSegmento_IdFactNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsSegmento_IdFactNull();
             }
	        }
        public Int32 Segmento1NFact {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Segmento1NFact"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Segmento1NFact;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Segmento1NFact = value;
               }
	          }
        public bool IsSegmento1NFactNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsSegmento1NFactNull();
             }
	        }
        public Int32 Segmento2NFact {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Segmento2NFact"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Segmento2NFact;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Segmento2NFact = value;
               }
	          }
        public bool IsSegmento2NFactNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsSegmento2NFactNull();
             }
	        }
        public Int32 Segmento3NFact {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Segmento3NFact"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Segmento3NFact;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Segmento3NFact = value;
               }
	          }
        public bool IsSegmento3NFactNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsSegmento3NFactNull();
             }
	        }
        public Int32 Segmento4NFact {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Segmento4NFact"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Segmento4NFact;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Segmento4NFact = value;
               }
	          }
        public bool IsSegmento4NFactNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsSegmento4NFactNull();
             }
	        }
        public String Segmento1CFact {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Segmento1CFact"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Segmento1CFact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Segmento1CFact = value;
               }
	          }
        public bool IsSegmento1CFactNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsSegmento1CFactNull();
             }
	        }
        public String Segmento2CFact {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Segmento2CFact"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Segmento2CFact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Segmento2CFact = value;
               }
	          }
        public bool IsSegmento2CFactNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsSegmento2CFactNull();
             }
	        }
        public String Segmento3CFact {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Segmento3CFact"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Segmento3CFact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Segmento3CFact = value;
               }
	          }
        public bool IsSegmento3CFactNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsSegmento3CFactNull();
             }
	        }
        public String Segmento4CFact {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Segmento4CFact"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Segmento4CFact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Segmento4CFact = value;
               }
	          }
        public bool IsSegmento4CFactNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsSegmento4CFactNull();
             }
	        }
        public String ArchivoPDF {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["ArchivoPDF"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].ArchivoPDF;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].ArchivoPDF = value;
               }
	          }
        public bool IsArchivoPDFNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsArchivoPDFNull();
             }
	        }
        public String ArchivoXML {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["ArchivoXML"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].ArchivoXML;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].ArchivoXML = value;
               }
	          }
        public bool IsArchivoXMLNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsArchivoXMLNull();
             }
	        }
        public Decimal Total {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Total"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Total;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Total = value;
               }
	          }
        public bool IsTotalNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsTotalNull();
             }
	        }
        public DateTime FechaNueva {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["FechaNueva"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].FechaNueva;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].FechaNueva = value;
               }
	          }
        public bool IsFechaNuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsFechaNuevaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venRemitosPendienteClieDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venRemitosPendienteClieDS );
     }
     public venRemitosPendienteClieActionExchange() : base( "venRemitosPendienteClie" ) {
     }

     public venRemitosPendienteClieActionExchange(venRemitosPendienteClieActionEnum.EnumvenRemitosPendienteClieAction pAccion) : base(venRemitosPendienteClieActionEnum.GetAccionvenRemitosPendienteClieAction(pAccion)) {
     }

     public venRemitosPendienteClieActionExchange(venRemitosPendienteClieActionEnum.EnumvenRemitosPendienteClieAction pAccion, VentasCommon.venRemitosPendienteClieDS pdsParam) : base(venRemitosPendienteClieActionEnum.GetAccionvenRemitosPendienteClieAction(pAccion), pdsParam) {
     }

     public venRemitosPendienteClieActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venRemitosPendienteClieDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venRemitosPendienteClieDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venRemitosPendienteClieDS)mParam;
	        }
     }
  }
}
