using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace SueldosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class sueConcAcumSegmentoActionExchange : Framework.Core.Exchange{

        public String Segmento_Id {
            get {
                if(((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento1N_Nueva {
            get {
                if(((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0]["Segmento1N_Nueva"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Segmento1N_Nueva;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Segmento1N_Nueva = value;
               }
	          }
        public bool IsSegmento1N_NuevaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].IsSegmento1N_NuevaNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Int32 sueConcAcum {
            get {
                if(((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0]["sueConcAcum"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].sueConcAcum;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].sueConcAcum = value;
               }
	          }
        public bool IssueConcAcumNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].IssueConcAcumNull();
             }
	        }
        public Boolean TieneColumnaAutomatica {
            get {
                if(((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0]["TieneColumnaAutomatica"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].TieneColumnaAutomatica;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].TieneColumnaAutomatica = value;
               }
	          }
        public bool IsTieneColumnaAutomaticaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].IsTieneColumnaAutomaticaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcAcumSegmentoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueConcAcumSegmentoDS );
     }
     public sueConcAcumSegmentoActionExchange() : base( "sueConcAcumSegmento" ) {
     }

     public sueConcAcumSegmentoActionExchange(sueConcAcumSegmentoActionEnum.EnumsueConcAcumSegmentoAction pAccion) : base(sueConcAcumSegmentoActionEnum.GetAccionsueConcAcumSegmentoAction(pAccion)) {
     }

     public sueConcAcumSegmentoActionExchange(sueConcAcumSegmentoActionEnum.EnumsueConcAcumSegmentoAction pAccion, SueldosCommon.sueConcAcumSegmentoDS pdsParam) : base(sueConcAcumSegmentoActionEnum.GetAccionsueConcAcumSegmentoAction(pAccion), pdsParam) {
     }

     public sueConcAcumSegmentoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueConcAcumSegmentoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueConcAcumSegmentoDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueConcAcumSegmentoDS)mParam;
	        }
     }
  }
}
