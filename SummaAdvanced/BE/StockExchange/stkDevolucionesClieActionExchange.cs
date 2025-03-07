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
    public class stkDevolucionesClieActionExchange : Framework.Core.Exchange{

        public String Segmento_Id {
            get {
                if(((StockCommon.stkDevolucionesClieDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((StockCommon.stkDevolucionesClieDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((StockCommon.stkDevolucionesClieDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((StockCommon.stkDevolucionesClieDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((StockCommon.stkDevolucionesClieDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((StockCommon.stkDevolucionesClieDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((StockCommon.stkDevolucionesClieDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((StockCommon.stkDevolucionesClieDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((StockCommon.stkDevolucionesClieDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String Causa_Id {
            get {
                if(((StockCommon.stkDevolucionesClieDS)mParam).Principal[0]["Causa_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Causa_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Causa_Id = value;
               }
	          }
        public bool IsCausa_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].IsCausa_IdNull();
             }
	        }
        public String DescripcionCausa {
            get {
                if(((StockCommon.stkDevolucionesClieDS)mParam).Principal[0]["DescripcionCausa"] != DBNull.Value  ){
                    return ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].DescripcionCausa;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].DescripcionCausa = value;
               }
	          }
        public bool IsDescripcionCausaNull {
             get {
                 return mParam==null || ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].IsDescripcionCausaNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((StockCommon.stkDevolucionesClieDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String Centro2_Id {
            get {
                if(((StockCommon.stkDevolucionesClieDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String Deposito {
            get {
                if(((StockCommon.stkDevolucionesClieDS)mParam).Principal[0]["Deposito"] != DBNull.Value  ){
                    return ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Deposito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Deposito = value;
               }
	          }
        public bool IsDepositoNull {
             get {
                 return mParam==null || ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].IsDepositoNull();
             }
	        }
        public Int64 stkMoviCabe {
            get {
                if(((StockCommon.stkDevolucionesClieDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Boolean Anulado {
            get {
                if(((StockCommon.stkDevolucionesClieDS)mParam).Principal[0]["Anulado"] != DBNull.Value  ){
                    return ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Anulado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Anulado = value;
               }
	          }
        public bool IsAnuladoNull {
             get {
                 return mParam==null || ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].IsAnuladoNull();
             }
	        }
        public String TipoMov {
            get {
                if(((StockCommon.stkDevolucionesClieDS)mParam).Principal[0]["TipoMov"] != DBNull.Value  ){
                    return ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].TipoMov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].TipoMov = value;
               }
	          }
        public bool IsTipoMovNull {
             get {
                 return mParam==null || ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].IsTipoMovNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkDevolucionesClieDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkDevolucionesClieDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkDevolucionesClieDS );
     }
     public stkDevolucionesClieActionExchange() : base( "stkDevolucionesClie" ) {
     }

     public stkDevolucionesClieActionExchange(stkDevolucionesClieActionEnum.EnumstkDevolucionesClieAction pAccion) : base(stkDevolucionesClieActionEnum.GetAccionstkDevolucionesClieAction(pAccion)) {
     }

     public stkDevolucionesClieActionExchange(stkDevolucionesClieActionEnum.EnumstkDevolucionesClieAction pAccion, StockCommon.stkDevolucionesClieDS pdsParam) : base(stkDevolucionesClieActionEnum.GetAccionstkDevolucionesClieAction(pAccion), pdsParam) {
     }

     public stkDevolucionesClieActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkDevolucionesClieDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkDevolucionesClieDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkDevolucionesClieDS)mParam;
	        }
     }
  }
}
