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
    public class StockCerrarActionExchange : Framework.Core.Exchange{

        public DateTime UltimoCierre {
            get {
                if(((StockCommon.StockCerrarDS)mParam).Principal[0]["UltimoCierre"] != DBNull.Value  ){
                    return ((StockCommon.StockCerrarDS)mParam).Principal[0].UltimoCierre;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.StockCerrarDS)mParam).Principal[0].UltimoCierre = value;
               }
	          }
        public bool IsUltimoCierreNull {
             get {
                 return mParam==null || ((StockCommon.StockCerrarDS)mParam).Principal[0].IsUltimoCierreNull();
             }
	        }
        public DateTime ProximoCierre {
            get {
                if(((StockCommon.StockCerrarDS)mParam).Principal[0]["ProximoCierre"] != DBNull.Value  ){
                    return ((StockCommon.StockCerrarDS)mParam).Principal[0].ProximoCierre;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.StockCerrarDS)mParam).Principal[0].ProximoCierre = value;
               }
	          }
        public bool IsProximoCierreNull {
             get {
                 return mParam==null || ((StockCommon.StockCerrarDS)mParam).Principal[0].IsProximoCierreNull();
             }
	        }
        public DateTime FechaCalculoStock {
            get {
                if(((StockCommon.StockCerrarDS)mParam).Principal[0]["FechaCalculoStock"] != DBNull.Value  ){
                    return ((StockCommon.StockCerrarDS)mParam).Principal[0].FechaCalculoStock;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.StockCerrarDS)mParam).Principal[0].FechaCalculoStock = value;
               }
	          }
        public bool IsFechaCalculoStockNull {
             get {
                 return mParam==null || ((StockCommon.StockCerrarDS)mParam).Principal[0].IsFechaCalculoStockNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.StockCerrarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.StockCerrarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.StockCerrarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.StockCerrarDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.StockCerrarDS );
     }
     public StockCerrarActionExchange() : base( "StockCerrar" ) {
     }

     public StockCerrarActionExchange(StockCerrarActionEnum.EnumStockCerrarAction pAccion) : base(StockCerrarActionEnum.GetAccionStockCerrarAction(pAccion)) {
     }

     public StockCerrarActionExchange(StockCerrarActionEnum.EnumStockCerrarAction pAccion, StockCommon.StockCerrarDS pdsParam) : base(StockCerrarActionEnum.GetAccionStockCerrarAction(pAccion), pdsParam) {
     }

     public StockCerrarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.StockCerrarDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.StockCerrarDS Param{
	        get{
			    InitParam();
			    return (StockCommon.StockCerrarDS)mParam;
	        }
     }
  }
}
