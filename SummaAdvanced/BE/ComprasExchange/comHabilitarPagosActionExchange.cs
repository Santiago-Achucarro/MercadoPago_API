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
    public class comHabilitarPagosActionExchange : Framework.Core.Exchange{

        public String Proveed_Id {
            get {
                if(((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean SoloHabilitados {
            get {
                if(((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0]["SoloHabilitados"] != DBNull.Value  ){
                    return ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].SoloHabilitados;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].SoloHabilitados = value;
               }
	          }
        public bool IsSoloHabilitadosNull {
             get {
                 return mParam==null || ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].IsSoloHabilitadosNull();
             }
	        }
        public Decimal Total {
            get {
                if(((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0]["Total"] != DBNull.Value  ){
                    return ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].Total;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].Total = value;
               }
	          }
        public bool IsTotalNull {
             get {
                 return mParam==null || ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].IsTotalNull();
             }
	        }
        public DateTime FechaPago {
            get {
                if(((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0]["FechaPago"] != DBNull.Value  ){
                    return ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].FechaPago;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].FechaPago = value;
               }
	          }
        public bool IsFechaPagoNull {
             get {
                 return mParam==null || ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].IsFechaPagoNull();
             }
	        }
        public String Upload {
            get {
                if(((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0]["Upload"] != DBNull.Value  ){
                    return ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].Upload;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].Upload = value;
               }
	          }
        public bool IsUploadNull {
             get {
                 return mParam==null || ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].IsUploadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comHabilitarPagosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comHabilitarPagosDS );
     }
     public comHabilitarPagosActionExchange() : base( "comHabilitarPagos" ) {
     }

     public comHabilitarPagosActionExchange(comHabilitarPagosActionEnum.EnumcomHabilitarPagosAction pAccion) : base(comHabilitarPagosActionEnum.GetAccioncomHabilitarPagosAction(pAccion)) {
     }

     public comHabilitarPagosActionExchange(comHabilitarPagosActionEnum.EnumcomHabilitarPagosAction pAccion, ComprasCommon.comHabilitarPagosDS pdsParam) : base(comHabilitarPagosActionEnum.GetAccioncomHabilitarPagosAction(pAccion), pdsParam) {
     }

     public comHabilitarPagosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comHabilitarPagosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comHabilitarPagosDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comHabilitarPagosDS)mParam;
	        }
     }
  }
}
