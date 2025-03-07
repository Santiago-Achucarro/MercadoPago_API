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
    public class stkMoviEmbarqueActionExchange : Framework.Core.Exchange{

        public Int64 stkMoviCabe {
            get {
                if(((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Int64 comEmbarques {
            get {
                if(((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0]["comEmbarques"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0].comEmbarques;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0].comEmbarques = value;
               }
	          }
        public bool IscomEmbarquesNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0].IscomEmbarquesNull();
             }
	        }
        public String Proveed_Id {
            get {
                if(((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String RemitoProv {
            get {
                if(((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0]["RemitoProv"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0].RemitoProv;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0].RemitoProv = value;
               }
	          }
        public bool IsRemitoProvNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0].IsRemitoProvNull();
             }
	        }
        public String Despacho_Id {
            get {
                if(((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0]["Despacho_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0].Despacho_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0].Despacho_Id = value;
               }
	          }
        public bool IsDespacho_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0].IsDespacho_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviEmbarqueDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkMoviEmbarqueDS );
     }
     public stkMoviEmbarqueActionExchange() : base( "stkMoviEmbarque" ) {
     }

     public stkMoviEmbarqueActionExchange(stkMoviEmbarqueActionEnum.EnumstkMoviEmbarqueAction pAccion) : base(stkMoviEmbarqueActionEnum.GetAccionstkMoviEmbarqueAction(pAccion)) {
     }

     public stkMoviEmbarqueActionExchange(stkMoviEmbarqueActionEnum.EnumstkMoviEmbarqueAction pAccion, StockCommon.stkMoviEmbarqueDS pdsParam) : base(stkMoviEmbarqueActionEnum.GetAccionstkMoviEmbarqueAction(pAccion), pdsParam) {
     }

     public stkMoviEmbarqueActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkMoviEmbarqueDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkMoviEmbarqueDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkMoviEmbarqueDS)mParam;
	        }
     }
  }
}
