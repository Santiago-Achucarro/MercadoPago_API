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
    public class stkMoviCausaActionExchange : Framework.Core.Exchange{

        public Int64 stkMoviCabe {
            get {
                if(((StockCommon.stkMoviCausaDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCausaDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCausaDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCausaDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public String Causa_Id {
            get {
                if(((StockCommon.stkMoviCausaDS)mParam).Principal[0]["Causa_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCausaDS)mParam).Principal[0].Causa_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCausaDS)mParam).Principal[0].Causa_Id = value;
               }
	          }
        public bool IsCausa_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCausaDS)mParam).Principal[0].IsCausa_IdNull();
             }
	        }
        public String DescripcionCausasMovi {
            get {
                if(((StockCommon.stkMoviCausaDS)mParam).Principal[0]["DescripcionCausasMovi"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCausaDS)mParam).Principal[0].DescripcionCausasMovi;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCausaDS)mParam).Principal[0].DescripcionCausasMovi = value;
               }
	          }
        public bool IsDescripcionCausasMoviNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCausaDS)mParam).Principal[0].IsDescripcionCausasMoviNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((StockCommon.stkMoviCausaDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCausaDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCausaDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCausaDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((StockCommon.stkMoviCausaDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCausaDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCausaDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((StockCommon.stkMoviCausaDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((StockCommon.stkMoviCausaDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCausaDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCausaDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCausaDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((StockCommon.stkMoviCausaDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCausaDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCausaDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((StockCommon.stkMoviCausaDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkMoviCausaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCausaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCausaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCausaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkMoviCausaDS );
     }
     public stkMoviCausaActionExchange() : base( "stkMoviCausa" ) {
     }

     public stkMoviCausaActionExchange(stkMoviCausaActionEnum.EnumstkMoviCausaAction pAccion) : base(stkMoviCausaActionEnum.GetAccionstkMoviCausaAction(pAccion)) {
     }

     public stkMoviCausaActionExchange(stkMoviCausaActionEnum.EnumstkMoviCausaAction pAccion, StockCommon.stkMoviCausaDS pdsParam) : base(stkMoviCausaActionEnum.GetAccionstkMoviCausaAction(pAccion), pdsParam) {
     }

     public stkMoviCausaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkMoviCausaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkMoviCausaDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkMoviCausaDS)mParam;
	        }
     }
  }
}
