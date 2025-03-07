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
    public class stkProdImagenesXLSActionExchange : Framework.Core.Exchange{

        public String Upload {
            get {
                if(((StockCommon.stkProdImagenesXLSDS)mParam).Principal[0]["Upload"] != DBNull.Value  ){
                    return ((StockCommon.stkProdImagenesXLSDS)mParam).Principal[0].Upload;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProdImagenesXLSDS)mParam).Principal[0].Upload = value;
               }
	          }
        public bool IsUploadNull {
             get {
                 return mParam==null || ((StockCommon.stkProdImagenesXLSDS)mParam).Principal[0].IsUploadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkProdImagenesXLSDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkProdImagenesXLSDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProdImagenesXLSDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkProdImagenesXLSDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkProdImagenesXLSDS );
     }
     public stkProdImagenesXLSActionExchange() : base( "stkProdImagenesXLS" ) {
     }

     public stkProdImagenesXLSActionExchange(stkProdImagenesXLSActionEnum.EnumstkProdImagenesXLSAction pAccion) : base(stkProdImagenesXLSActionEnum.GetAccionstkProdImagenesXLSAction(pAccion)) {
     }

     public stkProdImagenesXLSActionExchange(stkProdImagenesXLSActionEnum.EnumstkProdImagenesXLSAction pAccion, StockCommon.stkProdImagenesXLSDS pdsParam) : base(stkProdImagenesXLSActionEnum.GetAccionstkProdImagenesXLSAction(pAccion), pdsParam) {
     }

     public stkProdImagenesXLSActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkProdImagenesXLSDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkProdImagenesXLSDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkProdImagenesXLSDS)mParam;
	        }
     }
  }
}
