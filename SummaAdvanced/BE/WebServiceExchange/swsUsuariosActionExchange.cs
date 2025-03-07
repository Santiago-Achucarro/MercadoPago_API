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
    public class swsUsuariosActionExchange : Framework.Core.Exchange{

        public Boolean Todos {
            get {
                if(((WebServiceCommon.swsUsuariosDS)mParam).Principal[0]["Todos"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsUsuariosDS)mParam).Principal[0].Todos;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsUsuariosDS)mParam).Principal[0].Todos = value;
               }
	          }
        public bool IsTodosNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsUsuariosDS)mParam).Principal[0].IsTodosNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((WebServiceCommon.swsUsuariosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((WebServiceCommon.swsUsuariosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((WebServiceCommon.swsUsuariosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((WebServiceCommon.swsUsuariosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( WebServiceCommon.swsUsuariosDS );
     }
     public swsUsuariosActionExchange() : base( "swsUsuarios" ) {
     }

     public swsUsuariosActionExchange(swsUsuariosActionEnum.EnumswsUsuariosAction pAccion) : base(swsUsuariosActionEnum.GetAccionswsUsuariosAction(pAccion)) {
     }

     public swsUsuariosActionExchange(swsUsuariosActionEnum.EnumswsUsuariosAction pAccion, WebServiceCommon.swsUsuariosDS pdsParam) : base(swsUsuariosActionEnum.GetAccionswsUsuariosAction(pAccion), pdsParam) {
     }

     public swsUsuariosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new WebServiceCommon.swsUsuariosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public WebServiceCommon.swsUsuariosDS Param{
	        get{
			    InitParam();
			    return (WebServiceCommon.swsUsuariosDS)mParam;
	        }
     }
  }
}
