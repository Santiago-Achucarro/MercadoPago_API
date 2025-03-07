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
    public class venMoviPredialActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venMoviPredialDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venMoviPredialDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMoviPredialDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venMoviPredialDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public Int32 conRenglon {
            get {
                if(((VentasCommon.venMoviPredialDS)mParam).Principal[0]["conRenglon"] != DBNull.Value  ){
                    return ((VentasCommon.venMoviPredialDS)mParam).Principal[0].conRenglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMoviPredialDS)mParam).Principal[0].conRenglon = value;
               }
	          }
        public bool IsconRenglonNull {
             get {
                 return mParam==null || ((VentasCommon.venMoviPredialDS)mParam).Principal[0].IsconRenglonNull();
             }
	        }
        public String CuentaPredial {
            get {
                if(((VentasCommon.venMoviPredialDS)mParam).Principal[0]["CuentaPredial"] != DBNull.Value  ){
                    return ((VentasCommon.venMoviPredialDS)mParam).Principal[0].CuentaPredial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMoviPredialDS)mParam).Principal[0].CuentaPredial = value;
               }
	          }
        public bool IsCuentaPredialNull {
             get {
                 return mParam==null || ((VentasCommon.venMoviPredialDS)mParam).Principal[0].IsCuentaPredialNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venMoviPredialDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMoviPredialDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMoviPredialDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMoviPredialDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMoviPredialDS );
     }
     public venMoviPredialActionExchange() : base( "venMoviPredial" ) {
     }

     public venMoviPredialActionExchange(venMoviPredialActionEnum.EnumvenMoviPredialAction pAccion) : base(venMoviPredialActionEnum.GetAccionvenMoviPredialAction(pAccion)) {
     }

     public venMoviPredialActionExchange(venMoviPredialActionEnum.EnumvenMoviPredialAction pAccion, VentasCommon.venMoviPredialDS pdsParam) : base(venMoviPredialActionEnum.GetAccionvenMoviPredialAction(pAccion), pdsParam) {
     }

     public venMoviPredialActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMoviPredialDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMoviPredialDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMoviPredialDS)mParam;
	        }
     }
  }
}
