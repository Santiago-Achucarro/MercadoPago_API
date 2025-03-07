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
    public class tesCFDICobranzaActionExchange : Framework.Core.Exchange{

        public Int32 tesCFDICobranza {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["tesCFDICobranza"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].tesCFDICobranza;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].tesCFDICobranza = value;
               }
	          }
        public bool IstesCFDICobranzaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IstesCFDICobranzaNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String SelloDigital {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["SelloDigital"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].SelloDigital;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].SelloDigital = value;
               }
	          }
        public bool IsSelloDigitalNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsSelloDigitalNull();
             }
	        }
        public String Xml {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["Xml"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Xml;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Xml = value;
               }
	          }
        public bool IsXmlNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsXmlNull();
             }
	        }
        public String Cadena {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["Cadena"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Cadena;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Cadena = value;
               }
	          }
        public bool IsCadenaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsCadenaNull();
             }
	        }
        public String NoCertificado {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["NoCertificado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].NoCertificado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].NoCertificado = value;
               }
	          }
        public bool IsNoCertificadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsNoCertificadoNull();
             }
	        }
        public String UUID {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["UUID"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].UUID;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].UUID = value;
               }
	          }
        public bool IsUUIDNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsUUIDNull();
             }
	        }
        public String FechaTimbrado {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["FechaTimbrado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].FechaTimbrado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].FechaTimbrado = value;
               }
	          }
        public bool IsFechaTimbradoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsFechaTimbradoNull();
             }
	        }
        public String SelloSat {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["SelloSat"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].SelloSat;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].SelloSat = value;
               }
	          }
        public bool IsSelloSatNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsSelloSatNull();
             }
	        }
        public String NoCertificadoSat {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["NoCertificadoSat"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].NoCertificadoSat;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].NoCertificadoSat = value;
               }
	          }
        public bool IsNoCertificadoSatNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsNoCertificadoSatNull();
             }
	        }
        public String RfcProvCertif {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["RfcProvCertif"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].RfcProvCertif;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].RfcProvCertif = value;
               }
	          }
        public bool IsRfcProvCertifNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsRfcProvCertifNull();
             }
	        }
        public String Leyenda {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["Leyenda"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Leyenda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Leyenda = value;
               }
	          }
        public bool IsLeyendaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsLeyendaNull();
             }
	        }
        public String Anulada {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["Anulada"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Anulada;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Anulada = value;
               }
	          }
        public bool IsAnuladaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsAnuladaNull();
             }
	        }
        public String Sucursal {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCFDICobranzaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesCFDICobranzaDS );
     }
     public tesCFDICobranzaActionExchange() : base( "tesCFDICobranza" ) {
     }

     public tesCFDICobranzaActionExchange(tesCFDICobranzaActionEnum.EnumtesCFDICobranzaAction pAccion) : base(tesCFDICobranzaActionEnum.GetAcciontesCFDICobranzaAction(pAccion)) {
     }

     public tesCFDICobranzaActionExchange(tesCFDICobranzaActionEnum.EnumtesCFDICobranzaAction pAccion, TesoreriaCommon.tesCFDICobranzaDS pdsParam) : base(tesCFDICobranzaActionEnum.GetAcciontesCFDICobranzaAction(pAccion), pdsParam) {
     }

     public tesCFDICobranzaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesCFDICobranzaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesCFDICobranzaDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesCFDICobranzaDS)mParam;
	        }
     }
  }
}
