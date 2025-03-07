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
    public class comProvAnexoActionExchange : Framework.Core.Exchange{

        public Int64 genEntidades {
            get {
                if(((ComprasCommon.comProvAnexoDS)mParam).Principal[0]["genEntidades"] != DBNull.Value  ){
                    return ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].genEntidades;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].genEntidades = value;
               }
	          }
        public bool IsgenEntidadesNull {
             get {
                 return mParam==null || ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].IsgenEntidadesNull();
             }
	        }
        public String CUIT {
            get {
                if(((ComprasCommon.comProvAnexoDS)mParam).Principal[0]["CUIT"] != DBNull.Value  ){
                    return ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].CUIT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].CUIT = value;
               }
	          }
        public bool IsCUITNull {
             get {
                 return mParam==null || ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].IsCUITNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((ComprasCommon.comProvAnexoDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String Direccion1 {
            get {
                if(((ComprasCommon.comProvAnexoDS)mParam).Principal[0]["Direccion1"] != DBNull.Value  ){
                    return ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].Direccion1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].Direccion1 = value;
               }
	          }
        public bool IsDireccion1Null {
             get {
                 return mParam==null || ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].IsDireccion1Null();
             }
	        }
        public String Direccion2 {
            get {
                if(((ComprasCommon.comProvAnexoDS)mParam).Principal[0]["Direccion2"] != DBNull.Value  ){
                    return ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].Direccion2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].Direccion2 = value;
               }
	          }
        public bool IsDireccion2Null {
             get {
                 return mParam==null || ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].IsDireccion2Null();
             }
	        }
        public String Localidad {
            get {
                if(((ComprasCommon.comProvAnexoDS)mParam).Principal[0]["Localidad"] != DBNull.Value  ){
                    return ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].Localidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].Localidad = value;
               }
	          }
        public bool IsLocalidadNull {
             get {
                 return mParam==null || ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].IsLocalidadNull();
             }
	        }
        public String Cod_Postal {
            get {
                if(((ComprasCommon.comProvAnexoDS)mParam).Principal[0]["Cod_Postal"] != DBNull.Value  ){
                    return ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].Cod_Postal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].Cod_Postal = value;
               }
	          }
        public bool IsCod_PostalNull {
             get {
                 return mParam==null || ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].IsCod_PostalNull();
             }
	        }
        public String Provincia_Id {
            get {
                if(((ComprasCommon.comProvAnexoDS)mParam).Principal[0]["Provincia_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].Provincia_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].Provincia_Id = value;
               }
	          }
        public bool IsProvincia_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].IsProvincia_IdNull();
             }
	        }
        public String DescripcionProvincias {
            get {
                if(((ComprasCommon.comProvAnexoDS)mParam).Principal[0]["DescripcionProvincias"] != DBNull.Value  ){
                    return ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].DescripcionProvincias;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].DescripcionProvincias = value;
               }
	          }
        public bool IsDescripcionProvinciasNull {
             get {
                 return mParam==null || ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].IsDescripcionProvinciasNull();
             }
	        }
        public String CondFiscal_Id {
            get {
                if(((ComprasCommon.comProvAnexoDS)mParam).Principal[0]["CondFiscal_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].CondFiscal_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].CondFiscal_Id = value;
               }
	          }
        public bool IsCondFiscal_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].IsCondFiscal_IdNull();
             }
	        }
        public String DescripcionCondFiscal {
            get {
                if(((ComprasCommon.comProvAnexoDS)mParam).Principal[0]["DescripcionCondFiscal"] != DBNull.Value  ){
                    return ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].DescripcionCondFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].DescripcionCondFiscal = value;
               }
	          }
        public bool IsDescripcionCondFiscalNull {
             get {
                 return mParam==null || ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].IsDescripcionCondFiscalNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ComprasCommon.comProvAnexoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ComprasCommon.comProvAnexoDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comProvAnexoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comProvAnexoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comProvAnexoDS );
     }
     public comProvAnexoActionExchange() : base( "comProvAnexo" ) {
     }

     public comProvAnexoActionExchange(comProvAnexoActionEnum.EnumcomProvAnexoAction pAccion) : base(comProvAnexoActionEnum.GetAccioncomProvAnexoAction(pAccion)) {
     }

     public comProvAnexoActionExchange(comProvAnexoActionEnum.EnumcomProvAnexoAction pAccion, ComprasCommon.comProvAnexoDS pdsParam) : base(comProvAnexoActionEnum.GetAccioncomProvAnexoAction(pAccion), pdsParam) {
     }

     public comProvAnexoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comProvAnexoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comProvAnexoDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comProvAnexoDS)mParam;
	        }
     }
  }
}
