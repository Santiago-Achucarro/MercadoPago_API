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
    public class stkMaxMinActionExchange : Framework.Core.Exchange{

        public String Deposito_Id {
            get {
                if(((StockCommon.stkMaxMinDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkMaxMinDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMaxMinDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkMaxMinDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String DescripcionDeposito {
            get {
                if(((StockCommon.stkMaxMinDS)mParam).Principal[0]["DescripcionDeposito"] != DBNull.Value  ){
                    return ((StockCommon.stkMaxMinDS)mParam).Principal[0].DescripcionDeposito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMaxMinDS)mParam).Principal[0].DescripcionDeposito = value;
               }
	          }
        public bool IsDescripcionDepositoNull {
             get {
                 return mParam==null || ((StockCommon.stkMaxMinDS)mParam).Principal[0].IsDescripcionDepositoNull();
             }
	        }
        public String Excel {
            get {
                if(((StockCommon.stkMaxMinDS)mParam).Principal[0]["Excel"] != DBNull.Value  ){
                    return ((StockCommon.stkMaxMinDS)mParam).Principal[0].Excel;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMaxMinDS)mParam).Principal[0].Excel = value;
               }
	          }
        public bool IsExcelNull {
             get {
                 return mParam==null || ((StockCommon.stkMaxMinDS)mParam).Principal[0].IsExcelNull();
             }
	        }
        public Boolean Quita_No_Existentes {
            get {
                if(((StockCommon.stkMaxMinDS)mParam).Principal[0]["Quita_No_Existentes"] != DBNull.Value  ){
                    return ((StockCommon.stkMaxMinDS)mParam).Principal[0].Quita_No_Existentes;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMaxMinDS)mParam).Principal[0].Quita_No_Existentes = value;
               }
	          }
        public bool IsQuita_No_ExistentesNull {
             get {
                 return mParam==null || ((StockCommon.stkMaxMinDS)mParam).Principal[0].IsQuita_No_ExistentesNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkMaxMinDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkMaxMinDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMaxMinDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkMaxMinDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkMaxMinDS );
     }
     public stkMaxMinActionExchange() : base( "stkMaxMin" ) {
     }

     public stkMaxMinActionExchange(stkMaxMinActionEnum.EnumstkMaxMinAction pAccion) : base(stkMaxMinActionEnum.GetAccionstkMaxMinAction(pAccion)) {
     }

     public stkMaxMinActionExchange(stkMaxMinActionEnum.EnumstkMaxMinAction pAccion, StockCommon.stkMaxMinDS pdsParam) : base(stkMaxMinActionEnum.GetAccionstkMaxMinAction(pAccion), pdsParam) {
     }

     public stkMaxMinActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkMaxMinDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkMaxMinDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkMaxMinDS)mParam;
	        }
     }
  }
}
