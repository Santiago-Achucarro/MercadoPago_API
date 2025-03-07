using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace TesoreriaExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class tesCFDICobranzaImprimirActionExchange : Framework.Core.Exchange{

        public String Segmento_Id {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String PDF {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0]["PDF"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].PDF;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].PDF = value;
               }
	          }
        public bool IsPDFNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].IsPDFNull();
             }
	        }
        public String XML {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0]["XML"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].XML;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].XML = value;
               }
	          }
        public bool IsXMLNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].IsXMLNull();
             }
	        }
        public String NombreArchivo {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0]["NombreArchivo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].NombreArchivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].NombreArchivo = value;
               }
	          }
        public bool IsNombreArchivoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].IsNombreArchivoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesCFDICobranzaImprimirDS );
     }
     public tesCFDICobranzaImprimirActionExchange() : base( "tesCFDICobranzaImprimir" ) {
     }

     public tesCFDICobranzaImprimirActionExchange(tesCFDICobranzaImprimirActionEnum.EnumtesCFDICobranzaImprimirAction pAccion) : base(tesCFDICobranzaImprimirActionEnum.GetAcciontesCFDICobranzaImprimirAction(pAccion)) {
     }

     public tesCFDICobranzaImprimirActionExchange(tesCFDICobranzaImprimirActionEnum.EnumtesCFDICobranzaImprimirAction pAccion, TesoreriaCommon.tesCFDICobranzaImprimirDS pdsParam) : base(tesCFDICobranzaImprimirActionEnum.GetAcciontesCFDICobranzaImprimirAction(pAccion), pdsParam) {
     }

     public tesCFDICobranzaImprimirActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesCFDICobranzaImprimirDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesCFDICobranzaImprimirDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesCFDICobranzaImprimirDS)mParam;
	        }
     }
  }
}
