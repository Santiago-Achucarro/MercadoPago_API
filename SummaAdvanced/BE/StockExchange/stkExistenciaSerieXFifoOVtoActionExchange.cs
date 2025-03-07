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
    public class stkExistenciaSerieXFifoOVtoActionExchange : Framework.Core.Exchange{

        public String Producto_Id {
            get {
                if(((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkExistenciaSerieXFifoOVtoDS );
     }
     public stkExistenciaSerieXFifoOVtoActionExchange() : base( "stkExistenciaSerieXFifoOVto" ) {
     }

     public stkExistenciaSerieXFifoOVtoActionExchange(stkExistenciaSerieXFifoOVtoActionEnum.EnumstkExistenciaSerieXFifoOVtoAction pAccion) : base(stkExistenciaSerieXFifoOVtoActionEnum.GetAccionstkExistenciaSerieXFifoOVtoAction(pAccion)) {
     }

     public stkExistenciaSerieXFifoOVtoActionExchange(stkExistenciaSerieXFifoOVtoActionEnum.EnumstkExistenciaSerieXFifoOVtoAction pAccion, StockCommon.stkExistenciaSerieXFifoOVtoDS pdsParam) : base(stkExistenciaSerieXFifoOVtoActionEnum.GetAccionstkExistenciaSerieXFifoOVtoAction(pAccion), pdsParam) {
     }

     public stkExistenciaSerieXFifoOVtoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkExistenciaSerieXFifoOVtoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public stkExistenciaSerieXFifoOVtoActionExchange(StockCommon.stkExistenciaSerieXFifoOVtoDS pDS) : base() {
     this.Action = "";
     this.mParam = new StockCommon.stkExistenciaSerieXFifoOVtoDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkExistenciaSerieXFifoOVtoDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkExistenciaSerieXFifoOVtoDS)mParam;
	        }
     }
  }
}
