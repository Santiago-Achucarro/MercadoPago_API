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
    public class esptesMPCobranzaKSKActionExchange : Framework.Core.Exchange{

        public Int32 id {
            get {
                if(((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0]["id"] != DBNull.Value  ){
                    return ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].id = value;
               }
	          }
        public bool IsidNull {
             get {
                 return mParam==null || ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].IsidNull();
             }
	        }
        public String status {
            get {
                if(((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0]["status"] != DBNull.Value  ){
                    return ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].status;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].status = value;
               }
	          }
        public bool IsstatusNull {
             get {
                 return mParam==null || ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].IsstatusNull();
             }
	        }
        public String external_reference {
            get {
                if(((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0]["external_reference"] != DBNull.Value  ){
                    return ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].external_reference;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].external_reference = value;
               }
	          }
        public bool Isexternal_referenceNull {
             get {
                 return mParam==null || ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].Isexternal_referenceNull();
             }
	        }
        public Decimal pay_transaction_amount {
            get {
                if(((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0]["pay_transaction_amount"] != DBNull.Value  ){
                    return ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].pay_transaction_amount;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].pay_transaction_amount = value;
               }
	          }
        public bool Ispay_transaction_amountNull {
             get {
                 return mParam==null || ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].Ispay_transaction_amountNull();
             }
	        }
        public String pay_status {
            get {
                if(((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0]["pay_status"] != DBNull.Value  ){
                    return ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].pay_status;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].pay_status = value;
               }
	          }
        public bool Ispay_statusNull {
             get {
                 return mParam==null || ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].Ispay_statusNull();
             }
	        }
        public String date_created {
            get {
                if(((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0]["date_created"] != DBNull.Value  ){
                    return ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].date_created;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].date_created = value;
               }
	          }
        public bool Isdate_createdNull {
             get {
                 return mParam==null || ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].Isdate_createdNull();
             }
	        }
        public Int32 col_id {
            get {
                if(((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0]["col_id"] != DBNull.Value  ){
                    return ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].col_id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].col_id = value;
               }
	          }
        public bool Iscol_idNull {
             get {
                 return mParam==null || ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].Iscol_idNull();
             }
	        }
        public String col_email {
            get {
                if(((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0]["col_email"] != DBNull.Value  ){
                    return ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].col_email;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].col_email = value;
               }
	          }
        public bool Iscol_emailNull {
             get {
                 return mParam==null || ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].Iscol_emailNull();
             }
	        }
        public String col_nickname {
            get {
                if(((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0]["col_nickname"] != DBNull.Value  ){
                    return ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].col_nickname;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].col_nickname = value;
               }
	          }
        public bool Iscol_nicknameNull {
             get {
                 return mParam==null || ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].Iscol_nicknameNull();
             }
	        }
        public Decimal APagar {
            get {
                if(((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0]["APagar"] != DBNull.Value  ){
                    return ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].APagar;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].APagar = value;
               }
	          }
        public bool IsAPagarNull {
             get {
                 return mParam==null || ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].IsAPagarNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((KSKCommon.esptesMPCobranzaKSKDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( KSKCommon.esptesMPCobranzaKSKDS );
     }
     public esptesMPCobranzaKSKActionExchange() : base( "esptesMPCobranzaKSK" ) {
     }

     public esptesMPCobranzaKSKActionExchange(esptesMPCobranzaKSKActionEnum.EnumesptesMPCobranzaKSKAction pAccion) : base(esptesMPCobranzaKSKActionEnum.GetAccionesptesMPCobranzaKSKAction(pAccion)) {
     }

     public esptesMPCobranzaKSKActionExchange(esptesMPCobranzaKSKActionEnum.EnumesptesMPCobranzaKSKAction pAccion, KSKCommon.esptesMPCobranzaKSKDS pdsParam) : base(esptesMPCobranzaKSKActionEnum.GetAccionesptesMPCobranzaKSKAction(pAccion), pdsParam) {
     }

     public esptesMPCobranzaKSKActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new KSKCommon.esptesMPCobranzaKSKDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public esptesMPCobranzaKSKActionExchange(KSKCommon.esptesMPCobranzaKSKDS pDS) : base() {
     this.Action = "";
     this.mParam = new KSKCommon.esptesMPCobranzaKSKDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public KSKCommon.esptesMPCobranzaKSKDS Param{
	        get{
			    InitParam();
			    return (KSKCommon.esptesMPCobranzaKSKDS)mParam;
	        }
     }
  }
}
