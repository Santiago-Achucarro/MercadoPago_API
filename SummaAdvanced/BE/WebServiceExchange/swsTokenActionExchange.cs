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
    public class swsTokenActionExchange : Framework.Core.Exchange{

        public Int32 genUsuarios {
            get {
                if(((WebServiceCommon.swsTokenDS)mParam).Principal[0]["genUsuarios"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenDS)mParam).Principal[0].genUsuarios;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenDS)mParam).Principal[0].genUsuarios = value;
               }
	          }
        public bool IsgenUsuariosNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenDS)mParam).Principal[0].IsgenUsuariosNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((WebServiceCommon.swsTokenDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String Usuario_Id_Nueva {
            get {
                if(((WebServiceCommon.swsTokenDS)mParam).Principal[0]["Usuario_Id_Nueva"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenDS)mParam).Principal[0].Usuario_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenDS)mParam).Principal[0].Usuario_Id_Nueva = value;
               }
	          }
        public bool IsUsuario_Id_NuevaNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenDS)mParam).Principal[0].IsUsuario_Id_NuevaNull();
             }
	        }
        public String Apellido_y_Nombres {
            get {
                if(((WebServiceCommon.swsTokenDS)mParam).Principal[0]["Apellido_y_Nombres"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenDS)mParam).Principal[0].Apellido_y_Nombres;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenDS)mParam).Principal[0].Apellido_y_Nombres = value;
               }
	          }
        public bool IsApellido_y_NombresNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenDS)mParam).Principal[0].IsApellido_y_NombresNull();
             }
	        }
        public Int32 genEmpresas {
            get {
                if(((WebServiceCommon.swsTokenDS)mParam).Principal[0]["genEmpresas"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenDS)mParam).Principal[0].genEmpresas;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenDS)mParam).Principal[0].genEmpresas = value;
               }
	          }
        public bool IsgenEmpresasNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenDS)mParam).Principal[0].IsgenEmpresasNull();
             }
	        }
        public String Empresa_Id {
            get {
                if(((WebServiceCommon.swsTokenDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public DateTime ValidThru {
            get {
                if(((WebServiceCommon.swsTokenDS)mParam).Principal[0]["ValidThru"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenDS)mParam).Principal[0].ValidThru;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenDS)mParam).Principal[0].ValidThru = value;
               }
	          }
        public bool IsValidThruNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenDS)mParam).Principal[0].IsValidThruNull();
             }
	        }
        public String Token {
            get {
                if(((WebServiceCommon.swsTokenDS)mParam).Principal[0]["Token"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenDS)mParam).Principal[0].Token;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenDS)mParam).Principal[0].Token = value;
               }
	          }
        public bool IsTokenNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenDS)mParam).Principal[0].IsTokenNull();
             }
	        }
        public String Dominio_Id {
            get {
                if(((WebServiceCommon.swsTokenDS)mParam).Principal[0]["Dominio_Id"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenDS)mParam).Principal[0].Dominio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenDS)mParam).Principal[0].Dominio_Id = value;
               }
	          }
        public bool IsDominio_IdNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenDS)mParam).Principal[0].IsDominio_IdNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((WebServiceCommon.swsTokenDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String Accion_Id {
            get {
                if(((WebServiceCommon.swsTokenDS)mParam).Principal[0]["Accion_Id"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenDS)mParam).Principal[0].Accion_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenDS)mParam).Principal[0].Accion_Id = value;
               }
	          }
        public bool IsAccion_IdNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenDS)mParam).Principal[0].IsAccion_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((WebServiceCommon.swsTokenDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsTokenDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsTokenDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsTokenDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( WebServiceCommon.swsTokenDS );
     }
     public swsTokenActionExchange() : base( "swsToken" ) {
     }

     public swsTokenActionExchange(swsTokenActionEnum.EnumswsTokenAction pAccion) : base(swsTokenActionEnum.GetAccionswsTokenAction(pAccion)) {
     }

     public swsTokenActionExchange(swsTokenActionEnum.EnumswsTokenAction pAccion, WebServiceCommon.swsTokenDS pdsParam) : base(swsTokenActionEnum.GetAccionswsTokenAction(pAccion), pdsParam) {
     }

     public swsTokenActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new WebServiceCommon.swsTokenDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public WebServiceCommon.swsTokenDS Param{
	        get{
			    InitParam();
			    return (WebServiceCommon.swsTokenDS)mParam;
	        }
     }
  }
}
