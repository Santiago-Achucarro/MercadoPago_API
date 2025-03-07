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
    public class venCotizCuerpoActionExchange : Framework.Core.Exchange{

        public Int32 Cotizacion_Id {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["Cotizacion_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Cotizacion_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Cotizacion_Id = value;
               }
	          }
        public bool IsCotizacion_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsCotizacion_IdNull();
             }
	        }
        public Int32 Renglon_Co {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["Renglon_Co"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Renglon_Co;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Renglon_Co = value;
               }
	          }
        public bool IsRenglon_CoNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsRenglon_CoNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String DescripcionProducto {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["DescripcionProducto"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].DescripcionProducto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].DescripcionProducto = value;
               }
	          }
        public bool IsDescripcionProductoNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsDescripcionProductoNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public String DescripcionMedida {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["DescripcionMedida"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].DescripcionMedida;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].DescripcionMedida = value;
               }
	          }
        public bool IsDescripcionMedidaNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsDescripcionMedidaNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String DescripcionDeposito {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["DescripcionDeposito"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].DescripcionDeposito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].DescripcionDeposito = value;
               }
	          }
        public bool IsDescripcionDepositoNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsDescripcionDepositoNull();
             }
	        }
        public Decimal Factor {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["Factor"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Factor;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Factor = value;
               }
	          }
        public bool IsFactorNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsFactorNull();
             }
	        }
        public Decimal CantidadOriginal {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["CantidadOriginal"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].CantidadOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].CantidadOriginal = value;
               }
	          }
        public bool IsCantidadOriginalNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsCantidadOriginalNull();
             }
	        }
        public Decimal CantidadPedida {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["CantidadPedida"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].CantidadPedida;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].CantidadPedida = value;
               }
	          }
        public bool IsCantidadPedidaNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsCantidadPedidaNull();
             }
	        }
        public Decimal CantidadRemitida {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["CantidadRemitida"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].CantidadRemitida;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].CantidadRemitida = value;
               }
	          }
        public bool IsCantidadRemitidaNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsCantidadRemitidaNull();
             }
	        }
        public Decimal CantidadFacturada {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["CantidadFacturada"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].CantidadFacturada;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].CantidadFacturada = value;
               }
	          }
        public bool IsCantidadFacturadaNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsCantidadFacturadaNull();
             }
	        }
        public Decimal PrecioForm {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["PrecioForm"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].PrecioForm;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].PrecioForm = value;
               }
	          }
        public bool IsPrecioFormNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsPrecioFormNull();
             }
	        }
        public Decimal PrecioLista {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["PrecioLista"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].PrecioLista;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].PrecioLista = value;
               }
	          }
        public bool IsPrecioListaNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsPrecioListaNull();
             }
	        }
        public Decimal PrecioVenta {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["PrecioVenta"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].PrecioVenta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].PrecioVenta = value;
               }
	          }
        public bool IsPrecioVentaNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsPrecioVentaNull();
             }
	        }
        public DateTime FechaEntrega {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["FechaEntrega"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].FechaEntrega;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].FechaEntrega = value;
               }
	          }
        public bool IsFechaEntregaNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsFechaEntregaNull();
             }
	        }
        public Boolean Especial {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["Especial"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Especial;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Especial = value;
               }
	          }
        public bool IsEspecialNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsEspecialNull();
             }
	        }
        public Decimal Bonificacion {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["Bonificacion"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Bonificacion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Bonificacion = value;
               }
	          }
        public bool IsBonificacionNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsBonificacionNull();
             }
	        }
        public String Observaciones {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public Boolean Pendiente {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["Pendiente"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Pendiente;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Pendiente = value;
               }
	          }
        public bool IsPendienteNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsPendienteNull();
             }
	        }
        public Boolean ReservaMercaderia {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["ReservaMercaderia"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].ReservaMercaderia;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].ReservaMercaderia = value;
               }
	          }
        public bool IsReservaMercaderiaNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsReservaMercaderiaNull();
             }
	        }
        public Decimal PrecioListaForm {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["PrecioListaForm"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].PrecioListaForm;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].PrecioListaForm = value;
               }
	          }
        public bool IsPrecioListaFormNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsPrecioListaFormNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Decimal SubTotal {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["SubTotal"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].SubTotal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].SubTotal = value;
               }
	          }
        public bool IsSubTotalNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsSubTotalNull();
             }
	        }
        public Decimal SubTotalNeto {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["SubTotalNeto"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].SubTotalNeto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].SubTotalNeto = value;
               }
	          }
        public bool IsSubTotalNetoNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsSubTotalNetoNull();
             }
	        }
        public String TipoPrecio {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["TipoPrecio"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].TipoPrecio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].TipoPrecio = value;
               }
	          }
        public bool IsTipoPrecioNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsTipoPrecioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venCotizCuerpoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizCuerpoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venCotizCuerpoDS );
     }
     public venCotizCuerpoActionExchange() : base( "venCotizCuerpo" ) {
     }

     public venCotizCuerpoActionExchange(venCotizCuerpoActionEnum.EnumvenCotizCuerpoAction pAccion) : base(venCotizCuerpoActionEnum.GetAccionvenCotizCuerpoAction(pAccion)) {
     }

     public venCotizCuerpoActionExchange(venCotizCuerpoActionEnum.EnumvenCotizCuerpoAction pAccion, VentasCommon.venCotizCuerpoDS pdsParam) : base(venCotizCuerpoActionEnum.GetAccionvenCotizCuerpoAction(pAccion), pdsParam) {
     }

     public venCotizCuerpoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venCotizCuerpoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venCotizCuerpoActionExchange(VentasCommon.venCotizCuerpoDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venCotizCuerpoDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venCotizCuerpoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venCotizCuerpoDS)mParam;
	        }
     }
  }
}
