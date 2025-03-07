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
    public class comForEntreActionExchange : Framework.Core.Exchange{

        public Int32 comForEntre {
            get {
                if(((ComprasCommon.comForEntreDS)mParam).Principal[0]["comForEntre"] != DBNull.Value  ){
                    return ((ComprasCommon.comForEntreDS)mParam).Principal[0].comForEntre;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comForEntreDS)mParam).Principal[0].comForEntre = value;
               }
	          }
        public bool IscomForEntreNull {
             get {
                 return mParam==null || ((ComprasCommon.comForEntreDS)mParam).Principal[0].IscomForEntreNull();
             }
	        }
        public String FormaEnt_Id {
            get {
                if(((ComprasCommon.comForEntreDS)mParam).Principal[0]["FormaEnt_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comForEntreDS)mParam).Principal[0].FormaEnt_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comForEntreDS)mParam).Principal[0].FormaEnt_Id = value;
               }
	          }
        public bool IsFormaEnt_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comForEntreDS)mParam).Principal[0].IsFormaEnt_IdNull();
             }
	        }
        public String FormaEnt_Id_Nueva {
            get {
                if(((ComprasCommon.comForEntreDS)mParam).Principal[0]["FormaEnt_Id_Nueva"] != DBNull.Value  ){
                    return ((ComprasCommon.comForEntreDS)mParam).Principal[0].FormaEnt_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comForEntreDS)mParam).Principal[0].FormaEnt_Id_Nueva = value;
               }
	          }
        public bool IsFormaEnt_Id_NuevaNull {
             get {
                 return mParam==null || ((ComprasCommon.comForEntreDS)mParam).Principal[0].IsFormaEnt_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ComprasCommon.comForEntreDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ComprasCommon.comForEntreDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comForEntreDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ComprasCommon.comForEntreDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comForEntreDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comForEntreDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comForEntreDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comForEntreDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ComprasCommon.comForEntreDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ComprasCommon.comForEntreDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comForEntreDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ComprasCommon.comForEntreDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ComprasCommon.comForEntreDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ComprasCommon.comForEntreDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comForEntreDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ComprasCommon.comForEntreDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ComprasCommon.comForEntreDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comForEntreDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comForEntreDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comForEntreDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ComprasCommon.comForEntreDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ComprasCommon.comForEntreDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comForEntreDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ComprasCommon.comForEntreDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ComprasCommon.comForEntreDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ComprasCommon.comForEntreDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comForEntreDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comForEntreDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comForEntreDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comForEntreDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comForEntreDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comForEntreDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comForEntreDS );
     }
     public comForEntreActionExchange() : base( "comForEntre" ) {
     }

     public comForEntreActionExchange(comForEntreActionEnum.EnumcomForEntreAction pAccion) : base(comForEntreActionEnum.GetAccioncomForEntreAction(pAccion)) {
     }

     public comForEntreActionExchange(comForEntreActionEnum.EnumcomForEntreAction pAccion, ComprasCommon.comForEntreDS pdsParam) : base(comForEntreActionEnum.GetAccioncomForEntreAction(pAccion), pdsParam) {
     }

     public comForEntreActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comForEntreDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comForEntreDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comForEntreDS)mParam;
	        }
     }
  }
}
