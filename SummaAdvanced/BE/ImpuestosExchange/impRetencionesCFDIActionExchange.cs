using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ImpuestosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class impRetencionesCFDIActionExchange : Framework.Core.Exchange{

        public Int32 impRetencionesCFDI {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["impRetencionesCFDI"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].impRetencionesCFDI;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].impRetencionesCFDI = value;
               }
	          }
        public bool IsimpRetencionesCFDINull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsimpRetencionesCFDINull();
             }
	        }
        public Int32 Folio {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["Folio"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].Folio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].Folio = value;
               }
	          }
        public bool IsFolioNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsFolioNull();
             }
	        }
        public String Sello {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["Sello"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].Sello;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].Sello = value;
               }
	          }
        public bool IsSelloNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsSelloNull();
             }
	        }
        public String NumCert {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["NumCert"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].NumCert;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].NumCert = value;
               }
	          }
        public bool IsNumCertNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsNumCertNull();
             }
	        }
        public DateTime FechaExp {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["FechaExp"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].FechaExp;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].FechaExp = value;
               }
	          }
        public bool IsFechaExpNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsFechaExpNull();
             }
	        }
        public String CveRetenc {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["CveRetenc"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].CveRetenc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].CveRetenc = value;
               }
	          }
        public bool IsCveRetencNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsCveRetencNull();
             }
	        }
        public String DescRetenc {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["DescRetenc"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].DescRetenc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].DescRetenc = value;
               }
	          }
        public bool IsDescRetencNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsDescRetencNull();
             }
	        }
        public String Nacionalidad {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["Nacionalidad"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].Nacionalidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].Nacionalidad = value;
               }
	          }
        public bool IsNacionalidadNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsNacionalidadNull();
             }
	        }
        public String RFC {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["RFC"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].RFC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].RFC = value;
               }
	          }
        public bool IsRFCNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsRFCNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String CURP {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["CURP"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].CURP;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].CURP = value;
               }
	          }
        public bool IsCURPNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsCURPNull();
             }
	        }
        public String NroRegIdTrib {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["NroRegIdTrib"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].NroRegIdTrib;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].NroRegIdTrib = value;
               }
	          }
        public bool IsNroRegIdTribNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsNroRegIdTribNull();
             }
	        }
        public Int32 Ejercicio {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["Ejercicio"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].Ejercicio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].Ejercicio = value;
               }
	          }
        public bool IsEjercicioNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsEjercicioNull();
             }
	        }
        public Int16 MesIni {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["MesIni"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].MesIni;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].MesIni = value;
               }
	          }
        public bool IsMesIniNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsMesIniNull();
             }
	        }
        public Int16 MesFin {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["MesFin"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].MesFin;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].MesFin = value;
               }
	          }
        public bool IsMesFinNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsMesFinNull();
             }
	        }
        public Decimal montoTotOperacion {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["montoTotOperacion"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].montoTotOperacion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].montoTotOperacion = value;
               }
	          }
        public bool IsmontoTotOperacionNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsmontoTotOperacionNull();
             }
	        }
        public Decimal montoTotGrav {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["montoTotGrav"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].montoTotGrav;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].montoTotGrav = value;
               }
	          }
        public bool IsmontoTotGravNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsmontoTotGravNull();
             }
	        }
        public Decimal montoTotExent {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["montoTotExent"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].montoTotExent;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].montoTotExent = value;
               }
	          }
        public bool IsmontoTotExentNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsmontoTotExentNull();
             }
	        }
        public Decimal montoTotRet {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["montoTotRet"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].montoTotRet;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].montoTotRet = value;
               }
	          }
        public bool IsmontoTotRetNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsmontoTotRetNull();
             }
	        }
        public Boolean Cancelado {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["Cancelado"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].Cancelado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].Cancelado = value;
               }
	          }
        public bool IsCanceladoNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsCanceladoNull();
             }
	        }
        public DateTime FechaCancelacion {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["FechaCancelacion"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].FechaCancelacion;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].FechaCancelacion = value;
               }
	          }
        public bool IsFechaCancelacionNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsFechaCancelacionNull();
             }
	        }
        public String FechaTimbre {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["FechaTimbre"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].FechaTimbre;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].FechaTimbre = value;
               }
	          }
        public bool IsFechaTimbreNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsFechaTimbreNull();
             }
	        }
        public String SelloSAT {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["SelloSAT"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].SelloSAT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].SelloSAT = value;
               }
	          }
        public bool IsSelloSATNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsSelloSATNull();
             }
	        }
        public String NoCertificadoSAT {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["NoCertificadoSAT"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].NoCertificadoSAT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].NoCertificadoSAT = value;
               }
	          }
        public bool IsNoCertificadoSATNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsNoCertificadoSATNull();
             }
	        }
        public String UUID {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["UUID"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].UUID;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].UUID = value;
               }
	          }
        public bool IsUUIDNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsUUIDNull();
             }
	        }
        public String RfcProvCertif {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["RfcProvCertif"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].RfcProvCertif;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].RfcProvCertif = value;
               }
	          }
        public bool IsRfcProvCertifNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsRfcProvCertifNull();
             }
	        }
        public String Leyenda {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["Leyenda"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].Leyenda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].Leyenda = value;
               }
	          }
        public bool IsLeyendaNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsLeyendaNull();
             }
	        }
        public String Xml {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["Xml"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].Xml;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].Xml = value;
               }
	          }
        public bool IsXmlNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsXmlNull();
             }
	        }
        public String CodPostal {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["CodPostal"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].CodPostal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].CodPostal = value;
               }
	          }
        public bool IsCodPostalNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsCodPostalNull();
             }
	        }
        public Decimal UtilidadBimestral {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["UtilidadBimestral"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].UtilidadBimestral;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].UtilidadBimestral = value;
               }
	          }
        public bool IsUtilidadBimestralNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsUtilidadBimestralNull();
             }
	        }
        public Decimal ISRCorrespondiente {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["ISRCorrespondiente"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].ISRCorrespondiente;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].ISRCorrespondiente = value;
               }
	          }
        public bool IsISRCorrespondienteNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsISRCorrespondienteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetencionesCFDIDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ImpuestosCommon.impRetencionesCFDIDS );
     }
     public impRetencionesCFDIActionExchange() : base( "impRetencionesCFDI" ) {
     }

     public impRetencionesCFDIActionExchange(impRetencionesCFDIActionEnum.EnumimpRetencionesCFDIAction pAccion) : base(impRetencionesCFDIActionEnum.GetAccionimpRetencionesCFDIAction(pAccion)) {
     }

     public impRetencionesCFDIActionExchange(impRetencionesCFDIActionEnum.EnumimpRetencionesCFDIAction pAccion, ImpuestosCommon.impRetencionesCFDIDS pdsParam) : base(impRetencionesCFDIActionEnum.GetAccionimpRetencionesCFDIAction(pAccion), pdsParam) {
     }

     public impRetencionesCFDIActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ImpuestosCommon.impRetencionesCFDIDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public impRetencionesCFDIActionExchange(ImpuestosCommon.impRetencionesCFDIDS pDS) : base() {
     this.Action = "";
     this.mParam = new ImpuestosCommon.impRetencionesCFDIDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ImpuestosCommon.impRetencionesCFDIDS Param{
	        get{
			    InitParam();
			    return (ImpuestosCommon.impRetencionesCFDIDS)mParam;
	        }
     }
  }
}
