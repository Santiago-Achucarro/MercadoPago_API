using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ContabilidadExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class conAsiMarcaAperturaActionExchange : Framework.Core.Exchange{

        public String Segmento_Id {
            get {
                if(((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public Int32 Ejercicio {
            get {
                if(((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0]["Ejercicio"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Ejercicio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Ejercicio = value;
               }
	          }
        public bool IsEjercicioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].IsEjercicioNull();
             }
	        }
        public String Especial {
            get {
                if(((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0]["Especial"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Especial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Especial = value;
               }
	          }
        public bool IsEspecialNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].IsEspecialNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsiMarcaAperturaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conAsiMarcaAperturaDS );
     }
     public conAsiMarcaAperturaActionExchange() : base( "conAsiMarcaApertura" ) {
     }

     public conAsiMarcaAperturaActionExchange(conAsiMarcaAperturaActionEnum.EnumconAsiMarcaAperturaAction pAccion) : base(conAsiMarcaAperturaActionEnum.GetAccionconAsiMarcaAperturaAction(pAccion)) {
     }

     public conAsiMarcaAperturaActionExchange(conAsiMarcaAperturaActionEnum.EnumconAsiMarcaAperturaAction pAccion, ContabilidadCommon.conAsiMarcaAperturaDS pdsParam) : base(conAsiMarcaAperturaActionEnum.GetAccionconAsiMarcaAperturaAction(pAccion), pdsParam) {
     }

     public conAsiMarcaAperturaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conAsiMarcaAperturaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conAsiMarcaAperturaDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conAsiMarcaAperturaDS)mParam;
	        }
     }
  }
}
