using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace SueldosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class sueVariableGrupoActionExchange : Framework.Core.Exchange{

        public Int32 Legajo {
            get {
                if(((SueldosCommon.sueVariableGrupoDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVariableGrupoDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVariableGrupoDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVariableGrupoDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public Int32 Grupo_Id {
            get {
                if(((SueldosCommon.sueVariableGrupoDS)mParam).Principal[0]["Grupo_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVariableGrupoDS)mParam).Principal[0].Grupo_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVariableGrupoDS)mParam).Principal[0].Grupo_Id = value;
               }
	          }
        public bool IsGrupo_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVariableGrupoDS)mParam).Principal[0].IsGrupo_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueVariableGrupoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueVariableGrupoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueVariableGrupoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueVariableGrupoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueVariableGrupoDS );
     }
     public sueVariableGrupoActionExchange() : base( "sueVariableGrupo" ) {
     }

     public sueVariableGrupoActionExchange(sueVariableGrupoActionEnum.EnumsueVariableGrupoAction pAccion) : base(sueVariableGrupoActionEnum.GetAccionsueVariableGrupoAction(pAccion)) {
     }

     public sueVariableGrupoActionExchange(sueVariableGrupoActionEnum.EnumsueVariableGrupoAction pAccion, SueldosCommon.sueVariableGrupoDS pdsParam) : base(sueVariableGrupoActionEnum.GetAccionsueVariableGrupoAction(pAccion), pdsParam) {
     }

     public sueVariableGrupoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueVariableGrupoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueVariableGrupoDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueVariableGrupoDS)mParam;
	        }
     }
  }
}
