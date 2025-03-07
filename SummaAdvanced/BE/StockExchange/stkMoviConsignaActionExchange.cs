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
    public class stkMoviConsignaActionExchange : Framework.Core.Exchange{

        public Int64 stkMoviCabe {
            get {
                if(((StockCommon.stkMoviConsignaDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviConsignaDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviConsignaDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviConsignaDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((StockCommon.stkMoviConsignaDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviConsignaDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviConsignaDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviConsignaDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public Int32 comOrdenComp {
            get {
                if(((StockCommon.stkMoviConsignaDS)mParam).Principal[0]["comOrdenComp"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviConsignaDS)mParam).Principal[0].comOrdenComp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviConsignaDS)mParam).Principal[0].comOrdenComp = value;
               }
	          }
        public bool IscomOrdenCompNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviConsignaDS)mParam).Principal[0].IscomOrdenCompNull();
             }
	        }
        public Int32 Renglon_OC {
            get {
                if(((StockCommon.stkMoviConsignaDS)mParam).Principal[0]["Renglon_OC"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviConsignaDS)mParam).Principal[0].Renglon_OC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviConsignaDS)mParam).Principal[0].Renglon_OC = value;
               }
	          }
        public bool IsRenglon_OCNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviConsignaDS)mParam).Principal[0].IsRenglon_OCNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((StockCommon.stkMoviConsignaDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviConsignaDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviConsignaDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviConsignaDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkMoviConsignaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviConsignaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviConsignaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviConsignaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkMoviConsignaDS );
     }
     public stkMoviConsignaActionExchange() : base( "stkMoviConsigna" ) {
     }

     public stkMoviConsignaActionExchange(stkMoviConsignaActionEnum.EnumstkMoviConsignaAction pAccion) : base(stkMoviConsignaActionEnum.GetAccionstkMoviConsignaAction(pAccion)) {
     }

     public stkMoviConsignaActionExchange(stkMoviConsignaActionEnum.EnumstkMoviConsignaAction pAccion, StockCommon.stkMoviConsignaDS pdsParam) : base(stkMoviConsignaActionEnum.GetAccionstkMoviConsignaAction(pAccion), pdsParam) {
     }

     public stkMoviConsignaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkMoviConsignaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkMoviConsignaDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkMoviConsignaDS)mParam;
	        }
     }
  }
}
