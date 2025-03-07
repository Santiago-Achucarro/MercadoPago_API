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
    public class venMovimientosCFDIRVirtualActionExchange : Framework.Core.Exchange{

        public Boolean Existe {
            get {
                if(((VentasCommon.venMovimientosCFDIRVirtualDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCFDIRVirtualDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCFDIRVirtualDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCFDIRVirtualDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMovimientosCFDIRVirtualDS );
     }
     public venMovimientosCFDIRVirtualActionExchange() : base( "venMovimientosCFDIRVirtual" ) {
     }

     public venMovimientosCFDIRVirtualActionExchange(venMovimientosCFDIRVirtualActionEnum.EnumvenMovimientosCFDIRVirtualAction pAccion) : base(venMovimientosCFDIRVirtualActionEnum.GetAccionvenMovimientosCFDIRVirtualAction(pAccion)) {
     }

     public venMovimientosCFDIRVirtualActionExchange(venMovimientosCFDIRVirtualActionEnum.EnumvenMovimientosCFDIRVirtualAction pAccion, VentasCommon.venMovimientosCFDIRVirtualDS pdsParam) : base(venMovimientosCFDIRVirtualActionEnum.GetAccionvenMovimientosCFDIRVirtualAction(pAccion), pdsParam) {
     }

     public venMovimientosCFDIRVirtualActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMovimientosCFDIRVirtualDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMovimientosCFDIRVirtualDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMovimientosCFDIRVirtualDS)mParam;
	        }
     }
  }
}
