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
    public class stkMoviCRevaluoActionExchange : Framework.Core.Exchange{

        public Int64 stkMoviCabeReva {
            get {
                if(((StockCommon.stkMoviCRevaluoDS)mParam).Principal[0]["stkMoviCabeReva"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCRevaluoDS)mParam).Principal[0].stkMoviCabeReva;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCRevaluoDS)mParam).Principal[0].stkMoviCabeReva = value;
               }
	          }
        public bool IsstkMoviCabeRevaNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCRevaluoDS)mParam).Principal[0].IsstkMoviCabeRevaNull();
             }
	        }
        public Int64 conAsientos {
            get {
                if(((StockCommon.stkMoviCRevaluoDS)mParam).Principal[0]["conAsientos"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCRevaluoDS)mParam).Principal[0].conAsientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCRevaluoDS)mParam).Principal[0].conAsientos = value;
               }
	          }
        public bool IsconAsientosNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCRevaluoDS)mParam).Principal[0].IsconAsientosNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkMoviCRevaluoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCRevaluoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCRevaluoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCRevaluoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkMoviCRevaluoDS );
     }
     public stkMoviCRevaluoActionExchange() : base( "stkMoviCRevaluo" ) {
     }

     public stkMoviCRevaluoActionExchange(stkMoviCRevaluoActionEnum.EnumstkMoviCRevaluoAction pAccion) : base(stkMoviCRevaluoActionEnum.GetAccionstkMoviCRevaluoAction(pAccion)) {
     }

     public stkMoviCRevaluoActionExchange(stkMoviCRevaluoActionEnum.EnumstkMoviCRevaluoAction pAccion, StockCommon.stkMoviCRevaluoDS pdsParam) : base(stkMoviCRevaluoActionEnum.GetAccionstkMoviCRevaluoAction(pAccion), pdsParam) {
     }

     public stkMoviCRevaluoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkMoviCRevaluoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkMoviCRevaluoDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkMoviCRevaluoDS)mParam;
	        }
     }
  }
}
