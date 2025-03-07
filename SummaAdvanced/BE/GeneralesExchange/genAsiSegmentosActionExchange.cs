using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genAsiSegmentosActionExchange : Framework.Core.Exchange{

        public Int32 Empresa_Id {
            get {
                if(((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public String DescripcionSegmentos {
            get {
                if(((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0]["DescripcionSegmentos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].DescripcionSegmentos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].DescripcionSegmentos = value;
               }
	          }
        public bool IsDescripcionSegmentosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].IsDescripcionSegmentosNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int64 Asiento_Id {
            get {
                if(((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0]["Asiento_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Asiento_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Asiento_Id = value;
               }
	          }
        public bool IsAsiento_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].IsAsiento_IdNull();
             }
	        }
        public Boolean TieneAutomatico {
            get {
                if(((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0]["TieneAutomatico"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].TieneAutomatico;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].TieneAutomatico = value;
               }
	          }
        public bool IsTieneAutomaticoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].IsTieneAutomaticoNull();
             }
	        }
        public String Segmento_Str {
            get {
                if(((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0]["Segmento_Str"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Segmento_Str;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Segmento_Str = value;
               }
	          }
        public bool IsSegmento_StrNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].IsSegmento_StrNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAsiSegmentosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genAsiSegmentosDS );
     }
     public genAsiSegmentosActionExchange() : base( "genAsiSegmentos" ) {
     }

     public genAsiSegmentosActionExchange(genAsiSegmentosActionEnum.EnumgenAsiSegmentosAction pAccion) : base(genAsiSegmentosActionEnum.GetAcciongenAsiSegmentosAction(pAccion)) {
     }

     public genAsiSegmentosActionExchange(genAsiSegmentosActionEnum.EnumgenAsiSegmentosAction pAccion, GeneralesCommon.genAsiSegmentosDS pdsParam) : base(genAsiSegmentosActionEnum.GetAcciongenAsiSegmentosAction(pAccion), pdsParam) {
     }

     public genAsiSegmentosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genAsiSegmentosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genAsiSegmentosDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genAsiSegmentosDS)mParam;
	        }
     }
  }
}
