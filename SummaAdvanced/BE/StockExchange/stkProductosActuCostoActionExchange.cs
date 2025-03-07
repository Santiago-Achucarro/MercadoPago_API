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
    public class stkProductosActuCostoActionExchange : Framework.Core.Exchange{

        public String Producto_Id {
            get {
                if(((StockCommon.stkProductosActuCostoDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosActuCostoDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosActuCostoDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosActuCostoDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((StockCommon.stkProductosActuCostoDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosActuCostoDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosActuCostoDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosActuCostoDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Decimal Costo {
            get {
                if(((StockCommon.stkProductosActuCostoDS)mParam).Principal[0]["Costo"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosActuCostoDS)mParam).Principal[0].Costo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosActuCostoDS)mParam).Principal[0].Costo = value;
               }
	          }
        public bool IsCostoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosActuCostoDS)mParam).Principal[0].IsCostoNull();
             }
	        }
        public String TipoCosto {
            get {
                if(((StockCommon.stkProductosActuCostoDS)mParam).Principal[0]["TipoCosto"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosActuCostoDS)mParam).Principal[0].TipoCosto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosActuCostoDS)mParam).Principal[0].TipoCosto = value;
               }
	          }
        public bool IsTipoCostoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosActuCostoDS)mParam).Principal[0].IsTipoCostoNull();
             }
	        }
        public Decimal CostoOriginal {
            get {
                if(((StockCommon.stkProductosActuCostoDS)mParam).Principal[0]["CostoOriginal"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosActuCostoDS)mParam).Principal[0].CostoOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosActuCostoDS)mParam).Principal[0].CostoOriginal = value;
               }
	          }
        public bool IsCostoOriginalNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosActuCostoDS)mParam).Principal[0].IsCostoOriginalNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((StockCommon.stkProductosActuCostoDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosActuCostoDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosActuCostoDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosActuCostoDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkProductosActuCostoDS );
     }
     public stkProductosActuCostoActionExchange() : base( "stkProductosActuCosto" ) {
     }

     public stkProductosActuCostoActionExchange(stkProductosActuCostoActionEnum.EnumstkProductosActuCostoAction pAccion) : base(stkProductosActuCostoActionEnum.GetAccionstkProductosActuCostoAction(pAccion)) {
     }

     public stkProductosActuCostoActionExchange(stkProductosActuCostoActionEnum.EnumstkProductosActuCostoAction pAccion, StockCommon.stkProductosActuCostoDS pdsParam) : base(stkProductosActuCostoActionEnum.GetAccionstkProductosActuCostoAction(pAccion), pdsParam) {
     }

     public stkProductosActuCostoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkProductosActuCostoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkProductosActuCostoDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkProductosActuCostoDS)mParam;
	        }
     }
  }
}
