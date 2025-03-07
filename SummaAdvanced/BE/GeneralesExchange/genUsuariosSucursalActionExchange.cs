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
    public class genUsuariosSucursalActionExchange : Framework.Core.Exchange{

        public String Usuario_Id {
            get {
                if(((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public String DescripcionUsuario_Nueva {
            get {
                if(((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0]["DescripcionUsuario_Nueva"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].DescripcionUsuario_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].DescripcionUsuario_Nueva = value;
               }
	          }
        public bool IsDescripcionUsuario_NuevaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].IsDescripcionUsuario_NuevaNull();
             }
	        }
        public String Empresa_Id {
            get {
                if(((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String DescripcionEmpresa {
            get {
                if(((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0]["DescripcionEmpresa"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].DescripcionEmpresa;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].DescripcionEmpresa = value;
               }
	          }
        public bool IsDescripcionEmpresaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].IsDescripcionEmpresaNull();
             }
	        }
        public String Sucursal {
            get {
                if(((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public String DescripcionSucursal {
            get {
                if(((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0]["DescripcionSucursal"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].DescripcionSucursal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].DescripcionSucursal = value;
               }
	          }
        public bool IsDescripcionSucursalNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].IsDescripcionSucursalNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosSucursalDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genUsuariosSucursalDS );
     }
     public genUsuariosSucursalActionExchange() : base( "genUsuariosSucursal" ) {
     }

     public genUsuariosSucursalActionExchange(genUsuariosSucursalActionEnum.EnumgenUsuariosSucursalAction pAccion) : base(genUsuariosSucursalActionEnum.GetAcciongenUsuariosSucursalAction(pAccion)) {
     }

     public genUsuariosSucursalActionExchange(genUsuariosSucursalActionEnum.EnumgenUsuariosSucursalAction pAccion, GeneralesCommon.genUsuariosSucursalDS pdsParam) : base(genUsuariosSucursalActionEnum.GetAcciongenUsuariosSucursalAction(pAccion), pdsParam) {
     }

     public genUsuariosSucursalActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genUsuariosSucursalDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genUsuariosSucursalDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genUsuariosSucursalDS)mParam;
	        }
     }
  }
}
