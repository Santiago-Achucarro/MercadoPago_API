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
    public class genGruposPertenceActionExchange : Framework.Core.Exchange{

        public String Grupo_id {
            get {
                if(((GeneralesCommon.genGruposPertenceDS)mParam).Principal[0]["Grupo_id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGruposPertenceDS)mParam).Principal[0].Grupo_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGruposPertenceDS)mParam).Principal[0].Grupo_id = value;
               }
	          }
        public bool IsGrupo_idNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGruposPertenceDS)mParam).Principal[0].IsGrupo_idNull();
             }
	        }
        public Boolean Pertenese {
            get {
                if(((GeneralesCommon.genGruposPertenceDS)mParam).Principal[0]["Pertenese"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGruposPertenceDS)mParam).Principal[0].Pertenese;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGruposPertenceDS)mParam).Principal[0].Pertenese = value;
               }
	          }
        public bool IsPerteneseNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGruposPertenceDS)mParam).Principal[0].IsPerteneseNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genGruposPertenceDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGruposPertenceDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGruposPertenceDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGruposPertenceDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genGruposPertenceDS );
     }
     public genGruposPertenceActionExchange() : base( "genGruposPertence" ) {
     }

     public genGruposPertenceActionExchange(genGruposPertenceActionEnum.EnumgenGruposPertenceAction pAccion) : base(genGruposPertenceActionEnum.GetAcciongenGruposPertenceAction(pAccion)) {
     }

     public genGruposPertenceActionExchange(genGruposPertenceActionEnum.EnumgenGruposPertenceAction pAccion, GeneralesCommon.genGruposPertenceDS pdsParam) : base(genGruposPertenceActionEnum.GetAcciongenGruposPertenceAction(pAccion), pdsParam) {
     }

     public genGruposPertenceActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genGruposPertenceDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genGruposPertenceDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genGruposPertenceDS)mParam;
	        }
     }
  }
}
