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
    public class venPediAutorizaActionExchange : Framework.Core.Exchange{

        public String Cliente_Id {
            get {
                if(((VentasCommon.venPediAutorizaDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((VentasCommon.venPediAutorizaDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String TipoClie_Id {
            get {
                if(((VentasCommon.venPediAutorizaDS)mParam).Principal[0]["TipoClie_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].TipoClie_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].TipoClie_Id = value;
               }
	          }
        public bool IsTipoClie_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].IsTipoClie_IdNull();
             }
	        }
        public String DescripcionTipoClie {
            get {
                if(((VentasCommon.venPediAutorizaDS)mParam).Principal[0]["DescripcionTipoClie"] != DBNull.Value  ){
                    return ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].DescripcionTipoClie;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].DescripcionTipoClie = value;
               }
	          }
        public bool IsDescripcionTipoClieNull {
             get {
                 return mParam==null || ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].IsDescripcionTipoClieNull();
             }
	        }
        public String Vendedor_Id {
            get {
                if(((VentasCommon.venPediAutorizaDS)mParam).Principal[0]["Vendedor_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].Vendedor_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].Vendedor_Id = value;
               }
	          }
        public bool IsVendedor_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].IsVendedor_IdNull();
             }
	        }
        public String DescripcionVendedor {
            get {
                if(((VentasCommon.venPediAutorizaDS)mParam).Principal[0]["DescripcionVendedor"] != DBNull.Value  ){
                    return ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].DescripcionVendedor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].DescripcionVendedor = value;
               }
	          }
        public bool IsDescripcionVendedorNull {
             get {
                 return mParam==null || ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].IsDescripcionVendedorNull();
             }
	        }
        public String Zona_Id {
            get {
                if(((VentasCommon.venPediAutorizaDS)mParam).Principal[0]["Zona_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].Zona_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].Zona_Id = value;
               }
	          }
        public bool IsZona_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].IsZona_IdNull();
             }
	        }
        public String DescripcionZona {
            get {
                if(((VentasCommon.venPediAutorizaDS)mParam).Principal[0]["DescripcionZona"] != DBNull.Value  ){
                    return ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].DescripcionZona;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].DescripcionZona = value;
               }
	          }
        public bool IsDescripcionZonaNull {
             get {
                 return mParam==null || ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].IsDescripcionZonaNull();
             }
	        }
        public String FormaEntrega_Id {
            get {
                if(((VentasCommon.venPediAutorizaDS)mParam).Principal[0]["FormaEntrega_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].FormaEntrega_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].FormaEntrega_Id = value;
               }
	          }
        public bool IsFormaEntrega_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].IsFormaEntrega_IdNull();
             }
	        }
        public String DescripcionFormaEntrega {
            get {
                if(((VentasCommon.venPediAutorizaDS)mParam).Principal[0]["DescripcionFormaEntrega"] != DBNull.Value  ){
                    return ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].DescripcionFormaEntrega;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].DescripcionFormaEntrega = value;
               }
	          }
        public bool IsDescripcionFormaEntregaNull {
             get {
                 return mParam==null || ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].IsDescripcionFormaEntregaNull();
             }
	        }
        public String PrimeraVez {
            get {
                if(((VentasCommon.venPediAutorizaDS)mParam).Principal[0]["PrimeraVez"] != DBNull.Value  ){
                    return ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].PrimeraVez;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].PrimeraVez = value;
               }
	          }
        public bool IsPrimeraVezNull {
             get {
                 return mParam==null || ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].IsPrimeraVezNull();
             }
	        }
        public String Mensaje {
            get {
                if(((VentasCommon.venPediAutorizaDS)mParam).Principal[0]["Mensaje"] != DBNull.Value  ){
                    return ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].Mensaje;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].Mensaje = value;
               }
	          }
        public bool IsMensajeNull {
             get {
                 return mParam==null || ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].IsMensajeNull();
             }
	        }
        public Int32 Registro {
            get {
                if(((VentasCommon.venPediAutorizaDS)mParam).Principal[0]["Registro"] != DBNull.Value  ){
                    return ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].Registro;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].Registro = value;
               }
	          }
        public bool IsRegistroNull {
             get {
                 return mParam==null || ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].IsRegistroNull();
             }
	        }
        public String Continuar {
            get {
                if(((VentasCommon.venPediAutorizaDS)mParam).Principal[0]["Continuar"] != DBNull.Value  ){
                    return ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].Continuar;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].Continuar = value;
               }
	          }
        public bool IsContinuarNull {
             get {
                 return mParam==null || ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].IsContinuarNull();
             }
	        }
        public String Cobrador_Id {
            get {
                if(((VentasCommon.venPediAutorizaDS)mParam).Principal[0]["Cobrador_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].Cobrador_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].Cobrador_Id = value;
               }
	          }
        public bool IsCobrador_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].IsCobrador_IdNull();
             }
	        }
        public String DescripcionCobrador {
            get {
                if(((VentasCommon.venPediAutorizaDS)mParam).Principal[0]["DescripcionCobrador"] != DBNull.Value  ){
                    return ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].DescripcionCobrador;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].DescripcionCobrador = value;
               }
	          }
        public bool IsDescripcionCobradorNull {
             get {
                 return mParam==null || ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].IsDescripcionCobradorNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venPediAutorizaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venPediAutorizaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venPediAutorizaDS );
     }
     public venPediAutorizaActionExchange() : base( "venPediAutoriza" ) {
     }

     public venPediAutorizaActionExchange(venPediAutorizaActionEnum.EnumvenPediAutorizaAction pAccion) : base(venPediAutorizaActionEnum.GetAccionvenPediAutorizaAction(pAccion)) {
     }

     public venPediAutorizaActionExchange(venPediAutorizaActionEnum.EnumvenPediAutorizaAction pAccion, VentasCommon.venPediAutorizaDS pdsParam) : base(venPediAutorizaActionEnum.GetAccionvenPediAutorizaAction(pAccion), pdsParam) {
     }

     public venPediAutorizaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venPediAutorizaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venPediAutorizaActionExchange(VentasCommon.venPediAutorizaDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venPediAutorizaDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venPediAutorizaDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venPediAutorizaDS)mParam;
	        }
     }
  }
}
