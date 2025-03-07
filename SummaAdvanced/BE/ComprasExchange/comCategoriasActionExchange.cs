using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ComprasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class comCategoriasActionExchange : Framework.Core.Exchange{

        public Int32 comCategorias {
            get {
                if(((ComprasCommon.comCategoriasDS)mParam).Principal[0]["comCategorias"] != DBNull.Value  ){
                    return ((ComprasCommon.comCategoriasDS)mParam).Principal[0].comCategorias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCategoriasDS)mParam).Principal[0].comCategorias = value;
               }
	          }
        public bool IscomCategoriasNull {
             get {
                 return mParam==null || ((ComprasCommon.comCategoriasDS)mParam).Principal[0].IscomCategoriasNull();
             }
	        }
        public String Categoria_Id {
            get {
                if(((ComprasCommon.comCategoriasDS)mParam).Principal[0]["Categoria_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comCategoriasDS)mParam).Principal[0].Categoria_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCategoriasDS)mParam).Principal[0].Categoria_Id = value;
               }
	          }
        public bool IsCategoria_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comCategoriasDS)mParam).Principal[0].IsCategoria_IdNull();
             }
	        }
        public String Categoria_Id_Nueva {
            get {
                if(((ComprasCommon.comCategoriasDS)mParam).Principal[0]["Categoria_Id_Nueva"] != DBNull.Value  ){
                    return ((ComprasCommon.comCategoriasDS)mParam).Principal[0].Categoria_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCategoriasDS)mParam).Principal[0].Categoria_Id_Nueva = value;
               }
	          }
        public bool IsCategoria_Id_NuevaNull {
             get {
                 return mParam==null || ((ComprasCommon.comCategoriasDS)mParam).Principal[0].IsCategoria_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ComprasCommon.comCategoriasDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ComprasCommon.comCategoriasDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCategoriasDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ComprasCommon.comCategoriasDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((ComprasCommon.comCategoriasDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comCategoriasDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCategoriasDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comCategoriasDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuentas {
            get {
                if(((ComprasCommon.comCategoriasDS)mParam).Principal[0]["DescripcionCuentas"] != DBNull.Value  ){
                    return ((ComprasCommon.comCategoriasDS)mParam).Principal[0].DescripcionCuentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCategoriasDS)mParam).Principal[0].DescripcionCuentas = value;
               }
	          }
        public bool IsDescripcionCuentasNull {
             get {
                 return mParam==null || ((ComprasCommon.comCategoriasDS)mParam).Principal[0].IsDescripcionCuentasNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ComprasCommon.comCategoriasDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ComprasCommon.comCategoriasDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCategoriasDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ComprasCommon.comCategoriasDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ComprasCommon.comCategoriasDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ComprasCommon.comCategoriasDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCategoriasDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comCategoriasDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ComprasCommon.comCategoriasDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comCategoriasDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCategoriasDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comCategoriasDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ComprasCommon.comCategoriasDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ComprasCommon.comCategoriasDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCategoriasDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ComprasCommon.comCategoriasDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comCategoriasDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comCategoriasDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCategoriasDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comCategoriasDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ComprasCommon.comCategoriasDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ComprasCommon.comCategoriasDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCategoriasDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ComprasCommon.comCategoriasDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comCategoriasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comCategoriasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCategoriasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comCategoriasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comCategoriasDS );
     }
     public comCategoriasActionExchange() : base( "comCategorias" ) {
     }

     public comCategoriasActionExchange(comCategoriasActionEnum.EnumcomCategoriasAction pAccion) : base(comCategoriasActionEnum.GetAccioncomCategoriasAction(pAccion)) {
     }

     public comCategoriasActionExchange(comCategoriasActionEnum.EnumcomCategoriasAction pAccion, ComprasCommon.comCategoriasDS pdsParam) : base(comCategoriasActionEnum.GetAccioncomCategoriasAction(pAccion), pdsParam) {
     }

     public comCategoriasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comCategoriasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comCategoriasDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comCategoriasDS)mParam;
	        }
     }
  }
}
