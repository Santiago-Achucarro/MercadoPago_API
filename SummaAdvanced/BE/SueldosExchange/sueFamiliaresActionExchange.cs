using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace SueldosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class sueFamiliaresActionExchange : Framework.Core.Exchange{

        public Int32 Legajo {
            get {
                if(((SueldosCommon.sueFamiliaresDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public String ApellidoPaterno {
            get {
                if(((SueldosCommon.sueFamiliaresDS)mParam).Principal[0]["ApellidoPaterno"] != DBNull.Value  ){
                    return ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].ApellidoPaterno;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].ApellidoPaterno = value;
               }
	          }
        public bool IsApellidoPaternoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].IsApellidoPaternoNull();
             }
	        }
        public String TipoDoc {
            get {
                if(((SueldosCommon.sueFamiliaresDS)mParam).Principal[0]["TipoDoc"] != DBNull.Value  ){
                    return ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].TipoDoc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].TipoDoc = value;
               }
	          }
        public bool IsTipoDocNull {
             get {
                 return mParam==null || ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].IsTipoDocNull();
             }
	        }
        public String DescripcionTipoDoc {
            get {
                if(((SueldosCommon.sueFamiliaresDS)mParam).Principal[0]["DescripcionTipoDoc"] != DBNull.Value  ){
                    return ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].DescripcionTipoDoc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].DescripcionTipoDoc = value;
               }
	          }
        public bool IsDescripcionTipoDocNull {
             get {
                 return mParam==null || ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].IsDescripcionTipoDocNull();
             }
	        }
        public String NroDoc {
            get {
                if(((SueldosCommon.sueFamiliaresDS)mParam).Principal[0]["NroDoc"] != DBNull.Value  ){
                    return ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].NroDoc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].NroDoc = value;
               }
	          }
        public bool IsNroDocNull {
             get {
                 return mParam==null || ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].IsNroDocNull();
             }
	        }
        public String Relacion {
            get {
                if(((SueldosCommon.sueFamiliaresDS)mParam).Principal[0]["Relacion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].Relacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].Relacion = value;
               }
	          }
        public bool IsRelacionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].IsRelacionNull();
             }
	        }
        public String ApellidoyNombre {
            get {
                if(((SueldosCommon.sueFamiliaresDS)mParam).Principal[0]["ApellidoyNombre"] != DBNull.Value  ){
                    return ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].ApellidoyNombre;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].ApellidoyNombre = value;
               }
	          }
        public bool IsApellidoyNombreNull {
             get {
                 return mParam==null || ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].IsApellidoyNombreNull();
             }
	        }
        public String Sexo {
            get {
                if(((SueldosCommon.sueFamiliaresDS)mParam).Principal[0]["Sexo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].Sexo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].Sexo = value;
               }
	          }
        public bool IsSexoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].IsSexoNull();
             }
	        }
        public DateTime FechaNacimiento {
            get {
                if(((SueldosCommon.sueFamiliaresDS)mParam).Principal[0]["FechaNacimiento"] != DBNull.Value  ){
                    return ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].FechaNacimiento;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].FechaNacimiento = value;
               }
	          }
        public bool IsFechaNacimientoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].IsFechaNacimientoNull();
             }
	        }
        public DateTime ACargoDesde {
            get {
                if(((SueldosCommon.sueFamiliaresDS)mParam).Principal[0]["ACargoDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].ACargoDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].ACargoDesde = value;
               }
	          }
        public bool IsACargoDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].IsACargoDesdeNull();
             }
	        }
        public DateTime FechaBaja {
            get {
                if(((SueldosCommon.sueFamiliaresDS)mParam).Principal[0]["FechaBaja"] != DBNull.Value  ){
                    return ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].FechaBaja;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].FechaBaja = value;
               }
	          }
        public bool IsFechaBajaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].IsFechaBajaNull();
             }
	        }
        public DateTime FechaCarga {
            get {
                if(((SueldosCommon.sueFamiliaresDS)mParam).Principal[0]["FechaCarga"] != DBNull.Value  ){
                    return ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].FechaCarga;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].FechaCarga = value;
               }
	          }
        public bool IsFechaCargaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].IsFechaCargaNull();
             }
	        }
        public Boolean Ganancias {
            get {
                if(((SueldosCommon.sueFamiliaresDS)mParam).Principal[0]["Ganancias"] != DBNull.Value  ){
                    return ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].Ganancias;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].Ganancias = value;
               }
	          }
        public bool IsGananciasNull {
             get {
                 return mParam==null || ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].IsGananciasNull();
             }
	        }
        public Boolean Incapacitado {
            get {
                if(((SueldosCommon.sueFamiliaresDS)mParam).Principal[0]["Incapacitado"] != DBNull.Value  ){
                    return ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].Incapacitado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].Incapacitado = value;
               }
	          }
        public bool IsIncapacitadoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].IsIncapacitadoNull();
             }
	        }
        public Boolean AdhObSocial {
            get {
                if(((SueldosCommon.sueFamiliaresDS)mParam).Principal[0]["AdhObSocial"] != DBNull.Value  ){
                    return ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].AdhObSocial;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].AdhObSocial = value;
               }
	          }
        public bool IsAdhObSocialNull {
             get {
                 return mParam==null || ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].IsAdhObSocialNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((SueldosCommon.sueFamiliaresDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((SueldosCommon.sueFamiliaresDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueFamiliaresDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueFamiliaresDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueFamiliaresDS );
     }
     public sueFamiliaresActionExchange() : base( "sueFamiliares" ) {
     }

     public sueFamiliaresActionExchange(sueFamiliaresActionEnum.EnumsueFamiliaresAction pAccion) : base(sueFamiliaresActionEnum.GetAccionsueFamiliaresAction(pAccion)) {
     }

     public sueFamiliaresActionExchange(sueFamiliaresActionEnum.EnumsueFamiliaresAction pAccion, SueldosCommon.sueFamiliaresDS pdsParam) : base(sueFamiliaresActionEnum.GetAccionsueFamiliaresAction(pAccion), pdsParam) {
     }

     public sueFamiliaresActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueFamiliaresDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueFamiliaresDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueFamiliaresDS)mParam;
	        }
     }
  }
}
