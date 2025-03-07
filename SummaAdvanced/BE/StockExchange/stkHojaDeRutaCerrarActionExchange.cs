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
    public class stkHojaDeRutaCerrarActionExchange : Framework.Core.Exchange{

        public String Segmento_Id {
            get {
                if(((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public DateTime FechaRegistro {
            get {
                if(((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0]["FechaRegistro"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].FechaRegistro;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].FechaRegistro = value;
               }
	          }
        public bool IsFechaRegistroNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].IsFechaRegistroNull();
             }
	        }
        public String Estado {
            get {
                if(((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0]["Estado"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].Estado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].Estado = value;
               }
	          }
        public bool IsEstadoNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].IsEstadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaCerrarDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkHojaDeRutaCerrarDS );
     }
     public stkHojaDeRutaCerrarActionExchange() : base( "stkHojaDeRutaCerrar" ) {
     }

     public stkHojaDeRutaCerrarActionExchange(stkHojaDeRutaCerrarActionEnum.EnumstkHojaDeRutaCerrarAction pAccion) : base(stkHojaDeRutaCerrarActionEnum.GetAccionstkHojaDeRutaCerrarAction(pAccion)) {
     }

     public stkHojaDeRutaCerrarActionExchange(stkHojaDeRutaCerrarActionEnum.EnumstkHojaDeRutaCerrarAction pAccion, StockCommon.stkHojaDeRutaCerrarDS pdsParam) : base(stkHojaDeRutaCerrarActionEnum.GetAccionstkHojaDeRutaCerrarAction(pAccion), pdsParam) {
     }

     public stkHojaDeRutaCerrarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkHojaDeRutaCerrarDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkHojaDeRutaCerrarDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkHojaDeRutaCerrarDS)mParam;
	        }
     }
  }
}
