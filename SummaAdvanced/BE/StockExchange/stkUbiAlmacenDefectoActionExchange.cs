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
    public class stkUbiAlmacenDefectoActionExchange : Framework.Core.Exchange{

        public String Deposito_Id {
            get {
                if(((StockCommon.stkUbiAlmacenDefectoDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkUbiAlmacenDefectoDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUbiAlmacenDefectoDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkUbiAlmacenDefectoDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((StockCommon.stkUbiAlmacenDefectoDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkUbiAlmacenDefectoDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUbiAlmacenDefectoDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkUbiAlmacenDefectoDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String DescripcionProductos {
            get {
                if(((StockCommon.stkUbiAlmacenDefectoDS)mParam).Principal[0]["DescripcionProductos"] != DBNull.Value  ){
                    return ((StockCommon.stkUbiAlmacenDefectoDS)mParam).Principal[0].DescripcionProductos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUbiAlmacenDefectoDS)mParam).Principal[0].DescripcionProductos = value;
               }
	          }
        public bool IsDescripcionProductosNull {
             get {
                 return mParam==null || ((StockCommon.stkUbiAlmacenDefectoDS)mParam).Principal[0].IsDescripcionProductosNull();
             }
	        }
        public String Ubicacion_Id {
            get {
                if(((StockCommon.stkUbiAlmacenDefectoDS)mParam).Principal[0]["Ubicacion_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkUbiAlmacenDefectoDS)mParam).Principal[0].Ubicacion_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUbiAlmacenDefectoDS)mParam).Principal[0].Ubicacion_Id = value;
               }
	          }
        public bool IsUbicacion_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkUbiAlmacenDefectoDS)mParam).Principal[0].IsUbicacion_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkUbiAlmacenDefectoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkUbiAlmacenDefectoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkUbiAlmacenDefectoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkUbiAlmacenDefectoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkUbiAlmacenDefectoDS );
     }
     public stkUbiAlmacenDefectoActionExchange() : base( "stkUbiAlmacenDefecto" ) {
     }

     public stkUbiAlmacenDefectoActionExchange(stkUbiAlmacenDefectoActionEnum.EnumstkUbiAlmacenDefectoAction pAccion) : base(stkUbiAlmacenDefectoActionEnum.GetAccionstkUbiAlmacenDefectoAction(pAccion)) {
     }

     public stkUbiAlmacenDefectoActionExchange(stkUbiAlmacenDefectoActionEnum.EnumstkUbiAlmacenDefectoAction pAccion, StockCommon.stkUbiAlmacenDefectoDS pdsParam) : base(stkUbiAlmacenDefectoActionEnum.GetAccionstkUbiAlmacenDefectoAction(pAccion), pdsParam) {
     }

     public stkUbiAlmacenDefectoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkUbiAlmacenDefectoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public stkUbiAlmacenDefectoActionExchange(StockCommon.stkUbiAlmacenDefectoDS pDS) : base() {
     this.Action = "";
     this.mParam = new StockCommon.stkUbiAlmacenDefectoDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkUbiAlmacenDefectoDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkUbiAlmacenDefectoDS)mParam;
	        }
     }
  }
}
