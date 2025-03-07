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
    public class stkConsStockActionExchange : Framework.Core.Exchange{

        public String Producto_Id {
            get {
                if(((StockCommon.stkConsStockDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkConsStockDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkConsStockDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkConsStockDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((StockCommon.stkConsStockDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkConsStockDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkConsStockDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkConsStockDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkConsStockDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkConsStockDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkConsStockDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkConsStockDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkConsStockDS );
     }
     public stkConsStockActionExchange() : base( "stkConsStock" ) {
     }

     public stkConsStockActionExchange(stkConsStockActionEnum.EnumstkConsStockAction pAccion) : base(stkConsStockActionEnum.GetAccionstkConsStockAction(pAccion)) {
     }

     public stkConsStockActionExchange(stkConsStockActionEnum.EnumstkConsStockAction pAccion, StockCommon.stkConsStockDS pdsParam) : base(stkConsStockActionEnum.GetAccionstkConsStockAction(pAccion), pdsParam) {
     }

     public stkConsStockActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkConsStockDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkConsStockDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkConsStockDS)mParam;
	        }
     }
  }
}
