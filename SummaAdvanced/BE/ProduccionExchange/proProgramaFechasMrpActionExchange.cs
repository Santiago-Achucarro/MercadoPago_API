using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ProduccionExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class proProgramaFechasMrpActionExchange : Framework.Core.Exchange{

        public String Segmento_Id {
            get {
                if(((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Boolean IncluPendiente {
            get {
                if(((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0]["IncluPendiente"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].IncluPendiente;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].IncluPendiente = value;
               }
	          }
        public bool IsIncluPendienteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].IsIncluPendienteNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].IsExisteNull();
             }
	        }
        public String ProgramaStr {
            get {
                if(((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0]["ProgramaStr"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].ProgramaStr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].ProgramaStr = value;
               }
	          }
        public bool IsProgramaStrNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaFechasMrpDS)mParam).Principal[0].IsProgramaStrNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proProgramaFechasMrpDS );
     }
     public proProgramaFechasMrpActionExchange() : base( "proProgramaFechasMrp" ) {
     }

     public proProgramaFechasMrpActionExchange(proProgramaFechasMrpActionEnum.EnumproProgramaFechasMrpAction pAccion) : base(proProgramaFechasMrpActionEnum.GetAccionproProgramaFechasMrpAction(pAccion)) {
     }

     public proProgramaFechasMrpActionExchange(proProgramaFechasMrpActionEnum.EnumproProgramaFechasMrpAction pAccion, ProduccionCommon.proProgramaFechasMrpDS pdsParam) : base(proProgramaFechasMrpActionEnum.GetAccionproProgramaFechasMrpAction(pAccion), pdsParam) {
     }

     public proProgramaFechasMrpActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proProgramaFechasMrpDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proProgramaFechasMrpDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proProgramaFechasMrpDS)mParam;
	        }
     }
  }
}
