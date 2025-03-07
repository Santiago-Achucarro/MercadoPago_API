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
    public class stkCOTArLimitesActionExchange : Framework.Core.Exchange{

        public Decimal CotLimiteKG {
            get {
                if(((StockCommon.stkCOTArLimitesDS)mParam).Principal[0]["CotLimiteKG"] != DBNull.Value  ){
                    return ((StockCommon.stkCOTArLimitesDS)mParam).Principal[0].CotLimiteKG;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCOTArLimitesDS)mParam).Principal[0].CotLimiteKG = value;
               }
	          }
        public bool IsCotLimiteKGNull {
             get {
                 return mParam==null || ((StockCommon.stkCOTArLimitesDS)mParam).Principal[0].IsCotLimiteKGNull();
             }
	        }
        public Decimal CotLimitePES {
            get {
                if(((StockCommon.stkCOTArLimitesDS)mParam).Principal[0]["CotLimitePES"] != DBNull.Value  ){
                    return ((StockCommon.stkCOTArLimitesDS)mParam).Principal[0].CotLimitePES;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCOTArLimitesDS)mParam).Principal[0].CotLimitePES = value;
               }
	          }
        public bool IsCotLimitePESNull {
             get {
                 return mParam==null || ((StockCommon.stkCOTArLimitesDS)mParam).Principal[0].IsCotLimitePESNull();
             }
	        }
        public String CodKilos {
            get {
                if(((StockCommon.stkCOTArLimitesDS)mParam).Principal[0]["CodKilos"] != DBNull.Value  ){
                    return ((StockCommon.stkCOTArLimitesDS)mParam).Principal[0].CodKilos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCOTArLimitesDS)mParam).Principal[0].CodKilos = value;
               }
	          }
        public bool IsCodKilosNull {
             get {
                 return mParam==null || ((StockCommon.stkCOTArLimitesDS)mParam).Principal[0].IsCodKilosNull();
             }
	        }
        public Decimal Atributo {
            get {
                if(((StockCommon.stkCOTArLimitesDS)mParam).Principal[0]["Atributo"] != DBNull.Value  ){
                    return ((StockCommon.stkCOTArLimitesDS)mParam).Principal[0].Atributo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCOTArLimitesDS)mParam).Principal[0].Atributo = value;
               }
	          }
        public bool IsAtributoNull {
             get {
                 return mParam==null || ((StockCommon.stkCOTArLimitesDS)mParam).Principal[0].IsAtributoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkCOTArLimitesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkCOTArLimitesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCOTArLimitesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkCOTArLimitesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkCOTArLimitesDS );
     }
     public stkCOTArLimitesActionExchange() : base( "stkCOTArLimites" ) {
     }

     public stkCOTArLimitesActionExchange(stkCOTArLimitesActionEnum.EnumstkCOTArLimitesAction pAccion) : base(stkCOTArLimitesActionEnum.GetAccionstkCOTArLimitesAction(pAccion)) {
     }

     public stkCOTArLimitesActionExchange(stkCOTArLimitesActionEnum.EnumstkCOTArLimitesAction pAccion, StockCommon.stkCOTArLimitesDS pdsParam) : base(stkCOTArLimitesActionEnum.GetAccionstkCOTArLimitesAction(pAccion), pdsParam) {
     }

     public stkCOTArLimitesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkCOTArLimitesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkCOTArLimitesDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkCOTArLimitesDS)mParam;
	        }
     }
  }
}
