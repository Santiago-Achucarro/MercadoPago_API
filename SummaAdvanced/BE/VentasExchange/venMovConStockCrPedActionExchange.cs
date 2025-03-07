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
    public class venMovConStockCrPedActionExchange : Framework.Core.Exchange{

        public Int32 venPedidos {
            get {
                if(((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0]["venPedidos"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].venPedidos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].venPedidos = value;
               }
	          }
        public bool IsvenPedidosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].IsvenPedidosNull();
             }
	        }
        public Int32 Renglon_Pe {
            get {
                if(((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0]["Renglon_Pe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].Renglon_Pe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].Renglon_Pe = value;
               }
	          }
        public bool IsRenglon_PeNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].IsRenglon_PeNull();
             }
	        }
        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public Int32 RenglonCuerpo {
            get {
                if(((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0]["RenglonCuerpo"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].RenglonCuerpo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].RenglonCuerpo = value;
               }
	          }
        public bool IsRenglonCuerpoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].IsRenglonCuerpoNull();
             }
	        }
        public Int32 venReparto {
            get {
                if(((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0]["venReparto"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].venReparto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].venReparto = value;
               }
	          }
        public bool IsvenRepartoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].IsvenRepartoNull();
             }
	        }
        public String Pedido {
            get {
                if(((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0]["Pedido"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].Pedido;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].Pedido = value;
               }
	          }
        public bool IsPedidoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].IsPedidoNull();
             }
	        }
        public String Reparto {
            get {
                if(((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0]["Reparto"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].Reparto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].Reparto = value;
               }
	          }
        public bool IsRepartoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].IsRepartoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovConStockCrPedDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMovConStockCrPedDS );
     }
     public venMovConStockCrPedActionExchange() : base( "venMovConStockCrPed" ) {
     }

     public venMovConStockCrPedActionExchange(venMovConStockCrPedActionEnum.EnumvenMovConStockCrPedAction pAccion) : base(venMovConStockCrPedActionEnum.GetAccionvenMovConStockCrPedAction(pAccion)) {
     }

     public venMovConStockCrPedActionExchange(venMovConStockCrPedActionEnum.EnumvenMovConStockCrPedAction pAccion, VentasCommon.venMovConStockCrPedDS pdsParam) : base(venMovConStockCrPedActionEnum.GetAccionvenMovConStockCrPedAction(pAccion), pdsParam) {
     }

     public venMovConStockCrPedActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMovConStockCrPedDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMovConStockCrPedDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMovConStockCrPedDS)mParam;
	        }
     }
  }
}
