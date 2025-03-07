using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace WebServiceExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class swsPermisosActionExchange : Framework.Core.Exchange{

        public String Usuario_Id {
            get {
                if(((WebServiceCommon.swsPermisosDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsPermisosDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsPermisosDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsPermisosDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String Apellido_y_Nombres {
            get {
                if(((WebServiceCommon.swsPermisosDS)mParam).Principal[0]["Apellido_y_Nombres"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsPermisosDS)mParam).Principal[0].Apellido_y_Nombres;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsPermisosDS)mParam).Principal[0].Apellido_y_Nombres = value;
               }
	          }
        public bool IsApellido_y_NombresNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsPermisosDS)mParam).Principal[0].IsApellido_y_NombresNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((WebServiceCommon.swsPermisosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsPermisosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsPermisosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsPermisosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( WebServiceCommon.swsPermisosDS );
     }
     public swsPermisosActionExchange() : base( "swsPermisos" ) {
     }

     public swsPermisosActionExchange(swsPermisosActionEnum.EnumswsPermisosAction pAccion) : base(swsPermisosActionEnum.GetAccionswsPermisosAction(pAccion)) {
     }

     public swsPermisosActionExchange(swsPermisosActionEnum.EnumswsPermisosAction pAccion, WebServiceCommon.swsPermisosDS pdsParam) : base(swsPermisosActionEnum.GetAccionswsPermisosAction(pAccion), pdsParam) {
     }

     public swsPermisosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new WebServiceCommon.swsPermisosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public WebServiceCommon.swsPermisosDS Param{
	        get{
			    InitParam();
			    return (WebServiceCommon.swsPermisosDS)mParam;
	        }
     }
  }
}
