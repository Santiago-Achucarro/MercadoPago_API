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
    public class venMovStkHistDevolverIdMovStockActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venMovStkHistDevolverIdMovStockDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venMovStkHistDevolverIdMovStockDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovStkHistDevolverIdMovStockDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovStkHistDevolverIdMovStockDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public Int64 stkMoviCabe {
            get {
                if(((VentasCommon.venMovStkHistDevolverIdMovStockDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovStkHistDevolverIdMovStockDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovStkHistDevolverIdMovStockDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((VentasCommon.venMovStkHistDevolverIdMovStockDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venMovStkHistDevolverIdMovStockDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovStkHistDevolverIdMovStockDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovStkHistDevolverIdMovStockDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovStkHistDevolverIdMovStockDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMovStkHistDevolverIdMovStockDS );
     }
     public venMovStkHistDevolverIdMovStockActionExchange() : base( "venMovStkHistDevolverIdMovStock" ) {
     }

     public venMovStkHistDevolverIdMovStockActionExchange(venMovStkHistDevolverIdMovStockActionEnum.EnumvenMovStkHistDevolverIdMovStockAction pAccion) : base(venMovStkHistDevolverIdMovStockActionEnum.GetAccionvenMovStkHistDevolverIdMovStockAction(pAccion)) {
     }

     public venMovStkHistDevolverIdMovStockActionExchange(venMovStkHistDevolverIdMovStockActionEnum.EnumvenMovStkHistDevolverIdMovStockAction pAccion, VentasCommon.venMovStkHistDevolverIdMovStockDS pdsParam) : base(venMovStkHistDevolverIdMovStockActionEnum.GetAccionvenMovStkHistDevolverIdMovStockAction(pAccion), pdsParam) {
     }

     public venMovStkHistDevolverIdMovStockActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMovStkHistDevolverIdMovStockDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMovStkHistDevolverIdMovStockDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMovStkHistDevolverIdMovStockDS)mParam;
	        }
     }
  }
}
