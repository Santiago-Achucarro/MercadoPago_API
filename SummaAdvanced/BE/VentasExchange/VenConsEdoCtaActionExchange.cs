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
    public class VenConsEdoCtaActionExchange : Framework.Core.Exchange{

        public String Cliente_Id {
            get {
                if(((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String MonedaCtaCte {
            get {
                if(((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0]["MonedaCtaCte"] != DBNull.Value  ){
                    return ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].MonedaCtaCte;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].MonedaCtaCte = value;
               }
	          }
        public bool IsMonedaCtaCteNull {
             get {
                 return mParam==null || ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].IsMonedaCtaCteNull();
             }
	        }
        public Int32 SucursalClie {
            get {
                if(((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0]["SucursalClie"] != DBNull.Value  ){
                    return ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].SucursalClie;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].SucursalClie = value;
               }
	          }
        public bool IsSucursalClieNull {
             get {
                 return mParam==null || ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].IsSucursalClieNull();
             }
	        }
        public String NombreFantasia {
            get {
                if(((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0]["NombreFantasia"] != DBNull.Value  ){
                    return ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].NombreFantasia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].NombreFantasia = value;
               }
	          }
        public bool IsNombreFantasiaNull {
             get {
                 return mParam==null || ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].IsNombreFantasiaNull();
             }
	        }
        public Decimal LimiteCredito {
            get {
                if(((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0]["LimiteCredito"] != DBNull.Value  ){
                    return ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].LimiteCredito;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].LimiteCredito = value;
               }
	          }
        public bool IsLimiteCreditoNull {
             get {
                 return mParam==null || ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].IsLimiteCreditoNull();
             }
	        }
        public Decimal LimiteCreditoOri {
            get {
                if(((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0]["LimiteCreditoOri"] != DBNull.Value  ){
                    return ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].LimiteCreditoOri;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].LimiteCreditoOri = value;
               }
	          }
        public bool IsLimiteCreditoOriNull {
             get {
                 return mParam==null || ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].IsLimiteCreditoOriNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String Vendedor_Id {
            get {
                if(((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0]["Vendedor_Id"] != DBNull.Value  ){
                    return ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].Vendedor_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].Vendedor_Id = value;
               }
	          }
        public bool IsVendedor_IdNull {
             get {
                 return mParam==null || ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].IsVendedor_IdNull();
             }
	        }
        public String DescripcionVendedor {
            get {
                if(((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0]["DescripcionVendedor"] != DBNull.Value  ){
                    return ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].DescripcionVendedor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].DescripcionVendedor = value;
               }
	          }
        public bool IsDescripcionVendedorNull {
             get {
                 return mParam==null || ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].IsDescripcionVendedorNull();
             }
	        }
        public String Cobrador_Id {
            get {
                if(((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0]["Cobrador_Id"] != DBNull.Value  ){
                    return ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].Cobrador_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].Cobrador_Id = value;
               }
	          }
        public bool IsCobrador_IdNull {
             get {
                 return mParam==null || ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].IsCobrador_IdNull();
             }
	        }
        public String DescripcionCobrador {
            get {
                if(((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0]["DescripcionCobrador"] != DBNull.Value  ){
                    return ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].DescripcionCobrador;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].DescripcionCobrador = value;
               }
	          }
        public bool IsDescripcionCobradorNull {
             get {
                 return mParam==null || ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].IsDescripcionCobradorNull();
             }
	        }
        public Boolean Pendiente {
            get {
                if(((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0]["Pendiente"] != DBNull.Value  ){
                    return ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].Pendiente;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].Pendiente = value;
               }
	          }
        public bool IsPendienteNull {
             get {
                 return mParam==null || ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].IsPendienteNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Int32 Sucursal {
            get {
                if(((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public Boolean SoloEstaMoneda {
            get {
                if(((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0]["SoloEstaMoneda"] != DBNull.Value  ){
                    return ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].SoloEstaMoneda;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].SoloEstaMoneda = value;
               }
	          }
        public bool IsSoloEstaMonedaNull {
             get {
                 return mParam==null || ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].IsSoloEstaMonedaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.VenConsEdoCtaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.VenConsEdoCtaDS );
     }
     public VenConsEdoCtaActionExchange() : base( "VenConsEdoCta" ) {
     }

     public VenConsEdoCtaActionExchange(VenConsEdoCtaActionEnum.EnumVenConsEdoCtaAction pAccion) : base(VenConsEdoCtaActionEnum.GetAccionVenConsEdoCtaAction(pAccion)) {
     }

     public VenConsEdoCtaActionExchange(VenConsEdoCtaActionEnum.EnumVenConsEdoCtaAction pAccion, VentasCommon.VenConsEdoCtaDS pdsParam) : base(VenConsEdoCtaActionEnum.GetAccionVenConsEdoCtaAction(pAccion), pdsParam) {
     }

     public VenConsEdoCtaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.VenConsEdoCtaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.VenConsEdoCtaDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.VenConsEdoCtaDS)mParam;
	        }
     }
  }
}
