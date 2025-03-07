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
    public class conGruposContActionExchange : Framework.Core.Exchange{

        public Int32 conGruposCont {
            get {
                if(((ContabilidadCommon.conGruposContDS)mParam).Principal[0]["conGruposCont"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].conGruposCont;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].conGruposCont = value;
               }
	          }
        public bool IsconGruposContNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].IsconGruposContNull();
             }
	        }
        public String Grupo_Id {
            get {
                if(((ContabilidadCommon.conGruposContDS)mParam).Principal[0]["Grupo_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].Grupo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].Grupo_Id = value;
               }
	          }
        public bool IsGrupo_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].IsGrupo_IdNull();
             }
	        }
        public String Grupo_Id_Nueva {
            get {
                if(((ContabilidadCommon.conGruposContDS)mParam).Principal[0]["Grupo_Id_Nueva"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].Grupo_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].Grupo_Id_Nueva = value;
               }
	          }
        public bool IsGrupo_Id_NuevaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].IsGrupo_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ContabilidadCommon.conGruposContDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ContabilidadCommon.conGruposContDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ContabilidadCommon.conGruposContDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ContabilidadCommon.conGruposContDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ContabilidadCommon.conGruposContDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ContabilidadCommon.conGruposContDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ContabilidadCommon.conGruposContDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conGruposContDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conGruposContDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conGruposContDS );
     }
     public conGruposContActionExchange() : base( "conGruposCont" ) {
     }

     public conGruposContActionExchange(conGruposContActionEnum.EnumconGruposContAction pAccion) : base(conGruposContActionEnum.GetAccionconGruposContAction(pAccion)) {
     }

     public conGruposContActionExchange(conGruposContActionEnum.EnumconGruposContAction pAccion, ContabilidadCommon.conGruposContDS pdsParam) : base(conGruposContActionEnum.GetAccionconGruposContAction(pAccion), pdsParam) {
     }

     public conGruposContActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conGruposContDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conGruposContDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conGruposContDS)mParam;
	        }
     }
  }
}
