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
    public class comCondFiscalActionExchange : Framework.Core.Exchange{

        public Int32 comCondFiscal {
            get {
                if(((ComprasCommon.comCondFiscalDS)mParam).Principal[0]["comCondFiscal"] != DBNull.Value  ){
                    return ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].comCondFiscal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].comCondFiscal = value;
               }
	          }
        public bool IscomCondFiscalNull {
             get {
                 return mParam==null || ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].IscomCondFiscalNull();
             }
	        }
        public String CondFiscal_Id {
            get {
                if(((ComprasCommon.comCondFiscalDS)mParam).Principal[0]["CondFiscal_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].CondFiscal_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].CondFiscal_Id = value;
               }
	          }
        public bool IsCondFiscal_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].IsCondFiscal_IdNull();
             }
	        }
        public String CondFiscal_Id_Nueva {
            get {
                if(((ComprasCommon.comCondFiscalDS)mParam).Principal[0]["CondFiscal_Id_Nueva"] != DBNull.Value  ){
                    return ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].CondFiscal_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].CondFiscal_Id_Nueva = value;
               }
	          }
        public bool IsCondFiscal_Id_NuevaNull {
             get {
                 return mParam==null || ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].IsCondFiscal_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comCondFiscalDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ComprasCommon.comCondFiscalDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ComprasCommon.comCondFiscalDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String CodigoFiscal {
            get {
                if(((ComprasCommon.comCondFiscalDS)mParam).Principal[0]["CodigoFiscal"] != DBNull.Value  ){
                    return ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].CodigoFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].CodigoFiscal = value;
               }
	          }
        public bool IsCodigoFiscalNull {
             get {
                 return mParam==null || ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].IsCodigoFiscalNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ComprasCommon.comCondFiscalDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ComprasCommon.comCondFiscalDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ComprasCommon.comCondFiscalDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ComprasCommon.comCondFiscalDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comCondFiscalDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comCondFiscalDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comCondFiscalDS );
     }
     public comCondFiscalActionExchange() : base( "comCondFiscal" ) {
     }

     public comCondFiscalActionExchange(comCondFiscalActionEnum.EnumcomCondFiscalAction pAccion) : base(comCondFiscalActionEnum.GetAccioncomCondFiscalAction(pAccion)) {
     }

     public comCondFiscalActionExchange(comCondFiscalActionEnum.EnumcomCondFiscalAction pAccion, ComprasCommon.comCondFiscalDS pdsParam) : base(comCondFiscalActionEnum.GetAccioncomCondFiscalAction(pAccion), pdsParam) {
     }

     public comCondFiscalActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comCondFiscalDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comCondFiscalDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comCondFiscalDS)mParam;
	        }
     }
  }
}
