using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace StockExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class stkRemiCancPendActionExchange : Framework.Core.Exchange{

        public DateTime FechaHasta {
            get {
                if(((StockCommon.stkRemiCancPendDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiCancPendDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiCancPendDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiCancPendDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkRemiCancPendDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiCancPendDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiCancPendDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiCancPendDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkRemiCancPendDS );
     }
     public stkRemiCancPendActionExchange() : base( "stkRemiCancPend" ) {
     }

     public stkRemiCancPendActionExchange(stkRemiCancPendActionEnum.EnumstkRemiCancPendAction pAccion) : base(stkRemiCancPendActionEnum.GetAccionstkRemiCancPendAction(pAccion)) {
     }

     public stkRemiCancPendActionExchange(stkRemiCancPendActionEnum.EnumstkRemiCancPendAction pAccion, StockCommon.stkRemiCancPendDS pdsParam) : base(stkRemiCancPendActionEnum.GetAccionstkRemiCancPendAction(pAccion), pdsParam) {
     }

     public stkRemiCancPendActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkRemiCancPendDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkRemiCancPendDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkRemiCancPendDS)mParam;
	        }
     }
  }
}
