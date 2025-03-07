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
    public class venVendedoresActionExchange : Framework.Core.Exchange{

        public Int64 venVendedores {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["venVendedores"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].venVendedores;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].venVendedores = value;
               }
	          }
        public bool IsvenVendedoresNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsvenVendedoresNull();
             }
	        }
        public String Vendedor_Id {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["Vendedor_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].Vendedor_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].Vendedor_Id = value;
               }
	          }
        public bool IsVendedor_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsVendedor_IdNull();
             }
	        }
        public String Vendedor_Id_Nueva {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["Vendedor_Id_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].Vendedor_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].Vendedor_Id_Nueva = value;
               }
	          }
        public bool IsVendedor_Id_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsVendedor_Id_NuevaNull();
             }
	        }
        public String CUIT {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["CUIT"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].CUIT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].CUIT = value;
               }
	          }
        public bool IsCUITNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsCUITNull();
             }
	        }
        public String TipoDoc {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["TipoDoc"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].TipoDoc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].TipoDoc = value;
               }
	          }
        public bool IsTipoDocNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsTipoDocNull();
             }
	        }
        public String IdFiscal {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["IdFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].IdFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].IdFiscal = value;
               }
	          }
        public bool IsIdFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsIdFiscalNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Nombre {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["Nombre"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].Nombre;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].Nombre = value;
               }
	          }
        public bool IsNombreNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsNombreNull();
             }
	        }
        public Decimal Comision {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["Comision"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].Comision;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].Comision = value;
               }
	          }
        public bool IsComisionNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsComisionNull();
             }
	        }
        public Decimal ComisionxSuperv {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["ComisionxSuperv"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].ComisionxSuperv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].ComisionxSuperv = value;
               }
	          }
        public bool IsComisionxSupervNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsComisionxSupervNull();
             }
	        }
        public String Supervisor_Id {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["Supervisor_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].Supervisor_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].Supervisor_Id = value;
               }
	          }
        public bool IsSupervisor_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsSupervisor_IdNull();
             }
	        }
        public String NombreSupervisor {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["NombreSupervisor"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].NombreSupervisor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].NombreSupervisor = value;
               }
	          }
        public bool IsNombreSupervisorNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsNombreSupervisorNull();
             }
	        }
        public Decimal PisoDeVentas {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["PisoDeVentas"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].PisoDeVentas;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].PisoDeVentas = value;
               }
	          }
        public bool IsPisoDeVentasNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsPisoDeVentasNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Boolean FacturaCobrada {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["FacturaCobrada"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].FacturaCobrada;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].FacturaCobrada = value;
               }
	          }
        public bool IsFacturaCobradaNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsFacturaCobradaNull();
             }
	        }
        public Boolean ConAnticipos {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["ConAnticipos"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].ConAnticipos;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].ConAnticipos = value;
               }
	          }
        public bool IsConAnticiposNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsConAnticiposNull();
             }
	        }
        public Boolean SinImpuestos {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["SinImpuestos"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].SinImpuestos;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].SinImpuestos = value;
               }
	          }
        public bool IsSinImpuestosNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsSinImpuestosNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["Usuario"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].Usuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].Usuario = value;
               }
	          }
        public bool IsUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsUsuarioNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String ClieRazonSocial {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["ClieRazonSocial"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].ClieRazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].ClieRazonSocial = value;
               }
	          }
        public bool IsClieRazonSocialNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsClieRazonSocialNull();
             }
	        }
        public String Proveed_Id {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String ProvRazonSocial {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["ProvRazonSocial"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].ProvRazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].ProvRazonSocial = value;
               }
	          }
        public bool IsProvRazonSocialNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsProvRazonSocialNull();
             }
	        }
        public String Cobrador_Id {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["Cobrador_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].Cobrador_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].Cobrador_Id = value;
               }
	          }
        public bool IsCobrador_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsCobrador_IdNull();
             }
	        }
        public String CobNombre {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["CobNombre"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].CobNombre;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].CobNombre = value;
               }
	          }
        public bool IsCobNombreNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsCobNombreNull();
             }
	        }
        public Int32 Legajo {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public String SueNombre {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["SueNombre"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].SueNombre;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].SueNombre = value;
               }
	          }
        public bool IsSueNombreNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsSueNombreNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario_Id {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["DescripcionUsuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].DescripcionUsuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].DescripcionUsuario_Id = value;
               }
	          }
        public bool IsDescripcionUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsDescripcionUsuario_IdNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venVendedoresDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venVendedoresDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venVendedoresDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venVendedoresDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venVendedoresDS );
     }
     public venVendedoresActionExchange() : base( "venVendedores" ) {
     }

     public venVendedoresActionExchange(venVendedoresActionEnum.EnumvenVendedoresAction pAccion) : base(venVendedoresActionEnum.GetAccionvenVendedoresAction(pAccion)) {
     }

     public venVendedoresActionExchange(venVendedoresActionEnum.EnumvenVendedoresAction pAccion, VentasCommon.venVendedoresDS pdsParam) : base(venVendedoresActionEnum.GetAccionvenVendedoresAction(pAccion), pdsParam) {
     }

     public venVendedoresActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venVendedoresDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venVendedoresDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venVendedoresDS)mParam;
	        }
     }
  }
}
