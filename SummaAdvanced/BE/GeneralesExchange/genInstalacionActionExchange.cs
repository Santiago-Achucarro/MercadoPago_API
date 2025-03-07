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
    public class genInstalacionActionExchange : Framework.Core.Exchange{

        public String Dominio_Id {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["Dominio_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].Dominio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].Dominio_Id = value;
               }
	          }
        public bool IsDominio_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsDominio_IdNull();
             }
	        }
        public String DescripcionDominios {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["DescripcionDominios"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].DescripcionDominios;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].DescripcionDominios = value;
               }
	          }
        public bool IsDescripcionDominiosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsDescripcionDominiosNull();
             }
	        }
        public Int32 Licencias {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["Licencias"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].Licencias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].Licencias = value;
               }
	          }
        public bool IsLicenciasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsLicenciasNull();
             }
	        }
        public String RptServidor {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["RptServidor"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].RptServidor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].RptServidor = value;
               }
	          }
        public bool IsRptServidorNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsRptServidorNull();
             }
	        }
        public String RptCarpeta {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["RptCarpeta"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].RptCarpeta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].RptCarpeta = value;
               }
	          }
        public bool IsRptCarpetaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsRptCarpetaNull();
             }
	        }
        public String RptUsuario {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["RptUsuario"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].RptUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].RptUsuario = value;
               }
	          }
        public bool IsRptUsuarioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsRptUsuarioNull();
             }
	        }
        public String RptClave {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["RptClave"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].RptClave;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].RptClave = value;
               }
	          }
        public bool IsRptClaveNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsRptClaveNull();
             }
	        }
        public String RptDominio {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["RptDominio"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].RptDominio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].RptDominio = value;
               }
	          }
        public bool IsRptDominioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsRptDominioNull();
             }
	        }
        public String Licencia {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["Licencia"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].Licencia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].Licencia = value;
               }
	          }
        public bool IsLicenciaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsLicenciaNull();
             }
	        }
        public String Clave {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["Clave"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].Clave;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].Clave = value;
               }
	          }
        public bool IsClaveNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsClaveNull();
             }
	        }
        public DateTime FechaVencimiento {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["FechaVencimiento"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].FechaVencimiento;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].FechaVencimiento = value;
               }
	          }
        public bool IsFechaVencimientoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsFechaVencimientoNull();
             }
	        }
        public Int32 UsoHorario {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["UsoHorario"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].UsoHorario;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].UsoHorario = value;
               }
	          }
        public bool IsUsoHorarioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsUsoHorarioNull();
             }
	        }
        public Boolean PorEmpresa {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["PorEmpresa"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].PorEmpresa;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].PorEmpresa = value;
               }
	          }
        public bool IsPorEmpresaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsPorEmpresaNull();
             }
	        }
        public String TamanioHoja {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["TamanioHoja"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].TamanioHoja;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].TamanioHoja = value;
               }
	          }
        public bool IsTamanioHojaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsTamanioHojaNull();
             }
	        }
        public Int32 LongitudClave {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["LongitudClave"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].LongitudClave;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].LongitudClave = value;
               }
	          }
        public bool IsLongitudClaveNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsLongitudClaveNull();
             }
	        }
        public Int32 DiasDuracionClave {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["DiasDuracionClave"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].DiasDuracionClave;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].DiasDuracionClave = value;
               }
	          }
        public bool IsDiasDuracionClaveNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsDiasDuracionClaveNull();
             }
	        }
        public Int32 LoginGracia {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["LoginGracia"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].LoginGracia;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].LoginGracia = value;
               }
	          }
        public bool IsLoginGraciaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsLoginGraciaNull();
             }
	        }
        public Int32 CantIntentosFallidos {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["CantIntentosFallidos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].CantIntentosFallidos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].CantIntentosFallidos = value;
               }
	          }
        public bool IsCantIntentosFallidosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsCantIntentosFallidosNull();
             }
	        }
        public Boolean ClaveSimbolos {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["ClaveSimbolos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].ClaveSimbolos;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].ClaveSimbolos = value;
               }
	          }
        public bool IsClaveSimbolosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsClaveSimbolosNull();
             }
	        }
        public Boolean ClaveNumero {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["ClaveNumero"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].ClaveNumero;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].ClaveNumero = value;
               }
	          }
        public bool IsClaveNumeroNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsClaveNumeroNull();
             }
	        }
        public Boolean ClaveMayuscula {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["ClaveMayuscula"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].ClaveMayuscula;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].ClaveMayuscula = value;
               }
	          }
        public bool IsClaveMayusculaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsClaveMayusculaNull();
             }
	        }
        public Boolean ClaveMinuscula {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["ClaveMinuscula"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].ClaveMinuscula;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].ClaveMinuscula = value;
               }
	          }
        public bool IsClaveMinusculaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsClaveMinusculaNull();
             }
	        }
        public Boolean ClaveComunes {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["ClaveComunes"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].ClaveComunes;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].ClaveComunes = value;
               }
	          }
        public bool IsClaveComunesNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsClaveComunesNull();
             }
	        }
        public Int16 conDigiCta {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["conDigiCta"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].conDigiCta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].conDigiCta = value;
               }
	          }
        public bool IsconDigiCtaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsconDigiCtaNull();
             }
	        }
        public Int16 conDigiSubCta {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["conDigiSubCta"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].conDigiSubCta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].conDigiSubCta = value;
               }
	          }
        public bool IsconDigiSubCtaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsconDigiSubCtaNull();
             }
	        }
        public String contMascaraCuenta {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["contMascaraCuenta"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].contMascaraCuenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].contMascaraCuenta = value;
               }
	          }
        public bool IscontMascaraCuentaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IscontMascaraCuentaNull();
             }
	        }
        public Boolean TwoFactor {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["TwoFactor"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].TwoFactor;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].TwoFactor = value;
               }
	          }
        public bool IsTwoFactorNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsTwoFactorNull();
             }
	        }
        public Boolean EntrarSiFallaCorreo {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["EntrarSiFallaCorreo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].EntrarSiFallaCorreo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].EntrarSiFallaCorreo = value;
               }
	          }
        public bool IsEntrarSiFallaCorreoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsEntrarSiFallaCorreoNull();
             }
	        }
        public Int32 DuracionCookie {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["DuracionCookie"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].DuracionCookie;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].DuracionCookie = value;
               }
	          }
        public bool IsDuracionCookieNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsDuracionCookieNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genInstalacionDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genInstalacionDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genInstalacionDS );
     }
     public genInstalacionActionExchange() : base( "genInstalacion" ) {
     }

     public genInstalacionActionExchange(genInstalacionActionEnum.EnumgenInstalacionAction pAccion) : base(genInstalacionActionEnum.GetAcciongenInstalacionAction(pAccion)) {
     }

     public genInstalacionActionExchange(genInstalacionActionEnum.EnumgenInstalacionAction pAccion, GeneralesCommon.genInstalacionDS pdsParam) : base(genInstalacionActionEnum.GetAcciongenInstalacionAction(pAccion), pdsParam) {
     }

     public genInstalacionActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genInstalacionDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genInstalacionDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genInstalacionDS)mParam;
	        }
     }
  }
}
