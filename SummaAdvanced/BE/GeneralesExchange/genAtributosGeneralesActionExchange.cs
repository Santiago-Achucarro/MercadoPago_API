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
    public class genAtributosGeneralesActionExchange : Framework.Core.Exchange{

        public Int32 AtributoNro {
            get {
                if(((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0]["AtributoNro"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0].AtributoNro;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0].AtributoNro = value;
               }
	          }
        public bool IsAtributoNroNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0].IsAtributoNroNull();
             }
	        }
        public String Tabla_Id {
            get {
                if(((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0]["Tabla_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0].Tabla_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0].Tabla_Id = value;
               }
	          }
        public bool IsTabla_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0].IsTabla_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Tipo {
            get {
                if(((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0]["Tipo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0].Tipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0].Tipo = value;
               }
	          }
        public bool IsTipoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0].IsTipoNull();
             }
	        }
        public Boolean EnGrilla {
            get {
                if(((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0]["EnGrilla"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0].EnGrilla;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0].EnGrilla = value;
               }
	          }
        public bool IsEnGrillaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0].IsEnGrillaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosGeneralesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genAtributosGeneralesDS );
     }
     public genAtributosGeneralesActionExchange() : base( "genAtributosGenerales" ) {
     }

     public genAtributosGeneralesActionExchange(genAtributosGeneralesActionEnum.EnumgenAtributosGeneralesAction pAccion) : base(genAtributosGeneralesActionEnum.GetAcciongenAtributosGeneralesAction(pAccion)) {
     }

     public genAtributosGeneralesActionExchange(genAtributosGeneralesActionEnum.EnumgenAtributosGeneralesAction pAccion, GeneralesCommon.genAtributosGeneralesDS pdsParam) : base(genAtributosGeneralesActionEnum.GetAcciongenAtributosGeneralesAction(pAccion), pdsParam) {
     }

     public genAtributosGeneralesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genAtributosGeneralesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genAtributosGeneralesDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genAtributosGeneralesDS)mParam;
	        }
     }
  }
}
