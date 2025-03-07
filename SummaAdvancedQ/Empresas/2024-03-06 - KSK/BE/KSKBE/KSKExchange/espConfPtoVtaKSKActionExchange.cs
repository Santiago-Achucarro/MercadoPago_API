using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace KSKExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class espConfPtoVtaKSKActionExchange : Framework.Core.Exchange{

        public Int32 Empresa_Id {
            get {
                if(((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String SubTipoMov_Id {
            get {
                if(((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0]["SubTipoMov_Id"] != DBNull.Value  ){
                    return ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].SubTipoMov_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].SubTipoMov_Id = value;
               }
	          }
        public bool IsSubTipoMov_IdNull {
             get {
                 return mParam==null || ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].IsSubTipoMov_IdNull();
             }
	        }
        public String DescripcionSubTipoMov {
            get {
                if(((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0]["DescripcionSubTipoMov"] != DBNull.Value  ){
                    return ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].DescripcionSubTipoMov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].DescripcionSubTipoMov = value;
               }
	          }
        public bool IsDescripcionSubTipoMovNull {
             get {
                 return mParam==null || ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].IsDescripcionSubTipoMovNull();
             }
	        }
        public String Efectivo {
            get {
                if(((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0]["Efectivo"] != DBNull.Value  ){
                    return ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].Efectivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].Efectivo = value;
               }
	          }
        public bool IsEfectivoNull {
             get {
                 return mParam==null || ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].IsEfectivoNull();
             }
	        }
        public String DescripcionEfectivo {
            get {
                if(((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0]["DescripcionEfectivo"] != DBNull.Value  ){
                    return ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].DescripcionEfectivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].DescripcionEfectivo = value;
               }
	          }
        public bool IsDescripcionEfectivoNull {
             get {
                 return mParam==null || ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].IsDescripcionEfectivoNull();
             }
	        }
        public String Cheques {
            get {
                if(((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0]["Cheques"] != DBNull.Value  ){
                    return ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].Cheques;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].Cheques = value;
               }
	          }
        public bool IsChequesNull {
             get {
                 return mParam==null || ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].IsChequesNull();
             }
	        }
        public String DescripcionCheques {
            get {
                if(((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0]["DescripcionCheques"] != DBNull.Value  ){
                    return ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].DescripcionCheques;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].DescripcionCheques = value;
               }
	          }
        public bool IsDescripcionChequesNull {
             get {
                 return mParam==null || ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].IsDescripcionChequesNull();
             }
	        }
        public String TDebito {
            get {
                if(((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0]["TDebito"] != DBNull.Value  ){
                    return ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].TDebito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].TDebito = value;
               }
	          }
        public bool IsTDebitoNull {
             get {
                 return mParam==null || ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].IsTDebitoNull();
             }
	        }
        public String DescripcionTDebito {
            get {
                if(((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0]["DescripcionTDebito"] != DBNull.Value  ){
                    return ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].DescripcionTDebito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].DescripcionTDebito = value;
               }
	          }
        public bool IsDescripcionTDebitoNull {
             get {
                 return mParam==null || ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].IsDescripcionTDebitoNull();
             }
	        }
        public String TCredito {
            get {
                if(((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0]["TCredito"] != DBNull.Value  ){
                    return ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].TCredito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].TCredito = value;
               }
	          }
        public bool IsTCreditoNull {
             get {
                 return mParam==null || ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].IsTCreditoNull();
             }
	        }
        public String DescripcionTCredito {
            get {
                if(((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0]["DescripcionTCredito"] != DBNull.Value  ){
                    return ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].DescripcionTCredito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].DescripcionTCredito = value;
               }
	          }
        public bool IsDescripcionTCreditoNull {
             get {
                 return mParam==null || ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].IsDescripcionTCreditoNull();
             }
	        }
        public String Transferencia {
            get {
                if(((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0]["Transferencia"] != DBNull.Value  ){
                    return ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].Transferencia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].Transferencia = value;
               }
	          }
        public bool IsTransferenciaNull {
             get {
                 return mParam==null || ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].IsTransferenciaNull();
             }
	        }
        public String DescripcionTransferencia {
            get {
                if(((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0]["DescripcionTransferencia"] != DBNull.Value  ){
                    return ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].DescripcionTransferencia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].DescripcionTransferencia = value;
               }
	          }
        public bool IsDescripcionTransferenciaNull {
             get {
                 return mParam==null || ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].IsDescripcionTransferenciaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((KSKCommon.espConfPtoVtaKSKDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( KSKCommon.espConfPtoVtaKSKDS );
     }
     public espConfPtoVtaKSKActionExchange() : base( "espConfPtoVtaKSK" ) {
     }

     public espConfPtoVtaKSKActionExchange(espConfPtoVtaKSKActionEnum.EnumespConfPtoVtaKSKAction pAccion) : base(espConfPtoVtaKSKActionEnum.GetAccionespConfPtoVtaKSKAction(pAccion)) {
     }

     public espConfPtoVtaKSKActionExchange(espConfPtoVtaKSKActionEnum.EnumespConfPtoVtaKSKAction pAccion, KSKCommon.espConfPtoVtaKSKDS pdsParam) : base(espConfPtoVtaKSKActionEnum.GetAccionespConfPtoVtaKSKAction(pAccion), pdsParam) {
     }

     public espConfPtoVtaKSKActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new KSKCommon.espConfPtoVtaKSKDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public KSKCommon.espConfPtoVtaKSKDS Param{
	        get{
			    InitParam();
			    return (KSKCommon.espConfPtoVtaKSKDS)mParam;
	        }
     }
  }
}
