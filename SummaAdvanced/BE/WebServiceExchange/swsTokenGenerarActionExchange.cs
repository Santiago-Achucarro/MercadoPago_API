using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace WebServiceExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class swsTokenGenerarActionExchange : Framework.Core.Exchange{

        public Int32 genEmpresas {
            get {
                if(((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0]["genEmpresas"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].genEmpresas;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].genEmpresas = value;
               }
	          }
        public bool IsgenEmpresasNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].IsgenEmpresasNull();
             }
	        }
        public String Empresa_Id {
            get {
                if(((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Empresa_Id_Nueva {
            get {
                if(((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0]["Empresa_Id_Nueva"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].Empresa_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].Empresa_Id_Nueva = value;
               }
	          }
        public bool IsEmpresa_Id_NuevaNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].IsEmpresa_Id_NuevaNull();
             }
	        }
        public String DescripcionEmpresa {
            get {
                if(((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0]["DescripcionEmpresa"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].DescripcionEmpresa;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].DescripcionEmpresa = value;
               }
	          }
        public bool IsDescripcionEmpresaNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].IsDescripcionEmpresaNull();
             }
	        }
        public Int32 genUsuarios {
            get {
                if(((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0]["genUsuarios"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].genUsuarios;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].genUsuarios = value;
               }
	          }
        public bool IsgenUsuariosNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].IsgenUsuariosNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public String Password {
            get {
                if(((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0]["Password"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].Password;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].Password = value;
               }
	          }
        public bool IsPasswordNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].IsPasswordNull();
             }
	        }
        public String Token {
            get {
                if(((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0]["Token"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].Token;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].Token = value;
               }
	          }
        public bool IsTokenNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].IsTokenNull();
             }
	        }
        public String Base64Key {
            get {
                if(((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0]["Base64Key"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].Base64Key;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].Base64Key = value;
               }
	          }
        public bool IsBase64KeyNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].IsBase64KeyNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenGenerarDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( WebServiceCommon.swsTokenGenerarDS );
     }
     public swsTokenGenerarActionExchange() : base( "swsTokenGenerar" ) {
     }

     public swsTokenGenerarActionExchange(swsTokenGenerarActionEnum.EnumswsTokenGenerarAction pAccion) : base(swsTokenGenerarActionEnum.GetAccionswsTokenGenerarAction(pAccion)) {
     }

     public swsTokenGenerarActionExchange(swsTokenGenerarActionEnum.EnumswsTokenGenerarAction pAccion, WebServiceCommon.swsTokenGenerarDS pdsParam) : base(swsTokenGenerarActionEnum.GetAccionswsTokenGenerarAction(pAccion), pdsParam) {
     }

     public swsTokenGenerarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new WebServiceCommon.swsTokenGenerarDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public WebServiceCommon.swsTokenGenerarDS Param{
	        get{
			    InitParam();
			    return (WebServiceCommon.swsTokenGenerarDS)mParam;
	        }
     }
  }
}
