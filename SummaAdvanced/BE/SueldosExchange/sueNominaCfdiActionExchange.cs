using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace SueldosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class sueNominaCfdiActionExchange : Framework.Core.Exchange{

        public Int32 Folio {
            get {
                if(((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0]["Folio"] != DBNull.Value  ){
                    return ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].Folio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].Folio = value;
               }
	          }
        public bool IsFolioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].IsFolioNull();
             }
	        }
        public Int64 sueLiquidacion {
            get {
                if(((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0]["sueLiquidacion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].sueLiquidacion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].sueLiquidacion = value;
               }
	          }
        public bool IssueLiquidacionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].IssueLiquidacionNull();
             }
	        }
        public String DescripcionLiquidacion {
            get {
                if(((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0]["DescripcionLiquidacion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].DescripcionLiquidacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].DescripcionLiquidacion = value;
               }
	          }
        public bool IsDescripcionLiquidacionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].IsDescripcionLiquidacionNull();
             }
	        }
        public Int32 Legajo {
            get {
                if(((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public String Nombre {
            get {
                if(((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0]["Nombre"] != DBNull.Value  ){
                    return ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].Nombre;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].Nombre = value;
               }
	          }
        public bool IsNombreNull {
             get {
                 return mParam==null || ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].IsNombreNull();
             }
	        }
        public String SelloDigital {
            get {
                if(((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0]["SelloDigital"] != DBNull.Value  ){
                    return ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].SelloDigital;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].SelloDigital = value;
               }
	          }
        public bool IsSelloDigitalNull {
             get {
                 return mParam==null || ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].IsSelloDigitalNull();
             }
	        }
        public String Xml {
            get {
                if(((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0]["Xml"] != DBNull.Value  ){
                    return ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].Xml;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].Xml = value;
               }
	          }
        public bool IsXmlNull {
             get {
                 return mParam==null || ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].IsXmlNull();
             }
	        }
        public String NoCertificado {
            get {
                if(((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0]["NoCertificado"] != DBNull.Value  ){
                    return ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].NoCertificado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].NoCertificado = value;
               }
	          }
        public bool IsNoCertificadoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].IsNoCertificadoNull();
             }
	        }
        public String UUID {
            get {
                if(((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0]["UUID"] != DBNull.Value  ){
                    return ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].UUID;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].UUID = value;
               }
	          }
        public bool IsUUIDNull {
             get {
                 return mParam==null || ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].IsUUIDNull();
             }
	        }
        public String FechaTimbrado {
            get {
                if(((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0]["FechaTimbrado"] != DBNull.Value  ){
                    return ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].FechaTimbrado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].FechaTimbrado = value;
               }
	          }
        public bool IsFechaTimbradoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].IsFechaTimbradoNull();
             }
	        }
        public String SelloSat {
            get {
                if(((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0]["SelloSat"] != DBNull.Value  ){
                    return ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].SelloSat;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].SelloSat = value;
               }
	          }
        public bool IsSelloSatNull {
             get {
                 return mParam==null || ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].IsSelloSatNull();
             }
	        }
        public String noCertificadoSAT {
            get {
                if(((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0]["noCertificadoSAT"] != DBNull.Value  ){
                    return ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].noCertificadoSAT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].noCertificadoSAT = value;
               }
	          }
        public bool IsnoCertificadoSATNull {
             get {
                 return mParam==null || ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].IsnoCertificadoSATNull();
             }
	        }
        public String Fecha {
            get {
                if(((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].Fecha;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Boolean Anulada {
            get {
                if(((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0]["Anulada"] != DBNull.Value  ){
                    return ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].Anulada;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].Anulada = value;
               }
	          }
        public bool IsAnuladaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].IsAnuladaNull();
             }
	        }
        public String RfcProvCertif {
            get {
                if(((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0]["RfcProvCertif"] != DBNull.Value  ){
                    return ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].RfcProvCertif;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].RfcProvCertif = value;
               }
	          }
        public bool IsRfcProvCertifNull {
             get {
                 return mParam==null || ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].IsRfcProvCertifNull();
             }
	        }
        public String Leyenda {
            get {
                if(((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0]["Leyenda"] != DBNull.Value  ){
                    return ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].Leyenda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].Leyenda = value;
               }
	          }
        public bool IsLeyendaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].IsLeyendaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueNominaCfdiDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueNominaCfdiDS );
     }
     public sueNominaCfdiActionExchange() : base( "sueNominaCfdi" ) {
     }

     public sueNominaCfdiActionExchange(sueNominaCfdiActionEnum.EnumsueNominaCfdiAction pAccion) : base(sueNominaCfdiActionEnum.GetAccionsueNominaCfdiAction(pAccion)) {
     }

     public sueNominaCfdiActionExchange(sueNominaCfdiActionEnum.EnumsueNominaCfdiAction pAccion, SueldosCommon.sueNominaCfdiDS pdsParam) : base(sueNominaCfdiActionEnum.GetAccionsueNominaCfdiAction(pAccion), pdsParam) {
     }

     public sueNominaCfdiActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueNominaCfdiDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueNominaCfdiDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueNominaCfdiDS)mParam;
	        }
     }
  }
}
