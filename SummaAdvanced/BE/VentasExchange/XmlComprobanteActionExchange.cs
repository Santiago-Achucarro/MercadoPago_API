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
    public class XmlComprobanteActionExchange : Framework.Core.Exchange{

        public String Version {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["Version"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Version;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Version = value;
               }
	          }
        public bool IsVersionNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsVersionNull();
             }
	        }
        public Int64 Asiento_Id {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["Asiento_Id"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Asiento_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Asiento_Id = value;
               }
	          }
        public bool IsAsiento_IdNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsAsiento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public DateTime FechaRegistro {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["FechaRegistro"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].FechaRegistro;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].FechaRegistro = value;
               }
	          }
        public bool IsFechaRegistroNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsFechaRegistroNull();
             }
	        }
        public String MetodoPago {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["MetodoPago"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].MetodoPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].MetodoPago = value;
               }
	          }
        public bool IsMetodoPagoNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsMetodoPagoNull();
             }
	        }
        public String NoCertificado {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["NoCertificado"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].NoCertificado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].NoCertificado = value;
               }
	          }
        public bool IsNoCertificadoNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsNoCertificadoNull();
             }
	        }
        public String Certificado {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["Certificado"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Certificado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Certificado = value;
               }
	          }
        public bool IsCertificadoNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsCertificadoNull();
             }
	        }
        public String CondicionesDePago {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["CondicionesDePago"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].CondicionesDePago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].CondicionesDePago = value;
               }
	          }
        public bool IsCondicionesDePagoNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsCondicionesDePagoNull();
             }
	        }
        public Decimal SubTotal {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["SubTotal"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].SubTotal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].SubTotal = value;
               }
	          }
        public bool IsSubTotalNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsSubTotalNull();
             }
	        }
        public Decimal Descuento {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["Descuento"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Descuento;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Descuento = value;
               }
	          }
        public bool IsDescuentoNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsDescuentoNull();
             }
	        }
        public String Moneda {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["Moneda"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Moneda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Moneda = value;
               }
	          }
        public bool IsMonedaNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsMonedaNull();
             }
	        }
        public String DescripcionMoneda {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["DescripcionMoneda"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].DescripcionMoneda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].DescripcionMoneda = value;
               }
	          }
        public bool IsDescripcionMonedaNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsDescripcionMonedaNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public Decimal Total {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["Total"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Total;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Total = value;
               }
	          }
        public bool IsTotalNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsTotalNull();
             }
	        }
        public Decimal TipoCambio {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["TipoCambio"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].TipoCambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].TipoCambio = value;
               }
	          }
        public bool IsTipoCambioNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsTipoCambioNull();
             }
	        }
        public String TipoDeComprobante {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["TipoDeComprobante"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].TipoDeComprobante;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].TipoDeComprobante = value;
               }
	          }
        public bool IsTipoDeComprobanteNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsTipoDeComprobanteNull();
             }
	        }
        public String FormaPago {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["FormaPago"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].FormaPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].FormaPago = value;
               }
	          }
        public bool IsFormaPagoNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsFormaPagoNull();
             }
	        }
        public String LugarExpedicion {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["LugarExpedicion"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].LugarExpedicion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].LugarExpedicion = value;
               }
	          }
        public bool IsLugarExpedicionNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsLugarExpedicionNull();
             }
	        }
        public String Confirmacion {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["Confirmacion"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Confirmacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Confirmacion = value;
               }
	          }
        public bool IsConfirmacionNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsConfirmacionNull();
             }
	        }
        public Int64 venMovimientos {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.XmlComprobanteDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.XmlComprobanteDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.XmlComprobanteDS );
     }
     public XmlComprobanteActionExchange() : base( "XmlComprobante" ) {
     }

     public XmlComprobanteActionExchange(XmlComprobanteActionEnum.EnumXmlComprobanteAction pAccion) : base(XmlComprobanteActionEnum.GetAccionXmlComprobanteAction(pAccion)) {
     }

     public XmlComprobanteActionExchange(XmlComprobanteActionEnum.EnumXmlComprobanteAction pAccion, VentasCommon.XmlComprobanteDS pdsParam) : base(XmlComprobanteActionEnum.GetAccionXmlComprobanteAction(pAccion), pdsParam) {
     }

     public XmlComprobanteActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.XmlComprobanteDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public XmlComprobanteActionExchange(VentasCommon.XmlComprobanteDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.XmlComprobanteDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.XmlComprobanteDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.XmlComprobanteDS)mParam;
	        }
     }
  }
}
