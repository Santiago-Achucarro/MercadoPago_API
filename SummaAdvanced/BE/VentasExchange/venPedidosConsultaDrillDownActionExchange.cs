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
    public class venPedidosConsultaDrillDownActionExchange : Framework.Core.Exchange{

        public Int32 venPedidos {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["venPedidos"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].venPedidos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].venPedidos = value;
               }
	          }
        public bool IsvenPedidosNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsvenPedidosNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String Segmento {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Segmento"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Segmento;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Segmento = value;
               }
	          }
        public bool IsSegmentoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsSegmentoNull();
             }
	        }
        public String SubTipoMov_Id {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["SubTipoMov_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].SubTipoMov_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].SubTipoMov_Id = value;
               }
	          }
        public bool IsSubTipoMov_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsSubTipoMov_IdNull();
             }
	        }
        public String DescripcionSubTipoMov {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["DescripcionSubTipoMov"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionSubTipoMov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionSubTipoMov = value;
               }
	          }
        public bool IsDescripcionSubTipoMovNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionSubTipoMovNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public Int32 Sucursal {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public String NombreFantasia {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["NombreFantasia"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].NombreFantasia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].NombreFantasia = value;
               }
	          }
        public bool IsNombreFantasiaNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsNombreFantasiaNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public String MonedaFacturacion {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["MonedaFacturacion"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].MonedaFacturacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].MonedaFacturacion = value;
               }
	          }
        public bool IsMonedaFacturacionNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsMonedaFacturacionNull();
             }
	        }
        public String DescripcionMonFacturacion {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["DescripcionMonFacturacion"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionMonFacturacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionMonFacturacion = value;
               }
	          }
        public bool IsDescripcionMonFacturacionNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionMonFacturacionNull();
             }
	        }
        public String CondPagoCli_Id {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["CondPagoCli_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].CondPagoCli_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].CondPagoCli_Id = value;
               }
	          }
        public bool IsCondPagoCli_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsCondPagoCli_IdNull();
             }
	        }
        public String DescripcionCondPago {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["DescripcionCondPago"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionCondPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionCondPago = value;
               }
	          }
        public bool IsDescripcionCondPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionCondPagoNull();
             }
	        }
        public String ListaPrecio_Id {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["ListaPrecio_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].ListaPrecio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].ListaPrecio_Id = value;
               }
	          }
        public bool IsListaPrecio_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsListaPrecio_IdNull();
             }
	        }
        public String DescripcionListasPrecios {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["DescripcionListasPrecios"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionListasPrecios;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionListasPrecios = value;
               }
	          }
        public bool IsDescripcionListasPreciosNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionListasPreciosNull();
             }
	        }
        public String Vendedor_Id {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Vendedor_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Vendedor_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Vendedor_Id = value;
               }
	          }
        public bool IsVendedor_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsVendedor_IdNull();
             }
	        }
        public String DescripcionVendedores {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["DescripcionVendedores"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionVendedores;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionVendedores = value;
               }
	          }
        public bool IsDescripcionVendedoresNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionVendedoresNull();
             }
	        }
        public String FormaEntrega_Id {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["FormaEntrega_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].FormaEntrega_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].FormaEntrega_Id = value;
               }
	          }
        public bool IsFormaEntrega_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsFormaEntrega_IdNull();
             }
	        }
        public String DescripcionFormaEntrega {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["DescripcionFormaEntrega"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionFormaEntrega;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionFormaEntrega = value;
               }
	          }
        public bool IsDescripcionFormaEntregaNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionFormaEntregaNull();
             }
	        }
        public String Estado {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Estado"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Estado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Estado = value;
               }
	          }
        public bool IsEstadoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsEstadoNull();
             }
	        }
        public String UsuarioAutoriz_Id {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["UsuarioAutoriz_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].UsuarioAutoriz_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].UsuarioAutoriz_Id = value;
               }
	          }
        public bool IsUsuarioAutoriz_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsUsuarioAutoriz_IdNull();
             }
	        }
        public String DescripcionUsuarioAutoriz {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["DescripcionUsuarioAutoriz"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionUsuarioAutoriz;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionUsuarioAutoriz = value;
               }
	          }
        public bool IsDescripcionUsuarioAutorizNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionUsuarioAutorizNull();
             }
	        }
        public DateTime FechaAutorizo {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["FechaAutorizo"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].FechaAutorizo;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].FechaAutorizo = value;
               }
	          }
        public bool IsFechaAutorizoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsFechaAutorizoNull();
             }
	        }
        public String Observaciones {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public String ObservEstado {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["ObservEstado"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].ObservEstado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].ObservEstado = value;
               }
	          }
        public bool IsObservEstadoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsObservEstadoNull();
             }
	        }
        public Int16 Motivo_Id {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Motivo_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Motivo_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Motivo_Id = value;
               }
	          }
        public bool IsMotivo_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsMotivo_IdNull();
             }
	        }
        public Decimal ImporteTotal {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["ImporteTotal"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].ImporteTotal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].ImporteTotal = value;
               }
	          }
        public bool IsImporteTotalNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsImporteTotalNull();
             }
	        }
        public Decimal Bonificacion1 {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Bonificacion1"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Bonificacion1;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Bonificacion1 = value;
               }
	          }
        public bool IsBonificacion1Null {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsBonificacion1Null();
             }
	        }
        public Decimal Bonificacion2 {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Bonificacion2"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Bonificacion2;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Bonificacion2 = value;
               }
	          }
        public bool IsBonificacion2Null {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsBonificacion2Null();
             }
	        }
        public Decimal Bonificacion3 {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Bonificacion3"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Bonificacion3;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Bonificacion3 = value;
               }
	          }
        public bool IsBonificacion3Null {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsBonificacion3Null();
             }
	        }
        public Decimal Bonificacion4 {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Bonificacion4"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Bonificacion4;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Bonificacion4 = value;
               }
	          }
        public bool IsBonificacion4Null {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsBonificacion4Null();
             }
	        }
        public Decimal Bonificacion5 {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Bonificacion5"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Bonificacion5;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Bonificacion5 = value;
               }
	          }
        public bool IsBonificacion5Null {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsBonificacion5Null();
             }
	        }
        public Decimal Dato1 {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Dato1"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Dato1;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Dato1 = value;
               }
	          }
        public bool IsDato1Null {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsDato1Null();
             }
	        }
        public Decimal Dato2 {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Dato2"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Dato2;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Dato2 = value;
               }
	          }
        public bool IsDato2Null {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsDato2Null();
             }
	        }
        public Decimal Dato3 {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Dato3"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Dato3;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Dato3 = value;
               }
	          }
        public bool IsDato3Null {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsDato3Null();
             }
	        }
        public DateTime FechaUltMod {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["FechaUltMod"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].FechaUltMod;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].FechaUltMod = value;
               }
	          }
        public bool IsFechaUltModNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsFechaUltModNull();
             }
	        }
        public String CliOrdenCompra {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["CliOrdenCompra"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].CliOrdenCompra;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].CliOrdenCompra = value;
               }
	          }
        public bool IsCliOrdenCompraNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsCliOrdenCompraNull();
             }
	        }
        public String venNroPedido {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["venNroPedido"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].venNroPedido;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].venNroPedido = value;
               }
	          }
        public bool IsvenNroPedidoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsvenNroPedidoNull();
             }
	        }
        public Boolean FacturaAnticipo {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["FacturaAnticipo"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].FacturaAnticipo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].FacturaAnticipo = value;
               }
	          }
        public bool IsFacturaAnticipoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsFacturaAnticipoNull();
             }
	        }
        public Boolean TrabaDespacho {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["TrabaDespacho"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].TrabaDespacho;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].TrabaDespacho = value;
               }
	          }
        public bool IsTrabaDespachoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsTrabaDespachoNull();
             }
	        }
        public Decimal PorAnticipo {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["PorAnticipo"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].PorAnticipo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].PorAnticipo = value;
               }
	          }
        public bool IsPorAnticipoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsPorAnticipoNull();
             }
	        }
        public Decimal Anticipo {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Anticipo"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Anticipo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Anticipo = value;
               }
	          }
        public bool IsAnticipoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsAnticipoNull();
             }
	        }
        public Decimal AnticipoPendiente {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["AnticipoPendiente"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].AnticipoPendiente;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].AnticipoPendiente = value;
               }
	          }
        public bool IsAnticipoPendienteNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsAnticipoPendienteNull();
             }
	        }
        public String ObsAnticipo {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["ObsAnticipo"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].ObsAnticipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].ObsAnticipo = value;
               }
	          }
        public bool IsObsAnticipoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsObsAnticipoNull();
             }
	        }
        public String TipoPrecioForm {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["TipoPrecioForm"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].TipoPrecioForm;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].TipoPrecioForm = value;
               }
	          }
        public bool IsTipoPrecioFormNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsTipoPrecioFormNull();
             }
	        }
        public Boolean CongelaCambio {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["CongelaCambio"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].CongelaCambio;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].CongelaCambio = value;
               }
	          }
        public bool IsCongelaCambioNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsCongelaCambioNull();
             }
	        }
        public DateTime Fecha_Registro {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Fecha_Registro"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Fecha_Registro;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Fecha_Registro = value;
               }
	          }
        public bool IsFecha_RegistroNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsFecha_RegistroNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public String Incoterm_Id {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Incoterm_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Incoterm_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Incoterm_Id = value;
               }
	          }
        public bool IsIncoterm_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsIncoterm_IdNull();
             }
	        }
        public String DescripcionIncoterm {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["DescripcionIncoterm"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionIncoterm;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionIncoterm = value;
               }
	          }
        public bool IsDescripcionIncotermNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionIncotermNull();
             }
	        }
        public Boolean SoloEntrega {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["SoloEntrega"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].SoloEntrega;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].SoloEntrega = value;
               }
	          }
        public bool IsSoloEntregaNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsSoloEntregaNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String MetodoPago {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["MetodoPago"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].MetodoPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].MetodoPago = value;
               }
	          }
        public bool IsMetodoPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsMetodoPagoNull();
             }
	        }
        public String UsoCfdi {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["UsoCfdi"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].UsoCfdi;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].UsoCfdi = value;
               }
	          }
        public bool IsUsoCfdiNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsUsoCfdiNull();
             }
	        }
        public String DescripcionUsoCfdi {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["DescripcionUsoCfdi"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionUsoCfdi;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionUsoCfdi = value;
               }
	          }
        public bool IsDescripcionUsoCfdiNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionUsoCfdiNull();
             }
	        }
        public String DescripcionMetodoPago {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["DescripcionMetodoPago"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionMetodoPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].DescripcionMetodoPago = value;
               }
	          }
        public bool IsDescripcionMetodoPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionMetodoPagoNull();
             }
	        }
        public Decimal SubTotal {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["SubTotal"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].SubTotal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].SubTotal = value;
               }
	          }
        public bool IsSubTotalNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsSubTotalNull();
             }
	        }
        public Decimal SubTotalBonif {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["SubTotalBonif"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].SubTotalBonif;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].SubTotalBonif = value;
               }
	          }
        public bool IsSubTotalBonifNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsSubTotalBonifNull();
             }
	        }
        public String SucursalUsu {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["SucursalUsu"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].SucursalUsu;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].SucursalUsu = value;
               }
	          }
        public bool IsSucursalUsuNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsSucursalUsuNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosConsultaDrillDownDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venPedidosConsultaDrillDownDS );
     }
     public venPedidosConsultaDrillDownActionExchange() : base( "venPedidosConsultaDrillDown" ) {
     }

     public venPedidosConsultaDrillDownActionExchange(venPedidosConsultaDrillDownActionEnum.EnumvenPedidosConsultaDrillDownAction pAccion) : base(venPedidosConsultaDrillDownActionEnum.GetAccionvenPedidosConsultaDrillDownAction(pAccion)) {
     }

     public venPedidosConsultaDrillDownActionExchange(venPedidosConsultaDrillDownActionEnum.EnumvenPedidosConsultaDrillDownAction pAccion, VentasCommon.venPedidosConsultaDrillDownDS pdsParam) : base(venPedidosConsultaDrillDownActionEnum.GetAccionvenPedidosConsultaDrillDownAction(pAccion), pdsParam) {
     }

     public venPedidosConsultaDrillDownActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venPedidosConsultaDrillDownDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venPedidosConsultaDrillDownDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venPedidosConsultaDrillDownDS)mParam;
	        }
     }
  }
}
