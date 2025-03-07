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
    public class genLogRequestActionExchange : Framework.Core.Exchange{

        public Int32 genLogRequest {
            get {
                if(((GeneralesCommon.genLogRequestDS)mParam).Principal[0]["genLogRequest"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].genLogRequest;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].genLogRequest = value;
               }
	          }
        public bool IsgenLogRequestNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].IsgenLogRequestNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((GeneralesCommon.genLogRequestDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String NombreClase {
            get {
                if(((GeneralesCommon.genLogRequestDS)mParam).Principal[0]["NombreClase"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].NombreClase;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].NombreClase = value;
               }
	          }
        public bool IsNombreClaseNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].IsNombreClaseNull();
             }
	        }
        public String Tipo {
            get {
                if(((GeneralesCommon.genLogRequestDS)mParam).Principal[0]["Tipo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Tipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Tipo = value;
               }
	          }
        public bool IsTipoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].IsTipoNull();
             }
	        }
        public String Request {
            get {
                if(((GeneralesCommon.genLogRequestDS)mParam).Principal[0]["Request"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Request;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Request = value;
               }
	          }
        public bool IsRequestNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].IsRequestNull();
             }
	        }
        public String RequestEsp {
            get {
                if(((GeneralesCommon.genLogRequestDS)mParam).Principal[0]["RequestEsp"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].RequestEsp;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].RequestEsp = value;
               }
	          }
        public bool IsRequestEspNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].IsRequestEspNull();
             }
	        }
        public String Accion {
            get {
                if(((GeneralesCommon.genLogRequestDS)mParam).Principal[0]["Accion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Accion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Accion = value;
               }
	          }
        public bool IsAccionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].IsAccionNull();
             }
	        }
        public DateTime FechaRegistro {
            get {
                if(((GeneralesCommon.genLogRequestDS)mParam).Principal[0]["FechaRegistro"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].FechaRegistro;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].FechaRegistro = value;
               }
	          }
        public bool IsFechaRegistroNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].IsFechaRegistroNull();
             }
	        }
        public String Formulario_Id {
            get {
                if(((GeneralesCommon.genLogRequestDS)mParam).Principal[0]["Formulario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Formulario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Formulario_Id = value;
               }
	          }
        public bool IsFormulario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].IsFormulario_IdNull();
             }
	        }
        public Int32 Usuario_Id {
            get {
                if(((GeneralesCommon.genLogRequestDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((GeneralesCommon.genLogRequestDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((GeneralesCommon.genLogRequestDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((GeneralesCommon.genLogRequestDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((GeneralesCommon.genLogRequestDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((GeneralesCommon.genLogRequestDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((GeneralesCommon.genLogRequestDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((GeneralesCommon.genLogRequestDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((GeneralesCommon.genLogRequestDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((GeneralesCommon.genLogRequestDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genLogRequestDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLogRequestDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genLogRequestDS );
     }
     public genLogRequestActionExchange() : base( "genLogRequest" ) {
     }

     public genLogRequestActionExchange(genLogRequestActionEnum.EnumgenLogRequestAction pAccion) : base(genLogRequestActionEnum.GetAcciongenLogRequestAction(pAccion)) {
     }

     public genLogRequestActionExchange(genLogRequestActionEnum.EnumgenLogRequestAction pAccion, GeneralesCommon.genLogRequestDS pdsParam) : base(genLogRequestActionEnum.GetAcciongenLogRequestAction(pAccion), pdsParam) {
     }

     public genLogRequestActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genLogRequestDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public genLogRequestActionExchange(GeneralesCommon.genLogRequestDS pDS) : base() {
     this.Action = "";
     this.mParam = new GeneralesCommon.genLogRequestDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genLogRequestDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genLogRequestDS)mParam;
	        }
     }
  }
}
