using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace VentasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class venBonifTemporalSegmentoActionExchange : Framework.Core.Exchange{

        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 venBonifTemporal {
            get {
                if(((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0]["venBonifTemporal"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].venBonifTemporal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].venBonifTemporal = value;
               }
	          }
        public bool IsvenBonifTemporalNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].IsvenBonifTemporalNull();
             }
	        }
        public Boolean TieneColumnaAutomatica {
            get {
                if(((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0]["TieneColumnaAutomatica"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].TieneColumnaAutomatica;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].TieneColumnaAutomatica = value;
               }
	          }
        public bool IsTieneColumnaAutomaticaNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].IsTieneColumnaAutomaticaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalSegmentoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venBonifTemporalSegmentoDS );
     }
     public venBonifTemporalSegmentoActionExchange() : base( "venBonifTemporalSegmento" ) {
     }

     public venBonifTemporalSegmentoActionExchange(venBonifTemporalSegmentoActionEnum.EnumvenBonifTemporalSegmentoAction pAccion) : base(venBonifTemporalSegmentoActionEnum.GetAccionvenBonifTemporalSegmentoAction(pAccion)) {
     }

     public venBonifTemporalSegmentoActionExchange(venBonifTemporalSegmentoActionEnum.EnumvenBonifTemporalSegmentoAction pAccion, VentasCommon.venBonifTemporalSegmentoDS pdsParam) : base(venBonifTemporalSegmentoActionEnum.GetAccionvenBonifTemporalSegmentoAction(pAccion), pdsParam) {
     }

     public venBonifTemporalSegmentoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venBonifTemporalSegmentoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venBonifTemporalSegmentoActionExchange(VentasCommon.venBonifTemporalSegmentoDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venBonifTemporalSegmentoDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venBonifTemporalSegmentoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venBonifTemporalSegmentoDS)mParam;
	        }
     }
  }
}
