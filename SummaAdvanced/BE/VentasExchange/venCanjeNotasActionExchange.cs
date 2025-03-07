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
    public class venCanjeNotasActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venCanjeNotasDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venCanjeNotasDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCanjeNotasDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venCanjeNotasDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public Int64 venMovimientosNC {
            get {
                if(((VentasCommon.venCanjeNotasDS)mParam).Principal[0]["venMovimientosNC"] != DBNull.Value  ){
                    return ((VentasCommon.venCanjeNotasDS)mParam).Principal[0].venMovimientosNC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCanjeNotasDS)mParam).Principal[0].venMovimientosNC = value;
               }
	          }
        public bool IsvenMovimientosNCNull {
             get {
                 return mParam==null || ((VentasCommon.venCanjeNotasDS)mParam).Principal[0].IsvenMovimientosNCNull();
             }
	        }
        public Int64 venMovimientosFC {
            get {
                if(((VentasCommon.venCanjeNotasDS)mParam).Principal[0]["venMovimientosFC"] != DBNull.Value  ){
                    return ((VentasCommon.venCanjeNotasDS)mParam).Principal[0].venMovimientosFC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCanjeNotasDS)mParam).Principal[0].venMovimientosFC = value;
               }
	          }
        public bool IsvenMovimientosFCNull {
             get {
                 return mParam==null || ((VentasCommon.venCanjeNotasDS)mParam).Principal[0].IsvenMovimientosFCNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venCanjeNotasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venCanjeNotasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCanjeNotasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venCanjeNotasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venCanjeNotasDS );
     }
     public venCanjeNotasActionExchange() : base( "venCanjeNotas" ) {
     }

     public venCanjeNotasActionExchange(venCanjeNotasActionEnum.EnumvenCanjeNotasAction pAccion) : base(venCanjeNotasActionEnum.GetAccionvenCanjeNotasAction(pAccion)) {
     }

     public venCanjeNotasActionExchange(venCanjeNotasActionEnum.EnumvenCanjeNotasAction pAccion, VentasCommon.venCanjeNotasDS pdsParam) : base(venCanjeNotasActionEnum.GetAccionvenCanjeNotasAction(pAccion), pdsParam) {
     }

     public venCanjeNotasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venCanjeNotasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venCanjeNotasDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venCanjeNotasDS)mParam;
	        }
     }
  }
}
