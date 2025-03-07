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
    public class comRIConsolidacionActionExchange : Framework.Core.Exchange{

        public DateTime FechaDesde {
            get {
                if(((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String Proveed_Id {
            get {
                if(((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String DescripcionProveed {
            get {
                if(((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0]["DescripcionProveed"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].DescripcionProveed;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].DescripcionProveed = value;
               }
	          }
        public bool IsDescripcionProveedNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].IsDescripcionProveedNull();
             }
	        }
        public String TipoPermi_Id {
            get {
                if(((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0]["TipoPermi_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].TipoPermi_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].TipoPermi_Id = value;
               }
	          }
        public bool IsTipoPermi_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].IsTipoPermi_IdNull();
             }
	        }
        public String DescripcionTipoPermiRI {
            get {
                if(((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0]["DescripcionTipoPermiRI"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].DescripcionTipoPermiRI;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].DescripcionTipoPermiRI = value;
               }
	          }
        public bool IsDescripcionTipoPermiRINull {
             get {
                 return mParam==null || ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].IsDescripcionTipoPermiRINull();
             }
	        }
        public String CondPago_Id {
            get {
                if(((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0]["CondPago_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].CondPago_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].CondPago_Id = value;
               }
	          }
        public bool IsCondPago_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].IsCondPago_IdNull();
             }
	        }
        public String DescripcionCondPago {
            get {
                if(((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0]["DescripcionCondPago"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].DescripcionCondPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].DescripcionCondPago = value;
               }
	          }
        public bool IsDescripcionCondPagoNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].IsDescripcionCondPagoNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMoneda {
            get {
                if(((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0]["DescripcionMoneda"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].DescripcionMoneda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].DescripcionMoneda = value;
               }
	          }
        public bool IsDescripcionMonedaNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].IsDescripcionMonedaNull();
             }
	        }
        public Decimal Total {
            get {
                if(((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0]["Total"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].Total;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].Total = value;
               }
	          }
        public bool IsTotalNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].IsTotalNull();
             }
	        }
        public String FamiliaDesde {
            get {
                if(((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0]["FamiliaDesde"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].FamiliaDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].FamiliaDesde = value;
               }
	          }
        public bool IsFamiliaDesdeNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].IsFamiliaDesdeNull();
             }
	        }
        public String FamiliaHasta {
            get {
                if(((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0]["FamiliaHasta"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].FamiliaHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].FamiliaHasta = value;
               }
	          }
        public bool IsFamiliaHastaNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].IsFamiliaHastaNull();
             }
	        }
        public String Observaciones {
            get {
                if(((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comRIConsolidacionDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comRIConsolidacionDS );
     }
     public comRIConsolidacionActionExchange() : base( "comRIConsolidacion" ) {
     }

     public comRIConsolidacionActionExchange(comRIConsolidacionActionEnum.EnumcomRIConsolidacionAction pAccion) : base(comRIConsolidacionActionEnum.GetAccioncomRIConsolidacionAction(pAccion)) {
     }

     public comRIConsolidacionActionExchange(comRIConsolidacionActionEnum.EnumcomRIConsolidacionAction pAccion, ComprasCommon.comRIConsolidacionDS pdsParam) : base(comRIConsolidacionActionEnum.GetAccioncomRIConsolidacionAction(pAccion), pdsParam) {
     }

     public comRIConsolidacionActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comRIConsolidacionDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comRIConsolidacionDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comRIConsolidacionDS)mParam;
	        }
     }
  }
}
