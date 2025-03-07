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
    public class comSubirXmlDesdeCarpetaActionExchange : Framework.Core.Exchange{

        public String Upload {
            get {
                if(((ComprasCommon.comSubirXmlDesdeCarpetaDS)mParam).Principal[0]["Upload"] != DBNull.Value  ){
                    return ((ComprasCommon.comSubirXmlDesdeCarpetaDS)mParam).Principal[0].Upload;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSubirXmlDesdeCarpetaDS)mParam).Principal[0].Upload = value;
               }
	          }
        public bool IsUploadNull {
             get {
                 return mParam==null || ((ComprasCommon.comSubirXmlDesdeCarpetaDS)mParam).Principal[0].IsUploadNull();
             }
	        }
        public String TipoArchivo {
            get {
                if(((ComprasCommon.comSubirXmlDesdeCarpetaDS)mParam).Principal[0]["TipoArchivo"] != DBNull.Value  ){
                    return ((ComprasCommon.comSubirXmlDesdeCarpetaDS)mParam).Principal[0].TipoArchivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSubirXmlDesdeCarpetaDS)mParam).Principal[0].TipoArchivo = value;
               }
	          }
        public bool IsTipoArchivoNull {
             get {
                 return mParam==null || ((ComprasCommon.comSubirXmlDesdeCarpetaDS)mParam).Principal[0].IsTipoArchivoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comSubirXmlDesdeCarpetaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comSubirXmlDesdeCarpetaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comSubirXmlDesdeCarpetaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comSubirXmlDesdeCarpetaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comSubirXmlDesdeCarpetaDS );
     }
     public comSubirXmlDesdeCarpetaActionExchange() : base( "comSubirXmlDesdeCarpeta" ) {
     }

     public comSubirXmlDesdeCarpetaActionExchange(comSubirXmlDesdeCarpetaActionEnum.EnumcomSubirXmlDesdeCarpetaAction pAccion) : base(comSubirXmlDesdeCarpetaActionEnum.GetAccioncomSubirXmlDesdeCarpetaAction(pAccion)) {
     }

     public comSubirXmlDesdeCarpetaActionExchange(comSubirXmlDesdeCarpetaActionEnum.EnumcomSubirXmlDesdeCarpetaAction pAccion, ComprasCommon.comSubirXmlDesdeCarpetaDS pdsParam) : base(comSubirXmlDesdeCarpetaActionEnum.GetAccioncomSubirXmlDesdeCarpetaAction(pAccion), pdsParam) {
     }

     public comSubirXmlDesdeCarpetaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comSubirXmlDesdeCarpetaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comSubirXmlDesdeCarpetaDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comSubirXmlDesdeCarpetaDS)mParam;
	        }
     }
  }
}
