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
    public class genUsuariosCambiarClaveActionExchange : Framework.Core.Exchange{

        public String ClaveVieja {
            get {
                if(((GeneralesCommon.genUsuariosCambiarClaveDS)mParam).Principal[0]["ClaveVieja"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosCambiarClaveDS)mParam).Principal[0].ClaveVieja;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosCambiarClaveDS)mParam).Principal[0].ClaveVieja = value;
               }
	          }
        public bool IsClaveViejaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosCambiarClaveDS)mParam).Principal[0].IsClaveViejaNull();
             }
	        }
        public String ClaveNueva1 {
            get {
                if(((GeneralesCommon.genUsuariosCambiarClaveDS)mParam).Principal[0]["ClaveNueva1"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosCambiarClaveDS)mParam).Principal[0].ClaveNueva1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosCambiarClaveDS)mParam).Principal[0].ClaveNueva1 = value;
               }
	          }
        public bool IsClaveNueva1Null {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosCambiarClaveDS)mParam).Principal[0].IsClaveNueva1Null();
             }
	        }
        public String ClaveNueva2 {
            get {
                if(((GeneralesCommon.genUsuariosCambiarClaveDS)mParam).Principal[0]["ClaveNueva2"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosCambiarClaveDS)mParam).Principal[0].ClaveNueva2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosCambiarClaveDS)mParam).Principal[0].ClaveNueva2 = value;
               }
	          }
        public bool IsClaveNueva2Null {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosCambiarClaveDS)mParam).Principal[0].IsClaveNueva2Null();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genUsuariosCambiarClaveDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosCambiarClaveDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosCambiarClaveDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosCambiarClaveDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genUsuariosCambiarClaveDS );
     }
     public genUsuariosCambiarClaveActionExchange() : base( "genUsuariosCambiarClave" ) {
     }

     public genUsuariosCambiarClaveActionExchange(genUsuariosCambiarClaveActionEnum.EnumgenUsuariosCambiarClaveAction pAccion) : base(genUsuariosCambiarClaveActionEnum.GetAcciongenUsuariosCambiarClaveAction(pAccion)) {
     }

     public genUsuariosCambiarClaveActionExchange(genUsuariosCambiarClaveActionEnum.EnumgenUsuariosCambiarClaveAction pAccion, GeneralesCommon.genUsuariosCambiarClaveDS pdsParam) : base(genUsuariosCambiarClaveActionEnum.GetAcciongenUsuariosCambiarClaveAction(pAccion), pdsParam) {
     }

     public genUsuariosCambiarClaveActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genUsuariosCambiarClaveDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genUsuariosCambiarClaveDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genUsuariosCambiarClaveDS)mParam;
	        }
     }
  }
}
