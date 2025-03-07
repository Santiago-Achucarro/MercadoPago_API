using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace TesoreriaExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class tesDepositoActionExchange : Framework.Core.Exchange{

        public Int64 tesMovimientos {
            get {
                if(((TesoreriaCommon.tesDepositoDS)mParam).Principal[0]["tesMovimientos"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].tesMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].tesMovimientos = value;
               }
	          }
        public bool IstesMovimientosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].IstesMovimientosNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((TesoreriaCommon.tesDepositoDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String FormaDePagoP {
            get {
                if(((TesoreriaCommon.tesDepositoDS)mParam).Principal[0]["FormaDePagoP"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].FormaDePagoP;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].FormaDePagoP = value;
               }
	          }
        public bool IsFormaDePagoPNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].IsFormaDePagoPNull();
             }
	        }
        public String NumOperacion {
            get {
                if(((TesoreriaCommon.tesDepositoDS)mParam).Principal[0]["NumOperacion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].NumOperacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].NumOperacion = value;
               }
	          }
        public bool IsNumOperacionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].IsNumOperacionNull();
             }
	        }
        public String NomBancoOrdExt {
            get {
                if(((TesoreriaCommon.tesDepositoDS)mParam).Principal[0]["NomBancoOrdExt"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].NomBancoOrdExt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].NomBancoOrdExt = value;
               }
	          }
        public bool IsNomBancoOrdExtNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].IsNomBancoOrdExtNull();
             }
	        }
        public String CtaOrdenante {
            get {
                if(((TesoreriaCommon.tesDepositoDS)mParam).Principal[0]["CtaOrdenante"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].CtaOrdenante;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].CtaOrdenante = value;
               }
	          }
        public bool IsCtaOrdenanteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].IsCtaOrdenanteNull();
             }
	        }
        public String TipoCadPago {
            get {
                if(((TesoreriaCommon.tesDepositoDS)mParam).Principal[0]["TipoCadPago"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].TipoCadPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].TipoCadPago = value;
               }
	          }
        public bool IsTipoCadPagoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].IsTipoCadPagoNull();
             }
	        }
        public String CertPago {
            get {
                if(((TesoreriaCommon.tesDepositoDS)mParam).Principal[0]["CertPago"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].CertPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].CertPago = value;
               }
	          }
        public bool IsCertPagoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].IsCertPagoNull();
             }
	        }
        public String CadPago {
            get {
                if(((TesoreriaCommon.tesDepositoDS)mParam).Principal[0]["CadPago"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].CadPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].CadPago = value;
               }
	          }
        public bool IsCadPagoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].IsCadPagoNull();
             }
	        }
        public String SelloPago {
            get {
                if(((TesoreriaCommon.tesDepositoDS)mParam).Principal[0]["SelloPago"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].SelloPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].SelloPago = value;
               }
	          }
        public bool IsSelloPagoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].IsSelloPagoNull();
             }
	        }
        public String RfcEmisorCtaOrd {
            get {
                if(((TesoreriaCommon.tesDepositoDS)mParam).Principal[0]["RfcEmisorCtaOrd"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].RfcEmisorCtaOrd;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].RfcEmisorCtaOrd = value;
               }
	          }
        public bool IsRfcEmisorCtaOrdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].IsRfcEmisorCtaOrdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesDepositoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepositoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesDepositoDS );
     }
     public tesDepositoActionExchange() : base( "tesDeposito" ) {
     }

     public tesDepositoActionExchange(tesDepositoActionEnum.EnumtesDepositoAction pAccion) : base(tesDepositoActionEnum.GetAcciontesDepositoAction(pAccion)) {
     }

     public tesDepositoActionExchange(tesDepositoActionEnum.EnumtesDepositoAction pAccion, TesoreriaCommon.tesDepositoDS pdsParam) : base(tesDepositoActionEnum.GetAcciontesDepositoAction(pAccion), pdsParam) {
     }

     public tesDepositoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesDepositoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesDepositoDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesDepositoDS)mParam;
	        }
     }
  }
}
