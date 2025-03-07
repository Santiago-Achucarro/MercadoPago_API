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
    public class tesXmlComprobantePagoActionExchange : Framework.Core.Exchange{

        public String Version {
            get {
                if(((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0]["Version"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].Version;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].Version = value;
               }
	          }
        public bool IsVersionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].IsVersionNull();
             }
	        }
        public String Serie {
            get {
                if(((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0]["Serie"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].Serie;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].Serie = value;
               }
	          }
        public bool IsSerieNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].IsSerieNull();
             }
	        }
        public Int32 Folio {
            get {
                if(((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0]["Folio"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].Folio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].Folio = value;
               }
	          }
        public bool IsFolioNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].IsFolioNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Int32 TesCFDICobranza {
            get {
                if(((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0]["TesCFDICobranza"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].TesCFDICobranza;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].TesCFDICobranza = value;
               }
	          }
        public bool IsTesCFDICobranzaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].IsTesCFDICobranzaNull();
             }
	        }
        public String MetodoPago {
            get {
                if(((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0]["MetodoPago"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].MetodoPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].MetodoPago = value;
               }
	          }
        public bool IsMetodoPagoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].IsMetodoPagoNull();
             }
	        }
        public String NoCertificado {
            get {
                if(((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0]["NoCertificado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].NoCertificado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].NoCertificado = value;
               }
	          }
        public bool IsNoCertificadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].IsNoCertificadoNull();
             }
	        }
        public String Certificado {
            get {
                if(((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0]["Certificado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].Certificado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].Certificado = value;
               }
	          }
        public bool IsCertificadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].IsCertificadoNull();
             }
	        }
        public String CondicionesDePago {
            get {
                if(((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0]["CondicionesDePago"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].CondicionesDePago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].CondicionesDePago = value;
               }
	          }
        public bool IsCondicionesDePagoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].IsCondicionesDePagoNull();
             }
	        }
        public Decimal SubTotal {
            get {
                if(((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0]["SubTotal"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].SubTotal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].SubTotal = value;
               }
	          }
        public bool IsSubTotalNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].IsSubTotalNull();
             }
	        }
        public Decimal Descuento {
            get {
                if(((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0]["Descuento"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].Descuento;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].Descuento = value;
               }
	          }
        public bool IsDescuentoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].IsDescuentoNull();
             }
	        }
        public String Moneda {
            get {
                if(((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0]["Moneda"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].Moneda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].Moneda = value;
               }
	          }
        public bool IsMonedaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].IsMonedaNull();
             }
	        }
        public Decimal Total {
            get {
                if(((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0]["Total"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].Total;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].Total = value;
               }
	          }
        public bool IsTotalNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].IsTotalNull();
             }
	        }
        public Decimal TipoCambio {
            get {
                if(((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0]["TipoCambio"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].TipoCambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].TipoCambio = value;
               }
	          }
        public bool IsTipoCambioNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].IsTipoCambioNull();
             }
	        }
        public String TipoDeComprobante {
            get {
                if(((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0]["TipoDeComprobante"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].TipoDeComprobante;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].TipoDeComprobante = value;
               }
	          }
        public bool IsTipoDeComprobanteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].IsTipoDeComprobanteNull();
             }
	        }
        public String FormaPago {
            get {
                if(((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0]["FormaPago"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].FormaPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].FormaPago = value;
               }
	          }
        public bool IsFormaPagoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].IsFormaPagoNull();
             }
	        }
        public String LugarExpedicion {
            get {
                if(((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0]["LugarExpedicion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].LugarExpedicion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].LugarExpedicion = value;
               }
	          }
        public bool IsLugarExpedicionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].IsLugarExpedicionNull();
             }
	        }
        public String Confirmacion {
            get {
                if(((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0]["Confirmacion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].Confirmacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].Confirmacion = value;
               }
	          }
        public bool IsConfirmacionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].IsConfirmacionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesXmlComprobantePagoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesXmlComprobantePagoDS );
     }
     public tesXmlComprobantePagoActionExchange() : base( "tesXmlComprobantePago" ) {
     }

     public tesXmlComprobantePagoActionExchange(tesXmlComprobantePagoActionEnum.EnumtesXmlComprobantePagoAction pAccion) : base(tesXmlComprobantePagoActionEnum.GetAcciontesXmlComprobantePagoAction(pAccion)) {
     }

     public tesXmlComprobantePagoActionExchange(tesXmlComprobantePagoActionEnum.EnumtesXmlComprobantePagoAction pAccion, TesoreriaCommon.tesXmlComprobantePagoDS pdsParam) : base(tesXmlComprobantePagoActionEnum.GetAcciontesXmlComprobantePagoAction(pAccion), pdsParam) {
     }

     public tesXmlComprobantePagoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesXmlComprobantePagoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesXmlComprobantePagoDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesXmlComprobantePagoDS)mParam;
	        }
     }
  }
}
