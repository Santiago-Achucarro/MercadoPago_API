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
    public class venNotaDeCreditoAnticipoActionExchange : Framework.Core.Exchange{

        public Int32 venPedidos {
            get {
                if(((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0]["venPedidos"] != DBNull.Value  ){
                    return ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].venPedidos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].venPedidos = value;
               }
	          }
        public bool IsvenPedidosNull {
             get {
                 return mParam==null || ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].IsvenPedidosNull();
             }
	        }
        public Decimal SubTotalPedido {
            get {
                if(((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0]["SubTotalPedido"] != DBNull.Value  ){
                    return ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].SubTotalPedido;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].SubTotalPedido = value;
               }
	          }
        public bool IsSubTotalPedidoNull {
             get {
                 return mParam==null || ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].IsSubTotalPedidoNull();
             }
	        }
        public Decimal SubTotalFactura {
            get {
                if(((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0]["SubTotalFactura"] != DBNull.Value  ){
                    return ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].SubTotalFactura;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].SubTotalFactura = value;
               }
	          }
        public bool IsSubTotalFacturaNull {
             get {
                 return mParam==null || ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].IsSubTotalFacturaNull();
             }
	        }
        public Decimal TotalFactura {
            get {
                if(((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0]["TotalFactura"] != DBNull.Value  ){
                    return ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].TotalFactura;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].TotalFactura = value;
               }
	          }
        public bool IsTotalFacturaNull {
             get {
                 return mParam==null || ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].IsTotalFacturaNull();
             }
	        }
        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public String Moneda {
            get {
                if(((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0]["Moneda"] != DBNull.Value  ){
                    return ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].Moneda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].Moneda = value;
               }
	          }
        public bool IsMonedaNull {
             get {
                 return mParam==null || ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].IsMonedaNull();
             }
	        }
        public Int32 Reparto_Id {
            get {
                if(((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0]["Reparto_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].Reparto_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].Reparto_Id = value;
               }
	          }
        public bool IsReparto_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].IsReparto_IdNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public String Observaciones {
            get {
                if(((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public Int32 Sucursal {
            get {
                if(((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public String CtaAnticipos {
            get {
                if(((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0]["CtaAnticipos"] != DBNull.Value  ){
                    return ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].CtaAnticipos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].CtaAnticipos = value;
               }
	          }
        public bool IsCtaAnticiposNull {
             get {
                 return mParam==null || ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].IsCtaAnticiposNull();
             }
	        }
        public String CondPago_Id {
            get {
                if(((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0]["CondPago_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].CondPago_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].CondPago_Id = value;
               }
	          }
        public bool IsCondPago_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].IsCondPago_IdNull();
             }
	        }
        public String Vendedor_Id {
            get {
                if(((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0]["Vendedor_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].Vendedor_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].Vendedor_Id = value;
               }
	          }
        public bool IsVendedor_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].IsVendedor_IdNull();
             }
	        }
        public String FormaEntrega_Id {
            get {
                if(((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0]["FormaEntrega_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].FormaEntrega_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].FormaEntrega_Id = value;
               }
	          }
        public bool IsFormaEntrega_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].IsFormaEntrega_IdNull();
             }
	        }
        public String UsoCfdi_Id {
            get {
                if(((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0]["UsoCfdi_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].UsoCfdi_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].UsoCfdi_Id = value;
               }
	          }
        public bool IsUsoCfdi_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].IsUsoCfdi_IdNull();
             }
	        }
        public String PedidoStr {
            get {
                if(((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0]["PedidoStr"] != DBNull.Value  ){
                    return ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].PedidoStr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].PedidoStr = value;
               }
	          }
        public bool IsPedidoStrNull {
             get {
                 return mParam==null || ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].IsPedidoStrNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venNotaDeCreditoAnticipoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venNotaDeCreditoAnticipoDS );
     }
     public venNotaDeCreditoAnticipoActionExchange() : base( "venNotaDeCreditoAnticipo" ) {
     }

     public venNotaDeCreditoAnticipoActionExchange(venNotaDeCreditoAnticipoActionEnum.EnumvenNotaDeCreditoAnticipoAction pAccion) : base(venNotaDeCreditoAnticipoActionEnum.GetAccionvenNotaDeCreditoAnticipoAction(pAccion)) {
     }

     public venNotaDeCreditoAnticipoActionExchange(venNotaDeCreditoAnticipoActionEnum.EnumvenNotaDeCreditoAnticipoAction pAccion, VentasCommon.venNotaDeCreditoAnticipoDS pdsParam) : base(venNotaDeCreditoAnticipoActionEnum.GetAccionvenNotaDeCreditoAnticipoAction(pAccion), pdsParam) {
     }

     public venNotaDeCreditoAnticipoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venNotaDeCreditoAnticipoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venNotaDeCreditoAnticipoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venNotaDeCreditoAnticipoDS)mParam;
	        }
     }
  }
}
