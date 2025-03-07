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
    public class suePersonalActionExchange : Framework.Core.Exchange{

        public Int64 genEntidades {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["genEntidades"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].genEntidades;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].genEntidades = value;
               }
	          }
        public bool IsgenEntidadesNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsgenEntidadesNull();
             }
	        }
        public Int32 Legajo {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public Int32 Legajo_Nueva {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Legajo_Nueva"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Legajo_Nueva;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Legajo_Nueva = value;
               }
	          }
        public bool IsLegajo_NuevaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsLegajo_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Nombres {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Nombres"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Nombres;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Nombres = value;
               }
	          }
        public bool IsNombresNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsNombresNull();
             }
	        }
        public String ApellidoPaterno {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["ApellidoPaterno"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].ApellidoPaterno;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].ApellidoPaterno = value;
               }
	          }
        public bool IsApellidoPaternoNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsApellidoPaternoNull();
             }
	        }
        public String ApellidoMaterno {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["ApellidoMaterno"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].ApellidoMaterno;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].ApellidoMaterno = value;
               }
	          }
        public bool IsApellidoMaternoNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsApellidoMaternoNull();
             }
	        }
        public String NumeroDoc {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["NumeroDoc"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].NumeroDoc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].NumeroDoc = value;
               }
	          }
        public bool IsNumeroDocNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsNumeroDocNull();
             }
	        }
        public String NroSegSocial {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["NroSegSocial"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].NroSegSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].NroSegSocial = value;
               }
	          }
        public bool IsNroSegSocialNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsNroSegSocialNull();
             }
	        }
        public String Telefonos {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Telefonos"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Telefonos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Telefonos = value;
               }
	          }
        public bool IsTelefonosNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsTelefonosNull();
             }
	        }
        public String Celular {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Celular"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Celular;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Celular = value;
               }
	          }
        public bool IsCelularNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsCelularNull();
             }
	        }
        public DateTime FechaNacimiento {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["FechaNacimiento"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].FechaNacimiento;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].FechaNacimiento = value;
               }
	          }
        public bool IsFechaNacimientoNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsFechaNacimientoNull();
             }
	        }
        public String Sexo {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Sexo"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Sexo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Sexo = value;
               }
	          }
        public bool IsSexoNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsSexoNull();
             }
	        }
        public Int16 Nacionalidad {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Nacionalidad"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Nacionalidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Nacionalidad = value;
               }
	          }
        public bool IsNacionalidadNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsNacionalidadNull();
             }
	        }
        public String DescripcionNacionalidad {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionNacionalidad"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionNacionalidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionNacionalidad = value;
               }
	          }
        public bool IsDescripcionNacionalidadNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionNacionalidadNull();
             }
	        }
        public String CodigoNatural {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["CodigoNatural"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].CodigoNatural;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].CodigoNatural = value;
               }
	          }
        public bool IsCodigoNaturalNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsCodigoNaturalNull();
             }
	        }
        public String DescripcionCodigoNatural {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionCodigoNatural"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionCodigoNatural;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionCodigoNatural = value;
               }
	          }
        public bool IsDescripcionCodigoNaturalNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionCodigoNaturalNull();
             }
	        }
        public String eMail {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["eMail"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].eMail;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].eMail = value;
               }
	          }
        public bool IseMailNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IseMailNull();
             }
	        }
        public DateTime FechaIngreso {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["FechaIngreso"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].FechaIngreso;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].FechaIngreso = value;
               }
	          }
        public bool IsFechaIngresoNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsFechaIngresoNull();
             }
	        }
        public DateTime FechaBaja {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["FechaBaja"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].FechaBaja;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].FechaBaja = value;
               }
	          }
        public bool IsFechaBajaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsFechaBajaNull();
             }
	        }
        public Int32 AniosReconocidos {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["AniosReconocidos"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].AniosReconocidos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].AniosReconocidos = value;
               }
	          }
        public bool IsAniosReconocidosNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsAniosReconocidosNull();
             }
	        }
        public Int32 MesesReconocidos {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["MesesReconocidos"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].MesesReconocidos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].MesesReconocidos = value;
               }
	          }
        public bool IsMesesReconocidosNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsMesesReconocidosNull();
             }
	        }
        public String GrupoSanguineo {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["GrupoSanguineo"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].GrupoSanguineo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].GrupoSanguineo = value;
               }
	          }
        public bool IsGrupoSanguineoNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsGrupoSanguineoNull();
             }
	        }
        public String RH {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["RH"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].RH;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].RH = value;
               }
	          }
        public bool IsRHNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsRHNull();
             }
	        }
        public String BancoSucursal {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["BancoSucursal"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].BancoSucursal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].BancoSucursal = value;
               }
	          }
        public bool IsBancoSucursalNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsBancoSucursalNull();
             }
	        }
        public String BancoCuenta {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["BancoCuenta"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].BancoCuenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].BancoCuenta = value;
               }
	          }
        public bool IsBancoCuentaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsBancoCuentaNull();
             }
	        }
        public String BancoTipoCta {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["BancoTipoCta"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].BancoTipoCta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].BancoTipoCta = value;
               }
	          }
        public bool IsBancoTipoCtaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsBancoTipoCtaNull();
             }
	        }
        public Boolean CuentaInactiva {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["CuentaInactiva"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].CuentaInactiva;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].CuentaInactiva = value;
               }
	          }
        public bool IsCuentaInactivaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsCuentaInactivaNull();
             }
	        }
        public String ClaveBancaria {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["ClaveBancaria"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].ClaveBancaria;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].ClaveBancaria = value;
               }
	          }
        public bool IsClaveBancariaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsClaveBancariaNull();
             }
	        }
        public String Observaciones {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public String UMF {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["UMF"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].UMF;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].UMF = value;
               }
	          }
        public bool IsUMFNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsUMFNull();
             }
	        }
        public String AvisarA {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["AvisarA"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].AvisarA;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].AvisarA = value;
               }
	          }
        public bool IsAvisarANull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsAvisarANull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Int32 Usuario_Id {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String Actividad_Id {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Actividad_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Actividad_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Actividad_Id = value;
               }
	          }
        public bool IsActividad_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsActividad_IdNull();
             }
	        }
        public String DescripcionActividad {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionActividad"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionActividad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionActividad = value;
               }
	          }
        public bool IsDescripcionActividadNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionActividadNull();
             }
	        }
        public String Afore_Id {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Afore_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Afore_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Afore_Id = value;
               }
	          }
        public bool IsAfore_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsAfore_IdNull();
             }
	        }
        public String DescripcionAfore {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionAfore"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionAfore;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionAfore = value;
               }
	          }
        public bool IsDescripcionAforeNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionAforeNull();
             }
	        }
        public String Categoria_Id {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Categoria_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Categoria_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Categoria_Id = value;
               }
	          }
        public bool IsCategoria_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsCategoria_IdNull();
             }
	        }
        public String DescripcionCategoria {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionCategoria"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionCategoria;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionCategoria = value;
               }
	          }
        public bool IsDescripcionCategoriaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionCategoriaNull();
             }
	        }
        public String CondServicio_Id {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["CondServicio_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].CondServicio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].CondServicio_Id = value;
               }
	          }
        public bool IsCondServicio_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsCondServicio_IdNull();
             }
	        }
        public String DescripcionCondServicio {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionCondServicio"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionCondServicio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionCondServicio = value;
               }
	          }
        public bool IsDescripcionCondServicioNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionCondServicioNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuenta {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionCuenta"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionCuenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionCuenta = value;
               }
	          }
        public bool IsDescripcionCuentaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionCuentaNull();
             }
	        }
        public String Convenio_Id {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Convenio_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Convenio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Convenio_Id = value;
               }
	          }
        public bool IsConvenio_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsConvenio_IdNull();
             }
	        }
        public String Descripcionconvenio {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Descripcionconvenio"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Descripcionconvenio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Descripcionconvenio = value;
               }
	          }
        public bool IsDescripcionconvenioNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionconvenioNull();
             }
	        }
        public String Direccion1 {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Direccion1"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Direccion1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Direccion1 = value;
               }
	          }
        public bool IsDireccion1Null {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDireccion1Null();
             }
	        }
        public String CodigoPostal {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["CodigoPostal"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].CodigoPostal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].CodigoPostal = value;
               }
	          }
        public bool IsCodigoPostalNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsCodigoPostalNull();
             }
	        }
        public String Direccion2 {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Direccion2"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Direccion2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Direccion2 = value;
               }
	          }
        public bool IsDireccion2Null {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDireccion2Null();
             }
	        }
        public String EntreCalle1 {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["EntreCalle1"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].EntreCalle1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].EntreCalle1 = value;
               }
	          }
        public bool IsEntreCalle1Null {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsEntreCalle1Null();
             }
	        }
        public String EntreCalle2 {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["EntreCalle2"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].EntreCalle2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].EntreCalle2 = value;
               }
	          }
        public bool IsEntreCalle2Null {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsEntreCalle2Null();
             }
	        }
        public String Localidad {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Localidad"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Localidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Localidad = value;
               }
	          }
        public bool IsLocalidadNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsLocalidadNull();
             }
	        }
        public String NroExterior {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["NroExterior"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].NroExterior;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].NroExterior = value;
               }
	          }
        public bool IsNroExteriorNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsNroExteriorNull();
             }
	        }
        public String NroInterior {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["NroInterior"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].NroInterior;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].NroInterior = value;
               }
	          }
        public bool IsNroInteriorNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsNroInteriorNull();
             }
	        }
        public String Provincia_Id {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Provincia_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Provincia_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Provincia_Id = value;
               }
	          }
        public bool IsProvincia_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsProvincia_IdNull();
             }
	        }
        public String DescripcionProvincia {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionProvincia"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionProvincia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionProvincia = value;
               }
	          }
        public bool IsDescripcionProvinciaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionProvinciaNull();
             }
	        }
        public String EstadoCivil_Id {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["EstadoCivil_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].EstadoCivil_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].EstadoCivil_Id = value;
               }
	          }
        public bool IsEstadoCivil_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsEstadoCivil_IdNull();
             }
	        }
        public String DescripcionEdoCivil {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionEdoCivil"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionEdoCivil;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionEdoCivil = value;
               }
	          }
        public bool IsDescripcionEdoCivilNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionEdoCivilNull();
             }
	        }
        public String Localidad_Id {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Localidad_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Localidad_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Localidad_Id = value;
               }
	          }
        public bool IsLocalidad_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsLocalidad_IdNull();
             }
	        }
        public String DescripcionLocalidad {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionLocalidad"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionLocalidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionLocalidad = value;
               }
	          }
        public bool IsDescripcionLocalidadNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionLocalidadNull();
             }
	        }
        public String ModContrata_Id {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["ModContrata_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].ModContrata_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].ModContrata_Id = value;
               }
	          }
        public bool IsModContrata_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsModContrata_IdNull();
             }
	        }
        public String DescripcionModContrata {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionModContrata"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionModContrata;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionModContrata = value;
               }
	          }
        public bool IsDescripcionModContrataNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionModContrataNull();
             }
	        }
        public String Puesto_Id {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Puesto_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Puesto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Puesto_Id = value;
               }
	          }
        public bool IsPuesto_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsPuesto_IdNull();
             }
	        }
        public String DescripcionPuesto {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionPuesto"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionPuesto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionPuesto = value;
               }
	          }
        public bool IsDescripcionPuestoNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionPuestoNull();
             }
	        }
        public String Siniestro_Id {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Siniestro_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Siniestro_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Siniestro_Id = value;
               }
	          }
        public bool IsSiniestro_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsSiniestro_IdNull();
             }
	        }
        public String DescripcionSiniestro {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionSiniestro"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionSiniestro;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionSiniestro = value;
               }
	          }
        public bool IsDescripcionSiniestroNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionSiniestroNull();
             }
	        }
        public String SituacionRevi_Id {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["SituacionRevi_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].SituacionRevi_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].SituacionRevi_Id = value;
               }
	          }
        public bool IsSituacionRevi_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsSituacionRevi_IdNull();
             }
	        }
        public String DescripcionSituacionRevi {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionSituacionRevi"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionSituacionRevi;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionSituacionRevi = value;
               }
	          }
        public bool IsDescripcionSituacionReviNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionSituacionReviNull();
             }
	        }
        public String Sucursal {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public String DescripcionSucursal {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionSucursal"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionSucursal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionSucursal = value;
               }
	          }
        public bool IsDescripcionSucursalNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionSucursalNull();
             }
	        }
        public String TipoContrato {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["TipoContrato"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].TipoContrato;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].TipoContrato = value;
               }
	          }
        public bool IsTipoContratoNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsTipoContratoNull();
             }
	        }
        public String DescripcionTipoContrato {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionTipoContrato"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionTipoContrato;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionTipoContrato = value;
               }
	          }
        public bool IsDescripcionTipoContratoNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionTipoContratoNull();
             }
	        }
        public String TipoEmpleador_Id {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["TipoEmpleador_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].TipoEmpleador_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].TipoEmpleador_Id = value;
               }
	          }
        public bool IsTipoEmpleador_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsTipoEmpleador_IdNull();
             }
	        }
        public String DescripcionTipoEmpleador {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionTipoEmpleador"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionTipoEmpleador;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionTipoEmpleador = value;
               }
	          }
        public bool IsDescripcionTipoEmpleadorNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionTipoEmpleadorNull();
             }
	        }
        public String TipoJornada {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["TipoJornada"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].TipoJornada;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].TipoJornada = value;
               }
	          }
        public bool IsTipoJornadaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsTipoJornadaNull();
             }
	        }
        public String DescripcionTipoJornada {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionTipoJornada"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionTipoJornada;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionTipoJornada = value;
               }
	          }
        public bool IsDescripcionTipoJornadaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionTipoJornadaNull();
             }
	        }
        public String TipoPago_Id {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["TipoPago_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].TipoPago_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].TipoPago_Id = value;
               }
	          }
        public bool IsTipoPago_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsTipoPago_IdNull();
             }
	        }
        public String DescripcionTipoPago {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionTipoPago"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionTipoPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionTipoPago = value;
               }
	          }
        public bool IsDescripcionTipoPagoNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionTipoPagoNull();
             }
	        }
        public String TipoRegimen {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["TipoRegimen"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].TipoRegimen;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].TipoRegimen = value;
               }
	          }
        public bool IsTipoRegimenNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsTipoRegimenNull();
             }
	        }
        public String DescripcionTipoRegimen {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionTipoRegimen"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionTipoRegimen;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionTipoRegimen = value;
               }
	          }
        public bool IsDescripcionTipoRegimenNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionTipoRegimenNull();
             }
	        }
        public String TipoSDI {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["TipoSDI"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].TipoSDI;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].TipoSDI = value;
               }
	          }
        public bool IsTipoSDINull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsTipoSDINull();
             }
	        }
        public String DescripcionTipoSDI {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionTipoSDI"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionTipoSDI;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionTipoSDI = value;
               }
	          }
        public bool IsDescripcionTipoSDINull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionTipoSDINull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Decimal Porcentaje {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Porcentaje"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Porcentaje;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Porcentaje = value;
               }
	          }
        public bool IsPorcentajeNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsPorcentajeNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Cuit {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Cuit"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Cuit;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Cuit = value;
               }
	          }
        public bool IsCuitNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsCuitNull();
             }
	        }
        public String IdFiscal {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["IdFiscal"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].IdFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].IdFiscal = value;
               }
	          }
        public bool IsIdFiscalNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsIdFiscalNull();
             }
	        }
        public String TipoDoc {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["TipoDoc"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].TipoDoc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].TipoDoc = value;
               }
	          }
        public bool IsTipoDocNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsTipoDocNull();
             }
	        }
        public DateTime FechaOculta {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["FechaOculta"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].FechaOculta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].FechaOculta = value;
               }
	          }
        public bool IsFechaOcultaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsFechaOcultaNull();
             }
	        }
        public Decimal Rebaja {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Rebaja"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Rebaja;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Rebaja = value;
               }
	          }
        public bool IsRebajaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsRebajaNull();
             }
	        }
        public Decimal Reduccion {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Reduccion"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Reduccion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Reduccion = value;
               }
	          }
        public bool IsReduccionNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsReduccionNull();
             }
	        }
        public Decimal Adicional {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Adicional"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Adicional;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Adicional = value;
               }
	          }
        public bool IsAdicionalNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsAdicionalNull();
             }
	        }
        public Decimal Voluntario {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Voluntario"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Voluntario;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Voluntario = value;
               }
	          }
        public bool IsVoluntarioNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsVoluntarioNull();
             }
	        }
        public String ObraSocial {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["ObraSocial"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].ObraSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].ObraSocial = value;
               }
	          }
        public bool IsObraSocialNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsObraSocialNull();
             }
	        }
        public String DescObraSocial {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["DescObraSocial"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescObraSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].DescObraSocial = value;
               }
	          }
        public bool IsDescObraSocialNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsDescObraSocialNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.suePersonalDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersonalDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersonalDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersonalDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.suePersonalDS );
     }
     public suePersonalActionExchange() : base( "suePersonal" ) {
     }

     public suePersonalActionExchange(suePersonalActionEnum.EnumsuePersonalAction pAccion) : base(suePersonalActionEnum.GetAccionsuePersonalAction(pAccion)) {
     }

     public suePersonalActionExchange(suePersonalActionEnum.EnumsuePersonalAction pAccion, SueldosCommon.suePersonalDS pdsParam) : base(suePersonalActionEnum.GetAccionsuePersonalAction(pAccion), pdsParam) {
     }

     public suePersonalActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.suePersonalDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.suePersonalDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.suePersonalDS)mParam;
	        }
     }
  }
}
