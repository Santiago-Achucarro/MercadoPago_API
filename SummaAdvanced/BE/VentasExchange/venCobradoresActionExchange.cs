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
    public class venCobradoresActionExchange : Framework.Core.Exchange{

        public Int64 venCobradores {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["venCobradores"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].venCobradores;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].venCobradores = value;
               }
	          }
        public bool IsvenCobradoresNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsvenCobradoresNull();
             }
	        }
        public String Cobrador_Id {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["Cobrador_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].Cobrador_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].Cobrador_Id = value;
               }
	          }
        public bool IsCobrador_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsCobrador_IdNull();
             }
	        }
        public String Cobrador_Id_Nueva {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["Cobrador_Id_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].Cobrador_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].Cobrador_Id_Nueva = value;
               }
	          }
        public bool IsCobrador_Id_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsCobrador_Id_NuevaNull();
             }
	        }
        public String CUIT {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["CUIT"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].CUIT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].CUIT = value;
               }
	          }
        public bool IsCUITNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsCUITNull();
             }
	        }
        public String TipoDoc {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["TipoDoc"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].TipoDoc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].TipoDoc = value;
               }
	          }
        public bool IsTipoDocNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsTipoDocNull();
             }
	        }
        public String IdFiscal {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["IdFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].IdFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].IdFiscal = value;
               }
	          }
        public bool IsIdFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsIdFiscalNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Nombre {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["Nombre"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].Nombre;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].Nombre = value;
               }
	          }
        public bool IsNombreNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsNombreNull();
             }
	        }
        public Decimal Comision {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["Comision"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].Comision;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].Comision = value;
               }
	          }
        public bool IsComisionNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsComisionNull();
             }
	        }
        public Decimal LimiteComision {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["LimiteComision"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].LimiteComision;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].LimiteComision = value;
               }
	          }
        public bool IsLimiteComisionNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsLimiteComisionNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String ClieRazonSocial {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["ClieRazonSocial"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].ClieRazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].ClieRazonSocial = value;
               }
	          }
        public bool IsClieRazonSocialNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsClieRazonSocialNull();
             }
	        }
        public String Proveed_Id {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String ProvRazonSocial {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["ProvRazonSocial"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].ProvRazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].ProvRazonSocial = value;
               }
	          }
        public bool IsProvRazonSocialNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsProvRazonSocialNull();
             }
	        }
        public String Vendedor_Id {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["Vendedor_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].Vendedor_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].Vendedor_Id = value;
               }
	          }
        public bool IsVendedor_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsVendedor_IdNull();
             }
	        }
        public String VenNombre {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["VenNombre"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].VenNombre;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].VenNombre = value;
               }
	          }
        public bool IsVenNombreNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsVenNombreNull();
             }
	        }
        public Int32 Legajo {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public String SueNombre {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["SueNombre"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].SueNombre;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].SueNombre = value;
               }
	          }
        public bool IsSueNombreNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsSueNombreNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venCobradoresDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venCobradoresDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCobradoresDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venCobradoresDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venCobradoresDS );
     }
     public venCobradoresActionExchange() : base( "venCobradores" ) {
     }

     public venCobradoresActionExchange(venCobradoresActionEnum.EnumvenCobradoresAction pAccion) : base(venCobradoresActionEnum.GetAccionvenCobradoresAction(pAccion)) {
     }

     public venCobradoresActionExchange(venCobradoresActionEnum.EnumvenCobradoresAction pAccion, VentasCommon.venCobradoresDS pdsParam) : base(venCobradoresActionEnum.GetAccionvenCobradoresAction(pAccion), pdsParam) {
     }

     public venCobradoresActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venCobradoresDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venCobradoresDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venCobradoresDS)mParam;
	        }
     }
  }
}
