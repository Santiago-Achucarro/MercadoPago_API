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
    public class genEntidadesActionExchange : Framework.Core.Exchange{

        public Int64 genEntidades {
            get {
                if(((GeneralesCommon.genEntidadesDS)mParam).Principal[0]["genEntidades"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].genEntidades;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].genEntidades = value;
               }
	          }
        public bool IsgenEntidadesNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].IsgenEntidadesNull();
             }
	        }
        public DateTime FechaAlta {
            get {
                if(((GeneralesCommon.genEntidadesDS)mParam).Principal[0]["FechaAlta"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].FechaAlta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].FechaAlta = value;
               }
	          }
        public bool IsFechaAltaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].IsFechaAltaNull();
             }
	        }
        public Int32 Usuario_Id {
            get {
                if(((GeneralesCommon.genEntidadesDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String Cuit {
            get {
                if(((GeneralesCommon.genEntidadesDS)mParam).Principal[0]["Cuit"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].Cuit;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].Cuit = value;
               }
	          }
        public bool IsCuitNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].IsCuitNull();
             }
	        }
        public String TipoDoc {
            get {
                if(((GeneralesCommon.genEntidadesDS)mParam).Principal[0]["TipoDoc"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].TipoDoc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].TipoDoc = value;
               }
	          }
        public bool IsTipoDocNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].IsTipoDocNull();
             }
	        }
        public String idFiscal {
            get {
                if(((GeneralesCommon.genEntidadesDS)mParam).Principal[0]["idFiscal"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].idFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].idFiscal = value;
               }
	          }
        public bool IsidFiscalNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].IsidFiscalNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((GeneralesCommon.genEntidadesDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((GeneralesCommon.genEntidadesDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String ClieRazonSocial {
            get {
                if(((GeneralesCommon.genEntidadesDS)mParam).Principal[0]["ClieRazonSocial"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].ClieRazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].ClieRazonSocial = value;
               }
	          }
        public bool IsClieRazonSocialNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].IsClieRazonSocialNull();
             }
	        }
        public String Proveed_Id {
            get {
                if(((GeneralesCommon.genEntidadesDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String ProvRazonSocial {
            get {
                if(((GeneralesCommon.genEntidadesDS)mParam).Principal[0]["ProvRazonSocial"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].ProvRazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].ProvRazonSocial = value;
               }
	          }
        public bool IsProvRazonSocialNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].IsProvRazonSocialNull();
             }
	        }
        public String Vendedor_Id {
            get {
                if(((GeneralesCommon.genEntidadesDS)mParam).Principal[0]["Vendedor_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].Vendedor_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].Vendedor_Id = value;
               }
	          }
        public bool IsVendedor_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].IsVendedor_IdNull();
             }
	        }
        public String VenNombre {
            get {
                if(((GeneralesCommon.genEntidadesDS)mParam).Principal[0]["VenNombre"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].VenNombre;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].VenNombre = value;
               }
	          }
        public bool IsVenNombreNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].IsVenNombreNull();
             }
	        }
        public String Cobrador_Id {
            get {
                if(((GeneralesCommon.genEntidadesDS)mParam).Principal[0]["Cobrador_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].Cobrador_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].Cobrador_Id = value;
               }
	          }
        public bool IsCobrador_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].IsCobrador_IdNull();
             }
	        }
        public String CobNombre {
            get {
                if(((GeneralesCommon.genEntidadesDS)mParam).Principal[0]["CobNombre"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].CobNombre;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].CobNombre = value;
               }
	          }
        public bool IsCobNombreNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].IsCobNombreNull();
             }
	        }
        public Int32 Legajo {
            get {
                if(((GeneralesCommon.genEntidadesDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public String SueNombre {
            get {
                if(((GeneralesCommon.genEntidadesDS)mParam).Principal[0]["SueNombre"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].SueNombre;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].SueNombre = value;
               }
	          }
        public bool IsSueNombreNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].IsSueNombreNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genEntidadesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genEntidadesDS );
     }
     public genEntidadesActionExchange() : base( "genEntidades" ) {
     }

     public genEntidadesActionExchange(genEntidadesActionEnum.EnumgenEntidadesAction pAccion) : base(genEntidadesActionEnum.GetAcciongenEntidadesAction(pAccion)) {
     }

     public genEntidadesActionExchange(genEntidadesActionEnum.EnumgenEntidadesAction pAccion, GeneralesCommon.genEntidadesDS pdsParam) : base(genEntidadesActionEnum.GetAcciongenEntidadesAction(pAccion), pdsParam) {
     }

     public genEntidadesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genEntidadesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genEntidadesDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genEntidadesDS)mParam;
	        }
     }
  }
}
