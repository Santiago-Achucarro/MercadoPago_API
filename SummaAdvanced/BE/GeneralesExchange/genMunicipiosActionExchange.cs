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
    public class genMunicipiosActionExchange : Framework.Core.Exchange{

        public String c_Municipio {
            get {
                if(((GeneralesCommon.genMunicipiosDS)mParam).Principal[0]["c_Municipio"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMunicipiosDS)mParam).Principal[0].c_Municipio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMunicipiosDS)mParam).Principal[0].c_Municipio = value;
               }
	          }
        public bool Isc_MunicipioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMunicipiosDS)mParam).Principal[0].Isc_MunicipioNull();
             }
	        }
        public String c_Estado {
            get {
                if(((GeneralesCommon.genMunicipiosDS)mParam).Principal[0]["c_Estado"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMunicipiosDS)mParam).Principal[0].c_Estado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMunicipiosDS)mParam).Principal[0].c_Estado = value;
               }
	          }
        public bool Isc_EstadoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMunicipiosDS)mParam).Principal[0].Isc_EstadoNull();
             }
	        }
        public String Descripcion {
            get {
                if(((GeneralesCommon.genMunicipiosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMunicipiosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMunicipiosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMunicipiosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genMunicipiosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMunicipiosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMunicipiosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMunicipiosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genMunicipiosDS );
     }
     public genMunicipiosActionExchange() : base( "genMunicipios" ) {
     }

     public genMunicipiosActionExchange(genMunicipiosActionEnum.EnumgenMunicipiosAction pAccion) : base(genMunicipiosActionEnum.GetAcciongenMunicipiosAction(pAccion)) {
     }

     public genMunicipiosActionExchange(genMunicipiosActionEnum.EnumgenMunicipiosAction pAccion, GeneralesCommon.genMunicipiosDS pdsParam) : base(genMunicipiosActionEnum.GetAcciongenMunicipiosAction(pAccion), pdsParam) {
     }

     public genMunicipiosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genMunicipiosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public genMunicipiosActionExchange(GeneralesCommon.genMunicipiosDS pDS) : base() {
     this.Action = "";
     this.mParam = new GeneralesCommon.genMunicipiosDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genMunicipiosDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genMunicipiosDS)mParam;
	        }
     }
  }
}
