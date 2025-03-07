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
    public class stockMovCuerpoCierreActionExchange : Framework.Core.Exchange{

        public Int32 stkProductos {
            get {
                if(((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0]["stkProductos"] != DBNull.Value  ){
                    return ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].stkProductos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].stkProductos = value;
               }
	          }
        public bool IsstkProductosNull {
             get {
                 return mParam==null || ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].IsstkProductosNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public Decimal CostoUnitario {
            get {
                if(((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0]["CostoUnitario"] != DBNull.Value  ){
                    return ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].CostoUnitario;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].CostoUnitario = value;
               }
	          }
        public bool IsCostoUnitarioNull {
             get {
                 return mParam==null || ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].IsCostoUnitarioNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Decimal PrecioOriginal {
            get {
                if(((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0]["PrecioOriginal"] != DBNull.Value  ){
                    return ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].PrecioOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].PrecioOriginal = value;
               }
	          }
        public bool IsPrecioOriginalNull {
             get {
                 return mParam==null || ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].IsPrecioOriginalNull();
             }
	        }
        public Int32 conRenglonDebe {
            get {
                if(((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0]["conRenglonDebe"] != DBNull.Value  ){
                    return ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].conRenglonDebe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].conRenglonDebe = value;
               }
	          }
        public bool IsconRenglonDebeNull {
             get {
                 return mParam==null || ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].IsconRenglonDebeNull();
             }
	        }
        public Int32 conRenglonHaber {
            get {
                if(((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0]["conRenglonHaber"] != DBNull.Value  ){
                    return ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].conRenglonHaber;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].conRenglonHaber = value;
               }
	          }
        public bool IsconRenglonHaberNull {
             get {
                 return mParam==null || ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].IsconRenglonHaberNull();
             }
	        }
        public String CtaAjuInventario {
            get {
                if(((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0]["CtaAjuInventario"] != DBNull.Value  ){
                    return ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].CtaAjuInventario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].CtaAjuInventario = value;
               }
	          }
        public bool IsCtaAjuInventarioNull {
             get {
                 return mParam==null || ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].IsCtaAjuInventarioNull();
             }
	        }
        public String CtaCompra {
            get {
                if(((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0]["CtaCompra"] != DBNull.Value  ){
                    return ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].CtaCompra;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].CtaCompra = value;
               }
	          }
        public bool IsCtaCompraNull {
             get {
                 return mParam==null || ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].IsCtaCompraNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String Centro2_Id {
            get {
                if(((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stockMovCuerpoCierreDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stockMovCuerpoCierreDS );
     }
     public stockMovCuerpoCierreActionExchange() : base( "stockMovCuerpoCierre" ) {
     }

     public stockMovCuerpoCierreActionExchange(stockMovCuerpoCierreActionEnum.EnumstockMovCuerpoCierreAction pAccion) : base(stockMovCuerpoCierreActionEnum.GetAccionstockMovCuerpoCierreAction(pAccion)) {
     }

     public stockMovCuerpoCierreActionExchange(stockMovCuerpoCierreActionEnum.EnumstockMovCuerpoCierreAction pAccion, StockCommon.stockMovCuerpoCierreDS pdsParam) : base(stockMovCuerpoCierreActionEnum.GetAccionstockMovCuerpoCierreAction(pAccion), pdsParam) {
     }

     public stockMovCuerpoCierreActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stockMovCuerpoCierreDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stockMovCuerpoCierreDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stockMovCuerpoCierreDS)mParam;
	        }
     }
  }
}
