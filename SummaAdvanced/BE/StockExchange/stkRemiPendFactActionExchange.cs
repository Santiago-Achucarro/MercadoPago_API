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
    public class stkRemiPendFactActionExchange : Framework.Core.Exchange{

        public Int64 stkMoviCabe {
            get {
                if(((StockCommon.stkRemiPendFactDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiPendFactDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiPendFactDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiPendFactDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((StockCommon.stkRemiPendFactDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiPendFactDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiPendFactDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiPendFactDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((StockCommon.stkRemiPendFactDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiPendFactDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiPendFactDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiPendFactDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String DescripcionProducto {
            get {
                if(((StockCommon.stkRemiPendFactDS)mParam).Principal[0]["DescripcionProducto"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiPendFactDS)mParam).Principal[0].DescripcionProducto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiPendFactDS)mParam).Principal[0].DescripcionProducto = value;
               }
	          }
        public bool IsDescripcionProductoNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiPendFactDS)mParam).Principal[0].IsDescripcionProductoNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((StockCommon.stkRemiPendFactDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiPendFactDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiPendFactDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiPendFactDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Decimal CantidadPendiente {
            get {
                if(((StockCommon.stkRemiPendFactDS)mParam).Principal[0]["CantidadPendiente"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiPendFactDS)mParam).Principal[0].CantidadPendiente;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiPendFactDS)mParam).Principal[0].CantidadPendiente = value;
               }
	          }
        public bool IsCantidadPendienteNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiPendFactDS)mParam).Principal[0].IsCantidadPendienteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkRemiPendFactDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiPendFactDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiPendFactDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiPendFactDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkRemiPendFactDS );
     }
     public stkRemiPendFactActionExchange() : base( "stkRemiPendFact" ) {
     }

     public stkRemiPendFactActionExchange(stkRemiPendFactActionEnum.EnumstkRemiPendFactAction pAccion) : base(stkRemiPendFactActionEnum.GetAccionstkRemiPendFactAction(pAccion)) {
     }

     public stkRemiPendFactActionExchange(stkRemiPendFactActionEnum.EnumstkRemiPendFactAction pAccion, StockCommon.stkRemiPendFactDS pdsParam) : base(stkRemiPendFactActionEnum.GetAccionstkRemiPendFactAction(pAccion), pdsParam) {
     }

     public stkRemiPendFactActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkRemiPendFactDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkRemiPendFactDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkRemiPendFactDS)mParam;
	        }
     }
  }
}
