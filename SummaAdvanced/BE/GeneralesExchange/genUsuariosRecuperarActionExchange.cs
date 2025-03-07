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
    public class genUsuariosRecuperarActionExchange : Framework.Core.Exchange{

        public Int32 genUsuarios {
            get {
                if(((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0]["genUsuarios"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].genUsuarios;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].genUsuarios = value;
               }
	          }
        public bool IsgenUsuariosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].IsgenUsuariosNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String Usuario_Id_Nueva {
            get {
                if(((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0]["Usuario_Id_Nueva"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].Usuario_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].Usuario_Id_Nueva = value;
               }
	          }
        public bool IsUsuario_Id_NuevaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].IsUsuario_Id_NuevaNull();
             }
	        }
        public String Empresa_Id {
            get {
                if(((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Email {
            get {
                if(((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0]["Email"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].Email;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].Email = value;
               }
	          }
        public bool IsEmailNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].IsEmailNull();
             }
	        }
        public String EmailEmpresa {
            get {
                if(((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0]["EmailEmpresa"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].EmailEmpresa;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].EmailEmpresa = value;
               }
	          }
        public bool IsEmailEmpresaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].IsEmailEmpresaNull();
             }
	        }
        public String Servidor {
            get {
                if(((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0]["Servidor"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].Servidor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].Servidor = value;
               }
	          }
        public bool IsServidorNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].IsServidorNull();
             }
	        }
        public String Seguridad {
            get {
                if(((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0]["Seguridad"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].Seguridad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].Seguridad = value;
               }
	          }
        public bool IsSeguridadNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].IsSeguridadNull();
             }
	        }
        public Int32 Puerto {
            get {
                if(((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0]["Puerto"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].Puerto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].Puerto = value;
               }
	          }
        public bool IsPuertoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].IsPuertoNull();
             }
	        }
        public String Clave {
            get {
                if(((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0]["Clave"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].Clave;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].Clave = value;
               }
	          }
        public bool IsClaveNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].IsClaveNull();
             }
	        }
        public String ClaveNueva {
            get {
                if(((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0]["ClaveNueva"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].ClaveNueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].ClaveNueva = value;
               }
	          }
        public bool IsClaveNuevaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].IsClaveNuevaNull();
             }
	        }
        public String EmailUsuario {
            get {
                if(((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0]["EmailUsuario"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].EmailUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].EmailUsuario = value;
               }
	          }
        public bool IsEmailUsuarioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].IsEmailUsuarioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosRecuperarDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genUsuariosRecuperarDS );
     }
     public genUsuariosRecuperarActionExchange() : base( "genUsuariosRecuperar" ) {
     }

     public genUsuariosRecuperarActionExchange(genUsuariosRecuperarActionEnum.EnumgenUsuariosRecuperarAction pAccion) : base(genUsuariosRecuperarActionEnum.GetAcciongenUsuariosRecuperarAction(pAccion)) {
     }

     public genUsuariosRecuperarActionExchange(genUsuariosRecuperarActionEnum.EnumgenUsuariosRecuperarAction pAccion, GeneralesCommon.genUsuariosRecuperarDS pdsParam) : base(genUsuariosRecuperarActionEnum.GetAcciongenUsuariosRecuperarAction(pAccion), pdsParam) {
     }

     public genUsuariosRecuperarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genUsuariosRecuperarDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genUsuariosRecuperarDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genUsuariosRecuperarDS)mParam;
	        }
     }
  }
}
