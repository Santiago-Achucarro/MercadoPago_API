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
    public class stkRevaCostoManualActionExchange : Framework.Core.Exchange{

        public Int64 stkMoviCabe {
            get {
                if(((StockCommon.stkRevaCostoManualDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((StockCommon.stkRevaCostoManualDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((StockCommon.stkRevaCostoManualDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((StockCommon.stkRevaCostoManualDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((StockCommon.stkRevaCostoManualDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((StockCommon.stkRevaCostoManualDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((StockCommon.stkRevaCostoManualDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((StockCommon.stkRevaCostoManualDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((StockCommon.stkRevaCostoManualDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((StockCommon.stkRevaCostoManualDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((StockCommon.stkRevaCostoManualDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((StockCommon.stkRevaCostoManualDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((StockCommon.stkRevaCostoManualDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((StockCommon.stkRevaCostoManualDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((StockCommon.stkRevaCostoManualDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public String ProductoDesde {
            get {
                if(((StockCommon.stkRevaCostoManualDS)mParam).Principal[0]["ProductoDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].ProductoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].ProductoDesde = value;
               }
	          }
        public bool IsProductoDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].IsProductoDesdeNull();
             }
	        }
        public String ProductoHasta {
            get {
                if(((StockCommon.stkRevaCostoManualDS)mParam).Principal[0]["ProductoHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].ProductoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].ProductoHasta = value;
               }
	          }
        public bool IsProductoHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].IsProductoHastaNull();
             }
	        }
        public Boolean ParaTodasLasSuc {
            get {
                if(((StockCommon.stkRevaCostoManualDS)mParam).Principal[0]["ParaTodasLasSuc"] != DBNull.Value  ){
                    return ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].ParaTodasLasSuc;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].ParaTodasLasSuc = value;
               }
	          }
        public bool IsParaTodasLasSucNull {
             get {
                 return mParam==null || ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].IsParaTodasLasSucNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkRevaCostoManualDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].IsExisteNull();
             }
	        }
        public String Upload {
            get {
                if(((StockCommon.stkRevaCostoManualDS)mParam).Principal[0]["Upload"] != DBNull.Value  ){
                    return ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Upload;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].Upload = value;
               }
	          }
        public bool IsUploadNull {
             get {
                 return mParam==null || ((StockCommon.stkRevaCostoManualDS)mParam).Principal[0].IsUploadNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkRevaCostoManualDS );
     }
     public stkRevaCostoManualActionExchange() : base( "stkRevaCostoManual" ) {
     }

     public stkRevaCostoManualActionExchange(stkRevaCostoManualActionEnum.EnumstkRevaCostoManualAction pAccion) : base(stkRevaCostoManualActionEnum.GetAccionstkRevaCostoManualAction(pAccion)) {
     }

     public stkRevaCostoManualActionExchange(stkRevaCostoManualActionEnum.EnumstkRevaCostoManualAction pAccion, StockCommon.stkRevaCostoManualDS pdsParam) : base(stkRevaCostoManualActionEnum.GetAccionstkRevaCostoManualAction(pAccion), pdsParam) {
     }

     public stkRevaCostoManualActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkRevaCostoManualDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkRevaCostoManualDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkRevaCostoManualDS)mParam;
	        }
     }
  }
}
