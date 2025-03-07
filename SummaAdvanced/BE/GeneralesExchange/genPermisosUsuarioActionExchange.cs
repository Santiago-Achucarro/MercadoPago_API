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
    public class genPermisosUsuarioActionExchange : Framework.Core.Exchange{

        public String Usuario_Id {
            get {
                if(((GeneralesCommon.genPermisosUsuarioDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPermisosUsuarioDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPermisosUsuarioDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPermisosUsuarioDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String Apellido_y_Nombres {
            get {
                if(((GeneralesCommon.genPermisosUsuarioDS)mParam).Principal[0]["Apellido_y_Nombres"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPermisosUsuarioDS)mParam).Principal[0].Apellido_y_Nombres;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPermisosUsuarioDS)mParam).Principal[0].Apellido_y_Nombres = value;
               }
	          }
        public bool IsApellido_y_NombresNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPermisosUsuarioDS)mParam).Principal[0].IsApellido_y_NombresNull();
             }
	        }
        public Boolean EsSupervisor {
            get {
                if(((GeneralesCommon.genPermisosUsuarioDS)mParam).Principal[0]["EsSupervisor"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPermisosUsuarioDS)mParam).Principal[0].EsSupervisor;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPermisosUsuarioDS)mParam).Principal[0].EsSupervisor = value;
               }
	          }
        public bool IsEsSupervisorNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPermisosUsuarioDS)mParam).Principal[0].IsEsSupervisorNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genPermisosUsuarioDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genPermisosUsuarioDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genPermisosUsuarioDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genPermisosUsuarioDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genPermisosUsuarioDS );
     }
     public genPermisosUsuarioActionExchange() : base( "genPermisosUsuario" ) {
     }

     public genPermisosUsuarioActionExchange(genPermisosUsuarioActionEnum.EnumgenPermisosUsuarioAction pAccion) : base(genPermisosUsuarioActionEnum.GetAcciongenPermisosUsuarioAction(pAccion)) {
     }

     public genPermisosUsuarioActionExchange(genPermisosUsuarioActionEnum.EnumgenPermisosUsuarioAction pAccion, GeneralesCommon.genPermisosUsuarioDS pdsParam) : base(genPermisosUsuarioActionEnum.GetAcciongenPermisosUsuarioAction(pAccion), pdsParam) {
     }

     public genPermisosUsuarioActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genPermisosUsuarioDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genPermisosUsuarioDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genPermisosUsuarioDS)mParam;
	        }
     }
  }
}
