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
    public class stkProductosCodFiscalActionExchange : Framework.Core.Exchange{

        public String Producto_Id {
            get {
                if(((StockCommon.stkProductosCodFiscalDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCodFiscalDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCodFiscalDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCodFiscalDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String CodigoFiscal {
            get {
                if(((StockCommon.stkProductosCodFiscalDS)mParam).Principal[0]["CodigoFiscal"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCodFiscalDS)mParam).Principal[0].CodigoFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCodFiscalDS)mParam).Principal[0].CodigoFiscal = value;
               }
	          }
        public bool IsCodigoFiscalNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCodFiscalDS)mParam).Principal[0].IsCodigoFiscalNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkProductosCodFiscalDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCodFiscalDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCodFiscalDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCodFiscalDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkProductosCodFiscalDS );
     }
     public stkProductosCodFiscalActionExchange() : base( "stkProductosCodFiscal" ) {
     }

     public stkProductosCodFiscalActionExchange(stkProductosCodFiscalActionEnum.EnumstkProductosCodFiscalAction pAccion) : base(stkProductosCodFiscalActionEnum.GetAccionstkProductosCodFiscalAction(pAccion)) {
     }

     public stkProductosCodFiscalActionExchange(stkProductosCodFiscalActionEnum.EnumstkProductosCodFiscalAction pAccion, StockCommon.stkProductosCodFiscalDS pdsParam) : base(stkProductosCodFiscalActionEnum.GetAccionstkProductosCodFiscalAction(pAccion), pdsParam) {
     }

     public stkProductosCodFiscalActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkProductosCodFiscalDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkProductosCodFiscalDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkProductosCodFiscalDS)mParam;
	        }
     }
  }
}
