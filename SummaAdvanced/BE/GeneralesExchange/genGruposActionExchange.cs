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
    public class genGruposActionExchange : Framework.Core.Exchange{

        public String Usuario_Id {
            get {
                if(((GeneralesCommon.genGruposDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGruposDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGruposDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGruposDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String Apellido_y_Nombres {
            get {
                if(((GeneralesCommon.genGruposDS)mParam).Principal[0]["Apellido_y_Nombres"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGruposDS)mParam).Principal[0].Apellido_y_Nombres;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGruposDS)mParam).Principal[0].Apellido_y_Nombres = value;
               }
	          }
        public bool IsApellido_y_NombresNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGruposDS)mParam).Principal[0].IsApellido_y_NombresNull();
             }
	        }
        public String GrupoNuevo {
            get {
                if(((GeneralesCommon.genGruposDS)mParam).Principal[0]["GrupoNuevo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGruposDS)mParam).Principal[0].GrupoNuevo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGruposDS)mParam).Principal[0].GrupoNuevo = value;
               }
	          }
        public bool IsGrupoNuevoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGruposDS)mParam).Principal[0].IsGrupoNuevoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((GeneralesCommon.genGruposDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGruposDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGruposDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGruposDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean PTEmpresas {
            get {
                if(((GeneralesCommon.genGruposDS)mParam).Principal[0]["PTEmpresas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGruposDS)mParam).Principal[0].PTEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGruposDS)mParam).Principal[0].PTEmpresas = value;
               }
	          }
        public bool IsPTEmpresasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGruposDS)mParam).Principal[0].IsPTEmpresasNull();
             }
	        }
        public Int32 genUsuarios {
            get {
                if(((GeneralesCommon.genGruposDS)mParam).Principal[0]["genUsuarios"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGruposDS)mParam).Principal[0].genUsuarios;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGruposDS)mParam).Principal[0].genUsuarios = value;
               }
	          }
        public bool IsgenUsuariosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGruposDS)mParam).Principal[0].IsgenUsuariosNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genGruposDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genGruposDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genGruposDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genGruposDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genGruposDS );
     }
     public genGruposActionExchange() : base( "genGrupos" ) {
     }

     public genGruposActionExchange(genGruposActionEnum.EnumgenGruposAction pAccion) : base(genGruposActionEnum.GetAcciongenGruposAction(pAccion)) {
     }

     public genGruposActionExchange(genGruposActionEnum.EnumgenGruposAction pAccion, GeneralesCommon.genGruposDS pdsParam) : base(genGruposActionEnum.GetAcciongenGruposAction(pAccion), pdsParam) {
     }

     public genGruposActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genGruposDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genGruposDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genGruposDS)mParam;
	        }
     }
  }
}
