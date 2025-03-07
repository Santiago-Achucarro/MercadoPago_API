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
    public class stkMoviLegaActionExchange : Framework.Core.Exchange{

        public Int64 stkMoviCabe {
            get {
                if(((StockCommon.stkMoviLegaDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviLegaDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviLegaDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviLegaDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Int32 Legajo {
            get {
                if(((StockCommon.stkMoviLegaDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviLegaDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviLegaDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviLegaDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkMoviLegaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviLegaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviLegaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviLegaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkMoviLegaDS );
     }
     public stkMoviLegaActionExchange() : base( "stkMoviLega" ) {
     }

     public stkMoviLegaActionExchange(stkMoviLegaActionEnum.EnumstkMoviLegaAction pAccion) : base(stkMoviLegaActionEnum.GetAccionstkMoviLegaAction(pAccion)) {
     }

     public stkMoviLegaActionExchange(stkMoviLegaActionEnum.EnumstkMoviLegaAction pAccion, StockCommon.stkMoviLegaDS pdsParam) : base(stkMoviLegaActionEnum.GetAccionstkMoviLegaAction(pAccion), pdsParam) {
     }

     public stkMoviLegaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkMoviLegaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public stkMoviLegaActionExchange(StockCommon.stkMoviLegaDS pDS) : base() {
     this.Action = "";
     this.mParam = new StockCommon.stkMoviLegaDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkMoviLegaDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkMoviLegaDS)mParam;
	        }
     }
  }
}
