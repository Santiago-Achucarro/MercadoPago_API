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
    public class comOrdenCompImprimirActionExchange : Framework.Core.Exchange{

        public String Segmento_Id {
            get {
                if(((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String PDF {
            get {
                if(((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0]["PDF"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].PDF;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].PDF = value;
               }
	          }
        public bool IsPDFNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].IsPDFNull();
             }
	        }
        public String NombreArchivo {
            get {
                if(((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0]["NombreArchivo"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].NombreArchivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].NombreArchivo = value;
               }
	          }
        public bool IsNombreArchivoNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].IsNombreArchivoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comOrdenCompImprimirDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comOrdenCompImprimirDS );
     }
     public comOrdenCompImprimirActionExchange() : base( "comOrdenCompImprimir" ) {
     }

     public comOrdenCompImprimirActionExchange(comOrdenCompImprimirActionEnum.EnumcomOrdenCompImprimirAction pAccion) : base(comOrdenCompImprimirActionEnum.GetAccioncomOrdenCompImprimirAction(pAccion)) {
     }

     public comOrdenCompImprimirActionExchange(comOrdenCompImprimirActionEnum.EnumcomOrdenCompImprimirAction pAccion, ComprasCommon.comOrdenCompImprimirDS pdsParam) : base(comOrdenCompImprimirActionEnum.GetAccioncomOrdenCompImprimirAction(pAccion), pdsParam) {
     }

     public comOrdenCompImprimirActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comOrdenCompImprimirDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comOrdenCompImprimirDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comOrdenCompImprimirDS)mParam;
	        }
     }
  }
}
