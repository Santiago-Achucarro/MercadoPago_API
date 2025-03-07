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
    public class conCentro1ActionExchange : Framework.Core.Exchange{

        public Int32 conCentro1 {
            get {
                if(((ContabilidadCommon.conCentro1DS)mParam).Principal[0]["conCentro1"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].conCentro1;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].conCentro1 = value;
               }
	          }
        public bool IsconCentro1Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].IsconCentro1Null();
             }
	        }
        public String Centro1_Id {
            get {
                if(((ContabilidadCommon.conCentro1DS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String Centro1_Id_Nueva {
            get {
                if(((ContabilidadCommon.conCentro1DS)mParam).Principal[0]["Centro1_Id_Nueva"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].Centro1_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].Centro1_Id_Nueva = value;
               }
	          }
        public bool IsCentro1_Id_NuevaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].IsCentro1_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ContabilidadCommon.conCentro1DS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ContabilidadCommon.conCentro1DS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ContabilidadCommon.conCentro1DS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int16 Nivel {
            get {
                if(((ContabilidadCommon.conCentro1DS)mParam).Principal[0]["Nivel"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].Nivel;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].Nivel = value;
               }
	          }
        public bool IsNivelNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].IsNivelNull();
             }
	        }
        public Boolean Imputable {
            get {
                if(((ContabilidadCommon.conCentro1DS)mParam).Principal[0]["Imputable"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].Imputable;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].Imputable = value;
               }
	          }
        public bool IsImputableNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].IsImputableNull();
             }
	        }
        public String Notas {
            get {
                if(((ContabilidadCommon.conCentro1DS)mParam).Principal[0]["Notas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].Notas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].Notas = value;
               }
	          }
        public bool IsNotasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].IsNotasNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ContabilidadCommon.conCentro1DS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ContabilidadCommon.conCentro1DS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ContabilidadCommon.conCentro1DS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ContabilidadCommon.conCentro1DS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conCentro1DS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCentro1DS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conCentro1DS );
     }
     public conCentro1ActionExchange() : base( "conCentro1" ) {
     }

     public conCentro1ActionExchange(conCentro1ActionEnum.EnumconCentro1Action pAccion) : base(conCentro1ActionEnum.GetAccionconCentro1Action(pAccion)) {
     }

     public conCentro1ActionExchange(conCentro1ActionEnum.EnumconCentro1Action pAccion, ContabilidadCommon.conCentro1DS pdsParam) : base(conCentro1ActionEnum.GetAccionconCentro1Action(pAccion), pdsParam) {
     }

     public conCentro1ActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conCentro1DS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conCentro1DS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conCentro1DS)mParam;
	        }
     }
  }
}
