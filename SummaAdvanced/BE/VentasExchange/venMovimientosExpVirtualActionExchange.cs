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
    public class venMovimientosExpVirtualActionExchange : Framework.Core.Exchange{

        public Boolean Existe {
            get {
                if(((VentasCommon.venMovimientosExpVirtualDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosExpVirtualDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosExpVirtualDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosExpVirtualDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMovimientosExpVirtualDS );
     }
     public venMovimientosExpVirtualActionExchange() : base( "venMovimientosExpVirtual" ) {
     }

     public venMovimientosExpVirtualActionExchange(venMovimientosExpVirtualActionEnum.EnumvenMovimientosExpVirtualAction pAccion) : base(venMovimientosExpVirtualActionEnum.GetAccionvenMovimientosExpVirtualAction(pAccion)) {
     }

     public venMovimientosExpVirtualActionExchange(venMovimientosExpVirtualActionEnum.EnumvenMovimientosExpVirtualAction pAccion, VentasCommon.venMovimientosExpVirtualDS pdsParam) : base(venMovimientosExpVirtualActionEnum.GetAccionvenMovimientosExpVirtualAction(pAccion), pdsParam) {
     }

     public venMovimientosExpVirtualActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMovimientosExpVirtualDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMovimientosExpVirtualDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMovimientosExpVirtualDS)mParam;
	        }
     }
  }
}
