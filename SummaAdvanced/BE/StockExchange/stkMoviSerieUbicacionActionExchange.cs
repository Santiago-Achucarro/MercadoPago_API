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
    public class stkMoviSerieUbicacionActionExchange : Framework.Core.Exchange{

        public Int64 stkMoviCabe {
            get {
                if(((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Serie {
            get {
                if(((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0]["Serie"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0].Serie;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0].Serie = value;
               }
	          }
        public bool IsSerieNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0].IsSerieNull();
             }
	        }
        public String Ubicacion_Id {
            get {
                if(((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0]["Ubicacion_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0].Ubicacion_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0].Ubicacion_Id = value;
               }
	          }
        public bool IsUbicacion_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0].IsUbicacion_IdNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviSerieUbicacionDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkMoviSerieUbicacionDS );
     }
     public stkMoviSerieUbicacionActionExchange() : base( "stkMoviSerieUbicacion" ) {
     }

     public stkMoviSerieUbicacionActionExchange(stkMoviSerieUbicacionActionEnum.EnumstkMoviSerieUbicacionAction pAccion) : base(stkMoviSerieUbicacionActionEnum.GetAccionstkMoviSerieUbicacionAction(pAccion)) {
     }

     public stkMoviSerieUbicacionActionExchange(stkMoviSerieUbicacionActionEnum.EnumstkMoviSerieUbicacionAction pAccion, StockCommon.stkMoviSerieUbicacionDS pdsParam) : base(stkMoviSerieUbicacionActionEnum.GetAccionstkMoviSerieUbicacionAction(pAccion), pdsParam) {
     }

     public stkMoviSerieUbicacionActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkMoviSerieUbicacionDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkMoviSerieUbicacionDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkMoviSerieUbicacionDS)mParam;
	        }
     }
  }
}
