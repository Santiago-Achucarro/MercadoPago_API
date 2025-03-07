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
    public class genAlertasUsuarioActionExchange : Framework.Core.Exchange{

        public Int32 Usuario_id {
            get {
                if(((GeneralesCommon.genAlertasUsuarioDS)mParam).Principal[0]["Usuario_id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAlertasUsuarioDS)mParam).Principal[0].Usuario_id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAlertasUsuarioDS)mParam).Principal[0].Usuario_id = value;
               }
	          }
        public bool IsUsuario_idNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAlertasUsuarioDS)mParam).Principal[0].IsUsuario_idNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genAlertasUsuarioDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAlertasUsuarioDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAlertasUsuarioDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAlertasUsuarioDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genAlertasUsuarioDS );
     }
     public genAlertasUsuarioActionExchange() : base( "genAlertasUsuario" ) {
     }

     public genAlertasUsuarioActionExchange(genAlertasUsuarioActionEnum.EnumgenAlertasUsuarioAction pAccion) : base(genAlertasUsuarioActionEnum.GetAcciongenAlertasUsuarioAction(pAccion)) {
     }

     public genAlertasUsuarioActionExchange(genAlertasUsuarioActionEnum.EnumgenAlertasUsuarioAction pAccion, GeneralesCommon.genAlertasUsuarioDS pdsParam) : base(genAlertasUsuarioActionEnum.GetAcciongenAlertasUsuarioAction(pAccion), pdsParam) {
     }

     public genAlertasUsuarioActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genAlertasUsuarioDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genAlertasUsuarioDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genAlertasUsuarioDS)mParam;
	        }
     }
  }
}
