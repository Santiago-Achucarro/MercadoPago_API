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
    public class venMovimientosImprimirActionExchange : Framework.Core.Exchange{

        public String Segmento_Id {
            get {
                if(((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String PDF {
            get {
                if(((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0]["PDF"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].PDF;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].PDF = value;
               }
	          }
        public bool IsPDFNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].IsPDFNull();
             }
	        }
        public String XML {
            get {
                if(((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0]["XML"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].XML;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].XML = value;
               }
	          }
        public bool IsXMLNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].IsXMLNull();
             }
	        }
        public String NombreArchivo {
            get {
                if(((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0]["NombreArchivo"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].NombreArchivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].NombreArchivo = value;
               }
	          }
        public bool IsNombreArchivoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].IsNombreArchivoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].IsExisteNull();
             }
	        }
        public Int32 ComprobanteHasta {
            get {
                if(((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0]["ComprobanteHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].ComprobanteHasta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].ComprobanteHasta = value;
               }
	          }
        public bool IsComprobanteHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].IsComprobanteHastaNull();
             }
	        }
        public Boolean SaltarPrimero {
            get {
                if(((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0]["SaltarPrimero"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].SaltarPrimero;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].SaltarPrimero = value;
               }
	          }
        public bool IsSaltarPrimeroNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].IsSaltarPrimeroNull();
             }
	        }
        public Boolean Anulado {
            get {
                if(((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0]["Anulado"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].Anulado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].Anulado = value;
               }
	          }
        public bool IsAnuladoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosImprimirDS)mParam).Principal[0].IsAnuladoNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMovimientosImprimirDS );
     }
     public venMovimientosImprimirActionExchange() : base( "venMovimientosImprimir" ) {
     }

     public venMovimientosImprimirActionExchange(venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction pAccion) : base(venMovimientosImprimirActionEnum.GetAccionvenMovimientosImprimirAction(pAccion)) {
     }

     public venMovimientosImprimirActionExchange(venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction pAccion, VentasCommon.venMovimientosImprimirDS pdsParam) : base(venMovimientosImprimirActionEnum.GetAccionvenMovimientosImprimirAction(pAccion), pdsParam) {
     }

     public venMovimientosImprimirActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMovimientosImprimirDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venMovimientosImprimirActionExchange(VentasCommon.venMovimientosImprimirDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venMovimientosImprimirDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMovimientosImprimirDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMovimientosImprimirDS)mParam;
	        }
     }
  }
}
