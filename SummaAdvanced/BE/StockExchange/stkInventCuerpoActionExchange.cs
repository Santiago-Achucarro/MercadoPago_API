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
    public class stkInventCuerpoActionExchange : Framework.Core.Exchange{

        public Int32 stkInventarios {
            get {
                if(((StockCommon.stkInventCuerpoDS)mParam).Principal[0]["stkInventarios"] != DBNull.Value  ){
                    return ((StockCommon.stkInventCuerpoDS)mParam).Principal[0].stkInventarios;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventCuerpoDS)mParam).Principal[0].stkInventarios = value;
               }
	          }
        public bool IsstkInventariosNull {
             get {
                 return mParam==null || ((StockCommon.stkInventCuerpoDS)mParam).Principal[0].IsstkInventariosNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((StockCommon.stkInventCuerpoDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkInventCuerpoDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventCuerpoDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkInventCuerpoDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((StockCommon.stkInventCuerpoDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((StockCommon.stkInventCuerpoDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventCuerpoDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((StockCommon.stkInventCuerpoDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Decimal CantidadAlterna {
            get {
                if(((StockCommon.stkInventCuerpoDS)mParam).Principal[0]["CantidadAlterna"] != DBNull.Value  ){
                    return ((StockCommon.stkInventCuerpoDS)mParam).Principal[0].CantidadAlterna;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventCuerpoDS)mParam).Principal[0].CantidadAlterna = value;
               }
	          }
        public bool IsCantidadAlternaNull {
             get {
                 return mParam==null || ((StockCommon.stkInventCuerpoDS)mParam).Principal[0].IsCantidadAlternaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkInventCuerpoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkInventCuerpoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventCuerpoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkInventCuerpoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkInventCuerpoDS );
     }
     public stkInventCuerpoActionExchange() : base( "stkInventCuerpo" ) {
     }

     public stkInventCuerpoActionExchange(stkInventCuerpoActionEnum.EnumstkInventCuerpoAction pAccion) : base(stkInventCuerpoActionEnum.GetAccionstkInventCuerpoAction(pAccion)) {
     }

     public stkInventCuerpoActionExchange(stkInventCuerpoActionEnum.EnumstkInventCuerpoAction pAccion, StockCommon.stkInventCuerpoDS pdsParam) : base(stkInventCuerpoActionEnum.GetAccionstkInventCuerpoAction(pAccion), pdsParam) {
     }

     public stkInventCuerpoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkInventCuerpoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkInventCuerpoDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkInventCuerpoDS)mParam;
	        }
     }
  }
}
