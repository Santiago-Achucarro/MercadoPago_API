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
    public class genCertificadosFeArActionExchange : Framework.Core.Exchange{

        public String GENWSAAPRIVATEKEY {
            get {
                if(((GeneralesCommon.genCertificadosFeArDS)mParam).Principal[0]["GENWSAAPRIVATEKEY"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosFeArDS)mParam).Principal[0].GENWSAAPRIVATEKEY;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosFeArDS)mParam).Principal[0].GENWSAAPRIVATEKEY = value;
               }
	          }
        public bool IsGENWSAAPRIVATEKEYNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosFeArDS)mParam).Principal[0].IsGENWSAAPRIVATEKEYNull();
             }
	        }
        public String GENWSAAPUBLICKEY {
            get {
                if(((GeneralesCommon.genCertificadosFeArDS)mParam).Principal[0]["GENWSAAPUBLICKEY"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosFeArDS)mParam).Principal[0].GENWSAAPUBLICKEY;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosFeArDS)mParam).Principal[0].GENWSAAPUBLICKEY = value;
               }
	          }
        public bool IsGENWSAAPUBLICKEYNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosFeArDS)mParam).Principal[0].IsGENWSAAPUBLICKEYNull();
             }
	        }
        public String EMPDIRPDFFACT {
            get {
                if(((GeneralesCommon.genCertificadosFeArDS)mParam).Principal[0]["EMPDIRPDFFACT"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosFeArDS)mParam).Principal[0].EMPDIRPDFFACT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosFeArDS)mParam).Principal[0].EMPDIRPDFFACT = value;
               }
	          }
        public bool IsEMPDIRPDFFACTNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosFeArDS)mParam).Principal[0].IsEMPDIRPDFFACTNull();
             }
	        }
        public DateTime GENWSFECHAVENC {
            get {
                if(((GeneralesCommon.genCertificadosFeArDS)mParam).Principal[0]["GENWSFECHAVENC"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosFeArDS)mParam).Principal[0].GENWSFECHAVENC;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosFeArDS)mParam).Principal[0].GENWSFECHAVENC = value;
               }
	          }
        public bool IsGENWSFECHAVENCNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosFeArDS)mParam).Principal[0].IsGENWSFECHAVENCNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genCertificadosFeArDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCertificadosFeArDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCertificadosFeArDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCertificadosFeArDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genCertificadosFeArDS );
     }
     public genCertificadosFeArActionExchange() : base( "genCertificadosFeAr" ) {
     }

     public genCertificadosFeArActionExchange(genCertificadosFeArActionEnum.EnumgenCertificadosFeArAction pAccion) : base(genCertificadosFeArActionEnum.GetAcciongenCertificadosFeArAction(pAccion)) {
     }

     public genCertificadosFeArActionExchange(genCertificadosFeArActionEnum.EnumgenCertificadosFeArAction pAccion, GeneralesCommon.genCertificadosFeArDS pdsParam) : base(genCertificadosFeArActionEnum.GetAcciongenCertificadosFeArAction(pAccion), pdsParam) {
     }

     public genCertificadosFeArActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genCertificadosFeArDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genCertificadosFeArDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genCertificadosFeArDS)mParam;
	        }
     }
  }
}
