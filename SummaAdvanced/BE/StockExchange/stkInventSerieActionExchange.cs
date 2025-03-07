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
    public class stkInventSerieActionExchange : Framework.Core.Exchange{

        public Int32 stkInventarios {
            get {
                if(((StockCommon.stkInventSerieDS)mParam).Principal[0]["stkInventarios"] != DBNull.Value  ){
                    return ((StockCommon.stkInventSerieDS)mParam).Principal[0].stkInventarios;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventSerieDS)mParam).Principal[0].stkInventarios = value;
               }
	          }
        public bool IsstkInventariosNull {
             get {
                 return mParam==null || ((StockCommon.stkInventSerieDS)mParam).Principal[0].IsstkInventariosNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((StockCommon.stkInventSerieDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkInventSerieDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventSerieDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkInventSerieDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String Serie {
            get {
                if(((StockCommon.stkInventSerieDS)mParam).Principal[0]["Serie"] != DBNull.Value  ){
                    return ((StockCommon.stkInventSerieDS)mParam).Principal[0].Serie;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventSerieDS)mParam).Principal[0].Serie = value;
               }
	          }
        public bool IsSerieNull {
             get {
                 return mParam==null || ((StockCommon.stkInventSerieDS)mParam).Principal[0].IsSerieNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((StockCommon.stkInventSerieDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((StockCommon.stkInventSerieDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventSerieDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((StockCommon.stkInventSerieDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkInventSerieDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkInventSerieDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkInventSerieDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkInventSerieDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkInventSerieDS );
     }
     public stkInventSerieActionExchange() : base( "stkInventSerie" ) {
     }

     public stkInventSerieActionExchange(stkInventSerieActionEnum.EnumstkInventSerieAction pAccion) : base(stkInventSerieActionEnum.GetAccionstkInventSerieAction(pAccion)) {
     }

     public stkInventSerieActionExchange(stkInventSerieActionEnum.EnumstkInventSerieAction pAccion, StockCommon.stkInventSerieDS pdsParam) : base(stkInventSerieActionEnum.GetAccionstkInventSerieAction(pAccion), pdsParam) {
     }

     public stkInventSerieActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkInventSerieDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public stkInventSerieActionExchange(StockCommon.stkInventSerieDS pDS) : base() {
     this.Action = "";
     this.mParam = new StockCommon.stkInventSerieDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkInventSerieDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkInventSerieDS)mParam;
	        }
     }
  }
}
