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
    public class venMovimientosConsultaDrillDownActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String venTipoMov {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["venTipoMov"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].venTipoMov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].venTipoMov = value;
               }
	          }
        public bool IsvenTipoMovNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsvenTipoMovNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public DateTime FechaRegistro {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["FechaRegistro"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].FechaRegistro;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].FechaRegistro = value;
               }
	          }
        public bool IsFechaRegistroNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsFechaRegistroNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public Decimal CambioMonedaOriginal {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["CambioMonedaOriginal"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].CambioMonedaOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].CambioMonedaOriginal = value;
               }
	          }
        public bool IsCambioMonedaOriginalNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsCambioMonedaOriginalNull();
             }
	        }
        public Boolean Anulado {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Anulado"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Anulado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Anulado = value;
               }
	          }
        public bool IsAnuladoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsAnuladoNull();
             }
	        }
        public String Observaciones {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public Int32 Sucursal {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public String NombreFantasia {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["NombreFantasia"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].NombreFantasia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].NombreFantasia = value;
               }
	          }
        public bool IsNombreFantasiaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsNombreFantasiaNull();
             }
	        }
        public String SubTipoMov_Id {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["SubTipoMov_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].SubTipoMov_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].SubTipoMov_Id = value;
               }
	          }
        public bool IsSubTipoMov_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsSubTipoMov_IdNull();
             }
	        }
        public String DescripcionSubTipoMov {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["DescripcionSubTipoMov"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].DescripcionSubTipoMov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].DescripcionSubTipoMov = value;
               }
	          }
        public bool IsDescripcionSubTipoMovNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionSubTipoMovNull();
             }
	        }
        public String CondPagoCli_Id {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["CondPagoCli_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].CondPagoCli_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].CondPagoCli_Id = value;
               }
	          }
        public bool IsCondPagoCli_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsCondPagoCli_IdNull();
             }
	        }
        public String DescripcionCondPago {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["DescripcionCondPago"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].DescripcionCondPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].DescripcionCondPago = value;
               }
	          }
        public bool IsDescripcionCondPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionCondPagoNull();
             }
	        }
        public String Vendedor_Id {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Vendedor_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Vendedor_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Vendedor_Id = value;
               }
	          }
        public bool IsVendedor_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsVendedor_IdNull();
             }
	        }
        public String DescripcionVendedores {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["DescripcionVendedores"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].DescripcionVendedores;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].DescripcionVendedores = value;
               }
	          }
        public bool IsDescripcionVendedoresNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionVendedoresNull();
             }
	        }
        public String Cobrador_Id {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Cobrador_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Cobrador_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Cobrador_Id = value;
               }
	          }
        public bool IsCobrador_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsCobrador_IdNull();
             }
	        }
        public String DescripcionCobradores {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["DescripcionCobradores"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].DescripcionCobradores;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].DescripcionCobradores = value;
               }
	          }
        public bool IsDescripcionCobradoresNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionCobradoresNull();
             }
	        }
        public String FormaEntrega_Id {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["FormaEntrega_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].FormaEntrega_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].FormaEntrega_Id = value;
               }
	          }
        public bool IsFormaEntrega_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsFormaEntrega_IdNull();
             }
	        }
        public String DescripcionFormaEntrega {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["DescripcionFormaEntrega"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].DescripcionFormaEntrega;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].DescripcionFormaEntrega = value;
               }
	          }
        public bool IsDescripcionFormaEntregaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionFormaEntregaNull();
             }
	        }
        public String CondFisc_Id {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["CondFisc_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].CondFisc_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].CondFisc_Id = value;
               }
	          }
        public bool IsCondFisc_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsCondFisc_IdNull();
             }
	        }
        public String DescripcionCondFiscal {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["DescripcionCondFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].DescripcionCondFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].DescripcionCondFiscal = value;
               }
	          }
        public bool IsDescripcionCondFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionCondFiscalNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Decimal Saldo {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Saldo"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Saldo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Saldo = value;
               }
	          }
        public bool IsSaldoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsSaldoNull();
             }
	        }
        public Decimal SubTotal {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["SubTotal"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].SubTotal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].SubTotal = value;
               }
	          }
        public bool IsSubTotalNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsSubTotalNull();
             }
	        }
        public Decimal SubTotalBonif {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["SubTotalBonif"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].SubTotalBonif;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].SubTotalBonif = value;
               }
	          }
        public bool IsSubTotalBonifNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsSubTotalBonifNull();
             }
	        }
        public Decimal Comision1 {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Comision1"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Comision1;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Comision1 = value;
               }
	          }
        public bool IsComision1Null {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsComision1Null();
             }
	        }
        public Decimal Comision2 {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Comision2"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Comision2;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Comision2 = value;
               }
	          }
        public bool IsComision2Null {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsComision2Null();
             }
	        }
        public Decimal Bonificacion1 {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Bonificacion1"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Bonificacion1;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Bonificacion1 = value;
               }
	          }
        public bool IsBonificacion1Null {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsBonificacion1Null();
             }
	        }
        public Decimal Bonificacion2 {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Bonificacion2"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Bonificacion2;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Bonificacion2 = value;
               }
	          }
        public bool IsBonificacion2Null {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsBonificacion2Null();
             }
	        }
        public Decimal Bonificacion3 {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Bonificacion3"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Bonificacion3;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Bonificacion3 = value;
               }
	          }
        public bool IsBonificacion3Null {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsBonificacion3Null();
             }
	        }
        public Decimal Bonificacion4 {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Bonificacion4"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Bonificacion4;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Bonificacion4 = value;
               }
	          }
        public bool IsBonificacion4Null {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsBonificacion4Null();
             }
	        }
        public Decimal Bonificacion5 {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Bonificacion5"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Bonificacion5;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Bonificacion5 = value;
               }
	          }
        public bool IsBonificacion5Null {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsBonificacion5Null();
             }
	        }
        public Decimal Dato1 {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Dato1"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Dato1;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Dato1 = value;
               }
	          }
        public bool IsDato1Null {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsDato1Null();
             }
	        }
        public Decimal Dato2 {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Dato2"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Dato2;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Dato2 = value;
               }
	          }
        public bool IsDato2Null {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsDato2Null();
             }
	        }
        public Decimal Dato3 {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Dato3"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Dato3;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Dato3 = value;
               }
	          }
        public bool IsDato3Null {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsDato3Null();
             }
	        }
        public Boolean CobraAbasto {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["CobraAbasto"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].CobraAbasto;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].CobraAbasto = value;
               }
	          }
        public bool IsCobraAbastoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsCobraAbastoNull();
             }
	        }
        public Boolean CambioFijo {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["CambioFijo"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].CambioFijo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].CambioFijo = value;
               }
	          }
        public bool IsCambioFijoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsCambioFijoNull();
             }
	        }
        public Int32 ComprobanteDesde {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["ComprobanteDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].ComprobanteDesde;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].ComprobanteDesde = value;
               }
	          }
        public bool IsComprobanteDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsComprobanteDesdeNull();
             }
	        }
        public Int32 TipoPago {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["TipoPago"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].TipoPago;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].TipoPago = value;
               }
	          }
        public bool IsTipoPagoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsTipoPagoNull();
             }
	        }
        public String Incoterm_Id {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Incoterm_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Incoterm_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Incoterm_Id = value;
               }
	          }
        public bool IsIncoterm_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsIncoterm_IdNull();
             }
	        }
        public String DescripcionIncoterm {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["DescripcionIncoterm"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].DescripcionIncoterm;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].DescripcionIncoterm = value;
               }
	          }
        public bool IsDescripcionIncotermNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionIncotermNull();
             }
	        }
        public String CtaClientes {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["CtaClientes"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].CtaClientes;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].CtaClientes = value;
               }
	          }
        public bool IsCtaClientesNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsCtaClientesNull();
             }
	        }
        public String DescripcionCtaClientes {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["DescripcionCtaClientes"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].DescripcionCtaClientes;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].DescripcionCtaClientes = value;
               }
	          }
        public bool IsDescripcionCtaClientesNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionCtaClientesNull();
             }
	        }
        public String Centro1DXV_Id {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Centro1DXV_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Centro1DXV_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Centro1DXV_Id = value;
               }
	          }
        public bool IsCentro1DXV_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsCentro1DXV_IdNull();
             }
	        }
        public String DescripcionCentro1DXV {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["DescripcionCentro1DXV"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].DescripcionCentro1DXV;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].DescripcionCentro1DXV = value;
               }
	          }
        public bool IsDescripcionCentro1DXVNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionCentro1DXVNull();
             }
	        }
        public String Centro2DXV_Id {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Centro2DXV_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Centro2DXV_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Centro2DXV_Id = value;
               }
	          }
        public bool IsCentro2DXV_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsCentro2DXV_IdNull();
             }
	        }
        public String DescripcionCentro2DXV {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["DescripcionCentro2DXV"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].DescripcionCentro2DXV;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].DescripcionCentro2DXV = value;
               }
	          }
        public bool IsDescripcionCentro2DXVNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsDescripcionCentro2DXVNull();
             }
	        }
        public Decimal TipomovCont {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["TipomovCont"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].TipomovCont;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].TipomovCont = value;
               }
	          }
        public bool IsTipomovContNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsTipomovContNull();
             }
	        }
        public String Clase {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Clase"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Clase;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Clase = value;
               }
	          }
        public bool IsClaseNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsClaseNull();
             }
	        }
        public Decimal ImporteContable {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["ImporteContable"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].ImporteContable;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].ImporteContable = value;
               }
	          }
        public bool IsImporteContableNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsImporteContableNull();
             }
	        }
        public Int16 CantCuotas {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["CantCuotas"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].CantCuotas;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].CantCuotas = value;
               }
	          }
        public bool IsCantCuotasNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsCantCuotasNull();
             }
	        }
        public String Formulario_Id {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Formulario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Formulario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Formulario_Id = value;
               }
	          }
        public bool IsFormulario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsFormulario_IdNull();
             }
	        }
        public Boolean LlamarAlWSFE {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["LlamarAlWSFE"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].LlamarAlWSFE;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].LlamarAlWSFE = value;
               }
	          }
        public bool IsLlamarAlWSFENull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsLlamarAlWSFENull();
             }
	        }
        public String SegmentoStr {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["SegmentoStr"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].SegmentoStr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].SegmentoStr = value;
               }
	          }
        public bool IsSegmentoStrNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsSegmentoStrNull();
             }
	        }
        public String SucursalEmpr {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["SucursalEmpr"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].SucursalEmpr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].SucursalEmpr = value;
               }
	          }
        public bool IsSucursalEmprNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsSucursalEmprNull();
             }
	        }
        public Boolean NoRecalcular {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["NoRecalcular"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].NoRecalcular;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].NoRecalcular = value;
               }
	          }
        public bool IsNoRecalcularNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsNoRecalcularNull();
             }
	        }
        public Boolean SinEntrega {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["SinEntrega"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].SinEntrega;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].SinEntrega = value;
               }
	          }
        public bool IsSinEntregaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsSinEntregaNull();
             }
	        }
        public Boolean EsSaldoInicial {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["EsSaldoInicial"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].EsSaldoInicial;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].EsSaldoInicial = value;
               }
	          }
        public bool IsEsSaldoInicialNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsEsSaldoInicialNull();
             }
	        }
        public Boolean AceptarDatosExternos {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["AceptarDatosExternos"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].AceptarDatosExternos;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].AceptarDatosExternos = value;
               }
	          }
        public bool IsAceptarDatosExternosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsAceptarDatosExternosNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosConsultaDrillDownDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMovimientosConsultaDrillDownDS );
     }
     public venMovimientosConsultaDrillDownActionExchange() : base( "venMovimientosConsultaDrillDown" ) {
     }

     public venMovimientosConsultaDrillDownActionExchange(venMovimientosConsultaDrillDownActionEnum.EnumvenMovimientosConsultaDrillDownAction pAccion) : base(venMovimientosConsultaDrillDownActionEnum.GetAccionvenMovimientosConsultaDrillDownAction(pAccion)) {
     }

     public venMovimientosConsultaDrillDownActionExchange(venMovimientosConsultaDrillDownActionEnum.EnumvenMovimientosConsultaDrillDownAction pAccion, VentasCommon.venMovimientosConsultaDrillDownDS pdsParam) : base(venMovimientosConsultaDrillDownActionEnum.GetAccionvenMovimientosConsultaDrillDownAction(pAccion), pdsParam) {
     }

     public venMovimientosConsultaDrillDownActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMovimientosConsultaDrillDownDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMovimientosConsultaDrillDownDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMovimientosConsultaDrillDownDS)mParam;
	        }
     }
  }
}
