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
    public class genAtributosProvinciaActionExchange : Framework.Core.Exchange{

        public String ProvinciaC {
            get {
                if(((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0]["ProvinciaC"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0].ProvinciaC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0].ProvinciaC = value;
               }
	          }
        public bool IsProvinciaCNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0].IsProvinciaCNull();
             }
	        }
        public Int32 ProvinciaN {
            get {
                if(((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0]["ProvinciaN"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0].ProvinciaN;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0].ProvinciaN = value;
               }
	          }
        public bool IsProvinciaNNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0].IsProvinciaNNull();
             }
	        }
        public Int32 AtributoNro {
            get {
                if(((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0]["AtributoNro"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0].AtributoNro;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0].AtributoNro = value;
               }
	          }
        public bool IsAtributoNroNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0].IsAtributoNroNull();
             }
	        }
        public String Provincia_Id {
            get {
                if(((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0]["Provincia_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0].Provincia_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0].Provincia_Id = value;
               }
	          }
        public bool IsProvincia_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0].IsProvincia_IdNull();
             }
	        }
        public String DescripcionProvincia {
            get {
                if(((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0]["DescripcionProvincia"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0].DescripcionProvincia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0].DescripcionProvincia = value;
               }
	          }
        public bool IsDescripcionProvinciaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0].IsDescripcionProvinciaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosProvinciaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genAtributosProvinciaDS );
     }
     public genAtributosProvinciaActionExchange() : base( "genAtributosProvincia" ) {
     }

     public genAtributosProvinciaActionExchange(genAtributosProvinciaActionEnum.EnumgenAtributosProvinciaAction pAccion) : base(genAtributosProvinciaActionEnum.GetAcciongenAtributosProvinciaAction(pAccion)) {
     }

     public genAtributosProvinciaActionExchange(genAtributosProvinciaActionEnum.EnumgenAtributosProvinciaAction pAccion, GeneralesCommon.genAtributosProvinciaDS pdsParam) : base(genAtributosProvinciaActionEnum.GetAcciongenAtributosProvinciaAction(pAccion), pdsParam) {
     }

     public genAtributosProvinciaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genAtributosProvinciaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genAtributosProvinciaDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genAtributosProvinciaDS)mParam;
	        }
     }
  }
}
