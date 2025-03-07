using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace VentasExchange
{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class venCotizPedidosActionExchange : Framework.Core.Exchange{

        public Int32 Cotizacion_Id {
            get {
                if(((VentasCommon.venCotizPedidosDS)mParam).Principal[0]["Cotizacion_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizPedidosDS)mParam).Principal[0].Cotizacion_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizPedidosDS)mParam).Principal[0].Cotizacion_Id = value;
               }
	          }
        public bool IsCotizacion_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizPedidosDS)mParam).Principal[0].IsCotizacion_IdNull();
             }
	        }
        public Int32 Pedido_Id {
            get {
                if(((VentasCommon.venCotizPedidosDS)mParam).Principal[0]["Pedido_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizPedidosDS)mParam).Principal[0].Pedido_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizPedidosDS)mParam).Principal[0].Pedido_Id = value;
               }
	          }
        public bool IsPedido_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizPedidosDS)mParam).Principal[0].IsPedido_IdNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((VentasCommon.venCotizPedidosDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizPedidosDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizPedidosDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizPedidosDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venCotizPedidosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizPedidosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizPedidosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizPedidosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venCotizPedidosDS );
     }
     public venCotizPedidosActionExchange() : base( "venCotizPedidos" ) {
     }

     public venCotizPedidosActionExchange(venCotizPedidosActionEnum.EnumvenCotizPedidosAction pAccion) : base(venCotizPedidosActionEnum.GetAccionvenCotizPedidosAction(pAccion)) {
     }

     public venCotizPedidosActionExchange(venCotizPedidosActionEnum.EnumvenCotizPedidosAction pAccion, VentasCommon.venCotizPedidosDS pdsParam) : base(venCotizPedidosActionEnum.GetAccionvenCotizPedidosAction(pAccion), pdsParam) {
     }

     public venCotizPedidosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venCotizPedidosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venCotizPedidosDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venCotizPedidosDS)mParam;
	        }
     }
  }
}
