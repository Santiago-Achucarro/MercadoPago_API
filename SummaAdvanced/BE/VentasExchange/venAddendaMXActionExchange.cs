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
    public class venAddendaMXActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venAddendaMXDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venAddendaMXDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAddendaMXDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venAddendaMXDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public String Addenda {
            get {
                if(((VentasCommon.venAddendaMXDS)mParam).Principal[0]["Addenda"] != DBNull.Value  ){
                    return ((VentasCommon.venAddendaMXDS)mParam).Principal[0].Addenda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAddendaMXDS)mParam).Principal[0].Addenda = value;
               }
	          }
        public bool IsAddendaNull {
             get {
                 return mParam==null || ((VentasCommon.venAddendaMXDS)mParam).Principal[0].IsAddendaNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venAddendaMXDS );
     }
     public venAddendaMXActionExchange() : base( "venAddendaMX" ) {
     }

     public venAddendaMXActionExchange(venAddendaMXActionEnum.EnumvenAddendaMXAction pAccion) : base(venAddendaMXActionEnum.GetAccionvenAddendaMXAction(pAccion)) {
     }

     public venAddendaMXActionExchange(venAddendaMXActionEnum.EnumvenAddendaMXAction pAccion, VentasCommon.venAddendaMXDS pdsParam) : base(venAddendaMXActionEnum.GetAccionvenAddendaMXAction(pAccion), pdsParam) {
     }

     public venAddendaMXActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venAddendaMXDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venAddendaMXDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venAddendaMXDS)mParam;
	        }
     }
  }
}
