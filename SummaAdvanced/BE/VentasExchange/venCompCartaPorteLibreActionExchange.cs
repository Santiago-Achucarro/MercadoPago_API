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
    public class venCompCartaPorteLibreActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public DateTime FechaHoraSalida {
            get {
                if(((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0]["FechaHoraSalida"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].FechaHoraSalida;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].FechaHoraSalida = value;
               }
	          }
        public bool IsFechaHoraSalidaNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].IsFechaHoraSalidaNull();
             }
	        }
        public String Archivo {
            get {
                if(((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0]["Archivo"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Archivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Archivo = value;
               }
	          }
        public bool IsArchivoNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].IsArchivoNull();
             }
	        }
        public String NombreArchivo {
            get {
                if(((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0]["NombreArchivo"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].NombreArchivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].NombreArchivo = value;
               }
	          }
        public bool IsNombreArchivoNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].IsNombreArchivoNull();
             }
	        }
        public String Extension {
            get {
                if(((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0]["Extension"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Extension;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Extension = value;
               }
	          }
        public bool IsExtensionNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].IsExtensionNull();
             }
	        }
        public String Camion_Id {
            get {
                if(((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0]["Camion_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Camion_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Camion_Id = value;
               }
	          }
        public bool IsCamion_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].IsCamion_IdNull();
             }
	        }
        public String Remolque1 {
            get {
                if(((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0]["Remolque1"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Remolque1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Remolque1 = value;
               }
	          }
        public bool IsRemolque1Null {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].IsRemolque1Null();
             }
	        }
        public String Remolque2 {
            get {
                if(((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0]["Remolque2"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Remolque2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Remolque2 = value;
               }
	          }
        public bool IsRemolque2Null {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].IsRemolque2Null();
             }
	        }
        public String Operador_Id {
            get {
                if(((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0]["Operador_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Operador_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Operador_Id = value;
               }
	          }
        public bool IsOperador_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].IsOperador_IdNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String XML {
            get {
                if(((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0]["XML"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].XML;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].XML = value;
               }
	          }
        public bool IsXMLNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].IsXMLNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteLibreDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venCompCartaPorteLibreDS );
     }
     public venCompCartaPorteLibreActionExchange() : base( "venCompCartaPorteLibre" ) {
     }

     public venCompCartaPorteLibreActionExchange(venCompCartaPorteLibreActionEnum.EnumvenCompCartaPorteLibreAction pAccion) : base(venCompCartaPorteLibreActionEnum.GetAccionvenCompCartaPorteLibreAction(pAccion)) {
     }

     public venCompCartaPorteLibreActionExchange(venCompCartaPorteLibreActionEnum.EnumvenCompCartaPorteLibreAction pAccion, VentasCommon.venCompCartaPorteLibreDS pdsParam) : base(venCompCartaPorteLibreActionEnum.GetAccionvenCompCartaPorteLibreAction(pAccion), pdsParam) {
     }

     public venCompCartaPorteLibreActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venCompCartaPorteLibreDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venCompCartaPorteLibreActionExchange(VentasCommon.venCompCartaPorteLibreDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venCompCartaPorteLibreDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venCompCartaPorteLibreDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venCompCartaPorteLibreDS)mParam;
	        }
     }
  }
}
