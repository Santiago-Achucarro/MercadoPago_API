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
    public class stkInvMoviStkActionExchange : Framework.Core.Exchange{

        public Int32 Algo {
            get {
                if(((StockCommon.stkInvMoviStkDS)mParam).Principal[0]["Algo"] != DBNull.Value  ){
                    return ((StockCommon.stkInvMoviStkDS)mParam).Principal[0].Algo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInvMoviStkDS)mParam).Principal[0].Algo = value;
               }
	          }
        public bool IsAlgoNull {
             get {
                 return mParam==null || ((StockCommon.stkInvMoviStkDS)mParam).Principal[0].IsAlgoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkInvMoviStkDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkInvMoviStkDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInvMoviStkDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkInvMoviStkDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkInvMoviStkDS );
     }
     public stkInvMoviStkActionExchange() : base( "stkInvMoviStk" ) {
     }

     public stkInvMoviStkActionExchange(stkInvMoviStkActionEnum.EnumstkInvMoviStkAction pAccion) : base(stkInvMoviStkActionEnum.GetAccionstkInvMoviStkAction(pAccion)) {
     }

     public stkInvMoviStkActionExchange(stkInvMoviStkActionEnum.EnumstkInvMoviStkAction pAccion, StockCommon.stkInvMoviStkDS pdsParam) : base(stkInvMoviStkActionEnum.GetAccionstkInvMoviStkAction(pAccion), pdsParam) {
     }

     public stkInvMoviStkActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkInvMoviStkDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkInvMoviStkDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkInvMoviStkDS)mParam;
	        }
     }
  }
}
