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
    public class venCotizPediCuerpoActionExchange : Framework.Core.Exchange{

        public Int32 venPedidos {
            get {
                if(((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0]["venPedidos"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0].venPedidos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0].venPedidos = value;
               }
	          }
        public bool IsvenPedidosNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0].IsvenPedidosNull();
             }
	        }
        public Int32 Renglon_Pe {
            get {
                if(((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0]["Renglon_Pe"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0].Renglon_Pe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0].Renglon_Pe = value;
               }
	          }
        public bool IsRenglon_PeNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0].IsRenglon_PeNull();
             }
	        }
        public Int32 venCotizaciones {
            get {
                if(((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0]["venCotizaciones"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0].venCotizaciones;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0].venCotizaciones = value;
               }
	          }
        public bool IsvenCotizacionesNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0].IsvenCotizacionesNull();
             }
	        }
        public Int32 Renglon_Co {
            get {
                if(((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0]["Renglon_Co"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0].Renglon_Co;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0].Renglon_Co = value;
               }
	          }
        public bool IsRenglon_CoNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0].IsRenglon_CoNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizPediCuerpoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venCotizPediCuerpoDS );
     }
     public venCotizPediCuerpoActionExchange() : base( "venCotizPediCuerpo" ) {
     }

     public venCotizPediCuerpoActionExchange(venCotizPediCuerpoActionEnum.EnumvenCotizPediCuerpoAction pAccion) : base(venCotizPediCuerpoActionEnum.GetAccionvenCotizPediCuerpoAction(pAccion)) {
     }

     public venCotizPediCuerpoActionExchange(venCotizPediCuerpoActionEnum.EnumvenCotizPediCuerpoAction pAccion, VentasCommon.venCotizPediCuerpoDS pdsParam) : base(venCotizPediCuerpoActionEnum.GetAccionvenCotizPediCuerpoAction(pAccion), pdsParam) {
     }

     public venCotizPediCuerpoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venCotizPediCuerpoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venCotizPediCuerpoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venCotizPediCuerpoDS)mParam;
	        }
     }
  }
}
