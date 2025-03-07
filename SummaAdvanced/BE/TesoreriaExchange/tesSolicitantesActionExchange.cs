using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace TesoreriaExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class tesSolicitantesActionExchange : Framework.Core.Exchange{

        public String Cuit {
            get {
                if(((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0]["Cuit"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].Cuit;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].Cuit = value;
               }
	          }
        public bool IsCuitNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].IsCuitNull();
             }
	        }
        public String IdFiscal {
            get {
                if(((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0]["IdFiscal"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].IdFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].IdFiscal = value;
               }
	          }
        public bool IsIdFiscalNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].IsIdFiscalNull();
             }
	        }
        public String TipoDoc {
            get {
                if(((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0]["TipoDoc"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].TipoDoc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].TipoDoc = value;
               }
	          }
        public bool IsTipoDocNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].IsTipoDocNull();
             }
	        }
        public String Solicitante_Id {
            get {
                if(((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0]["Solicitante_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].Solicitante_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].Solicitante_Id = value;
               }
	          }
        public bool IsSolicitante_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].IsSolicitante_IdNull();
             }
	        }
        public String Solicitante_Id_Nueva {
            get {
                if(((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0]["Solicitante_Id_Nueva"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].Solicitante_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].Solicitante_Id_Nueva = value;
               }
	          }
        public bool IsSolicitante_Id_NuevaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].IsSolicitante_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Nombre {
            get {
                if(((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0]["Nombre"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].Nombre;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].Nombre = value;
               }
	          }
        public bool IsNombreNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].IsNombreNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Banco_Id {
            get {
                if(((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0]["Banco_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].Banco_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].Banco_Id = value;
               }
	          }
        public bool IsBanco_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].IsBanco_IdNull();
             }
	        }
        public String DescripcionBancos {
            get {
                if(((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0]["DescripcionBancos"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].DescripcionBancos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].DescripcionBancos = value;
               }
	          }
        public bool IsDescripcionBancosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].IsDescripcionBancosNull();
             }
	        }
        public String Cuenta {
            get {
                if(((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0]["Cuenta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].Cuenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].Cuenta = value;
               }
	          }
        public bool IsCuentaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].IsCuentaNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public DateTime FechaCarga {
            get {
                if(((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0]["FechaCarga"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].FechaCarga;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].FechaCarga = value;
               }
	          }
        public bool IsFechaCargaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].IsFechaCargaNull();
             }
	        }
        public Int64 genEntidades {
            get {
                if(((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0]["genEntidades"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].genEntidades;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].genEntidades = value;
               }
	          }
        public bool IsgenEntidadesNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].IsgenEntidadesNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitantesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesSolicitantesDS );
     }
     public tesSolicitantesActionExchange() : base( "tesSolicitantes" ) {
     }

     public tesSolicitantesActionExchange(tesSolicitantesActionEnum.EnumtesSolicitantesAction pAccion) : base(tesSolicitantesActionEnum.GetAcciontesSolicitantesAction(pAccion)) {
     }

     public tesSolicitantesActionExchange(tesSolicitantesActionEnum.EnumtesSolicitantesAction pAccion, TesoreriaCommon.tesSolicitantesDS pdsParam) : base(tesSolicitantesActionEnum.GetAcciontesSolicitantesAction(pAccion), pdsParam) {
     }

     public tesSolicitantesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesSolicitantesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesSolicitantesDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesSolicitantesDS)mParam;
	        }
     }
  }
}
