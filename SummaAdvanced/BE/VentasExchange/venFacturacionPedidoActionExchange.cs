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
    public class venFacturacionPedidoActionExchange : Framework.Core.Exchange{

        public Int32 venPedidos {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["venPedidos"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].venPedidos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].venPedidos = value;
               }
	          }
        public bool IsvenPedidosNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsvenPedidosNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String SubTipoMov_Id {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["SubTipoMov_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].SubTipoMov_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].SubTipoMov_Id = value;
               }
	          }
        public bool IsSubTipoMov_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSubTipoMov_IdNull();
             }
	        }
        public String DescripcionSubTipoMov {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["DescripcionSubTipoMov"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionSubTipoMov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionSubTipoMov = value;
               }
	          }
        public bool IsDescripcionSubTipoMovNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsDescripcionSubTipoMovNull();
             }
	        }
        public DateTime FechaPedido {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["FechaPedido"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].FechaPedido;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].FechaPedido = value;
               }
	          }
        public bool IsFechaPedidoNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsFechaPedidoNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public Int32 Sucursal {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public String NombreFantasia {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["NombreFantasia"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].NombreFantasia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].NombreFantasia = value;
               }
	          }
        public bool IsNombreFantasiaNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsNombreFantasiaNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public String MonedaFacturacion {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["MonedaFacturacion"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].MonedaFacturacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].MonedaFacturacion = value;
               }
	          }
        public bool IsMonedaFacturacionNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsMonedaFacturacionNull();
             }
	        }
        public String DescripcionMonFacturacion {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["DescripcionMonFacturacion"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionMonFacturacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionMonFacturacion = value;
               }
	          }
        public bool IsDescripcionMonFacturacionNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsDescripcionMonFacturacionNull();
             }
	        }
        public String CondPagoCli_Id {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["CondPagoCli_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].CondPagoCli_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].CondPagoCli_Id = value;
               }
	          }
        public bool IsCondPagoCli_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsCondPagoCli_IdNull();
             }
	        }
        public String DescripcionCondPago {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["DescripcionCondPago"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionCondPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionCondPago = value;
               }
	          }
        public bool IsDescripcionCondPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsDescripcionCondPagoNull();
             }
	        }
        public String ListaPrecio_Id {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["ListaPrecio_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].ListaPrecio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].ListaPrecio_Id = value;
               }
	          }
        public bool IsListaPrecio_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsListaPrecio_IdNull();
             }
	        }
        public String DescripcionListasPrecios {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["DescripcionListasPrecios"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionListasPrecios;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionListasPrecios = value;
               }
	          }
        public bool IsDescripcionListasPreciosNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsDescripcionListasPreciosNull();
             }
	        }
        public String Vendedor_Id {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Vendedor_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Vendedor_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Vendedor_Id = value;
               }
	          }
        public bool IsVendedor_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsVendedor_IdNull();
             }
	        }
        public String DescripcionVendedores {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["DescripcionVendedores"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionVendedores;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionVendedores = value;
               }
	          }
        public bool IsDescripcionVendedoresNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsDescripcionVendedoresNull();
             }
	        }
        public String FormaEntrega_Id {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["FormaEntrega_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].FormaEntrega_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].FormaEntrega_Id = value;
               }
	          }
        public bool IsFormaEntrega_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsFormaEntrega_IdNull();
             }
	        }
        public String DescripcionFormaEntrega {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["DescripcionFormaEntrega"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionFormaEntrega;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionFormaEntrega = value;
               }
	          }
        public bool IsDescripcionFormaEntregaNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsDescripcionFormaEntregaNull();
             }
	        }
        public String Estado {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Estado"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Estado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Estado = value;
               }
	          }
        public bool IsEstadoNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsEstadoNull();
             }
	        }
        public String UsuarioAutoriz_Id {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["UsuarioAutoriz_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].UsuarioAutoriz_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].UsuarioAutoriz_Id = value;
               }
	          }
        public bool IsUsuarioAutoriz_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsUsuarioAutoriz_IdNull();
             }
	        }
        public String DescripcionUsuarioAutoriz {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["DescripcionUsuarioAutoriz"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionUsuarioAutoriz;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionUsuarioAutoriz = value;
               }
	          }
        public bool IsDescripcionUsuarioAutorizNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsDescripcionUsuarioAutorizNull();
             }
	        }
        public DateTime FechaAutorizo {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["FechaAutorizo"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].FechaAutorizo;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].FechaAutorizo = value;
               }
	          }
        public bool IsFechaAutorizoNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsFechaAutorizoNull();
             }
	        }
        public String Observaciones {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public String ObservEstado {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["ObservEstado"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].ObservEstado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].ObservEstado = value;
               }
	          }
        public bool IsObservEstadoNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsObservEstadoNull();
             }
	        }
        public Int16 Motivo_Id {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Motivo_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Motivo_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Motivo_Id = value;
               }
	          }
        public bool IsMotivo_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsMotivo_IdNull();
             }
	        }
        public Decimal ImporteTotal {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["ImporteTotal"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].ImporteTotal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].ImporteTotal = value;
               }
	          }
        public bool IsImporteTotalNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsImporteTotalNull();
             }
	        }
        public Decimal Bonificacion1 {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Bonificacion1"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Bonificacion1;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Bonificacion1 = value;
               }
	          }
        public bool IsBonificacion1Null {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsBonificacion1Null();
             }
	        }
        public Decimal Bonificacion2 {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Bonificacion2"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Bonificacion2;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Bonificacion2 = value;
               }
	          }
        public bool IsBonificacion2Null {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsBonificacion2Null();
             }
	        }
        public Decimal Bonificacion3 {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Bonificacion3"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Bonificacion3;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Bonificacion3 = value;
               }
	          }
        public bool IsBonificacion3Null {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsBonificacion3Null();
             }
	        }
        public Decimal Bonificacion4 {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Bonificacion4"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Bonificacion4;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Bonificacion4 = value;
               }
	          }
        public bool IsBonificacion4Null {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsBonificacion4Null();
             }
	        }
        public Decimal Bonificacion5 {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Bonificacion5"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Bonificacion5;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Bonificacion5 = value;
               }
	          }
        public bool IsBonificacion5Null {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsBonificacion5Null();
             }
	        }
        public Decimal Dato1 {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Dato1"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Dato1;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Dato1 = value;
               }
	          }
        public bool IsDato1Null {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsDato1Null();
             }
	        }
        public Decimal Dato2 {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Dato2"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Dato2;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Dato2 = value;
               }
	          }
        public bool IsDato2Null {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsDato2Null();
             }
	        }
        public Decimal Dato3 {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Dato3"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Dato3;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Dato3 = value;
               }
	          }
        public bool IsDato3Null {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsDato3Null();
             }
	        }
        public DateTime FechaUltMod {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["FechaUltMod"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].FechaUltMod;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].FechaUltMod = value;
               }
	          }
        public bool IsFechaUltModNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsFechaUltModNull();
             }
	        }
        public String CliOrdenCompra {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["CliOrdenCompra"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].CliOrdenCompra;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].CliOrdenCompra = value;
               }
	          }
        public bool IsCliOrdenCompraNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsCliOrdenCompraNull();
             }
	        }
        public String venNroPedido {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["venNroPedido"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].venNroPedido;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].venNroPedido = value;
               }
	          }
        public bool IsvenNroPedidoNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsvenNroPedidoNull();
             }
	        }
        public Boolean FacturaAnticipo {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["FacturaAnticipo"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].FacturaAnticipo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].FacturaAnticipo = value;
               }
	          }
        public bool IsFacturaAnticipoNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsFacturaAnticipoNull();
             }
	        }
        public Boolean TrabaDespacho {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["TrabaDespacho"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].TrabaDespacho;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].TrabaDespacho = value;
               }
	          }
        public bool IsTrabaDespachoNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsTrabaDespachoNull();
             }
	        }
        public Decimal PorAnticipo {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["PorAnticipo"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].PorAnticipo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].PorAnticipo = value;
               }
	          }
        public bool IsPorAnticipoNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsPorAnticipoNull();
             }
	        }
        public Decimal Anticipo {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Anticipo"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Anticipo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Anticipo = value;
               }
	          }
        public bool IsAnticipoNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsAnticipoNull();
             }
	        }
        public Decimal AnticipoPendiente {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["AnticipoPendiente"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].AnticipoPendiente;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].AnticipoPendiente = value;
               }
	          }
        public bool IsAnticipoPendienteNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsAnticipoPendienteNull();
             }
	        }
        public String ObsAnticipo {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["ObsAnticipo"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].ObsAnticipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].ObsAnticipo = value;
               }
	          }
        public bool IsObsAnticipoNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsObsAnticipoNull();
             }
	        }
        public String TipoPrecioForm {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["TipoPrecioForm"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].TipoPrecioForm;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].TipoPrecioForm = value;
               }
	          }
        public bool IsTipoPrecioFormNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsTipoPrecioFormNull();
             }
	        }
        public Boolean CongelaCambio {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["CongelaCambio"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].CongelaCambio;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].CongelaCambio = value;
               }
	          }
        public bool IsCongelaCambioNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsCongelaCambioNull();
             }
	        }
        public DateTime Fecha_Registro {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Fecha_Registro"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Fecha_Registro;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Fecha_Registro = value;
               }
	          }
        public bool IsFecha_RegistroNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsFecha_RegistroNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public Decimal CambioMonedaOriginal {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["CambioMonedaOriginal"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].CambioMonedaOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].CambioMonedaOriginal = value;
               }
	          }
        public bool IsCambioMonedaOriginalNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsCambioMonedaOriginalNull();
             }
	        }
        public String Incoterm_Id {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Incoterm_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Incoterm_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Incoterm_Id = value;
               }
	          }
        public bool IsIncoterm_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsIncoterm_IdNull();
             }
	        }
        public String DescripcionIncoterm {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["DescripcionIncoterm"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionIncoterm;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionIncoterm = value;
               }
	          }
        public bool IsDescripcionIncotermNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsDescripcionIncotermNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String MetodoPago {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["MetodoPago"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].MetodoPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].MetodoPago = value;
               }
	          }
        public bool IsMetodoPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsMetodoPagoNull();
             }
	        }
        public String UsoCfdi {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["UsoCfdi"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].UsoCfdi;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].UsoCfdi = value;
               }
	          }
        public bool IsUsoCfdiNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsUsoCfdiNull();
             }
	        }
        public String DescripcionUsoCfdi {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["DescripcionUsoCfdi"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionUsoCfdi;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionUsoCfdi = value;
               }
	          }
        public bool IsDescripcionUsoCfdiNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsDescripcionUsoCfdiNull();
             }
	        }
        public String DescripcionMetodoPago {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["DescripcionMetodoPago"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionMetodoPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].DescripcionMetodoPago = value;
               }
	          }
        public bool IsDescripcionMetodoPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsDescripcionMetodoPagoNull();
             }
	        }
        public String N_MetodoPago {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["N_MetodoPago"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].N_MetodoPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].N_MetodoPago = value;
               }
	          }
        public bool IsN_MetodoPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsN_MetodoPagoNull();
             }
	        }
        public Boolean Timbrar {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Timbrar"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Timbrar;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Timbrar = value;
               }
	          }
        public bool IsTimbrarNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsTimbrarNull();
             }
	        }
        public String SegmentoStr {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["SegmentoStr"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].SegmentoStr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].SegmentoStr = value;
               }
	          }
        public bool IsSegmentoStrNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmentoStrNull();
             }
	        }
        public String Segmento_IdFact {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento_IdFact"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento_IdFact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento_IdFact = value;
               }
	          }
        public bool IsSegmento_IdFactNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento_IdFactNull();
             }
	        }
        public Int32 Segmento1NFact {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento1NFact"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento1NFact;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento1NFact = value;
               }
	          }
        public bool IsSegmento1NFactNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento1NFactNull();
             }
	        }
        public Int32 Segmento2NFact {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento2NFact"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento2NFact;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento2NFact = value;
               }
	          }
        public bool IsSegmento2NFactNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento2NFactNull();
             }
	        }
        public Int32 Segmento3NFact {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento3NFact"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento3NFact;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento3NFact = value;
               }
	          }
        public bool IsSegmento3NFactNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento3NFactNull();
             }
	        }
        public Int32 Segmento4NFact {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento4NFact"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento4NFact;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento4NFact = value;
               }
	          }
        public bool IsSegmento4NFactNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento4NFactNull();
             }
	        }
        public String Segmento1CFact {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento1CFact"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento1CFact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento1CFact = value;
               }
	          }
        public bool IsSegmento1CFactNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento1CFactNull();
             }
	        }
        public String Segmento2CFact {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento2CFact"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento2CFact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento2CFact = value;
               }
	          }
        public bool IsSegmento2CFactNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento2CFactNull();
             }
	        }
        public String Segmento3CFact {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento3CFact"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento3CFact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento3CFact = value;
               }
	          }
        public bool IsSegmento3CFactNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento3CFactNull();
             }
	        }
        public String Segmento4CFact {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento4CFact"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento4CFact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento4CFact = value;
               }
	          }
        public bool IsSegmento4CFactNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento4CFactNull();
             }
	        }
        public String ArchivoPDF {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["ArchivoPDF"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].ArchivoPDF;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].ArchivoPDF = value;
               }
	          }
        public bool IsArchivoPDFNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsArchivoPDFNull();
             }
	        }
        public String ArchivoXML {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["ArchivoXML"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].ArchivoXML;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].ArchivoXML = value;
               }
	          }
        public bool IsArchivoXMLNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsArchivoXMLNull();
             }
	        }
        public String Segmento_IdNC {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento_IdNC"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento_IdNC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento_IdNC = value;
               }
	          }
        public bool IsSegmento_IdNCNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento_IdNCNull();
             }
	        }
        public Int32 Segmento1NNC {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento1NNC"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento1NNC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento1NNC = value;
               }
	          }
        public bool IsSegmento1NNCNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento1NNCNull();
             }
	        }
        public Int32 Segmento2NNC {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento2NNC"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento2NNC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento2NNC = value;
               }
	          }
        public bool IsSegmento2NNCNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento2NNCNull();
             }
	        }
        public Int32 Segmento3NNC {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento3NNC"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento3NNC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento3NNC = value;
               }
	          }
        public bool IsSegmento3NNCNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento3NNCNull();
             }
	        }
        public Int32 Segmento4NNC {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento4NNC"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento4NNC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento4NNC = value;
               }
	          }
        public bool IsSegmento4NNCNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento4NNCNull();
             }
	        }
        public String Segmento1CNC {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento1CNC"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento1CNC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento1CNC = value;
               }
	          }
        public bool IsSegmento1CNCNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento1CNCNull();
             }
	        }
        public String Segmento2CNC {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento2CNC"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento2CNC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento2CNC = value;
               }
	          }
        public bool IsSegmento2CNCNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento2CNCNull();
             }
	        }
        public String Segmento3CNC {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento3CNC"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento3CNC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento3CNC = value;
               }
	          }
        public bool IsSegmento3CNCNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento3CNCNull();
             }
	        }
        public String Segmento4CNC {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento4CNC"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento4CNC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento4CNC = value;
               }
	          }
        public bool IsSegmento4CNCNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento4CNCNull();
             }
	        }
        public String ArchivoPDFNC {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["ArchivoPDFNC"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].ArchivoPDFNC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].ArchivoPDFNC = value;
               }
	          }
        public bool IsArchivoPDFNCNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsArchivoPDFNCNull();
             }
	        }
        public String ArchivoXMLNC {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["ArchivoXMLNC"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].ArchivoXMLNC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].ArchivoXMLNC = value;
               }
	          }
        public bool IsArchivoXMLNCNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsArchivoXMLNCNull();
             }
	        }
        public String Segmento_IdRem {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento_IdRem"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento_IdRem;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento_IdRem = value;
               }
	          }
        public bool IsSegmento_IdRemNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento_IdRemNull();
             }
	        }
        public Int32 Segmento1NRem {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento1NRem"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento1NRem;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento1NRem = value;
               }
	          }
        public bool IsSegmento1NRemNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento1NRemNull();
             }
	        }
        public Int32 Segmento2NRem {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento2NRem"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento2NRem;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento2NRem = value;
               }
	          }
        public bool IsSegmento2NRemNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento2NRemNull();
             }
	        }
        public Int32 Segmento3NRem {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento3NRem"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento3NRem;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento3NRem = value;
               }
	          }
        public bool IsSegmento3NRemNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento3NRemNull();
             }
	        }
        public Int32 Segmento4NRem {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento4NRem"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento4NRem;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento4NRem = value;
               }
	          }
        public bool IsSegmento4NRemNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento4NRemNull();
             }
	        }
        public String Segmento1CRem {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento1CRem"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento1CRem;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento1CRem = value;
               }
	          }
        public bool IsSegmento1CRemNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento1CRemNull();
             }
	        }
        public String Segmento2CRem {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento2CRem"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento2CRem;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento2CRem = value;
               }
	          }
        public bool IsSegmento2CRemNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento2CRemNull();
             }
	        }
        public String Segmento3CRem {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento3CRem"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento3CRem;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento3CRem = value;
               }
	          }
        public bool IsSegmento3CRemNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento3CRemNull();
             }
	        }
        public String Segmento4CRem {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Segmento4CRem"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento4CRem;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Segmento4CRem = value;
               }
	          }
        public bool IsSegmento4CRemNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsSegmento4CRemNull();
             }
	        }
        public String ArchivoPDFRem {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["ArchivoPDFRem"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].ArchivoPDFRem;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].ArchivoPDFRem = value;
               }
	          }
        public bool IsArchivoPDFRemNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsArchivoPDFRemNull();
             }
	        }
        public String ArchivoXMLRem {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["ArchivoXMLRem"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].ArchivoXMLRem;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].ArchivoXMLRem = value;
               }
	          }
        public bool IsArchivoXMLRemNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsArchivoXMLRemNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venFacturacionPedidoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venFacturacionPedidoDS );
     }
     public venFacturacionPedidoActionExchange() : base( "venFacturacionPedido" ) {
     }

     public venFacturacionPedidoActionExchange(venFacturacionPedidoActionEnum.EnumvenFacturacionPedidoAction pAccion) : base(venFacturacionPedidoActionEnum.GetAccionvenFacturacionPedidoAction(pAccion)) {
     }

     public venFacturacionPedidoActionExchange(venFacturacionPedidoActionEnum.EnumvenFacturacionPedidoAction pAccion, VentasCommon.venFacturacionPedidoDS pdsParam) : base(venFacturacionPedidoActionEnum.GetAccionvenFacturacionPedidoAction(pAccion), pdsParam) {
     }

     public venFacturacionPedidoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venFacturacionPedidoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venFacturacionPedidoActionExchange(VentasCommon.venFacturacionPedidoDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venFacturacionPedidoDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venFacturacionPedidoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venFacturacionPedidoDS)mParam;
	        }
     }
  }
}
