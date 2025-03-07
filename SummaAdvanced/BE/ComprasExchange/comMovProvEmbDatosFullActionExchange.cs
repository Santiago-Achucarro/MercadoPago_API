using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ComprasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class comMovProvEmbDatosFullActionExchange : Framework.Core.Exchange{

        public Int64 conAsientos {
            get {
                if(((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0]["conAsientos"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].conAsientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].conAsientos = value;
               }
	          }
        public bool IsconAsientosNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].IsconAsientosNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String SegmentoSTR {
            get {
                if(((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0]["SegmentoSTR"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].SegmentoSTR;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].SegmentoSTR = value;
               }
	          }
        public bool IsSegmentoSTRNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].IsSegmentoSTRNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvEmbDatosFullDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comMovProvEmbDatosFullDS );
     }
     public comMovProvEmbDatosFullActionExchange() : base( "comMovProvEmbDatosFull" ) {
     }

     public comMovProvEmbDatosFullActionExchange(comMovProvEmbDatosFullActionEnum.EnumcomMovProvEmbDatosFullAction pAccion) : base(comMovProvEmbDatosFullActionEnum.GetAccioncomMovProvEmbDatosFullAction(pAccion)) {
     }

     public comMovProvEmbDatosFullActionExchange(comMovProvEmbDatosFullActionEnum.EnumcomMovProvEmbDatosFullAction pAccion, ComprasCommon.comMovProvEmbDatosFullDS pdsParam) : base(comMovProvEmbDatosFullActionEnum.GetAccioncomMovProvEmbDatosFullAction(pAccion), pdsParam) {
     }

     public comMovProvEmbDatosFullActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comMovProvEmbDatosFullDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comMovProvEmbDatosFullDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comMovProvEmbDatosFullDS)mParam;
	        }
     }
  }
}
