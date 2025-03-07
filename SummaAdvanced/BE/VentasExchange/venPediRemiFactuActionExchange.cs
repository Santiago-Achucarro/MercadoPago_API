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
    public class venPediRemiFactuActionExchange : Framework.Core.Exchange{

        public Int32 venPedidos {
            get {
                if(((VentasCommon.venPediRemiFactuDS)mParam).Principal[0]["venPedidos"] != DBNull.Value  ){
                    return ((VentasCommon.venPediRemiFactuDS)mParam).Principal[0].venPedidos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediRemiFactuDS)mParam).Principal[0].venPedidos = value;
               }
	          }
        public bool IsvenPedidosNull {
             get {
                 return mParam==null || ((VentasCommon.venPediRemiFactuDS)mParam).Principal[0].IsvenPedidosNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venPediRemiFactuDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venPediRemiFactuDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediRemiFactuDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venPediRemiFactuDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venPediRemiFactuDS );
     }
     public venPediRemiFactuActionExchange() : base( "venPediRemiFactu" ) {
     }

     public venPediRemiFactuActionExchange(venPediRemiFactuActionEnum.EnumvenPediRemiFactuAction pAccion) : base(venPediRemiFactuActionEnum.GetAccionvenPediRemiFactuAction(pAccion)) {
     }

     public venPediRemiFactuActionExchange(venPediRemiFactuActionEnum.EnumvenPediRemiFactuAction pAccion, VentasCommon.venPediRemiFactuDS pdsParam) : base(venPediRemiFactuActionEnum.GetAccionvenPediRemiFactuAction(pAccion), pdsParam) {
     }

     public venPediRemiFactuActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venPediRemiFactuDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venPediRemiFactuDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venPediRemiFactuDS)mParam;
	        }
     }
  }
}
