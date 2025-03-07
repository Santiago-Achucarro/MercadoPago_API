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
    public class genAdjuntosActionExchange : Framework.Core.Exchange{

        public String Tabla_Id {
            get {
                if(((GeneralesCommon.genAdjuntosDS)mParam).Principal[0]["Tabla_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].Tabla_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].Tabla_Id = value;
               }
	          }
        public bool IsTabla_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].IsTabla_IdNull();
             }
	        }
        public Int64 Identity_Id {
            get {
                if(((GeneralesCommon.genAdjuntosDS)mParam).Principal[0]["Identity_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].Identity_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].Identity_Id = value;
               }
	          }
        public bool IsIdentity_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].IsIdentity_IdNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((GeneralesCommon.genAdjuntosDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Guid {
            get {
                if(((GeneralesCommon.genAdjuntosDS)mParam).Principal[0]["Guid"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].Guid;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].Guid = value;
               }
	          }
        public bool IsGuidNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].IsGuidNull();
             }
	        }
        public String NombreArchivo {
            get {
                if(((GeneralesCommon.genAdjuntosDS)mParam).Principal[0]["NombreArchivo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].NombreArchivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].NombreArchivo = value;
               }
	          }
        public bool IsNombreArchivoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].IsNombreArchivoNull();
             }
	        }
        public String Extension {
            get {
                if(((GeneralesCommon.genAdjuntosDS)mParam).Principal[0]["Extension"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].Extension;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].Extension = value;
               }
	          }
        public bool IsExtensionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].IsExtensionNull();
             }
	        }
        public String ArchivoBase64 {
            get {
                if(((GeneralesCommon.genAdjuntosDS)mParam).Principal[0]["ArchivoBase64"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].ArchivoBase64;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].ArchivoBase64 = value;
               }
	          }
        public bool IsArchivoBase64Null {
             get {
                 return mParam==null || ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].IsArchivoBase64Null();
             }
	        }
        public String Estado {
            get {
                if(((GeneralesCommon.genAdjuntosDS)mParam).Principal[0]["Estado"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].Estado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].Estado = value;
               }
	          }
        public bool IsEstadoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].IsEstadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genAdjuntosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAdjuntosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genAdjuntosDS );
     }
     public genAdjuntosActionExchange() : base( "genAdjuntos" ) {
     }

     public genAdjuntosActionExchange(genAdjuntosActionEnum.EnumgenAdjuntosAction pAccion) : base(genAdjuntosActionEnum.GetAcciongenAdjuntosAction(pAccion)) {
     }

     public genAdjuntosActionExchange(genAdjuntosActionEnum.EnumgenAdjuntosAction pAccion, GeneralesCommon.genAdjuntosDS pdsParam) : base(genAdjuntosActionEnum.GetAcciongenAdjuntosAction(pAccion), pdsParam) {
     }

     public genAdjuntosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genAdjuntosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genAdjuntosDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genAdjuntosDS)mParam;
	        }
     }
  }
}
