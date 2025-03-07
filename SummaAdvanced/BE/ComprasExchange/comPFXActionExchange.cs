using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ComprasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class comPFXActionExchange : Framework.Core.Exchange{

        public String ArchivoPFX {
            get {
                if(((ComprasCommon.comPFXDS)mParam).Principal[0]["ArchivoPFX"] != DBNull.Value  ){
                    return ((ComprasCommon.comPFXDS)mParam).Principal[0].ArchivoPFX;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPFXDS)mParam).Principal[0].ArchivoPFX = value;
               }
	          }
        public bool IsArchivoPFXNull {
             get {
                 return mParam==null || ((ComprasCommon.comPFXDS)mParam).Principal[0].IsArchivoPFXNull();
             }
	        }
        public String ClavePFX {
            get {
                if(((ComprasCommon.comPFXDS)mParam).Principal[0]["ClavePFX"] != DBNull.Value  ){
                    return ((ComprasCommon.comPFXDS)mParam).Principal[0].ClavePFX;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPFXDS)mParam).Principal[0].ClavePFX = value;
               }
	          }
        public bool IsClavePFXNull {
             get {
                 return mParam==null || ((ComprasCommon.comPFXDS)mParam).Principal[0].IsClavePFXNull();
             }
	        }
        public String UploadCer {
            get {
                if(((ComprasCommon.comPFXDS)mParam).Principal[0]["UploadCer"] != DBNull.Value  ){
                    return ((ComprasCommon.comPFXDS)mParam).Principal[0].UploadCer;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPFXDS)mParam).Principal[0].UploadCer = value;
               }
	          }
        public bool IsUploadCerNull {
             get {
                 return mParam==null || ((ComprasCommon.comPFXDS)mParam).Principal[0].IsUploadCerNull();
             }
	        }
        public String UploadKey {
            get {
                if(((ComprasCommon.comPFXDS)mParam).Principal[0]["UploadKey"] != DBNull.Value  ){
                    return ((ComprasCommon.comPFXDS)mParam).Principal[0].UploadKey;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPFXDS)mParam).Principal[0].UploadKey = value;
               }
	          }
        public bool IsUploadKeyNull {
             get {
                 return mParam==null || ((ComprasCommon.comPFXDS)mParam).Principal[0].IsUploadKeyNull();
             }
	        }
        public String ClaveKey {
            get {
                if(((ComprasCommon.comPFXDS)mParam).Principal[0]["ClaveKey"] != DBNull.Value  ){
                    return ((ComprasCommon.comPFXDS)mParam).Principal[0].ClaveKey;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPFXDS)mParam).Principal[0].ClaveKey = value;
               }
	          }
        public bool IsClaveKeyNull {
             get {
                 return mParam==null || ((ComprasCommon.comPFXDS)mParam).Principal[0].IsClaveKeyNull();
             }
	        }
        public Boolean EsCSD {
            get {
                if(((ComprasCommon.comPFXDS)mParam).Principal[0]["EsCSD"] != DBNull.Value  ){
                    return ((ComprasCommon.comPFXDS)mParam).Principal[0].EsCSD;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPFXDS)mParam).Principal[0].EsCSD = value;
               }
	          }
        public bool IsEsCSDNull {
             get {
                 return mParam==null || ((ComprasCommon.comPFXDS)mParam).Principal[0].IsEsCSDNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comPFXDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comPFXDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comPFXDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comPFXDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comPFXDS );
     }
     public comPFXActionExchange() : base( "comPFX" ) {
     }

     public comPFXActionExchange(comPFXActionEnum.EnumcomPFXAction pAccion) : base(comPFXActionEnum.GetAccioncomPFXAction(pAccion)) {
     }

     public comPFXActionExchange(comPFXActionEnum.EnumcomPFXAction pAccion, ComprasCommon.comPFXDS pdsParam) : base(comPFXActionEnum.GetAccioncomPFXAction(pAccion), pdsParam) {
     }

     public comPFXActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comPFXDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comPFXDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comPFXDS)mParam;
	        }
     }
  }
}
