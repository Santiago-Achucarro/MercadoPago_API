using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ContabilidadExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class conAnexoGrupoTiposActionExchange : Framework.Core.Exchange{

        public String GrupoAne_Id {
            get {
                if(((ContabilidadCommon.conAnexoGrupoTiposDS)mParam).Principal[0]["GrupoAne_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAnexoGrupoTiposDS)mParam).Principal[0].GrupoAne_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAnexoGrupoTiposDS)mParam).Principal[0].GrupoAne_Id = value;
               }
	          }
        public bool IsGrupoAne_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAnexoGrupoTiposDS)mParam).Principal[0].IsGrupoAne_IdNull();
             }
	        }
        public String Tipo_Id {
            get {
                if(((ContabilidadCommon.conAnexoGrupoTiposDS)mParam).Principal[0]["Tipo_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAnexoGrupoTiposDS)mParam).Principal[0].Tipo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAnexoGrupoTiposDS)mParam).Principal[0].Tipo_Id = value;
               }
	          }
        public bool IsTipo_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAnexoGrupoTiposDS)mParam).Principal[0].IsTipo_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conAnexoGrupoTiposDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAnexoGrupoTiposDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAnexoGrupoTiposDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAnexoGrupoTiposDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conAnexoGrupoTiposDS );
     }
     public conAnexoGrupoTiposActionExchange() : base( "conAnexoGrupoTipos" ) {
     }

     public conAnexoGrupoTiposActionExchange(conAnexoGrupoTiposActionEnum.EnumconAnexoGrupoTiposAction pAccion) : base(conAnexoGrupoTiposActionEnum.GetAccionconAnexoGrupoTiposAction(pAccion)) {
     }

     public conAnexoGrupoTiposActionExchange(conAnexoGrupoTiposActionEnum.EnumconAnexoGrupoTiposAction pAccion, ContabilidadCommon.conAnexoGrupoTiposDS pdsParam) : base(conAnexoGrupoTiposActionEnum.GetAccionconAnexoGrupoTiposAction(pAccion), pdsParam) {
     }

     public conAnexoGrupoTiposActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conAnexoGrupoTiposDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conAnexoGrupoTiposDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conAnexoGrupoTiposDS)mParam;
	        }
     }
  }
}
