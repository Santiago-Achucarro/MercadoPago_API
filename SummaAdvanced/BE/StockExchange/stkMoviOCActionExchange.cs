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
    public class stkMoviOCActionExchange : Framework.Core.Exchange{

        public Int64 stkMoviCabe {
            get {
                if(((StockCommon.stkMoviOCDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviOCDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviOCDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviOCDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((StockCommon.stkMoviOCDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviOCDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviOCDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviOCDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public Int32 comOrdenComp {
            get {
                if(((StockCommon.stkMoviOCDS)mParam).Principal[0]["comOrdenComp"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviOCDS)mParam).Principal[0].comOrdenComp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviOCDS)mParam).Principal[0].comOrdenComp = value;
               }
	          }
        public bool IscomOrdenCompNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviOCDS)mParam).Principal[0].IscomOrdenCompNull();
             }
	        }
        public Int32 Renglon_OC {
            get {
                if(((StockCommon.stkMoviOCDS)mParam).Principal[0]["Renglon_OC"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviOCDS)mParam).Principal[0].Renglon_OC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviOCDS)mParam).Principal[0].Renglon_OC = value;
               }
	          }
        public bool IsRenglon_OCNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviOCDS)mParam).Principal[0].IsRenglon_OCNull();
             }
	        }
        public String Producto_id {
            get {
                if(((StockCommon.stkMoviOCDS)mParam).Principal[0]["Producto_id"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviOCDS)mParam).Principal[0].Producto_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviOCDS)mParam).Principal[0].Producto_id = value;
               }
	          }
        public bool IsProducto_idNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviOCDS)mParam).Principal[0].IsProducto_idNull();
             }
	        }
        public String DescripcionProducto {
            get {
                if(((StockCommon.stkMoviOCDS)mParam).Principal[0]["DescripcionProducto"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviOCDS)mParam).Principal[0].DescripcionProducto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviOCDS)mParam).Principal[0].DescripcionProducto = value;
               }
	          }
        public bool IsDescripcionProductoNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviOCDS)mParam).Principal[0].IsDescripcionProductoNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((StockCommon.stkMoviOCDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviOCDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviOCDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviOCDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Decimal CantidadOriginal {
            get {
                if(((StockCommon.stkMoviOCDS)mParam).Principal[0]["CantidadOriginal"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviOCDS)mParam).Principal[0].CantidadOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviOCDS)mParam).Principal[0].CantidadOriginal = value;
               }
	          }
        public bool IsCantidadOriginalNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviOCDS)mParam).Principal[0].IsCantidadOriginalNull();
             }
	        }
        public Decimal CantidadOC {
            get {
                if(((StockCommon.stkMoviOCDS)mParam).Principal[0]["CantidadOC"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviOCDS)mParam).Principal[0].CantidadOC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviOCDS)mParam).Principal[0].CantidadOC = value;
               }
	          }
        public bool IsCantidadOCNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviOCDS)mParam).Principal[0].IsCantidadOCNull();
             }
	        }
        public Decimal CantidadOriginalOC {
            get {
                if(((StockCommon.stkMoviOCDS)mParam).Principal[0]["CantidadOriginalOC"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviOCDS)mParam).Principal[0].CantidadOriginalOC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviOCDS)mParam).Principal[0].CantidadOriginalOC = value;
               }
	          }
        public bool IsCantidadOriginalOCNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviOCDS)mParam).Principal[0].IsCantidadOriginalOCNull();
             }
	        }
        public Decimal CantFactPendiente {
            get {
                if(((StockCommon.stkMoviOCDS)mParam).Principal[0]["CantFactPendiente"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviOCDS)mParam).Principal[0].CantFactPendiente;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviOCDS)mParam).Principal[0].CantFactPendiente = value;
               }
	          }
        public bool IsCantFactPendienteNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviOCDS)mParam).Principal[0].IsCantFactPendienteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkMoviOCDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviOCDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviOCDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviOCDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkMoviOCDS );
     }
     public stkMoviOCActionExchange() : base( "stkMoviOC" ) {
     }

     public stkMoviOCActionExchange(stkMoviOCActionEnum.EnumstkMoviOCAction pAccion) : base(stkMoviOCActionEnum.GetAccionstkMoviOCAction(pAccion)) {
     }

     public stkMoviOCActionExchange(stkMoviOCActionEnum.EnumstkMoviOCAction pAccion, StockCommon.stkMoviOCDS pdsParam) : base(stkMoviOCActionEnum.GetAccionstkMoviOCAction(pAccion), pdsParam) {
     }

     public stkMoviOCActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkMoviOCDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkMoviOCDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkMoviOCDS)mParam;
	        }
     }
  }
}
