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
    public class stkCostoUltimaCompraActionExchange : Framework.Core.Exchange{

        public String Producto_Id {
            get {
                if(((StockCommon.stkCostoUltimaCompraDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkCostoUltimaCompraDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCostoUltimaCompraDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkCostoUltimaCompraDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public Decimal CostoUltCompra {
            get {
                if(((StockCommon.stkCostoUltimaCompraDS)mParam).Principal[0]["CostoUltCompra"] != DBNull.Value  ){
                    return ((StockCommon.stkCostoUltimaCompraDS)mParam).Principal[0].CostoUltCompra;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCostoUltimaCompraDS)mParam).Principal[0].CostoUltCompra = value;
               }
	          }
        public bool IsCostoUltCompraNull {
             get {
                 return mParam==null || ((StockCommon.stkCostoUltimaCompraDS)mParam).Principal[0].IsCostoUltCompraNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkCostoUltimaCompraDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkCostoUltimaCompraDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCostoUltimaCompraDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkCostoUltimaCompraDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkCostoUltimaCompraDS );
     }
     public stkCostoUltimaCompraActionExchange() : base( "stkCostoUltimaCompra" ) {
     }

     public stkCostoUltimaCompraActionExchange(stkCostoUltimaCompraActionEnum.EnumstkCostoUltimaCompraAction pAccion) : base(stkCostoUltimaCompraActionEnum.GetAccionstkCostoUltimaCompraAction(pAccion)) {
     }

     public stkCostoUltimaCompraActionExchange(stkCostoUltimaCompraActionEnum.EnumstkCostoUltimaCompraAction pAccion, StockCommon.stkCostoUltimaCompraDS pdsParam) : base(stkCostoUltimaCompraActionEnum.GetAccionstkCostoUltimaCompraAction(pAccion), pdsParam) {
     }

     public stkCostoUltimaCompraActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkCostoUltimaCompraDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkCostoUltimaCompraDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkCostoUltimaCompraDS)mParam;
	        }
     }
  }
}
