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
    public class stkConsKardexActionExchange : Framework.Core.Exchange{

        public String Producto_Id {
            get {
                if(((StockCommon.stkConsKardexDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkConsKardexDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkConsKardexDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkConsKardexDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((StockCommon.stkConsKardexDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((StockCommon.stkConsKardexDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkConsKardexDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((StockCommon.stkConsKardexDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String DepositoDesde {
            get {
                if(((StockCommon.stkConsKardexDS)mParam).Principal[0]["DepositoDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkConsKardexDS)mParam).Principal[0].DepositoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkConsKardexDS)mParam).Principal[0].DepositoDesde = value;
               }
	          }
        public bool IsDepositoDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkConsKardexDS)mParam).Principal[0].IsDepositoDesdeNull();
             }
	        }
        public String DepositoHasta {
            get {
                if(((StockCommon.stkConsKardexDS)mParam).Principal[0]["DepositoHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkConsKardexDS)mParam).Principal[0].DepositoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkConsKardexDS)mParam).Principal[0].DepositoHasta = value;
               }
	          }
        public bool IsDepositoHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkConsKardexDS)mParam).Principal[0].IsDepositoHastaNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((StockCommon.stkConsKardexDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkConsKardexDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkConsKardexDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkConsKardexDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((StockCommon.stkConsKardexDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkConsKardexDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkConsKardexDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkConsKardexDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Boolean IncluCanc {
            get {
                if(((StockCommon.stkConsKardexDS)mParam).Principal[0]["IncluCanc"] != DBNull.Value  ){
                    return ((StockCommon.stkConsKardexDS)mParam).Principal[0].IncluCanc;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkConsKardexDS)mParam).Principal[0].IncluCanc = value;
               }
	          }
        public bool IsIncluCancNull {
             get {
                 return mParam==null || ((StockCommon.stkConsKardexDS)mParam).Principal[0].IsIncluCancNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkConsKardexDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkConsKardexDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkConsKardexDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkConsKardexDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkConsKardexDS );
     }
     public stkConsKardexActionExchange() : base( "stkConsKardex" ) {
     }

     public stkConsKardexActionExchange(stkConsKardexActionEnum.EnumstkConsKardexAction pAccion) : base(stkConsKardexActionEnum.GetAccionstkConsKardexAction(pAccion)) {
     }

     public stkConsKardexActionExchange(stkConsKardexActionEnum.EnumstkConsKardexAction pAccion, StockCommon.stkConsKardexDS pdsParam) : base(stkConsKardexActionEnum.GetAccionstkConsKardexAction(pAccion), pdsParam) {
     }

     public stkConsKardexActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkConsKardexDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkConsKardexDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkConsKardexDS)mParam;
	        }
     }
  }
}
