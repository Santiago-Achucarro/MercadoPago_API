using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genCertificadosActionExchange : Framework.Core.Exchange{

        public String NoCertificado {
            get {
                if(((GeneralesCommon.genCertificadosDS)mParam).Principal[0]["NoCertificado"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].NoCertificado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].NoCertificado = value;
               }
	          }
        public bool IsNoCertificadoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].IsNoCertificadoNull();
             }
	        }
        public String GENWSAAPRIVATEKEY {
            get {
                if(((GeneralesCommon.genCertificadosDS)mParam).Principal[0]["GENWSAAPRIVATEKEY"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].GENWSAAPRIVATEKEY;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].GENWSAAPRIVATEKEY = value;
               }
	          }
        public bool IsGENWSAAPRIVATEKEYNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].IsGENWSAAPRIVATEKEYNull();
             }
	        }
        public String GENWSAAPUBLICKEY {
            get {
                if(((GeneralesCommon.genCertificadosDS)mParam).Principal[0]["GENWSAAPUBLICKEY"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].GENWSAAPUBLICKEY;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].GENWSAAPUBLICKEY = value;
               }
	          }
        public bool IsGENWSAAPUBLICKEYNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].IsGENWSAAPUBLICKEYNull();
             }
	        }
        public String ClavePubKey {
            get {
                if(((GeneralesCommon.genCertificadosDS)mParam).Principal[0]["ClavePubKey"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].ClavePubKey;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].ClavePubKey = value;
               }
	          }
        public bool IsClavePubKeyNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].IsClavePubKeyNull();
             }
	        }
        public String ArchivoKey {
            get {
                if(((GeneralesCommon.genCertificadosDS)mParam).Principal[0]["ArchivoKey"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].ArchivoKey;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].ArchivoKey = value;
               }
	          }
        public bool IsArchivoKeyNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].IsArchivoKeyNull();
             }
	        }
        public String ArchivoCer {
            get {
                if(((GeneralesCommon.genCertificadosDS)mParam).Principal[0]["ArchivoCer"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].ArchivoCer;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].ArchivoCer = value;
               }
	          }
        public bool IsArchivoCerNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].IsArchivoCerNull();
             }
	        }
        public String VENPAC {
            get {
                if(((GeneralesCommon.genCertificadosDS)mParam).Principal[0]["VENPAC"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].VENPAC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].VENPAC = value;
               }
	          }
        public bool IsVENPACNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].IsVENPACNull();
             }
	        }
        public String VENCLAVEPAC {
            get {
                if(((GeneralesCommon.genCertificadosDS)mParam).Principal[0]["VENCLAVEPAC"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].VENCLAVEPAC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].VENCLAVEPAC = value;
               }
	          }
        public bool IsVENCLAVEPACNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].IsVENCLAVEPACNull();
             }
	        }
        public String VENUSUARIOPAC {
            get {
                if(((GeneralesCommon.genCertificadosDS)mParam).Principal[0]["VENUSUARIOPAC"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].VENUSUARIOPAC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].VENUSUARIOPAC = value;
               }
	          }
        public bool IsVENUSUARIOPACNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].IsVENUSUARIOPACNull();
             }
	        }
        public String VENCLAVEPACCANC {
            get {
                if(((GeneralesCommon.genCertificadosDS)mParam).Principal[0]["VENCLAVEPACCANC"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].VENCLAVEPACCANC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].VENCLAVEPACCANC = value;
               }
	          }
        public bool IsVENCLAVEPACCANCNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].IsVENCLAVEPACCANCNull();
             }
	        }
        public String VENUSUARIOPACANC {
            get {
                if(((GeneralesCommon.genCertificadosDS)mParam).Principal[0]["VENUSUARIOPACANC"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].VENUSUARIOPACANC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].VENUSUARIOPACANC = value;
               }
	          }
        public bool IsVENUSUARIOPACANCNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].IsVENUSUARIOPACANCNull();
             }
	        }
        public String EMPDIRPDFFACT {
            get {
                if(((GeneralesCommon.genCertificadosDS)mParam).Principal[0]["EMPDIRPDFFACT"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].EMPDIRPDFFACT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].EMPDIRPDFFACT = value;
               }
	          }
        public bool IsEMPDIRPDFFACTNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].IsEMPDIRPDFFACTNull();
             }
	        }
        public Boolean VENLLAMAPAC {
            get {
                if(((GeneralesCommon.genCertificadosDS)mParam).Principal[0]["VENLLAMAPAC"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].VENLLAMAPAC;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].VENLLAMAPAC = value;
               }
	          }
        public bool IsVENLLAMAPACNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].IsVENLLAMAPACNull();
             }
	        }
        public String CLAVEPRIVATEKEY {
            get {
                if(((GeneralesCommon.genCertificadosDS)mParam).Principal[0]["CLAVEPRIVATEKEY"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].CLAVEPRIVATEKEY;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].CLAVEPRIVATEKEY = value;
               }
	          }
        public bool IsCLAVEPRIVATEKEYNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].IsCLAVEPRIVATEKEYNull();
             }
	        }
        public String VENCLAPFXCANC {
            get {
                if(((GeneralesCommon.genCertificadosDS)mParam).Principal[0]["VENCLAPFXCANC"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].VENCLAPFXCANC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].VENCLAPFXCANC = value;
               }
	          }
        public bool IsVENCLAPFXCANCNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].IsVENCLAPFXCANCNull();
             }
	        }
        public Boolean VENCANCCONTRA {
            get {
                if(((GeneralesCommon.genCertificadosDS)mParam).Principal[0]["VENCANCCONTRA"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].VENCANCCONTRA;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].VENCANCCONTRA = value;
               }
	          }
        public bool IsVENCANCCONTRANull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].IsVENCANCCONTRANull();
             }
	        }
        public String GENVERSIONCFDI {
            get {
                if(((GeneralesCommon.genCertificadosDS)mParam).Principal[0]["GENVERSIONCFDI"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].GENVERSIONCFDI;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].GENVERSIONCFDI = value;
               }
	          }
        public bool IsGENVERSIONCFDINull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].IsGENVERSIONCFDINull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genCertificadosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genCertificadosDS );
     }
     public genCertificadosActionExchange() : base( "genCertificados" ) {
     }

     public genCertificadosActionExchange(genCertificadosActionEnum.EnumgenCertificadosAction pAccion) : base(genCertificadosActionEnum.GetAcciongenCertificadosAction(pAccion)) {
     }

     public genCertificadosActionExchange(genCertificadosActionEnum.EnumgenCertificadosAction pAccion, GeneralesCommon.genCertificadosDS pdsParam) : base(genCertificadosActionEnum.GetAcciongenCertificadosAction(pAccion), pdsParam) {
     }

     public genCertificadosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genCertificadosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public genCertificadosActionExchange(GeneralesCommon.genCertificadosDS pDS) : base() {
     this.Action = "";
     this.mParam = new GeneralesCommon.genCertificadosDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genCertificadosDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genCertificadosDS)mParam;
	        }
     }
  }
}
