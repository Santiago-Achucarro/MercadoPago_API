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
    public class grdMoviSerieActionExchange : Framework.Core.Exchange{

        public Boolean Existe {
            get {
                if(((StockCommon.grdMoviSerieDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.grdMoviSerieDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.grdMoviSerieDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.grdMoviSerieDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.grdMoviSerieDS );
     }
     public grdMoviSerieActionExchange() : base( "grdMoviSerie" ) {
     }

     public grdMoviSerieActionExchange(grdMoviSerieActionEnum.EnumgrdMoviSerieAction pAccion) : base(grdMoviSerieActionEnum.GetAcciongrdMoviSerieAction(pAccion)) {
     }

     public grdMoviSerieActionExchange(grdMoviSerieActionEnum.EnumgrdMoviSerieAction pAccion, StockCommon.grdMoviSerieDS pdsParam) : base(grdMoviSerieActionEnum.GetAcciongrdMoviSerieAction(pAccion), pdsParam) {
     }

     public grdMoviSerieActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.grdMoviSerieDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public grdMoviSerieActionExchange(StockCommon.grdMoviSerieDS pDS) : base() {
     this.Action = "";
     this.mParam = new StockCommon.grdMoviSerieDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.grdMoviSerieDS Param{
	        get{
			    InitParam();
			    return (StockCommon.grdMoviSerieDS)mParam;
	        }
     }
  }
}
