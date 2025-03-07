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
    public class venPedidosPendAutoActionExchange : Framework.Core.Exchange{

        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venPedidosPendAutoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosPendAutoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosPendAutoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosPendAutoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venPedidosPendAutoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosPendAutoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosPendAutoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosPendAutoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venPedidosPendAutoDS );
     }
     public venPedidosPendAutoActionExchange() : base( "venPedidosPendAuto" ) {
     }

     public venPedidosPendAutoActionExchange(venPedidosPendAutoActionEnum.EnumvenPedidosPendAutoAction pAccion) : base(venPedidosPendAutoActionEnum.GetAccionvenPedidosPendAutoAction(pAccion)) {
     }

     public venPedidosPendAutoActionExchange(venPedidosPendAutoActionEnum.EnumvenPedidosPendAutoAction pAccion, VentasCommon.venPedidosPendAutoDS pdsParam) : base(venPedidosPendAutoActionEnum.GetAccionvenPedidosPendAutoAction(pAccion), pdsParam) {
     }

     public venPedidosPendAutoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venPedidosPendAutoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venPedidosPendAutoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venPedidosPendAutoDS)mParam;
	        }
     }
  }
}
