using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genUsuarioLoginActionExchange : Framework.Core.Exchange{

        public String Empresa {
            get {
                if(((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0]["Empresa"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Empresa;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Empresa = value;
               }
	          }
        public bool IsEmpresaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].IsEmpresaNull();
             }
	        }
        public String Usuario_id {
            get {
                if(((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0]["Usuario_id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Usuario_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Usuario_id = value;
               }
	          }
        public bool IsUsuario_idNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].IsUsuario_idNull();
             }
	        }
        public String Clave {
            get {
                if(((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0]["Clave"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Clave;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Clave = value;
               }
	          }
        public bool IsClaveNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].IsClaveNull();
             }
	        }
        public Boolean Correcta {
            get {
                if(((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0]["Correcta"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Correcta;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Correcta = value;
               }
	          }
        public bool IsCorrectaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].IsCorrectaNull();
             }
	        }
        public Int32 genUsuario {
            get {
                if(((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0]["genUsuario"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].genUsuario;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].genUsuario = value;
               }
	          }
        public bool IsgenUsuarioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].IsgenUsuarioNull();
             }
	        }
        public Int32 genEmpresa {
            get {
                if(((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0]["genEmpresa"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].genEmpresa;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].genEmpresa = value;
               }
	          }
        public bool IsgenEmpresaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].IsgenEmpresaNull();
             }
	        }
        public Boolean DebeCambiarClave {
            get {
                if(((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0]["DebeCambiarClave"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].DebeCambiarClave;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].DebeCambiarClave = value;
               }
	          }
        public bool IsDebeCambiarClaveNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].IsDebeCambiarClaveNull();
             }
	        }
        public String Mensaje {
            get {
                if(((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0]["Mensaje"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Mensaje;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Mensaje = value;
               }
	          }
        public bool IsMensajeNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].IsMensajeNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String DescripcionCliente {
            get {
                if(((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0]["DescripcionCliente"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].DescripcionCliente;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].DescripcionCliente = value;
               }
	          }
        public bool IsDescripcionClienteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].IsDescripcionClienteNull();
             }
	        }
        public String Proveed_Id {
            get {
                if(((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String DescripcionProveedor {
            get {
                if(((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0]["DescripcionProveedor"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].DescripcionProveedor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].DescripcionProveedor = value;
               }
	          }
        public bool IsDescripcionProveedorNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].IsDescripcionProveedorNull();
             }
	        }
        public Int32 Legajo {
            get {
                if(((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public String DescripcionLegajo {
            get {
                if(((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0]["DescripcionLegajo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].DescripcionLegajo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].DescripcionLegajo = value;
               }
	          }
        public bool IsDescripcionLegajoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].IsDescripcionLegajoNull();
             }
	        }
        public String Vendedor_Id {
            get {
                if(((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0]["Vendedor_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Vendedor_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Vendedor_Id = value;
               }
	          }
        public bool IsVendedor_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].IsVendedor_IdNull();
             }
	        }
        public String DescripcionVendedor {
            get {
                if(((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0]["DescripcionVendedor"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].DescripcionVendedor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].DescripcionVendedor = value;
               }
	          }
        public bool IsDescripcionVendedorNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].IsDescripcionVendedorNull();
             }
	        }
        public String Cobrador_Id {
            get {
                if(((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0]["Cobrador_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Cobrador_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Cobrador_Id = value;
               }
	          }
        public bool IsCobrador_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].IsCobrador_IdNull();
             }
	        }
        public String DescripcionCobrador {
            get {
                if(((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0]["DescripcionCobrador"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].DescripcionCobrador;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].DescripcionCobrador = value;
               }
	          }
        public bool IsDescripcionCobradorNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].IsDescripcionCobradorNull();
             }
	        }
        public String Cultura {
            get {
                if(((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0]["Cultura"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Cultura;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Cultura = value;
               }
	          }
        public bool IsCulturaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].IsCulturaNull();
             }
	        }
        public String Token {
            get {
                if(((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0]["Token"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Token;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Token = value;
               }
	          }
        public bool IsTokenNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].IsTokenNull();
             }
	        }
        public String Url {
            get {
                if(((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0]["Url"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Url;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].Url = value;
               }
	          }
        public bool IsUrlNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuarioLoginDS)mParam).Principal[0].IsUrlNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genUsuarioLoginDS );
     }
     public genUsuarioLoginActionExchange() : base( "genUsuarioLogin" ) {
     }

     public genUsuarioLoginActionExchange(genUsuarioLoginActionEnum.EnumgenUsuarioLoginAction pAccion) : base(genUsuarioLoginActionEnum.GetAcciongenUsuarioLoginAction(pAccion)) {
     }

     public genUsuarioLoginActionExchange(genUsuarioLoginActionEnum.EnumgenUsuarioLoginAction pAccion, GeneralesCommon.genUsuarioLoginDS pdsParam) : base(genUsuarioLoginActionEnum.GetAcciongenUsuarioLoginAction(pAccion), pdsParam) {
     }

     public genUsuarioLoginActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genUsuarioLoginDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genUsuarioLoginDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genUsuarioLoginDS)mParam;
	        }
     }
  }
}
