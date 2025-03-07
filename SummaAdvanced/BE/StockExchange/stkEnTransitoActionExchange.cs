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
    public class stkEnTransitoActionExchange : Framework.Core.Exchange{

        public Int64 stkMoviCabe {
            get {
                if(((StockCommon.stkEnTransitoDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((StockCommon.stkEnTransitoDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEnTransitoDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((StockCommon.stkEnTransitoDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((StockCommon.stkEnTransitoDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((StockCommon.stkEnTransitoDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((StockCommon.stkEnTransitoDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((StockCommon.stkEnTransitoDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((StockCommon.stkEnTransitoDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((StockCommon.stkEnTransitoDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((StockCommon.stkEnTransitoDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((StockCommon.stkEnTransitoDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((StockCommon.stkEnTransitoDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((StockCommon.stkEnTransitoDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((StockCommon.stkEnTransitoDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((StockCommon.stkEnTransitoDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((StockCommon.stkEnTransitoDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((StockCommon.stkEnTransitoDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((StockCommon.stkEnTransitoDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((StockCommon.stkEnTransitoDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 Segmento1NEntr {
            get {
                if(((StockCommon.stkEnTransitoDS)mParam).Principal[0]["Segmento1NEntr"] != DBNull.Value  ){
                    return ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento1NEntr;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento1NEntr = value;
               }
	          }
        public bool IsSegmento1NEntrNull {
             get {
                 return mParam==null || ((StockCommon.stkEnTransitoDS)mParam).Principal[0].IsSegmento1NEntrNull();
             }
	        }
        public Int32 Segmento2NEntr {
            get {
                if(((StockCommon.stkEnTransitoDS)mParam).Principal[0]["Segmento2NEntr"] != DBNull.Value  ){
                    return ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento2NEntr;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento2NEntr = value;
               }
	          }
        public bool IsSegmento2NEntrNull {
             get {
                 return mParam==null || ((StockCommon.stkEnTransitoDS)mParam).Principal[0].IsSegmento2NEntrNull();
             }
	        }
        public Int32 Segmento3NEntr {
            get {
                if(((StockCommon.stkEnTransitoDS)mParam).Principal[0]["Segmento3NEntr"] != DBNull.Value  ){
                    return ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento3NEntr;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento3NEntr = value;
               }
	          }
        public bool IsSegmento3NEntrNull {
             get {
                 return mParam==null || ((StockCommon.stkEnTransitoDS)mParam).Principal[0].IsSegmento3NEntrNull();
             }
	        }
        public Int32 Segmento4NEntr {
            get {
                if(((StockCommon.stkEnTransitoDS)mParam).Principal[0]["Segmento4NEntr"] != DBNull.Value  ){
                    return ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento4NEntr;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento4NEntr = value;
               }
	          }
        public bool IsSegmento4NEntrNull {
             get {
                 return mParam==null || ((StockCommon.stkEnTransitoDS)mParam).Principal[0].IsSegmento4NEntrNull();
             }
	        }
        public Int64 stkMoviCabeEntr {
            get {
                if(((StockCommon.stkEnTransitoDS)mParam).Principal[0]["stkMoviCabeEntr"] != DBNull.Value  ){
                    return ((StockCommon.stkEnTransitoDS)mParam).Principal[0].stkMoviCabeEntr;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEnTransitoDS)mParam).Principal[0].stkMoviCabeEntr = value;
               }
	          }
        public bool IsstkMoviCabeEntrNull {
             get {
                 return mParam==null || ((StockCommon.stkEnTransitoDS)mParam).Principal[0].IsstkMoviCabeEntrNull();
             }
	        }
        public String Segmento1CEntr {
            get {
                if(((StockCommon.stkEnTransitoDS)mParam).Principal[0]["Segmento1CEntr"] != DBNull.Value  ){
                    return ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento1CEntr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento1CEntr = value;
               }
	          }
        public bool IsSegmento1CEntrNull {
             get {
                 return mParam==null || ((StockCommon.stkEnTransitoDS)mParam).Principal[0].IsSegmento1CEntrNull();
             }
	        }
        public String Segmento2CEntr {
            get {
                if(((StockCommon.stkEnTransitoDS)mParam).Principal[0]["Segmento2CEntr"] != DBNull.Value  ){
                    return ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento2CEntr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento2CEntr = value;
               }
	          }
        public bool IsSegmento2CEntrNull {
             get {
                 return mParam==null || ((StockCommon.stkEnTransitoDS)mParam).Principal[0].IsSegmento2CEntrNull();
             }
	        }
        public String Segmento3CEntr {
            get {
                if(((StockCommon.stkEnTransitoDS)mParam).Principal[0]["Segmento3CEntr"] != DBNull.Value  ){
                    return ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento3CEntr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento3CEntr = value;
               }
	          }
        public bool IsSegmento3CEntrNull {
             get {
                 return mParam==null || ((StockCommon.stkEnTransitoDS)mParam).Principal[0].IsSegmento3CEntrNull();
             }
	        }
        public String Segmento4CEntr {
            get {
                if(((StockCommon.stkEnTransitoDS)mParam).Principal[0]["Segmento4CEntr"] != DBNull.Value  ){
                    return ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento4CEntr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Segmento4CEntr = value;
               }
	          }
        public bool IsSegmento4CEntrNull {
             get {
                 return mParam==null || ((StockCommon.stkEnTransitoDS)mParam).Principal[0].IsSegmento4CEntrNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((StockCommon.stkEnTransitoDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkEnTransitoDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String DescripcionDepositos {
            get {
                if(((StockCommon.stkEnTransitoDS)mParam).Principal[0]["DescripcionDepositos"] != DBNull.Value  ){
                    return ((StockCommon.stkEnTransitoDS)mParam).Principal[0].DescripcionDepositos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEnTransitoDS)mParam).Principal[0].DescripcionDepositos = value;
               }
	          }
        public bool IsDescripcionDepositosNull {
             get {
                 return mParam==null || ((StockCommon.stkEnTransitoDS)mParam).Principal[0].IsDescripcionDepositosNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkEnTransitoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkEnTransitoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkEnTransitoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkEnTransitoDS );
     }
     public stkEnTransitoActionExchange() : base( "stkEnTransito" ) {
     }

     public stkEnTransitoActionExchange(stkEnTransitoActionEnum.EnumstkEnTransitoAction pAccion) : base(stkEnTransitoActionEnum.GetAccionstkEnTransitoAction(pAccion)) {
     }

     public stkEnTransitoActionExchange(stkEnTransitoActionEnum.EnumstkEnTransitoAction pAccion, StockCommon.stkEnTransitoDS pdsParam) : base(stkEnTransitoActionEnum.GetAccionstkEnTransitoAction(pAccion), pdsParam) {
     }

     public stkEnTransitoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkEnTransitoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkEnTransitoDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkEnTransitoDS)mParam;
	        }
     }
  }
}
