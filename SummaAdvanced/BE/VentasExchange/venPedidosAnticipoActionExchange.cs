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
    public class venPedidosAnticipoActionExchange : Framework.Core.Exchange{

        public Int32 venPedidos {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["venPedidos"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].venPedidos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].venPedidos = value;
               }
	          }
        public bool IsvenPedidosNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsvenPedidosNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String SubTipoMov_Id {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["SubTipoMov_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].SubTipoMov_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].SubTipoMov_Id = value;
               }
	          }
        public bool IsSubTipoMov_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsSubTipoMov_IdNull();
             }
	        }
        public String DescripcionSubTipoMov {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["DescripcionSubTipoMov"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].DescripcionSubTipoMov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].DescripcionSubTipoMov = value;
               }
	          }
        public bool IsDescripcionSubTipoMovNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsDescripcionSubTipoMovNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public DateTime FechaFactura {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["FechaFactura"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].FechaFactura;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].FechaFactura = value;
               }
	          }
        public bool IsFechaFacturaNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsFechaFacturaNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public Int32 Sucursal {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public String NombreFantasia {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["NombreFantasia"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].NombreFantasia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].NombreFantasia = value;
               }
	          }
        public bool IsNombreFantasiaNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsNombreFantasiaNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public String MonedaFacturacion {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["MonedaFacturacion"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].MonedaFacturacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].MonedaFacturacion = value;
               }
	          }
        public bool IsMonedaFacturacionNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsMonedaFacturacionNull();
             }
	        }
        public String DescripcionMonFacturacion {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["DescripcionMonFacturacion"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].DescripcionMonFacturacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].DescripcionMonFacturacion = value;
               }
	          }
        public bool IsDescripcionMonFacturacionNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsDescripcionMonFacturacionNull();
             }
	        }
        public String CondPagoCli_Id {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["CondPagoCli_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].CondPagoCli_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].CondPagoCli_Id = value;
               }
	          }
        public bool IsCondPagoCli_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsCondPagoCli_IdNull();
             }
	        }
        public String DescripcionCondPago {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["DescripcionCondPago"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].DescripcionCondPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].DescripcionCondPago = value;
               }
	          }
        public bool IsDescripcionCondPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsDescripcionCondPagoNull();
             }
	        }
        public String ListaPrecio_Id {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["ListaPrecio_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].ListaPrecio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].ListaPrecio_Id = value;
               }
	          }
        public bool IsListaPrecio_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsListaPrecio_IdNull();
             }
	        }
        public String DescripcionListasPrecios {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["DescripcionListasPrecios"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].DescripcionListasPrecios;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].DescripcionListasPrecios = value;
               }
	          }
        public bool IsDescripcionListasPreciosNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsDescripcionListasPreciosNull();
             }
	        }
        public String Vendedor_Id {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Vendedor_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Vendedor_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Vendedor_Id = value;
               }
	          }
        public bool IsVendedor_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsVendedor_IdNull();
             }
	        }
        public String DescripcionVendedores {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["DescripcionVendedores"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].DescripcionVendedores;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].DescripcionVendedores = value;
               }
	          }
        public bool IsDescripcionVendedoresNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsDescripcionVendedoresNull();
             }
	        }
        public String FormaEntrega_Id {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["FormaEntrega_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].FormaEntrega_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].FormaEntrega_Id = value;
               }
	          }
        public bool IsFormaEntrega_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsFormaEntrega_IdNull();
             }
	        }
        public String DescripcionFormaEntrega {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["DescripcionFormaEntrega"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].DescripcionFormaEntrega;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].DescripcionFormaEntrega = value;
               }
	          }
        public bool IsDescripcionFormaEntregaNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsDescripcionFormaEntregaNull();
             }
	        }
        public String Estado {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Estado"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Estado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Estado = value;
               }
	          }
        public bool IsEstadoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsEstadoNull();
             }
	        }
        public String UsuarioAutoriz_Id {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["UsuarioAutoriz_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].UsuarioAutoriz_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].UsuarioAutoriz_Id = value;
               }
	          }
        public bool IsUsuarioAutoriz_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsUsuarioAutoriz_IdNull();
             }
	        }
        public String DescripcionUsuarioAutoriz {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["DescripcionUsuarioAutoriz"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].DescripcionUsuarioAutoriz;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].DescripcionUsuarioAutoriz = value;
               }
	          }
        public bool IsDescripcionUsuarioAutorizNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsDescripcionUsuarioAutorizNull();
             }
	        }
        public DateTime FechaAutorizo {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["FechaAutorizo"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].FechaAutorizo;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].FechaAutorizo = value;
               }
	          }
        public bool IsFechaAutorizoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsFechaAutorizoNull();
             }
	        }
        public String Observaciones {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public Decimal ImporteTotal {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["ImporteTotal"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].ImporteTotal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].ImporteTotal = value;
               }
	          }
        public bool IsImporteTotalNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsImporteTotalNull();
             }
	        }
        public String CliOrdenCompra {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["CliOrdenCompra"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].CliOrdenCompra;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].CliOrdenCompra = value;
               }
	          }
        public bool IsCliOrdenCompraNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsCliOrdenCompraNull();
             }
	        }
        public String venNroPedido {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["venNroPedido"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].venNroPedido;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].venNroPedido = value;
               }
	          }
        public bool IsvenNroPedidoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsvenNroPedidoNull();
             }
	        }
        public Boolean FacturaAnticipo {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["FacturaAnticipo"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].FacturaAnticipo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].FacturaAnticipo = value;
               }
	          }
        public bool IsFacturaAnticipoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsFacturaAnticipoNull();
             }
	        }
        public Decimal PorAnticipo {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["PorAnticipo"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].PorAnticipo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].PorAnticipo = value;
               }
	          }
        public bool IsPorAnticipoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsPorAnticipoNull();
             }
	        }
        public Decimal Anticipo {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Anticipo"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Anticipo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Anticipo = value;
               }
	          }
        public bool IsAnticipoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsAnticipoNull();
             }
	        }
        public Decimal AnticipoPendiente {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["AnticipoPendiente"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].AnticipoPendiente;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].AnticipoPendiente = value;
               }
	          }
        public bool IsAnticipoPendienteNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsAnticipoPendienteNull();
             }
	        }
        public String ObsAnticipo {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["ObsAnticipo"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].ObsAnticipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].ObsAnticipo = value;
               }
	          }
        public bool IsObsAnticipoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsObsAnticipoNull();
             }
	        }
        public Boolean CongelaCambio {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["CongelaCambio"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].CongelaCambio;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].CongelaCambio = value;
               }
	          }
        public bool IsCongelaCambioNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsCongelaCambioNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String MetodoPago {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["MetodoPago"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].MetodoPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].MetodoPago = value;
               }
	          }
        public bool IsMetodoPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsMetodoPagoNull();
             }
	        }
        public String UsoCfdi {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["UsoCfdi"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].UsoCfdi;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].UsoCfdi = value;
               }
	          }
        public bool IsUsoCfdiNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsUsoCfdiNull();
             }
	        }
        public String DescripcionUsoCfdi {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["DescripcionUsoCfdi"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].DescripcionUsoCfdi;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].DescripcionUsoCfdi = value;
               }
	          }
        public bool IsDescripcionUsoCfdiNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsDescripcionUsoCfdiNull();
             }
	        }
        public String DescripcionMetodoPago {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["DescripcionMetodoPago"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].DescripcionMetodoPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].DescripcionMetodoPago = value;
               }
	          }
        public bool IsDescripcionMetodoPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsDescripcionMetodoPagoNull();
             }
	        }
        public Boolean Timbrar {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Timbrar"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Timbrar;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Timbrar = value;
               }
	          }
        public bool IsTimbrarNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsTimbrarNull();
             }
	        }
        public String SegmentoStr {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["SegmentoStr"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].SegmentoStr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].SegmentoStr = value;
               }
	          }
        public bool IsSegmentoStrNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsSegmentoStrNull();
             }
	        }
        public String Segmento_IdFact {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Segmento_IdFact"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento_IdFact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento_IdFact = value;
               }
	          }
        public bool IsSegmento_IdFactNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsSegmento_IdFactNull();
             }
	        }
        public Int32 Segmento1NFact {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Segmento1NFact"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento1NFact;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento1NFact = value;
               }
	          }
        public bool IsSegmento1NFactNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsSegmento1NFactNull();
             }
	        }
        public Int32 Segmento2NFact {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Segmento2NFact"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento2NFact;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento2NFact = value;
               }
	          }
        public bool IsSegmento2NFactNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsSegmento2NFactNull();
             }
	        }
        public Int32 Segmento3NFact {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Segmento3NFact"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento3NFact;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento3NFact = value;
               }
	          }
        public bool IsSegmento3NFactNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsSegmento3NFactNull();
             }
	        }
        public Int32 Segmento4NFact {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Segmento4NFact"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento4NFact;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento4NFact = value;
               }
	          }
        public bool IsSegmento4NFactNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsSegmento4NFactNull();
             }
	        }
        public String Segmento1CFact {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Segmento1CFact"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento1CFact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento1CFact = value;
               }
	          }
        public bool IsSegmento1CFactNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsSegmento1CFactNull();
             }
	        }
        public String Segmento2CFact {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Segmento2CFact"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento2CFact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento2CFact = value;
               }
	          }
        public bool IsSegmento2CFactNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsSegmento2CFactNull();
             }
	        }
        public String Segmento3CFact {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Segmento3CFact"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento3CFact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento3CFact = value;
               }
	          }
        public bool IsSegmento3CFactNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsSegmento3CFactNull();
             }
	        }
        public String Segmento4CFact {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Segmento4CFact"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento4CFact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Segmento4CFact = value;
               }
	          }
        public bool IsSegmento4CFactNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsSegmento4CFactNull();
             }
	        }
        public String ArchivoPDF {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["ArchivoPDF"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].ArchivoPDF;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].ArchivoPDF = value;
               }
	          }
        public bool IsArchivoPDFNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsArchivoPDFNull();
             }
	        }
        public String ArchivoXML {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["ArchivoXML"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].ArchivoXML;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].ArchivoXML = value;
               }
	          }
        public bool IsArchivoXMLNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsArchivoXMLNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venPedidosAnticipoDS );
     }
     public venPedidosAnticipoActionExchange() : base( "venPedidosAnticipo" ) {
     }

     public venPedidosAnticipoActionExchange(venPedidosAnticipoActionEnum.EnumvenPedidosAnticipoAction pAccion) : base(venPedidosAnticipoActionEnum.GetAccionvenPedidosAnticipoAction(pAccion)) {
     }

     public venPedidosAnticipoActionExchange(venPedidosAnticipoActionEnum.EnumvenPedidosAnticipoAction pAccion, VentasCommon.venPedidosAnticipoDS pdsParam) : base(venPedidosAnticipoActionEnum.GetAccionvenPedidosAnticipoAction(pAccion), pdsParam) {
     }

     public venPedidosAnticipoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venPedidosAnticipoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venPedidosAnticipoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venPedidosAnticipoDS)mParam;
	        }
     }
  }
}
