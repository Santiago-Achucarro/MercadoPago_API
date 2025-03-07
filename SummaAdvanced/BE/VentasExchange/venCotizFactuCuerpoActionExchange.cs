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
    public class venCotizFactuCuerpoActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public Int32 RenglonCuerpo {
            get {
                if(((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0]["RenglonCuerpo"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0].RenglonCuerpo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0].RenglonCuerpo = value;
               }
	          }
        public bool IsRenglonCuerpoNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0].IsRenglonCuerpoNull();
             }
	        }
        public Int32 venCotizaciones {
            get {
                if(((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0]["venCotizaciones"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0].venCotizaciones;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0].venCotizaciones = value;
               }
	          }
        public bool IsvenCotizacionesNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0].IsvenCotizacionesNull();
             }
	        }
        public Int32 Renglon_Co {
            get {
                if(((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0]["Renglon_Co"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0].Renglon_Co;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0].Renglon_Co = value;
               }
	          }
        public bool IsRenglon_CoNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0].IsRenglon_CoNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizFactuCuerpoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venCotizFactuCuerpoDS );
     }
     public venCotizFactuCuerpoActionExchange() : base( "venCotizFactuCuerpo" ) {
     }

     public venCotizFactuCuerpoActionExchange(venCotizFactuCuerpoActionEnum.EnumvenCotizFactuCuerpoAction pAccion) : base(venCotizFactuCuerpoActionEnum.GetAccionvenCotizFactuCuerpoAction(pAccion)) {
     }

     public venCotizFactuCuerpoActionExchange(venCotizFactuCuerpoActionEnum.EnumvenCotizFactuCuerpoAction pAccion, VentasCommon.venCotizFactuCuerpoDS pdsParam) : base(venCotizFactuCuerpoActionEnum.GetAccionvenCotizFactuCuerpoAction(pAccion), pdsParam) {
     }

     public venCotizFactuCuerpoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venCotizFactuCuerpoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venCotizFactuCuerpoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venCotizFactuCuerpoDS)mParam;
	        }
     }
  }
}
