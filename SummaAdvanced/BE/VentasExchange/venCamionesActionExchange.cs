using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace VentasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class venCamionesActionExchange : Framework.Core.Exchange{

        public Int32 venCamiones {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["venCamiones"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].venCamiones;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].venCamiones = value;
               }
	          }
        public bool IsvenCamionesNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsvenCamionesNull();
             }
	        }
        public String Patente_Id {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["Patente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].Patente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].Patente_Id = value;
               }
	          }
        public bool IsPatente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsPatente_IdNull();
             }
	        }
        public String Patente_Id_Nueva {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["Patente_Id_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].Patente_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].Patente_Id_Nueva = value;
               }
	          }
        public bool IsPatente_Id_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsPatente_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String FormaEntrega_Id {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["FormaEntrega_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].FormaEntrega_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].FormaEntrega_Id = value;
               }
	          }
        public bool IsFormaEntrega_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsFormaEntrega_IdNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public Decimal CargaMaxima {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["CargaMaxima"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].CargaMaxima;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].CargaMaxima = value;
               }
	          }
        public bool IsCargaMaximaNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsCargaMaximaNull();
             }
	        }
        public Decimal Tara {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["Tara"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].Tara;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].Tara = value;
               }
	          }
        public bool IsTaraNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsTaraNull();
             }
	        }
        public String Marca {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["Marca"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].Marca;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].Marca = value;
               }
	          }
        public bool IsMarcaNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsMarcaNull();
             }
	        }
        public DateTime Inspeccion {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["Inspeccion"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].Inspeccion;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].Inspeccion = value;
               }
	          }
        public bool IsInspeccionNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsInspeccionNull();
             }
	        }
        public Boolean EsAcoplado {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["EsAcoplado"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].EsAcoplado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].EsAcoplado = value;
               }
	          }
        public bool IsEsAcopladoNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsEsAcopladoNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String NroPoliza {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["NroPoliza"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].NroPoliza;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].NroPoliza = value;
               }
	          }
        public bool IsNroPolizaNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsNroPolizaNull();
             }
	        }
        public String NombreAseg {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["NombreAseg"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].NombreAseg;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].NombreAseg = value;
               }
	          }
        public bool IsNombreAsegNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsNombreAsegNull();
             }
	        }
        public String ConfVehicular {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["ConfVehicular"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].ConfVehicular;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].ConfVehicular = value;
               }
	          }
        public bool IsConfVehicularNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsConfVehicularNull();
             }
	        }
        public Int32 Modelo {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["Modelo"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].Modelo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].Modelo = value;
               }
	          }
        public bool IsModeloNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsModeloNull();
             }
	        }
        public String TipoPermisoSCT {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["TipoPermisoSCT"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].TipoPermisoSCT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].TipoPermisoSCT = value;
               }
	          }
        public bool IsTipoPermisoSCTNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsTipoPermisoSCTNull();
             }
	        }
        public String NroPermisoSCT {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["NroPermisoSCT"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].NroPermisoSCT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].NroPermisoSCT = value;
               }
	          }
        public bool IsNroPermisoSCTNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsNroPermisoSCTNull();
             }
	        }
        public String PropArre_Id {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["PropArre_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].PropArre_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].PropArre_Id = value;
               }
	          }
        public bool IsPropArre_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsPropArre_IdNull();
             }
	        }
        public String Nombre {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["Nombre"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].Nombre;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].Nombre = value;
               }
	          }
        public bool IsNombreNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsNombreNull();
             }
	        }
        public String AseguraMedAmb {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["AseguraMedAmb"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].AseguraMedAmb;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].AseguraMedAmb = value;
               }
	          }
        public bool IsAseguraMedAmbNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsAseguraMedAmbNull();
             }
	        }
        public String PolizaMedAmbiente {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["PolizaMedAmbiente"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].PolizaMedAmbiente;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].PolizaMedAmbiente = value;
               }
	          }
        public bool IsPolizaMedAmbienteNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsPolizaMedAmbienteNull();
             }
	        }
        public String AseguraCarga {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["AseguraCarga"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].AseguraCarga;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].AseguraCarga = value;
               }
	          }
        public bool IsAseguraCargaNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsAseguraCargaNull();
             }
	        }
        public String PolizaCarga {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["PolizaCarga"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].PolizaCarga;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].PolizaCarga = value;
               }
	          }
        public bool IsPolizaCargaNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsPolizaCargaNull();
             }
	        }
        public Decimal PrimaSeguro {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["PrimaSeguro"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].PrimaSeguro;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].PrimaSeguro = value;
               }
	          }
        public bool IsPrimaSeguroNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsPrimaSeguroNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venCamionesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venCamionesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCamionesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venCamionesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venCamionesDS );
     }
     public venCamionesActionExchange() : base( "venCamiones" ) {
     }

     public venCamionesActionExchange(venCamionesActionEnum.EnumvenCamionesAction pAccion) : base(venCamionesActionEnum.GetAccionvenCamionesAction(pAccion)) {
     }

     public venCamionesActionExchange(venCamionesActionEnum.EnumvenCamionesAction pAccion, VentasCommon.venCamionesDS pdsParam) : base(venCamionesActionEnum.GetAccionvenCamionesAction(pAccion), pdsParam) {
     }

     public venCamionesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venCamionesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venCamionesActionExchange(VentasCommon.venCamionesDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venCamionesDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venCamionesDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venCamionesDS)mParam;
	        }
     }
  }
}
