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
    public class conBaseDistriActionExchange : Framework.Core.Exchange{

        public Int32 conBaseDistri {
            get {
                if(((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0]["conBaseDistri"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].conBaseDistri;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].conBaseDistri = value;
               }
	          }
        public bool IsconBaseDistriNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].IsconBaseDistriNull();
             }
	        }
        public String Base_Id {
            get {
                if(((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0]["Base_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].Base_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].Base_Id = value;
               }
	          }
        public bool IsBase_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].IsBase_IdNull();
             }
	        }
        public String Base_Id_Nueva {
            get {
                if(((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0]["Base_Id_Nueva"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].Base_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].Base_Id_Nueva = value;
               }
	          }
        public bool IsBase_Id_NuevaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].IsBase_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conBaseDistriDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conBaseDistriDS );
     }
     public conBaseDistriActionExchange() : base( "conBaseDistri" ) {
     }

     public conBaseDistriActionExchange(conBaseDistriActionEnum.EnumconBaseDistriAction pAccion) : base(conBaseDistriActionEnum.GetAccionconBaseDistriAction(pAccion)) {
     }

     public conBaseDistriActionExchange(conBaseDistriActionEnum.EnumconBaseDistriAction pAccion, ContabilidadCommon.conBaseDistriDS pdsParam) : base(conBaseDistriActionEnum.GetAccionconBaseDistriAction(pAccion), pdsParam) {
     }

     public conBaseDistriActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conBaseDistriDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conBaseDistriDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conBaseDistriDS)mParam;
	        }
     }
  }
}
