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
    public class proOrdenCerrarrActionExchange : Framework.Core.Exchange{

        public Int32 proOrden {
            get {
                if(((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0]["proOrden"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].proOrden;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].proOrden = value;
               }
	          }
        public bool IsproOrdenNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].IsproOrdenNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String Observaciones {
            get {
                if(((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public DateTime FechaFin {
            get {
                if(((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0]["FechaFin"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].FechaFin;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].FechaFin = value;
               }
	          }
        public bool IsFechaFinNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].IsFechaFinNull();
             }
	        }
        public Decimal CantIngPendiente {
            get {
                if(((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0]["CantIngPendiente"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].CantIngPendiente;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].CantIngPendiente = value;
               }
	          }
        public bool IsCantIngPendienteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].IsCantIngPendienteNull();
             }
	        }
        public Boolean Anulado {
            get {
                if(((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0]["Anulado"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Anulado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Anulado = value;
               }
	          }
        public bool IsAnuladoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].IsAnuladoNull();
             }
	        }
        public String TipoCierre {
            get {
                if(((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0]["TipoCierre"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].TipoCierre;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].TipoCierre = value;
               }
	          }
        public bool IsTipoCierreNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].IsTipoCierreNull();
             }
	        }
        public String Causa_Id {
            get {
                if(((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0]["Causa_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Causa_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Causa_Id = value;
               }
	          }
        public bool IsCausa_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].IsCausa_IdNull();
             }
	        }
        public String DescripcionCausa {
            get {
                if(((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0]["DescripcionCausa"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].DescripcionCausa;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].DescripcionCausa = value;
               }
	          }
        public bool IsDescripcionCausaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].IsDescripcionCausaNull();
             }
	        }
        public Int64 proMovCierreOrden {
            get {
                if(((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0]["proMovCierreOrden"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].proMovCierreOrden;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].proMovCierreOrden = value;
               }
	          }
        public bool IsproMovCierreOrdenNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].IsproMovCierreOrdenNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenCerrarrDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proOrdenCerrarrDS );
     }
     public proOrdenCerrarrActionExchange() : base( "proOrdenCerrarr" ) {
     }

     public proOrdenCerrarrActionExchange(proOrdenCerrarrActionEnum.EnumproOrdenCerrarrAction pAccion) : base(proOrdenCerrarrActionEnum.GetAccionproOrdenCerrarrAction(pAccion)) {
     }

     public proOrdenCerrarrActionExchange(proOrdenCerrarrActionEnum.EnumproOrdenCerrarrAction pAccion, ProduccionCommon.proOrdenCerrarrDS pdsParam) : base(proOrdenCerrarrActionEnum.GetAccionproOrdenCerrarrAction(pAccion), pdsParam) {
     }

     public proOrdenCerrarrActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proOrdenCerrarrDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public proOrdenCerrarrActionExchange(ProduccionCommon.proOrdenCerrarrDS pDS) : base() {
     this.Action = "";
     this.mParam = new ProduccionCommon.proOrdenCerrarrDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proOrdenCerrarrDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proOrdenCerrarrDS)mParam;
	        }
     }
  }
}
