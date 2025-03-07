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
    public class conCentro2ActionExchange : Framework.Core.Exchange{

        public Int32 conCentro2 {
            get {
                if(((ContabilidadCommon.conCentro2DS)mParam).Principal[0]["conCentro2"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].conCentro2;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].conCentro2 = value;
               }
	          }
        public bool IsconCentro2Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].IsconCentro2Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((ContabilidadCommon.conCentro2DS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String Centro2_Id_Nueva {
            get {
                if(((ContabilidadCommon.conCentro2DS)mParam).Principal[0]["Centro2_Id_Nueva"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].Centro2_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].Centro2_Id_Nueva = value;
               }
	          }
        public bool IsCentro2_Id_NuevaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].IsCentro2_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ContabilidadCommon.conCentro2DS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ContabilidadCommon.conCentro2DS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ContabilidadCommon.conCentro2DS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int16 Nivel {
            get {
                if(((ContabilidadCommon.conCentro2DS)mParam).Principal[0]["Nivel"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].Nivel;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].Nivel = value;
               }
	          }
        public bool IsNivelNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].IsNivelNull();
             }
	        }
        public Boolean Imputable {
            get {
                if(((ContabilidadCommon.conCentro2DS)mParam).Principal[0]["Imputable"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].Imputable;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].Imputable = value;
               }
	          }
        public bool IsImputableNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].IsImputableNull();
             }
	        }
        public String Notas {
            get {
                if(((ContabilidadCommon.conCentro2DS)mParam).Principal[0]["Notas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].Notas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].Notas = value;
               }
	          }
        public bool IsNotasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].IsNotasNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ContabilidadCommon.conCentro2DS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ContabilidadCommon.conCentro2DS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ContabilidadCommon.conCentro2DS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ContabilidadCommon.conCentro2DS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conCentro2DS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro2DS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conCentro2DS );
     }
     public conCentro2ActionExchange() : base( "conCentro2" ) {
     }

     public conCentro2ActionExchange(conCentro2ActionEnum.EnumconCentro2Action pAccion) : base(conCentro2ActionEnum.GetAccionconCentro2Action(pAccion)) {
     }

     public conCentro2ActionExchange(conCentro2ActionEnum.EnumconCentro2Action pAccion, ContabilidadCommon.conCentro2DS pdsParam) : base(conCentro2ActionEnum.GetAccionconCentro2Action(pAccion), pdsParam) {
     }

     public conCentro2ActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conCentro2DS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conCentro2DS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conCentro2DS)mParam;
	        }
     }
  }
}
