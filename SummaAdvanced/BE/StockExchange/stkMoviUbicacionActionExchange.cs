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
    public class stkMoviUbicacionActionExchange : Framework.Core.Exchange{

        public Boolean Existe {
            get {
                if(((StockCommon.stkMoviUbicacionDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviUbicacionDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviUbicacionDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviUbicacionDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkMoviUbicacionDS );
     }
     public stkMoviUbicacionActionExchange() : base( "stkMoviUbicacion" ) {
     }

     public stkMoviUbicacionActionExchange(stkMoviUbicacionActionEnum.EnumstkMoviUbicacionAction pAccion) : base(stkMoviUbicacionActionEnum.GetAccionstkMoviUbicacionAction(pAccion)) {
     }

     public stkMoviUbicacionActionExchange(stkMoviUbicacionActionEnum.EnumstkMoviUbicacionAction pAccion, StockCommon.stkMoviUbicacionDS pdsParam) : base(stkMoviUbicacionActionEnum.GetAccionstkMoviUbicacionAction(pAccion), pdsParam) {
     }

     public stkMoviUbicacionActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkMoviUbicacionDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public stkMoviUbicacionActionExchange(StockCommon.stkMoviUbicacionDS pDS) : base() {
     this.Action = "";
     this.mParam = new StockCommon.stkMoviUbicacionDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkMoviUbicacionDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkMoviUbicacionDS)mParam;
	        }
     }
  }
}
