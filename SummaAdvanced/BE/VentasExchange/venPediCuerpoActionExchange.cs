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
    public class venPediCuerpoActionExchange : Framework.Core.Exchange{

        public Int32 venPedidos {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["venPedidos"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].venPedidos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].venPedidos = value;
               }
	          }
        public bool IsvenPedidosNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsvenPedidosNull();
             }
	        }
        public Int32 Renglon_Pe {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["Renglon_Pe"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Renglon_Pe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Renglon_Pe = value;
               }
	          }
        public bool IsRenglon_PeNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsRenglon_PeNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String DescripcionProductos {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["DescripcionProductos"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].DescripcionProductos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].DescripcionProductos = value;
               }
	          }
        public bool IsDescripcionProductosNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsDescripcionProductosNull();
             }
	        }
        public String ObservacionesProductos {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["ObservacionesProductos"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].ObservacionesProductos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].ObservacionesProductos = value;
               }
	          }
        public bool IsObservacionesProductosNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsObservacionesProductosNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public String DescripcionUniMed {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["DescripcionUniMed"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].DescripcionUniMed;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].DescripcionUniMed = value;
               }
	          }
        public bool IsDescripcionUniMedNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsDescripcionUniMedNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String DescripcionDepositos {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["DescripcionDepositos"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].DescripcionDepositos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].DescripcionDepositos = value;
               }
	          }
        public bool IsDescripcionDepositosNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsDescripcionDepositosNull();
             }
	        }
        public Decimal Factor {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["Factor"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Factor;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Factor = value;
               }
	          }
        public bool IsFactorNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsFactorNull();
             }
	        }
        public Decimal CantidadOriginal {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["CantidadOriginal"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].CantidadOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].CantidadOriginal = value;
               }
	          }
        public bool IsCantidadOriginalNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsCantidadOriginalNull();
             }
	        }
        public Decimal CantidadPedida {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["CantidadPedida"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].CantidadPedida;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].CantidadPedida = value;
               }
	          }
        public bool IsCantidadPedidaNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsCantidadPedidaNull();
             }
	        }
        public Decimal CantidadRemitida {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["CantidadRemitida"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].CantidadRemitida;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].CantidadRemitida = value;
               }
	          }
        public bool IsCantidadRemitidaNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsCantidadRemitidaNull();
             }
	        }
        public Decimal CantidadFacturada {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["CantidadFacturada"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].CantidadFacturada;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].CantidadFacturada = value;
               }
	          }
        public bool IsCantidadFacturadaNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsCantidadFacturadaNull();
             }
	        }
        public Decimal PrecioForm {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["PrecioForm"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].PrecioForm;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].PrecioForm = value;
               }
	          }
        public bool IsPrecioFormNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsPrecioFormNull();
             }
	        }
        public Decimal PrecioSinIva {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["PrecioSinIva"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].PrecioSinIva;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].PrecioSinIva = value;
               }
	          }
        public bool IsPrecioSinIvaNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsPrecioSinIvaNull();
             }
	        }
        public String CFVenta_Id {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["CFVenta_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].CFVenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].CFVenta_Id = value;
               }
	          }
        public bool IsCFVenta_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsCFVenta_IdNull();
             }
	        }
        public Decimal PrecioLista {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["PrecioLista"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].PrecioLista;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].PrecioLista = value;
               }
	          }
        public bool IsPrecioListaNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsPrecioListaNull();
             }
	        }
        public Decimal PrecioListaForm {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["PrecioListaForm"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].PrecioListaForm;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].PrecioListaForm = value;
               }
	          }
        public bool IsPrecioListaFormNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsPrecioListaFormNull();
             }
	        }
        public Decimal PrecioVenta {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["PrecioVenta"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].PrecioVenta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].PrecioVenta = value;
               }
	          }
        public bool IsPrecioVentaNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsPrecioVentaNull();
             }
	        }
        public String TipoPrecio {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["TipoPrecio"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].TipoPrecio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].TipoPrecio = value;
               }
	          }
        public bool IsTipoPrecioNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsTipoPrecioNull();
             }
	        }
        public Decimal SubTotal {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["SubTotal"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].SubTotal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].SubTotal = value;
               }
	          }
        public bool IsSubTotalNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsSubTotalNull();
             }
	        }
        public DateTime FechaEntrega {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["FechaEntrega"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].FechaEntrega;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].FechaEntrega = value;
               }
	          }
        public bool IsFechaEntregaNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsFechaEntregaNull();
             }
	        }
        public Boolean Especial {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["Especial"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Especial;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Especial = value;
               }
	          }
        public bool IsEspecialNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsEspecialNull();
             }
	        }
        public Decimal Bonificacion {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["Bonificacion"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Bonificacion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Bonificacion = value;
               }
	          }
        public bool IsBonificacionNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsBonificacionNull();
             }
	        }
        public String Observaciones {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public Boolean Pendiente {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["Pendiente"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Pendiente;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Pendiente = value;
               }
	          }
        public bool IsPendienteNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsPendienteNull();
             }
	        }
        public Boolean ReservaMercaderia {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["ReservaMercaderia"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].ReservaMercaderia;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].ReservaMercaderia = value;
               }
	          }
        public bool IsReservaMercaderiaNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsReservaMercaderiaNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Decimal SubTotalNeto {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["SubTotalNeto"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].SubTotalNeto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].SubTotalNeto = value;
               }
	          }
        public bool IsSubTotalNetoNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsSubTotalNetoNull();
             }
	        }
        public Int32 RenglonReferencia {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["RenglonReferencia"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].RenglonReferencia;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].RenglonReferencia = value;
               }
	          }
        public bool IsRenglonReferenciaNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsRenglonReferenciaNull();
             }
	        }
        public Boolean Anular {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["Anular"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Anular;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Anular = value;
               }
	          }
        public bool IsAnularNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsAnularNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venPediCuerpoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venPediCuerpoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venPediCuerpoDS );
     }
     public venPediCuerpoActionExchange() : base( "venPediCuerpo" ) {
     }

     public venPediCuerpoActionExchange(venPediCuerpoActionEnum.EnumvenPediCuerpoAction pAccion) : base(venPediCuerpoActionEnum.GetAccionvenPediCuerpoAction(pAccion)) {
     }

     public venPediCuerpoActionExchange(venPediCuerpoActionEnum.EnumvenPediCuerpoAction pAccion, VentasCommon.venPediCuerpoDS pdsParam) : base(venPediCuerpoActionEnum.GetAccionvenPediCuerpoAction(pAccion), pdsParam) {
     }

     public venPediCuerpoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venPediCuerpoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venPediCuerpoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venPediCuerpoDS)mParam;
	        }
     }
  }
}
