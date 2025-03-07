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
    public class conSubCuentasActionExchange : Framework.Core.Exchange{

        public Int32 conSubCuentas {
            get {
                if(((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0]["conSubCuentas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].conSubCuentas;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].conSubCuentas = value;
               }
	          }
        public bool IsconSubCuentasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].IsconSubCuentasNull();
             }
	        }
        public String SubCuenta_Id {
            get {
                if(((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0]["SubCuenta_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].SubCuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].SubCuenta_Id = value;
               }
	          }
        public bool IsSubCuenta_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].IsSubCuenta_IdNull();
             }
	        }
        public String SubCuenta_Id_Nueva {
            get {
                if(((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0]["SubCuenta_Id_Nueva"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].SubCuenta_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].SubCuenta_Id_Nueva = value;
               }
	          }
        public bool IsSubCuenta_Id_NuevaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].IsSubCuenta_Id_NuevaNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Base_Id {
            get {
                if(((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0]["Base_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].Base_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].Base_Id = value;
               }
	          }
        public bool IsBase_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].IsBase_IdNull();
             }
	        }
        public String DescripcionBaseDistri {
            get {
                if(((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0]["DescripcionBaseDistri"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].DescripcionBaseDistri;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].DescripcionBaseDistri = value;
               }
	          }
        public bool IsDescripcionBaseDistriNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].IsDescripcionBaseDistriNull();
             }
	        }
        public Int32 Cuadro1Fila_Id {
            get {
                if(((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0]["Cuadro1Fila_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].Cuadro1Fila_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].Cuadro1Fila_Id = value;
               }
	          }
        public bool IsCuadro1Fila_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].IsCuadro1Fila_IdNull();
             }
	        }
        public String DescripcionCuadro1Filas {
            get {
                if(((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0]["DescripcionCuadro1Filas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].DescripcionCuadro1Filas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].DescripcionCuadro1Filas = value;
               }
	          }
        public bool IsDescripcionCuadro1FilasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].IsDescripcionCuadro1FilasNull();
             }
	        }
        public Boolean Ajustable {
            get {
                if(((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0]["Ajustable"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].Ajustable;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].Ajustable = value;
               }
	          }
        public bool IsAjustableNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].IsAjustableNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Description {
            get {
                if(((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0]["Description"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].Description;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].Description = value;
               }
	          }
        public bool IsDescriptionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].IsDescriptionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conSubCuentasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conSubCuentasDS );
     }
     public conSubCuentasActionExchange() : base( "conSubCuentas" ) {
     }

     public conSubCuentasActionExchange(conSubCuentasActionEnum.EnumconSubCuentasAction pAccion) : base(conSubCuentasActionEnum.GetAccionconSubCuentasAction(pAccion)) {
     }

     public conSubCuentasActionExchange(conSubCuentasActionEnum.EnumconSubCuentasAction pAccion, ContabilidadCommon.conSubCuentasDS pdsParam) : base(conSubCuentasActionEnum.GetAccionconSubCuentasAction(pAccion), pdsParam) {
     }

     public conSubCuentasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conSubCuentasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conSubCuentasDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conSubCuentasDS)mParam;
	        }
     }
  }
}
