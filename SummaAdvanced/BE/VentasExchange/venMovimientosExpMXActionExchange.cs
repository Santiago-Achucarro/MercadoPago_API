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
    public class venMovimientosExpMXActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public String Motivo_id {
            get {
                if(((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0]["Motivo_id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].Motivo_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].Motivo_id = value;
               }
	          }
        public bool IsMotivo_idNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].IsMotivo_idNull();
             }
	        }
        public String TipoOperacion {
            get {
                if(((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0]["TipoOperacion"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].TipoOperacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].TipoOperacion = value;
               }
	          }
        public bool IsTipoOperacionNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].IsTipoOperacionNull();
             }
	        }
        public String ClaveDePedimento {
            get {
                if(((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0]["ClaveDePedimento"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].ClaveDePedimento;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].ClaveDePedimento = value;
               }
	          }
        public bool IsClaveDePedimentoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].IsClaveDePedimentoNull();
             }
	        }
        public Int32 CertificadoOrigen {
            get {
                if(((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0]["CertificadoOrigen"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].CertificadoOrigen;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].CertificadoOrigen = value;
               }
	          }
        public bool IsCertificadoOrigenNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].IsCertificadoOrigenNull();
             }
	        }
        public String NumCertificadoOrigen {
            get {
                if(((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0]["NumCertificadoOrigen"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].NumCertificadoOrigen;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].NumCertificadoOrigen = value;
               }
	          }
        public bool IsNumCertificadoOrigenNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].IsNumCertificadoOrigenNull();
             }
	        }
        public String NumeroExportadorConfiable {
            get {
                if(((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0]["NumeroExportadorConfiable"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].NumeroExportadorConfiable;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].NumeroExportadorConfiable = value;
               }
	          }
        public bool IsNumeroExportadorConfiableNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].IsNumeroExportadorConfiableNull();
             }
	        }
        public Int32 Subdivision {
            get {
                if(((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0]["Subdivision"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].Subdivision;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].Subdivision = value;
               }
	          }
        public bool IsSubdivisionNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].IsSubdivisionNull();
             }
	        }
        public String Observaciones {
            get {
                if(((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public Decimal TipoCambioUSD {
            get {
                if(((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0]["TipoCambioUSD"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].TipoCambioUSD;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].TipoCambioUSD = value;
               }
	          }
        public bool IsTipoCambioUSDNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].IsTipoCambioUSDNull();
             }
	        }
        public Decimal TotalUSD {
            get {
                if(((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0]["TotalUSD"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].TotalUSD;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].TotalUSD = value;
               }
	          }
        public bool IsTotalUSDNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].IsTotalUSDNull();
             }
	        }
        public Boolean UsaProv {
            get {
                if(((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0]["UsaProv"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].UsaProv;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].UsaProv = value;
               }
	          }
        public bool IsUsaProvNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].IsUsaProvNull();
             }
	        }
        public String PropNumRegIdTrib {
            get {
                if(((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0]["PropNumRegIdTrib"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].PropNumRegIdTrib;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].PropNumRegIdTrib = value;
               }
	          }
        public bool IsPropNumRegIdTribNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].IsPropNumRegIdTribNull();
             }
	        }
        public String PropResidenciaFiscal {
            get {
                if(((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0]["PropResidenciaFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].PropResidenciaFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].PropResidenciaFiscal = value;
               }
	          }
        public bool IsPropResidenciaFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].IsPropResidenciaFiscalNull();
             }
	        }
        public String ReceptorNumRegIdTrib {
            get {
                if(((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0]["ReceptorNumRegIdTrib"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].ReceptorNumRegIdTrib;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].ReceptorNumRegIdTrib = value;
               }
	          }
        public bool IsReceptorNumRegIdTribNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].IsReceptorNumRegIdTribNull();
             }
	        }
        public String Destinatario_id {
            get {
                if(((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0]["Destinatario_id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].Destinatario_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].Destinatario_id = value;
               }
	          }
        public bool IsDestinatario_idNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].IsDestinatario_idNull();
             }
	        }
        public Int32 SucursalDest {
            get {
                if(((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0]["SucursalDest"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].SucursalDest;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].SucursalDest = value;
               }
	          }
        public bool IsSucursalDestNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].IsSucursalDestNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosExpMXDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMovimientosExpMXDS );
     }
     public venMovimientosExpMXActionExchange() : base( "venMovimientosExpMX" ) {
     }

     public venMovimientosExpMXActionExchange(venMovimientosExpMXActionEnum.EnumvenMovimientosExpMXAction pAccion) : base(venMovimientosExpMXActionEnum.GetAccionvenMovimientosExpMXAction(pAccion)) {
     }

     public venMovimientosExpMXActionExchange(venMovimientosExpMXActionEnum.EnumvenMovimientosExpMXAction pAccion, VentasCommon.venMovimientosExpMXDS pdsParam) : base(venMovimientosExpMXActionEnum.GetAccionvenMovimientosExpMXAction(pAccion), pdsParam) {
     }

     public venMovimientosExpMXActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMovimientosExpMXDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMovimientosExpMXDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMovimientosExpMXDS)mParam;
	        }
     }
  }
}
