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
    public class stkRemiConformaActionExchange : Framework.Core.Exchange{

        public Int64 stkMoviCabe {
            get {
                if(((StockCommon.stkRemiConformaDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiConformaDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiConformaDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiConformaDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((StockCommon.stkRemiConformaDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiConformaDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((StockCommon.stkRemiConformaDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiConformaDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((StockCommon.stkRemiConformaDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiConformaDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((StockCommon.stkRemiConformaDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiConformaDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((StockCommon.stkRemiConformaDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiConformaDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((StockCommon.stkRemiConformaDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiConformaDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((StockCommon.stkRemiConformaDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiConformaDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((StockCommon.stkRemiConformaDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiConformaDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((StockCommon.stkRemiConformaDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiConformaDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((StockCommon.stkRemiConformaDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiConformaDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Boolean Anulado {
            get {
                if(((StockCommon.stkRemiConformaDS)mParam).Principal[0]["Anulado"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Anulado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Anulado = value;
               }
	          }
        public bool IsAnuladoNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiConformaDS)mParam).Principal[0].IsAnuladoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((StockCommon.stkRemiConformaDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiConformaDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((StockCommon.stkRemiConformaDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiConformaDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((StockCommon.stkRemiConformaDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiConformaDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiConformaDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiConformaDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((StockCommon.stkRemiConformaDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiConformaDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((StockCommon.stkRemiConformaDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiConformaDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiConformaDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiConformaDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public DateTime FechaConforma {
            get {
                if(((StockCommon.stkRemiConformaDS)mParam).Principal[0]["FechaConforma"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiConformaDS)mParam).Principal[0].FechaConforma;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiConformaDS)mParam).Principal[0].FechaConforma = value;
               }
	          }
        public bool IsFechaConformaNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiConformaDS)mParam).Principal[0].IsFechaConformaNull();
             }
	        }
        public DateTime FechaRegistro {
            get {
                if(((StockCommon.stkRemiConformaDS)mParam).Principal[0]["FechaRegistro"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiConformaDS)mParam).Principal[0].FechaRegistro;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiConformaDS)mParam).Principal[0].FechaRegistro = value;
               }
	          }
        public bool IsFechaRegistroNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiConformaDS)mParam).Principal[0].IsFechaRegistroNull();
             }
	        }
        public String Observaciones {
            get {
                if(((StockCommon.stkRemiConformaDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiConformaDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkRemiConformaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkRemiConformaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkRemiConformaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkRemiConformaDS );
     }
     public stkRemiConformaActionExchange() : base( "stkRemiConforma" ) {
     }

     public stkRemiConformaActionExchange(stkRemiConformaActionEnum.EnumstkRemiConformaAction pAccion) : base(stkRemiConformaActionEnum.GetAccionstkRemiConformaAction(pAccion)) {
     }

     public stkRemiConformaActionExchange(stkRemiConformaActionEnum.EnumstkRemiConformaAction pAccion, StockCommon.stkRemiConformaDS pdsParam) : base(stkRemiConformaActionEnum.GetAccionstkRemiConformaAction(pAccion), pdsParam) {
     }

     public stkRemiConformaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkRemiConformaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkRemiConformaDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkRemiConformaDS)mParam;
	        }
     }
  }
}
