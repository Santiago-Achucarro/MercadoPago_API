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
    public class venMovimientosFiscalActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public String ClaveFiscal {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["ClaveFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].ClaveFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].ClaveFiscal = value;
               }
	          }
        public bool IsClaveFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsClaveFiscalNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Letra {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["Letra"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].Letra;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].Letra = value;
               }
	          }
        public bool IsLetraNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsLetraNull();
             }
	        }
        public Int32 Comprobante_Id {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["Comprobante_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].Comprobante_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].Comprobante_Id = value;
               }
	          }
        public bool IsComprobante_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsComprobante_IdNull();
             }
	        }
        public String DescripcionTipoComp {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["DescripcionTipoComp"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].DescripcionTipoComp;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].DescripcionTipoComp = value;
               }
	          }
        public bool IsDescripcionTipoCompNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsDescripcionTipoCompNull();
             }
	        }
        public Boolean EsFactElec {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["EsFactElec"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].EsFactElec;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].EsFactElec = value;
               }
	          }
        public bool IsEsFactElecNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsEsFactElecNull();
             }
	        }
        public String Motivo {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["Motivo"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].Motivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].Motivo = value;
               }
	          }
        public bool IsMotivoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsMotivoNull();
             }
	        }
        public String XMLFiscal {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["XMLFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].XMLFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].XMLFiscal = value;
               }
	          }
        public bool IsXMLFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsXMLFiscalNull();
             }
	        }
        public String SelloDigital {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["SelloDigital"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].SelloDigital;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].SelloDigital = value;
               }
	          }
        public bool IsSelloDigitalNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsSelloDigitalNull();
             }
	        }
        public String FechaString {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["FechaString"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].FechaString;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].FechaString = value;
               }
	          }
        public bool IsFechaStringNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsFechaStringNull();
             }
	        }
        public String SelloFiscal {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["SelloFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].SelloFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].SelloFiscal = value;
               }
	          }
        public bool IsSelloFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsSelloFiscalNull();
             }
	        }
        public String NoCertificadoFiscal {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["NoCertificadoFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].NoCertificadoFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].NoCertificadoFiscal = value;
               }
	          }
        public bool IsNoCertificadoFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsNoCertificadoFiscalNull();
             }
	        }
        public String NoCertificadoPropio {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["NoCertificadoPropio"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].NoCertificadoPropio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].NoCertificadoPropio = value;
               }
	          }
        public bool IsNoCertificadoPropioNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsNoCertificadoPropioNull();
             }
	        }
        public DateTime FechaAutorizacion {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["FechaAutorizacion"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].FechaAutorizacion;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].FechaAutorizacion = value;
               }
	          }
        public bool IsFechaAutorizacionNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsFechaAutorizacionNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public Int32 NumeroDesde {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["NumeroDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].NumeroDesde;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].NumeroDesde = value;
               }
	          }
        public bool IsNumeroDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsNumeroDesdeNull();
             }
	        }
        public Int32 NumeroHasta {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["NumeroHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].NumeroHasta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].NumeroHasta = value;
               }
	          }
        public bool IsNumeroHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsNumeroHastaNull();
             }
	        }
        public String RfcProvCertif {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["RfcProvCertif"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].RfcProvCertif;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].RfcProvCertif = value;
               }
	          }
        public bool IsRfcProvCertifNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsRfcProvCertifNull();
             }
	        }
        public String Leyenda {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["Leyenda"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].Leyenda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].Leyenda = value;
               }
	          }
        public bool IsLeyendaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsLeyendaNull();
             }
	        }
        public String TipoProceso {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["TipoProceso"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].TipoProceso;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].TipoProceso = value;
               }
	          }
        public bool IsTipoProcesoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsTipoProcesoNull();
             }
	        }
        public String TipoComite {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["TipoComite"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].TipoComite;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].TipoComite = value;
               }
	          }
        public bool IsTipoComiteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsTipoComiteNull();
             }
	        }
        public Decimal idContabilidad {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["idContabilidad"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].idContabilidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].idContabilidad = value;
               }
	          }
        public bool IsidContabilidadNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsidContabilidadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosFiscalDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMovimientosFiscalDS );
     }
     public venMovimientosFiscalActionExchange() : base( "venMovimientosFiscal" ) {
     }

     public venMovimientosFiscalActionExchange(venMovimientosFiscalActionEnum.EnumvenMovimientosFiscalAction pAccion) : base(venMovimientosFiscalActionEnum.GetAccionvenMovimientosFiscalAction(pAccion)) {
     }

     public venMovimientosFiscalActionExchange(venMovimientosFiscalActionEnum.EnumvenMovimientosFiscalAction pAccion, VentasCommon.venMovimientosFiscalDS pdsParam) : base(venMovimientosFiscalActionEnum.GetAccionvenMovimientosFiscalAction(pAccion), pdsParam) {
     }

     public venMovimientosFiscalActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMovimientosFiscalDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMovimientosFiscalDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMovimientosFiscalDS)mParam;
	        }
     }
  }
}
